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

        static void Initialize()
        {
            try
            {
                JNetTestCore.ApplicationWriteEventOrExceptionOnCmdLine = true;
                JNetTestCore.ApplicationHeapSize = "4G";
                JNetTestCore.ApplicationInitialHeapSize = "256M";
                JNetTestCore.CreateGlobalInstance();
                var appArgs = JNetTestCore.FilteredArgs;

                System.Console.WriteLine($"Initialized JNetTestCore, remaining arguments are {string.Join(" ", appArgs)}");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                throw;
            }
        }

        static void TestInsertByteBuffers(int iteration, int length)
        {
            Console.WriteLine($"TestInsertByteBuffers with {iteration} iterations and {length} length");
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
                for (i = 0; i < iteration; i++)
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

                System.GC.Collect();
                Java.Lang.System.Gc();

                Console.WriteLine($"End insertArray");

                Stopwatch watcher2 = Stopwatch.StartNew();
                for (i = 0; i < iteration; i++)
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

                System.GC.Collect();
                Java.Lang.System.Gc();

                Console.WriteLine($"End insertByteBuffer");

                Stopwatch watcher3 = Stopwatch.StartNew();
                for (i = 0; i < iteration; i++)
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

                System.GC.Collect();
                Java.Lang.System.Gc();

                Console.WriteLine($"End insertByteBufferNoNew");

                Stopwatch watcher4 = Stopwatch.StartNew();
                for (i = 0; i < iteration; i++)
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

                Console.WriteLine($"End insertByteBufferNoGet");

                Console.WriteLine($"{length,Padding} - Array {TimeSpan.FromTicks(watcher1.ElapsedTicks / iteration)} - ByteBuffer {TimeSpan.FromTicks(watcher2.ElapsedTicks / iteration)} ({((double)watcher1.ElapsedTicks / watcher2.ElapsedTicks) * 100:0.##}%) - ByteBufferNoNew {TimeSpan.FromTicks(watcher3.ElapsedTicks / iteration)} ({((double)watcher1.ElapsedTicks / watcher3.ElapsedTicks) * 100:0.##}%) - ByteBufferNoGet {TimeSpan.FromTicks(watcher4.ElapsedTicks / iteration)} ({((double)watcher1.ElapsedTicks / watcher4.ElapsedTicks) * 100:0.##}%)");
            }
            catch
            {
                Console.WriteLine($"Failed at iteration: {i}");
                throw;
            }
        }

        static void TestGetByteBuffers(int iteration, int length)
        {
            Console.WriteLine($"TestGetByteBuffers with {iteration} iterations and {length} length");
            int i = 0;
            try
            {
                byte[] bytes = new byte[length];
                var jClass = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestArrayAndByteBuffer", length) as IJavaObject;

                System.GC.Collect();
                Java.Lang.System.Gc();

                Console.WriteLine($"Created TestArrayAndByteBuffer");

                Stopwatch watcher1 = Stopwatch.StartNew();
                for (i = 0; i < iteration; i++)
                {
                    var res = jClass.Invoke<byte[]>("getArray");
                    if (res.Length != length) { throw new System.Exception(); }
                }
                watcher1.Stop();

                System.GC.Collect();
                Java.Lang.System.Gc();

                Stopwatch watcher2 = Stopwatch.StartNew();
                for (i = 0; i < iteration; i++)
                {
                    var res = jClass.Invoke<ByteBuffer>("getByteBuffer");
                    var array = res.ToArray();
                    if (array.Length != length) { throw new System.Exception(); }
                }
                watcher2.Stop();

                System.GC.Collect();
                Java.Lang.System.Gc();

                Stopwatch watcher3 = Stopwatch.StartNew();
                for (i = 0; i < iteration; i++)
                {
                    var res = jClass.Invoke<ByteBuffer>("getByteBuffer");
                    res.ToArray(ref bytes, false);
                    if (bytes.Length != length) { throw new System.Exception(); }
                }
                watcher3.Stop();

                System.GC.Collect();
                Java.Lang.System.Gc();

                System.Runtime.InteropServices.GCHandle handle = System.Runtime.InteropServices.GCHandle.Alloc(bytes, System.Runtime.InteropServices.GCHandleType.Pinned);

                Stopwatch watcher4 = Stopwatch.StartNew();
                for (i = 0; i < iteration; i++)
                {
                    var res = jClass.Invoke<ByteBuffer>("getByteBuffer");
                    res.ToDirectBuffer().CopyTo(handle.AddrOfPinnedObject(), bytes.Length, 0, bytes.Length);
                    if (bytes.Length != length) { throw new System.Exception(); }
                }
                watcher4.Stop();

                System.GC.Collect();
                Java.Lang.System.Gc();

                Stopwatch watcher5 = Stopwatch.StartNew();
                for (i = 0; i < iteration; i++)
                {
                    var res = jClass.Invoke<ByteBuffer>("getByteBuffer");
                    if (res.Remaining() != length) { throw new System.Exception(); }
                }
                watcher5.Stop();

                Console.WriteLine($"{length,Padding} - Array {TimeSpan.FromTicks(watcher1.ElapsedTicks / iteration)} - ByteBuffer {TimeSpan.FromTicks(watcher2.ElapsedTicks / iteration)} ({((double)watcher1.ElapsedTicks / watcher2.ElapsedTicks) * 100:0.##}%) - ByteBufferNoNew {TimeSpan.FromTicks(watcher3.ElapsedTicks / iteration)} ({((double)watcher1.ElapsedTicks / watcher3.ElapsedTicks) * 100:0.##}%) - ByteBufferNoAlloc {TimeSpan.FromTicks(watcher4.ElapsedTicks / iteration)} ({((double)watcher1.ElapsedTicks / watcher4.ElapsedTicks) * 100:0.##}%) - ByteBufferNoGet {TimeSpan.FromTicks(watcher5.ElapsedTicks / iteration)} ({((double)watcher1.ElapsedTicks / watcher5.ElapsedTicks) * 100:0.##}%)");
            }
            catch
            {
                Console.WriteLine($"Failed at iteration: {i}");
                throw;
            }
        }
    }
}
