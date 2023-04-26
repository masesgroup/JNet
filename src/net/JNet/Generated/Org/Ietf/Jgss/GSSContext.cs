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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Ietf.Jgss
{
    #region GSSContext
    public partial class GSSContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#DEFAULT_LIFETIME"/>
        /// </summary>
        public static int DEFAULT_LIFETIME => LocalClazz.GetField<int>("DEFAULT_LIFETIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#INDEFINITE_LIFETIME"/>
        /// </summary>
        public static int INDEFINITE_LIFETIME => LocalClazz.GetField<int>("INDEFINITE_LIFETIME");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getAnonymityState()"/> 
        /// </summary>
        public bool AnonymityState
        {
            get { return IExecute<bool>("getAnonymityState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getConfState()"/> 
        /// </summary>
        public bool ConfState
        {
            get { return IExecute<bool>("getConfState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getCredDelegState()"/> 
        /// </summary>
        public bool CredDelegState
        {
            get { return IExecute<bool>("getCredDelegState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getDelegCred()"/> 
        /// </summary>
        public Org.Ietf.Jgss.GSSCredential DelegCred
        {
            get { return IExecute<Org.Ietf.Jgss.GSSCredential>("getDelegCred"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#export()"/> 
        /// </summary>
        public byte[] Export
        {
            get { return IExecuteArray<byte>("export"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getIntegState()"/> 
        /// </summary>
        public bool IntegState
        {
            get { return IExecute<bool>("getIntegState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isEstablished()"/> 
        /// </summary>
        public bool IsEstablished
        {
            get { return IExecute<bool>("isEstablished"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isInitiator()"/> 
        /// </summary>
        public bool IsInitiator
        {
            get { return IExecute<bool>("isInitiator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isProtReady()"/> 
        /// </summary>
        public bool IsProtReady
        {
            get { return IExecute<bool>("isProtReady"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#isTransferable()"/> 
        /// </summary>
        public bool IsTransferable
        {
            get { return IExecute<bool>("isTransferable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getLifetime()"/> 
        /// </summary>
        public int Lifetime
        {
            get { return IExecute<int>("getLifetime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getMech()"/> 
        /// </summary>
        public Org.Ietf.Jgss.Oid Mech
        {
            get { return IExecute<Org.Ietf.Jgss.Oid>("getMech"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getMutualAuthState()"/> 
        /// </summary>
        public bool MutualAuthState
        {
            get { return IExecute<bool>("getMutualAuthState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getReplayDetState()"/> 
        /// </summary>
        public bool ReplayDetState
        {
            get { return IExecute<bool>("getReplayDetState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getSequenceDetState()"/> 
        /// </summary>
        public bool SequenceDetState
        {
            get { return IExecute<bool>("getSequenceDetState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getSrcName()"/> 
        /// </summary>
        public Org.Ietf.Jgss.GSSName SrcName
        {
            get { return IExecute<Org.Ietf.Jgss.GSSName>("getSrcName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#getTargName()"/> 
        /// </summary>
        public Org.Ietf.Jgss.GSSName TargName
        {
            get { return IExecute<Org.Ietf.Jgss.GSSName>("getTargName"); }
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
            IExecute("dispose");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestAnonymity(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestAnonymity(bool arg0)
        {
            IExecute("requestAnonymity", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestConf(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestConf(bool arg0)
        {
            IExecute("requestConf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestCredDeleg(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestCredDeleg(bool arg0)
        {
            IExecute("requestCredDeleg", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestInteg(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestInteg(bool arg0)
        {
            IExecute("requestInteg", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestLifetime(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestLifetime(int arg0)
        {
            IExecute("requestLifetime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestMutualAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestMutualAuth(bool arg0)
        {
            IExecute("requestMutualAuth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestReplayDet(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestReplayDet(bool arg0)
        {
            IExecute("requestReplayDet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#requestSequenceDet(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void RequestSequenceDet(bool arg0)
        {
            IExecute("requestSequenceDet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSContext.html#setChannelBinding(org.ietf.jgss.ChannelBinding)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.ChannelBinding"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void SetChannelBinding(Org.Ietf.Jgss.ChannelBinding arg0)
        {
            IExecute("setChannelBinding", arg0);
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