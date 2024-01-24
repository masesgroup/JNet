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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region KeyManagerFactory
    public partial class KeyManagerFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyManagerFactory.html#getDefaultAlgorithm()"/> 
        /// </summary>
        public static string DefaultAlgorithm
        {
            get { return SExecute<string>(LocalBridgeClazz, "getDefaultAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyManagerFactory.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Net.Ssl.KeyManagerFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Net.Ssl.KeyManagerFactory GetInstance(string arg0, string arg1)
        {
            return SExecute<Javax.Net.Ssl.KeyManagerFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyManagerFactory.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Net.Ssl.KeyManagerFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Net.Ssl.KeyManagerFactory GetInstance(string arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Net.Ssl.KeyManagerFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyManagerFactory.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Net.Ssl.KeyManagerFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Net.Ssl.KeyManagerFactory GetInstance(string arg0)
        {
            return SExecute<Javax.Net.Ssl.KeyManagerFactory>(LocalBridgeClazz, "getInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyManagerFactory.html#getAlgorithm()"/> 
        /// </summary>
        public string Algorithm
        {
            get { return IExecute<string>("getAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyManagerFactory.html#getKeyManagers()"/> 
        /// </summary>
        public Javax.Net.Ssl.KeyManager[] KeyManagers
        {
            get { return IExecuteArray<Javax.Net.Ssl.KeyManager>("getKeyManagers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyManagerFactory.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecute<Java.Security.Provider>("getProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyManagerFactory.html#init(java.security.KeyStore,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableKeyException"/>
        public void Init(Java.Security.KeyStore arg0, char[] arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/KeyManagerFactory.html#init(javax.net.ssl.ManagerFactoryParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.ManagerFactoryParameters"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(Javax.Net.Ssl.ManagerFactoryParameters arg0)
        {
            IExecute("init", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}