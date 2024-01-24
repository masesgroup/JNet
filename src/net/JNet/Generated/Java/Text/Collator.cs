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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Text
{
    #region Collator
    public partial class Collator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Text.Collator"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Text.Collator t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#CANONICAL_DECOMPOSITION"/>
        /// </summary>
        public static int CANONICAL_DECOMPOSITION { get { if (!_CANONICAL_DECOMPOSITIONReady) { _CANONICAL_DECOMPOSITIONContent = SGetField<int>(LocalBridgeClazz, "CANONICAL_DECOMPOSITION"); _CANONICAL_DECOMPOSITIONReady = true; } return _CANONICAL_DECOMPOSITIONContent; } }
        private static int _CANONICAL_DECOMPOSITIONContent = default;
        private static bool _CANONICAL_DECOMPOSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#FULL_DECOMPOSITION"/>
        /// </summary>
        public static int FULL_DECOMPOSITION { get { if (!_FULL_DECOMPOSITIONReady) { _FULL_DECOMPOSITIONContent = SGetField<int>(LocalBridgeClazz, "FULL_DECOMPOSITION"); _FULL_DECOMPOSITIONReady = true; } return _FULL_DECOMPOSITIONContent; } }
        private static int _FULL_DECOMPOSITIONContent = default;
        private static bool _FULL_DECOMPOSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#IDENTICAL"/>
        /// </summary>
        public static int IDENTICAL { get { if (!_IDENTICALReady) { _IDENTICALContent = SGetField<int>(LocalBridgeClazz, "IDENTICAL"); _IDENTICALReady = true; } return _IDENTICALContent; } }
        private static int _IDENTICALContent = default;
        private static bool _IDENTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#NO_DECOMPOSITION"/>
        /// </summary>
        public static int NO_DECOMPOSITION { get { if (!_NO_DECOMPOSITIONReady) { _NO_DECOMPOSITIONContent = SGetField<int>(LocalBridgeClazz, "NO_DECOMPOSITION"); _NO_DECOMPOSITIONReady = true; } return _NO_DECOMPOSITIONContent; } }
        private static int _NO_DECOMPOSITIONContent = default;
        private static bool _NO_DECOMPOSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#PRIMARY"/>
        /// </summary>
        public static int PRIMARY { get { if (!_PRIMARYReady) { _PRIMARYContent = SGetField<int>(LocalBridgeClazz, "PRIMARY"); _PRIMARYReady = true; } return _PRIMARYContent; } }
        private static int _PRIMARYContent = default;
        private static bool _PRIMARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#SECONDARY"/>
        /// </summary>
        public static int SECONDARY { get { if (!_SECONDARYReady) { _SECONDARYContent = SGetField<int>(LocalBridgeClazz, "SECONDARY"); _SECONDARYReady = true; } return _SECONDARYContent; } }
        private static int _SECONDARYContent = default;
        private static bool _SECONDARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#TERTIARY"/>
        /// </summary>
        public static int TERTIARY { get { if (!_TERTIARYReady) { _TERTIARYContent = SGetField<int>(LocalBridgeClazz, "TERTIARY"); _TERTIARYReady = true; } return _TERTIARYContent; } }
        private static int _TERTIARYContent = default;
        private static bool _TERTIARYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getInstance()"/> 
        /// </summary>
        public static Java.Text.Collator Instance
        {
            get { return SExecute<Java.Text.Collator>(LocalBridgeClazz, "getInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.Collator"/></returns>
        public static Java.Text.Collator GetInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.Collator>(LocalBridgeClazz, "getInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getDecomposition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#setDecomposition(int)"/>
        /// </summary>
        public int Decomposition
        {
            get { return IExecute<int>("getDecomposition"); } set { IExecute("setDecomposition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getStrength()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#setStrength(int)"/>
        /// </summary>
        public int Strength
        {
            get { return IExecute<int>("getStrength"); } set { IExecute("setStrength", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#compare(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(string arg0, string arg1)
        {
            return IExecute<int>("compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getCollationKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Text.CollationKey"/></returns>
        public Java.Text.CollationKey GetCollationKey(string arg0)
        {
            return IExecute<Java.Text.CollationKey>("getCollationKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#equals(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Equals(string arg0, string arg1)
        {
            return IExecute<bool>("equals", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#compare(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(object arg0, object arg1)
        {
            return IExecute<int>("compare", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}