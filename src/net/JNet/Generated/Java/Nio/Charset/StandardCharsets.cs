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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Charset
{
    #region StandardCharsets
    public partial class StandardCharsets
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/StandardCharsets.html#ISO_8859_1"/>
        /// </summary>
        public static Java.Nio.Charset.Charset ISO_8859_1 { get { if (!_ISO_8859_1Ready) { _ISO_8859_1Content = SGetField<Java.Nio.Charset.Charset>(LocalBridgeClazz, "ISO_8859_1"); _ISO_8859_1Ready = true; } return _ISO_8859_1Content; } }
        private static Java.Nio.Charset.Charset _ISO_8859_1Content = default;
        private static bool _ISO_8859_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/StandardCharsets.html#US_ASCII"/>
        /// </summary>
        public static Java.Nio.Charset.Charset US_ASCII { get { if (!_US_ASCIIReady) { _US_ASCIIContent = SGetField<Java.Nio.Charset.Charset>(LocalBridgeClazz, "US_ASCII"); _US_ASCIIReady = true; } return _US_ASCIIContent; } }
        private static Java.Nio.Charset.Charset _US_ASCIIContent = default;
        private static bool _US_ASCIIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/StandardCharsets.html#UTF_16"/>
        /// </summary>
        public static Java.Nio.Charset.Charset UTF_16 { get { if (!_UTF_16Ready) { _UTF_16Content = SGetField<Java.Nio.Charset.Charset>(LocalBridgeClazz, "UTF_16"); _UTF_16Ready = true; } return _UTF_16Content; } }
        private static Java.Nio.Charset.Charset _UTF_16Content = default;
        private static bool _UTF_16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/StandardCharsets.html#UTF_16BE"/>
        /// </summary>
        public static Java.Nio.Charset.Charset UTF_16BE { get { if (!_UTF_16BEReady) { _UTF_16BEContent = SGetField<Java.Nio.Charset.Charset>(LocalBridgeClazz, "UTF_16BE"); _UTF_16BEReady = true; } return _UTF_16BEContent; } }
        private static Java.Nio.Charset.Charset _UTF_16BEContent = default;
        private static bool _UTF_16BEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/StandardCharsets.html#UTF_16LE"/>
        /// </summary>
        public static Java.Nio.Charset.Charset UTF_16LE { get { if (!_UTF_16LEReady) { _UTF_16LEContent = SGetField<Java.Nio.Charset.Charset>(LocalBridgeClazz, "UTF_16LE"); _UTF_16LEReady = true; } return _UTF_16LEContent; } }
        private static Java.Nio.Charset.Charset _UTF_16LEContent = default;
        private static bool _UTF_16LEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/StandardCharsets.html#UTF_8"/>
        /// </summary>
        public static Java.Nio.Charset.Charset UTF_8 { get { if (!_UTF_8Ready) { _UTF_8Content = SGetField<Java.Nio.Charset.Charset>(LocalBridgeClazz, "UTF_8"); _UTF_8Ready = true; } return _UTF_8Content; } }
        private static Java.Nio.Charset.Charset _UTF_8Content = default;
        private static bool _UTF_8Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}