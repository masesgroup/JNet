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

`JCOBridgeDisposeFastScope` and `JCOBridgeDisposeAsyncScope` address this by queuing release
requests and flushing them together in a single native call, keeping the per-object `Dispose`
call cost negligible. The loop body requires no changes.

> [!NOTE]
> Objects whose `Dispose` is not called explicitly (no `using` block) are eventually released
> by the .NET finalizer as before — batch scopes do not affect that path. The benefit applies
> only to explicit `Dispose` calls made while a scope is active.

### `JCOBridgeDisposeFastScope` — synchronous hot paths

Use this scope for synchronous code on a controlled thread. It uses `[ThreadStatic]` storage,
which has negligible access cost compared to the native call it replaces.

```csharp
// Kafka consumer poll loop — sync
using var batch = new JCOBridgeDisposeFastScope();
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
> `JCOBridgeDisposeFastScope` is not safe across `await` — if a continuation resumes on a
> different thread the scope state will not be visible on the new thread. Use
> `JCOBridgeDisposeAsyncScope` for async code.

### `JCOBridgeDisposeAsyncScope` — async/await contexts

Use this scope when continuations may resume on a different thread. The scope state flows
automatically across `await` points.

On .NET 8 and later `JCOBridgeDisposeAsyncScope` implements `IAsyncDisposable`, enabling
`await using` and an asynchronous flush on scope exit:

```csharp
// Async enumeration — .NET 8 / 9 / 10
await using var batch = new JCOBridgeDisposeAsyncScope();
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
using (var batch = new JCOBridgeDisposeAsyncScope())
{
    foreach (var item in jvmCollection)
    {
        using (item) { /* item disposal is batched */ }
    }
} // scope exits: queued releases flushed synchronously
```

> [!NOTE]
> `JCOBridgeDisposeAsyncScope` has slightly higher per-access cost than `JCOBridgeDisposeFastScope`
> due to the `ExecutionContext` propagation required for async safety. For synchronous hot paths
> where throughput matters, prefer `JCOBridgeDisposeFastScope`.

### Nesting scopes

Both scope types support nesting. When scopes are nested — for example because library-internal
code opens its own scope inside a user-opened scope — the inner scope increments a depth counter
and the flush is deferred until the outermost scope exits. This means library code and user code
can independently opt in to batching without coordination.

```csharp
using var outerBatch = new JCOBridgeDisposeFastScope();
// library method internally opens its own JCOBridgeDisposeFastScope — depth = 2
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

## Discard unwanted JVM™ events early with `ListenerShallManageEvent`

When a JVM™ class fires events toward the CLR — for example an AWT component, a Kafka Streams functional interface, or any JNet callback wrapper — the standard flow reads argument data from the JVM™ before invoking the registered handler. For sources that produce many event types, most of them may have no handler registered in the application. Reading and converting argument data for events that will be immediately discarded is wasted work.

JCOBridge 2.6.7+ introduces a two-level filter applied before full event handling, through two overloads of `ListenerShallManageEvent` on the JNet callback base class. Both gates receive the event as a numeric index — no string conversion is performed unless explicitly requested.

### First gate — `bool ListenerShallManageEvent(int eventIndex)`

Called before any argument data is read from the JVM. Return `false` to discard immediately (no data read, handler not invoked); return `true` to proceed to the second gate.

The first gate can be driven by one of the following, evaluated in order:
- `ListenerShallManageEventIndex` (`Func<int, bool>`) — fastest path: receives the raw event index, no string conversion.
- `ListenerShallManageEventName` (`Func<string, bool>`) — receives the event name, resolved via `ConvertListenerEventIndexToEventName`.
- Override of `ListenerShallManageEvent(int)` — virtual method for subclass-based filtering.
- Default: returns `true`.

### Second gate — `bool ListenerShallManageEvent(int eventIndex, object data)`

Called after raw argument data is available, but before full argument conversion and handler dispatch. Allows a lightweight inspection of the raw payload without paying the cost of full processing. Return `false` to discard after inspection; return `true` to proceed.

The second gate can be driven by one of the following, evaluated in order:
- `ListenerShallManageEventIndexWithData` (`Func<int, object, bool>`) — receives the raw event index and raw data.
- `ListenerShallManageEventNameWithData` (`Func<string, object, bool>`) — receives the event name and raw data.
- Override of `ListenerShallManageEvent(int, object)` — virtual method.
- Default: returns `true`.

> [!NOTE]
> The combination "first gate returns `false`, second gate returns `true`" is never reached — if the first gate discards, the second gate is not called.

### Usage

Assign the index-based delegate for the lowest-overhead path:

```csharp
var listener = new Java.Awt.Event.ActionListener();
// first gate — filter by index, no string conversion
listener.ListenerShallManageEventIndex = idx => idx == actionPerformedIndex;
// second gate — inspect raw data before full processing
listener.ListenerShallManageEventIndexWithData = (idx, data) => data is Java.Awt.Event.ActionEvent;
listener.ActionPerformed += e => { /* handle */ };
```

