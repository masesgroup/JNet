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

using Java.Nio;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.JNetTest.Common;
using System;
using System.Diagnostics;

namespace MASES.JNetByteBufferTest
{
    class Program
    {
        const int MinValue = 10;
        const int MaxValue = 1000000000;
        const int Padding = 10;
        const int iterations = 100;
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
            Console.WriteLine("Start insert from CLR to JVM");

            for (int i = MinValue; i < MaxValue; i *= 10)
            {
                TestInsertByteBuffers(iterations, i);
            }

            Console.WriteLine("Start get from JVM to CLR");

            for (int i = MinValue; i < MaxValue; i *= 10)
            {
                TestGetByteBuffers(iterations, i);
            }
        }

        static void TestInsertByteBuffers(int requestedIterations, int length)
        {
            Console.WriteLine($"TestInsertByteBuffers with {requestedIterations} iterations and {length} length");
            int i = 0;
            try
            {
                byte[] bytes = new byte[length];
                for (i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)(i % byte.MaxValue);
                }

                var bbCast = Java.Nio.ByteBuffer.From(bytes, false, false);
                var jClass = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestArrayAndByteBuffer") as IJavaObject;

                System.GC.Collect();
                Java.Lang.System.Gc();

                Console.WriteLine($"Created TestArrayAndByteBuffer");

                Stopwatch watcher1 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    try
                    {
                        jClass.Invoke("insertArray", bytes);
                    }
                    catch (Java.Lang.OutOfMemoryError ex)
                    {
                        Console.WriteLine($"Break insertArray at iteration {i} due to {ex}");
                        break;
                    }
                }
                watcher1.Stop();

                Console.WriteLine($"End insertArray Elapsed {watcher1.Elapsed}");

                System.GC.Collect();
                Java.Lang.System.Gc();

