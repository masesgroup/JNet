
using Java.Awt;
using Java.Awt.Event;
using JavaX.Swing;
using MASES.JCOBridge.C2JBridge;
using MASES.JNet;
using System;

namespace MASES.JNetGraphicCommon
{
    static class GraphicCommon
    {
        public static dynamic TextArea { get; private set; }

        static dynamic CommonContainer { get; set; }

        public static IJCGraphicContainer Container { get; private set; }
        static ActionListener _Listener;

        public static object CreateAWTContent(Action<ActionEvent> handler)
        {
            try
            {
                _Listener = new ActionListener(handler);
                CommonContainer = new Panel();
                dynamic layout = new GridLayout(2, 1);
                CommonContainer.setLayout(layout);
                TextArea = new TextArea("", 10, 40);
                CommonContainer.add(TextArea);
                dynamic button = new Button("Send TextArea text to Host Application");
                button.setActionCommand("sendData");
                button.addActionListener(_Listener.Instance);
                CommonContainer.add(button);
                Container = CommonContainer.HostedContainer;
#if WINFORMS
                return CommonContainer.CreateHostedContainer(false);
#else
                return CommonContainer.CreateHostedContainer(true);
#endif
            }
            catch (Exception ex)
            {
#if WINFORMS
                var label = new System.Windows.Forms.Label
                {
                    Text = ex.ToString()
                };
#else
                var label = new System.Windows.Controls.Label
                {
                    Content = ex.ToString()
                };
#endif
                return label;
            }
        }

