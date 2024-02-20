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

namespace Java.Rmi.Activation
{
    #region ActivationDesc
    public partial class ActivationDesc
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationDesc.html#%3Cinit%3E(java.lang.String,java.lang.String,java.rmi.MarshalledObject,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        public ActivationDesc(Java.Lang.String arg0, Java.Lang.String arg1, Java.Rmi.MarshalledObject<object> arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationDesc.html#%3Cinit%3E(java.lang.String,java.lang.String,java.rmi.MarshalledObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        public ActivationDesc(Java.Lang.String arg0, Java.Lang.String arg1, Java.Rmi.MarshalledObject<object> arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationDesc.html#%3Cinit%3E(java.rmi.activation.ActivationGroupID,java.lang.String,java.lang.String,java.rmi.MarshalledObject,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public ActivationDesc(Java.Rmi.Activation.ActivationGroupID arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Rmi.MarshalledObject<object> arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationDesc.html#%3Cinit%3E(java.rmi.activation.ActivationGroupID,java.lang.String,java.lang.String,java.rmi.MarshalledObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Rmi.MarshalledObject"/></param>
        public ActivationDesc(Java.Rmi.Activation.ActivationGroupID arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Rmi.MarshalledObject<object> arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationDesc.html#getClassName()"/> 
        /// </summary>
        public Java.Lang.String ClassName
        {
            get { return IExecute<Java.Lang.String>("getClassName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationDesc.html#getData()"/> 
        /// </summary>
        public Java.Rmi.MarshalledObject<object> Data
        {
            get { return IExecute<Java.Rmi.MarshalledObject<object>>("getData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationDesc.html#getGroupID()"/> 
        /// </summary>
        public Java.Rmi.Activation.ActivationGroupID GroupID
        {
            get { return IExecute<Java.Rmi.Activation.ActivationGroupID>("getGroupID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationDesc.html#getLocation()"/> 
        /// </summary>
        public Java.Lang.String Location
        {
            get { return IExecute<Java.Lang.String>("getLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationDesc.html#getRestartMode()"/> 
        /// </summary>
        public bool RestartMode
        {
            get { return IExecute<bool>("getRestartMode"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}