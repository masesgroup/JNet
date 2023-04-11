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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Float
    public partial class Float
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Float"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Float t) => t.Cast<Java.Lang.Comparable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MAX_VALUE"/>
        /// </summary>
        public static float MAX_VALUE => Clazz.GetField<float>("MAX_VALUE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MIN_NORMAL"/>
        /// </summary>
        public static float MIN_NORMAL => Clazz.GetField<float>("MIN_NORMAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MIN_VALUE"/>
        /// </summary>
        public static float MIN_VALUE => Clazz.GetField<float>("MIN_VALUE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#NaN"/>
        /// </summary>
        public static float NaN => Clazz.GetField<float>("NaN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#NEGATIVE_INFINITY"/>
        /// </summary>
        public static float NEGATIVE_INFINITY => Clazz.GetField<float>("NEGATIVE_INFINITY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#POSITIVE_INFINITY"/>
        /// </summary>
        public static float POSITIVE_INFINITY => Clazz.GetField<float>("POSITIVE_INFINITY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#BYTES"/>
        /// </summary>
        public static int BYTES => Clazz.GetField<int>("BYTES");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MAX_EXPONENT"/>
        /// </summary>
        public static int MAX_EXPONENT => Clazz.GetField<int>("MAX_EXPONENT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MIN_EXPONENT"/>
        /// </summary>
        public static int MIN_EXPONENT => Clazz.GetField<int>("MIN_EXPONENT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#SIZE"/>
        /// </summary>
        public static int SIZE => Clazz.GetField<int>("SIZE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE => Clazz.GetField<Java.Lang.Class>("TYPE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isFinite(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFinite(float arg0)
        {
            return SExecute<bool>(LocalClazz, "isFinite", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isInfinite(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInfinite(float arg0)
        {
            return SExecute<bool>(LocalClazz, "isInfinite", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isNaN(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNaN(float arg0)
        {
            return SExecute<bool>(LocalClazz, "isNaN", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#max(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Max(float arg0, float arg1)
        {
            return SExecute<float>(LocalClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#min(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Min(float arg0, float arg1)
        {
            return SExecute<float>(LocalClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#parseFloat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static float ParseFloat(string arg0)
        {
            return SExecute<float>(LocalClazz, "parseFloat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#sum(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Sum(float arg0, float arg1)
        {
            return SExecute<float>(LocalClazz, "sum", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#compare(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(float arg0, float arg1)
        {
            return SExecute<int>(LocalClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#floatToIntBits(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloatToIntBits(float arg0)
        {
            return SExecute<int>(LocalClazz, "floatToIntBits", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#hashCode(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(float arg0)
        {
            return SExecute<int>(LocalClazz, "hashCode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#valueOf(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float? ValueOf(float arg0)
        {
            return SExecute<float?>(LocalClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static float? ValueOf(string arg0)
        {
            return SExecute<float?>(LocalClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#toHexString(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToHexString(float arg0)
        {
            return SExecute<string>(LocalClazz, "toHexString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#toString(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToString(float arg0)
        {
            return SExecute<string>(LocalClazz, "toString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#intBitsToFloat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public static float IntBitsToFloat(int arg0)
        {
            return SExecute<float>(LocalClazz, "intBitsToFloat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#floatToRawIntBits(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloatToRawIntBits(float arg0)
        {
            return SExecute<int>(LocalClazz, "floatToRawIntBits", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isInfinite()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsInfinite()
        {
            return IExecute<bool>("isInfinite");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isNaN()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsNaN()
        {
            return IExecute<bool>("isNaN");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#compareTo(java.lang.Float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(float? arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#compareTo(java.lang.Object)"/>
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