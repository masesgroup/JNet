using System;
using Java.Awt;
using Java.Awt.EventNs;
using MASES.JNet;

/*
 * Example program to run a basic AWT graphic application. To run use:
 * jnetAWTApp --JVMPath:<ABSOLUTE PATH TO JRE LIBRARY (jvm.dll/libjvm.so)
 * 
 * To add options to JVM use the --JVMOption:<option>, e.g. --JVMOption:-Xmx128M, --JVMOption:-XX:OnError=\"gcore %p;dbx - %p\"
 */

namespace MASES.JNetTemplate.JNetAWTApp
{
    class MyJNetCore : JNetCore<MyJNetCore> { }

    class Program
    {
        static void Main(string[] args)
        {
            MyJNetCore.CreateGlobalInstance(); // this call prepares the environment: it is mandatory to initialize the JVM
            var appArgs = MyJNetCore.FilteredArgs; // contains the remaining arguments, the JNet and JCOBridge arguments are discarded

            try
            {
                var vApp = new JVMWrapperApp();
                vApp.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        class JVMWrapperApp
        {
            bool execute = true;

            void ActionDone(ActionEvent args)
            {
                if (args.ActionCommand == "writeToConsole")
                {
                    Console.WriteLine("Action from JVM");
                }
                else if (args.ActionCommand == "closeApplication")
                {
                    Console.WriteLine("Closing...");
                    execute = false;
                }
            }

            public void Execute()
            {
                // the example uses the implicit cast to dynamic to access methods of the Java Object without an implementation in the .NET class

                var listener = new ActionListener(ActionDone);

                dynamic frame = new Frame("My First GUI");
                frame.setSize(300, 300);

                dynamic buttonWrite = new Button("Write to console");
                buttonWrite.setActionCommand("writeToConsole");
                buttonWrite.addActionListener(listener.Instance);
                dynamic buttonClose = new Button("Close application");
                buttonClose.setActionCommand("closeApplication");
                buttonClose.addActionListener(listener.Instance);
                dynamic panel = new Panel();
                var layout = new GridLayout(1, 2);
                panel.setLayout(layout.Instance);

                panel.add(buttonWrite); // Adds Button to content pane of frame
                panel.add(buttonClose); // Adds Button to content pane of frame
                frame.add(panel);
                frame.setVisible(true);
                Console.WriteLine("Waiting for close...");
                while (execute)
                {
                    System.Threading.Thread.Sleep(10);
                }
            }
        }
    }
}
