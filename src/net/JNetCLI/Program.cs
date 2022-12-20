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

using MASES.JCOBridge.C2JBridge;
using MASES.JNet;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MASES.JNetCLI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                JNetCLICore.CreateGlobalInstance();

                if (JNetCLICore.Interactive)
                {
                    ScriptOptions options = ScriptOptions.Default.WithReferences(typeof(JNetCoreBase<>).Assembly)
                                                                 .WithImports(JNetCLICore.NamespaceList);
                    ScriptState<object> state = null;
                    while (true)
                    {
                        try
                        {
                            var codeToEval = Console.ReadLine();
                            if (state == null)
                            {
                                state = await CSharpScript.RunAsync(codeToEval, options);
                            }
                            else
                            {
                                state = await state.ContinueWithAsync(codeToEval, options, (o) =>
                                {
                                    if (o is CompilationErrorException)
                                    {
                                        Console.WriteLine(o);
                                        return true;
                                    }
                                    else if (o is JVMBridgeException jvmbe)
                                    {
                                        Console.WriteLine($"{jvmbe.ClassName}: {jvmbe.Message}");
                                        return true;
                                    }
                                    return false;
                                });
                            }
                            if (state.ReturnValue != null) Console.WriteLine(state.ReturnValue);
                        }
                        catch (JVMBridgeException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (CompilationErrorException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                else if (!string.IsNullOrEmpty(JNetCLICore.Script))
                {
                    if (!File.Exists(JNetCLICore.Script)) throw new FileNotFoundException("A valid file must be provided", JNetCLICore.Script);

                    var scriptCode = File.ReadAllText(JNetCLICore.Script);

                    ScriptOptions options = ScriptOptions.Default.WithReferences(typeof(JNetCoreBase<>).Assembly)
                                                                 .WithImports(JNetCLICore.NamespaceList);

                    var script = CSharpScript.Create(scriptCode, options);
                    var result = await script.RunAsync();
                    if (result.ReturnValue != null) Console.WriteLine(result.ReturnValue);
                }
                else if (!string.IsNullOrEmpty(JNetCLICore.RunCommand))
                {
                    GenericCommand.CreateAndLaunch(JNetCLICore.RunCommand, JNetCLICore.FilteredArgs);
                }
                else ShowHelp();
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
            Console.WriteLine($"{assembly.GetName().Name} (ver. {assembly.GetName().Version}) - JNet command line interface");
            Console.WriteLine();
            if (!string.IsNullOrEmpty(errorString))
            {
                Console.WriteLine("Error: {0}", errorString);
            }

            Console.WriteLine(JNetCLICore.HelpInfo());

            Console.WriteLine("JCOBridgeArguments: the arguments of JCOBridge (see online at https://www.jcobridge.com/net-examples/command-line-options/ for the possible values). ");
            Console.WriteLine();
            Console.WriteLine("Examples:");
            Console.WriteLine(assembly.GetName().Name + " ");
        }
    }
}