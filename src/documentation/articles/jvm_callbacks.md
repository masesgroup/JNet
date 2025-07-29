---
title: JVM™ callbacks within JNet powered code
_description: Describes how to manage callbacks from JVM™ using the .NET suite for Java™/JVM™
---

# JNet: JVM™ callbacks

One of the features of [JCOBridge](https://www.jcobridge.com/), used in JNet, is the callback management from JVM™.
Many applications use the callback mechanism to be informed about events which happens during execution.
Apache Kakfa exposes many API which have callbacks in the parameters.
The Java™ code of a callback can be written with lambda expressions, but JNet cannot, it needs an object.

## JNet Callback internals

JNet is based on [JCOBridge](https://www.jcobridge.com/). JCOBridge as per its name is a bridge between the CLR (CoreCLR) and the JVM™.
Events, generally are expressed as interfaces in Java™, and a lambda expression is translated into an object at compile time. Otherwise the developer can implement a Java™ class which **implements** the interface: with JCOBridge the developer needs to follow a seamless approach.
In JNet some callbacks are ready made. In this tutorial the **Predicate** interface ([java.util.function.Predicate](https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html)) will be taken as an example.
The concrete class implementing the interface is the following one:

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

The structure follows the guidelines of JCOBridge:
* It **must** `extends` the base class `JCListener` (or `implements` the interface `IJCListener`): this is a constraint of JCOBridge; `JCListener` has many ready made methods; if the callback is not based on an interface the developer can `implements` the `IJCListener`;
* The concrete class **must** have at least a constructor accepting a String;
* Within the implementation of the interface method (in this case the method `test` of the `Predicate` interface) the method `raiseEvent` informs the CLR that a method was raised using the specific key (**test** in this case) along with all associated objects:
  * If the interface has many methods each one must have its own `raiseEvent` call;
  * The key used from raiseEvent is not mandatory to be equal to the name of the calling method, it is only a convention for the mapping: this will be more clear looking at the C# code.

Now there is a concrete class within the JVM™ space. 
Going on to the CLR side a possible concrete class in C# is as the following one:

```c#
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

The structure follows the guidelines of JCOBridge:
* It **must** `extends` the base class `JVMBridgeListener` : this is a constraint of JCOBridge; `JVMBridgeListener` contains all the functionality to handle events from the JVM™;
* The `ClassName` property informs the base class about the concrete class in JVM™ associated to this event handler;
* Within the constructor the method `AddEventHandler` registers a .NET `EventHandler` associated to the method in JVM™; look at the key string: **it is the same used from the JVM™**;
  * The costructor of the code above accept in input an `Func` which permits to write lambda expression in C#;
  * The code above associate a private handler with specific data type:
    * `CLRListenerEventArgs` is mandatory and it is used from `JVMBridgeListener`;
    * `TObject` represents the CLR version of the corresponding `TObject` within the JVM™;
* On callback invocation (`test` in this case) the CLR will invoke `EventHandler`:
  * The first parameter is directly reported using the `TypedEventData` property;
  * On completion the result is reported back to the JVM™ using the `SetReturnValue` function;
* Other pieces of the class are useful in other condition:
  * Creating a new class extending `Callback` class, the method `OnTest` can be overridden;
  * Otherwise to the property `OnTest` can be associated to an handler;
    	
## JNet Callback lifecycle

The lifecycle of the callback managed from JCOBridge is slightly different from the standard one.
To avoid the Garbage Collector collects an instance of `JVMBridgeListener` it shall be registered. `JVMBridgeListener` do this automatically within the initialization (this behavior can be avoided using the property `AutoInit`).
So at the end of its use it must be disposed to avoid a resource leak. In the example below there is a **using** clause and the class is instantiated only one time.
A correct approach is like the following:

```c#
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

while with an approach like the following one: 

```c#
var result = o.CanSend(i, new Predicate<int>((o1) =>
{
	if (o1 > 10) return true;
	return false;
}));
```

there are two main drawbacks:
* it creates a resource leak because the object instance related to `Predicate<int>` cannot be programmatically disposed;
* on each cycle, the engine shall allocate the infrastructure to handle events from the JVM™.
