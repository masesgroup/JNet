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
    #region LinkOption
    public partial class LinkOption
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.LinkOption"/> to <see cref="Java.Nio.File.OpenOption"/>
        /// </summary>
        public static implicit operator Java.Nio.File.OpenOption(Java.Nio.File.LinkOption t) => t.Cast<Java.Nio.File.OpenOption>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.LinkOption"/> to <see cref="Java.Nio.File.CopyOption"/>
        /// </summary>
        public static implicit operator Java.Nio.File.CopyOption(Java.Nio.File.LinkOption t) => t.Cast<Java.Nio.File.CopyOption>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/LinkOption.html#NOFOLLOW_LINKS"/>
        /// </summary>
        public static Java.Nio.File.LinkOption NOFOLLOW_LINKS { get { if (!_NOFOLLOW_LINKSReady) { _NOFOLLOW_LINKSContent = SGetField<Java.Nio.File.LinkOption>(LocalBridgeClazz, "NOFOLLOW_LINKS"); _NOFOLLOW_LINKSReady = true; } return _NOFOLLOW_LINKSContent; } }
        private static Java.Nio.File.LinkOption _NOFOLLOW_LINKSContent = default;
        private static bool _NOFOLLOW_LINKSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/LinkOption.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.LinkOption"/></returns>
        public static Java.Nio.File.LinkOption ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.LinkOption>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/LinkOption;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/LinkOption.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.LinkOption"/></returns>
        public static Java.Nio.File.LinkOption[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.LinkOption>(LocalBridgeClazz, "values", "()[Ljava/nio/file/LinkOption;");
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