---
title: Performance Tips for JNet
_description: Describes some tips about performance of the .NET suite for Java™/JVM™
---

# JNet performance tips

This article covers performance tips for JNet, explains the reasons behind each recommendation, and provides benchmarks to help you decide when to apply them.

## Reduce CLR-JVM™ boundary invocations

The library optimizes boundary invocations where possible, but you should avoid excessive
method calls across the CLR-JVM™ boundary when performance is a concern.
Consider the following code (available in the __tests__ folder):

```csharp
const int execution = 10000;
Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>();
for (int i = 0; i < execution; i++)
{
    alist.Add(i);
}
```

This code creates a `Java.Util.ArrayList<int>` and fills it in a loop, crossing the CLR-JVM™ boundary on every `Add` call. The cumulative cost of those boundary crossings can be significant
when performance matters.

### JNet helper class

The specific example above can be optimized using `JNetHelper`, which builds a `java.util.List`
of primitive types from a CLR primitive array in a single boundary-efficient operation.

#### Array transfer

The optimized approach uses `JNetHelper.ListFrom` to transfer the entire array at once:

```csharp
const int execution = 10000;
int[] tmpArray = new int[execution];
var tmpJList = JNetHelper.ListFrom(tmpArray);
Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>(tmpJList);
```

This transfers the primitive array using only a few boundary invocations. The list is constructed
entirely within the JVM™ and then returned to the CLR.

#### Transfer via `java.nio.*Buffer`

