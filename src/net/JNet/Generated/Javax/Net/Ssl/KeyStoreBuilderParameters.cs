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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region KeyStoreBuilderParameters
    public partial class KeyStoreBuilderParameters
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyStoreBuilderParameters.html#%3Cinit%3E(java.security.KeyStore.Builder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore.Builder"/></param>
        public KeyStoreBuilderParameters(Java.Security.KeyStore.Builder arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyStoreBuilderParameters.html#%3Cinit%3E(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public KeyStoreBuilderParameters(Java.Util.List<Java.Security.KeyStore.Builder> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Net.Ssl.KeyStoreBuilderParameters"/> to <see cref="Javax.Net.Ssl.ManagerFactoryParameters"/>
        /// </summary>
        public static implicit operator Javax.Net.Ssl.ManagerFactoryParameters(Javax.Net.Ssl.KeyStoreBuilderParameters t) => t.Cast<Javax.Net.Ssl.ManagerFactoryParameters>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyStoreBuilderParameters.html#getParameters()"/> 
        /// </summary>
        public Java.Util.List<Java.Security.KeyStore.Builder> Parameters
        {
            get { return IExecute<Java.Util.List<Java.Security.KeyStore.Builder>>("getParameters"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}