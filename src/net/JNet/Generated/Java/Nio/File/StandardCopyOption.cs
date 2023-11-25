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
        public static Java.Nio.File.StandardCopyOption ATOMIC_MOVE { get { return SGetField<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "ATOMIC_MOVE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardCopyOption.html#COPY_ATTRIBUTES"/>
        /// </summary>
        public static Java.Nio.File.StandardCopyOption COPY_ATTRIBUTES { get { return SGetField<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "COPY_ATTRIBUTES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardCopyOption.html#REPLACE_EXISTING"/>
        /// </summary>
        public static Java.Nio.File.StandardCopyOption REPLACE_EXISTING { get { return SGetField<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "REPLACE_EXISTING"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardCopyOption.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.StandardCopyOption"/></returns>
        public static Java.Nio.File.StandardCopyOption ValueOf(string arg0)
        {
            return SExecute<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardCopyOption.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.StandardCopyOption"/></returns>
        public static Java.Nio.File.StandardCopyOption[] Values()
        {
            return SExecuteArray<Java.Nio.File.StandardCopyOption>(LocalBridgeClazz, "values");
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