/*
*  Copyright 2025 MASES s.r.l.
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

using MASES.CLIParser;
using MASES.JCOBridge.C2JBridge;
using MASES.JNet;
using MASES.JNet.Specific;
using MASES.JNet.Specific.Extensions;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MASES.JNet.CLI
{
    public class ProgramBase<TRunner, TProgram>
        where TRunner : JNetCoreBase<TRunner>
        where TProgram : ProgramBase<TRunner, TProgram>
    {
        static readonly Type RunnerType = typeof(TRunner);
        static readonly Type ProgramType = typeof(TProgram);

        async Task Start()
        {
            if (JNetCLICoreHelper.Interactive)
            {
                ScriptOptions options = ScriptOptions.Default.WithReferences(JNetCLICoreHelper.ReferencesOf<TRunner>())
                                                             .WithImports(JNetCLICoreHelper.NamespaceList);
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
                                    Console.WriteLine($"{jvmbe.BridgeClassName}: {jvmbe.Message}");
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
            else if (!string.IsNullOrEmpty(JNetCLICoreHelper.Script))
            {
                if (!File.Exists(JNetCLICoreHelper.Script)) throw new FileNotFoundException("A valid file must be provided", JNetCLICoreHelper.Script);

                var scriptCode = File.ReadAllText(JNetCLICoreHelper.Script);

                ScriptOptions options = ScriptOptions.Default.WithReferences(JNetCLICoreHelper.ReferencesOf<TRunner>())
                                                             .WithImports(JNetCLICoreHelper.NamespaceList);

                var script = CSharpScript.Create(scriptCode, options);
                var result = await script.RunAsync();
                if (result.ReturnValue != null) Console.WriteLine(result.ReturnValue);
            }
            else if (!string.IsNullOrEmpty(JNetCLICoreHelper.RunCommand))
            {
                var res = RunnerType.GetStaticPropertyOn(typeof(SetupJVMWrapper), nameof(JNetCoreBase<TRunner>.FilteredArgs));
                GenericCommand.CreateAndLaunch(JNetCLICoreHelper.RunCommand, (object[])res);
            }
            else ShowHelp();
        }

        public static async Task InternalMain(string[] args)
        {
            var main = Activator.CreateInstance<TProgram>();

            try
            {
                JNetCLICoreHelper.DefaultClassToRun = main.DefaultClassToRun;
                RunnerType.RunStaticMethodOn(typeof(SetupJVMWrapper<>), nameof(JNetCoreBase<TRunner>.CreateGlobalInstance));
                await main.Start();
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
                main.ShowHelp(sb.ToString());
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
                main.ShowHelp(sb.ToString());
            }
        }

        public virtual string ProjectName => "JNet";

        public virtual string ProgramName => ProgramType.Assembly.GetName().Name;

        public virtual Version ProgramVersion => ProgramType.Assembly.GetName().Version;

        public virtual string EntryLine => $"{ProgramName} (ver. {ProgramVersion}) - {ProjectName} command line interface";

        public virtual string SpecificArguments => null;

        public virtual string ExampleLines => ProgramName;

        public virtual string DefaultClassToRun => null;

        public virtual void ShowHelp(string errorString = null)
        {
            Console.WriteLine(EntryLine);
            Console.WriteLine();
            if (!string.IsNullOrEmpty(errorString))
            {
                Console.WriteLine("Error: {0}", errorString);
            }

            Dictionary<string, Type> implementedClasses = new Dictionary<string, Type>();
            StringBuilder avTypes = new();
            foreach (var reference in JNetCLICoreHelper.ReferencesOf<TRunner>())
            {
                IDictionary<string, Type> classes = RunnerType.RunStaticMethodOn(typeof(SetupJVMWrapper), nameof(JNetCoreBase<TRunner>.GetMainClasses), reference) as IDictionary<string, Type>;
                foreach (var cls in classes)
                {
                    if (!implementedClasses.ContainsKey(cls.Key))
                    {
                        implementedClasses.Add(cls.Key, cls.Value);
                        avTypes.AppendFormat("{0}, ", cls.Key);
                    }
                }
            }

            Console.WriteLine(ProgramName + " -ClassToRun classname <Specific arguments> <JCOBridgeArguments> <ClassArguments>");
            Console.WriteLine();
            Console.WriteLine(RunnerType.RunStaticMethodOn(typeof(JNetCoreBase<>), nameof(JNetCoreBase<TRunner>.HelpInfo), new Type[] { typeof(int?) }, new object[] { null }));
            if (!string.IsNullOrWhiteSpace(SpecificArguments))
            {
                Console.WriteLine(SpecificArguments);
            }
            Console.WriteLine("JCOBridgeArguments: the arguments of JCOBridge (see online at https://www.jcobridge.com/net-examples/command-line-options/ for the possible values). ");
            Console.WriteLine("ClassArguments: the arguments of the class. Depends on the ClassToRun value, to obtain them runs the application or look at requested class documentation.");
            Console.WriteLine();
            Console.WriteLine("The Main classes can be invoked are: {0}... ", avTypes.ToString());
            Console.WriteLine();
            Console.WriteLine("Examples:");
            Console.WriteLine(ExampleLines);
        }
    }
}