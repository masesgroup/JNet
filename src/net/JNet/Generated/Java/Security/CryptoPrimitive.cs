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

namespace Java.Security
{
    #region CryptoPrimitive
    public partial class CryptoPrimitive
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#BLOCK_CIPHER"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive BLOCK_CIPHER { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "BLOCK_CIPHER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#KEY_AGREEMENT"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive KEY_AGREEMENT { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "KEY_AGREEMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#KEY_ENCAPSULATION"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive KEY_ENCAPSULATION { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "KEY_ENCAPSULATION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#KEY_WRAP"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive KEY_WRAP { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "KEY_WRAP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#MAC"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive MAC { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "MAC"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#MESSAGE_DIGEST"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive MESSAGE_DIGEST { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "MESSAGE_DIGEST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#PUBLIC_KEY_ENCRYPTION"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive PUBLIC_KEY_ENCRYPTION { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "PUBLIC_KEY_ENCRYPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#SECURE_RANDOM"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive SECURE_RANDOM { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "SECURE_RANDOM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#SIGNATURE"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive SIGNATURE { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "SIGNATURE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#STREAM_CIPHER"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive STREAM_CIPHER { get { return SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "STREAM_CIPHER"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#values()"/> 
        /// </summary>
        public static Java.Security.CryptoPrimitive[] Values
        {
            get { return SExecuteArray<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.CryptoPrimitive"/></returns>
        public static Java.Security.CryptoPrimitive ValueOf(string arg0)
        {
            return SExecute<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "valueOf", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}