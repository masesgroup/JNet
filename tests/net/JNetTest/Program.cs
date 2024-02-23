/*
*  Copyright 2024 MASES s.r.l.
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

namespace MASES.JNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            JNetTestCore.CreateGlobalInstance();
            var appArgs = JNetTestCore.FilteredArgs;

            var setEmpty = Collections.EmptySet<int>();

            var cls = Java.Lang.Class.Of<Vector<string>>();
            var cls2 = JNetTestCore.Class<Vector<string>>();

            var res = cls.Equals(cls2);
            System.Console.WriteLine($"Class are equals: {res}");

            try
            {
                var set = Collections.Singleton("test");
                if (appArgs.Length != 0) set.Add(appArgs[0]);
            }
            catch (UnsupportedOperationException)
            {
                System.Console.WriteLine("Add Operation not supported as expected");
            }
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }

            TestSimpleOperatorsExtension<Java.Lang.String, string>("a", "b", "c");
            TestOperators();

            TestIterator();
            TestAsyncIterator().Wait();

            TestExtensions();
        }

        static void TestOperators()
        {
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

        static void TestSimpleOperatorsExtension<TJVM, TNet>(params TNet[] dataInput)
            where TJVM : INativeConvertible<TJVM, TNet>, new()
        {
            var jvmArray = dataInput.ToJVMArray<TJVM, TNet>();

            var jvmIterable = dataInput.ToJVMCollectionType<ArrayList<TJVM>, TJVM, TNet>();

            var netList = jvmArray.ToNetCollectionType<System.Collections.Generic.List<TNet>, TNet, TJVM>();

            TNet[] arrayNet = jvmArray.ToNetArray<TNet, TJVM>();

            if (!dataInput.SequenceEqual(arrayNet)) throw new System.InvalidOperationException();
        }

        static async Task TestAsyncIterator()
        {
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
            const int execution = 100;
            Stopwatch w = Stopwatch.StartNew();
            ArrayList<string> alist = new Java.Util.ArrayList<string>();
            for (int i = 0; i < execution; i++)
            {
                alist.Add(i.ToString());
            }
            w.Stop();

            foreach (var item in ((List<string>)alist).WithPrefetch())
            {
                if (!int.TryParse(item, out int i))
                {
                    System.Console.WriteLine($"Failed to parse: {item}");
                }
            }
        }

        static void TestExtensions()
        {
            System.Collections.Generic.Dictionary<string, bool> dict = new();
            dict.Add("true", true);
            dict.Add("false", false);
            dict.Add("true2", true);
            var map = dict.ToMap();
            var newDict = map.ToDictiony();

            const int execution = 10000;
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

            //var collection = newDict.Values.ToJCollection();
            //var intermediate = collection.ToList<Map.Entry<string, string>>();
            var list = ((List<int>)alist).ToList();
        }
    }
}
