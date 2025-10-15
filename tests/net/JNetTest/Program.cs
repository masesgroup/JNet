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

using Java.Lang;
using Java.Lang.Annotation;
using Java.Nio;
using Java.Util;
using Java.Util.Concurrent;
using Java.Util.Function;
using MASES.JCOBridge.C2JBridge;
using MASES.JNet.Specific;
using MASES.JNet.Specific.Extensions;
using MASES.JNetTest.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MASES.JNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Starting JNetTest");

#if DEBUG
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.WriteLine("Press a button to start");
                System.Console.ReadKey();
            }
#endif

            Initialize();
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                TestCreateObjects();

                TestVarArg();

                TestEnum();

                for (int i = 0; i < 5; i++)
                {
                    TestListeners($"Listener {i}");
                }

                TestExtensions();

                TestMemoryStream();

                TestByteBuffers();

                TestEquality();

                TestSingleton();

                TestSimpleOperatorsExtension<Java.Lang.String, string>("a", "b", "c");

                TestArrays();

                TestOperators();

                TestIterator(false, false);

                TestIterator(true, true);

                TestIterator(true, false);

                TestAsyncIterator().Wait();
#if DEBUG
                const int asyncOperations = 100;
#else
                const int asyncOperations = 5;
#endif
                for (int i = 0; i < asyncOperations; i++)
                {
                    TestAsyncOperation(i, false).Wait();

                    try
                    {
                        TestAsyncOperation(i, true).Wait();
                    }
                    catch (System.AggregateException ae)
                    {
                        if (ae.InnerException is not UnsupportedOperationException)
                        {
                            System.Console.WriteLine($"Not expected exception: {ae.InnerException.GetType()}");
                            throw;
                        }
                        else
                        {
                            if (ae.InnerException.InnerException is not UnsupportedOperationException)
                            {
                                System.Console.WriteLine($"Not expected exception: {ae.InnerException.InnerException.GetType()}");
                                throw;
                            }
                            else
                            {
                                if (ae.InnerException.InnerException.InnerException is not UnsupportedOperationException)
                                {
                                    System.Console.WriteLine($"Not expected exception: {ae.InnerException.InnerException.InnerException.GetType()}");
                                    throw;
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                System.Environment.ExitCode = 1;
            }
            finally
            {
                stopwatch.Stop();
                System.Console.WriteLine($"All tests completed in {stopwatch.Elapsed}");
            }
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

        static void TestCreateObjects()
        {
            const string dataToUse = "Long string to be written";
            System.Console.WriteLine("TestCreateObjects");

            Java.Lang.String str = new String();
            str = str.Concat(dataToUse);

            if (str != dataToUse)
            {
                throw new System.InvalidOperationException($"Failed to compare with \"!=\": {str} with {dataToUse}");
            }

            str = new String(dataToUse);

            if (str != dataToUse)
            {
                throw new System.InvalidOperationException($"Failed to compare with \"!=\": {str} with {dataToUse}");
            }

            str = new String(dataToUse);

            if (str != dataToUse)
            {
                throw new System.InvalidOperationException($"Failed to compare with \"==\": {str} with {dataToUse}");
            }
        }

        static void TestVarArg()
        {
            System.Console.WriteLine("TestVarArg");
            const string formatToUSe = "This is the %d %s for a %s";
            for (int i = 0; i < 10; i++)
            {
                bool fallback = false;
                bool fallback2 = false;
                string str;
                var dataToUse = string.Format("This is the {0} {1} for a {2}", i, "test", "varArg");
                try
                {
                    str = String.Format(formatToUSe, i, "test", "varArg");
                }
                catch
                {
                    // https://github.com/masesgroup/JNet/issues/770#issuecomment-3405824484
                    fallback = true;
                    try
                    {
                        str = String.SExecuteWithSignature("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", formatToUSe, i, "test", "varArg").ToString();
                    }
                    catch
                    {
                        // https://github.com/masesgroup/JNet/issues/770#issuecomment-3406351861
                        fallback2 = true;
                        str = String.SExecute("format", formatToUSe, i, "test", "varArg").ToString();
                    }
                }

                if (str != dataToUse)
                {
                    throw new System.InvalidOperationException($"Failed to compare {str} with {dataToUse}: fallback is {fallback}, fallback2 is {fallback2}");
                }
                else if (fallback || fallback2)
                {
                    System.Console.WriteLine($"Test ended in right way with fallback ({fallback}) and fallback2 ({fallback2})");
                }
            }
        }

        static void TestEnum()
        {
            System.Console.WriteLine("TestEnum");

            ElementType type = ElementType.ANNOTATION_TYPE;

            if (type.Equals(ElementType.ANNOTATION_TYPE))
            {
                if (type != ElementType.ANNOTATION_TYPE)
                {
                    throw new System.InvalidOperationException($"Failed to compare with \"==\": {type} with {ElementType.ANNOTATION_TYPE}");
                }
            }
            else
            {
                throw new System.InvalidOperationException($"Failed to compare with Equals: {type} with {ElementType.ANNOTATION_TYPE}");
            }

            if (!type.Equals(ElementType.PARAMETER))
            {
                if (type == ElementType.PARAMETER)
                {
                    throw new System.InvalidOperationException($"Failed to compare with \"==\": {type} with {ElementType.PARAMETER}");
                }
            }
            else
            {
                throw new System.InvalidOperationException($"Failed to compare with Equals: {type} with {ElementType.PARAMETER}");
            }
        }

        class TestListener : JVMBridgeBase<TestListener>
        {
            public override string BridgeClassName => "org.mases.jnet.TestListener";

            public TestListener() { }

            public TestListener(params object[] args) : base(args) { }

            public Java.Lang.String Apply(Java.Lang.String str)
            {
                return IExecute<Java.Lang.String>("apply", str);
            }
        }

        static void TestListeners(string expectedResult)
        {
            System.Console.WriteLine($"TestListeners of {expectedResult}");

            using var consumer = new Consumer<Java.Lang.String>()
            {
                OnAccept = (o) =>
                {
                    System.Console.WriteLine($"Consumer Accept {o}");
                }
            };

            using var func = new Function<Java.Lang.String, Java.Lang.String>()
            {
                OnApply = (o) =>
                {
                    return o;
                }
            };
            TestListener testListener = new TestListener(consumer, func);
            Java.Lang.String result = testListener.Apply(expectedResult);
            if (result != expectedResult)
            {
                throw new System.InvalidOperationException($"Failed to compare: {result}");
            }
        }

        static void TestSingleton()
        {
            System.Console.WriteLine("TestSingleton");

            try
            {
                var set = Collections.Singleton((Java.Lang.String)"test");
                set.Add("testData");
            }
            catch (UnsupportedOperationException)
            {
                System.Console.WriteLine("Add Operation not supported as expected");
            }
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); throw; }
        }

        static void TestEquality()
        {
            System.Console.WriteLine("TestEquality");

            var cls = Java.Lang.Class.Of<Vector<string>>();
            var cls2 = JNetHelper.Class<Vector<string>>();

            var res = cls.Equals(cls2);
            System.Console.WriteLine($"Class are equals: {res}");
        }

        static void TestMemoryStream()
        {
            System.Console.WriteLine("TestMemoryStream");

            System.IO.MemoryStream ms = new();
            for (int i = 0; i < 100000; i++)
            {
                ms.WriteByte((byte)(i % byte.MaxValue));
            }

            ByteBuffer bb = (ByteBuffer)ms;
            bb.IsDirect();
        }

        static void TestByteBuffers()
        {
            System.Console.WriteLine("TestByteBuffers");

            byte[] bytes = new byte[100000];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)(i % byte.MaxValue);
            }

            var bbCast = (Java.Nio.ByteBuffer)bytes;

            /*
            var jClass = JNetTestCore.GlobalInstance.JVM.GetClass("org.mases.jcobridge.JCOBridgeSharedBuffer");
            var jj = jClass.Invoke<IJavaObject>("Create", bytes);
            var backObj = jj.Invoke<long>("getBackingIndex");
            */
            byte[] newArray;
            //JVMBridgeSharedBuffer.TryGetValue(backObj, out newArray);

            var direct = JNetTestCore.GlobalInstance.JVM.NewDirectBuffer(bytes);

            var getSharedBuffer = JNetTestCore.GlobalInstance.JVM.GetDirectBuffer<byte>(direct.JavaObject);
            var getSharedBufferInt = JNetTestCore.GlobalInstance.JVM.GetDirectBuffer<int>(direct.JavaObject);

            direct[10] = 4;

            if (direct[10] != getSharedBuffer[10]) throw new System.InvalidOperationException();

            var bb = Java.Nio.ByteBuffer.Wrap(bytes);
            var hasArray = bb.HasArray();
            var isDirect = bb.IsDirect();
            var obj = bb.Array();

            var bb2 = Java.Nio.ByteBuffer.AllocateDirect(bytes.Length);
            bb2.Put(bytes, 0, bytes.Length);

            var intBuffer = bb2.AsIntBuffer();
            var newCapacity = intBuffer.Capacity();

            var newBuffer = JNetTestCore.GlobalInstance.JVM.GetDirectBuffer<byte>(bb2.BridgeInstance);

            bb2.IsDirect();
            bb2.Rewind();
            bb2.Get();

            var bb3 = Java.Nio.ByteBuffer.AllocateDirect(bytes.Length);
            bb3.Put(bytes, 0, bytes.Length);

            JCOBridgeDirectBuffer<byte> db = (JCOBridgeDirectBuffer<byte>)bb3;
            bb3.Rewind();
            JCOBridgeDirectBuffer<int> db2 = (JCOBridgeDirectBuffer<int>)bb3.AsIntBuffer();

            newBuffer = JNetTestCore.GlobalInstance.JVM.GetDirectBuffer<byte>(bb3.BridgeInstance);
        }

        static void TestArrays()
        {
            System.Console.WriteLine("TestArrays");

            ArrayList<int[]> arr = new();
            arr.Add(new int[] { 0, 1 });

            ArrayList<int> arr1 = new();
            arr1.Add(1);

            ArrayList<string> arr2 = new();
            arr2.Add("a");

            ArrayList<Java.Lang.String> arr3 = new();
            arr3.Add("a");
            arr3.Add("b");

            Java.Lang.String[] arrRes = new String[1] { new String() };
            arrRes = arr3.ToArray(arrRes);

            var setEmpty = Collections.EmptySet<int>();
        }

        static void TestOperators()
        {
            System.Console.WriteLine("TestOperators");

            Java.Lang.Short a = 10;
            Java.Lang.Short b = 100;

            Java.Lang.Short c = (short)(a + b);
            Java.Lang.Short d = (short)(c / a);

            if (a < d) { a++; d = (short)(c / a); }

            Java.Lang.String strA = new String("StringA");
            Java.Lang.String strB = new String("StringB");

            if (strA != strB)
            {
                strA += strB;
            }
            strA += " Extra";
            strA += null;

            var cc = strA[4];

            string astr = "";
            string bstr = "";

            var ccc = astr + bstr;
        }

        static void TestSimpleOperatorsExtension()
        {
            System.Console.WriteLine("TestSimpleOperatorsExtension");

            TestSimpleOperatorsExtension<Java.Lang.String, string>("a", "b", "c");
        }

        static void TestSimpleOperatorsExtension<TJVM, TNet>(params TNet[] dataInput)
            where TJVM : INativeConvertible<TJVM, TNet>, new()
        {
            var jvmArray = dataInput.ToJVMArray<TJVM, TNet>();

            var jvmIterable = dataInput.ToJVMCollectionType<ArrayList<TJVM>, TJVM, TNet>();

            var netList = jvmArray.ToNetCollectionType<System.Collections.Generic.List<TNet>, TNet, TJVM>();

            TNet[] arrayNet = jvmIterable.ToNetArray<TNet, TJVM>();

            if (!dataInput.SequenceEqual(arrayNet)) throw new System.InvalidOperationException();
        }

        static async Task TestAsyncIterator()
        {
            System.Console.WriteLine("TestAsyncIterator");

            const int execution = 100;
            Stopwatch w = Stopwatch.StartNew();
            ArrayList<string> alist = new();
            for (int i = 0; i < execution; i++)
            {
                alist.Add(i.ToString());
            }
            w.Stop();

            await foreach (var item in ((List<string>)alist).WithPrefetch())
            {
                if (!int.TryParse(item, out int i))
                {
                    throw new System.InvalidOperationException($"Failed to parse: {item}");
                }
            }
        }

        class TestFuture : JVMBridgeBase<TestFuture>
        {
            /// <inheritdoc/>
            public TestFuture() { }

            public override string BridgeClassName => "org.mases.jnet.TestFuture";

            public CompletableFuture<String> WithException()
            {
                return IExecute<CompletableFuture<String>>("withException");
            }

            public CompletableFuture<String> WithComplete()
            {
                return IExecute<CompletableFuture<String>>("withComplete");
            }

            public CompletableFuture<String> Shutdown()
            {
                return IExecute<CompletableFuture<String>>("shutdown");
            }
        }

        static async Task TestAsyncOperation(int index, bool withEx)
        {
            System.Console.WriteLine($"TestAsyncOperation {index} withEx {withEx}");

            var clazz = JVMBridgeBase.ClazzOf<TestFuture>();

            TestFuture testFuture = new TestFuture();
            try
            {
                CompletableFuture<String> completableFuture = withEx ? testFuture.WithException() : testFuture.WithComplete();

                String result = await completableFuture.GetAsync();
                if (result != "Hello")
                {
                    throw new System.InvalidOperationException($"Failed to compare: {result}");
                }
            }
            finally { testFuture.Shutdown(); }
        }

        static void TestIterator(bool usePrefetch, bool useThread)
        {
            System.Console.WriteLine($"TestIterator with useThread {useThread} - usePrefetch {usePrefetch}");

            const int execution = 100;
            Stopwatch w = Stopwatch.StartNew();
            ArrayList<Java.Lang.String> alist = new();
            for (int i = 0; i < execution; i++)
            {
                alist.Add(i.ToString());
            }
            w.Stop();

            for (int iteration = 0; iteration < 10; iteration++)
            {
                foreach (var item in (alist).WithPrefetch(usePrefetch).WithThread(useThread))
                {
                    if (!int.TryParse(item, out int i))
                    {
                        throw new System.InvalidOperationException($"Failed to parse: {item}");
                    }
                }
            }
        }

        static void TestExtensions()
        {
            System.Console.WriteLine("TestExtensions");

            System.Collections.Generic.Dictionary<string, bool> dict = new();
            dict.Add("true", true);
            dict.Add("false", false);
            dict.Add("true2", true);
            var map = dict.ToJVMMap<HashMap<Java.Lang.String, Java.Lang.Boolean>, Java.Lang.String, Java.Lang.Boolean, string, bool>();
            var newDict = map.ToNetDictiony<string, bool, Java.Lang.String, Java.Lang.Boolean>();

            const int execution = 10000;
            const int numRepetition = 10;
            System.Collections.Generic.List<System.Collections.Generic.List<long>> executionData = new System.Collections.Generic.List<System.Collections.Generic.List<long>>();

            for (int index = 0; index < numRepetition; index++)
            {
                System.Collections.Generic.List<long> singleExecutionData = new System.Collections.Generic.List<long>();
                Stopwatch w = Stopwatch.StartNew();
                Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>();
                for (int i = 0; i < execution; i++)
                {
                    alist.Add(i);
                }
                w.Stop();
                singleExecutionData.Add(w.Elapsed.Ticks);
                System.Console.WriteLine($"ArrayList Elapsed ticks: {w.Elapsed.Ticks}");

                w.Restart();
                System.Collections.Generic.List<int> nlist = new System.Collections.Generic.List<int>();
                for (int i = 0; i < execution; i++)
                {
                    nlist.Add(i);
                }
                w.Stop();
                singleExecutionData.Add(w.Elapsed.Ticks);
                var referenceValue = w.Elapsed.Ticks;
                System.Console.WriteLine($"System.Collections.Generic.List Elapsed {w.Elapsed} - ticks: {referenceValue}");

                var tmpArray = nlist.ToArray();

                w.Restart();
                var tmpJList = JNetHelper.ListFrom(tmpArray);
                alist = new Java.Util.ArrayList<int>(tmpJList);
                w.Stop();
                singleExecutionData.Add(w.Elapsed.Ticks);
                System.Console.WriteLine($"Java.Util.ArrayList from array Elapsed {w.Elapsed} - ticks: {w.Elapsed.Ticks} ({100 * w.Elapsed.Ticks / referenceValue}%)");

                var intBuffer = IntBuffer.From(tmpArray, false, false);

                w.Restart();
                tmpJList = JNetHelper.ListFrom(intBuffer);
                alist = new Java.Util.ArrayList<int>(tmpJList);
                w.Stop();
                singleExecutionData.Add(w.Elapsed.Ticks);
                System.Console.WriteLine($"Java.Util.ArrayList from array premade buffer Elapsed {w.Elapsed} - ticks: {w.Elapsed.Ticks} ({100 * w.Elapsed.Ticks / referenceValue}%)");

                w.Restart();
                tmpJList = JNetHelper.ListFrom(tmpArray, true);
                alist = new Java.Util.ArrayList<int>(tmpJList);
                w.Stop();
                singleExecutionData.Add(w.Elapsed.Ticks);
                System.Console.WriteLine($"Java.Util.ArrayList from array buffered Elapsed {w.Elapsed} - ticks: {w.Elapsed.Ticks} ({100 * w.Elapsed.Ticks / referenceValue}%)");
                //var collection = newDict.Values.ToJCollection();
                //var intermediate = collection.ToList<Map.Entry<string, string>>();
                var list = ((List<int>)alist).ToList();

                executionData.Add(singleExecutionData);
            }

            int numOfTests = executionData[0].Count;

            for (int i = 0; i < numOfTests; i++)
            {
                long total = 0;
                for (int index = 1; index < numRepetition; index++)
                {
                    total += executionData[index][i];
                }
                System.Console.WriteLine($"Test {i} Mean {System.TimeSpan.FromTicks(total / (numRepetition - 1))}");
            }
        }
    }
}
