---
title: Usage Java/JVM suite for .NET
_description: Describes how to use JNet, set-up environment, identify the JVM and write good code
---

# JNet usage

To use JNet classes the developer can write code in .NET using the same classes available in the official Java packages.
If classes or methods are not available yet it is possible to use the approach synthetized in [What to do if an API was not yet implemented](API_extensibility.md)

## Environment setup

JNet accepts many command-line switches to customize its behavior. The full list is available at [Command line switch](commandlineswitch.md) page.

### JVM identification

One of the most important command-line switch is **JVMPath** and it is available in [JCOBridge switches](https://www.jcobridge.com/net-examples/command-line-options/): it can be used to set-up the location of the JVM library (jvm.dll/libjvm.so) if JCOBridge is not able to identify a suitable JRE installation.
If a developer is using JNet within its own product it is possible to override the **JVMPath** property with a snippet like the following one:

```c#
class MyJNetCore : JNetCore
{
    public override string JVMPath
    {
        get
        {
            string pathToJVM = "Set here the path to JVM library or use your own search method";
            return pathToJVM;
        }
    }
}
```

**IMPORTANT NOTE**: `pathToJVM` shall be escaped
1. `string pathToJVM = "C:\\Program Files\\Eclipse Adoptium\\jdk-11.0.18.10-hotspot\\bin\\server\\jvm.dll";`
2. `string pathToJVM = @"C:\Program Files\Eclipse Adoptium\jdk-11.0.18.10-hotspot\bin\server\jvm.dll";`

### Special initialization conditions

[JCOBridge](https://www.jcobridge.com/) try to identify a suitable JRE/JDK installation within the system using some standard mechanism of JRE/JDK: `JAVA_HOME` environment variable or Windows registry if available.
However it is possible, on Windows operating systems, that the library raises an **InvalidOperationException: Missing Java Key in registry: Couldn't find Java installed on the machine**.
This means that neither `JAVA_HOME` nor Windows registry contains information about a default installed JRE/JDK: some vendors may not setup them.
If the developer/user encounter this condition can do the following steps:
1. On a command prompt execute `set | findstr JAVA_HOME` and verify the result;
2. If something was reported maybe the `JAVA_HOME` environment variable is not set at system level, but at a different level like user level which is not visible from the JNet process that raised the exception;
3. Try to set `JAVA_HOME` at system level e.g. `JAVA_HOME=C:\Program Files\Eclipse Adoptium\jdk-11.0.18.10-hotspot\`;
4. Try to set `JCOBRIDGE_JVMPath` at system level e.g. `JCOBRIDGE_JVMPath=C:\Program Files\Eclipse Adoptium\jdk-11.0.18.10-hotspot\`.

**IMPORTANT NOTES**:
- One of `JCOBRIDGE_JVMPath` or `JAVA_HOME` environment variables or Windows registry (on Windows OSes) shall be available
- `JCOBRIDGE_JVMPath` environment variable takes precedence over `JAVA_HOME` and Windows registry: you can set `JCOBRIDGE_JVMPath` to `C:\Program Files\Eclipse Adoptium\jdk-11.0.18.10-hotspot\bin\server\jvm.dll` and avoid to override `JVMPath` in your code
- After first initialization steps, `JVMPath` takes precedence over `JCOBRIDGE_JVMPath`/`JAVA_HOME` environment variables or Windows registry

## Basic example

Below a basic example which demonstrates how to create a program based on JNet and some other features available like generics and exception handling.
Within the program the comments try to explain how the code works.

```c#
using Java.Util;
using MASES.JNet.Extensions;
using System.Diagnostics;
using Java.Lang;

namespace MASES.JNetExample
{
    // this class defines a concrete implementation of JNetCore<>
    class MyJNetCore : JNetCore<MyJNetCore>
    { 
    }

    class Program
    {
        static void Main(string[] args)
        {
            // the first step is mandatory: 
            // it invokes the method CreateGlobalInstance to allocate the JVM and prepares the environment
            MyJNetCore.CreateGlobalInstance();
            // at the end of initialization the arguments in the command line not used from JNet (and JCOBridge) 
            // are available to be used like any developer does with the args in the Main 
            var appArgs = MyJNetCore.FilteredArgs;

            // now we go into .NET/JVM interaction based on generics
            try
            {
                // in the first step the code allocates a java.util.Set<String> within the JVM using the java.util.Collections class
                // and returns a Java.Util.Set<string> in .NET
                Java.Util.Set<string> set = Collections.Singleton("test");

                // then the code tries to Add a new value if it is available in command-line, 
                // but we expect the JVM raises an exception
                if (appArgs.Length != 0) set.Add(appArgs[0]);
            }
            // if the Add is invoked the operation on java.util.Set<String> cannot be performed 
            // because Collections.Singleton returns an immutable java.util.Set<String>
            // see https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collections.html#singleton(T))
            catch (UnsupportedOperationException) 
            {
                // so we enter here because the engine translates the Java exception in an equivalent exception managed from C#
                System.Console.WriteLine("Operation not supported as expected");
            }
            // this piece of code is for any convenience because we want a clean close of the application
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
        }
    }
}
```

## Avoid `Java.Lang.NullPointerException` writing a good code

Sometime during execution a `Java.Lang.NullPointerException` can be raised and seems there isn't neither a real problem in the .NET code you wrote nor a specific pattern or time when it is raised.
The problem is behind the scene and it is correlated on how Garbage Collector and code optimizer works.
In the code of the previous chapter the `Collections.Singleton("test")` creates an object which is used from `set.Add(appArgs[0])` and in this case the Garbage Collector does not retires the object.
Considering the following code snippet:

```c#
using Java.Util;
using MASES.JNet.Extensions;
using System.Diagnostics;
using Java.Lang;

namespace MASES.JNetExample
{
    class MyJNetCore : JNetCore<MyJNetCore> { }

    class Program
    {
        static void Main(string[] args)
        {
            MyJNetCore.CreateGlobalInstance();
            try
            {
                Java.Util.Set<string> set = Collections.Singleton("test");
                ArrayList<string> arrayList = new();
                arrayList.AddAll(0, set); // this point can raise Java.Lang.NullPointerException
            }
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
        }
    }
}
```

the `Collections.Singleton("test")` ends its life, from .NET point of view, when `arrayList.AddAll(0, set)` is invoked:
- `Java.Util.Set<string>` is a .NET container for JVM `java.util.Set<String>`
- `arrayList.AddAll(0, set)` receives the `Java.Util.Set<string>` instance and sends to JVM the reference to `java.util.Set<String>` of JVM
- from .NET point of view `Java.Util.Set<string>` has ended its life and can be retired because does not have any other root referencing it
- .NET Garbage Collector activates arbitrarily when some conditions meet: https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/

Most of the time the code above works without problem, but sometimes the JVM can raise a `Java.Lang.NullPointerException` because `Java.Util.Set<string>` was retired from .NET GC.

To solve the issue, and force the GC to not retire the instance, there are some possible code snippet a developer can follows:

### `using` or `try-finally` with `Dispose` patterns

All classes implements `IDisposable` interface, the code snippet becomes:

```c#
using Java.Util;
using MASES.JNet.Extensions;
using System.Diagnostics;
using Java.Lang;

namespace MASES.JNetExample
{
    class MyJNetCore : JNetCore<MyJNetCore> { }

    class Program
    {
        static void Main(string[] args)
        {
            MyJNetCore.CreateGlobalInstance();
            try
            {
                using (Java.Util.Set<string> set = Collections.Singleton("test"))
                {
                    ArrayList<string> arrayList = new();
                    arrayList.AddAll(0, set);
                }
            }
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
        }
    }
}
```

or

```c#
using Java.Util;
using MASES.JNet.Extensions;
using System.Diagnostics;
using Java.Lang;

namespace MASES.JNetExample
{
    class MyJNetCore : JNetCore<MyJNetCore> { }

    class Program
    {
        static void Main(string[] args)
        {
            MyJNetCore.CreateGlobalInstance();
            try
            {
                Java.Util.Set<string> set = null;
                try
                {
                    set = Collections.Singleton("test");
                    ArrayList<string> arrayList = new();
                    arrayList.AddAll(0, set);
                }
                finally { set?.Dispose(); }
            }
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
        }
    }
}
```

### `SuppressFinalize`/`ReRegisterForFinalize` pattern

Over every .NET object can be invoke the `SuppressFinalize`, the code snippet becomes:

```c#
using Java.Util;
using MASES.JNet.Extensions;
using System.Diagnostics;
using Java.Lang;

namespace MASES.JNetExample
{
    class MyJNetCore : JNetCore<MyJNetCore> { }

    class Program
    {
        static void Main(string[] args)
        {
            MyJNetCore.CreateGlobalInstance();
            try
            {
                Java.Util.Set<string> set = Collections.Singleton("test");
                try
                {
                    System.GC.SuppressFinalize(set);
                    ArrayList<string> arrayList = new();
                    arrayList.AddAll(0, set);
                }
                finally { System.GC.ReRegisterForFinalize(set); }
            }
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
        }
    }
}
```
