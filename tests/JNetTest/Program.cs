/*
*  Copyright 2022 MASES s.r.l.
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
using MASES.JNet;
using System;

namespace MASES.JNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            JNetCore.CreateGlobalInstance();
            var appArgs = JNetCore.FilteredArgs;

            var cls = Java.Lang.Class.Of<Vector<string>>();
            var cls2 = JNetCore.Class<Vector<string>>();

            var res = cls.Equals(cls2);

            if (args.Length != 0)
            {
                var set = Collections.Singleton(appArgs[0]);
                Console.WriteLine(set.ToString());
            }
        }
    }
}
