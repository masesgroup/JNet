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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region StrictMath
    public partial class StrictMath
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#E"/>
        /// </summary>
        public static double E { get { if (!_EReady) { _EContent = SGetField<double>(LocalBridgeClazz, "E"); _EReady = true; } return _EContent; } }
        private static double _EContent = default;
        private static bool _EReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#PI"/>
        /// </summary>
        public static double PI { get { if (!_PIReady) { _PIContent = SGetField<double>(LocalBridgeClazz, "PI"); _PIReady = true; } return _PIContent; } }
        private static double _PIContent = default;
        private static bool _PIReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#abs(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Abs(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "abs", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#cbrt(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Cbrt(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "cbrt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#ceil(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Ceil(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "ceil", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#copySign(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double CopySign(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "copySign", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#exp(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Exp(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "exp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#floor(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Floor(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "floor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#fma(double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Fma(double arg0, double arg1, double arg2)
        {
            return SExecute<double>(LocalBridgeClazz, "fma", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#hypot(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Hypot(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "hypot", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#max(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Max(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#min(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Min(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#nextAfter(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double NextAfter(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "nextAfter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#nextDown(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double NextDown(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "nextDown", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#nextUp(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double NextUp(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "nextUp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#pow(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Pow(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "pow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#random()"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        public static double Random()
        {
            return SExecute<double>(LocalBridgeClazz, "random");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#rint(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Rint(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "rint", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#scalb(double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Scalb(double arg0, int arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "scalb", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#signum(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Signum(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "signum", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#ulp(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Ulp(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "ulp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#abs(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Abs(float arg0)
        {
            return SExecute<float>(LocalBridgeClazz, "abs", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#copySign(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float CopySign(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "copySign", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#fma(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Fma(float arg0, float arg1, float arg2)
        {
            return SExecute<float>(LocalBridgeClazz, "fma", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#max(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Max(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#min(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Min(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#nextAfter(float,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="float"/></returns>
        public static float NextAfter(float arg0, double arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "nextAfter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#nextDown(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float NextDown(float arg0)
        {
            return SExecute<float>(LocalBridgeClazz, "nextDown", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#nextUp(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float NextUp(float arg0)
        {
            return SExecute<float>(LocalBridgeClazz, "nextUp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#scalb(float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Scalb(float arg0, int arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "scalb", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#signum(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Signum(float arg0)
        {
            return SExecute<float>(LocalBridgeClazz, "signum", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#ulp(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Ulp(float arg0)
        {
            return SExecute<float>(LocalBridgeClazz, "ulp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#abs(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Abs(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "abs", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#addExact(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int AddExact(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "addExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#floorDiv(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloorDiv(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "floorDiv", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#floorMod(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloorMod(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "floorMod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#floorMod(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloorMod(long arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "floorMod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#getExponent(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetExponent(double arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getExponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#getExponent(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetExponent(float arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getExponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#max(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Max(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#min(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Min(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#multiplyExact(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int MultiplyExact(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "multiplyExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#round(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Round(float arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "round", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#subtractExact(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int SubtractExact(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "subtractExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#toIntExact(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ToIntExact(long arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "toIntExact", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#abs(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Abs(long arg0)
        {
            return SExecute<long>(LocalBridgeClazz, "abs", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#addExact(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long AddExact(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "addExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#floorDiv(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long FloorDiv(long arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "floorDiv", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#floorDiv(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long FloorDiv(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "floorDiv", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#floorMod(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long FloorMod(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "floorMod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#max(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Max(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#min(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Min(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#multiplyExact(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MultiplyExact(long arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "multiplyExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#multiplyExact(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MultiplyExact(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "multiplyExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#multiplyFull(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MultiplyFull(int arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "multiplyFull", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#multiplyHigh(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MultiplyHigh(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "multiplyHigh", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#round(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Round(double arg0)
        {
            return SExecute<long>(LocalBridgeClazz, "round", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#subtractExact(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long SubtractExact(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "subtractExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#acos(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Acos(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "acos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#asin(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Asin(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "asin", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#atan(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Atan(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "atan", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#atan2(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Atan2(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "atan2", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#cos(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Cos(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "cos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#cosh(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Cosh(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "cosh", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#expm1(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Expm1(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "expm1", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#IEEEremainder(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double IEEEremainder(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "IEEEremainder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#log(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Log(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "log", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#log10(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Log10(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "log10", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#log1p(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Log1p(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "log1p", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#sin(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Sin(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "sin", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#sinh(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Sinh(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "sinh", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#sqrt(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Sqrt(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "sqrt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#tan(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Tan(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "tan", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#tanh(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Tanh(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "tanh", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#toDegrees(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double ToDegrees(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "toDegrees", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StrictMath.html#toRadians(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double ToRadians(double arg0)
        {
            return SExecute<double>(LocalBridgeClazz, "toRadians", arg0);
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