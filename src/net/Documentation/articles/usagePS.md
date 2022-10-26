# JNet: PowerShell Module

## Installation

To install the tool executes the following command within a PowerShell shell:

> Install-Module MASES.JNetPS

## Usage

To use the PowerShell interface (JNetPS) runs the following commands within a **PowerShell** shell:

> Import-Module MASES.JNetPS

then run the following to initialize the environment:

> Start-JNetPS

Now everting is ready and tou can create objects like in the following snippet

```powershell
$var = New-JObject java.lang.String "Hello from"
$var.ToString()
$var = $var.concat(" JNetPS")
$var.ToString()
```

the output will be:

```shell
Hello from
Hello from JNetPS
```

### Cmdlet available

_jnetps_ accepts the following cmdlets:

* **Start-JNetPS**: Initialize the engine and shall be the first command to be invoked. The arguments are:
  * LicensePath
  * JDKHome
  * JVMPath
  * JNIVerbosity
  * JNIOutputFile
  * JmxPort
  * EnableDebug
  * JavaDebugPort
  * DebugSuspendFlag
  * JavaDebugOpts
  * HeapSize
  * InitialHeapSize
* **Invoke-JCommand**: executes the main method of a specific Java Main-Class in argument and exit. The arguments are:
  * MainClass
  * Arguments
* **New-JObject**: Creates a new JVM object of the class specified in argument using the parameters within command line for constructor. The arguments are:
  * Class
  * Arguments


