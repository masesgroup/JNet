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
> Need a build for a legacy or out-of-support target, or expert help with .NET and JVM™ integration? See [Professional Support Options](src/documentation/articles/support.md).

### Pipelines

[![CI_BUILD](https://github.com/masesgroup/JNet/actions/workflows/build.yaml/badge.svg)](https://github.com/masesgroup/JNet/actions/workflows/build.yaml) 
[![CodeQL](https://github.com/masesgroup/JNet/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/masesgroup/JNet/actions/workflows/codeql-analysis.yml)
[![CI_RELEASE](https://github.com/masesgroup/JNet/actions/workflows/release.yaml/badge.svg)](https://github.com/masesgroup/JNet/actions/workflows/release.yaml) 

### Project disclaimer

JNet is a suite for Java™/JVM™, maintained by MASES Group and open to community contributions.
Its primary scope is to support other MASES Group projects — both open-source and commercial — though it is freely available for any use. Dedicated community and commercial subscription plans are available.
The repository and releases may contain bugs. The release cycle depends on critical issues discovered and/or enhancement requests from this or other dependent projects.

Looking for expertise in applications mixing .NET and JVM™-enabled languages? MASES Group can help you design, build, deploy, and manage applications that run .NET and Java™/JVM™ side-by-side. [Find out more.](src/documentation/articles/support.md)

---

## Scope of the project

This project aims to create a set of libraries and tools to direct access, from .NET, all the features available in the Java™ Platform, this is the counterpart of [JCOReflector](https://github.com/masesgroup/JCOReflector).

There are many client libraries written to manage communication with Java™. Conversely, this project use directly the Java™ packages giving more than one benefit:
* all implemented features are availables at no extra implementation costs, see [JNet usage](src/documentation/articles/usage.md);
* avoids any third party communication protocol implementation;
* access all features made available from Java™ platform.

So, for example, do you want an `ArrayList`? Just write in C# a line of code like this:

For example, to use a Java `ArrayList` directly from C#:
```csharp
using Java.Util;

var alist = new ArrayList<string>();
alist.Add("Hello from JNet");
```

JNet maps Java types — including generics — to their C# equivalents, so you can work with them
using familiar syntax without any manual marshalling or conversion.

See [JNet usage](src/documentation/articles/usage.md) for a comprehensive walkthrough.

### Community and Contribution

If you find JNet useful:

* Leave a ⭐ on the repository
* Open [issues](https://github.com/masesgroup/JNet/issues) to report bugs 🐛 or request features
* Submit Pull Requests to improve the project

This project adheres to the Contributor [Covenant code of conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to coc_reporting@masesgroup.com.

## Summary

* [Roadmap](src/documentation/articles/roadmap.md)
* [Current state](src/documentation/articles/currentstate.md)
* [JNet usage](src/documentation/articles/usage.md)
* [JNet performance](src/documentation/articles/performance.md)
* [JNet performance tips](src/documentation/articles/performancetips.md)
* [JNet APIs extensibility](src/documentation/articles/API_extensibility.md)
* [JNet JVM™ callbacks](src/documentation/articles/jvm_callbacks.md)
* [JNet CLI usage](src/documentation/articles/usageCLI.md)
* [JNet Docker usage](src/documentation/articles/docker.md)
* [JNet Reflector usage](src/documentation/articles/usageReflector.md)
* [JNet PowerShell usage](src/documentation/articles/usagePS.md)
* [JNet Command-line switches](src/documentation/articles/commandlineswitch.md)

### Performance

JNet interop overhead is tracked continuously across .NET and JDK versions:
- [Latest benchmark results](src/documentation/articles/benchmark-latest.md)
- [Live benchmark dashboard](https://masesgroup.com/benchmark-data/)

Median across the CI matrix, split by CPU class (arm64, x86-64-v3, x86-64-v4). The spread (IQR) reflects differences between OS, .NET, JDK and runner CPU/clock combinations, not measurement noise; "Best" is the lowest run observed, with the matrix cell and CPU that produced it.
<!-- BENCHMARK-SUMMARY-START -->

**arm64**

| Benchmark | Median | IQR (25th–75th) | Best | Best cell | Best CPU | Allocated | Runs |
|---|---:|---:|---:|---|---|---:|---:|
| Static no-arg invocation | 150.3 ns | 146.7 ns – 155.8 ns | 132.1 ns | `core-ubuntu-22.04-arm_net10.0_temurin_17` | unknown | 0 B | 88 |
| Static invocation with feedback | 513.1 ns | 508.1 ns – 520.1 ns | 494.0 ns | `core-ubuntu-22.04-arm_net10.0_graalvm_25` | unknown | 248 B | 88 |
| Sustained JVM→.NET callback (first gate discard) | 44.85 ns | 44.04 ns – 46.63 ns | 42.49 ns | `core-ubuntu-24.04-arm_net11.0_zulu_25` | Neoverse-N2 | 0 B | 88 |
| Sustained JVM→.NET callback (full processing) | 2,590.79 ns | 2,534.48 ns – 2,676.63 ns | 2,444.55 ns | `core-ubuntu-22.04-arm_net11.0_temurin_25` | unknown | 592 B | 88 |
| Object creation | 796.1 ns | 786.2 ns – 807.5 ns | 768.9 ns | `core-ubuntu-22.04-arm_net11.0_temurin_21` | unknown | 368 B | 88 |
| Invoke with int[] (10000 elements) | 6,169.5 ns | 6,101.8 ns – 6,225.9 ns | 4,471.9 ns | `core-ubuntu-22.04-arm_net11.0_graalvm_17` | unknown | 344 B | 88 |
| Get instance int field | 66.22 ns | 64.23 ns – 68.59 ns | 61.20 ns | `core-ubuntu-22.04-arm_net10.0_corretto_11` | unknown | 24 B | 88 |
| Set instance int field | 94.76 ns | 91.53 ns – 97.26 ns | 81.93 ns | `core-ubuntu-22.04-arm_net10.0_microsoft_17` | unknown | 24 B | 88 |
| Get instance string field | 83.91 ns | 81.28 ns – 87.42 ns | 74.60 ns | `core-ubuntu-22.04-arm_net10.0_temurin_17` | unknown | 0 B | 88 |
| Set instance string field | 535.92 ns | 527.20 ns – 543.08 ns | 508.76 ns | `core-ubuntu-22.04-arm_net11.0_oracle_17` | unknown | 248 B | 88 |

**x64 – x86-64-v3 (AVX2)**

| Benchmark | Median | IQR (25th–75th) | Best | Best cell | Best CPU | Allocated | Runs |
|---|---:|---:|---:|---|---|---:|---:|
| Static no-arg invocation | 145.8 ns | 135.9 ns – 154.6 ns | 119.8 ns | `core-ubuntu-24.04_net10.0_zulu_21` | AMD EPYC 7763 2.45GHz | 0 B | 28 |
| Static invocation with feedback | 540.0 ns | 450.9 ns – 555.6 ns | 406.3 ns | `core-ubuntu-24.04_net11.0_microsoft_21` | AMD EPYC 9V74 2.87GHz | 248 B | 28 |
| Sustained JVM→.NET callback (first gate discard) | 34.18 ns | 30.09 ns – 34.42 ns | 28.98 ns | `core-ubuntu-24.04_net10.0_zulu_21` | AMD EPYC 7763 2.45GHz | 0 B | 28 |
| Sustained JVM→.NET callback (full processing) | 3,037.45 ns | 2,658.95 ns – 3,113.80 ns | 2,110.77 ns | `core-ubuntu-24.04_net11.0_microsoft_21` | AMD EPYC 9V74 2.87GHz | 592 B | 28 |
| Object creation | 876.7 ns | 756.9 ns – 920.7 ns | 688.9 ns | `core-ubuntu-24.04_net10.0_zulu_21` | AMD EPYC 7763 2.45GHz | 368 B | 28 |
| Invoke with int[] (10000 elements) | 7,903.5 ns | 7,147.0 ns – 7,999.5 ns | 5,071.9 ns | `core-ubuntu-24.04_net10.0_graalvm_25` | AMD EPYC 7763 3.24GHz | 344 B | 28 |
| Get instance int field | 74.09 ns | 56.33 ns – 75.79 ns | 49.15 ns | `core-ubuntu-24.04_net10.0_zulu_21` | AMD EPYC 7763 2.45GHz | 24 B | 28 |
| Set instance int field | 81.15 ns | 62.50 ns – 84.81 ns | 55.74 ns | `core-ubuntu-24.04_net10.0_temurin_25` | AMD EPYC 7763 3.20GHz | 24 B | 28 |
| Get instance string field | 72.35 ns | 58.99 ns – 74.74 ns | 51.78 ns | `core-ubuntu-24.04_net11.0_microsoft_21` | AMD EPYC 9V74 2.87GHz | 0 B | 28 |
| Set instance string field | 561.15 ns | 489.83 ns – 591.99 ns | 413.96 ns | `core-ubuntu-24.04_net11.0_microsoft_21` | AMD EPYC 9V74 2.87GHz | 248 B | 28 |

**x64 – x86-64-v4 (AVX-512)**

| Benchmark | Median | IQR (25th–75th) | Best | Best cell | Best CPU | Allocated | Runs |
|---|---:|---:|---:|---|---|---:|---:|
| Static no-arg invocation | 78.41 ns | 72.21 ns – 108.5 ns | 65.47 ns | `core-ubuntu-24.04_net11.0_corretto_25` | AMD EPYC 9V45 4.50GHz | 0 B | 60 |
| Static invocation with feedback | 277.81 ns | 259.78 ns – 360.49 ns | 224.17 ns | `core-ubuntu-24.04_net11.0_corretto_25` | AMD EPYC 9V45 4.50GHz | 248 B | 60 |
| Sustained JVM→.NET callback (first gate discard) | 36.42 ns | 31.88 ns – 37.58 ns | 23.95 ns | `core-ubuntu-24.04_net10.0_temurin_17` | AMD EPYC 9V74 3.67GHz | 0 B | 60 |
| Sustained JVM→.NET callback (full processing) | 1,780.81 ns | 1,729.60 ns – 2,074.61 ns | 1,369.69 ns | `core-ubuntu-24.04_net11.0_corretto_25` | AMD EPYC 9V45 4.50GHz | 592 B | 60 |
| Object creation | 528.2 ns | 511.0 ns – 651.4 ns | 430.0 ns | `core-ubuntu-24.04_net11.0_corretto_25` | AMD EPYC 9V45 4.50GHz | 368 B | 60 |
| Invoke with int[] (10000 elements) | 7,530.5 ns | 5,839.2 ns – 7,748.2 ns | 4,348.8 ns | `core-ubuntu-24.04_net11.0_corretto_25` | AMD EPYC 9V45 4.50GHz | 344 B | 60 |
| Get instance int field | 37.84 ns | 32.92 ns – 50.33 ns | 24.50 ns | `core-ubuntu-24.04_net11.0_corretto_25` | AMD EPYC 9V45 4.50GHz | 24 B | 60 |
| Set instance int field | 45.49 ns | 40.25 ns – 61.22 ns | 32.94 ns | `core-ubuntu-24.04_net11.0_corretto_25` | AMD EPYC 9V45 4.50GHz | 24 B | 60 |
| Get instance string field | 39.92 ns | 35.60 ns – 52.64 ns | 31.97 ns | `core-ubuntu-24.04_net11.0_corretto_25` | AMD EPYC 9V45 4.50GHz | 0 B | 60 |
| Set instance string field | 315.10 ns | 299.64 ns – 391.94 ns | 232.19 ns | `core-ubuntu-24.04_net11.0_corretto_25` | AMD EPYC 9V45 4.50GHz | 248 B | 60 |

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
* **Dynamic code**: it helps to write a Java/Scala/Kotlin/etc seamless language code directly inside a standard .NET application written in C#/VB.NET: look at this [simple example](https://www.jcobridge.com/net-examples/dotnet-examples/) and [JNet APIs extensibility](src/documentation/articles/API_extensibility.md).

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
