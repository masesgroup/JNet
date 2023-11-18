---
title: Current state of Java/JVM suite for .NET
_description: Describes the current development state of Java/JVM suite for .NET
---

# JNet development state

This release comes with some ready made classes:

* JNet:
  * Reflected almost all classes of a Temurin JDK 11 with the limits imposed from JNetReflector
  * Manually made some classes, or extended some of reflected one, due to limitations of JNetReflector
  * If something is not available use [API extensibility](API_extensibility.md) to cover missing classes.
* JNetCLI: added REPL shell, run Main-Class and execute C# scripts
* JNetReflector: builds listeners and reflects Java classes with constructor, methods, fields, conversion operators and documentation
* JNetPSCore: base implementation for JNetPS
* JNetPS: some PowerShell cmdlets