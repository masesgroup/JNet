package org.mases.jnet;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;
import java.util.Vector;

public class TestSwing {
    public static void main(String[] args) throws InterruptedException, UnsupportedLookAndFeelException, ClassNotFoundException, InstantiationException, IllegalAccessException {
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
        String[][] data;

        // don't work: JFrame.SetDefaultLookAndFeelDecorated(true);
        JFrame.setDefaultLookAndFeelDecorated(true);
        UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");

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

        // Set Layouts
        chatPanel.setLayout(chatLayout);
        messagePanel.setLayout(messageLayout);
        tablePanel.setLayout(tableLayout);
        tableButtonPanel.setLayout(tableButtonLayout);

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

        // var condition = JComponent.WHEN_FOCUSED;

        messagePanel.add(textLabel);
        messagePanel.add(textField);
        messagePanel.add(sendButton);
        messagePanel.add(clearButton);
        chatPanel.add(textArea);
        chatPanel.add(messagePanel);
        chatPanel.setSize(100, 100);

        // Add spinner
        var zoomModel = new SpinnerNumberModel(100, //initial value
                25,  //min
                200, //max
                25); //step
        spinner = new JSpinner(zoomModel);
        var labelZoom = new JLabel("Zoom X");

        //Add table
        data = new String[][]{new String[]{"101", "Amit", "670000"},
                new String[]{"102", "Jai", "780000"},
                new String[]{"101", "Sachin", "700000"},
                new String[]{"103", "New Row", "0"}};

        String[] columns = {"ID", "NAME", "SALARY"};
        var jt = new JTable(0, 3);
        tableModel = jt.getModel();
        if (tableModel instanceof javax.swing.table.DefaultTableModel) {
            javax.swing.table.DefaultTableModel tModel = (javax.swing.table.DefaultTableModel) tableModel;
            Vector<String> vector = new Vector<String>();
            vector.add(columns[0]);
            vector.add(columns[1]);
            vector.add(columns[2]);
            tModel.setColumnIdentifiers(vector);   // (new string[] { columns[0], columns[1], columns[2] });
            vector = new Vector<String>();
            vector.add(data[0][0]);
            vector.add(data[0][1]);
            vector.add(data[0][2]);
            tModel.addRow(vector);
            vector = new Vector<String>();
            vector.add(data[1][0]);
            vector.add(data[1][1]);
            vector.add(data[1][2]);
            tModel.addRow(vector);
            vector = new Vector<String>();
            vector.add(data[2][0]);
            vector.add(data[2][1]);
            vector.add(data[2][2]);
            tModel.addRow(vector);
        }

        jt.setBounds(30, 40, 200, 300);
        // Put table in a scroll panel
        var scrollPane = new JScrollPane(jt);

        //configure panel
        jPanel.setSize(500, 600);
        jPanel.setLayout(layout);
        jPanel.add(chatPanel);
        tableButtonPanel.add(addRowButton);
        tablePanel.add(tableButtonPanel);
        tablePanel.add(scrollPane);
        jPanel.add(tablePanel);

        // Put constraint on components
        layout.putConstraint(SpringLayout.HORIZONTAL_CENTER, chatPanel, 5, SpringLayout.HORIZONTAL_CENTER, jPanel);
        layout.putConstraint(SpringLayout.WIDTH, chatPanel, 5, SpringLayout.WIDTH, jPanel);
        layout.putConstraint(SpringLayout.NORTH, chatPanel, 5, SpringLayout.NORTH, jPanel);

        layout.putConstraint(SpringLayout.NORTH, imagePanel, 5, SpringLayout.SOUTH, chatPanel);
        layout.putConstraint(SpringLayout.HORIZONTAL_CENTER, imagePanel, 5, SpringLayout.HORIZONTAL_CENTER, jPanel);
        layout.putConstraint(SpringLayout.WIDTH, imagePanel, 5, SpringLayout.WIDTH, jPanel);

        layout.putConstraint(SpringLayout.NORTH, tablePanel, 5, SpringLayout.SOUTH, imagePanel);
        layout.putConstraint(SpringLayout.HORIZONTAL_CENTER, imagePanel, 5, SpringLayout.HORIZONTAL_CENTER, jPanel);
        layout.putConstraint(SpringLayout.WIDTH, tablePanel, 5, SpringLayout.WIDTH, jPanel);

        JFrame frame = new JFrame();
        frame.add(jPanel);
        frame.setBounds(10, 10, 200, 300);
        frame.setVisible(true);

        while (true) {
            Thread.sleep(100);
        }
    }
}