        public static object CreateSwingContent()
        {
            try
            {
                JNetCore.GlobalInstance.JVM.ImportPackage("java.lang");
                JNetCore.GlobalInstance.JVM.ImportPackage("java.util");
                JNetCore.GlobalInstance.JVM.ImportPackage("java.lang.reflect");
                JNetCore.GlobalInstance.JVM.ImportPackage("java.net");
                JNetCore.GlobalInstance.JVM.ImportPackage("java.awt");
                JNetCore.GlobalInstance.JVM.ImportPackage("javax.swing");
                JNetCore.GlobalInstance.JVM.ImportPackage("rvl.awt.Slider");

                dynamic clearButton;
                dynamic sendButton;
                dynamic layout;
                JPanel chatPanel;
                JPanel messagePanel;
                JPanel imagePanel;
                JPanel tablePanel;
                JPanel tableButtonPanel;
                dynamic addRowButton;
                dynamic textLabel;
                dynamic textField;
                dynamic textArea;
                dynamic spinner;
                dynamic tableModel;
                string[][] data;

                // don't work: JFrame.SetDefaultLookAndFeelDecorated(true);
                JNetCore.GlobalInstance.DynJVM.JFrame.setDefaultLookAndFeelDecorated(true);

                UIManager.DynClazz.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");

                // Define the panel to hold the components  
                CommonContainer = new JPanel();
                // Contains all the chat components
                chatPanel = new JPanel();
                messagePanel = new JPanel();
                // Contains all the table components
                tablePanel = new JPanel();
                tableButtonPanel = new JPanel();
                // Contains all the image components
                imagePanel = new JPanel();

                // Define layouts
                dynamic chatLayout = new BoxLayout(chatPanel, BoxLayout.DynClazz.Y_AXIS);
                dynamic messageLayout = new BoxLayout(messagePanel, BoxLayout.DynClazz.X_AXIS);
                dynamic tableLayout = new BoxLayout(tablePanel, BoxLayout.DynClazz.Y_AXIS);
                dynamic tableButtonLayout = new BoxLayout(tableButtonPanel, BoxLayout.DynClazz.X_AXIS);
                layout = new SpringLayout();

                // Set Layouts
                chatPanel.Dyn().setLayout(chatLayout);
                messagePanel.Dyn().setLayout(messageLayout);
                tablePanel.Dyn().setLayout(tableLayout);
                tableButtonPanel.Dyn().setLayout(tableButtonLayout);

                // Create buttons
                clearButton = new JButton("Clear");
                sendButton = new JButton("Send");
                addRowButton = new JButton("Add Row");
                clearButton.setActionCommand("Clear");
                sendButton.setActionCommand("Send");
                addRowButton.setActionCommand("AddRow");

                // Add chats components
                textLabel = new JLabel("Message: ");
                textField = new JTextField("Test Message", 15);
                textField.setActionCommand("TextEntered");
                textArea = new JTextArea("Message Area\n", 10, 5);

                // don't work var keystroke = KeyStroke.DynClazz.getKeyStroke('a', false);
                var keystroke = JNetCore.GlobalInstance.DynJVM.KeyStroke.getKeyStroke('a', false);
                var condition = JNetCore.GlobalInstance.DynJVM.JComponent.WHEN_FOCUSED;

                messagePanel.Dyn().add(textLabel);
                messagePanel.Dyn().add(textField);
                messagePanel.Dyn().add(sendButton);
                messagePanel.Dyn().add(clearButton);
                chatPanel.Dyn().add(textArea);
                chatPanel.Dyn().add(messagePanel.Instance);
                chatPanel.Dyn().setSize(100, 100);

                // Add spinner
                var zoomModel = new SpinnerNumberModel(100, //initial value
                                                        25,  //min
                                                        200, //max
                                                        25); //step
                spinner = new JSpinner(zoomModel);
                var labelZoom = new JLabel("Zoom X");

                //Add table
                data = new string[][] { new string[] { "101","Amit","670000"},
                                        new string[] { "102","Jai","780000"},
                                        new string[] { "101","Sachin","700000"},
                                        new string[] { "103","New Row","0"} };

                string[] columns = { "ID", "NAME", "SALARY" };
                var jt = JNetCore.GlobalInstance.DynJVM.JTable.@new(0, 3);
                tableModel = jt.getModel();
                Java.Util.Vector<string> vector = new();
                vector.Add(columns[0]); vector.Add(columns[1]); vector.Add(columns[2]);
                tableModel.setColumnIdentifiers(vector.Instance);
                vector = new();
                vector.Add(data[0][0]); vector.Add(data[0][1]); vector.Add(data[0][2]);
                tableModel.addRow(vector.Instance);
                vector = new();
                vector.Add(data[1][0]); vector.Add(data[1][1]); vector.Add(data[1][2]);
                tableModel.addRow(vector.Instance);
                vector = new();
                vector.Add(data[2][0]); vector.Add(data[2][1]); vector.Add(data[2][2]);
                tableModel.addRow(vector.Instance);
                jt.setBounds(30, 40, 200, 300);
                // Put table in a scroll panel
                var scrollPane = JNetCore.GlobalInstance.DynJVM.JScrollPane.@new(jt);

                //configure panel
                CommonContainer.setSize(500, 600);
                CommonContainer.setLayout(layout);
                CommonContainer.add(chatPanel.Instance);
                tableButtonPanel.Dyn().add(addRowButton);
                tablePanel.Dyn().add(tableButtonPanel.Instance);
                tablePanel.Dyn().add(scrollPane);
                CommonContainer.add(tablePanel.Instance);

                dynamic layoutAccessor = JNetCore.GlobalInstance.DynJVM.SpringLayout;

                // Put constraint on components
                layout.putConstraint(layoutAccessor.HORIZONTAL_CENTER, chatPanel.Instance, 5, layoutAccessor.HORIZONTAL_CENTER, CommonContainer.Instance);
                layout.putConstraint(layoutAccessor.WIDTH, chatPanel.Instance, 5, layoutAccessor.WIDTH, CommonContainer.Instance);
                layout.putConstraint(layoutAccessor.NORTH, chatPanel.Instance, 5, layoutAccessor.NORTH, CommonContainer.Instance);

                layout.putConstraint(layoutAccessor.NORTH, imagePanel.Instance, 5, layoutAccessor.SOUTH, chatPanel.Instance);
                layout.putConstraint(layoutAccessor.HORIZONTAL_CENTER, imagePanel.Instance, 5, layoutAccessor.HORIZONTAL_CENTER, CommonContainer.Instance);
                layout.putConstraint(layoutAccessor.WIDTH, imagePanel.Instance, 5, layoutAccessor.WIDTH, CommonContainer.Instance);

                layout.putConstraint(layoutAccessor.NORTH, tablePanel.Instance, 5, layoutAccessor.SOUTH, imagePanel.Instance);
                layout.putConstraint(layoutAccessor.HORIZONTAL_CENTER, imagePanel.Instance, 5, layoutAccessor.HORIZONTAL_CENTER, CommonContainer.Instance);
                layout.putConstraint(layoutAccessor.WIDTH, tablePanel.Instance, 5, layoutAccessor.WIDTH, CommonContainer.Instance);
                Container = CommonContainer.HostedContainer;
#if WINFORMS
                return CommonContainer.CreateHostedContainer(false);
#else
                return CommonContainer.CreateHostedContainer(true);
#endif
            }
            catch (Exception ex)
            {
#if WINFORMS
                var label = new System.Windows.Forms.Label
                {
                    Text = ex.ToString()
                };
#else
                var label = new System.Windows.Controls.Label
                {
                    Content = ex.ToString()
                };
#endif
                return label;
            }
        }
    }
}