Or use the name-based variant when filtering by event name is more convenient:

```csharp
listener.ListenerShallManageEventName = name => name == "actionPerformed";
listener.ListenerShallManageEventNameWithData = (name, data) => data is Java.Awt.Event.ActionEvent;
```

Or override the virtual methods on a subclass:

```csharp
public class MyActionListener : Java.Awt.Event.ActionListener
{
    protected override bool ListenerShallManageEvent(int eventIndex)
    {
        return eventIndex == actionPerformedIndex;
    }

    protected override bool ListenerShallManageEvent(int eventIndex, object data)
    {
        return data is Java.Awt.Event.ActionEvent ae && ae.GetSource() is MyButton;
    }

    public override void ActionPerformed(Java.Awt.Event.ActionEvent e)
    {
        // full handling — only reached when both gates return true
    }
}
```

### Performance impact

The cost per event at each gate, measured in a sustained JVM-originated stream on a GitHub Actions runner (latest version, 1 000 000 iterations):

| Gate | `byIndex` | .NET 8 / T17 | .NET 10 / T25 | Events/sec (.NET 8) |
|---|---|---|---|---|
| First gate discard (no data read) | `false` | 0.418 µs | 0.462 µs | ~2.4 M |
| First gate discard (no data read) | `true` | **0.035 µs** | **0.035 µs** | **~29 M** |
| Second gate discard (raw data inspected) | `false` | 0.435 µs | 0.471 µs | ~2.3 M |
| Second gate discard (raw data inspected) | `true` | **0.070 µs** | **0.053 µs** | **~14 M** |
| Full processing | `false` | 3.299 µs | 4.127 µs | ~303 K |
| Full processing | `true` | 2.780 µs | 3.650 µs | ~360 K |

With `byIndex = true` and `ListenerShallManageEventIndex`, the per-event cost reaches **35 ns on both .NET 8 and .NET 10** — within the range of raw JNI call overhead on dedicated bare-metal hardware, despite running on a shared CI runner and crossing the JVM↔CLR boundary.

See [performance](performance.md) for the complete benchmark data across all versions.

> [!TIP]
> Use `ListenerShallManageEventIndex` (index-based first gate) for the lowest-overhead path — no string conversion, pure integer check. Use `ListenerShallManageEventName` when filtering by event name is more convenient; it adds the cost of `ConvertListenerEventIndexToEventName`.

> [!TIP]
> Apply these filters whenever a JVM™ source fires multiple event types and only a subset have registered handlers. Typical candidates: AWT/Swing components with many listener methods, Kafka Streams topologies with mixed functional interfaces, and any JVM™ observable that emits high-frequency events of heterogeneous types.

> [!NOTE]
> Both `ListenerShallManageEvent` overloads are available from JCOBridge 2.6.7+. On earlier versions all events follow the full data-read path regardless of whether a handler is registered.

## Bulk data from JVM — `JCOBridgeStream<T>` and `JCOBridgeDirectBuffer<T>`

JCOBridge 2.6.9 introduces two typed wrappers for reading bulk data from the JVM with `T : unmanaged`:

- **`JCOBridgeStream<T>`** — wraps a JVM native array. Exposes `ToStream()` (backed by `UnmanagedMemoryStream`) and `ReadOnlySpan<T>`. With the **HPA edition**, accesses JVM array memory directly without any copy (GC pinned for the duration). Without HPA, an internal local copy is made.
- **`JCOBridgeDirectBuffer<T>`** — wraps a JVM `DirectByteBuffer`. Same surface plus direct native pointer access. **Zero-copy in all editions** — the buffer already lives in off-heap native memory.

Both provide .NET Framework-compatible shims for `ReadOnlySpan`.

> [!NOTE]
> `JCOBridgeStream<T>` zero-copy access requires the **JCOBridge HPA edition**. Check `JCOBridge.IsHPAEdition` at startup to determine which path is active. Without HPA, `JCOBridgeStream<T>` still provides a faster access pattern than `Invoke<byte[]>` for small payloads (up to 8×), but is not truly zero-copy.

### How to obtain a `JCOBridgeStream<T>`

JNetReflector does **not** generate dedicated `xxxStream()` methods alongside existing array-returning methods. The limitation is fundamental: with generic types such as `Map<K, V>`, the concrete element type (e.g. `byte[]` for `V`) is not deducible from reflection and only becomes known when the instance is used at runtime. Generating all possible combinations would be impractical and is not useful.

Instead, `JCOBridgeStream<T>` is obtained from the **raw type** via extension methods. JNetReflector generates a raw type alongside every generic that exposes `object` (backed by a plain `IExecute` returning `IJavaObject` or `IJavaArray`). From there:

