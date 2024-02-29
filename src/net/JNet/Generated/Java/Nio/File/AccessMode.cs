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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File
{
    #region AccessMode
    public partial class AccessMode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#EXECUTE"/>
        /// </summary>
        public static Java.Nio.File.AccessMode EXECUTE { get { if (!_EXECUTEReady) { _EXECUTEContent = SGetField<Java.Nio.File.AccessMode>(LocalBridgeClazz, "EXECUTE"); _EXECUTEReady = true; } return _EXECUTEContent; } }
        private static Java.Nio.File.AccessMode _EXECUTEContent = default;
        private static bool _EXECUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#READ"/>
        /// </summary>
        public static Java.Nio.File.AccessMode READ { get { if (!_READReady) { _READContent = SGetField<Java.Nio.File.AccessMode>(LocalBridgeClazz, "READ"); _READReady = true; } return _READContent; } }
        private static Java.Nio.File.AccessMode _READContent = default;
        private static bool _READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#WRITE"/>
        /// </summary>
        public static Java.Nio.File.AccessMode WRITE { get { if (!_WRITEReady) { _WRITEContent = SGetField<Java.Nio.File.AccessMode>(LocalBridgeClazz, "WRITE"); _WRITEReady = true; } return _WRITEContent; } }
        private static Java.Nio.File.AccessMode _WRITEContent = default;
        private static bool _WRITEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.AccessMode"/></returns>
        public static Java.Nio.File.AccessMode ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.AccessMode>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/AccessMode;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.AccessMode"/></returns>
        public static Java.Nio.File.AccessMode[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.AccessMode>(LocalBridgeClazz, "values", "()[Ljava/nio/file/AccessMode;");
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