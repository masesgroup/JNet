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

namespace Java.Net
{
    #region JarURLConnection
    public partial class JarURLConnection
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/JarURLConnection.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Jar.Attributes Attributes
        {
            get { return IExecute<Java.Util.Jar.Attributes>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/JarURLConnection.html#getCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] Certificates
        {
            get { return IExecuteArray<Java.Security.Cert.Certificate>("getCertificates"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/JarURLConnection.html#getEntryName()"/> 
        /// </summary>
        public string EntryName
        {
            get { return IExecute<string>("getEntryName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/JarURLConnection.html#getJarEntry()"/> 
        /// </summary>
        public Java.Util.Jar.JarEntry JarEntry
        {
            get { return IExecute<Java.Util.Jar.JarEntry>("getJarEntry"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/JarURLConnection.html#getJarFile()"/> 
        /// </summary>
        public Java.Util.Jar.JarFile JarFile
        {
            get { return IExecute<Java.Util.Jar.JarFile>("getJarFile"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/JarURLConnection.html#getJarFileURL()"/> 
        /// </summary>
        public Java.Net.URL JarFileURL
        {
            get { return IExecute<Java.Net.URL>("getJarFileURL"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/JarURLConnection.html#getMainAttributes()"/> 
        /// </summary>
        public Java.Util.Jar.Attributes MainAttributes
        {
            get { return IExecute<Java.Util.Jar.Attributes>("getMainAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/JarURLConnection.html#getManifest()"/> 
        /// </summary>
        public Java.Util.Jar.Manifest Manifest
        {
            get { return IExecute<Java.Util.Jar.Manifest>("getManifest"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}