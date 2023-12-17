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
        public static long serialVersionUID { get { return SGetField<long>(LocalBridgeClazz, "serialVersionUID"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getCrtCoefficient()"/> 
        /// </summary>
        public Java.Math.BigInteger CrtCoefficient
        {
            get { return IExecute<Java.Math.BigInteger>("getCrtCoefficient"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getOtherPrimeInfo()"/> 
        /// </summary>
        public Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo
        {
            get { return IExecuteArray<Java.Security.Spec.RSAOtherPrimeInfo>("getOtherPrimeInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentP
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeExponentP"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentQ
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeExponentQ"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeP
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeP"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeQ
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeQ"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPublicExponent()"/> 
        /// </summary>
        public Java.Math.BigInteger PublicExponent
        {
            get { return IExecute<Java.Math.BigInteger>("getPublicExponent"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}