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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Server
{
    #region RMIClassLoaderSpi
    public partial class RMIClassLoaderSpi
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoaderSpi.html#loadClass(java.lang.String,java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public Java.Lang.Class LoadClass(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.ClassLoader arg2)
        {
            return IExecute<Java.Lang.Class>("loadClass", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoaderSpi.html#loadProxyClass(java.lang.String,java.lang.String[],java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public Java.Lang.Class LoadProxyClass(Java.Lang.String arg0, Java.Lang.String[] arg1, Java.Lang.ClassLoader arg2)
        {
            return IExecute<Java.Lang.Class>("loadProxyClass", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoaderSpi.html#getClassLoader(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.ClassLoader"/></returns>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public Java.Lang.ClassLoader GetClassLoader(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.ClassLoader>("getClassLoader", "(Ljava/lang/String;)Ljava/lang/ClassLoader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoaderSpi.html#getClassAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetClassAnnotation(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getClassAnnotation", "(Ljava/lang/Class;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}