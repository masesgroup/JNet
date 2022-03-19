using Java.Util;
using MASES.JNet;
using System;

namespace MASES.JNetTemplate.JNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var appArgs = JNetCore.GlobalInstance.ApplicationArgs;
            if (args.Length != 0)
            {
                var set = Collections.Singleton(appArgs[0]);
                Console.WriteLine(set.ToString());
            }
        }
    }
}
