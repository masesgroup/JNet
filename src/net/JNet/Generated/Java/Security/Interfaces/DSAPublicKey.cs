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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Interfaces
{
    #region IDSAPublicKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDSAPublicKey
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAPublicKey.html#getY()"/> 
        /// </summary>
        Java.Math.BigInteger Y { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DSAPublicKey
    public partial class DSAPublicKey : Java.Security.Interfaces.IDSAPublicKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.DSAPublicKey"/> to <see cref="Java.Security.Interfaces.DSAKey"/>
        /// </summary>
        public static implicit operator Java.Security.Interfaces.DSAKey(Java.Security.Interfaces.DSAPublicKey t) => t.Cast<Java.Security.Interfaces.DSAKey>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.DSAPublicKey"/> to <see cref="Java.Security.PublicKey"/>
        /// </summary>
        public static implicit operator Java.Security.PublicKey(Java.Security.Interfaces.DSAPublicKey t) => t.Cast<Java.Security.PublicKey>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAPublicKey.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID { get { return SGetField<long>(LocalBridgeClazz, "serialVersionUID"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAPublicKey.html#getY()"/> 
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