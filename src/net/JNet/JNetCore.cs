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

using MASES.JCOBridge.C2JBridge;
using System.Collections.Generic;

namespace MASES.JNet
{
    /// <summary>
    /// Public entry point of <see cref="JNetCore{T}"/>
    /// </summary>
    public abstract class JNetCore<T> : JNetCoreBase<T> where T : JNetCore<T>
    {
        #region Initialization
        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetCore()
        {
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ThreadDeath>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Util.Concurrent.ExecutionException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Sql.SQLException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Naming.NamingException>();
        }

        /// <summary>
        /// Default performance options used in initialization
        /// </summary>
        protected virtual IList<string> PerformanceOptions => new List<string>();
        /// <summary>
        /// Adds options to the JVM
        /// </summary>
        protected override IDictionary<string, string> Options
        {
            get
            {
                IDictionary<string, string> opt = new Dictionary<string, string>();
                if (PerformanceOptions != null)
                {
                    foreach (var item in PerformanceOptions)
                    {
                        opt.Add(item, null);
                    }
                }
                return opt;
            }
        }

        /// <summary>
        /// A list of paths to be used in initialization of JVM ClassPath
        /// </summary>
        protected override IList<string> PathToParse
        {
            get
            {
                var assembly = typeof(JNetCore).Assembly;
                var version = assembly.GetName().Version.ToString();
                // 1. check first full version
                var jnetFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(assembly.Location), JARsSubFolder, $"jnet-{version}.jar");
                if (!System.IO.File.Exists(jnetFile) && version.EndsWith(".0"))
                {
                    // 2. if not exist remove last part of version
                    version = version.Substring(0, version.LastIndexOf(".0"));
                    jnetFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(assembly.Location), JARsSubFolder, $"jnet-{version}.jar");
                }
                var lst = base.PathToParse;
                lst.Add(jnetFile);
                return lst;
            }
        }
        #endregion
    }
    /// <summary>
    /// Concrete implementation of <see cref="JNetCore{T}"/>
    /// </summary>
    public class JNetCore : JNetCore<JNetCore>
    {
    }
}