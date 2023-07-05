# JNet usage

To use JNet classes the developer can write code in .NET using the same classes available in the official Java packages.
If classes or methods are not available yet it is possible to use the approach synthetized in [What to do if an API was not yet implemented](API_extensibility.md)

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
                var set = Collections.Singleton("test");
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