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
    #region LoginContext
    public partial class LoginContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginContext.html#%3Cinit%3E(java.lang.String,javax.security.auth.callback.CallbackHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public LoginContext(string arg0, Javax.Security.Auth.Callback.CallbackHandler arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginContext.html#%3Cinit%3E(java.lang.String,javax.security.auth.Subject,javax.security.auth.callback.CallbackHandler,javax.security.auth.login.Configuration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <param name="arg3"><see cref="Javax.Security.Auth.Login.Configuration"/></param>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public LoginContext(string arg0, Javax.Security.Auth.Subject arg1, Javax.Security.Auth.Callback.CallbackHandler arg2, Javax.Security.Auth.Login.Configuration arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginContext.html#%3Cinit%3E(java.lang.String,javax.security.auth.Subject,javax.security.auth.callback.CallbackHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public LoginContext(string arg0, Javax.Security.Auth.Subject arg1, Javax.Security.Auth.Callback.CallbackHandler arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginContext.html#%3Cinit%3E(java.lang.String,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public LoginContext(string arg0, Javax.Security.Auth.Subject arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginContext.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public LoginContext(string arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginContext.html#getSubject()"/> 
        /// </summary>
        public Javax.Security.Auth.Subject Subject
        {
            get { return IExecute<Javax.Security.Auth.Subject>("getSubject"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginContext.html#login.LoginContext.login()"/>
        /// </summary>
        
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public void Login()
        {
            IExecute("login");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginContext.html#logout()"/>
        /// </summary>
        
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public void Logout()
        {
            IExecute("logout");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}