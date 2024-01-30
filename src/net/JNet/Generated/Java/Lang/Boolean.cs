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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Boolean
    public partial class Boolean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Boolean"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Lang.Boolean t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Boolean"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Boolean t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#FALSE"/>
        /// </summary>
        public static Java.Lang.Boolean FALSE { get { if (!_FALSEReady) { _FALSEContent = SGetField<Java.Lang.Boolean>(LocalBridgeClazz, "FALSE"); _FALSEReady = true; } return _FALSEContent; } }
        private static Java.Lang.Boolean _FALSEContent = default;
        private static bool _FALSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#TRUE"/>
        /// </summary>
        public static Java.Lang.Boolean TRUE { get { if (!_TRUEReady) { _TRUEContent = SGetField<Java.Lang.Boolean>(LocalBridgeClazz, "TRUE"); _TRUEReady = true; } return _TRUEContent; } }
        private static Java.Lang.Boolean _TRUEContent = default;
        private static bool _TRUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { if (!_TYPEReady) { _TYPEContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); _TYPEReady = true; } return _TYPEContent; } }
        private static Java.Lang.Class _TYPEContent = default;
        private static bool _TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#getBoolean(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool GetBoolean(string arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "getBoolean", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#logicalAnd(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool LogicalAnd(bool arg0, bool arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "logicalAnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#logicalOr(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool LogicalOr(bool arg0, bool arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "logicalOr", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#logicalXor(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool LogicalXor(bool arg0, bool arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "logicalXor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#parseBoolean(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ParseBoolean(string arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "parseBoolean", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#compare(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(bool arg0, bool arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#hashCode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(bool arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "hashCode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#valueOf(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public static Java.Lang.Boolean ValueOf(bool arg0)
        {
            return SExecute<Java.Lang.Boolean>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public static Java.Lang.Boolean ValueOf(string arg0)
        {
            return SExecute<Java.Lang.Boolean>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#toString(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToString(bool arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toString", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#booleanValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool BooleanValue()
        {
            return IExecute<bool>("booleanValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#compareTo(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Boolean arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}