The same result can be achieved using a
[`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html)
via other overloads of `JNetHelper.ListFrom`. This uses shared memory to move data from CLR to JVM™:

```csharp
const int execution = 10000;
int[] tmpArray = new int[execution];
var intBuffer = IntBuffer.From(tmpArray, false, false);
var tmpJList = JNetHelper.ListFrom(intBuffer);
Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>(tmpJList);
```

or:

```csharp
const int execution = 10000;
int[] tmpArray = new int[execution];
var tmpJList = JNetHelper.ListFrom(tmpArray, true);
Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>(tmpJList);
```

The difference between the two is:
- In the first example, the `IntBuffer` is allocated explicitly and can be reused — for instance,
  refilled with different data and sent to the JVM™ again without creating a new buffer.
- In the second example, an `IntBuffer` is allocated internally by `JNetHelper.ListFrom` on each
  invocation.

### Performance comparison and tips

The JNetTest project (available in the __tests__ folder) measures timing across all approaches.
Using the loop-based example as a baseline:

- The `JNetHelper` array transfer approach is approximately **100× faster**.
- The `JNetHelper` `java.nio.*Buffer` approach can reach **140× faster**.
- Building a `System.Collections.Generic.List<int>` entirely in the CLR can be **1000× faster**.

> [!TIP]
> Three key principles follow from these results:
> - When possible, avoid invoking JVM™ methods from the CLR in a tight loop.
> - Collapse multiple boundary invocations into as few as possible — just as `JNetHelper` does.
> - If a task can be completed entirely in the CLR or entirely in the JVM™, keep it there until a
>   boundary crossing is strictly necessary.

## Batch JVM™ global reference releases

Each `Dispose` on a JNet object releases the underlying JVM™ global reference with a direct
native call. In isolation this cost is small, but in tight loops that create and dispose many
JNet objects — a Kafka consumer poll loop, a storage block enumeration, a sustained callback
stream — it accumulates into measurable overhead.

`JvmBatchDisposeFastScope` and `JvmBatchDisposeAsyncScope` address this by queuing release
requests and flushing them together in a single native call, keeping the per-object `Dispose`
call cost negligible. The loop body requires no changes.

> [!NOTE]
> Objects whose `Dispose` is not called explicitly (no `using` block) are eventually released
> by the .NET finalizer as before — batch scopes do not affect that path. The benefit applies
> only to explicit `Dispose` calls made while a scope is active.

### `JvmBatchDisposeFastScope` — synchronous hot paths

Use this scope for synchronous code on a controlled thread. It uses `[ThreadStatic]` storage,
which has negligible access cost compared to the native call it replaces.

```csharp
// Kafka consumer poll loop — sync
using var batch = new JvmBatchDisposeFastScope();
while (!resetEvent.WaitOne(0))
{
    using var records = consumer.Poll(200);
    foreach (var record in records)
    {
        using (record)
        {
            Console.WriteLine($"Offset={record.Offset()}, Key={record.Key()}");
        }
        // record.Dispose() queues the release — no native call here
    }
    // records.Dispose() queues the release — no native call here
}
// scope exits: all queued releases flushed in a single native call
```

Automatic mid-loop flushing occurs when the queue reaches the configured limit (default: 64
references). This bounds memory usage regardless of how long the loop runs.

> [!WARNING]
> `JvmBatchDisposeFastScope` is not safe across `await` — if a continuation resumes on a
> different thread the scope state will not be visible on the new thread. Use
> `JvmBatchDisposeAsyncScope` for async code.

### `JvmBatchDisposeAsyncScope` — async/await contexts

Use this scope when continuations may resume on a different thread. The scope state flows
automatically across `await` points.

On .NET 8 and later `JvmBatchDisposeAsyncScope` implements `IAsyncDisposable`, enabling
`await using` and an asynchronous flush on scope exit:

```csharp
// Async enumeration — .NET 8 / 9 / 10
await using var batch = new JvmBatchDisposeAsyncScope();
await foreach (var item in asyncJvmCollection)
{
    using (item)
    {
        await ProcessAsync(item);
    }
    // item.Dispose() queues the release — no native call here
}
// scope exits: queued releases flushed asynchronously
```

On .NET Framework `IAsyncDisposable` is not available — use a standard `using` block instead,
the flush on scope exit is synchronous:

```csharp
// .NET Framework
using (var batch = new JvmBatchDisposeAsyncScope())
{
    foreach (var item in jvmCollection)
    {
        using (item) { /* item disposal is batched */ }
    }
} // scope exits: queued releases flushed synchronously
```

> [!NOTE]
> `JvmBatchDisposeAsyncScope` has slightly higher per-access cost than `JvmBatchDisposeFastScope`
> due to the `ExecutionContext` propagation required for async safety. For synchronous hot paths
> where throughput matters, prefer `JvmBatchDisposeFastScope`.

### Nesting scopes

Both scope types support nesting. When scopes are nested — for example because library-internal
code opens its own scope inside a user-opened scope — the inner scope increments a depth counter
and the flush is deferred until the outermost scope exits. This means library code and user code
can independently opt in to batching without coordination.

```csharp
using var outerBatch = new JvmBatchDisposeFastScope();
// library method internally opens its own JvmBatchDisposeFastScope — depth = 2
DoSomethingThatUsesABatchScopeInternally();
// inner scope exits — depth returns to 1, no flush yet
// outer scope exits — depth reaches 0, flush occurs here
```

### When to use batch scopes

Batch scopes provide meaningful gains when `Dispose` calls are frequent relative to other work
in the loop. Typical candidates:

- Kafka consumer poll loops iterating over many records per poll.
- Storage block enumerations where each entry wraps one or more JVM™ objects.
- Callback handlers that receive high-frequency JVM-originated events carrying JVM™ object arguments.

For loops where the per-item operation is expensive (multiple JVM™ method calls, I/O, computation),
the `Dispose` cost is already a small fraction of the total and a batch scope will not produce
a measurable difference.

> [!TIP]
> Open the scope as close to the loop as possible — not at application startup — to limit the
> window in which references are queued rather than immediately released.

## Discard unwanted JVM™ events early with `ShallManageEvent`

When a JVM™ class fires events toward the CLR — for example an AWT component, a Kafka Streams functional interface, or any JNet callback wrapper — the standard flow reads argument data from the JVM™ before invoking the registered handler. For sources that produce many event types, most of them may have no handler registered in the application. Reading and converting argument data for events that will be immediately discarded is wasted work.

JCOBridge 2.6.7+ introduces a two-level filter applied before full event handling, through two overloads of `ShallManageEvent` on the JNet callback base class.

### First gate — `bool ShallManageEvent(string eventName)`

Called before any argument data is read from the JVM. Receives only the event name. Return `false` to discard immediately (no data read, handler not invoked); return `true` to proceed to the second gate.

### Second gate — `bool ShallManageEvent(string eventName, object data)`

Called after raw argument data is available, but before full argument conversion and handler dispatch. Allows a lightweight inspection of the raw payload — for example checking a type field or a numeric threshold — without paying the cost of full processing. Return `false` to discard after inspection (handler not invoked); return `true` to proceed with full conversion and handler invocation.

The `ShallManageEventHandler` (`Func<string, bool>`) delegate is the assignable equivalent of the first gate; `ShallManageEventWithDataHandler` (`Func<string, object, bool>`) is the assignable equivalent of the second gate.

> [!NOTE]
> The combination "first gate returns `false`, second gate returns `true`" is never reached — if the first gate discards, the second gate is not called.

Default for both gates is `true` (full processing). Both overloads are available from JCOBridge 2.6.7+.

### Usage

Override both gates on a callback subclass:

```csharp
public class MyActionListener : Java.Awt.Event.ActionListener
{
    protected override bool ShallManageEvent(string eventName)
    {
        // first gate: filter by event name alone, no data read yet
        return eventName == "actionPerformed";
    }

    protected override bool ShallManageEvent(string eventName, object data)
    {
        // second gate: raw data available — inspect before committing to full processing
        // e.g. check a source identifier in the raw payload
        return data is Java.Awt.Event.ActionEvent ae && ae.GetSource() is MyButton;
    }

    public override void ActionPerformed(Java.Awt.Event.ActionEvent e)
    {
        // full handling — only reached when both gates return true
    }
}
```

Or assign either gate via delegates without subclassing:

```csharp
var listener = new Java.Awt.Event.ActionListener();
// first gate — filter by name, no data read
listener.ShallManageEventHandler = eventName => eventName == "actionPerformed";
// second gate — inspect raw data before full processing
listener.ShallManageEventWithDataHandler = (eventName, data) => data is Java.Awt.Event.ActionEvent;
listener.ActionPerformed += e => { /* handle */ };
```

### Performance impact

The cost per event at each gate, measured in a sustained JVM-originated stream on a GitHub Actions runner (2.6.7+, 1 000 000 iterations):

| Gate | `byIndex` | .NET 8 / T17 | .NET 10 / T25 | Events/sec (.NET 10) |
|---|---|---|---|---|
| First gate discard (no data read) | `false` | 0.601 µs | 0.468 µs | ~2.1 M |
| First gate discard (no data read) | `true` | **0.045 µs** | **0.041 µs** | **~24 M** |
| Second gate discard (raw data inspected) | `false` | 0.625 µs | 0.493 µs | ~2.0 M |
| Second gate discard (raw data inspected) | `true` | **0.074 µs** | **0.067 µs** | **~15 M** |
| Full processing | `false` | 5.098 µs | 4.725 µs | ~212 K |
| Full processing | `true` | 4.467 µs | 4.141 µs | ~242 K |

With `byIndex = true` and first-gate discard, the per-event cost (~41–45 ns) is within the range of raw JNI overhead measured on dedicated bare-metal hardware — despite running on a shared CI runner and crossing the JVM↔CLR boundary. The second gate adds ~25–30 ns for the raw data availability step, still roughly 70× cheaper than full processing.

See [performance](performance.md) for the complete benchmark data.

> [!TIP]
> Use the first gate (`ShallManageEvent(string)`) to filter by event name alone — this is the cheapest path and sufficient for most use cases. Use the second gate (`ShallManageEvent(string, object)`) only when the decision depends on a lightweight check of the raw payload that is not worth deferring to the full handler.

> [!TIP]
> Apply these filters whenever a JVM™ source fires multiple event types and only a subset have registered handlers. Typical candidates: AWT/Swing components with many listener methods, Kafka Streams topologies with mixed functional interfaces, and any JVM™ observable that emits high-frequency events of heterogeneous types.

> [!NOTE]
> Both `ShallManageEvent` overloads are available from JCOBridge 2.6.7+. On earlier versions all events follow the full data-read path regardless of whether a handler is registered.

## Memory transfer at CLR-JVM™ boundary

JNet provides APIs to manage data exchange at the CLR-JVM™ boundary using
[`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html).

