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

using System;
using System.Reflection;
using System.Text;

namespace MASES.JNetReflector
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var assembly = typeof(Program).Assembly;
                Console.WriteLine($"{assembly.GetName().Name} (ver. {assembly.GetName().Version}) - JNet class reflection utility command line interface");
                Console.WriteLine();

                JNetReflectedCore.CreateGlobalInstance();

                foreach (var item in JNetReflectedCore.JarsToAnaylyze)
                {
                   ReflectionUtils.AnalyzeJar(item, JNetReflectedCore.DestinationRootPath, JNetReflectedCore.DryRun);
                }
            }
            catch (TargetInvocationException tie)
            {
                StringBuilder sb = new StringBuilder();
                Exception e = tie.InnerException;
                sb.AppendLine(e.Message);
                Exception innerException = e.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }
                ShowHelp(sb.ToString());
            }
            catch (Exception e)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(e.Message);
                Exception innerException = e.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }
                ShowHelp(sb.ToString());
            }
        }

        static void ShowHelp(string errorString = null)
        {
            var assembly = typeof(Program).Assembly;
            if (!string.IsNullOrEmpty(errorString))
            {
                Console.WriteLine("Error: {0}", errorString);
            }

            Console.WriteLine(JNetReflectedCore.HelpInfo());

            Console.WriteLine();
            Console.WriteLine("Examples: ");
            Console.WriteLine("dotnet" + assembly.GetName().Name + ".dll -OriginRootPath C:\\myJars -OriginJavadocUrl \"https://thehost/javadoc/\" -DestinationRootPath c:\\ReflectionDestination ");
        }
    }
}