## Generated classes

This folder contains the Java classes generated using JNetReflector at the same version of JNet.

The command used to build the classes is the following:

```cmd
dotnet build .\src\net\JNetReflector\JNetReflector.csproj
cd binReflector\net6.0
MASES.JNetReflector.exe -TraceLevel 0 -DestinationRootPath ..\..\src\net\JNet\Generated -ConfigurationFile ..\..\src\net\JNet\Generated\configuration.json
```

The configuration is:

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