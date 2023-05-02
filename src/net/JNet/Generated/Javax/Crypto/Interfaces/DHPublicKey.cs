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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Crypto.Interfaces
{
    #region DHPublicKey
    public partial class DHPublicKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Crypto.Interfaces.DHPublicKey"/> to <see cref="Javax.Crypto.Interfaces.DHKey"/>
        /// </summary>
        public static implicit operator Javax.Crypto.Interfaces.DHKey(Javax.Crypto.Interfaces.DHPublicKey t) => t.Cast<Javax.Crypto.Interfaces.DHKey>();
        /// <summary>
        /// Converter from <see cref="Javax.Crypto.Interfaces.DHPublicKey"/> to <see cref="Java.Security.PublicKey"/>
        /// </summary>
        public static implicit operator Java.Security.PublicKey(Javax.Crypto.Interfaces.DHPublicKey t) => t.Cast<Java.Security.PublicKey>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/interfaces/DHPublicKey.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID { get { return SGetField<long>(LocalBridgeClazz, "serialVersionUID"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/interfaces/DHPublicKey.html#getY()"/> 
        /// </summary>
        public Java.Math.BigInteger Y
        {
            get { return IExecute<Java.Math.BigInteger>("getY"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}