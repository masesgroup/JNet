---
title: APIs extendibility of .NET suite for Java™/JVM™
_description: Describes how to extend available APIs with .NET suite for Java™/JVM™
---

# JNet: APIs extendibility

What to do if an API was not yet implemented? The simplest answer is: help us to make this product reacher :smile:
There is another answer which is not available with other products: Dynamic code and programmatically API access.

With **JCOBridge** a developer can use some properties to manage objects in the JVM™. 
Each JNet class implemented contains some methods and two properties: a direct and a dynamic accessor able to analyze the JVM™ class and executes the code.
So it is not necessary at all to have the methods be ready to be used.

Let's go to show some possible conditions analyzing the `Hashtable` class (code at https://github.com/masesgroup/JNet/blob/master/src/net/JNet/Java/Util/Hashtable.cs).

## When a method is not available

The class has a single ready made method:

```C#
public void Put(K key, V value) => IExecute("put", key, value);
```

This is a void method, using **IExecute** the user of the library can invoke the `Put` method on the class and execute the Java™ counterpart. 
The developer can, anyway, invoke the `put` method directly from the instance of the `Hashtable` class using two different paradigms: **direct** or **dynamic** access.
The `put` method can be replaced with any method (with or without parameters) of the `Hashtable` class.

### Direct access

The `IExecute` method is public and can be executed using the instance of the `Hashtable` class.

```C#
Hashtable<string, string> data = new Hashtable<string, string>(...);

data.IExecute("put", "a", "b");
```

Anyway other methods can be accessed like in the following example where an overload of `IExecute` method returns a **bool** value:

```C#
Hashtable<string, string> data = new Hashtable<string, string>(...);

bool isEmpty = data.IExecute<bool>("isEmpty");
```

### Dynamic access

```C#
dynamic data = new Hashtable<string, string>(...);

data.put("a", "b");
var isEmpty = data.isEmpty();
```

The `Hashtable`, and any other ready made class of the library, supports the **dynamic** access to the methods available in Java™ side.
The previous example demostrates the behavior.

## When a class is not available

In a more complex scenario the method can return back objects or can accept input of not ready made classes: no problem, there is a solution.

### Return class is not available

To discuss this case we use another class: the [AWT Panel](https://docs.oracle.com/javase/8/docs/api/java/awt/Panel.html), implemented in [Java.Awt.Panel](https://github.com/masesgroup/JNet/blob/master/src/net/JNet/Java/Awt/Panel.cs).
The .NET class does not have any implemented method: we discuss about [createVolatileImage](https://docs.oracle.com/javase/8/docs/api/java/awt/Component.html#createVolatileImage-int-int-) inherited from the base class `Component`.
The method returns a [VolatileImage](https://docs.oracle.com/javase/8/docs/api/java/awt/image/VolatileImage.html) which is not yet implemented; a solution on this problem is to use directly the `createVolatileImage` Java™ method like the following code snippet does:

```C#
Java.Awt.Panel panel = new();
var volImage = panel.IExecute("createVolatileImage", 100, 100); // the returned object is a dynamic object which reference the VolatileImage object in Java
var snapshot = volImage.getSnapshot(); // the returned object is a dynamic object reference of the BufferedImage object in Java
var isContentLost = volImage.contentsLost(); // the returned object is a bool representing the Java counterpart

```

The example above uses the classes `VolatileImage` and `BufferedImage` which are not implemented yet: the classes exists in JVM™ and can be accessed.

### Input and Return class are not available

If even the input class is not available the solution is like the following:

```C#
Java.Awt.Panel panel = new();
var dynImageCapabilities = panel.JVM.New("java.awt.ImageCapabilities", true); // the returned object is a dynamic object which is a reference of the ImageCapabilities object in Java
var volImage = panel.IExecute("createVolatileImage", 100, 100, dynImageCapabilities); // the returned object is a dynamic object which reference the VolatileImage object in Java
var snapshot = volImage.getSnapshot(); // the returned object is a dynamic object reference of the BufferedImage object in Java
var isContentLost = volImage.contentsLost(); // the returned object is a bool representing the Java counterpart

```

In the above example the class `ImageCapabilities` is not implemented yet. Since it exists in the JVM™ it can be allocated and used.
Each object, like `Panel` instance, exposes (hidden in the editor) two properties:
* **JVM** which access the JVM™ using methods;
* **DynJVM** which access the JVM™ using the Dynamic engine.

Using the listed properties it is possible to instruct the JVM™ about the action to be done.

### Anything is not available

If no classes are available the solution comes from the global accessor available in JCOBridge and the code snippet is like the following one:

```C#
var panel = JNetCore.New("java.awt.Panel"); // the returned object is a dynamic object reference of the Panel object in Java
var dynImageCapabilities = JNetCore.New("java.awt.ImageCapabilities", true); // the returned object is a dynamic object which is a reference of the ImageCapabilities object in Java
var volImage = panel.createVolatileImage(100, 100, dynImageCapabilities); // the returned object is a dynamic object which reference the VolatileImage object in Java
var snapshot = volImage.getSnapshot(); // the returned object is a dynamic object reference of the BufferedImage object in Java
var isContentLost = volImage.contentsLost(); // the returned object is a bool representing the Java counterpart

```

The example above consider that even the class `Panel` is not implemented yet. Since it exists in the JVM™ it can be allocated and used.
In previous chapter the tutorial reports about two hidden properties in each object; the properties on each class are just an useful reference to the real one available in `JCOBridge.Global`:
* **JVM** which access the JVM™ using methods;
* **DynJVM** which access the JVM™ using the Dynamic engine.

Using the properties it is possible to instruct the JVM™ about the action to be done.

### Call a method dynamically

Look at the simple example below:

```C#

Java.Awt.Panel panel = new();
var result = panel.DynInstance.getLayout(); // this line invokes dynamically the getLayout method on the instance of the Panel

```

As exposed before, each object, like `Panel` instance, exposes (hidden in the editor) two properties.

Explaining the code:
* The first line creates a JVM™ object in C# style: `Container` lives in the CLR and has its counterpart in the JVM™.
* The `result` is a **dynamic** object that can be used to extract data or invokes other methods on the result of `getLayout` which is an object of type `LayoutManager`.

## API exendibility limitation

Starting from the assumption that JCOBridge does not make any code injection, or compilation, within JVM™ side, the actual limitation is related to something missing within the JVM™.
In the [JVM™ callbacks](jvm_callbacks.md) article there is an explanation of how works callbacks.
**The callback feature needs a concrete class in the JVM™ and if it does not exist there is no way to use it from JNet.**
