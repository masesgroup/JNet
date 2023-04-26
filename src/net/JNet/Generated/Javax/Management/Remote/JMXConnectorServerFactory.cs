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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Remote
{
    #region JMXConnectorServerFactory
    public partial class JMXConnectorServerFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerFactory.html#DEFAULT_CLASS_LOADER"/>
        /// </summary>
        public static string DEFAULT_CLASS_LOADER => LocalClazz.GetField<string>("DEFAULT_CLASS_LOADER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerFactory.html#DEFAULT_CLASS_LOADER_NAME"/>
        /// </summary>
        public static string DEFAULT_CLASS_LOADER_NAME => LocalClazz.GetField<string>("DEFAULT_CLASS_LOADER_NAME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerFactory.html#PROTOCOL_PROVIDER_CLASS_LOADER"/>
        /// </summary>
        public static string PROTOCOL_PROVIDER_CLASS_LOADER => LocalClazz.GetField<string>("PROTOCOL_PROVIDER_CLASS_LOADER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerFactory.html#PROTOCOL_PROVIDER_PACKAGES"/>
        /// </summary>
        public static string PROTOCOL_PROVIDER_PACKAGES => LocalClazz.GetField<string>("PROTOCOL_PROVIDER_PACKAGES");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerFactory.html#newJMXConnectorServer(javax.management.remote.JMXServiceURL,java.util.Map,javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanServer"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnectorServer"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Management.Remote.JMXConnectorServer NewJMXConnectorServer<Arg1Extendsobject>(Javax.Management.Remote.JMXServiceURL arg0, Java.Util.Map<string, Arg1Extendsobject> arg1, Javax.Management.MBeanServer arg2)
        {
            return SExecute<Javax.Management.Remote.JMXConnectorServer>(LocalClazz, "newJMXConnectorServer", arg0, arg1, arg2);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}