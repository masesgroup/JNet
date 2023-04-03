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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Loading
{
    #region MLet
    public partial class MLet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public MLet(Java.Net.URL[] arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public MLet(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader,java.net.URLStreamHandlerFactory,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg2"><see cref="Java.Net.URLStreamHandlerFactory"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public MLet(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1, Java.Net.URLStreamHandlerFactory arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader,java.net.URLStreamHandlerFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg2"><see cref="Java.Net.URLStreamHandlerFactory"/></param>
        public MLet(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1, Java.Net.URLStreamHandlerFactory arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        public MLet(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        public MLet(Java.Net.URL[] arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Loading.MLet"/> to <see cref="Javax.Management.Loading.MLetMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Loading.MLetMBean(Javax.Management.Loading.MLet t) => t.Cast<Javax.Management.Loading.MLetMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Loading.MLet"/> to <see cref="Javax.Management.MBeanRegistration"/>
        /// </summary>
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.Loading.MLet t) => t.Cast<Javax.Management.MBeanRegistration>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Loading.MLet"/> to <see cref="Java.Io.Externalizable"/>
        /// </summary>
        public static implicit operator Java.Io.Externalizable(Javax.Management.Loading.MLet t) => t.Cast<Java.Io.Externalizable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#getLibraryDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#setLibraryDirectory(java.lang.String)"/>
        /// </summary>
        public string LibraryDirectory
        {
            get { return IExecute<string>("getLibraryDirectory"); } set { IExecute("setLibraryDirectory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#getMBeansFromURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public Java.Util.Set<object> GetMBeansFromURL(string arg0)
        {
            return IExecute<Java.Util.Set<object>>("getMBeansFromURL", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#getMBeansFromURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public Java.Util.Set<object> GetMBeansFromURL(Java.Net.URL arg0)
        {
            return IExecute<Java.Util.Set<object>>("getMBeansFromURL", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectName>("preRegister", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#loadClass(java.lang.String,javax.management.loading.ClassLoaderRepository)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Loading.ClassLoaderRepository"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public Java.Lang.Class LoadClass<ReturnExtendsobject>(string arg0, Javax.Management.Loading.ClassLoaderRepository arg1)
        {
            return IExecute<Java.Lang.Class>("loadClass", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#addURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public void AddURL(string arg0)
        {
            IExecute("addURL", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#addURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        public void AddURL(Java.Net.URL arg0)
        {
            IExecute("addURL", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#postDeregister()"/>
        /// </summary>
        public void PostDeregister()
        {
            IExecute("postDeregister");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void PostRegister(bool? arg0)
        {
            IExecute("postRegister", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#preDeregister()"/>
        /// </summary>
        
        /// <exception cref="Java.Lang.Exception"/>
        public void PreDeregister()
        {
            IExecute("preDeregister");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#readExternal(java.io.ObjectInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void ReadExternal(Java.Io.ObjectInput arg0)
        {
            IExecute("readExternal", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#writeExternal(java.io.ObjectOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectOutput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void WriteExternal(Java.Io.ObjectOutput arg0)
        {
            IExecute("writeExternal", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}