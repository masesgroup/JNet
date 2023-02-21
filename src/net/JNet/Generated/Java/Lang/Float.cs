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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
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

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#POSITIVE_INFINITY
        /// </summary>
        public static float POSITIVE_INFINITY => Clazz.GetField<float>("POSITIVE_INFINITY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#NEGATIVE_INFINITY
        /// </summary>
        public static float NEGATIVE_INFINITY => Clazz.GetField<float>("NEGATIVE_INFINITY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#NaN
        /// </summary>
        public static float NaN => Clazz.GetField<float>("NaN");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MAX_VALUE
        /// </summary>
        public static float MAX_VALUE => Clazz.GetField<float>("MAX_VALUE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MIN_NORMAL
        /// </summary>
        public static float MIN_NORMAL => Clazz.GetField<float>("MIN_NORMAL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MIN_VALUE
        /// </summary>
        public static float MIN_VALUE => Clazz.GetField<float>("MIN_VALUE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MAX_EXPONENT
        /// </summary>
        public static int MAX_EXPONENT => Clazz.GetField<int>("MAX_EXPONENT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MIN_EXPONENT
        /// </summary>
        public static int MIN_EXPONENT => Clazz.GetField<int>("MIN_EXPONENT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#SIZE
        /// </summary>
        public static int SIZE => Clazz.GetField<int>("SIZE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#BYTES
        /// </summary>
        public static int BYTES => Clazz.GetField<int>("BYTES");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#TYPE
        /// </summary>
        public static Java.Lang.Class TYPE => Clazz.GetField<Java.Lang.Class>("TYPE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isFinite(float)
        /// </summary>
        public static bool IsFinite(float arg0)
        {
            return SExecute<bool>("isFinite", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isInfinite(float)
        /// </summary>
        public static bool IsInfinite(float arg0)
        {
            return SExecute<bool>("isInfinite", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isNaN(float)
        /// </summary>
        public static bool IsNaN(float arg0)
        {
            return SExecute<bool>("isNaN", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#max(float,float)
        /// </summary>
        public static float Max(float arg0, float arg1)
        {
            return SExecute<float>("max", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#min(float,float)
        /// </summary>
        public static float Min(float arg0, float arg1)
        {
            return SExecute<float>("min", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#parseFloat(java.lang.String) throws java.lang.NumberFormatException
        /// </summary>
        public static float ParseFloat(string arg0)
        {
            return SExecute<float>("parseFloat", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#sum(float,float)
        /// </summary>
        public static float Sum(float arg0, float arg1)
        {
            return SExecute<float>("sum", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#compare(float,float)
        /// </summary>
        public static int Compare(float arg0, float arg1)
        {
            return SExecute<int>("compare", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#floatToIntBits(float)
        /// </summary>
        public static int FloatToIntBits(float arg0)
        {
            return SExecute<int>("floatToIntBits", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#hashCode(float)
        /// </summary>
        public static int HashCode(float arg0)
        {
            return SExecute<int>("hashCode", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#valueOf(float)
        /// </summary>
        public static float ValueOf(float arg0)
        {
            return SExecute<float>("valueOf", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#valueOf(java.lang.String) throws java.lang.NumberFormatException
        /// </summary>
        public static float ValueOf(string arg0)
        {
            return SExecute<float>("valueOf", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#toHexString(float)
        /// </summary>
        public static string ToHexString(float arg0)
        {
            return SExecute<string>("toHexString", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#toString(float)
        /// </summary>
        public static string ToString(float arg0)
        {
            return SExecute<string>("toString", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#intBitsToFloat(int)
        /// </summary>
        public static float IntBitsToFloat(int arg0)
        {
            return SExecute<float>("intBitsToFloat", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#floatToRawIntBits(float)
        /// </summary>
        public static int FloatToRawIntBits(float arg0)
        {
            return SExecute<int>("floatToRawIntBits", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isInfinite()
        /// </summary>
        public bool IsInfinite()
        {
            return IExecute<bool>("isInfinite");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isNaN()
        /// </summary>
        public bool IsNaN()
        {
            return IExecute<bool>("isNaN");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#compareTo(java.lang.Float)
        /// </summary>
        public int CompareTo(float arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#compareTo(java.lang.Object)
        /// </summary>
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