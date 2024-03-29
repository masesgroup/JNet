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

namespace Org.Ietf.Jgss
{
    #region IGSSContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IGSSContext
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getAnonymityState()"/> 
        /// </summary>
        bool AnonymityState { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getConfState()"/> 
        /// </summary>
        bool ConfState { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getCredDelegState()"/> 
        /// </summary>
        bool CredDelegState { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getDelegCred()"/> 
        /// </summary>
        Org.Ietf.Jgss.GSSCredential DelegCred { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getIntegState()"/> 
        /// </summary>
        bool IntegState { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getLifetime()"/> 
        /// </summary>
        int Lifetime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getMech()"/> 
        /// </summary>
        Org.Ietf.Jgss.Oid Mech { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getMutualAuthState()"/> 
        /// </summary>
        bool MutualAuthState { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getReplayDetState()"/> 
        /// </summary>
        bool ReplayDetState { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getSequenceDetState()"/> 
        /// </summary>
        bool SequenceDetState { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getSrcName()"/> 
        /// </summary>
        Org.Ietf.Jgss.GSSName SrcName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getTargName()"/> 
        /// </summary>
        Org.Ietf.Jgss.GSSName TargName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isEstablished()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsEstablished();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isInitiator()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        bool IsInitiator();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isProtReady()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsProtReady();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isTransferable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        bool IsTransferable();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#acceptSecContext(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        byte[] AcceptSecContext(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#export()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        byte[] Export();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getMIC(byte[],int,int,org.ietf.jgss.MessageProp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Ietf.Jgss.MessageProp"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        byte[] GetMIC(byte[] arg0, int arg1, int arg2, Org.Ietf.Jgss.MessageProp arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#initSecContext(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        byte[] InitSecContext(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#unwrap(byte[],int,int,org.ietf.jgss.MessageProp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Ietf.Jgss.MessageProp"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        byte[] Unwrap(byte[] arg0, int arg1, int arg2, Org.Ietf.Jgss.MessageProp arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#wrap(byte[],int,int,org.ietf.jgss.MessageProp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Ietf.Jgss.MessageProp"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        byte[] Wrap(byte[] arg0, int arg1, int arg2, Org.Ietf.Jgss.MessageProp arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getWrapSizeLimit(int,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        int GetWrapSizeLimit(int arg0, bool arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#dispose()"/>
        /// </summary>

        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void Dispose();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestAnonymity(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void RequestAnonymity(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestConf(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void RequestConf(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestCredDeleg(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void RequestCredDeleg(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestInteg(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void RequestInteg(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestLifetime(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void RequestLifetime(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestMutualAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void RequestMutualAuth(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestReplayDet(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void RequestReplayDet(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestSequenceDet(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void RequestSequenceDet(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#setChannelBinding(org.ietf.jgss.ChannelBinding)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.ChannelBinding"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void SetChannelBinding(Org.Ietf.Jgss.ChannelBinding arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#verifyMIC(byte[],int,int,byte[],int,int,org.ietf.jgss.MessageProp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Org.Ietf.Jgss.MessageProp"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void VerifyMIC(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4, int arg5, Org.Ietf.Jgss.MessageProp arg6);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region GSSContext
    public partial class GSSContext : Org.Ietf.Jgss.IGSSContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#DEFAULT_LIFETIME"/>
        /// </summary>
        public static int DEFAULT_LIFETIME { get { if (!_DEFAULT_LIFETIMEReady) { _DEFAULT_LIFETIMEContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_LIFETIME"); _DEFAULT_LIFETIMEReady = true; } return _DEFAULT_LIFETIMEContent; } }
        private static int _DEFAULT_LIFETIMEContent = default;
        private static bool _DEFAULT_LIFETIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#INDEFINITE_LIFETIME"/>
        /// </summary>
        public static int INDEFINITE_LIFETIME { get { if (!_INDEFINITE_LIFETIMEReady) { _INDEFINITE_LIFETIMEContent = SGetField<int>(LocalBridgeClazz, "INDEFINITE_LIFETIME"); _INDEFINITE_LIFETIMEReady = true; } return _INDEFINITE_LIFETIMEContent; } }
        private static int _INDEFINITE_LIFETIMEContent = default;
        private static bool _INDEFINITE_LIFETIMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getAnonymityState()"/> 
        /// </summary>
        public bool AnonymityState
        {
            get { return IExecuteWithSignature<bool>("getAnonymityState", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getConfState()"/> 
        /// </summary>
        public bool ConfState
        {
            get { return IExecuteWithSignature<bool>("getConfState", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getCredDelegState()"/> 
        /// </summary>
        public bool CredDelegState
        {
            get { return IExecuteWithSignature<bool>("getCredDelegState", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getDelegCred()"/> 
        /// </summary>
        public Org.Ietf.Jgss.GSSCredential DelegCred
        {
            get { return IExecuteWithSignature<Org.Ietf.Jgss.GSSCredential>("getDelegCred", "()Lorg/ietf/jgss/GSSCredential;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getIntegState()"/> 
        /// </summary>
        public bool IntegState
        {
            get { return IExecuteWithSignature<bool>("getIntegState", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getLifetime()"/> 
        /// </summary>
        public int Lifetime
        {
            get { return IExecuteWithSignature<int>("getLifetime", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getMech()"/> 
        /// </summary>
        public Org.Ietf.Jgss.Oid Mech
        {
            get { return IExecuteWithSignature<Org.Ietf.Jgss.Oid>("getMech", "()Lorg/ietf/jgss/Oid;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getMutualAuthState()"/> 
        /// </summary>
        public bool MutualAuthState
        {
            get { return IExecuteWithSignature<bool>("getMutualAuthState", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getReplayDetState()"/> 
        /// </summary>
        public bool ReplayDetState
        {
            get { return IExecuteWithSignature<bool>("getReplayDetState", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getSequenceDetState()"/> 
        /// </summary>
        public bool SequenceDetState
        {
            get { return IExecuteWithSignature<bool>("getSequenceDetState", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getSrcName()"/> 
        /// </summary>
        public Org.Ietf.Jgss.GSSName SrcName
        {
            get { return IExecuteWithSignature<Org.Ietf.Jgss.GSSName>("getSrcName", "()Lorg/ietf/jgss/GSSName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getTargName()"/> 
        /// </summary>
        public Org.Ietf.Jgss.GSSName TargName
        {
            get { return IExecuteWithSignature<Org.Ietf.Jgss.GSSName>("getTargName", "()Lorg/ietf/jgss/GSSName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isEstablished()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEstablished()
        {
            return IExecuteWithSignature<bool>("isEstablished", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isInitiator()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public bool IsInitiator()
        {
            return IExecuteWithSignature<bool>("isInitiator", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isProtReady()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsProtReady()
        {
            return IExecuteWithSignature<bool>("isProtReady", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isTransferable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public bool IsTransferable()
        {
            return IExecuteWithSignature<bool>("isTransferable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#acceptSecContext(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public byte[] AcceptSecContext(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("acceptSecContext", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#export()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public byte[] Export()
        {
            return IExecuteWithSignatureArray<byte>("export", "()[B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getMIC(byte[],int,int,org.ietf.jgss.MessageProp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Ietf.Jgss.MessageProp"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public byte[] GetMIC(byte[] arg0, int arg1, int arg2, Org.Ietf.Jgss.MessageProp arg3)
        {
            return IExecuteArray<byte>("getMIC", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#initSecContext(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public byte[] InitSecContext(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("initSecContext", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#unwrap(byte[],int,int,org.ietf.jgss.MessageProp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Ietf.Jgss.MessageProp"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public byte[] Unwrap(byte[] arg0, int arg1, int arg2, Org.Ietf.Jgss.MessageProp arg3)
        {
            return IExecuteArray<byte>("unwrap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#wrap(byte[],int,int,org.ietf.jgss.MessageProp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Ietf.Jgss.MessageProp"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public byte[] Wrap(byte[] arg0, int arg1, int arg2, Org.Ietf.Jgss.MessageProp arg3)
        {
            return IExecuteArray<byte>("wrap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getWrapSizeLimit(int,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public int GetWrapSizeLimit(int arg0, bool arg1, int arg2)
        {
            return IExecute<int>("getWrapSizeLimit", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#dispose()"/>
        /// </summary>

        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestAnonymity(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestAnonymity(bool arg0)
        {
            IExecuteWithSignature("requestAnonymity", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestConf(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestConf(bool arg0)
        {
            IExecuteWithSignature("requestConf", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestCredDeleg(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestCredDeleg(bool arg0)
        {
            IExecuteWithSignature("requestCredDeleg", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestInteg(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestInteg(bool arg0)
        {
            IExecuteWithSignature("requestInteg", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestLifetime(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestLifetime(int arg0)
        {
            IExecuteWithSignature("requestLifetime", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestMutualAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestMutualAuth(bool arg0)
        {
            IExecuteWithSignature("requestMutualAuth", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestReplayDet(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestReplayDet(bool arg0)
        {
            IExecuteWithSignature("requestReplayDet", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestSequenceDet(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestSequenceDet(bool arg0)
        {
            IExecuteWithSignature("requestSequenceDet", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#setChannelBinding(org.ietf.jgss.ChannelBinding)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.ChannelBinding"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void SetChannelBinding(Org.Ietf.Jgss.ChannelBinding arg0)
        {
            IExecuteWithSignature("setChannelBinding", "(Lorg/ietf/jgss/ChannelBinding;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#verifyMIC(byte[],int,int,byte[],int,int,org.ietf.jgss.MessageProp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Org.Ietf.Jgss.MessageProp"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void VerifyMIC(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4, int arg5, Org.Ietf.Jgss.MessageProp arg6)
        {
            IExecute("verifyMIC", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}