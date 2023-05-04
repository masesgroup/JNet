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
                if (appArgs.Length != 0 && appArgs[0] == "dyn")
                {
                    vApp.ExecuteDynamics();
                }
                else vApp.Execute();
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

            public void ExecuteDynamics()
            {
                // the example uses the implicit cast to dynamic to access methods of the Java Object without an implementation in the .NET class

                var listener = new ActionListener(ActionDone);

                dynamic frame = new Frame("My First GUI");
                frame.setSize(300, 300);

                dynamic buttonWrite = new Button("Write to console");
                buttonWrite.setActionCommand("writeToConsole");
                buttonWrite.addActionListener(listener.BridgeInstance);
                dynamic buttonClose = new Button("Close application");
                buttonClose.setActionCommand("closeApplication");
                buttonClose.addActionListener(listener.BridgeInstance);
                dynamic panel = new Panel();
                var layout = new GridLayout(1, 2);
                panel.setLayout(layout.BridgeInstance);

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

            public void Execute()
            {
                using (var listener = new ActionListener(ActionDone))
                {
                    var frame = new Frame("My First GUI");
                    frame.SetSize(300, 300);

                    var buttonWrite = new Button("Write to console")
                    {
                        ActionCommand = "writeToConsole"
                    };
                    buttonWrite.AddActionListener(listener);
                    var buttonClose = new Button("Close application")
                    {
                        ActionCommand = "closeApplication"
                    };
                    buttonClose.AddActionListener(listener);
                    var panel = new Panel();
                    var layout = new GridLayout(1, 2);
                    panel.Layout = layout;

                    panel.Add(buttonWrite); // Adds Button to content pane of frame
                    panel.Add(buttonClose); // Adds Button to content pane of frame
                    frame.Add(panel);
                    frame.SetVisible(true);
                    Console.WriteLine("Waiting for close...");
                    while (execute)
                    {
                        System.Threading.Thread.Sleep(10);
                    }
                }
            }
        }
    }
}