                Stopwatch watcher2 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    try
                    {
                        jClass.Invoke("insertByteBuffer", bbCast.BridgeInstance);
                    }
                    catch (Java.Lang.OutOfMemoryError ex)
                    {
                        Console.WriteLine($"Break insertByteBuffer at iteration {i} due to {ex}");
                        break;
                    }
                }
                watcher2.Stop();

                Console.WriteLine($"End insertByteBuffer Elapsed {watcher2.Elapsed}");

                System.GC.Collect();
                Java.Lang.System.Gc();

                Stopwatch watcher3 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    try
                    {
                        jClass.Invoke("insertByteBufferNoNew", bbCast.BridgeInstance);
                    }
                    catch (Java.Lang.OutOfMemoryError ex)
                    {
                        Console.WriteLine($"Break insertByteBufferNoNew at iteration {i} due to {ex}");
                        break;
                    }
                }
                watcher3.Stop();

                Console.WriteLine($"End insertByteBufferNoNew Elapsed {watcher3.Elapsed}");

                System.GC.Collect();
                Java.Lang.System.Gc();

                Stopwatch watcher4 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    try
                    {
                        jClass.Invoke("insertByteBufferNoGet", bbCast.BridgeInstance);
                    }
                    catch (Java.Lang.OutOfMemoryError ex)
                    {
                        Console.WriteLine($"Break insertByteBufferNoGet at iteration {i} due to {ex}");
                        break;
                    }
                }
                watcher4.Stop();

                Console.WriteLine($"End insertByteBufferNoGet Elapsed {watcher4.Elapsed}");

                Console.WriteLine($"{length,Padding} Mean Time over {requestedIterations} iterations - Array {TimeSpan.FromTicks(watcher1.Elapsed.Ticks / requestedIterations)} - ByteBuffer {TimeSpan.FromTicks(watcher2.Elapsed.Ticks / requestedIterations)} ({((double)watcher1.Elapsed.Ticks / watcher2.Elapsed.Ticks) * 100:0.##}%) - ByteBufferNoNew {TimeSpan.FromTicks(watcher3.Elapsed.Ticks / requestedIterations)} ({((double)watcher1.Elapsed.Ticks / watcher3.Elapsed.Ticks) * 100:0.##}%) - ByteBufferNoGet {TimeSpan.FromTicks(watcher4.Elapsed.Ticks / requestedIterations)} ({((double)watcher1.Elapsed.Ticks / watcher4.Elapsed.Ticks) * 100:0.##}%)");
            }
            catch
            {
                Console.WriteLine($"Failed at iteration: {i}");
                throw;
            }
        }

        static void TestGetByteBuffers(int requestedIterations, int length)
        {
            Console.WriteLine($"TestGetByteBuffers with {requestedIterations} iterations and {length} length");
            int i = 0;
            try
            {
                byte[] bytes = new byte[length];
                var jClass = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestArrayAndByteBuffer", length) as IJavaObject;

                System.GC.Collect();
                Java.Lang.System.Gc();

                Console.WriteLine($"Created TestArrayAndByteBuffer");

                Stopwatch watcher1 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    var res = jClass.Invoke<byte[]>("getArray");
                    if (res.Length != length) { throw new System.Exception(); }
                }
                watcher1.Stop();

                Console.WriteLine($"End getArray Elapsed {watcher1.Elapsed}");

                System.GC.Collect();
                Java.Lang.System.Gc();

                Stopwatch watcher2 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    var res = jClass.Invoke<ByteBuffer>("getByteBuffer");
                    var array = res.ToArray();
                    if (array.Length != length) { throw new System.Exception(); }
                }
                watcher2.Stop();

                Console.WriteLine($"End getByteBuffer -> ByteBuffer -> ToArray Elapsed {watcher2.Elapsed}");

                System.GC.Collect();
                Java.Lang.System.Gc();

                Stopwatch watcher3 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    var res = jClass.Invoke<ByteBuffer>("getByteBuffer");
                    res.ToArray(ref bytes, false);
                    if (bytes.Length != length) { throw new System.Exception(); }
                }
                watcher3.Stop();

                Console.WriteLine($"End getByteBuffer -> ByteBuffer -> ToArray with noResize Elapsed {watcher3.Elapsed}");

                System.GC.Collect();
                Java.Lang.System.Gc();

                System.Runtime.InteropServices.GCHandle handle = System.Runtime.InteropServices.GCHandle.Alloc(bytes, System.Runtime.InteropServices.GCHandleType.Pinned);

                Stopwatch watcher4 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    var res = jClass.Invoke<ByteBuffer>("getByteBuffer");
                    res.ToDirectBuffer().CopyTo(handle.AddrOfPinnedObject(), bytes.Length, 0, bytes.Length);
                    if (bytes.Length != length) { throw new System.Exception(); }
                }
                watcher4.Stop();

                Console.WriteLine($"End getByteBuffer -> ByteBuffer -> ToDirectBuffer -> CopyTo Elapsed {watcher4.Elapsed}");

                System.GC.Collect();
                Java.Lang.System.Gc();

                Stopwatch watcher5 = Stopwatch.StartNew();
                for (i = 0; i < requestedIterations; i++)
                {
                    var res = jClass.Invoke<ByteBuffer>("getByteBuffer");
                    if (res.Remaining() != length) { throw new System.Exception(); }
                }
                watcher5.Stop();

                Console.WriteLine($"End getByteBuffer -> ByteBuffer -> Remaining Elapsed {watcher5.Elapsed}");

                Console.WriteLine($"{length,Padding} Mean Time over {requestedIterations} iterations - Array {TimeSpan.FromTicks(watcher1.Elapsed.Ticks / requestedIterations)} - ByteBuffer {TimeSpan.FromTicks(watcher2.Elapsed.Ticks / requestedIterations)} ({((double)watcher1.Elapsed.Ticks / watcher2.Elapsed.Ticks) * 100:0.##}%) - ByteBufferNoNew {TimeSpan.FromTicks(watcher3.Elapsed.Ticks / requestedIterations)} ({((double)watcher1.Elapsed.Ticks / watcher3.Elapsed.Ticks) * 100:0.##}%) - ByteBufferNoAlloc {TimeSpan.FromTicks(watcher4.Elapsed.Ticks / requestedIterations)} ({((double)watcher1.Elapsed.Ticks / watcher4.Elapsed.Ticks) * 100:0.##}%) - ByteBufferNoGet {TimeSpan.FromTicks(watcher5.Elapsed.Ticks / requestedIterations)} ({((double)watcher1.Elapsed.Ticks / watcher5.Elapsed.Ticks) * 100:0.##}%)");
            }
            catch
            {
                Console.WriteLine($"Failed at iteration: {i}");
                throw;
            }
        }
    }
}
