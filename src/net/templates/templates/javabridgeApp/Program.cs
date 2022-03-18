using Java.Util;
using MASES.JavaBridge;
using System;

namespace MASES.JavaBridgeTemplate.JavaBridgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var appArgs = JavaBridgeCore.GlobalInstance.ApplicationArgs;
            if (args.Length != 0)
            {
                var set = Collections.Singleton(appArgs[0]);
                Console.WriteLine(set.ToString());
            }
        }
    }
}
