---
title: Performance tips of .NET suite for Java™/JVM™
_description: Describes some tips about performance of .NET suite for Java™/JVM™
---

# JNet performance tips

This article tries to report some tips can be used when the user faces with the performances, meanwhile explains the reasons.

## Reduce CLR-JVM boundary invocations

The library tries to optimize the usage of invocations at CLR-JVM boundary, however the user shall avoid an expansive usage of methods if not strictly needed.
Consider the following code (available in the __tests__ folder projects):

```c#
const int execution = 10000;
Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>();
for (int i = 0; i < execution; i++)
{
    alist.Add(i);
}
```

The previous code creates a `Java.Util.ArrayList<int>` and fills it, within the loop, invoking `Add` method: the fill operation is very expensive because on every loop the CLR-JVM boundary shall be traversed.
The previous is only an example of the impact of CLR-JVM boundary when performance is a key element.

### JNet helper class

The specific previous example can be optimized with some features of JNet available to build `java.util.List` of primitive types starting from array of primitive types of the CLR.

#### JNet helper class based on array transfer

An optimized way to allocate a `Java.Util.ArrayList<int>` uses the `JNetHelper` class available in JNet:

```c#
const int execution = 10000;
int[] tmpArray = new int[execution];
var tmpJList = JNetHelper.ListFrom(tmpArray);
Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>(tmpJList);
```

the previous code (also available in the __tests__ folder projects) move the primitive array using few invocations at CLR-JVM boundary, the final job is done in the JVM where the [`java.util.List`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/util/List.html) is created and then it is returned to the CLR.

#### JNet helper class based on java.nio.*Buffer

The previous code can uses a [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) to transfrer data using other overloads of `JNetHelper.ListFrom`:

```c#
const int execution = 10000;
int[] tmpArray = new int[execution];
var intBuffer = IntBuffer.From(tmpArray, false, false);
var tmpJList = JNetHelper.ListFrom(intBuffer);
Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>(tmpJList);
```

or 

```c#
const int execution = 10000;
int[] tmpArray = new int[execution];
var tmpJList = JNetHelper.ListFrom(tmpArray, true);
Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>(tmpJList);
```

Both examples uses a shared memory to move memory from CLR to JVM, the difference is mainly:
- in the first example the user allocates the `IntBuffer` and can reuse it for other reasons, e.g. refill it with other data to be sent to the JVM removing the need to create a new one
- in the second example an `IntBuffer` is allocated behind the scene each time the `JNetHelper.ListFrom` is invoked.

### Performance comparison and tips

Considering all examples it is possible to highligh how invocations at CLR-JVM boundary impacts on performance. 
The JNetTest project (available in the __tests__ folder projects) executes a timing comparison and the synthesis of the results is the following:
- First example is always the most impacted; using it as reference...
- ...when the JNet helper, based on array transfer, is used the speed is more or less 100 times higher
- ...when the JNet helper, based on java.nio.*Buffer, is used the speed can be 140 times higher
- Building a `System.Collections.Generic.List<int>` directly in the CLR the speed can be 1000 times higher

> [!TIP]
> From the previous it is possible to report three things:
> - when it is possible, the user shall avoid the invocation of methods in the JVM from the CLR to reduce their impact on performances;
> - if it possible the invocations at CLR-JVM boundary shall be collapsed just like JNetHelper does;
> - if something can be made entirely in CLR or JVM try to do it in that environment until invocation at CLR-JVM boundary is really needed.

## Memory transfer at CLR-JVM boundary

Latest version of JNet comes with many new APIs to manage data exchange at CLR-JVM boundary using [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html).

