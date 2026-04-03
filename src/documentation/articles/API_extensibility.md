---
title: API Extensibility in JNet
_description: Describes how to extend available APIs with the .NET suite for Java™/JVM™
---

# JNet: API extensibility

If a Java™ API has not yet been mapped in JNet, there are two options: contribute a mapping upstream,
or use JCOBridge's **direct and dynamic access** mechanisms to call any JVM™ class or method at
runtime — without waiting for a ready-made wrapper.

Every JNet class exposes two accessor properties alongside its ready-made methods, which can
introspect and invoke the JVM™ class directly:

* **`JVM`** — a typed interface exposing properties and methods to interact with the JVM™ in a
  structured way.
* **`DynJVM`** — returns a `dynamic` object, enabling fluent method calls without explicit typing.

Let's look at some concrete scenarios using the `Hashtable` class
(source at https://github.com/masesgroup/JNet/blob/master/src/net/JNet/Java/Util/Hashtable.cs).

## When a method is not available

The class has a single ready-made method:

```csharp
public void Put(K key, V value) => IExecute("put", key, value);
```

This is a void method — using `IExecute`, the library invokes the `put` method on the JVM™ counterpart.
Any method of the `Hashtable` class (with or without parameters) can be called the same way,
using either **direct** or **dynamic** access.

### Direct access

`IExecute` is public and can be called directly on any JNet instance:

```csharp
Hashtable<string, string> data = new Hashtable<string, string>(...);

data.IExecute("put", "a", "b");
```

Other methods can also be accessed this way. An overload of `IExecute` accepts a type parameter
to capture the return value:

```csharp
Hashtable<string, string> data = new Hashtable<string, string>(...);

bool isEmpty = data.IExecute<bool>("isEmpty");
```

### Dynamic access

```csharp
dynamic data = new Hashtable<string, string>(...);

data.put("a", "b");
var isEmpty = data.isEmpty();
```

Every ready-made JNet class supports `dynamic` access to all methods available on the Java™ side.
The example above demonstrates this behavior.

## When a class is not available

In more complex scenarios, a method may return an object or accept a parameter of a type that has
not yet been mapped in JNet. There is a solution for each case.

### Return class is not available

To illustrate this, consider the [AWT Panel](https://docs.oracle.com/javase/8/docs/api/java/awt/Panel.html),
implemented in [Java.Awt.Panel](https://github.com/masesgroup/JNet/blob/master/src/net/JNet/Java/Awt/Panel.cs).
The .NET class has no mapped methods. The example below calls
[createVolatileImage](https://docs.oracle.com/javase/8/docs/api/java/awt/Component.html#createVolatileImage-int-int-)
(inherited from `Component`), which returns a
[VolatileImage](https://docs.oracle.com/javase/8/docs/api/java/awt/image/VolatileImage.html) — a class
not yet mapped in JNet:

```csharp
Java.Awt.Panel panel = new();

// Returns a dynamic reference to the VolatileImage object in the JVM™
var volImage = panel.IExecute("createVolatileImage", 100, 100);
// Returns a dynamic reference to the BufferedImage object in the JVM™
var snapshot = volImage.getSnapshot();
// Returns a bool — the Java boolean is automatically converted
var isContentLost = volImage.contentsLost();
```

`VolatileImage` and `BufferedImage` are not mapped in JNet, but they exist in the JVM™ and are
fully accessible as `dynamic` references.

### Input and return class are not available

If the input class is also not mapped, use the `JVM` property to instantiate it directly in the JVM™:

```csharp
Java.Awt.Panel panel = new();

// Creates a new ImageCapabilities instance in the JVM™; returns a dynamic reference
var dynImageCapabilities = panel.JVM.New("java.awt.ImageCapabilities", true);
// Returns a dynamic reference to the VolatileImage object in the JVM™
var volImage = panel.IExecute("createVolatileImage", 100, 100, dynImageCapabilities);
// Returns a dynamic reference to the BufferedImage object in the JVM™
var snapshot = volImage.getSnapshot();
// Returns a bool — the Java boolean is automatically converted
var isContentLost = volImage.contentsLost();
```

`ImageCapabilities` is not mapped in JNet, but since it exists in the JVM™ it can be instantiated
and passed as an argument without any additional setup.

Each JNet object exposes two properties for direct JVM™ interaction (intentionally hidden in editor
autocompletion to reduce noise):

* **`JVM`** — a typed interface with properties and methods for structured JVM™ access; use this
  when you need explicit control (e.g. `JVM.New(...)` to instantiate a class).
* **`DynJVM`** — returns a `dynamic` object bound to the JVM™ instance; use this for fluent,
  untyped method calls.

### Anything is not available

If no classes are mapped at all, use the global accessor available on `JNetCore`:

```csharp
// Creates a new Panel instance in the JVM™; returns a dynamic reference
var panel = JNetCore.New("java.awt.Panel");
// Creates a new ImageCapabilities instance in the JVM™; returns a dynamic reference
var dynImageCapabilities = JNetCore.New("java.awt.ImageCapabilities", true);
// Returns a dynamic reference to the VolatileImage object in the JVM™
var volImage = panel.createVolatileImage(100, 100, dynImageCapabilities);
// Returns a dynamic reference to the BufferedImage object in the JVM™
var snapshot = volImage.getSnapshot();
// Returns a bool — the Java boolean is automatically converted
var isContentLost = volImage.contentsLost();
```

This example assumes even `Panel` is not mapped. Since it exists in the JVM™, it can be instantiated
and used via `JNetCore.New(...)`.

The `JVM` and `DynJVM` properties on each object are convenience references to the underlying
`JCOBridge.Global` accessor:

* **`JVM`** — typed interface with properties and methods for structured JVM™ access.
* **`DynJVM`** — returns a `dynamic` object for fluent, untyped calls.

### Call a method dynamically

The `DynJVM` property also exposes `DynInstance`, which allows dynamic invocation on the specific
object instance:

```csharp
Java.Awt.Panel panel = new();

// Dynamically invokes getLayout() on the Panel instance
var result = panel.DynInstance.getLayout();
```

Explaining the code:
* The first line creates a JVM™ object in C# style: `Container` (the base class of `Panel`) lives
  in the CLR and has its counterpart in the JVM™.
* `result` is a `dynamic` object representing a `LayoutManager` instance in the JVM™. It can be
  used to read properties or invoke further methods.

## API extensibility limitations

JCOBridge does not perform any code injection or compilation on the JVM™ side. The only hard
limitation is therefore related to **callbacks**: a callback requires a concrete class in the JVM™
that implements the target interface and calls back into the CLR.

**If no such concrete class exists in the JVM™, the callback cannot be used from JNet.**

See the [JVM™ Callbacks](jvm_callbacks.md) article for a full explanation of how callbacks work
and how to implement them.

> [!NOTE]
> If you need a callback against a Java™ interface that has no concrete JVM™ implementation in
> JNet yet, consider contributing one following the patterns described in
> [JVM™ Callbacks](jvm_callbacks.md).
