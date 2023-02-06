# JNet: PowerShell Module

## Installation

To install the tool executes the following command within a PowerShell shell:

> Install-Module -Name MASES.JNetPS

## Usage

To use the PowerShell interface (JNetPS) runs the following commands within a **PowerShell** shell:

### Initialization

* The following cmdlet initialize the environment:

> Start-JNetPS

### Execution

Now everything is ready and you can create objects like in the following snippet:

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

### JMX example

From version 1.5.0 new JMX comlets are available; the tutorial in https://docs.oracle.com/javase/tutorial/jmx/remote/custom.html can be reproduced in PowerShell:

```powershell
$url = New-JMXServiceURL "service:jmx:rmi:///jndi/rmi://:9999/jmxrmi"
$connector = Get-JMXConnector $url

$domains = Get-Domains $connector
$defaultdomain = Get-DefaultDomain $connector
$names = Get-Names $connector

$mbeanName = New-ObjectName "com.example:type=Hello"
$mbeanProxy = New-MBeanProxy -Connector $connector -ObjectName $mbeanName -InterfaceName "HelloMBean" -WithNotificationEmitter

[Action[JavaX.Management.Notification, System.Object]]$action = {param($notification, $handback) Write-Host "Notification message is $notification.Message"}
$listener = New-NotificationListener $action

Add-NotificationListener $connector $mbeanName $listener 

mbeanProxy.getCacheSize() // this use dynamic on mbeanProxy

```

## Cmdlet available

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
  * LogClassPath
* **Invoke-JCommand**: executes the main method of a specific Java Main-Class in argument and exit. The arguments are:
  * MainClass
  * Arguments
* **New-JObject**: Creates a new JVM object of the class specified in argument using the parameters within command line for constructor. The arguments are:
  * Class
  * Arguments
* **Get-ClassForName**: returns a Class from the class name
  * ClassName
  
From version 1.5.0 new JMX comlets are available:
* **Add-NotificationListener**:
* **Get-DefaultDomain**:
* **Get-Domains**:
* **Get-IsMXBeanInterface**:
* **Get-JMXConnector**:
* **Get-MBeanCount**:
* **Get-MBeanInfo**:
* **Get-QueryNames**:
* **Get-QueryClassattr**:
* **Get-QueryValueExp**:
* **Invoke-QueryAnd'
* **Invoke-QueryAnySubString**:
* **Invoke-QueryAttr**:
* **Invoke-QueryBetween**:
* **Invoke-QueryDiv**:
* **Invoke-QueryEq**:
* **Invoke-QueryFinalSubString**:
* **Invoke-QueryGeq**:
* **Invoke-QueryGt**:
* **Invoke-QueryIn**:
* **Invoke-QueryInitialSubString**:
* **Invoke-QueryIsInstanceOf**:
* **Invoke-QueryLeq**:
* **Invoke-QueryLt**:
* **Invoke-QueryMatch**:
* **Invoke-QueryMinus**:
* **Invoke-QueryNot**:
* **Invoke-QueryOr**:
* **Invoke-QueryPlus**:
* **Invoke-QueryTimes**:
* **New-JMXServiceURL**:
* **New-MBeanProxy**:
* **New-MXBeanProxy**:
* **New-NotificationListener**:
* **New-ObjectName**:
* **Remove-NotificationListener**:

### JVM identification

One of the most important command-line switch is **JVMPath**: it can be used to set-up the location of the JVM library (jvm.dll/libjvm.so) if JCOBridge is not able to identify a suitable JRE installation.

