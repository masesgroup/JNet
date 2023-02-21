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
    #region NameCallback
    public partial class NameCallback
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/NameCallback.html#<init>(java.lang.String)
        /// </summary>
        public NameCallback(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/NameCallback.html#<init>(java.lang.String,java.lang.String)
        /// </summary>
        public NameCallback(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Security.Auth.Callback.Callback(Javax.Security.Auth.Callback.NameCallback t) => t.Cast<Javax.Security.Auth.Callback.Callback>();
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Callback.NameCallback t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/NameCallback.html#getDefaultName() 
        /// </summary>
        public string DefaultName
        {
            get { return IExecute<string>("getDefaultName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/NameCallback.html#getName() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/NameCallback.html#setName(java.lang.String)
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/NameCallback.html#getPrompt() 
        /// </summary>
        public string Prompt
        {
            get { return IExecute<string>("getPrompt"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}