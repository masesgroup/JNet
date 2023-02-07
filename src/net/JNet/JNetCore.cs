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

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Io.IOException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Util.Concurrent.ExecutionException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Sql.SQLException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Naming.NamingException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.AttributeNotFoundException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.BadAttributeValueExpException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.BadBinaryOpValueExpException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.BadStringOperationException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.InstanceAlreadyExistsException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.InstanceNotFoundException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.IntrospectionException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.InvalidApplicationException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.InvalidAttributeValueException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.JMException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.JMRuntimeException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.ListenerNotFoundException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.MalformedObjectNameException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.MBeanException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.MBeanRegistrationException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.NotCompliantMBeanException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.OperationsException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.ReflectionException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.RuntimeErrorException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.RuntimeMBeanException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.RuntimeOperationsException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.ServiceNotFoundException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.Remote.JMXProviderException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Management.Remote.JMXServerErrorException>();
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
                var assembly = typeof(JNetCore<>).Assembly;
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
}