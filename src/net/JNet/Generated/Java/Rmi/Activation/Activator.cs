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

namespace Java.Rmi.Activation
{
    #region IActivator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IActivator : Java.Rmi.IRemote
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activator.html#activate(java.rmi.activation.ActivationID,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <typeparam name="ReturnExtendsJava_Rmi_Remote"><see cref="Java.Rmi.Remote"/></typeparam>
        /// <returns><see cref="Java.Rmi.MarshalledObject"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        Java.Rmi.MarshalledObject<ReturnExtendsJava_Rmi_Remote> Activate<ReturnExtendsJava_Rmi_Remote>(Java.Rmi.Activation.ActivationID arg0, bool arg1) where ReturnExtendsJava_Rmi_Remote: Java.Rmi.Remote;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Activator
    public partial class Activator : Java.Rmi.Activation.IActivator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activator.html#activate(java.rmi.activation.ActivationID,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <typeparam name="ReturnExtendsJava_Rmi_Remote"><see cref="Java.Rmi.Remote"/></typeparam>
        /// <returns><see cref="Java.Rmi.MarshalledObject"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public Java.Rmi.MarshalledObject<ReturnExtendsJava_Rmi_Remote> Activate<ReturnExtendsJava_Rmi_Remote>(Java.Rmi.Activation.ActivationID arg0, bool arg1) where ReturnExtendsJava_Rmi_Remote: Java.Rmi.Remote
        {
            return IExecute<Java.Rmi.MarshalledObject<ReturnExtendsJava_Rmi_Remote>>("activate", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}