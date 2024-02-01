---
title: JNet CLI tool of Java/JVM suite for .NET
_description: Describes JNet CLI tool: the CLI tool to use Java/JVM classes from any command-line shell
---

# JNet: CLI

## Installation

- **dotnet tool** hosted on NuGet.org: check https://www.nuget.org/packages/MASES.JNetCLI/ and https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools for installation deep instructions.
  * The dotnet tool version needs and installed JRE/JDK within the system (see [JVM identification](#jvm-identification))
- **Docker image** hosted on [GitHub](https://github.com/masesgroup/JNet/pkgs/container/jnet) or [Docker Hub](https://hub.docker.com/repository/docker/masesgroup/jnet/general): follow instruction within the page and general instruction on https://docs.docker.com
  * The image hosts both .NET 6 and JRE 17 runtimes

## Usage

To use the CLI interface (JNetCLI) runs a command like the following:

- **dotnet tool**

> jnet -i

- **Docker image**

> docker run ghcr.io/masesgroup/jnet -i

> docker run masesgroup/jnet -i

## Command switch available

_jnet_ accepts the following command-line switch:

* **Interactive** (**i**): Activates an interactive shell
* **RunCommand** (**r**): executes the main method of a specific Java class in argument and exit
* **Script** (**s**): Executes the c# script in the file arument
* **JarList** (**jl**): A CSV list of JAR to be used or folders containing the JARs
* **NamespaceList** (**nl**): A CSV list of namespace to be used for interactive shell, JNet namespace are added automatically
* **ImportList** (**il**): A CSV list of import to be used

Plus other switches available at [Command line switch](commandlineswitch.md) page.

### JVM identification

One of the most important command-line switch is **JVMPath** and it is available in [JCOBridge switches](https://www.jcobridge.com/net-examples/command-line-options/): it can be used to set-up the location of the JVM library (jvm.dll/libjvm.so) if JCOBridge is not able to identify a suitable JRE installation.
