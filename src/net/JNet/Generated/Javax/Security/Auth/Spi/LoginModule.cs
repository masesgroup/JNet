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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Auth.Spi
{
    #region ILoginModule
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILoginModule
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#abort()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        bool Abort();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#commit()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        bool Commit();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#login()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        bool Login();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#logout()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        bool Logout();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#initialize(javax.security.auth.Subject,javax.security.auth.callback.CallbackHandler,java.util.Map,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        void Initialize(Javax.Security.Auth.Subject arg0, Javax.Security.Auth.Callback.CallbackHandler arg1, Java.Util.Map<string, object> arg2, Java.Util.Map<string, object> arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LoginModule
    public partial class LoginModule : Javax.Security.Auth.Spi.ILoginModule
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#abort()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public bool Abort()
        {
            return IExecute<bool>("abort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#commit()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public bool Commit()
        {
            return IExecute<bool>("commit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#login()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public bool Login()
        {
            return IExecute<bool>("login");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#logout()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public bool Logout()
        {
            return IExecute<bool>("logout");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/spi/LoginModule.html#initialize(javax.security.auth.Subject,javax.security.auth.callback.CallbackHandler,java.util.Map,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        public void Initialize(Javax.Security.Auth.Subject arg0, Javax.Security.Auth.Callback.CallbackHandler arg1, Java.Util.Map<string, object> arg2, Java.Util.Map<string, object> arg3)
        {
            IExecute("initialize", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}