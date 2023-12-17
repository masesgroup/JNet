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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Short
    public partial class Short
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Short"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Short t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#BYTES"/>
        /// </summary>
        public static int BYTES { get { return SGetField<int>(LocalBridgeClazz, "BYTES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#SIZE"/>
        /// </summary>
        public static int SIZE { get { return SGetField<int>(LocalBridgeClazz, "SIZE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { return SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#MAX_VALUE"/>
        /// </summary>
        public static short MAX_VALUE { get { return SGetField<short>(LocalBridgeClazz, "MAX_VALUE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#MIN_VALUE"/>
        /// </summary>
        public static short MIN_VALUE { get { return SGetField<short>(LocalBridgeClazz, "MIN_VALUE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#compare(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(short arg0, short arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#compareUnsigned(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CompareUnsigned(short arg0, short arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compareUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#hashCode(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(short arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "hashCode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#toUnsignedInt(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ToUnsignedInt(short arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "toUnsignedInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#decode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Short"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Short Decode(string arg0)
        {
            return SExecute<Java.Lang.Short>(LocalBridgeClazz, "decode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#valueOf(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Short"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Short ValueOf(string arg0, int arg1)
        {
            return SExecute<Java.Lang.Short>(LocalBridgeClazz, "valueOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Short"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Short ValueOf(string arg0)
        {
            return SExecute<Java.Lang.Short>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#valueOf(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Lang.Short"/></returns>
        public static Java.Lang.Short ValueOf(short arg0)
        {
            return SExecute<Java.Lang.Short>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#toString(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToString(short arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#toUnsignedLong(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="long"/></returns>
        public static long ToUnsignedLong(short arg0)
        {
            return SExecute<long>(LocalBridgeClazz, "toUnsignedLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#parseShort(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static short ParseShort(string arg0, int arg1)
        {
            return SExecute<short>(LocalBridgeClazz, "parseShort", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#parseShort(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static short ParseShort(string arg0)
        {
            return SExecute<short>(LocalBridgeClazz, "parseShort", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#reverseBytes(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short ReverseBytes(short arg0)
        {
            return SExecute<short>(LocalBridgeClazz, "reverseBytes", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Short.html#compareTo(java.lang.Short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Short"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Short arg0)
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