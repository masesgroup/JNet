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

namespace Java.Security
{
    #region PermissionCollection
    public partial class PermissionCollection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.PermissionCollection"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Security.PermissionCollection t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/PermissionCollection.html#elements()"/> 
        /// </summary>
        public Java.Util.Enumeration<Java.Security.Permission> Elements
        {
            get { return IExecute<Java.Util.Enumeration<Java.Security.Permission>>("elements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/PermissionCollection.html#elementsAsStream()"/> 
        /// </summary>
        public Java.Util.Stream.Stream<Java.Security.Permission> ElementsAsStream
        {
            get { return IExecute<Java.Util.Stream.Stream<Java.Security.Permission>>("elementsAsStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/PermissionCollection.html#isReadOnly()"/> 
        /// </summary>
        public bool IsReadOnly
        {
            get { return IExecute<bool>("isReadOnly"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/PermissionCollection.html#implies(java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Permission"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Implies(Java.Security.Permission arg0)
        {
            return IExecute<bool>("implies", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/PermissionCollection.html#add(java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Permission"/></param>
        public void Add(Java.Security.Permission arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/PermissionCollection.html#setReadOnly()"/>
        /// </summary>
        public void SetReadOnly()
        {
            IExecute("setReadOnly");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}