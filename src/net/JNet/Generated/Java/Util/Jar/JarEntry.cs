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

namespace Java.Util.Jar
{
    #region JarEntry
    public partial class JarEntry
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarEntry.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public JarEntry(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarEntry.html#%3Cinit%3E(java.util.jar.JarEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Jar.JarEntry"/></param>
        public JarEntry(Java.Util.Jar.JarEntry arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarEntry.html#%3Cinit%3E(java.util.zip.ZipEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.ZipEntry"/></param>
        public JarEntry(Java.Util.Zip.ZipEntry arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarEntry.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Jar.Attributes Attributes
        {
            get { return IExecute<Java.Util.Jar.Attributes>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarEntry.html#getCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] Certificates
        {
            get { return IExecuteArray<Java.Security.Cert.Certificate>("getCertificates"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarEntry.html#getCodeSigners()"/> 
        /// </summary>
        public Java.Security.CodeSigner[] CodeSigners
        {
            get { return IExecuteArray<Java.Security.CodeSigner>("getCodeSigners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarEntry.html#getRealName()"/> 
        /// </summary>
        public string RealName
        {
            get { return IExecute<string>("getRealName"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}