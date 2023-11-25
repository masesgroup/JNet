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

namespace Javax.Security.Sasl
{
    #region ISaslServer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISaslServer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#getAuthorizationID()"/> 
        /// </summary>
        string AuthorizationID { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#getMechanismName()"/> 
        /// </summary>
        string MechanismName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#isComplete()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsComplete();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#evaluateResponse(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        byte[] EvaluateResponse(byte[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#unwrap(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        byte[] Unwrap(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#wrap(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        byte[] Wrap(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#getNegotiatedProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetNegotiatedProperty(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#dispose()"/>
        /// </summary>

        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        void Dispose();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SaslServer
    public partial class SaslServer : Javax.Security.Sasl.ISaslServer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#getAuthorizationID()"/> 
        /// </summary>
        public string AuthorizationID
        {
            get { return IExecute<string>("getAuthorizationID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#getMechanismName()"/> 
        /// </summary>
        public string MechanismName
        {
            get { return IExecute<string>("getMechanismName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#isComplete()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsComplete()
        {
            return IExecute<bool>("isComplete");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#evaluateResponse(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        public byte[] EvaluateResponse(byte[] arg0)
        {
            return IExecuteArray<byte>("evaluateResponse", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#unwrap(byte[],int,int)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#wrap(byte[],int,int)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#getNegotiatedProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetNegotiatedProperty(string arg0)
        {
            return IExecute("getNegotiatedProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServer.html#dispose()"/>
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