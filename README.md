# JNet: .NET gateway for JVM APIs (Java, Scala, Kotlin, ...)

[![CI_BUILD](https://github.com/masesgroup/JNet/actions/workflows/build.yaml/badge.svg)](https://github.com/masesgroup/JNet/actions/workflows/build.yaml) [![CI_RELEASE](https://github.com/masesgroup/JNet/actions/workflows/release.yaml/badge.svg)](https://github.com/masesgroup/JNet/actions/workflows/release.yaml) 

|JNet | JNet.Templates | JNetCLI<br>(version 1.4.8+) | JNetReflector<br>(version 1.4.8+) |
|---	|---	|---	|---	|
|[![JNet nuget](https://img.shields.io/nuget/v/MASES.JNet)](https://www.nuget.org/packages/MASES.JNet) [![downloads](https://img.shields.io/nuget/dt/MASES.JNet)](https://www.nuget.org/packages/MASES.JNet) | [![JNet.Templates nuget](https://img.shields.io/nuget/v/MASES.JNet.Templates)](https://www.nuget.org/packages/MASES.JNet.Templates) [![downloads](https://img.shields.io/nuget/dt/MASES.JNet.Templates)](https://www.nuget.org/packages/MASES.JNet.Templates)| [![JNetCLI nuget](https://img.shields.io/nuget/v/MASES.JNetCLI)](https://www.nuget.org/packages/MASES.JNetCLI) [![downloads](https://img.shields.io/nuget/dt/MASES.JNetCLI)](https://www.nuget.org/packages/MASES.JNetCLI)| [![JNetReflector nuget](https://img.shields.io/nuget/v/MASES.JNetReflector)](https://www.nuget.org/packages/MASES.JNetReflector) [![downloads](https://img.shields.io/nuget/dt/MASES.JNetReflector)](https://www.nuget.org/packages/MASES.JNetReflector)|

JNet is a .NET gateway for JVM APIs (Java, Scala, Kotlin, ...).

This project adheres to the Contributor [Covenant code of conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to coc_reporting@masesgroup.com.

## Scope of the project

This project aims to create a library to direct access, from .NET, all the features available in the Java Platform, this is the counterpart of [JCOReflector](https://github.com/masesgroup/JCOReflector).

There are many client libraries written to manage communication with Java. Conversely, this project use directly the Java packages giving more than one benefit:
* all implemented features are availables at no extra implementation costs, see [JNet usage](src/net/Documentation/articles/usage.md);
* avoids any third party communication protocol implementation;
* access all features made available from Java platform.

## Runtime engine

JNet uses [JCOBridge](https://www.jcobridge.com), and its [features](https://www.jcobridge.com/features/), to obtain many benefits:
* **Cyber-security**: 
  * [JVM](https://en.wikipedia.org/wiki/Java_virtual_machine) and [CLR, or CoreCLR,](https://en.wikipedia.org/wiki/Common_Language_Runtime) runs in the same process, but are insulated from each other;
  * JCOBridge does not make any code injection into JVM;
  * JCOBridge does not use any other communication mechanism than JNI;
  * .NET (CLR) inherently inherits the cyber-security levels of running JVM; 
* **Direct access the JVM from any .NET application**: 
  * Any Java/Scala/Kotlin/... class can be directly managed;
  * No need to learn new APIs: we try to expose the same APIs in C# style;
  * No extra validation cycle on protocol and functionality: bug fix, improvements, new features are immediately available;
  * Documentation is shared;
* **Dynamic code**: it helps to write a Java/Scala/Kotlin/etc seamless language code directly inside a standard .NET application written in C#/VB.NET: look at this [simple example](https://www.jcobridge.com/net-examples/dotnet-examples/) and [JNet APIs extensibility](src/net/Documentation/articles/API_extensibility.md).

Have a look at the following resources:
- [Release notes](https://www.jcobridge.com/release-notes/)
- [Non Profit or University](https://www.jcobridge.com/pricing/)
- [Commercial info: Professional or Enterprise](https://www.jcobridge.com/pricing/)
- [![JCOBridge nuget](https://img.shields.io/nuget/v/MASES.JCOBridge)](https://www.nuget.org/packages/MASES.JCOBridge)

---
## Summary

* [Roadmap](src/net/Documentation/articles/roadmap.md)
* [Actual state](src/net/Documentation/articles/actualstate.md)
* [JNet usage](src/net/Documentation/articles/usage.md)
* [JNet APIs extensibility](src/net/Documentation/articles/API_extensibility.md)
* [JNet CLI](src/net/Documentation/articles/usageCLI.md)
* [JNet Reflector](src/net/Documentation/articles/usageReflector.md)

---
