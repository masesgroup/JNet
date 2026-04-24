---
title: Using JNet — .NET suite for Java™/JVM™
_description: How to configure the environment, locate the JVM™, and write robust JNet code
---

# JNet usage

JNet exposes Java™ classes directly in .NET, letting you write C# code against the same types
available in the official Java™ packages. If a class or method has not been mapped yet, see
[What to do if an API was not yet implemented](API_extensibility.md).

## Environment setup

JNet accepts many command-line switches to customize its behavior. The full list is available at the [Command line switch](commandlineswitch.md) page.

### JVM™ identification

One of the most important command-line switches is **JVMPath**, available in [JCOBridge switches](https://www.jcobridge.com/net-examples/command-line-options/): it can be used to set the location of the JVM™ library (`jvm.dll` / `libjvm.so`) if JCOBridge is not able to identify a suitable JRE installation.

If you are embedding JNet in your own product, you can override the **JVMPath** property as shown below:

```csharp
class MyJNetCore : JNetCore<MyJNetCore>
{
    // Override JVMPath when JCOBridge cannot auto-detect the JRE/JDK installation,
    // or when you need to pin a specific JVM version in your application.
    public override string JVMPath
    {
        get
        {
            string pathToJVM = "Set here the path to the JVM library (jvm.dll / libjvm.so)";
            return pathToJVM;
        }
    }
}
```

> [!IMPORTANT]
> `pathToJVM` must be properly escaped:
> 1. `string pathToJVM = "C:\\Program Files\\Eclipse Adoptium\\jdk-11.0.18.10-hotspot\\bin\\server\\jvm.dll";`
> 2. `string pathToJVM = @"C:\Program Files\Eclipse Adoptium\jdk-11.0.18.10-hotspot\bin\server\jvm.dll";`

### Special initialization conditions

[JCOBridge](https://www.jcobridge.com/) attempts to locate a suitable JRE/JDK installation using standard mechanisms: the `JAVA_HOME` environment variable or the Windows registry (where available).

If the application fails with **InvalidOperationException: Missing Java Key in registry**, neither `JAVA_HOME` nor the Windows registry contains a reference to a JRE/JDK installation.

**Diagnose the issue:**
1. Open a command prompt and run `set | findstr JAVA_HOME`.
2. If a value is returned, it may be set at user level rather than system level, making it invisible to the JNet process that raised the exception.

**Fix the issue (choose one):**
- Set `JAVA_HOME` at system level, e.g. `JAVA_HOME=C:\Program Files\Eclipse Adoptium\jdk-11.0.18.10-hotspot\`
- Set `JCOBRIDGE_JVMPath` at system level to point directly to the JVM library, e.g. `JCOBRIDGE_JVMPath=C:\Program Files\Eclipse Adoptium\jdk-11.0.18.10-hotspot\bin\server\jvm.dll`

> [!IMPORTANT]
> - At least one of `JCOBRIDGE_JVMPath`, `JAVA_HOME`, or the Windows registry (on Windows) must be available.
> - `JCOBRIDGE_JVMPath` takes precedence over `JAVA_HOME` and the Windows registry: setting it to the full path of `jvm.dll` avoids the need to override `JVMPath` in code.
> - After first initialization, `JVMPath` (set in code) takes precedence over both environment variables and the registry.

### Intel CET and JNet

JNet uses an embedded JVM™ through JCOBridge. However, JVM™ initialization is incompatible with [CET (Control-flow Enforcement Technology)](https://www.intel.com/content/www/us/en/developer/articles/technical/technical-look-control-flow-enforcement-technology.html) because the code used to identify the CPU attempts to modify the return address, which CET treats as a violation — see [this issue comment](https://github.com/masesgroup/JNet/issues/573#issuecomment-2544249107).

From .NET 9 preview 6, [CET is enabled by default on supported hardware](https://learn.microsoft.com/en-us/dotnet/core/compatibility/interop/9.0/cet-support) when the build output is an executable (i.e. the `.csproj` contains `<OutputType>Exe</OutputType>`).

If the application fails at startup with error `0xc0000409` (subcode `0x30`), CET is enabled and conflicting with JVM™ initialization.

> [!TIP]
> Solutions 2 and 3 are the recommended approaches for most projects. Solution 1 requires targeting an older .NET version; solution 4 requires elevated privileges and a registry change.

There are four possible workarounds:

1. Target a .NET version that does not enable CET by default, such as .NET 8.

2. Disable CET for the executable in the `.csproj` (JNet project templates include this automatically):

```xml
<PropertyGroup Condition="'$(TargetFramework)' == 'net9.0'">
    <!--see https://learn.microsoft.com/en-us/dotnet/core/compatibility/interop/9.0/cet-support-->
    <CETCompat>false</CETCompat>
</PropertyGroup>
```

3. Run via the `dotnet` app host instead of the native executable, as described in [this comment](https://github.com/masesgroup/JCOBridgePublic/issues/7#issuecomment-2550031946):

```sh
dotnet MyApplication.dll
```

instead of:

```sh
MyApplication.exe
```

4. Register a CET mitigation for the specific executable from an **elevated shell**:

```sh
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\MyApplication.exe" /v MitigationOptions /t REG_BINARY /d "0000000000000000000000000000002000" /f
```

then run:

```sh
MyApplication.exe
```

## Basic example

Below is a basic example demonstrating how to create a JNet-based program, including generics and exception handling. Comments in the code explain each step.

```csharp
using Java.Util;
using MASES.JNet.Extensions;
using System.Diagnostics;
using Java.Lang;

namespace MASES.JNetExample
{
    // Define a concrete implementation of JNetCore<> for this application.
    class MyJNetCore : JNetCore<MyJNetCore>
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Mandatory first step: allocate the JVM and prepare the interop environment.
            MyJNetCore.CreateGlobalInstance();

            // Arguments not consumed by JNet/JCOBridge are available here,
            // just like standard command-line args.
            var appArgs = MyJNetCore.FilteredArgs;

            try
            {
                // Allocate a java.util.Set<String> in the JVM via Collections.Singleton,
                // returned as a Java.Util.Set<string> on the .NET side.
                Java.Util.Set<string> set = Collections.Singleton("test");

                // Attempt to add an element if one was passed on the command line.
                // Collections.Singleton returns an immutable Set, so this will throw.
                // See: https://docs.oracle.com/javase/8/docs/api/java/util/Collections.html#singleton(T)
                if (appArgs.Length != 0) set.Add(appArgs[0]);
            }
            // JNet translates Java exceptions into equivalent .NET exceptions,
            // so UnsupportedOperationException is caught here just like any C# exception.
            catch (UnsupportedOperationException)
            {
                System.Console.WriteLine("Operation not supported as expected");
            }
            // Catch-all: print any unexpected exception and let the application exit cleanly.
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
        }
    }
}
```

## Avoiding `Java.Lang.NullPointerException` — Understanding .NET/JVM GC interaction

Occasionally, a `Java.Lang.NullPointerException` is raised with no obvious cause in the .NET code. This is a cross-boundary GC issue: the .NET Garbage Collector may collect a JNet wrapper object while the JVM™ is still using the underlying Java object it references.

In the basic example above, `Collections.Singleton("test")` creates a wrapper held by `set`, which remains reachable until `set.Add(appArgs[0])` completes — so the GC does not collect it prematurely.

Consider this slightly different snippet:

```csharp
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
                arrayList.AddAll(0, set); // Java.Lang.NullPointerException may occur here
            }
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
        }
    }
}
```

At the point `arrayList.AddAll(0, set)` is called:
- `Java.Util.Set<string>` is a .NET wrapper around a JVM™ `java.util.Set<String>`.
- The call passes the JVM™ reference across the boundary, but from .NET's perspective the wrapper `set` has no further uses and is eligible for collection.
- If the .NET GC runs at this moment — which it may do arbitrarily based on [memory pressure](https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/) — the wrapper is collected and the JVM™ receives a null reference.

Most of the time the code works fine, but the failure is non-deterministic and hard to reproduce.

### `using` or `try-finally` with `Dispose`

All JNet classes implement `IDisposable`. Wrapping an object in a `using` block keeps it alive for the entire scope and releases the JVM™ global reference deterministically when the block exits:

```csharp
using Java.Util;
using MASES.JNet.Extensions;
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
                using (var set = Collections.Singleton("test"))
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