The [chapter](#JNet-helper-class-based-on-java.nio.*Buffer) introduces one of the usage of the new APIs in a specific context behind an helper class, however [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) can be used starting from many types of CLR inputs:
- from an `IntPtr` 
- from a `System.IO.MemoryStream`
- from an array of primitive types (`byte`, `short`, `int`, `long`, and so on)

All previous variants are available because there many possible needs, here some examples:
- An `IntPtr`, representing a generic native memory pointer, can be the address of a memory allocated from COM (Component Object Model), a pointer to a unmanaged memory or other cases
- A `System.IO.MemoryStream` can be the output of some operations (e.g. a JSON serialization before convert it to an array of bytes)
- An array of `byte`s can be a file read from the disk, information from a socket and so on

JNI (CLR-JVM boundary) comes with many methods to transfer data using array of primitivess, but in some conditions both CLR and JVM can make multiple copies of the memory reducing the performances.
An example can be a `System.IO.MemoryStream` holding information to be transferred in the JVM:
1. the data within the `System.IO.MemoryStream` shall be extracted and converted into an array of `byte`s;
2. the array of `byte`s shall be allocated from the CLR then the content of `System.IO.MemoryStream` shall be copied in it;
3. the array of `byte`s shall be transferred to the JVM and this operation needs to:
  a. create a new array in the JVM with length equals to the CLR array
  b. execute a memory copy from CLR memory to the JVM memory
4. the operation 3.b can be impacted, depending on the JVM, from a further copy becuase the JVM itself can decide to use a temporary array reference at JNI (CLR-JVM boundary) level
5. then the JVM can use the data sent from the CLR. 

With the new APIs available in JNet the previous steps becomes:
1. A [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) is created diretly from `System.IO.MemoryStream`;
2. the reference to [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) is sent to the JVM, but the memory isn't moved;
3. then the JVM can directly access the CLR memory using [`public abstract byte get()`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html#get()) or [`public abstract byte get(int index)`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html#get(int)) methods.

> [!IMPORTANT]
> Other methods can be used to retrieve an array of `byte`s if the code needs that kind of type, however it is important to notice that an user shall avoid the [`public ByteBuffer get(byte[] dst)`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html#get(byte%5B%5D)) method because the underlying implementation executes a byte-to-byte copy, while it is preferable the [`public ByteBuffer get(byte[] dst, int offset, int length)`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html#get(byte%5B%5D,int,int)) method because it executes a copy based on block of bytes. 

### The impact of array creation

In the previous chapter was reported that an user can obtain an array of `byte`s (or any other primitive) by method parameter or reading data transferred using a [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html).
If an array of primitives is needed the JVM (or the CLR) is heavely impacted because the JVM (or the CLR) must execute some work to obtain it.

> [!NOTE]
> The work mentioned before does not change if the array comes from JNI (CLR-JVM boundary) or from [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html).

The JNetByteBufferTest project (available in the __tests__ folder projects) executes a set of different tests comparing some cases:
1. executes a transfer using array of `byte`s, and it is used as reference
2. then executes memory transfer using [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) and reads the data allocating, on each execution, a new array of `byte`s
3. then executes memory transfer using [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) and reads the data reusing, on each execution, a previously allocated array of `byte`s
4. then executes memory transfer using [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) without reads the data

The previous steps are done both from CLR to the JVM, then from JVM to the CLR, repeating them many times and using different array lengths; from the tests executed it is possible to highlight that:

- test cases 1 and 2:
  - array of `byte`s performs better than [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) mainly for smallest arrays in both directions
  - [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) not always performs better than array of `byte`s and the reason can be found in the allocation of array of `byte`s requested from JVM, and CLR, on each execution

- test case 3:
  - in general, avoiding array allocation gives an enhancement of 4/5 times than transfer made with array of `byte`s
  - currently, transferring few data (smallest length) from JVM to CLR, array of `byte`s performs better than [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html)

- test case 4:
  - uncomparable with the other tests, it is useful to measure the transfer of the [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html) which is acting as a pointer to the JVM (or CLR) memory

> [!TIP]
> For test case 4: if the user implements a sparse access to the memory transferred using a [`java.nio.ByteBuffer`](https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/nio/ByteBuffer.html), the code does not need to move memory (or make a copy) with array of `byte`s, gaining in performance.

### Performance and tips

From the previous chapter it is clear that memory allocation is a key to be considered in performances because the memory shall be found from the JVM, or CLR, then it shall be released.

> [!TIP]
> When it is possible, try to reuse the previously allocated arrays to avoid an expansive load on JVM, or CLR, both during creation and when the arrays are garbage collected. 

## Execute iterations in parallel

The chapter [Performance comparison and tips](#Performance-comparison-and-tips) recommends to reduce the number of invocations at CLR-JVM boundary to the minimum possible, JNetHelper is a great helper when the user is facing with primitives and [Memory transfer at CLR-JVM boundary](#Memory-transfer-at-CLR-JVM-boundary) explain how to optimize memory transfer.
However in many conditions the user shall executes iterations on objects which cannot be managed like primitive types. To explain better, consider the following snippet:

```c#
ArrayList<Java.Lang.String> alist = GetAnArrayListOfString();
foreach (Java.Lang.String item in alist)
{
    // EXPENSIVE OPERATION OVER item
}
```

the code requests a `Java.Lang.String` using the `Java.Lang.Iterable` interface, then executes an EXPENSIVE operation over it: when the CLR is executing the operation the JVM does not do anything with the `Java.Lang.Iterable` interface, the next time the CLR code requests a new item the `Java.Lang.Iterable` interface is impacted.
In general this means that:
1. the next **EXPENSIVE OPERATION OVER item** shall wait that the item is received from the JVM
2. while **EXPENSIVE OPERATION OVER item** is executed the JVM is idle

To speed up the iteration it is possible to use the `WithPrefetch` extension method like in the following sinppet:

```c#
ArrayList<Java.Lang.String> alist = GetAnArrayListOfString();
foreach (Java.Lang.String item in alist.WithPrefetch())
{
    // EXPENSIVE OPERATION OVER item
}
```

`WithPrefetch` returns a new iterator that retrieves data from JVM in parallel: while **EXPENSIVE OPERATION OVER item** is executed, a new item is received from the JVM.

A further improvement can be obtained using `WithThread` extension method like in:

```c#
ArrayList<Java.Lang.String> alist = GetAnArrayListOfString();
foreach (Java.Lang.String item in alist.WithPrefetch().WithThread())
{
    // EXPENSIVE OPERATION OVER item
}
```

`WithThread` creates an external native thread which executes the retrieve operation.

> [!TIP]
> It is preferable to use `WithPrefetch` and `WithThread` when the number of items are high and the operation over item is expensive; otherwise the time spent to allocate the external native thread and manage the second iterator is more than the operation executed with classic iterator.


