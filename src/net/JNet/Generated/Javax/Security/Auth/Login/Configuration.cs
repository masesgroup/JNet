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

namespace Javax.Security.Auth.Login
{
    #region Configuration
    public partial class Configuration
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.html#getConfiguration()
        /// </summary>
        public static Javax.Security.Auth.Login.Configuration GetConfiguration()
        {
            return SExecute<Javax.Security.Auth.Login.Configuration>("getConfiguration");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.html#getInstance(java.lang.String,javax.security.auth.login.Configuration$Parameters,java.lang.String) throws java.security.NoSuchProviderException,java.security.NoSuchAlgorithmException
        /// </summary>
        public static Javax.Security.Auth.Login.Configuration GetInstance(string arg0, Javax.Security.Auth.Login.Configuration.Parameters arg1, string arg2)
        {
            return SExecute<Javax.Security.Auth.Login.Configuration>("getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.html#getInstance(java.lang.String,javax.security.auth.login.Configuration$Parameters) throws java.security.NoSuchAlgorithmException
        /// </summary>
        public static Javax.Security.Auth.Login.Configuration GetInstance(string arg0, Javax.Security.Auth.Login.Configuration.Parameters arg1)
        {
            return SExecute<Javax.Security.Auth.Login.Configuration>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.html#setConfiguration(javax.security.auth.login.Configuration)
        /// </summary>
        public static void SetConfiguration(Javax.Security.Auth.Login.Configuration arg0)
        {
            SExecute("setConfiguration", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.html#getType() 
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.html#getAppConfigurationEntry(java.lang.String)
        /// </summary>
        public Javax.Security.Auth.Login.AppConfigurationEntry[] GetAppConfigurationEntry(string arg0)
        {
            return IExecuteArray<Javax.Security.Auth.Login.AppConfigurationEntry>("getAppConfigurationEntry", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.html#getParameters()
        /// </summary>
        public Javax.Security.Auth.Login.Configuration.Parameters GetParameters()
        {
            return IExecute<Javax.Security.Auth.Login.Configuration.Parameters>("getParameters");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.html#refresh()
        /// </summary>
        public void Refresh()
        {
            IExecute("refresh");
        }
        
        #endregion

        #region Nested classes
        #region Parameters
        public partial class Parameters
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

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}