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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Remote.Rmi
{
    #region RMIServerImpl
    public partial class RMIServerImpl
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Remote.Rmi.RMIServerImpl"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Javax.Management.Remote.Rmi.RMIServerImpl t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Remote.Rmi.RMIServerImpl"/> to <see cref="Javax.Management.Remote.Rmi.RMIServer"/>
        /// </summary>
        public static implicit operator Javax.Management.Remote.Rmi.RMIServer(Javax.Management.Remote.Rmi.RMIServerImpl t) => t.Cast<Javax.Management.Remote.Rmi.RMIServer>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIServerImpl.html#getDefaultClassLoader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIServerImpl.html#setDefaultClassLoader(java.lang.ClassLoader)"/>
        /// </summary>
        public Java.Lang.ClassLoader DefaultClassLoader
        {
            get { return IExecute<Java.Lang.ClassLoader>("getDefaultClassLoader"); } set { IExecute("setDefaultClassLoader", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIServerImpl.html#getMBeanServer()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIServerImpl.html#setMBeanServer(javax.management.MBeanServer)"/>
        /// </summary>
        public Javax.Management.MBeanServer MBeanServer
        {
            get { return IExecute<Javax.Management.MBeanServer>("getMBeanServer"); } set { IExecute("setMBeanServer", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIServerImpl.html#getVersion()"/> 
        /// </summary>
        public string Version
        {
            get { return IExecute<string>("getVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIServerImpl.html#toStub()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Rmi.Remote ToStub()
        {
            return IExecute<Java.Rmi.Remote>("toStub");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIServerImpl.html#newClient(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Management.Remote.Rmi.RMIConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.Remote.Rmi.RMIConnection NewClient(object arg0)
        {
            return IExecute<Javax.Management.Remote.Rmi.RMIConnection>("newClient", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIServerImpl.html#close()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}