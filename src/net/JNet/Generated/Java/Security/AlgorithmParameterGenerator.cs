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
    #region AlgorithmParameterGenerator
    public partial class AlgorithmParameterGenerator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameterGenerator.html#getInstance(java.lang.String,java.lang.String) throws java.security.NoSuchAlgorithmException,java.security.NoSuchProviderException
        /// </summary>
        public static Java.Security.AlgorithmParameterGenerator GetInstance(string arg0, string arg1)
        {
            return SExecute<Java.Security.AlgorithmParameterGenerator>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameterGenerator.html#getInstance(java.lang.String) throws java.security.NoSuchAlgorithmException
        /// </summary>
        public static Java.Security.AlgorithmParameterGenerator GetInstance(string arg0)
        {
            return SExecute<Java.Security.AlgorithmParameterGenerator>("getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameterGenerator.html#getAlgorithm() 
        /// </summary>
        public string Algorithm
        {
            get { return IExecute<string>("getAlgorithm"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameterGenerator.html#generateParameters()
        /// </summary>
        public Java.Security.AlgorithmParameters GenerateParameters()
        {
            return IExecute<Java.Security.AlgorithmParameters>("generateParameters");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameterGenerator.html#init(int,java.security.SecureRandom)
        /// </summary>
        public void Init(int arg0, Java.Security.SecureRandom arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameterGenerator.html#init(int)
        /// </summary>
        public void Init(int arg0)
        {
            IExecute("init", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameterGenerator.html#init(java.security.spec.AlgorithmParameterSpec,java.security.SecureRandom) throws java.security.InvalidAlgorithmParameterException
        /// </summary>
        public void Init(Java.Security.Spec.AlgorithmParameterSpec arg0, Java.Security.SecureRandom arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmParameterGenerator.html#init(java.security.spec.AlgorithmParameterSpec) throws java.security.InvalidAlgorithmParameterException
        /// </summary>
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