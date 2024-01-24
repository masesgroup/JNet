---
title: JNetReflector tool of Java/JVM suite for .NET
_description: Describes JNetReflector: the tool to build .NET classes analyzing JVM Jar or modules
---

# JNet: Reflector

The tool is able to build .NET classes which reproduce the JVM class (Java, Scala, Kotlin, ...) counterpart.

## Installation

To install the tool follows the instructions on [NuGet](https://www.nuget.org/packages/MASES.JNetReflector/) and https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools.

## Usage

To use JNetReflector runs a command like the following:

* dotnet tool
> jnetreflector -OriginRootPath C:\\myJars -OriginJavadocUrl \"https://thehost/javadoc/\" -JavadocVersion 11 -DestinationRootPath C:\\ReflectionDestination

## Command switches available

_jnr_ accepts the following command-line switch:

* **ConfigurationFile**: The path where is stored a JSON file containing the tool configuration properties; the JSON items shall be written using the same command-line property names
* **OriginRootPath**: The origin path where Jars to be analyzed, and dependencies, are stored
* **OriginJavadocUrl**: The base URL of the Javadoc to be associated to the classes
* **JavadocVersion**: The version of the Javadoc to be associated to the classes, it means the Javadoc tool version used
* **OriginJavadocJARVersionAndUrls**: A CSV list of keypair of JavadocVersion and OriginJavadocUrl, separated by |, associated to the JARs to be analyzed
* **DestinationRootPath**: The destination root path where reflected classes will be stored
* **DestinationCSharpClassPath**: The destination root path where C# reflected classes will be stored
* **RelativeDestinationCSharpClassPath**: The relative destination root path, respect to DestinationRootPath, where C# reflected classes will be stored
* **DestinationJavaListenerPath**: The destination root path where Java listener classes will be stored
* **RelativeDestinationJavaListenerPath**: The destination root path, respect to DestinationRootPath, where Java listener classes will be stored
* **JavaListenerBasePackage**: The base package name to use when a Java listener class is created
* **ClassesToAnalyze**: A CSV list of full qualified class names to be analyzed
* **JarList**: A CSV list of JAR to be analyzed or folders containing the JARs
* **ModulesToParse**: A CSV list of module patterns to be parsed during analysis, it avoids the usage of OriginRootPath
* **NamespacesToAvoid**: A CSV list of namespaces to be removed from analysis
* **ClassesToAvoid**: A CSV list of classes to be removed during analysis
* **ClassesToAvoidInGenerics**: A CSV list of classes to be removed during analysis from the classes which have generics types
* **ClassesManuallyDeveloped**: A CSV list of class names will be manually developed
* **ClassesToBeListener**: A CSV list of class names to be treated as Listener, the tool consider any class which its name ends with "Listener" or "Adapter" as Listener
* **ClassesToAvoidJavaListener**: A CSV list of class names to be avoided during generation of Java listener classes
* **NamespacesInConflict**: A CSV list of namespaces in conflict with class name: to this one will be added an "Ns" at the end
* **ClassesInConflict**: A CSV list of classes in conflict with namespace name: to this one will be added an "Class" at the end
* **OnlyPropertiesForGetterSetter**: The option forces the tool to convert into properties only getter/setter
* **ReflectDeprecated**: The option forces the tool to write any constructor, method or field marked as deprecated, default is to avoid deprecated
* **AvoidCSharpGenericDefinition**: The option forces the tool to reflect generics without create the C# generic definition
* **AvoidCSharpGenericClauseDefinition**: The option forces the tool to reflect generics without create the clauses of C# generic definition
* **DisableGenericsInNonGenericClasses**: The option disables generation of generic methods in non generic classes
* **DisableGenerics**: The option forces the tool to disable any generic type
* **CreateInterfaceInheritance**: The option forces the tool to create the C# interface inheritance
* **DisableInterfaceMethodGeneration**: The option disables the generation of the methods in the C# interface
* **UseDotNetNullable**: The option forces the tool to use .NET nullable instead of Java types for native types
* **AvoidParallelBuild**: The option forces the tool to disable parallel execution
* **DryRun**: Execute everything, but do not write anything to disk
* **DoNotCamel**: Does not use camelized names in methods, class and so on
* **TraceLevel**: The level of traces to be reported: 0 - Critical ... 5 - Verbose
* **TraceTo**: The file name where traces will be write, default write to console

## JNet reflected classes

Many JNet classes are generated using JNetReflector. The JVM used to build the classes is the Temurin version 11 which is the minimum JVM version supported from JCOBridge.
The command line interface uses the following command line:

> jnetreflector -TraceLevel 0 -DestinationRootPath .\src\ -ConfigurationFile .\src\configuration.json

The options used are:

```json
{
  "RelativeDestinationCSharpClassPath": "net\\JNet\\Generated",
  "RelativeDestinationJavaListenerPath": "jvm\\jnet\\src\\main\\java",
  "JavaListenerBasePackage": "org.mases.jnet.generated",
  "OnlyPropertiesForGetterSetter": true,
  "ModulesToParse": [
    "org.*",
    "java.*"
  ],
  "OriginJavadocUrl": "https://docs.oracle.com/en/java/javase/11/docs/api/",
  "JavadocVersion": 11,
  "NamespacesToAvoid": [
    "org.jcp.xml.dsig.internal",
    "com.oracle",
    "com.sun",
    "org.mases",
    "org.junit",
    "org.hamcrest",
    "org.burningwave",
    "org.graalvm",
    "org.slf4j",
    "java.awt.peer"
  ],
  "ClassesToBeListener": [
    "javax.swing.Action",
    "javax.management.NotificationFilter"
  ],
  "ClassesToAvoid": [
    "java.lang.ProcessBuilder$Redirect$Type",
    "java.lang.Thread$UncaughtExceptionHandler",
    "java.util.Comparator",
    "java.util.EventListener",
    "java.util.stream.DoubleStream$Builder",
    "java.util.stream.IntStream$Builder",
    "java.util.stream.LongStream$Builder",
    "java.util.stream.Stream$Builder",
    "java.util.ServiceLoader$Provider",
    "javax.swing.ToolTipManager",
    "javax.swing.text.html.HTMLEditorKit$LinkController",
    "javax.swing.plaf.basic.BasicButtonListener",
    "javax.swing.plaf.basic.BasicTreeUI$MouseHandler",
    "javax.swing.plaf.basic.BasicDesktopIconUI$MouseInputHandler",
    "javax.swing.plaf.basic.BasicTabbedPaneUI$FocusHandler",
    "javax.swing.plaf.basic.BasicComboBoxUI$KeyHandler",
    "javax.swing.plaf.basic.BasicSliderUI$ComponentHandler",
    "javax.swing.plaf.basic.BasicComboPopup$InvocationKeyHandler",
    "javax.swing.plaf.basic.BasicTreeUI$KeyHandler",
    "javax.swing.plaf.basic.BasicTreeUI$ComponentHandler",
    "javax.swing.plaf.basic.BasicSplitPaneUI$FocusHandler",
    "javax.swing.plaf.basic.BasicTabbedPaneUI$MouseHandler",
    "javax.swing.plaf.basic.BasicOptionPaneUI$ButtonActionListener",
    "javax.swing.plaf.basic.BasicToolBarUI$DockingListener",
    "javax.swing.plaf.basic.BasicScrollPaneUI$HSBChangeListener",
    "javax.swing.plaf.basic.BasicInternalFrameUI$InternalFramePropertyChangeListener",
    "javax.swing.plaf.basic.BasicSliderUI$ScrollListener",
    "javax.swing.plaf.basic.BasicSliderUI$TrackListener",
    "javax.swing.plaf.basic.BasicScrollPaneUI$VSBChangeListener",
    "javax.swing.plaf.metal.MetalComboBoxUI$MetalPropertyChangeListener",
    "javax.tools.DiagnosticListener"
  ],
  "NamespacesInConflict": [
    "java.lang.module",
    "java.awt.color",
    "java.awt.desktop",
    "java.awt.image",
    "java.awt.event",
    "java.awt.font"
  ],
  "ClassesToAvoidInGenerics": [
    "java.time.chrono.ChronoLocalDateTime",
    "java.time.chrono.ChronoZonedDateTime"
  ]
}
```

### Running environment for PowerShell users

The command above fails in PowerShell because the nested class separator ($) is used from PowerShell to substitute variable values.
The previous command runs without problems in a Windows Command Prompt
