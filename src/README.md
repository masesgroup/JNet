## Generated classes

The command used to build the classes is the following:

```cmd
dotnet build .\src\net\JNetReflector\JNetReflector.csproj
cd binReflector\net6.0
MASES.JNetReflector.exe -TraceLevel 0 -DestinationRootPath ..\..\src\ -ConfigurationFile ..\..\src\configuration.json
```

The configuration is:

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