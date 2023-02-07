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
$names = Get-QueryNames $connector

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
* **Add-NotificationListener**: adds a notification listener and filter on a JMXConnector
* **Get-DefaultDomain**: get default domain from a JMXConnector
* **Get-Domains**: get all domains from a JMXConnector
* **Get-IsMXBeanInterface**: verify if the class name is an MBean interface
* **Get-JMXConnector**: get a JMXConnector
* **Get-MBeanCount**: get the number of MBean from a JMXConnector
* **Get-MBeanInfo**: get the MBeanInfo from an ObjectName using a JMXConnector
* **Get-QueryNames**: get the ObjectNames using a JMXConnector
* **Invoke-QueryAnd**: execute Query.And
* **Invoke-QueryAnySubString**: execute Query.AnySubString
* **Invoke-QueryAttr**: execute Query.Attr
* **Invoke-QueryBetween**: execute Query.Between
* **Invoke-QueryClassattr**: execute Query.Classattr
* **Invoke-QueryDiv**: execute Query.Div
* **Invoke-QueryEq**: execute Query.Eq
* **Invoke-QueryFinalSubString**: execute Query.FinalSubString
* **Invoke-QueryGeq**: execute Query.Geq
* **Invoke-QueryGt**: execute Query.Gt
* **Invoke-QueryIn**: execute Query.In
* **Invoke-QueryInitialSubString**: execute Query.nitialSubString
* **Invoke-QueryIsInstanceOf**: execute Query.IsInstanceOf
* **Invoke-QueryLeq**: execute Query.Leq
* **Invoke-QueryLt**: execute Query.Lt
* **Invoke-QueryMatch**: execute Query.Match
* **Invoke-QueryMinus**: execute Query.Minus
* **Invoke-QueryNot**: execute Query.Not
* **Invoke-QueryOr**: execute Query.Or
* **Invoke-QueryPlus**: execute Query.Plus
* **Invoke-QueryTimes**: execute Query.Times
* **Invoke-QueryValue**: execute Query.Value
* **New-AttributeChangeNotificationFilter**: create a new AttributeChangeNotificationFilter to be used in Add-NotificationListener
* **New-JMXServiceURL**: create a new JMXServiceURL to be used in Get-JMXConnector
* **New-MBeanProxy**: get a MBeanProxy from a JMXConnector
* **New-MXBeanProxy**: get a MXBeanProxy from a JMXConnector
* **New-NotificationFilterSupport**: create a new NotificationFilterSupport to be used in Add-NotificationListener
* **New-NotificationListener**: create a new NotificationListener to be used in Add-NotificationListener
* **New-ObjectName**: create a new ObjectName to be used in Get-JMXConnector
* **Remove-NotificationListener**: removes a notification listener and filter from a JMXConnector

### JVM identification

One of the most important command-line switch is **JVMPath**: it can be used to set-up the location of the JVM library (jvm.dll/libjvm.so) if JCOBridge is not able to identify a suitable JRE installation.

