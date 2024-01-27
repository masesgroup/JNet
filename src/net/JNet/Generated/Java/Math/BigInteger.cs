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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Math
{
    #region BigInteger
    public partial class BigInteger
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#%3Cinit%3E(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BigInteger(byte[] arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public BigInteger(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#%3Cinit%3E(int,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public BigInteger(int arg0, byte[] arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#%3Cinit%3E(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public BigInteger(int arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#%3Cinit%3E(int,int,java.util.Random)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Random"/></param>
        public BigInteger(int arg0, int arg1, Java.Util.Random arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#%3Cinit%3E(int,java.util.Random)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Random"/></param>
        public BigInteger(int arg0, Java.Util.Random arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public BigInteger(string arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public BigInteger(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Math.BigInteger"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Math.BigInteger t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#ONE"/>
        /// </summary>
        public static Java.Math.BigInteger ONE { get { if (!_ONEReady) { _ONEContent = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "ONE"); _ONEReady = true; } return _ONEContent; } }
        private static Java.Math.BigInteger _ONEContent = default;
        private static bool _ONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#TEN"/>
        /// </summary>
        public static Java.Math.BigInteger TEN { get { if (!_TENReady) { _TENContent = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "TEN"); _TENReady = true; } return _TENContent; } }
        private static Java.Math.BigInteger _TENContent = default;
        private static bool _TENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#TWO"/>
        /// </summary>
        public static Java.Math.BigInteger TWO { get { if (!_TWOReady) { _TWOContent = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "TWO"); _TWOReady = true; } return _TWOContent; } }
        private static Java.Math.BigInteger _TWOContent = default;
        private static bool _TWOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#ZERO"/>
        /// </summary>
        public static Java.Math.BigInteger ZERO { get { if (!_ZEROReady) { _ZEROContent = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "ZERO"); _ZEROReady = true; } return _ZEROContent; } }
        private static Java.Math.BigInteger _ZEROContent = default;
        private static bool _ZEROReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#probablePrime(int,java.util.Random)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Random"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public static Java.Math.BigInteger ProbablePrime(int arg0, Java.Util.Random arg1)
        {
            return SExecute<Java.Math.BigInteger>(LocalBridgeClazz, "probablePrime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#valueOf(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public static Java.Math.BigInteger ValueOf(long arg0)
        {
            return SExecute<Java.Math.BigInteger>(LocalBridgeClazz, "valueOf", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#getLowestSetBit()"/> 
        /// </summary>
        public int LowestSetBit
        {
            get { return IExecute<int>("getLowestSetBit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#isProbablePrime(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsProbablePrime(int arg0)
        {
            return IExecute<bool>("isProbablePrime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#testBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool TestBit(int arg0)
        {
            return IExecute<bool>("testBit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#byteValueExact()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte ByteValueExact()
        {
            return IExecute<byte>("byteValueExact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#toByteArray()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte[] ToByteArray()
        {
            return IExecuteArray<byte>("toByteArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#bitCount()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int BitCount()
        {
            return IExecute<int>("bitCount");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#bitLength()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int BitLength()
        {
            return IExecute<int>("bitLength");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#compareTo(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Math.BigInteger arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#intValueExact()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int IntValueExact()
        {
            return IExecute<int>("intValueExact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#signum()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Signum()
        {
            return IExecute<int>("signum");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#toString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ToString(int arg0)
        {
            return IExecute<string>("toString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#abs()"/>
        /// </summary>

        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Abs()
        {
            return IExecute<Java.Math.BigInteger>("abs");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#add(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Add(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#and(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger And(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("and", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#andNot(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger AndNot(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("andNot", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#clearBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ClearBit(int arg0)
        {
            return IExecute<Java.Math.BigInteger>("clearBit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#divide(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Divide(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("divide", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#flipBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger FlipBit(int arg0)
        {
            return IExecute<Java.Math.BigInteger>("flipBit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#gcd(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Gcd(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("gcd", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#max(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Max(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("max", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#min(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Min(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("min", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#mod(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Mod(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("mod", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#modInverse(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ModInverse(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("modInverse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#modPow(java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ModPow(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1)
        {
            return IExecute<Java.Math.BigInteger>("modPow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#multiply(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Multiply(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("multiply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Negate()
        {
            return IExecute<Java.Math.BigInteger>("negate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#nextProbablePrime()"/>
        /// </summary>

        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger NextProbablePrime()
        {
            return IExecute<Java.Math.BigInteger>("nextProbablePrime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#not()"/>
        /// </summary>

        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Not()
        {
            return IExecute<Java.Math.BigInteger>("not");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#or(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Or(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("or", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#pow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Pow(int arg0)
        {
            return IExecute<Java.Math.BigInteger>("pow", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#remainder(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Remainder(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("remainder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#setBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger SetBit(int arg0)
        {
            return IExecute<Java.Math.BigInteger>("setBit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#shiftLeft(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ShiftLeft(int arg0)
        {
            return IExecute<Java.Math.BigInteger>("shiftLeft", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#shiftRight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ShiftRight(int arg0)
        {
            return IExecute<Java.Math.BigInteger>("shiftRight", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#sqrt()"/>
        /// </summary>

        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Sqrt()
        {
            return IExecute<Java.Math.BigInteger>("sqrt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#subtract(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Subtract(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("subtract", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#xor(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Xor(Java.Math.BigInteger arg0)
        {
            return IExecute<Java.Math.BigInteger>("xor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#divideAndRemainder(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger[] DivideAndRemainder(Java.Math.BigInteger arg0)
        {
            return IExecuteArray<Java.Math.BigInteger>("divideAndRemainder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#sqrtAndRemainder()"/>
        /// </summary>

        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger[] SqrtAndRemainder()
        {
            return IExecuteArray<Java.Math.BigInteger>("sqrtAndRemainder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#longValueExact()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LongValueExact()
        {
            return IExecute<long>("longValueExact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html#shortValueExact()"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        public short ShortValueExact()
        {
            return IExecute<short>("shortValueExact");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}