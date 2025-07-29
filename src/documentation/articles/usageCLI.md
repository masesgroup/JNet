---
title: JNet CLI tool of .NET suite for Java™/JVM™
_description: Describes the CLI tool to use Java™/JVM™ classes from any command-line shell
---

# JNet: CLI

## Installation

- **dotnet tool** hosted on [NuGet](https://www.nuget.org/packages/MASES.JNetCLI): check https://www.nuget.org/packages/MASES.JNetCLI/ and https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools for deep installation instructions.
- **Docker image** hosted on [GitHub](https://github.com/masesgroup/JNet/pkgs/container/jnet) and [Docker Hub](https://hub.docker.com/repository/docker/masesgroup/jnet/general): follow instruction within the page and general instruction on https://docs.docker.com
  * The image hosts both .NET 6 and JRE 11 runtimes

> [!IMPORTANT]
> The **dotnet tool** needs a JRE/JDK installed within the system (see [JVM™ identification](#jvm-identification))

## Usage

To use the CLI interface (JNetCLI) runs a command like the following:

- **dotnet tool**

```sh
jnet -i
```

> [!IMPORTANT]
> If the previous command raises the error described in [Intel CET and JNet](usage.md#intel-cet-and-jnet), the only solution is to apply the following workaround (within an **elevated shell**) and disable CET:
> ```sh
> 	reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\jnet.exe" /v MitigationOptions /t REG_BINARY /d "0000000000000000000000000000002000" /f
> ```

- **Docker image**

```sh
docker run ghcr.io/masesgroup/jnet -i
```

```sh
docker run masesgroup/jnet -i
```

## Command switch available

_jnet_ accepts the following command-line switch:

* **Interactive** (**i**): Activates an interactive shell
* **RunCommand** (**r**): executes the main method of a specific Java™ class in argument and exit
* **Script** (**s**): Executes the c# script in the file arument
* **JarList** (**jl**): A CSV list of JAR to be used or folders containing the JARs
* **NamespaceList** (**nl**): A CSV list of namespace to be used for interactive shell, JNet namespace are added automatically
* **ImportList** (**il**): A CSV list of import to be used

Plus other switches available at [Command line switch](commandlineswitch.md) page.

### JVM™ identification

One of the most important command-line switch is **JVMPath** and it is available in [JCOBridge switches](https://www.jcobridge.com/net-examples/command-line-options/): it can be used to set-up the location of the JVM™ library (jvm.dll/libjvm.so) if JCOBridge is not able to identify a suitable JRE installation.
