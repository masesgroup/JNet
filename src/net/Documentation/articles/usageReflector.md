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
* **DoNotAddJarsInClasspath**: The option inform the tool to not add the Jars in classpath
* **ModulesToParse**: A CSV list of module patterns to be parsed during analysis, it avoids the usage of OriginRootPath
* **NamespacesToAvoid**: A CSV list of namespaces to be removed from analysis
* **ClassesToAvoid**: A CSV list of classes to be removed during analysis
* **ClassesToBeListener**: A CSV list of class names to be treated as Listener
* **NamespacesInConflict**: A CSV list of namespaces in conflict with class name: to this one will be added an "Ns" at the end
* **ReflectDeprecated**: The option forces the tool to write any constructor, method or field marked as deprecated, default is to avoid deprecated
* **DisableGenerics**: The option forces the tool to disable any generic type
* **AvoidParallelBuild**: The option forces the tool to disable parallel execution
* **DryRun**: Execute everything, but do not write anything to disk
* **TraceLevel**: The level of traces to be reported: 0 - Critical ... 5 - Verbose
* **TraceTo**: The file name where traces will be write, default write to console

## JNet reflected classes

Many JNet classes are generated using JNetReflector. The JVM used to build the classes is the Temurin version 11 which is the minimum JVM version supported from JCOBridge.
The command line interface used is:

> jnetreflector -ModulesToParse org.*,java.* -DestinationRootPath .\src\net\JNet\Generated -OriginJavadocUrl "https://docs.oracle.com/en/java/javase/11/docs/api/" -JavadocVersion 11 \
> -ClassesToBeListener javax.management.NotificationFilter \
> -ClassesToAvoid javax.swing.ToolTipManager,javax.swing.text.html.HTMLEditorKit$LinkController,javax.swing.plaf.basic.BasicTreeUI$MouseHandler,javax.swing.plaf.basic.BasicDesktopIconUI$MouseInputHandler,javax.swing.plaf.basic.BasicTabbedPaneUI$FocusHandler,javax.swing.plaf.basic.BasicComboBoxUI$KeyHandler,javax.swing.plaf.basic.BasicSliderUI$ComponentHandler,javax.swing.plaf.basic.BasicComboPopup$InvocationKeyHandler,javax.swing.plaf.basic.BasicTreeUI$KeyHandler,javax.swing.plaf.basic.BasicTreeUI$ComponentHandler,javax.swing.plaf.basic.BasicSplitPaneUI$FocusHandler,javax.swing.plaf.basic.BasicTabbedPaneUI$MouseHandler \
> -NamespacesToAvoid org.jcp.xml.dsig.internal,com.oracle,com.sun,org.mases,org.junit,org.hamcrest,org.burningwave,org.graalvm,org.slf4j,java.awt.peer \
> -NamespacesInConflict java.lang.module,java.awt.color,java.awt.desktop,java.awt.image,java.awt.event,java.awt.font

### Running environment for PowerShell users

The command above fails in PowerShell because the nested class separator ($) is used from PowerShell to substitute variable values.
The previous command runs without problems in a Windows Command Prompt
