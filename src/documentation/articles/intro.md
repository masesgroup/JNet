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
[![.NET 8+](https://img.shields.io/badge/.NET-8%2B-purple)](https://dotnet.microsoft.com/)

|JNet | JNet.Templates| JNetCLICore | JNetPSCore | JNetCLI | JNetReflector | JNetPS |
|:---:	|:---:	|:---:	|:---:	|:---:	|:---:	|:---:	|
|[![JNet nuget](https://img.shields.io/nuget/v/MASES.JNet)](https://www.nuget.org/packages/MASES.JNet)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNet)](https://www.nuget.org/packages/MASES.JNet) | [![JNet.Templates nuget](https://img.shields.io/nuget/v/MASES.JNet.Templates)](https://www.nuget.org/packages/MASES.JNet.Templates)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNet.Templates)](https://www.nuget.org/packages/MASES.JNet.Templates)| [![JNetCLICore nuget](https://img.shields.io/nuget/v/MASES.JNetCLICore)](https://www.nuget.org/packages/MASES.JNetCLICore)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNetCLICore)](https://www.nuget.org/packages/MASES.JNetCLICore)| [![JNetPSCore nuget](https://img.shields.io/nuget/v/MASES.JNetPSCore)](https://www.nuget.org/packages/MASES.JNetPSCore)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNetPSCore)](https://www.nuget.org/packages/MASES.JNetPSCore)| [![JNetCLI nuget](https://img.shields.io/nuget/v/MASES.JNetCLI)](https://www.nuget.org/packages/MASES.JNetCLI)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNetCLI)](https://www.nuget.org/packages/MASES.JNetCLI)| [![JNetReflector nuget](https://img.shields.io/nuget/v/MASES.JNetReflector)](https://www.nuget.org/packages/MASES.JNetReflector)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNetReflector)](https://www.nuget.org/packages/MASES.JNetReflector)| [![JNetPS](https://img.shields.io/powershellgallery/v/MASES.JNetPS.svg?style=flat-square&label=MASES.JNetPS)](https://www.powershellgallery.com/packages/MASES.JNetPS/)|

### Pipelines

[![CI_BUILD](https://github.com/masesgroup/JNet/actions/workflows/build.yaml/badge.svg)](https://github.com/masesgroup/JNet/actions/workflows/build.yaml) 
[![CodeQL](https://github.com/masesgroup/JNet/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/masesgroup/JNet/actions/workflows/codeql-analysis.yml)
[![CI_RELEASE](https://github.com/masesgroup/JNet/actions/workflows/release.yaml/badge.svg)](https://github.com/masesgroup/JNet/actions/workflows/release.yaml) 

### Project disclaimer

JNet is a suite, curated by MASES Group, can be supported by the open-source community.

Its primary scope is to support other, public or internal, MASES Group projects: open-source community and commercial entities can use it for their needs and support this project, moreover there are dedicated community and commercial subscription plans.

The repository code and releases may contain bugs, the release cycle depends from critical discovered issues and/or enhancement requested from this or other projects.

Looking for the help of experts? MASES Group can help you design, build, deploy, and manage applications mixing .NET and JVM™ enabled languages.

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

Do you like the project? 
- Request your free [community subscription](https://www.jcobridge.com/pricing-25/).

Do you want to help us?
- put a :star: on this project
- open [issues](https://github.com/masesgroup/JNet/issues) to request features or report bugs :bug:
- improves the project with Pull Requests

This project adheres to the Contributor [Covenant code of conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to coc_reporting@masesgroup.com.