The [section above](#JNet-helper-class-based-on-java.nio.*Buffer) shows one use of these APIs
via `JNetHelper`. However, `java.nio.ByteBuffer` can be constructed directly from many CLR input types:

- An `IntPtr` — a native memory pointer, e.g. from COM, unmanaged allocations, or interop scenarios.
- A `System.IO.MemoryStream` — e.g. the output of a JSON serialization step.
- An array of primitive types (`byte`, `short`, `int`, `long`, and so on) — e.g. data read from
  disk or a network socket.

Without `ByteBuffer`, transferring a `System.IO.MemoryStream` to the JVM™ involves multiple copies:

1. Extract the data from `System.IO.MemoryStream` into a `byte[]` in the CLR.
2. Allocate the `byte[]` and copy the stream content into it.
3. Transfer the `byte[]` to the JVM™, which requires:
   - a. Allocating a new array in the JVM™ of the same length.
   - b. Copying the memory from CLR to JVM™.
4. Depending on the JVM™ implementation, step 3b may involve an additional temporary copy at the
   JNI boundary.
5. The JVM™ can then use the data.

With `ByteBuffer`, the same transfer becomes:

1. A `ByteBuffer` is created directly from the `System.IO.MemoryStream` — no copy yet.
2. The `ByteBuffer` reference is passed to the JVM™ — the memory is not moved.
3. The JVM™ accesses the CLR memory directly using
   [`get()`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html#get())
   or
   [`get(int index)`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html#get(int)).

> [!IMPORTANT]
> If the JVM™ code needs a `byte[]`, prefer
> [`get(byte[] dst, int offset, int length)`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html#get(byte%5B%5D,int,int))
> over
> [`get(byte[] dst)`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html#get(byte%5B%5D)):
> the former copies in blocks, while the latter copies byte-by-byte.

### The impact of array creation

Whether data arrives via JNI array transfer or `java.nio.ByteBuffer`, if the receiving side needs
to allocate a new primitive array, both the JVM™ and the CLR are heavily impacted by the
allocation and subsequent garbage collection of that array.

> [!NOTE]
> The allocation cost is the same regardless of whether the array originates from a JNI boundary
> transfer or from a `java.nio.ByteBuffer` read.

The JNetByteBufferTest project (available in the __tests__ folder) benchmarks the following cases:

1. Transfer using a `byte[]` — used as the baseline.
2. Transfer using `java.nio.ByteBuffer`, allocating a **new** `byte[]` on each read.
3. Transfer using `java.nio.ByteBuffer`, **reusing** a previously allocated `byte[]` on each read.
4. Transfer using `java.nio.ByteBuffer` **without reading** the data — measures pure pointer transfer.

Tests run in both directions (CLR → JVM™ and JVM™ → CLR), repeated many times across different
array lengths. Key findings:

- **Cases 1 and 2**: raw `byte[]` outperforms `java.nio.ByteBuffer` for small arrays in both
  directions, because the cost of allocating a new `byte[]` on each read offsets the transfer savings.

- **Case 3**: reusing the pre-allocated `byte[]` gives a **4–5× improvement** over `byte[]`
  transfer in most scenarios. For very small payloads transferred from JVM™ to CLR, `byte[]` still
  edges ahead.

- **Case 4**: not directly comparable to the others — useful for measuring the cost of the
  `ByteBuffer` pointer handoff itself, with no data read overhead.

> [!TIP]
> If your code only needs sparse or indexed access to transferred memory, use `java.nio.ByteBuffer`
> and read individual elements via `get(int index)` — no array allocation, no memory copy,
> maximum throughput.

### Performance and tips

Memory allocation is a key performance factor because both the JVM™ and the CLR must find,
track, and eventually garbage-collect every allocated array.

> [!TIP]
> Where possible, reuse previously allocated arrays rather than creating new ones on each
> iteration. This reduces allocation pressure on both the JVM™ GC and the CLR GC.

## Execute iterations in parallel

The [Performance comparison and tips](#Performance-comparison-and-tips) section recommends
minimizing CLR-JVM™ boundary crossings, and `JNetHelper` addresses this for primitives.
However, in many real-world scenarios you must iterate over non-primitive objects. To illustrate,
consider the following snippet:

```csharp
ArrayList<Java.Lang.String> alist = GetAnArrayListOfString();
foreach (Java.Lang.String item in alist)
{
    // EXPENSIVE OPERATION OVER item
}
```

With a standard iterator, the CLR requests the next `Java.Lang.String` via `Java.Lang.Iterable`,
executes the expensive operation, then requests the next item — the JVM™ is idle for the entire
duration of the operation. This means:

1. Each **EXPENSIVE OPERATION** must wait for the next item to be fetched from the JVM™.
2. While the **EXPENSIVE OPERATION** runs, the JVM™ sits idle.

The `WithPrefetch` extension method solves this by fetching the next item from the JVM™ in
parallel while the current operation is still running:

```csharp
ArrayList<Java.Lang.String> alist = GetAnArrayListOfString();
foreach (Java.Lang.String item in alist.WithPrefetch())
{
    // EXPENSIVE OPERATION OVER item
}
```

For a further improvement, combine `WithPrefetch` with `WithThread`, which offloads the prefetch
to a dedicated native thread:

```csharp
ArrayList<Java.Lang.String> alist = GetAnArrayListOfString();
foreach (Java.Lang.String item in alist.WithPrefetch().WithThread())
{
    // EXPENSIVE OPERATION OVER item
}
```

`WithThread` creates an external native thread responsible for driving the prefetch loop,
keeping the fetch pipeline fully independent from the CLR thread executing the operation.

> [!TIP]
> Use `WithPrefetch` and `WithThread` when the number of items is large **and** the per-item
> operation is expensive. For short iterations or cheap operations, the overhead of allocating
> the native thread and managing the second iterator may exceed the gains from parallelism.