---
title: JVM™ Callbacks in JNet
_description: Describes how to manage callbacks from JVM™ using the .NET suite for Java™/JVM™
---

# JNet: JVM™ callbacks

One of the features of [JCOBridge](https://www.jcobridge.com/) is callback management from the JVM™.
Java™ callbacks are typically expressed as interfaces, which Java™ code can satisfy with lambda expressions.
Since JNet operates at the JNI boundary, lambdas are not directly usable — a concrete class implementing
the interface is required instead. This page explains how JNet and JCOBridge handle this transparently.

## JNet Callback internals

JNet is based on [JCOBridge](https://www.jcobridge.com/), a bridge between the CLR (CoreCLR) and the JVM™.
Events are generally expressed as interfaces in Java™, and a lambda expression is compiled into a concrete
object at build time. Alternatively, a developer can implement a Java™ class that **implements** the
interface directly — with JCOBridge, this follows a structured but familiar approach.

In JNet, several callbacks are ready-made. This tutorial uses the **Predicate** interface
([java.util.function.Predicate](https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html))
as an example.

The concrete JVM™ class implementing the interface looks like this:

```java
public final class JNetPredicate extends JCListener implements Predicate {
    public JNetPredicate(String key) throws JCNativeException {
        super(key);
    }

    @Override
    public boolean test(Object e) {
        raiseEvent("test", e);
        Object retVal = getReturnData();
        return (boolean) retVal;
    }
}
```

The structure follows the JCOBridge guidelines:

* It **must** extend the base class `JCListener` (or implement the interface `IJCListener`). This is a
  requirement of JCOBridge. `JCListener` provides many ready-made methods for event handling. If the
  callback is not based on an interface, the class can implement `IJCListener` directly.
* The concrete class **must** have at least one constructor accepting a `String`.
* Within the interface method implementation (here, `test` from the `Predicate` interface), the method
  `raiseEvent` notifies the CLR that the method was invoked, passing the event key (`"test"`) and all
  associated objects:
  * If the interface declares multiple methods, each one must have its own `raiseEvent` call.
  * The key passed to `raiseEvent` does not need to match the name of the calling method — it is a
    convention for mapping to the CLR side, which will become clearer when looking at the C# code below.

With the JVM™-side class in place, the corresponding CLR-side class in C# looks like this:

```csharp
public class Predicate<TObject> : JVMBridgeListener
{
    public override string ClassName => "org.mases.jnet.util.function.JNetPredicate";

    Func<TObject, bool> executionFunction = null;
    public virtual Func<TObject, bool> OnTest { get { return executionFunction; } }

    public Predicate(Func<TObject, bool> func = null, bool attachEventHandler = true)
    {
        if (func != null) executionFunction = func;
        else executionFunction = Test;

        if (attachEventHandler)
        {
            AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(EventHandler));
        }
    }

    void EventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
    {
        var retVal = OnTest(data.EventData.TypedEventData);
        data.SetReturnValue(retVal);
    }

    public virtual bool Test(TObject obj) { return false; }
}
```

The structure follows the JCOBridge guidelines:

* It **must** derive from the base class `JVMBridgeListener`. This is a requirement of JCOBridge;
  `JVMBridgeListener` contains all the infrastructure needed to handle events from the JVM™.
* The `ClassName` property tells the base class which JVM™ class is associated with this event handler.
* In the constructor, `AddEventHandler` registers a .NET `EventHandler` for the corresponding JVM™ method.
  Note that the key string **must match the key used in `raiseEvent` on the JVM™ side**:
  * The constructor accepts an optional `Func`, allowing the caller to pass a lambda expression from C#.
  * The handler uses specific data types:
    * `CLRListenerEventArgs` is mandatory and is used internally by `JVMBridgeListener`.
    * `TObject` represents the CLR equivalent of the corresponding Java type.
* When the JVM™ invokes the callback (`test` in this case), the CLR calls `EventHandler`:
  * The first parameter is accessed via the `TypedEventData` property.
  * Once complete, the return value is sent back to the JVM™ via `SetReturnValue`.
* The class also supports two extension points:
  * Subclassing `Predicate<TObject>` and overriding `OnTest` for a class-based approach.
  * Assigning a handler directly to the `OnTest` property without subclassing.

## JNet Callback lifecycle

The lifecycle of a JCOBridge-managed callback differs from standard .NET object lifetime.
To prevent the .NET Garbage Collector from collecting an active `JVMBridgeListener` instance —
which would break the JVM™ callback link — the instance is automatically registered during
initialization. This automatic registration can be disabled by setting the `AutoInit` property
to `false`, in which case the developer is responsible for managing the registration manually.

Because of this registration, the instance **must be explicitly disposed** when no longer needed
to avoid a resource leak. The recommended pattern uses a `using` block so the instance is
allocated once and disposed deterministically:

```csharp
using (var handler = new Predicate<int>((o1) =>
{
    if (o1 > 10) return true;
    return false;
}))
{
    while (!resetEvent.WaitOne(0))
    {
        if (o.CanSend(i, handler)) o.Send(i);
        i++;
    }
}
```

> [!WARNING]
> Avoid instantiating the callback inline at the call site, as in the example below:
>
> ```csharp
> var result = o.CanSend(i, new Predicate<int>((o1) =>
> {
>     if (o1 > 10) return true;
>     return false;
> }));
> ```
>
> This pattern has two significant drawbacks:
> * It creates a **resource leak**: the `Predicate<int>` instance cannot be programmatically disposed.
> * It incurs **unnecessary overhead**: the JVM™ event-handling infrastructure is allocated on every call
>   instead of being reused.

## Discarding events before full processing

When only a subset of events from a listener require full handling, the two-gate filter avoids reading JVM™ argument data for events that will be discarded. The index-based variants — `ListenerShallManageEventIndex` and `ListenerShallManageEventIndexWithData` — operate without any string conversion and represent the lowest-overhead path:

```csharp
using (var handler = new Predicate<int>((o1) =>
{
    if (o1 > 10) return true;
    return false;
}))
{
    // discard all events except index 0 before any data is read
    handler.ListenerShallManageEventIndex = idx => idx == 0;
    // further filter by raw data after read, before full dispatch
    handler.ListenerShallManageEventIndexWithData = (idx, data) => data != null;

    while (!resetEvent.WaitOne(0))
    {
        if (o.CanSend(i, handler)) o.Send(i);
        i++;
    }
}
```

Name-based variants (`ListenerShallManageEventName`, `ListenerShallManageEventNameWithData`) are available when filtering by event name is more convenient; they resolve the name via `ConvertListenerEventIndexToEventName`. Both approaches can also be implemented by overriding the virtual `ListenerShallManageEvent(int)` and `ListenerShallManageEvent(int, object)` methods on a subclass.

See [performance tips](performancetips.md) for the full gate API description and benchmark data.

## Reducing Dispose overhead in high-frequency callback loops

When a callback handler receives a sustained high-frequency stream of JVM-originated events — for
example a Kafka Streams functional interface processing thousands of records per second, or an AWT
event loop under heavy input — the JVM™ may pass one or more JNet-wrapped objects as arguments on
each invocation. Each of those objects carries a JVM™ global reference that must be released when
the object is no longer needed.

Releasing each reference immediately on `Dispose` makes a direct native call per object. At high
event rates this cost accumulates. Opening a `JCOBridgeDisposeFastScope` around the event loop
batches those releases and flushes them in a single native call, keeping the handler body unchanged:

```csharp
using (var handler = new Predicate<int>((o1) =>
{
    if (o1 > 10) return true;
    return false;
}))
using (var batch = new JCOBridgeDisposeFastScope())
{
    while (!resetEvent.WaitOne(0))
    {
        if (o.CanSend(i, handler)) o.Send(i);
        i++;
    }
}
// all queued releases flushed here when the scope exits
```

For async callback handlers where continuations may resume on a different thread, use
`JCOBridgeDisposeAsyncScope` instead. On .NET 8 and later `IAsyncDisposable` is available,
enabling `await using` and an asynchronous flush:

```csharp
// .NET 8 / 9 / 10
using (var handler = new MyAsyncListener())
await using (var batch = new JCOBridgeDisposeAsyncScope())
{
    await foreach (var ev in eventSource)
    {
        await handler.HandleAsync(ev);
    }
}
```

On .NET Framework use a standard `using` block — the flush is synchronous:

```csharp
// .NET Framework
using (var handler = new MyAsyncListener())
using (var batch = new JCOBridgeDisposeAsyncScope())
{
    foreach (var ev in eventSource)
    {
        handler.Handle(ev);
    }
}
```

> [!TIP]
> Batch scopes are most effective when the per-event handler work is lightweight — processing,
> filtering, or forwarding — and `Dispose` calls represent a meaningful fraction of the total
> loop time. When the handler itself performs expensive operations (I/O, multiple JVM™ method
> calls, computation), the release cost is already a small fraction of the total and a batch
> scope will not produce a measurable difference.

See [performance tips](performancetips.md) for guidance on when batch scopes provide meaningful
gains and how to select between the two scope types.
