# JNet: Reflector

## Installation

To install the tool follows the instructions on https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools.

## Usage

To use JNetReflector runs a command like the following:

* dotnet tool
> jnetreflector -OriginRootPath C:\\myJars -OriginJavadocUrl \"https://thehost/javadoc/\" -JavadocVersion 11 -DestinationRootPath C:\\ReflectionDestination

> jnr -OriginRootPath C:\\myJars -OriginJavadocUrl \"https://thehost/javadoc/\" -JavadocVersion 11 -DestinationRootPath C:\\ReflectionDestination

## Command switch available

_jnr_ accepts the following command-line switch:

* **OriginRootPath**: The origin path where Jars to be analyzed are stored
* **OriginJavadocUrl**: The base URL of the Javadoc to be associated to the classes
* **JavadocVersion**: The version of the Javadoc to be associated to the classes, it means the Javadoc tool version used
* **DestinationRootPath**: The destination root path where reflected classes will be stored
* **JarList**: A CSV list of JAR to be analyzed or folders containing the JARs
* **NamespacesToAvoid**: A CSV list of namespaces to be removed from analysis
* **ReflectDeprecated**: The option forces the tool to write any constructor, method or field marked as deprecated, default is to avoid deprecated
* **DryRun**: Execute everything, but do not write anything to disk
* **TraceLevel**: The level of traces to be reported: 0 - Critical ... 5 - Verbose
* **TraceTo**: The file name where traces will be write, default write to console