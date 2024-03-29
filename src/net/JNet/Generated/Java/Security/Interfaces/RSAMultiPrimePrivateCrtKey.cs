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

namespace Java.Security.Interfaces
{
    #region IRSAMultiPrimePrivateCrtKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRSAMultiPrimePrivateCrtKey : Java.Security.Interfaces.IRSAPrivateKey
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getCrtCoefficient()"/> 
        /// </summary>
        Java.Math.BigInteger CrtCoefficient { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getOtherPrimeInfo()"/> 
        /// </summary>
        Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentP()"/> 
        /// </summary>
        Java.Math.BigInteger PrimeExponentP { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentQ()"/> 
        /// </summary>
        Java.Math.BigInteger PrimeExponentQ { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeP()"/> 
        /// </summary>
        Java.Math.BigInteger PrimeP { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeQ()"/> 
        /// </summary>
        Java.Math.BigInteger PrimeQ { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPublicExponent()"/> 
        /// </summary>
        Java.Math.BigInteger PublicExponent { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RSAMultiPrimePrivateCrtKey
    public partial class RSAMultiPrimePrivateCrtKey : Java.Security.Interfaces.IRSAMultiPrimePrivateCrtKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID { get { if (!_serialVersionUIDReady) { _serialVersionUIDContent = SGetField<long>(LocalBridgeClazz, "serialVersionUID"); _serialVersionUIDReady = true; } return _serialVersionUIDContent; } }
        private static long _serialVersionUIDContent = default;
        private static bool _serialVersionUIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getCrtCoefficient()"/> 
        /// </summary>
        public Java.Math.BigInteger CrtCoefficient
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getCrtCoefficient", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getOtherPrimeInfo()"/> 
        /// </summary>
        public Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo
        {
            get { return IExecuteWithSignatureArray<Java.Security.Spec.RSAOtherPrimeInfo>("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentP
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentP", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentQ
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentQ", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeP
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeP", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeQ
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeQ", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPublicExponent()"/> 
        /// </summary>
        public Java.Math.BigInteger PublicExponent
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPublicExponent", "()Ljava/math/BigInteger;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}