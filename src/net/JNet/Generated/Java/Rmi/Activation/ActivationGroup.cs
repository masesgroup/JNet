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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Activation
{
    #region ActivationGroup
    public partial class ActivationGroup
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Rmi.Activation.ActivationGroup"/> to <see cref="Java.Rmi.Activation.ActivationInstantiator"/>
        /// </summary>
        public static implicit operator Java.Rmi.Activation.ActivationInstantiator(Java.Rmi.Activation.ActivationGroup t) => t.Cast<Java.Rmi.Activation.ActivationInstantiator>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroup.html#getSystem()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroup.html#setSystem(java.rmi.activation.ActivationSystem)"/>
        /// </summary>
        public static Java.Rmi.Activation.ActivationSystem System
        {
            get { return SExecuteWithSignature<Java.Rmi.Activation.ActivationSystem>(LocalBridgeClazz, "getSystem", "()Ljava/rmi/activation/ActivationSystem;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setSystem", "(Ljava/rmi/activation/ActivationSystem;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroup.html#createGroup(java.rmi.activation.ActivationGroupID,java.rmi.activation.ActivationGroupDesc,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationGroupDesc"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationGroup"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        public static Java.Rmi.Activation.ActivationGroup CreateGroup(Java.Rmi.Activation.ActivationGroupID arg0, Java.Rmi.Activation.ActivationGroupDesc arg1, long arg2)
        {
            return SExecute<Java.Rmi.Activation.ActivationGroup>(LocalBridgeClazz, "createGroup", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroup.html#currentGroupID()"/>
        /// </summary>

        /// <returns><see cref="Java.Rmi.Activation.ActivationGroupID"/></returns>
        public static Java.Rmi.Activation.ActivationGroupID CurrentGroupID()
        {
            return SExecuteWithSignature<Java.Rmi.Activation.ActivationGroupID>(LocalBridgeClazz, "currentGroupID", "()Ljava/rmi/activation/ActivationGroupID;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroup.html#activeObject(java.rmi.activation.ActivationID,java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Remote"/></param>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public void ActiveObject(Java.Rmi.Activation.ActivationID arg0, Java.Rmi.Remote arg1)
        {
            IExecute("activeObject", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroup.html#inactiveObject(java.rmi.activation.ActivationID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public bool InactiveObject(Java.Rmi.Activation.ActivationID arg0)
        {
            return IExecuteWithSignature<bool>("inactiveObject", "(Ljava/rmi/activation/ActivationID;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}