**Via `Convert<T>()` extension** — when the returned object is directly convertible:

```csharp
// e.g. iterating a Map<K, byte[]> via its raw EntrySet
foreach (var entry in map.EntrySet())
{
    var value = entry.Value; // object — IJavaObject
    using JCOBridgeStream<byte> stream = value.Convert<JCOBridgeStream<byte>>();
    ReadOnlySpan<byte> span = stream.AsSpan();
    // process span — zero-copy with HPA
}
```

**Via `IJavaArray.ToStream<T>()` extension** — when the object is an array:

```csharp
var value = entry.Value as IJavaArray;
using JCOBridgeStream<byte> stream = value.ToStream<byte>(FileAccess.ReadWrite, true);
ReadOnlySpan<byte> span = stream.AsSpan();
```

> [!NOTE]
> This requires user attention when writing the code — the type of array is known to the user from context but not to the reflector. This is intentional: `JCOBridgeStream<T>` is a precision tool for performance-critical paths, not a general-purpose replacement for array access.

### `JCOBridgeStream<T>` in listeners and callbacks

For listener/callback methods, the second overload of `ListenerShallManageEvent` provides access to raw event parameters before full processing:

```csharp
protected override bool ListenerShallManageEvent(int eventIndex, object data)
{
    var result = data as CLRListenerEventArgs<JNetEventResult>;
    CLREventData<JNetEventResult> parameters = result.EventData;

    // access the first JVM parameter (index 0)
    IJavaObject firstParameter = parameters[0];
    using (firstParameter)
    {
        using IJavaArray array = firstParameter.ToJavaArray();
        using JCOBridgeStream<byte> stream = array.ToStream<byte>();
        ReadOnlySpan<byte> span = stream.AsSpan();
        // inspect span to decide whether to proceed
        return ShouldProcess(span);
    }
}
```

- `CLRListenerEventArgs<JNetEventResult>` carries the event result and parameters
- `CLREventData<JNetEventResult>` provides indexed access to each JVM parameter as `IJavaObject`
- `IJavaObject` can be converted to `IJavaArray` and then to `JCOBridgeStream<T>`

This pattern lets you inspect array data at the second gate of `ListenerShallManageEvent` — deciding whether to invoke the full handler — without allocating a managed array.

> [!TIP]
> Use this pattern when a listener receives large arrays (e.g. audio buffers, sensor data, binary payloads) and you want to inspect or process them without a full JVM→CLR copy. With HPA enabled, the data never leaves JVM memory.

### `IsHPAEdition`

```csharp
if (JCOBridge.IsHPAEdition)
{
    // JCOBridgeStream<T>.AsSpan() is truly zero-copy
    // GC is pinned for the duration of the access
}
else
{
    // JCOBridgeStream<T>.AsSpan() performs an internal local copy
    // still faster than Invoke<byte[]> for small payloads
}
```

Check `IsHPAEdition` once at startup and use it to decide whether to apply the `JCOBridgeStream<T>` path or fall back to the standard `Invoke<T[]>` approach for latency-sensitive code.

### Choosing the right API

**For `DirectByteBuffer`** — use `JCOBridgeDirectBuffer<T>`:

```csharp
using var buf = jvmDirectBuffer.ToJCOBridgeDirectBuffer<byte>();

// AsSpan: zero-copy from native memory — no HPA needed
ReadOnlySpan<byte> span = buf.AsSpan();
ProcessData(span);

// ToStream + chunked read: no full intermediate allocation
using var netStream = buf.ToStream();
byte[] chunk = new byte[4096];
int read;
while ((read = netStream.Read(chunk, 0, chunk.Length)) > 0)
    ProcessChunk(chunk, read);
```

> [!NOTE]
> `AsSpan` on `JCOBridgeDirectBuffer<T>` is **zero-copy in all editions** — the `DirectByteBuffer` already lives in off-heap native memory. Avoid `ToStream() → MemoryStream.CopyTo() → ToArray()` for payloads above a few KB — it is up to 7× slower than `ToArray()` alone at 100 MB.

### Performance summary

See [performance — bulk data transfer](performance.md#bulk-data-transfer-at-the-jvmclr-boundary) for the full latency and throughput tables (10 B to 100 MB, 100 iterations per size). Highlights:

- `AsSpan` on `JCOBridgeStream<T>`: up to **8× faster** than `Invoke<byte[]>` for small payloads (≤10 KB); converges toward memory bandwidth at large sizes.
- `AsSpan` on `JCOBridgeDirectBuffer<T>`: **~18.5 GB/s** at 100 MB on .NET 10 / Temurin 25.
- The ByteBuffer benchmark (pre-allocated native memory, no heap→native copy) represents the expected performance of `JCOBridgeStream<T>` with HPA — the same absence of heap→native copy that HPA provides for JVM arrays.

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
