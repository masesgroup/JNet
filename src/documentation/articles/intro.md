---
title: Introduction to .NET suite for Java™/JVM™
_description: Introduction to .NET suite for Java™/JVM™
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
> Need a build for a legacy or out-of-support target, or expert help with .NET and JVM™ integration? See [Professional Support Options](src/documentation/articles/support.md).

### Project disclaimer

JNet is a suite for Java™/JVM™, maintained by MASES Group and open to community contributions.
Its primary scope is to support other MASES Group projects — both open-source and commercial — though it is freely available for any use. Dedicated community and commercial subscription plans are available.
The repository and releases may contain bugs. The release cycle depends on critical issues discovered and/or enhancement requests from this or other dependent projects.

Looking for expertise in applications mixing .NET and JVM™-enabled languages? MASES Group can help you design, build, deploy, and manage applications that run .NET and Java™/JVM™ side-by-side. [Find out more.](support.md)

---

## Scope of the project

This project aims to create a set of libraries and tools to direct access, from .NET, all the features available in the Java™ Platform, this is the counterpart of [JCOReflector](https://github.com/masesgroup/JCOReflector).

There are many client libraries written to manage communication with Java™. Conversely, this project use directly the Java™ packages giving more than one benefit:
* all implemented features are availables at no extra implementation costs, see [JNet usage](usage.md);
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

See [JNet usage](usage.md) for a comprehensive walkthrough.

### Community and Contribution

If you find JNet useful:

* Leave a ⭐ on the repository
* Open [issues](https://github.com/masesgroup/JNet/issues) to report bugs 🐛 or request features
* Submit Pull Requests to improve the project

This project adheres to the Contributor [Covenant code of conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to coc_reporting@masesgroup.com.
