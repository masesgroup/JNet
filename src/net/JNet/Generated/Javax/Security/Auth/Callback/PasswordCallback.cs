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

namespace Javax.Security.Auth.Callback
{
    #region PasswordCallback
    public partial class PasswordCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/PasswordCallback.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public PasswordCallback(string arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.PasswordCallback"/> to <see cref="Javax.Security.Auth.Callback.Callback"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Callback.Callback(Javax.Security.Auth.Callback.PasswordCallback t) => t.Cast<Javax.Security.Auth.Callback.Callback>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.PasswordCallback"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Callback.PasswordCallback t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/PasswordCallback.html#getPassword()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/PasswordCallback.html#setPassword(char[])"/>
        /// </summary>
        public char[] Password
        {
            get { return IExecuteArray<char>("getPassword"); } set { IExecute("setPassword", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/PasswordCallback.html#getPrompt()"/> 
        /// </summary>
        public string Prompt
        {
            get { return IExecute<string>("getPrompt"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/PasswordCallback.html#isEchoOn()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsEchoOn()
        {
            return IExecute<bool>("isEchoOn");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/PasswordCallback.html#clearPassword()"/>
        /// </summary>
        public void ClearPassword()
        {
            IExecute("clearPassword");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}