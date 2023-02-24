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

namespace Javax.Security.Sasl
{
    #region SaslClient
    public partial class SaslClient
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClient.html#getMechanismName()"/> 
        /// </summary>
        public string MechanismName
        {
            get { return IExecute<string>("getMechanismName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClient.html#hasInitialResponse()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasInitialResponse()
        {
            return IExecute<bool>("hasInitialResponse");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClient.html#isComplete()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsComplete()
        {
            return IExecute<bool>("isComplete");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClient.html#evaluateChallenge(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        public byte[] EvaluateChallenge(byte[] arg0)
        {
            return IExecuteArray<byte>("evaluateChallenge", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClient.html#unwrap(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        public byte[] Unwrap(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("unwrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClient.html#wrap(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        public byte[] Wrap(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClient.html#getNegotiatedProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="object"/></returns>
        public object GetNegotiatedProperty(string arg0)
        {
            return IExecute("getNegotiatedProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClient.html#dispose()"/>
        /// </summary>
        
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        public new void Dispose()
        {
            IExecute("dispose");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}