using System;
using MASES.JCOBridge.C2JBridge;

/*
 * Example program to run a basic console application based only on JCOBridge. To run use:
 * jcobridgeConsoleApp --JVMPath:<ABSOLUTE PATH TO JRE LIBRARY (jvm.dll/libjvm.so)
 * 
 * To add options to JVM use the --JVMOption:<option>, e.g. --JVMOption:-Xmx128M, --JVMOption:-XX:OnError=\"gcore %p;dbx - %p\"
 */

namespace MASES.JNetTemplate.JCOBridgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var vApp = new JVMWrapperApp();
                vApp.Execute();
                vApp = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        class JVMWrapperApp : SetupJVMWrapper
        {
            public void Execute()
            {
                ImportPackage("java.lang");
                ImportPackage("java.util");

                var str = DynJVM.String.@new();
                Console.WriteLine("Output from JVM: {0}", str.concat("HELLO WORLD FROM JVM!!!"));
            }
        }
    }
}
