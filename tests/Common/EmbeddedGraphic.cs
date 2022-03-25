
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

        static Container CommonContainer { get; set; }

        public static IJCGraphicContainer Container { get; private set; }
        static ActionListener _Listener;

        public static object CreateAWTContent(Action<ActionEvent> handler)
        {
            try
            {
                _Listener = new ActionListener(handler);
                CommonContainer = new Panel();
                var layout = JNetCore.GlobalInstance.DynJVM.java.awt.GridLayout.@new(2, 1);
                CommonContainer.Dyn().setLayout(layout);
                TextArea = JNetCore.GlobalInstance.DynJVM.java.awt.TextArea.@new("", 10, 40);
                CommonContainer.Dyn().add(TextArea);
                var button = JNetCore.GlobalInstance.DynJVM.java.awt.Button.@new("Send TextArea text to Host Application");
                button.setActionCommand("sendData");
                button.addActionListener(_Listener.Instance);
                CommonContainer.Dyn().add(button);
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

                JNetCore.GlobalInstance.DynJVM.javax.swing.JFrame.setDefaultLookAndFeelDecorated(true);

                JNetCore.GlobalInstance.DynJVM.UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");

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
                dynamic chatLayout = JNetCore.GlobalInstance.DynJVM.BoxLayout.@new(chatPanel.Instance, JNetCore.GlobalInstance.DynJVM.BoxLayout.Y_AXIS);
                dynamic messageLayout = JNetCore.GlobalInstance.DynJVM.BoxLayout.@new(messagePanel.Instance, JNetCore.GlobalInstance.DynJVM.BoxLayout.X_AXIS);
                dynamic tableLayout = JNetCore.GlobalInstance.DynJVM.BoxLayout.@new(tablePanel.Instance, JNetCore.GlobalInstance.DynJVM.BoxLayout.Y_AXIS);
                dynamic tableButtonLayout = JNetCore.GlobalInstance.DynJVM.BoxLayout.@new(tableButtonPanel.Instance, JNetCore.GlobalInstance.DynJVM.BoxLayout.X_AXIS);
                layout = JNetCore.GlobalInstance.DynJVM.SpringLayout.@new();

                // Set Layouts
                chatPanel.Dyn().setLayout(chatLayout);
                messagePanel.Dyn().setLayout(messageLayout);
                tablePanel.Dyn().setLayout(tableLayout);
                tableButtonPanel.Dyn().setLayout(tableButtonLayout);

                // Create buttons
                clearButton = JNetCore.GlobalInstance.DynJVM.javax.swing.JButton.@new("Clear");
                sendButton = JNetCore.GlobalInstance.DynJVM.javax.swing.JButton.@new("Send");
                addRowButton = JNetCore.GlobalInstance.DynJVM.javax.swing.JButton.@new("Add Row");
                clearButton.setActionCommand("Clear");
                sendButton.setActionCommand("Send");
                addRowButton.setActionCommand("AddRow");

                // Add chats components
                textLabel = JNetCore.GlobalInstance.DynJVM.JLabel.@new("Message: ");
                textField = JNetCore.GlobalInstance.DynJVM.JTextField.@new("Test Message", 15);
                textField.setActionCommand("TextEntered");
                textArea = JNetCore.GlobalInstance.DynJVM.JTextArea.@new("Message Area\n", 10, 5);

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
                var zoomModel = JNetCore.GlobalInstance.DynJVM.SpinnerNumberModel.@new(100, //initial value
                                                                                       25,  //min
                                                                                       200, //max
                                                                                       25); //step
                spinner = JNetCore.GlobalInstance.DynJVM.JSpinner.@new(zoomModel);
                var labelZoom = JNetCore.GlobalInstance.DynJVM.JLabel.@new("Zoom X");

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
                CommonContainer.Dyn().setSize(500, 600);
                CommonContainer.Dyn().setLayout(layout);
                CommonContainer.Dyn().add(chatPanel.Instance);
                tableButtonPanel.Dyn().add(addRowButton);
                tablePanel.Dyn().add(tableButtonPanel.Instance);
                tablePanel.Dyn().add(scrollPane);
                CommonContainer.Dyn().add(tablePanel.Instance);

                // Put constraint on components
                layout.putConstraint(JNetCore.GlobalInstance.DynJVM.SpringLayout.HORIZONTAL_CENTER, chatPanel.Instance, 5, JNetCore.GlobalInstance.DynJVM.SpringLayout.HORIZONTAL_CENTER, CommonContainer.Instance);
                layout.putConstraint(JNetCore.GlobalInstance.DynJVM.SpringLayout.WIDTH, chatPanel.Instance, 5, JNetCore.GlobalInstance.DynJVM.SpringLayout.WIDTH, CommonContainer.Instance);
                layout.putConstraint(JNetCore.GlobalInstance.DynJVM.SpringLayout.NORTH, chatPanel.Instance, 5, JNetCore.GlobalInstance.DynJVM.SpringLayout.NORTH, CommonContainer.Instance);

                layout.putConstraint(JNetCore.GlobalInstance.DynJVM.SpringLayout.NORTH, imagePanel.Instance, 5, JNetCore.GlobalInstance.DynJVM.SpringLayout.SOUTH, chatPanel.Instance);
                layout.putConstraint(JNetCore.GlobalInstance.DynJVM.SpringLayout.HORIZONTAL_CENTER, imagePanel.Instance, 5, JNetCore.GlobalInstance.DynJVM.SpringLayout.HORIZONTAL_CENTER, CommonContainer.Instance);
                layout.putConstraint(JNetCore.GlobalInstance.DynJVM.SpringLayout.WIDTH, imagePanel.Instance, 5, JNetCore.GlobalInstance.DynJVM.SpringLayout.WIDTH, CommonContainer.Instance);

                layout.putConstraint(JNetCore.GlobalInstance.DynJVM.SpringLayout.NORTH, tablePanel.Instance, 5, JNetCore.GlobalInstance.DynJVM.SpringLayout.SOUTH, imagePanel.Instance);
                layout.putConstraint(JNetCore.GlobalInstance.DynJVM.SpringLayout.HORIZONTAL_CENTER, imagePanel.Instance, 5, JNetCore.GlobalInstance.DynJVM.SpringLayout.HORIZONTAL_CENTER, CommonContainer.Instance);
                layout.putConstraint(JNetCore.GlobalInstance.DynJVM.SpringLayout.WIDTH, tablePanel.Instance, 5, JNetCore.GlobalInstance.DynJVM.SpringLayout.WIDTH, CommonContainer.Instance);
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