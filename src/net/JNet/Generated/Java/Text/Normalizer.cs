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

namespace Java.Text
{
    #region Normalizer
    public partial class Normalizer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.html#isNormalized(java.lang.CharSequence,java.text.Normalizer.Form)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.Normalizer.Form"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNormalized(Java.Lang.CharSequence arg0, Java.Text.Normalizer.Form arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isNormalized", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.html#normalize(java.lang.CharSequence,java.text.Normalizer.Form)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.Normalizer.Form"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Normalize(Java.Lang.CharSequence arg0, Java.Text.Normalizer.Form arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "normalize", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Form
        public partial class Form
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#NFC"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFC { get { if (!_NFCReady) { _NFCContent = SGetField<Java.Text.Normalizer.Form>(LocalBridgeClazz, "NFC"); _NFCReady = true; } return _NFCContent; } }
            private static Java.Text.Normalizer.Form _NFCContent = default;
            private static bool _NFCReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#NFD"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFD { get { if (!_NFDReady) { _NFDContent = SGetField<Java.Text.Normalizer.Form>(LocalBridgeClazz, "NFD"); _NFDReady = true; } return _NFDContent; } }
            private static Java.Text.Normalizer.Form _NFDContent = default;
            private static bool _NFDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#NFKC"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFKC { get { if (!_NFKCReady) { _NFKCContent = SGetField<Java.Text.Normalizer.Form>(LocalBridgeClazz, "NFKC"); _NFKCReady = true; } return _NFKCContent; } }
            private static Java.Text.Normalizer.Form _NFKCContent = default;
            private static bool _NFKCReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#NFKD"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFKD { get { if (!_NFKDReady) { _NFKDContent = SGetField<Java.Text.Normalizer.Form>(LocalBridgeClazz, "NFKD"); _NFKDReady = true; } return _NFKDContent; } }
            private static Java.Text.Normalizer.Form _NFKDContent = default;
            private static bool _NFKDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Text.Normalizer.Form"/></returns>
            public static Java.Text.Normalizer.Form ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Text.Normalizer.Form>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/text/Normalizer$Form;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Text.Normalizer.Form"/></returns>
            public static Java.Text.Normalizer.Form[] Values()
            {
                return SExecuteWithSignatureArray<Java.Text.Normalizer.Form>(LocalBridgeClazz, "values", "()[Ljava/text/Normalizer$Form;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}