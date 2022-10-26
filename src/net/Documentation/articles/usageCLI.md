# JNet: CLI

## Installation

- **dotnet tool** hosted on NuGet.org: check https://www.nuget.org/packages/MASES.JNetCLI/ and https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools for installation deep instructions.
- **Docker image** hosted on https://github.com/masesgroup/JNet/pkgs/container/mases.jnet: follow instruction within the page and general instruction on https://docs.docker.com

## Usage

To use the CLI interface (JNetCLI) runs a command like the following:

- **dotnet tool**

> jnet -i

- **Docker image**

> docker run ghcr.io/masesgroup/mases.jnet -i

### Commands available

_jnet_ accepts the following command-line switch:

* **Interactive** (**i**): Activates an interactive shell
* **RunCommand** (**r**): executes the main method of a specific Java class in argument and exit
* **Script** (**s**): Executes the c# script in the file arument
* **JarList** (**jl**): A CSV list of JAR to be used or folders containing the JARs
* **NamespaceList** (**nl**): A CSV list of namespace to be used for interactive shell, JNet namespace are added automatically
* **ImportList** (**il**): A CSV list of import to be used