Or equivalently with `try-finally`:

```csharp
Java.Util.Set<string> set = Collections.Singleton("test");
try
{
    ArrayList<string> arrayList = new();
    arrayList.AddAll(0, set);
}
finally { set?.Dispose(); }
```

> [!TIP]
> The `using` pattern is the most idiomatic approach in modern C# and should be preferred in new code.

### `SuppressFinalize`/`ReRegisterForFinalize` pattern

When restructuring to `using` is not practical, you can suppress finalization for the duration of the cross-boundary call:

```csharp
Java.Util.Set<string> set = Collections.Singleton("test");
try
{
    System.GC.SuppressFinalize(set);
    ArrayList<string> arrayList = new();
    arrayList.AddAll(0, set);
}
finally { System.GC.ReRegisterForFinalize(set); }
```

## Reducing Dispose overhead in high-volume loops

Each `Dispose` on a JNet object releases the underlying JVM™ global reference with a direct native call. In tight loops that create and dispose many JNet objects — such as a Kafka consumer poll loop or a storage enumeration — this per-object native call cost accumulates.

`JCOBridgeDisposeFastScope` and `JCOBridgeDisposeAsyncScope` address this by batching the releases and flushing them in a single native call, keeping the loop body unchanged.

### `JCOBridgeDisposeFastScope` — synchronous hot paths

Use this scope in synchronous code on a controlled thread. It uses thread-local storage with minimal access cost.

```csharp
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
    }
} // all queued releases flushed here in a single native call
```

> [!WARNING]
> `JCOBridgeDisposeFastScope` is not safe across `await` — if a continuation resumes on a different thread the scope state will not be visible. Use `JCOBridgeDisposeAsyncScope` for async code.

### `JCOBridgeDisposeAsyncScope` — async/await contexts

Use this scope when continuations may resume on a different thread. The scope state flows automatically across `await` points.

On .NET 8 and later `JCOBridgeDisposeAsyncScope` implements `IAsyncDisposable`, enabling `await using` and an asynchronous flush on scope exit:

```csharp
// .NET 8 / 9 / 10 — IAsyncDisposable available
await using var batch = new JCOBridgeDisposeAsyncScope();
await foreach (var item in asyncCollection)
{
    using (item)
    {
        await ProcessAsync(item);
    }
} // queued releases flushed asynchronously when the scope exits
```

On .NET Framework `IAsyncDisposable` is not available. Use a standard `using` block — the flush on scope exit is synchronous:

```csharp
// .NET Framework — IDisposable only
using (var batch = new JCOBridgeDisposeAsyncScope())
{
    foreach (var item in collection)
    {
        using (item) { /* item disposal is batched */ }
    }
} // queued releases flushed synchronously when the scope exits
```

> [!NOTE]
> Both scopes are opt-in and additive — code that does not open a scope continues to release references immediately on `Dispose`, with no behavioral change. Scopes are designed to be opened by library code (e.g. storage enumerators, consumer loops) rather than exposed to end users.

See [performance tips](performancetips.md) for guidance on when batch scopes provide meaningful gains.
