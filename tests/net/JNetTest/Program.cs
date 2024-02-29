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

namespace MASES.JNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            JNetTestCore.CreateGlobalInstance();
            var appArgs = JNetTestCore.FilteredArgs;

            var cls = Java.Lang.Class.Of<Vector<string>>();
            var cls2 = JNetTestCore.Class<Vector<string>>();

            var res = cls.Equals(cls2);
            System.Console.WriteLine($"Class are equals: {res}");

            try
            {
                var set = Collections.Singleton((Java.Lang.String)"test");
                if (appArgs.Length != 0) set.Add(appArgs[0]);
            }
            catch (UnsupportedOperationException)
            {
                System.Console.WriteLine("Add Operation not supported as expected");
            }
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }

            TestArrays();

            TestExtensions();

            TestOperators();

            TestIterator();

            TestAsyncIterator().Wait();
        }

        static void TestArrays()
        {
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
            System.Collections.Generic.Dictionary<Java.Lang.String, bool> dict = new();
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
