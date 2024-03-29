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

namespace Java.Nio.File
{
    #region StandardCopyOption
    public partial class StandardCopyOption
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.StandardCopyOption"/> to <see cref="Java.Nio.File.CopyOption"/>
        /// </summary>
        public static implicit operator Java.Nio.File.CopyOption(Java.Nio.File.StandardCopyOption t) => t.Cast<Java.Nio.File.CopyOption>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardCopyOption.html#ATOMIC_MOVE"/>
        /// </summary>
        public static Java.Nio.File.StandardCopyOption ATOMIC_MOVE { get { if (!_ATOMIC_MOVEReady) { _ATOMIC_MOVEContent = SGetField<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "ATOMIC_MOVE"); _ATOMIC_MOVEReady = true; } return _ATOMIC_MOVEContent; } }
        private static Java.Nio.File.StandardCopyOption _ATOMIC_MOVEContent = default;
        private static bool _ATOMIC_MOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardCopyOption.html#COPY_ATTRIBUTES"/>
        /// </summary>
        public static Java.Nio.File.StandardCopyOption COPY_ATTRIBUTES { get { if (!_COPY_ATTRIBUTESReady) { _COPY_ATTRIBUTESContent = SGetField<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "COPY_ATTRIBUTES"); _COPY_ATTRIBUTESReady = true; } return _COPY_ATTRIBUTESContent; } }
        private static Java.Nio.File.StandardCopyOption _COPY_ATTRIBUTESContent = default;
        private static bool _COPY_ATTRIBUTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardCopyOption.html#REPLACE_EXISTING"/>
        /// </summary>
        public static Java.Nio.File.StandardCopyOption REPLACE_EXISTING { get { if (!_REPLACE_EXISTINGReady) { _REPLACE_EXISTINGContent = SGetField<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "REPLACE_EXISTING"); _REPLACE_EXISTINGReady = true; } return _REPLACE_EXISTINGContent; } }
        private static Java.Nio.File.StandardCopyOption _REPLACE_EXISTINGContent = default;
        private static bool _REPLACE_EXISTINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardCopyOption.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.StandardCopyOption"/></returns>
        public static Java.Nio.File.StandardCopyOption ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/StandardCopyOption;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardCopyOption.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.StandardCopyOption"/></returns>
        public static Java.Nio.File.StandardCopyOption[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "values", "()[Ljava/nio/file/StandardCopyOption;");
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