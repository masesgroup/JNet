# JNet: Reflector

The tool is able to build .NET classes which reproduce the JVM class (Java, Scala, Kotlin, ...) counterpart.

## Installation

To install the tool follows the instructions on https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools.

## Usage

To use JNetReflector runs a command like the following:

* dotnet tool
> jnetreflector -OriginRootPath C:\\myJars -OriginJavadocUrl \"https://thehost/javadoc/\" -JavadocVersion 11 -DestinationRootPath C:\\ReflectionDestination

> jnr -OriginRootPath C:\\myJars -OriginJavadocUrl "https://thehost/javadoc/" -JavadocVersion 11 -DestinationRootPath C:\\ReflectionDestination

## Command switches available

_jnr_ accepts the following command-line switch:

* **ConfigurationFile**: The path where is stored a JSON file containing the tool configuration properties; the JSON items shall be written using the same command-line property names
* **OriginRootPath**: The origin path where Jars to be analyzed, and dependencies, are stored
* **OriginJavadocUrl**: The base URL of the Javadoc to be associated to the classes
* **JavadocVersion**: The version of the Javadoc to be associated to the classes, it means the Javadoc tool version used
* **OriginJavadocJARVersionAndUrls**: A CSV list of keypair of JavadocVersion and OriginJavadocUrl, separated by |, associated to the JARs to be analyzed
* **DestinationRootPath**: The destination root path where reflected classes will be stored
* **ClassesToAnalyze**: A CSV list of full qualified class names to be analyzed
* **JarList**: A CSV list of JAR to be analyzed or folders containing the JARs
* **ModulesToParse**: A CSV list of module patterns to be parsed during analysis, it avoids the usage of OriginRootPath
* **NamespacesToAvoid**: A CSV list of namespaces to be removed from analysis
* **ClassesToAvoid**: A CSV list of classes to be removed during analysis
* **ClassesToAvoidInGenerics**: A CSV list of classes to be removed during analysis from the classes which have generics types
* **ClassesToBeListener**: A CSV list of class names to be treated as Listener
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
* **AvoidParallelBuild**: The option forces the tool to disable parallel execution
* **DryRun**: Execute everything, but do not write anything to disk
* **DoNotCamel**: Does not use camelized names in methods, class and so on
* **TraceLevel**: The level of traces to be reported: 0 - Critical ... 5 - Verbose
* **TraceTo**: The file name where traces will be write, default write to console

## JNet reflected classes

Many JNet classes are generated using JNetReflector. The JVM used to build the classes is the Temurin version 11 which is the minimum JVM version supported from JCOBridge.
The command line interface uses the following command line:

> jnetreflector -TraceLevel 0 -DestinationRootPath .\src\net\JNet\Generated -ConfigurationFile .\src\net\JNet\Generated\configuration.json

The options used are:

```json
{
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
    "java.util.Comparator",
    "java.util.ServiceLoader$Provider",
    "java.util.stream.DoubleStream$Builder",
    "java.util.stream.IntStream$Builder",
    "java.util.stream.LongStream$Builder",
    "java.util.stream.Stream$Builder",
    "javax.swing.Action",
    "javax.management.NotificationFilter"
  ],
  "ClassesToAvoid": [
    "javax.swing.ToolTipManager",
    "javax.swing.text.html.HTMLEditorKit$LinkController",
    "javax.swing.plaf.basic.BasicTreeUI$MouseHandler",
    "javax.swing.plaf.basic.BasicDesktopIconUI$MouseInputHandler",
    "javax.swing.plaf.basic.BasicTabbedPaneUI$FocusHandler",
    "javax.swing.plaf.basic.BasicComboBoxUI$KeyHandler",
    "javax.swing.plaf.basic.BasicSliderUI$ComponentHandler",
    "javax.swing.plaf.basic.BasicComboPopup$InvocationKeyHandler",
    "javax.swing.plaf.basic.BasicTreeUI$KeyHandler",
    "javax.swing.plaf.basic.BasicTreeUI$ComponentHandler",
    "javax.swing.plaf.basic.BasicSplitPaneUI$FocusHandler",
    "javax.swing.plaf.basic.BasicTabbedPaneUI$MouseHandler"
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
