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

using MASES.JNet;
using System;
using System.Collections.Generic;

namespace MASES.JNetTest.Common
{
    class JNetTestCore : JNetCore<JNetTestCore>
    {
#if DEBUG
        public override bool EnableDebug => true;
#endif
        protected override IList<string> PathToParse
        {
            get
            {
                var lst = base.PathToParse;
                var assembly = typeof(JNetTestCore).Assembly;
                var path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(assembly.Location), JARsSubFolder, $"jnettest-1.0.0.0.jar");
                if (!System.IO.File.Exists(path)) throw new System.IO.FileNotFoundException("JAR file for test not available, run Maven first", path);
                lst.Add(path);
                return lst;
            }
        }
    }

    static class TestLogger
    {
        static bool _enabledAdanced = false;

        static TestLogger()
        {
            var logging = Environment.GetEnvironmentVariable("ENABLE_ADVANCED_TEST_LOGGING");
            if (logging != null)
            {
                if (!bool.TryParse(logging, out _enabledAdanced))
                {
                    Console.WriteLine($"ENABLE_ADVANCED_TEST_LOGGING exist, however its value (\"{logging}\") cannot be parsed as boolean.");
                    _enabledAdanced = false;
                }
            }
#if DEBUG
            _enabledAdanced = true;
#endif
        }

        public static void LogBasic(Exception ex)
        {
            Console.WriteLine(ex);
        }

        public static void LogBasic(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }

        public static void LogAdvanced(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}