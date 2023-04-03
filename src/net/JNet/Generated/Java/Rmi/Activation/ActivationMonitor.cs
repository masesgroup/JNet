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

namespace Java.Rmi.Activation
{
    #region ActivationMonitor
    public partial class ActivationMonitor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationMonitor.html#activeObject(java.rmi.activation.ActivationID,java.rmi.MarshalledObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public void ActiveObject<Arg1ExtendsJava_Rmi_Remote>(Java.Rmi.Activation.ActivationID arg0, Java.Rmi.MarshalledObject<Arg1ExtendsJava_Rmi_Remote> arg1) where Arg1ExtendsJava_Rmi_Remote: Java.Rmi.Remote
        {
            IExecute("activeObject", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationMonitor.html#inactiveGroup(java.rmi.activation.ActivationGroupID,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public void InactiveGroup(Java.Rmi.Activation.ActivationGroupID arg0, long arg1)
        {
            IExecute("inactiveGroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationMonitor.html#inactiveObject(java.rmi.activation.ActivationID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public void InactiveObject(Java.Rmi.Activation.ActivationID arg0)
        {
            IExecute("inactiveObject", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}