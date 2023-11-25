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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Crypto.Spec
{
    #region PSource
    public partial class PSource
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/PSource.html#getAlgorithm()"/> 
        /// </summary>
        public string Algorithm
        {
            get { return IExecute<string>("getAlgorithm"); }
        }

        #endregion

        #region Nested classes
        #region PSpecified
        public partial class PSpecified
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/PSource.PSpecified.html#%3Cinit%3E(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            public PSpecified(byte[] arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/PSource.PSpecified.html#DEFAULT"/>
            /// </summary>
            public static Javax.Crypto.Spec.PSource.PSpecified DEFAULT { get { return SGetField<Javax.Crypto.Spec.PSource.PSpecified>(LocalBridgeClazz, "DEFAULT"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/PSource.PSpecified.html#getValue()"/> 
            /// </summary>
            public byte[] Value
            {
                get { return IExecuteArray<byte>("getValue"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}