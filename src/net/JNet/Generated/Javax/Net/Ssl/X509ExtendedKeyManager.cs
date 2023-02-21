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

namespace Javax.Net.Ssl
{
    #region X509ExtendedKeyManager
    public partial class X509ExtendedKeyManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Net.Ssl.X509KeyManager(Javax.Net.Ssl.X509ExtendedKeyManager t) => t.Cast<Javax.Net.Ssl.X509KeyManager>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509ExtendedKeyManager.html#chooseEngineClientAlias(java.lang.String[],java.security.Principal[],javax.net.ssl.SSLEngine)
        /// </summary>
        public string ChooseEngineClientAlias(string[] arg0, Java.Security.Principal[] arg1, Javax.Net.Ssl.SSLEngine arg2)
        {
            return IExecute<string>("chooseEngineClientAlias", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509ExtendedKeyManager.html#chooseEngineServerAlias(java.lang.String,java.security.Principal[],javax.net.ssl.SSLEngine)
        /// </summary>
        public string ChooseEngineServerAlias(string arg0, Java.Security.Principal[] arg1, Javax.Net.Ssl.SSLEngine arg2)
        {
            return IExecute<string>("chooseEngineServerAlias", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}