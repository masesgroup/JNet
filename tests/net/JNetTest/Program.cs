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

using Java.Util;
using MASES.JNetTest.Common;
using MASES.JNet.Specific.Extensions;
using System.Diagnostics;
using Java.Lang;
using MASES.JCOBridge.C2JBridge;
using System.Threading.Tasks;
using System.Linq;
using Java.Nio;
using MASES.JNet.Specific;

namespace MASES.JNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Starting JNetTest");

            Initialize();

            TestExtensions();

            TestMemoryStream();

            TestByteBuffers();

            TestEquality();

            TestSingleton();

            TestSimpleOperatorsExtension<Java.Lang.String, string>("a", "b", "c");

            TestArrays();

            TestOperators();

            TestIterator();

            TestAsyncIterator().Wait();
        }

        static void Initialize()
        {
            try
            {
                JNetTestCore.ApplicationHeapSize = "4G";
                JNetTestCore.ApplicationInitialHeapSize = "1G";
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
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
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

            ByteBuffer bb = (ByteBuffer) ms;
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
                    System.Console.WriteLine($"Failed to parse: {item}");
                }
            }
        }

        static void TestIterator()
        {
            System.Console.WriteLine("TestIterator");

            const int execution = 100;
            Stopwatch w = Stopwatch.StartNew();
            ArrayList<Java.Lang.String> alist = new();
            for (int i = 0; i < execution; i++)
            {
                alist.Add(i.ToString());
            }
            w.Stop();

            foreach (var item in (alist).WithPrefetch())
            {
                if (!int.TryParse(item, out int i))
                {
                    System.Console.WriteLine($"Failed to parse: {item}");
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

            for (int index = 0; index < 5; index++)
            {
                Stopwatch w = Stopwatch.StartNew();
                Java.Util.ArrayList<int> alist = new Java.Util.ArrayList<int>();
                for (int i = 0; i < execution; i++)
                {
                    alist.Add(i);
                }
                w.Stop();
                System.Console.WriteLine($"ArrayList Elapsed ticks: {w.ElapsedTicks}");

                w.Restart();
                System.Collections.Generic.List<int> nlist = new System.Collections.Generic.List<int>();
                for (int i = 0; i < execution; i++)
                {
                    nlist.Add(i);
                }
                w.Stop();
                System.Console.WriteLine($"System.Collections.Generic.List Elapsed ticks: {w.ElapsedTicks}");

                var tmpArray = nlist.ToArray();

                w.Restart();
                var tmpJList = JNetHelper.ListFrom(tmpArray);
                alist = new Java.Util.ArrayList<int>(tmpJList);
                w.Stop();
                System.Console.WriteLine($"Java.Util.ArrayList from array Elapsed ticks: {w.ElapsedTicks}");

                var intBuffer = IntBuffer.From(tmpArray, false, false);

                w.Restart();
                tmpJList = JNetHelper.ListFrom(intBuffer);
                alist = new Java.Util.ArrayList<int>(tmpJList);
                w.Stop();
                System.Console.WriteLine($"Java.Util.ArrayList from array premade buffer Elapsed ticks: {w.ElapsedTicks}");

                w.Restart();
                tmpJList = JNetHelper.ListFrom(tmpArray, true);
                alist = new Java.Util.ArrayList<int>(tmpJList);
                w.Stop();
                System.Console.WriteLine($"Java.Util.ArrayList from array buffered Elapsed ticks: {w.ElapsedTicks}");
                //var collection = newDict.Values.ToJCollection();
                //var intermediate = collection.ToList<Map.Entry<string, string>>();
                var list = ((List<int>)alist).ToList();
            }
        }
    }
}
