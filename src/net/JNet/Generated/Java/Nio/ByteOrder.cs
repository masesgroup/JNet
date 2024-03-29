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

namespace Java.Nio
{
    #region ByteOrder
    public partial class ByteOrder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteOrder.html#BIG_ENDIAN"/>
        /// </summary>
        public static Java.Nio.ByteOrder BIG_ENDIAN { get { if (!_BIG_ENDIANReady) { _BIG_ENDIANContent = SGetField<Java.Nio.ByteOrder>(LocalBridgeClazz, "BIG_ENDIAN"); _BIG_ENDIANReady = true; } return _BIG_ENDIANContent; } }
        private static Java.Nio.ByteOrder _BIG_ENDIANContent = default;
        private static bool _BIG_ENDIANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteOrder.html#LITTLE_ENDIAN"/>
        /// </summary>
        public static Java.Nio.ByteOrder LITTLE_ENDIAN { get { if (!_LITTLE_ENDIANReady) { _LITTLE_ENDIANContent = SGetField<Java.Nio.ByteOrder>(LocalBridgeClazz, "LITTLE_ENDIAN"); _LITTLE_ENDIANReady = true; } return _LITTLE_ENDIANContent; } }
        private static Java.Nio.ByteOrder _LITTLE_ENDIANContent = default;
        private static bool _LITTLE_ENDIANReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteOrder.html#nativeOrder()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.ByteOrder"/></returns>
        public static Java.Nio.ByteOrder NativeOrder()
        {
            return SExecuteWithSignature<Java.Nio.ByteOrder>(LocalBridgeClazz, "nativeOrder", "()Ljava/nio/ByteOrder;");
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