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

using Java.Util;
using MASES.JNetTest.Common;
using MASES.JNet.Extensions;

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

            if (args.Length != 0)
            {
                try
                {
                    var set = Collections.Singleton(appArgs[0]);
                    set.Add("test");
                }
                catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
            }

            TestExtensions();
        }

        static void TestExtensions()
        {
            System.Collections.Generic.Dictionary<string, string> dict = new();
            dict.Add("a", "a");
            dict.Add("b", "b");
            dict.Add("c", "c");
            var map = dict.ToMap();
            var newDict = map.ToDictiony();

            var collection = newDict.Values.ToJCollection();
            var list = collection.ToList();
        }
    }
}
