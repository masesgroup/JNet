---
title: .NET suite for Java™/JVM™
_description: Main page of .NET suite for Java™/JVM™
---

# JNet: .NET suite for Java™/JVM™

JNet is a comprehensive suite of libraries and tools to use Java™/JVM™ APIs (Java, Scala, Kotlin, ...) and .NET side-by-side.

## Key Features

- ✅ **Java 8+ Support** - Works with legacy Java 8 systems through modern Java 25
- ✅ **Zero Migration Required** - Integrate existing Java 8 code with .NET applications
- ✅ **Direct API Access** - Call any Java API directly from C#/VB.NET
- ✅ **Bidirectional** - Java can call .NET and vice versa (see [JCOReflector](https://github.com/masesgroup/JCOReflector))

> **💡 Legacy Integration:** Still running Java 8 in production? JNet enables 
> integration with modern .NET applications without requiring Java upgrades—saving 
> months of migration work and significant costs.

### Libraries and Tools

[![Java 8+](https://img.shields.io/badge/Java-8%2B-blue)](https://www.oracle.com/java/)
[![.NET 10+](https://img.shields.io/badge/.NET-10%2B-purple)](https://dotnet.microsoft.com/)

| Package | Version | Downloads |
|:--|:--:|:--:|
| **JNet** | [![JNet nuget](https://img.shields.io/nuget/v/MASES.JNet)](https://www.nuget.org/packages/MASES.JNet) | [![JNet downloads](https://img.shields.io/nuget/dt/MASES.JNet)](https://www.nuget.org/packages/MASES.JNet) |
| **JNet.Templates** | [![JNet.Templates nuget](https://img.shields.io/nuget/v/MASES.JNet.Templates)](https://www.nuget.org/packages/MASES.JNet.Templates) | [![JNet.Templates downloads](https://img.shields.io/nuget/dt/MASES.JNet.Templates)](https://www.nuget.org/packages/MASES.JNet.Templates) |
| **JNetCLICore** | [![JNetCLICore nuget](https://img.shields.io/nuget/v/MASES.JNetCLICore)](https://www.nuget.org/packages/MASES.JNetCLICore) | [![JNetCLICore downloads](https://img.shields.io/nuget/dt/MASES.JNetCLICore)](https://www.nuget.org/packages/MASES.JNetCLICore) |
| **JNetPSCore** | [![JNetPSCore nuget](https://img.shields.io/nuget/v/MASES.JNetPSCore)](https://www.nuget.org/packages/MASES.JNetPSCore) | [![JNetPSCore downloads](https://img.shields.io/nuget/dt/MASES.JNetPSCore)](https://www.nuget.org/packages/MASES.JNetPSCore) |
| **JNetCLI** | [![JNetCLI nuget](https://img.shields.io/nuget/v/MASES.JNetCLI)](https://www.nuget.org/packages/MASES.JNetCLI) | [![JNetCLI downloads](https://img.shields.io/nuget/dt/MASES.JNetCLI)](https://www.nuget.org/packages/MASES.JNetCLI) |
| **JNetReflector** | [![JNetReflector nuget](https://img.shields.io/nuget/v/MASES.JNetReflector)](https://www.nuget.org/packages/MASES.JNetReflector) | [![JNetReflector downloads](https://img.shields.io/nuget/dt/MASES.JNetReflector)](https://www.nuget.org/packages/MASES.JNetReflector) |
| **JNetPS** | [![JNetPS PowerShell Gallery](https://img.shields.io/powershellgallery/v/MASES.JNetPS.svg?label=PowerShell%20Gallery)](https://www.powershellgallery.com/packages/MASES.JNetPS/) | [![JNetPS downloads](https://img.shields.io/powershellgallery/dt/MASES.JNetPS.svg)](https://www.powershellgallery.com/packages/MASES.JNetPS/) |

> [!NOTE]
> This project follows the target framework support of **JCOBridge**, which in turn follows the Microsoft .NET support lifecycle. The public releases do not take on the maintenance of runtimes that Microsoft no longer supports: when Microsoft ends support for a .NET version, that target is dropped starting with the next JCOBridge release.
>
> Need a build for a legacy or out-of-support target, or expert help with .NET and JVM™ integration? See [Professional Support Options](articles/support.md).

### Project disclaimer

JNet is a suite for Java™/JVM™, maintained by MASES Group and open to community contributions.
Its primary scope is to support other MASES Group projects — both open-source and commercial — though it is freely available for any use. Dedicated community and commercial subscription plans are available.
The repository and releases may contain bugs. The release cycle depends on critical issues discovered and/or enhancement requests from this or other dependent projects.

Looking for expertise in applications mixing .NET and JVM™-enabled languages? MASES Group can help you design, build, deploy, and manage applications that run .NET and Java™/JVM™ side-by-side. [Find out more.](articles/support.md)

---

## Scope of the project

This project aims to create a set of libraries and tools to direct access, from .NET, all the features available in the Java™ Platform, this is the counterpart of [JCOReflector](https://github.com/masesgroup/JCOReflector).

There are many client libraries written to manage communication with Java™. Conversely, this project use directly the Java™ packages giving more than one benefit:
* all implemented features are availables at no extra implementation costs, see [JNet usage](articles/usage.md);
* avoids any third party communication protocol implementation;
* access all features made available from Java™ platform.

For example, to use a Java `ArrayList` directly from C#:
```csharp
using Java.Util;

var alist = new ArrayList<string>();
alist.Add("Hello from JNet");
```

JNet maps Java types — including generics — to their C# equivalents, so you can work with them
using familiar syntax without any manual marshalling or conversion.

See [JNet usage](articles/usage.md) for a comprehensive walkthrough.

### Community and Contribution

If you find JNet useful:

* Leave a ⭐ on the repository
* Open [issues](https://github.com/masesgroup/JNet/issues) to report bugs 🐛 or request features
* Submit Pull Requests to improve the project

This project adheres to the Contributor [Covenant code of conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to coc_reporting@masesgroup.com.

## Summary

* [Roadmap](articles/roadmap.md)
* [Current state](articles/currentstate.md)
* [JNet usage](articles/usage.md)
* [JNet performance](articles/performance.md)
* [JNet performance tips](articles/performancetips.md)
* [JNet APIs extensibility](articles/API_extensibility.md)
* [JNet JVM™ callbacks](articles/jvm_callbacks.md)
* [JNet CLI usage](articles/usageCLI.md)
* [JNet Docker usage](articles/docker.md)
* [JNet Reflector usage](articles/usageReflector.md)
* [JNet PowerShell usage](articles/usagePS.md)
* [JNet Command-line switches](articles/commandlineswitch.md)

### Performance

JNet interop overhead is tracked continuously across .NET and JDK versions:
- [Latest benchmark results](articles/benchmark-latest.md)
- [Live benchmark dashboard](https://masesgroup.com/benchmark-data/)

Median across the CI matrix for each CPU class; below each median, the interquartile range (IQR) and the lowest run observed, with the CPU of the runner that produced it. The spread reflects differences between OS, .NET, JDK and runner hardware, not measurement noise. The x64 columns group runners by the instruction set the runtime detected, so CPU models within a column still vary. Results per CPU model, with allocations, are in [JNet performance](articles/performance.md).
<!-- BENCHMARK-SUMMARY-START -->

| Benchmark | arm64, 88 runs | x64 AVX2 (v3), 33 runs | x64 AVX-512 (v4), 55 runs |
|---|---:|---:|---:|
| Sustained JVM→.NET callback (first gate discard) | **45.24 ns**<br><sub>IQR 43.79 – 47.40 ns · lowest 42.18 ns (Neoverse-N2)</sub> | **34.15 ns**<br><sub>IQR 30.33 – 35.23 ns · lowest 28.67 ns (AMD EPYC 7763 2.45GHz)</sub> | **35.20 ns**<br><sub>IQR 28.61 – 38.28 ns · lowest 23.61 ns (AMD EPYC 9V74 3.66GHz)</sub> |
| Sustained JVM→.NET callback (full processing) | **2,602.75 ns**<br><sub>IQR 2,515.40 – 2,673.88 ns · lowest 2,190.45 ns (Neoverse-V3)</sub> | **3,027.72 ns**<br><sub>IQR 2,660.82 – 3,125.41 ns · lowest 2,461.00 ns (AMD EPYC 7763 2.59GHz)</sub> | **1,776.83 ns**<br><sub>IQR 1,709.30 – 2,103.91 ns · lowest 1,375.08 ns (AMD EPYC 9V45 4.25GHz)</sub> |
| Static no-arg invocation | **150.2 ns**<br><sub>IQR 146.9 – 155.1 ns · lowest 115.3 ns (Neoverse-V3)</sub> | **142.6 ns**<br><sub>IQR 131.6 – 150.9 ns · lowest 118.3 ns (AMD EPYC 7763 2.59GHz)</sub> | **104.22 ns**<br><sub>IQR 75.32 – 115.2 ns · lowest 68.44 ns (AMD EPYC 9V45 4.34GHz)</sub> |
| Static invocation with feedback | **512.7 ns**<br><sub>IQR 506.4 – 519.8 ns · lowest 397.1 ns (Neoverse-V3)</sub> | **546.2 ns**<br><sub>IQR 458.5 – 560.5 ns · lowest 413.3 ns (AMD EPYC 7763 3.24GHz)</sub> | **294.04 ns**<br><sub>IQR 268.50 – 378.2 ns · lowest 223.50 ns (AMD EPYC 9V45 4.25GHz)</sub> |
| Object creation | **793.9 ns**<br><sub>IQR 787.4 – 805.8 ns · lowest 731.6 ns (Neoverse-V3)</sub> | **881.4 ns**<br><sub>IQR 746.1 – 934.4 ns · lowest 690.7 ns (AMD EPYC 7763 3.24GHz)</sub> | **551.0 ns**<br><sub>IQR 514.8 – 662.1 ns · lowest 438.1 ns (AMD EPYC 9V45 4.25GHz)</sub> |
| Invoke with int[] (10000 elements) | **6,171.6 ns**<br><sub>IQR 6,121.9 – 6,234.7 ns · lowest 4,548.1 ns (Neoverse-N2)</sub> | **7,912.5 ns**<br><sub>IQR 7,645.9 – 8,001.2 ns · lowest 5,068.5 ns (AMD EPYC 7763 2.78GHz)</sub> | **6,292.0 ns**<br><sub>IQR 5,819.7 – 7,792.2 ns · lowest 2,490.9 ns (AMD EPYC 9V45 4.30GHz)</sub> |
| Get instance int field | **66.09 ns**<br><sub>IQR 64.28 – 68.87 ns · lowest 56.72 ns (Neoverse-V3)</sub> | **73.99 ns**<br><sub>IQR 53.59 – 75.66 ns · lowest 47.05 ns (AMD EPYC 7763 3.24GHz)</sub> | **39.80 ns**<br><sub>IQR 33.53 – 53.40 ns · lowest 27.67 ns (AMD EPYC 9V45 4.34GHz)</sub> |
| Set instance int field | **93.82 ns**<br><sub>IQR 90.43 – 97.58 ns · lowest 78.74 ns (Neoverse-V3)</sub> | **80.74 ns**<br><sub>IQR 62.49 – 83.33 ns · lowest 55.06 ns (AMD EPYC 7763 2.60GHz)</sub> | **48.63 ns**<br><sub>IQR 41.97 – 60.29 ns · lowest 35.57 ns (AMD EPYC 9V45 4.25GHz)</sub> |
| Get instance string field | **84.80 ns**<br><sub>IQR 81.30 – 86.87 ns · lowest 71.47 ns (Neoverse-V3)</sub> | **71.93 ns**<br><sub>IQR 58.37 – 74.16 ns · lowest 51.05 ns (AMD EPYC 7763 2.60GHz)</sub> | **46.25 ns**<br><sub>IQR 38.13 – 52.59 ns · lowest 31.67 ns (AMD EPYC 9V45 4.34GHz)</sub> |
| Set instance string field | **535.46 ns**<br><sub>IQR 525.77 – 543.70 ns · lowest 464.46 ns (Neoverse-V3)</sub> | **559.15 ns**<br><sub>IQR 463.09 – 607.32 ns · lowest 413.07 ns (AMD EPYC 7763 3.24GHz)</sub> | **329.33 ns**<br><sub>IQR 301.71 – 402.29 ns · lowest 258.80 ns (AMD EPYC 9V45 4.34GHz)</sub> |

<!-- BENCHMARK-SUMMARY-END -->

### Recent changes

* V2.6.x: aligns to JCOBridge 2.6.* series
  * V2.6.6: adds support for JavaSE 8  
* V2.5.13: adds [JNetCLICore](https://www.nuget.org/packages/MASES.JNetCLICore) to help CLI operations across projects based on JNet  
* V2.5.11: updates to JCOBridge 2.5.21 and adds management of [CET](https://www.intel.com/content/www/us/en/developer/articles/technical/technical-look-control-flow-enforcement-technology.html) on recent Intel CPUs due to [latest change on .NET 9](https://learn.microsoft.com/en-us/dotnet/core/compatibility/interop/9.0/cet-support); usage explanation in [this section](articles/usage.md#intel-cet-and-jnet) 
* V2.5.0+: the most notable changes are:  
  * Tools and Docker images updated to .NET 8  
  * **JNetReflector**: create side-by-side class for each listener used in case of pure JVM™ interface (see <https://github.com/masesgroup/JNet/issues/393>)  
  * **JNet**:  
    * review of classes based on latest JNetReflector  
    * enhanced ByteBuffer management  
    * speed-up in array/list conversion  
* V2.4.0+: the most notable changes are:  
  * **JNet**: review of classes based on latest updates of JNetReflector  
  * **JNetReflector**: use native types only when the JVM™ counterpart is a native type (see <https://github.com/masesgroup/JNet/issues/371>)  
  * **JNetReflector**: can use signature to invoke JVM™ methods or fallback to previous behavior (see <https://github.com/masesgroup/JNet/issues/374>)  
* V2.3.0+: the most notable changes are:  
  * **JNet**: review of classes based on latest updates of JNetReflector  
  * **JNetReflector**: use `Java.Lang.String` by default instead of `string` (`System.String`) (see <https://github.com/masesgroup/JNet/issues/363>)  
* V2.0.0+: major updates:  
  * **JNet**: complete review of all classes based on automatic JNetReflector generation  
  * **JNetReflector**: improvements from .NET interface generation to generics and where clauses (details: <https://github.com/masesgroup/JNet/issues/178>)  
* V1.5.3+: JNetReflector manages generics and covers almost all Java™ SE 11 classes: see [JNet Reflector usage](articles/usageReflector.md)
* V1.5.2+: major improvements to JNetReflector; used to generate almost all Java™ 11 classes for that JNet version  
* V1.4.9+: introduces two new projects:  
  * **JNetPSCore**: core library for PowerShell development  
  * **JNetPS**: PowerShell module for using JNet in a PowerShell shell  
* V1.4.8+: introduces **JNetReflector**, a new project (in development) able to build C# gateway classes from JARs, similar to [JCOReflector](https://github.com/masesgroup/JCOReflector) but for JVM™ classes  

## Frequently Asked Questions

### Does JNet support Java 8?

**Yes!** JNet fully supports Java 8 (JRE 1.8.0_161 or later) through Java 25. 
This is critical for enterprises with legacy Java 8 systems in production.

### Do I need to upgrade my Java 8 code to use JNet?

**No!** JNet works with your existing Java 8 bytecode without any modifications. 
You can integrate legacy Java 8 systems with modern .NET applications immediately.

### What about Java 8 End of Life?

Oracle provides Extended Support for Java 8 until December 2030. Many vendors 
(Amazon Corretto, Azul, Red Hat) provide free long-term support. JNet gives you 
flexibility: integrate now with Java 8, migrate Java when your timeline permits.

### Can I mix different Java versions in my application?

**Yes!** Java is backward compatible. A newer JVM can execute bytecode 
compiled with older Java versions.

**Example:** Using Java 17 JVM, you can call:
- Java 8 libraries ✅
- Java 11 libraries ✅  
- Java 17 libraries ✅

All in the same .NET process, with zero migration needed for older code!

**Simple rule:** Use the highest Java version required by any of your 
dependencies. That JVM will run all older bytecode versions.

### Do I need to upgrade my Java 8 code to use newer Java libraries?

**No!** Just upgrade the JVM to Java 17 (or whatever version the new 
library requires). Your Java 8 bytecode will continue working without 
any code changes.

This is Java's backward compatibility guarantee in action.

### What if I try to use Java 17 bytecode with Java 8 JVM?

You'll get an `UnsupportedClassVersionError`. Java doesn't support 
forward compatibility - older JVMs cannot run newer bytecode.

**Solution:** Upgrade to Java 17 JVM. Your Java 8 code will still work!

---

## Runtime engine

JNet uses [JCOBridge](https://www.jcobridge.com), and its [features](https://www.jcobridge.com/features/), to obtain many benefits:
* **Cyber-security**: 
  * [JVM™](https://en.wikipedia.org/wiki/Java_virtual_machine) and [CLR, or CoreCLR,](https://en.wikipedia.org/wiki/Common_Language_Runtime) runs in the same process, but are insulated from each other;
  * JCOBridge does not make any code injection into JVM™;
  * JCOBridge does not use any other communication mechanism than JNI;
  * .NET (CLR) inherently inherits the cyber-security levels of running JVM™; 
* **Direct access to the JVM™ from any .NET application**: 
  * Any Java/Scala/Kotlin/... class can be directly managed;
  * No need to learn new APIs: we try to expose the same APIs in C# style;
  * No extra validation cycle on protocol and functionality: bug fix, improvements, new features are immediately available;
  * Documentation is shared;
* **Dynamic code**: it helps to write a Java/Scala/Kotlin/etc seamless language code directly inside a standard .NET application written in C#/VB.NET: look at this [simple example](https://www.jcobridge.com/net-examples/dotnet-examples/) and [JNet APIs extensibility](articles/API_extensibility.md).

> [!NOTE]
> [JCOBridge 2.6.*](https://www.jcobridge.com) can be used for free without any obligations. A commercial license must be purchased — or the software uninstalled — if you derive direct or indirect income from its usage.

### Supported Versions

**Java:**
- ✅ Java 8 (JRE 1.8.0_161 or later)
- ✅ Java 11 (LTS)
- ✅ Java 17 (LTS)
- ✅ Java 21 (LTS)
- ✅ Java 25 (LTS)

**Note:** Works with Oracle JDK, OpenJDK, Amazon Corretto, Azul Zulu, and other compatible distributions.

**.NET:**
- .NET Framework 4.6.2+
- .NET 10, 11

> **Java 8 Extended Support** runs until December 2030. JNet provides a migration 
> path: integrate Java 8 systems with modern .NET now, migrate Java when ready.

### JCOBridge resources

Have a look at the following JCOBridge resources:

|JCOBridge | 2.5.* series | 2.6.* series |
|:---:	|:---:	|:---:	|
|JNet | > 1.5.* series | > 2.6.* series |
|Release notes|[Link](https://www.jcobridge.com/release-notes/)| [Link](https://www.jcobridge.com/release-notes/)|
|Community Edition|[Conditions](https://www.jcobridge.com/pricing-25/)|[Conditions](https://www.jcobridge.com/pricing-26/)|
|Commercial Edition|[Information](https://www.jcobridge.com/pricing-25/)|[Information](https://www.jcobridge.com/pricing-26/)|

Latest release: [![JCOBridge nuget](https://img.shields.io/nuget/v/MASES.JCOBridge)](https://www.nuget.org/packages/MASES.JCOBridge)
