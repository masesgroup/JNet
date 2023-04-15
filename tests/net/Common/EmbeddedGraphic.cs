/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

using Java.Awt;
using Java.Awt.EventNs;
using Javax.Swing;
using Javax.Swing.Table;
using MASES.JCOBridge.C2JBridge;
using MASES.JNetTest.Common;
using System;

namespace MASES.JNetTest.GraphicCommon
{
    static class GraphicCommon
    {
        public static TextArea TextArea { get; private set; }

        static Container CommonContainer { get; set; }

        public static IJCGraphicContainer Container { get; private set; }
        static ActionListener _Listener;

        public static object CreateAWTContent(Action<ActionEvent> handler)
        {
            return CreateAWTContentDynamic(handler);
            return CreateAWTContentClasses(handler);
        }

        public static object CreateAWTContentDynamic(Action<ActionEvent> handler)
        {
            try
            {
                _Listener = new ActionListener(handler);
                CommonContainer = new Panel();
                dynamic container = CommonContainer;
                dynamic layout = new GridLayout(2, 1);
                container.setLayout(layout);
                TextArea = new TextArea("", 10, 40);
                container.add(TextArea);
                dynamic button = new Button("Send TextArea text to Host Application");
                button.setActionCommand("sendData");
                button.addActionListener(_Listener.Instance);
                container.add(button);
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

        public static object CreateAWTContentClasses(Action<ActionEvent> handler)
        {
            try
            {
                _Listener = new ActionListener(handler);
                var panel = new Panel();
                var layout = new GridLayout(2, 1);
                panel.Layout = layout;
                TextArea = new TextArea("", 10, 40);
                panel.Add(TextArea);
                var button = new Button("Send TextArea text to Host Application");
                button.ActionCommand = "sendData";
                button.AddActionListener(_Listener);
                panel.Add(button);
                CommonContainer = panel;
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
            //return CreateSwingContentDynamic();
            return CreateSwingContentClasses();
        }

        public static object CreateSwingContentDynamic()
        {
            try
            {
                JNetTestCore.GlobalInstance.JVM.ImportPackage("java.lang");
                JNetTestCore.GlobalInstance.JVM.ImportPackage("java.util");
                JNetTestCore.GlobalInstance.JVM.ImportPackage("java.lang.reflect");
                JNetTestCore.GlobalInstance.JVM.ImportPackage("java.net");
                JNetTestCore.GlobalInstance.JVM.ImportPackage("java.awt");
                JNetTestCore.GlobalInstance.JVM.ImportPackage("javax.swing");
                JNetTestCore.GlobalInstance.JVM.ImportPackage("rvl.awt.Slider");

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
                JNetTestCore.GlobalInstance.DynJVM.JFrame.setDefaultLookAndFeelDecorated(true);

                UIManager.DynClazz.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");

                // Define the panel to hold the components  
                CommonContainer = new JPanel();
                dynamic container = CommonContainer;
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
                var keystroke = JNetTestCore.GlobalInstance.DynJVM.KeyStroke.getKeyStroke('a', false);
                var condition = JNetTestCore.GlobalInstance.DynJVM.JComponent.WHEN_FOCUSED;

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
                var jt = JNetTestCore.GlobalInstance.DynJVM.JTable.@new(0, 3);
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
                var scrollPane = JNetTestCore.GlobalInstance.DynJVM.JScrollPane.@new(jt);

                //configure panel
                container.setSize(500, 600);
                container.setLayout(layout);
                container.add(chatPanel.Instance);
                tableButtonPanel.Dyn().add(addRowButton);
                tablePanel.Dyn().add(tableButtonPanel.Instance);
                tablePanel.Dyn().add(scrollPane);
                container.add(tablePanel.Instance);

                dynamic layoutAccessor = JNetTestCore.GlobalInstance.DynJVM.SpringLayout;

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

        public static object CreateSwingContentClasses()
        {
            try
            {
                JButton clearButton;
                JButton sendButton;
                SpringLayout layout;
                JPanel chatPanel;
                JPanel messagePanel;
                JPanel imagePanel;
                JPanel tablePanel;
                JPanel tableButtonPanel;
                JButton addRowButton;
                JLabel textLabel;
                JTextField textField;
                JTextArea textArea;
                JSpinner spinner;
                TableModel tableModel;
                string[][] data;

                // don't work: JFrame.SetDefaultLookAndFeelDecorated(true);
                JFrame.SetDefaultLookAndFeelDecorated(true);
                UIManager.SetLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");

                // Define the panel to hold the components  
                var jPanel = new JPanel();
                // Contains all the chat components
                chatPanel = new JPanel();
                messagePanel = new JPanel();
                // Contains all the table components
                tablePanel = new JPanel();
                tableButtonPanel = new JPanel();
                // Contains all the image components
                imagePanel = new JPanel();

                // Define layouts
                BoxLayout chatLayout = new BoxLayout(chatPanel, BoxLayout.Y_AXIS);
                BoxLayout messageLayout = new BoxLayout(messagePanel, BoxLayout.X_AXIS);
                BoxLayout tableLayout = new BoxLayout(tablePanel, BoxLayout.Y_AXIS);
                BoxLayout tableButtonLayout = new BoxLayout(tableButtonPanel, BoxLayout.X_AXIS);
                layout = new SpringLayout();

                // Put constraint on components
                layout.PutConstraint(SpringLayout.HORIZONTAL_CENTER, chatPanel, 5, SpringLayout.HORIZONTAL_CENTER, jPanel);
                layout.PutConstraint(SpringLayout.WIDTH, chatPanel, 5, SpringLayout.WIDTH, jPanel);
                layout.PutConstraint(SpringLayout.NORTH, chatPanel, 5, SpringLayout.NORTH, jPanel);

                layout.PutConstraint(SpringLayout.NORTH, imagePanel, 5, SpringLayout.SOUTH, chatPanel);
                layout.PutConstraint(SpringLayout.HORIZONTAL_CENTER, imagePanel, 5, SpringLayout.HORIZONTAL_CENTER, jPanel);
                layout.PutConstraint(SpringLayout.WIDTH, imagePanel, 5, SpringLayout.WIDTH, jPanel);

                layout.PutConstraint(SpringLayout.NORTH, tablePanel, 5, SpringLayout.SOUTH, imagePanel);
                layout.PutConstraint(SpringLayout.HORIZONTAL_CENTER, imagePanel, 5, SpringLayout.HORIZONTAL_CENTER, jPanel);
                layout.PutConstraint(SpringLayout.WIDTH, tablePanel, 5, SpringLayout.WIDTH, jPanel);

                // Set Layouts
                chatPanel.Layout = chatLayout;
                messagePanel.Layout = messageLayout;
                tablePanel.Layout = tableLayout;
                tableButtonPanel.Layout = tableButtonLayout;

                // Create buttons
                clearButton = new JButton("Clear");
                sendButton = new JButton("Send");
                addRowButton = new JButton("Add Row");
                clearButton.ActionCommand = "Clear";
                sendButton.ActionCommand = "Send";
                addRowButton.ActionCommand = "AddRow";

                // Add chats components
                textLabel = new JLabel("Message: ");
                textField = new JTextField("Test Message", 15);
                textField.SetActionCommand("TextEntered");
                textArea = new JTextArea("Message Area\n", 10, 5);

                // var condition = JComponent.WHEN_FOCUSED;

                messagePanel.Add(textLabel);
                messagePanel.Add(textField);
                messagePanel.Add(sendButton);
                messagePanel.Add(clearButton);
                chatPanel.Add(textArea);
                chatPanel.Add(messagePanel);
                chatPanel.SetSize(100, 100);

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
                var jt = new JTable(0, 3);
                tableModel = jt.Model;
                if (tableModel.IsInstanceOf<DefaultTableModel>())
                {
                    var tModel = tableModel.CastTo<DefaultTableModel>();
                    Java.Util.Vector<string> vector = new();
                    vector.Add(columns[0]); vector.Add(columns[1]); vector.Add(columns[2]);
                    tModel.SetColumnIdentifiers(vector); // (new string[] { columns[0], columns[1], columns[2] });
                    vector = new();
                    vector.Add(data[0][0]); vector.Add(data[0][1]); vector.Add(data[0][2]);
                    tModel.AddRow(vector);
                    vector = new();
                    vector.Add(data[1][0]); vector.Add(data[1][1]); vector.Add(data[1][2]);
                    tModel.AddRow(vector);
                    vector = new();
                    vector.Add(data[2][0]); vector.Add(data[2][1]); vector.Add(data[2][2]);
                    tModel.AddRow(vector);
                }

                jt.SetBounds(30, 40, 200, 300);
                // Put table in a scroll panel
                var scrollPane = new JScrollPane(jt);

                //configure panel
                jPanel.SetSize(500, 600);
                jPanel.Layout = layout;
                jPanel.Add(chatPanel);
                tableButtonPanel.Add(addRowButton);
                tablePanel.Add(tableButtonPanel);
                tablePanel.Add(scrollPane);
                jPanel.Add(tablePanel);

                CommonContainer = jPanel;
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