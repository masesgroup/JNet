# JavaBridge: the Java .NET implementation

[![CI_BUILD](https://github.com/masesgroup/JavaBridge/actions/workflows/build.yaml/badge.svg)](https://github.com/masesgroup/JavaBridge/actions/workflows/build.yaml) [![CI_RELEASE](https://github.com/masesgroup/JavaBridge/actions/workflows/release.yaml/badge.svg)](https://github.com/masesgroup/JavaBridge/actions/workflows/release.yaml) 

|JavaBridge | JavaBridge.Templates |
|---	|---	|
|[![JavaBridge nuget](https://img.shields.io/nuget/v/MASES.JavaBridge)](https://www.nuget.org/packages/MASES.JavaBridge) [![downloads](https://img.shields.io/nuget/dt/MASES.JavaBridge)](https://www.nuget.org/packages/MASES.JavaBridge) | [![JavaBridge.Templates nuget](https://img.shields.io/nuget/v/MASES.JavaBridge.Templates)](https://www.nuget.org/packages/MASES.JavaBridge.Templates) [![downloads](https://img.shields.io/nuget/dt/MASES.JavaBridge.Templates)](https://www.nuget.org/packages/MASES.JavaBridge.Templates)|

JavaBridge is a .NET mirror of Java APIs.

This project adheres to the Contributor [Covenant code of conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to coc_reporting@masesgroup.com.

## Scope of the project

This project aims to create a library to direct access, from .NET, all the features available in the Java Platform, this is the counterpart of [JCOReflector](https://github.com/masesgroup/JCOReflector)

There are many client libraries written to manage communication with Java. Conversely, this project use directly the Java packages giving more than one benefit:
* all implemented features are availables at no extra implementation costs, see [JavaBridge usage](src/net/Documentation/articles/usage.md);
* avoids any third party communication protocol implementation;
* access all features made available from Java platform.

## Runtime engine

JavaBridge uses [JCOBridge](https://www.jcobridge.com), and its [features](https://www.jcobridge.com/features/), to obtain many benefits:
* **Cyber-security**: 
  * [JVM](https://en.wikipedia.org/wiki/Java_virtual_machine) and [CLR, or CoreCLR,](https://en.wikipedia.org/wiki/Common_Language_Runtime) runs in the same process, but are insulated from each other;
  * JCOBridge does not make any code injection into JVM;
  * JCOBridge does not use any other communication mechanism than JNI;
  * .NET (CLR) inherently inherits the cyber-security levels of running JVM; 
* **Direct access the JVM from any .NET application**: 
  * Any Java/Scala class behind Apache Kafka can be directly managed: Consumer, Producer, Administration, Streams, Server-side, and so on;
  * No need to learn new APIs: we try to expose the same APIs in C# style;
  * No extra validation cycle on protocol and functionality: bug fix, improvements, new features are immediately available;
  * Documentation is shared;
* **Dynamic code**: it helps to write a Java/Scala/Kotlin/etc seamless language code directly inside a standard .NET application written in C#/VB.NET: look at this [simple example](https://www.jcobridge.com/net-examples/dotnet-examples/) and [JavaBridge APIs extensibility](src/net/Documentation/articles/API_extensibility.md).

Have a look at the following resources:
- [Release notes](https://www.jcobridge.com/release-notes/)
- [Commercial info](https://www.jcobridge.com/pricing/)
- [![JCOBridge nuget](https://img.shields.io/nuget/v/MASES.JCOBridge)](https://www.nuget.org/packages/MASES.JCOBridge)

---
## Summary

* [Roadmap](src/net/Documentation/articles/roadmap.md)
* [Actual state](src/net/Documentation/articles/actualstate.md)
* [JavaBridge usage](src/net/Documentation/articles/usage.md)
* [JavaBridge APIs extensibility](src/net/Documentation/articles/API_extensibility.md)

---
