/*
*  Copyright (c) 2022-2026 MASES s.r.l.
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

using Java.Nio;
using Java.Util.Regex;
using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.JNetTest.Common;
using System;
using System.Diagnostics;

namespace Org.Mases.JNet
{
    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public abstract class Predicate : JVMBridgeListener
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;

        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.Predicate";
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html"/>. Extends <see cref="Predicate"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public class Predicate<TObject> : Predicate
    {
        readonly bool _readJVM;

        /// <summary>
        /// The <see cref="Func{TObject, Boolean}"/> to be executed
        /// </summary>
        public virtual Func<TObject, bool> OnTest { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="Predicate{TObject}"/>
        /// </summary>
        public Predicate(bool readJVM) : base()
        {
            if (InitHandlers)
            {
                AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(TestEventHandler)); OnTest = Test;
            }
            _readJVM = readJVM;
        }

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
        {
            if (_readJVM)
            {
                var retVal = OnTest(data.EventData.TypedEventData);
                data.SetReturnValue(retVal);
            }
        }
        /// <summary>
        /// Executes the Predicate action in the CLR
        /// </summary>
        /// <param name="obj">The Predicate object</param>
        /// <returns>The test evaluation</returns>
        public virtual bool Test(TObject obj) { return false; }
    }
}

namespace MASES.JNetPerformanceTest
{
    class Program
    {
        const int MinValue = 10;
        const int MaxValue = 1000000000;
        const int Padding = 10;
        const int iterations = 1_000_000;
        static void Main(string[] args)
        {
            Console.WriteLine("Starting JNetByteBufferTest");

#if DEBUG
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.WriteLine("Press a button to start");
                System.Console.ReadKey();
            }
#endif

            Initialize();

            Stopwatch stopwatch = Stopwatch.StartNew();

            ExecuteTests();

            Console.WriteLine("Enabling Critical methods");

            var management = JNetTestCore.GlobalInstance.Management;

            management.EnableCriticalMethods = true;
            management.EnableCriticalMethodsOnGetThreshold = management.EnableCriticalMethodsOnSetThreshold = 0;

            ExecuteTests();

            stopwatch.Stop();
            System.Console.WriteLine($"All tests completed in {stopwatch.Elapsed}");
        }

        static void Initialize()
        {
            try
            {
                JNetTestCore.ApplicationWriteEventOrExceptionOnCmdLine = true;
                JNetTestCore.ApplicationHeapSize = "4G";
                JNetTestCore.ApplicationInitialHeapSize = "256M";
                JNetTestCore.CreateGlobalInstance();
                var appArgs = JNetTestCore.FilteredArgs;

                System.Console.WriteLine("Initialized JNetTestCore" + (appArgs.Length != 0 ? $", remaining arguments are {string.Join(" ", appArgs)}" : string.Empty));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                throw;
            }
        }

        static void ExecuteTests()
        {
            Console.WriteLine("Start TestStaticEmptyMethod");

            TestStaticEmptyMethod(iterations);

            Console.WriteLine("Start TestEmptyMethod");

            TestEmptyMethod(iterations);

            Console.WriteLine("Start TestPredicateRoundTrip");

            TestPredicateRoundTrip(iterations, false, false);
            TestPredicateRoundTrip(iterations, true, false);
            TestPredicateRoundTrip(iterations, false, true);
            TestPredicateRoundTrip(iterations, true, true);
        }

        static void TestStaticEmptyMethod(int requestedIterations)
        {
            Console.WriteLine($"TestStaticEmptyMethod with {requestedIterations} iterations");
            int i = 0;
            try
            {
                var jClass = JNetTestCore.GlobalInstance.JVM.GetClass("org.mases.jnet.TestPerformance");

                Console.WriteLine($"Start executeStaticEmptyMethod Invoke");

                Stopwatch watcher1 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    try
                    {
                        jClass.Invoke("executeStaticEmptyMethod");
                    }
                    catch (Java.Lang.OutOfMemoryError ex)
                    {
                        Console.WriteLine($"Break executeStaticEmptyMethod Invoke at iteration {i} due to {ex}");
                        break;
                    }
                }
                watcher1.Stop();

                Console.WriteLine($"End executeStaticEmptyMethod Invoke over {i} iterations - Elapsed {watcher1.Elapsed} - Mean time {TimeSpan.FromTicks(watcher1.Elapsed.Ticks / i)}");

                Console.WriteLine($"Start executeStaticEmptyMethod InvokeWithSignature");

                watcher1.Restart();
                for (i = 0; i < requestedIterations; i++)
                {
                    try
                    {
                        jClass.InvokeWithSignature("executeStaticEmptyMethod", "()V");
                    }
                    catch (Java.Lang.OutOfMemoryError ex)
                    {
                        Console.WriteLine($"Break executeStaticEmptyMethod at iteration {i} due to {ex}");
                        break;
                    }
                }
                watcher1.Stop();

                Console.WriteLine($"End executeStaticEmptyMethod InvokeWithSignature over {i} iterations - Elapsed {watcher1.Elapsed} - Mean time {TimeSpan.FromTicks(watcher1.Elapsed.Ticks / i)}");
            }
            catch
            {
                Console.WriteLine($"Failed at iteration: {i}");
                throw;
            }
        }

        static void TestEmptyMethod(int requestedIterations)
        {
            Console.WriteLine($"TestEmptyMethod with {requestedIterations} iterations");
            int i = 0;
            try
            {
                var jClass = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestPerformance") as IJavaObject;

                Console.WriteLine($"Start executeEmptyMethod Invoke");

                Stopwatch watcher1 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    try
                    {
                        jClass.Invoke("executeEmptyMethod");
                    }
                    catch (Java.Lang.OutOfMemoryError ex)
                    {
                        Console.WriteLine($"Break executeEmptyMethod Invoke at iteration {i} due to {ex}");
                        break;
                    }
                }
                watcher1.Stop();

                Console.WriteLine($"End executeEmptyMethod over {i} iterations - Elapsed {watcher1.Elapsed} - Mean time {TimeSpan.FromTicks(watcher1.Elapsed.Ticks / i)}");

                Console.WriteLine($"Start executeEmptyMethod InvokeWithSignature");

                watcher1.Restart();
                for (i = 0; i < requestedIterations; i++)
                {
                    try
                    {
                        jClass.InvokeWithSignature("executeEmptyMethod", "()V");
                    }
                    catch (Java.Lang.OutOfMemoryError ex)
                    {
                        Console.WriteLine($"Break executeEmptyMethod at iteration {i} due to {ex}");
                        break;
                    }
                }
                watcher1.Stop();

                Console.WriteLine($"End executeEmptyMethod InvokeWithSignature over {i} iterations - Elapsed {watcher1.Elapsed} - Mean time {TimeSpan.FromTicks(watcher1.Elapsed.Ticks / i)}");
            }
            catch
            {
                Console.WriteLine($"Failed at iteration: {i}");
                throw;
            }
        }

        static void TestPredicateRoundTrip(int requestedIterations, bool byIndex, bool readJVM)
        {
            Console.WriteLine($"TestPredicateRoundTrip with {requestedIterations} iterations - byIndex={byIndex} readJVM={readJVM}");
            int i = 0;
            try
            {
                var method = byIndex ? "executePredicateIndex" : "executePredicate";
                using (var predicate = new Org.Mases.JNet.Predicate<object>(readJVM)
                {
                    OnTest = (o) =>
                    {
                        return true;
                    }
                })
                {
                    var jClass = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestPerformance", predicate) as IJavaObject;

                    Stopwatch watcher1 = Stopwatch.StartNew();
                    for (i = 0; i < requestedIterations; i++)
                    {
                        jClass.InvokeWithSignature(method, "()Z");
                    }
                    watcher1.Stop();
                    Console.WriteLine($"End {method} over {i} iterations - Elapsed {watcher1.Elapsed} - Mean time {TimeSpan.FromTicks(watcher1.Elapsed.Ticks / i)}");
                }
            }
            catch
            {
                Console.WriteLine($"Failed at iteration: {i}");
                throw;
            }
        }
    }
}
