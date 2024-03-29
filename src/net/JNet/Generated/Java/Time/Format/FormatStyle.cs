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

namespace Java.Time.Format
{
    #region FormatStyle
    public partial class FormatStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#FULL"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle FULL { get { if (!_FULLReady) { _FULLContent = SGetField<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "FULL"); _FULLReady = true; } return _FULLContent; } }
        private static Java.Time.Format.FormatStyle _FULLContent = default;
        private static bool _FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#LONG"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle LONG { get { if (!_LONGReady) { _LONGContent = SGetField<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "LONG"); _LONGReady = true; } return _LONGContent; } }
        private static Java.Time.Format.FormatStyle _LONGContent = default;
        private static bool _LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#MEDIUM"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle MEDIUM { get { if (!_MEDIUMReady) { _MEDIUMContent = SGetField<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "MEDIUM"); _MEDIUMReady = true; } return _MEDIUMContent; } }
        private static Java.Time.Format.FormatStyle _MEDIUMContent = default;
        private static bool _MEDIUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#SHORT"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
        private static Java.Time.Format.FormatStyle _SHORTContent = default;
        private static bool _SHORTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Format.FormatStyle"/></returns>
        public static Java.Time.Format.FormatStyle ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/format/FormatStyle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Format.FormatStyle"/></returns>
        public static Java.Time.Format.FormatStyle[] Values()
        {
            return SExecuteWithSignatureArray<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "values", "()[Ljava/time/format/FormatStyle;");
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