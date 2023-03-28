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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Auth.Callback
{
    #region ChoiceCallback
    public partial class ChoiceCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#%3Cinit%3E(java.lang.String,java.lang.String[],int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public ChoiceCallback(string arg0, string[] arg1, int arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.ChoiceCallback"/> to <see cref="Javax.Security.Auth.Callback.Callback"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Callback.Callback(Javax.Security.Auth.Callback.ChoiceCallback t) => t.Cast<Javax.Security.Auth.Callback.Callback>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.ChoiceCallback"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Callback.ChoiceCallback t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#getChoices()"/> 
        /// </summary>
        public string[] Choices
        {
            get { return IExecuteArray<string>("getChoices"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#getDefaultChoice()"/> 
        /// </summary>
        public int DefaultChoice
        {
            get { return IExecute<int>("getDefaultChoice"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#getPrompt()"/> 
        /// </summary>
        public string Prompt
        {
            get { return IExecute<string>("getPrompt"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#getSelectedIndexes()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#setSelectedIndexes(int[])"/>
        /// </summary>
        public int[] SelectedIndexes
        {
            get { return IExecuteArray<int>("getSelectedIndexes"); } set { IExecute("setSelectedIndexes", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#allowMultipleSelections()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool AllowMultipleSelections()
        {
            return IExecute<bool>("allowMultipleSelections");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#setSelectedIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSelectedIndex(int arg0)
        {
            IExecute("setSelectedIndex", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}