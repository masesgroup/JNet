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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region IHandshakeCompletedListener
    public partial interface IHandshakeCompletedListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedListener.html#handshakeCompleted(javax.net.ssl.HandshakeCompletedEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedEvent"/></param>
        void HandshakeCompleted(Javax.Net.Ssl.HandshakeCompletedEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HandshakeCompletedListener
    public partial class HandshakeCompletedListener : Javax.Net.Ssl.IHandshakeCompletedListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedListener.html#handshakeCompleted(javax.net.ssl.HandshakeCompletedEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedEvent"/></param>
        public virtual void HandshakeCompleted(Javax.Net.Ssl.HandshakeCompletedEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}