package org.mases.jnet;

import javax.swing.*;
import javax.swing.table.TableModel;
import java.awt.*;
import java.util.Vector;

public class TestAWT {
    public static void main(String[] args) throws InterruptedException, UnsupportedLookAndFeelException, ClassNotFoundException, InstantiationException, IllegalAccessException {

        Panel panel = new Panel();
        GridLayout layout = new GridLayout(2, 1);
        panel.setLayout(layout);
        TextArea textArea = new TextArea("", 10, 40);
        panel.add(textArea);
        Button button = new Button("Send TextArea text to Host Application");
        button.setActionCommand("sendData");
        panel.add(button);

        Frame frame = new Frame();
        frame.add(panel);
        frame.setLocation(100, 100);
        frame.setBounds(10, 10, 200, 300);
        frame.setVisible(true);

        int index = 0;
        while (true) {
            Thread.sleep(500);
           // frame.setLocation(100 + 100 * index % 2, 100 + 100 * index % 2);
            frame.setBounds(100 + 100 * index, 100 + 100 * index, 200, 300);
            frame.setVisible(true);
            index ++;
            if (index > 5) index = 0;
        }
    }
}
