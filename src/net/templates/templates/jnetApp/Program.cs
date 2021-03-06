using Java.Util;
using MASES.JNet;
using System;

namespace MASES.JNetTemplate.JNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JNetCore.CreateGlobalInstance(); // this call prepares the environment: it is mandatory to initialize the JVM
            var appArgs = JNetCore.FilteredArgs; // contains the remaining arguments, the JNet and JCOBridge arguments are discarded
            if (args.Length != 0)
            {
                var set = Collections.Singleton(appArgs[0]); // creates a Java.Util.Set<string> using the static method Collections.Singleton 
                Console.WriteLine(set.ToString()); // writes on stdout the previous set
            }
        }
    }
}
