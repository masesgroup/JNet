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
