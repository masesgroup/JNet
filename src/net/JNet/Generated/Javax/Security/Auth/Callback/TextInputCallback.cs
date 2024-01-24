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

namespace Javax.Security.Auth.Callback
{
    #region TextInputCallback
    public partial class TextInputCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextInputCallback.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public TextInputCallback(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextInputCallback.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public TextInputCallback(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.TextInputCallback"/> to <see cref="Javax.Security.Auth.Callback.Callback"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Callback.Callback(Javax.Security.Auth.Callback.TextInputCallback t) => t.Cast<Javax.Security.Auth.Callback.Callback>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.TextInputCallback"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Callback.TextInputCallback t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextInputCallback.html#getDefaultText()"/> 
        /// </summary>
        public string DefaultText
        {
            get { return IExecute<string>("getDefaultText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextInputCallback.html#getPrompt()"/> 
        /// </summary>
        public string Prompt
        {
            get { return IExecute<string>("getPrompt"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextInputCallback.html#getText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextInputCallback.html#setText(java.lang.String)"/>
        /// </summary>
        public string Text
        {
            get { return IExecute<string>("getText"); } set { IExecute("setText", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}