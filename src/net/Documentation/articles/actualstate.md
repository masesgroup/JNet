# JNet development state

This release comes with some ready made classes:

* JNet:
  * Reflected almost all classes of a Temurin JDK 11 with the limits imposed from JNetReflector
  * Manually made some classes used in other projects like [KNet](https://github.com/masesgroup/KNet). 
  * If something is not available use [API extensibility](API_extensibility.md) to cover missing classes.
* JNetCLI: added REPL shell, run Main-Class and execute C# scripts
* JNetReflector: reflects classes skeleton, constructor, methods, fields, conversion operators and adds documentation; known limitation are:
  * can identify Listener, Adapter, and so on, however is not able to build the corresponding C# class
* JNetPSCore: base implementation for JNetPS
* JNetPS: some PowerShell cmdlets