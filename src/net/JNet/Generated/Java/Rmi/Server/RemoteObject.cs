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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Server
{
    #region RemoteObject
    public partial class RemoteObject
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Rmi.Server.RemoteObject"/> to <see cref="Java.Rmi.Remote"/>
        /// </summary>
        public static implicit operator Java.Rmi.Remote(Java.Rmi.Server.RemoteObject t) => t.Cast<Java.Rmi.Remote>();
        /// <summary>
        /// Converter from <see cref="Java.Rmi.Server.RemoteObject"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Rmi.Server.RemoteObject t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteObject.html#toStub(java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.NoSuchObjectException"/>
        public static Java.Rmi.Remote ToStub(Java.Rmi.Remote arg0)
        {
            return SExecute<Java.Rmi.Remote>(LocalBridgeClazz, "toStub", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteObject.html#getRef()"/> 
        /// </summary>
        public Java.Rmi.Server.RemoteRef Ref
        {
            get { return IExecute<Java.Rmi.Server.RemoteRef>("getRef"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}