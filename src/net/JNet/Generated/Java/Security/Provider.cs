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

namespace Java.Security
{
    #region Provider
    public partial class Provider
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#getInfo()"/> 
        /// </summary>
        public string Info
        {
            get { return IExecute<string>("getInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#getVersionStr()"/> 
        /// </summary>
        public string VersionStr
        {
            get { return IExecute<string>("getVersionStr"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#isConfigured()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsConfigured()
        {
            return IExecute<bool>("isConfigured");
        }
        
        #endregion

        #region Nested classes
        #region Service
        public partial class Service
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#getAlgorithm()"/> 
            /// </summary>
            public string Algorithm
            {
                get { return IExecute<string>("getAlgorithm"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#getType()"/> 
            /// </summary>
            public string Type
            {
                get { return IExecute<string>("getType"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#supportsParameter(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see langword="bool"/></returns>
            public bool SupportsParameter(object arg0)
            {
                return IExecute<bool>("supportsParameter", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#getAttribute(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see langword="string"/></returns>
            public string GetAttribute(string arg0)
            {
                return IExecute<string>("getAttribute", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#getClassName()"/>
            /// </summary>
            
            /// <returns><see langword="string"/></returns>
            public string GetClassName()
            {
                return IExecute<string>("getClassName");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#newInstance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see langword="object"/></returns>
            /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
            public object NewInstance(object arg0)
            {
                return IExecute("newInstance", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}