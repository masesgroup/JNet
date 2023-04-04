# JNet: Java/JVM suite for .NET

JNet is a comprehensive suite of libraries and tools to use Java/JVM APIs (Java, Scala, Kotlin, ...) and .NET side-by-side.

### Libraries and Tools

|JNet | JNet.Templates | JNetPSCore | JNetCLI | JNetReflector | JNetPS |
|:---:	|:---:	|:---:	|:---:	|:---:	|:---:	|
|[![JNet nuget](https://img.shields.io/nuget/v/MASES.JNet)](https://www.nuget.org/packages/MASES.JNet)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNet)](https://www.nuget.org/packages/MASES.JNet) | [![JNet.Templates nuget](https://img.shields.io/nuget/v/MASES.JNet.Templates)](https://www.nuget.org/packages/MASES.JNet.Templates)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNet.Templates)](https://www.nuget.org/packages/MASES.JNet.Templates)| [![JNetPSCore nuget](https://img.shields.io/nuget/v/MASES.JNetPSCore)](https://www.nuget.org/packages/MASES.JNetPSCore)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNetPSCore)](https://www.nuget.org/packages/MASES.JNetPSCore)| [![JNetCLI nuget](https://img.shields.io/nuget/v/MASES.JNetCLI)](https://www.nuget.org/packages/MASES.JNetCLI)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNetCLI)](https://www.nuget.org/packages/MASES.JNetCLI)| [![JNetReflector nuget](https://img.shields.io/nuget/v/MASES.JNetReflector)](https://www.nuget.org/packages/MASES.JNetReflector)<br/>[![downloads](https://img.shields.io/nuget/dt/MASES.JNetReflector)](https://www.nuget.org/packages/MASES.JNetReflector)| [![JNetPS](https://img.shields.io/powershellgallery/v/MASES.JNetPS.svg?style=flat-square&label=MASES.JNetPS)](https://www.powershellgallery.com/packages/MASES.JNetPS/)|

---

## Scope of the project

This project aims to create a set of libraries and tools to direct access, from .NET, all the features available in the Java Platform, this is the counterpart of [JCOReflector](https://github.com/masesgroup/JCOReflector).

There are many client libraries written to manage communication with Java. Conversely, this project use directly the Java packages giving more than one benefit:
* all implemented features are availables at no extra implementation costs, see [JNet usage](src/net/Documentation/articles/usage.md);
* avoids any third party communication protocol implementation;
* access all features made available from Java platform.

So, for example, do you want an `ArrayList`? Just write in C# a line of code like this:

```c#
Java.Util.ArrayList<string> alist = new Java.Util.ArrayList<string>();
```

See [JNet usage](src/net/Documentation/articles/usage.md) for a comprehensive example.

### Community and Contribution

Do you like the project? 
- Request your free [community subscription](https://www.jcobridge.com/pricing-25/).

Do you want to help us?
- put a :star: on this project
- open [issues](https://github.com/masesgroup/JNet/issues) to request features or report bugs :bug:
- improves the project with Pull Requests

This project adheres to the Contributor [Covenant code of conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to coc_reporting@masesgroup.com.

## Summary

* [Roadmap](src/net/Documentation/articles/roadmap.md)
* [Actual state](src/net/Documentation/articles/actualstate.md)
* [JNet usage](src/net/Documentation/articles/usage.md)
* [JNet APIs extensibility](src/net/Documentation/articles/API_extensibility.md)
* [JNet CLI usage](src/net/Documentation/articles/usageCLI.md)
* [JNet Reflector usage](src/net/Documentation/articles/usageReflector.md)
* [JNet PowerShell usage](src/net/Documentation/articles/usagePS.md)

### News

* V1.4.8+: From version 1.4.8 there is a new project, named JNetReflector (still in development phase), able to build C# gateway classes from JARs containing the JVM classes, exactly the same [JCOReflector](https://github.com/masesgroup/JCOReflector) does for .NET in JVM.
* V1.4.9+: From version 1.4.9 there are two new projects:
  * JNetPSCore: the core library for PowerShell development, it can be extended in other projects based on JNet;
  * JNetPS: a PowerShell module to use JNet within a PowerShell shell.
* V1.5.2+: strong improvement of JNetReflector; it is used to generate almost all Java 11 classes available in the corresponding JNet version
* V1.5.3+: JNetReflector manages generics and almost all classes of Java SE 11 are covered: see [JNet Reflector usage](src/net/Documentation/articles/usageReflector.md)

---

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

### JCOBridge resources

Have a look at the following JCOBridge resources:
- [Release notes](https://www.jcobridge.com/release-notes/)
- ~~[Non Profit or University](https://www.jcobridge.com/pricing/)~~
- ~~[Commercial info: Professional or Enterprise](https://www.jcobridge.com/pricing/)~~
- [Community Edition](https://www.jcobridge.com/pricing-25/)
- [Commercial Edition](https://www.jcobridge.com/pricing-25/)
- Latest release: [![JCOBridge nuget](https://img.shields.io/nuget/v/MASES.JCOBridge)](https://www.nuget.org/packages/MASES.JCOBridge)
