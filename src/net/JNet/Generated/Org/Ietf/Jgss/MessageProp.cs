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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Ietf.Jgss
{
    #region MessageProp
    public partial class MessageProp
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public MessageProp(bool arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#%3Cinit%3E(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public MessageProp(int arg0, bool arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#getMinorStatus()"/> 
        /// </summary>
        public int MinorStatus
        {
            get { return IExecuteWithSignature<int>("getMinorStatus", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#getMinorString()"/> 
        /// </summary>
        public Java.Lang.String MinorString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMinorString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#getPrivacy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#setPrivacy(boolean)"/>
        /// </summary>
        public bool Privacy
        {
            get { return IExecuteWithSignature<bool>("getPrivacy", "()Z"); } set { IExecuteWithSignature("setPrivacy", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#getQOP()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#setQOP(int)"/>
        /// </summary>
        public int QOP
        {
            get { return IExecuteWithSignature<int>("getQOP", "()I"); } set { IExecuteWithSignature("setQOP", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#isDuplicateToken()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDuplicateToken()
        {
            return IExecuteWithSignature<bool>("isDuplicateToken", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#isGapToken()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsGapToken()
        {
            return IExecuteWithSignature<bool>("isGapToken", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#isOldToken()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOldToken()
        {
            return IExecuteWithSignature<bool>("isOldToken", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#isUnseqToken()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsUnseqToken()
        {
            return IExecuteWithSignature<bool>("isUnseqToken", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/MessageProp.html#setSupplementaryStates(boolean,boolean,boolean,boolean,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        public void SetSupplementaryStates(bool arg0, bool arg1, bool arg2, bool arg3, int arg4, Java.Lang.String arg5)
        {
            IExecute("setSupplementaryStates", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}