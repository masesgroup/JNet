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

namespace Javax.Crypto.Spec
{
    #region PBEParameterSpec
    public partial class PBEParameterSpec
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/PBEParameterSpec.html#<init>(byte[],int)
        /// </summary>
        public PBEParameterSpec(byte[] arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/PBEParameterSpec.html#<init>(byte[],int,java.security.spec.AlgorithmParameterSpec)
        /// </summary>
        public PBEParameterSpec(byte[] arg0, int arg1, Java.Security.Spec.AlgorithmParameterSpec arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Security.Spec.AlgorithmParameterSpec(Javax.Crypto.Spec.PBEParameterSpec t) => t.Cast<Java.Security.Spec.AlgorithmParameterSpec>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/PBEParameterSpec.html#getIterationCount() 
        /// </summary>
        public int IterationCount
        {
            get { return IExecute<int>("getIterationCount"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/PBEParameterSpec.html#getParameterSpec() 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec ParameterSpec
        {
            get { return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getParameterSpec"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/PBEParameterSpec.html#getSalt() 
        /// </summary>
        public byte[] Salt
        {
            get { return IExecuteArray<byte>("getSalt"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}