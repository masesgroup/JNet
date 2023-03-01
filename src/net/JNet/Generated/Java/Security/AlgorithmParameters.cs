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

namespace Java.Security
{
    #region AlgorithmParameters
    public partial class AlgorithmParameters
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.AlgorithmParameters"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.AlgorithmParameters GetInstance(string arg0, string arg1)
        {
            return SExecute<Java.Security.AlgorithmParameters>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.AlgorithmParameters"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.AlgorithmParameters GetInstance(string arg0, Java.Security.Provider arg1)
        {
            return SExecute<Java.Security.AlgorithmParameters>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.AlgorithmParameters"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.AlgorithmParameters GetInstance(string arg0)
        {
            return SExecute<Java.Security.AlgorithmParameters>("getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#getAlgorithm()"/> 
        /// </summary>
        public string Algorithm
        {
            get { return IExecute<string>("getAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteArray<byte>("getEncoded"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecute<Java.Security.Provider>("getProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#getParameterSpec(java.lang.Class%3CT%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidParameterSpecException"/>
        public Java.Security.Spec.AlgorithmParameterSpec GetParameterSpec(Java.Lang.Class arg0)
        {
            return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getParameterSpec", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#getEncoded(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] GetEncoded(string arg0)
        {
            return IExecuteArray<byte>("getEncoded", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#init(byte[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Init(byte[] arg0, string arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#init(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Init(byte[] arg0)
        {
            IExecute("init", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameters.html#init(java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.Spec.InvalidParameterSpecException"/>
        public void Init(Java.Security.Spec.AlgorithmParameterSpec arg0)
        {
            IExecute("init", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}