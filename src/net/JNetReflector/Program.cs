/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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
using System.IO;
using System.Reflection;
using System.Text;

namespace MASES.JNet.Reflector
{
    class Program
    {
        static StreamWriter _writer = null;

        static void Main(string[] args)
        {
            try
            {    
                var assembly = typeof(Program).Assembly;
                Console.WriteLine($"{assembly.GetName().Name} (ver. {assembly.GetName().Version}) - JNet class reflection utility command line interface");
                Console.WriteLine();

                JNetReflectorCore.CreateGlobalInstance();
                if (JNetReflectorCore.TraceTo != null)
                {
                    _writer = File.Exists(JNetReflectorCore.TraceTo) ? File.AppendText(JNetReflectorCore.TraceTo) : File.CreateText(JNetReflectorCore.TraceTo);
                    _writer.WriteLine($"Started new analysis at {DateTime.Now}");
                }

                ReflectionUtils.SetHandlerAndLevel(TraceReportHandler, JNetReflectorCore.TraceLevel);
                ReflectionUtils.Reflect();
            }
            catch (TargetInvocationException tie)
            {
                StringBuilder sb = new StringBuilder();
                Exception e = tie.InnerException;
#if DEBUG
                sb.AppendLine(e.ToString());
#else
                sb.AppendLine(e.Message);
#endif
                Exception innerException = e.InnerException;
                while (innerException != null)
                {
#if DEBUG
                    sb.AppendLine(innerException.ToString());
#else
                    sb.AppendLine(innerException.Message);
#endif
                    innerException = innerException.InnerException;
                }
                ShowHelp(sb.ToString());
                Environment.ExitCode = 1;
            }
            catch (Exception e)
            {
                StringBuilder sb = new StringBuilder();
#if DEBUG
                sb.AppendLine(e.ToString());
#else
                sb.AppendLine(e.Message);
#endif
                Exception innerException = e.InnerException;
                while (innerException != null)
                {
#if DEBUG
                    sb.AppendLine(innerException.ToString());
#else
                    sb.AppendLine(innerException.Message);
#endif
                    innerException = innerException.InnerException;
                }
                ShowHelp(sb.ToString());
                Environment.ExitCode = 1;
            }
            finally
            {
                _writer?.Dispose();
            }
        }

        static void TraceReportHandler(object sender, string trace)
        {
            if (_writer != null)
            {
                _writer.WriteLine(trace);
            }
            else
            {
                Console.WriteLine(trace);
            }
        }

        static void ShowHelp(string errorString = null)
        {
            var assembly = typeof(Program).Assembly;
            if (!string.IsNullOrEmpty(errorString))
            {
                Console.WriteLine("Error: {0}", errorString);
            }

            Console.WriteLine(JNetReflectorCore.HelpInfo());

            Console.WriteLine();
            Console.WriteLine("Examples: ");
            Console.WriteLine("dotnet " + assembly.GetName().Name + ".dll -OriginRootPath C:\\myJars -OriginJavadocUrl \"https://thehost/javadoc/\" -DestinationRootPath c:\\ReflectionDestination ");
        }
    }
}