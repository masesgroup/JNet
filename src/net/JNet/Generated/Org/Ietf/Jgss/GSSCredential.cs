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

namespace Org.Ietf.Jgss
{
    #region GSSCredential
    public partial class GSSCredential
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Ietf.Jgss.GSSCredential"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Org.Ietf.Jgss.GSSCredential t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#ACCEPT_ONLY"/>
        /// </summary>
        public static int ACCEPT_ONLY => Clazz.GetField<int>("ACCEPT_ONLY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#DEFAULT_LIFETIME"/>
        /// </summary>
        public static int DEFAULT_LIFETIME => Clazz.GetField<int>("DEFAULT_LIFETIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#INDEFINITE_LIFETIME"/>
        /// </summary>
        public static int INDEFINITE_LIFETIME => Clazz.GetField<int>("INDEFINITE_LIFETIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#INITIATE_AND_ACCEPT"/>
        /// </summary>
        public static int INITIATE_AND_ACCEPT => Clazz.GetField<int>("INITIATE_AND_ACCEPT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#INITIATE_ONLY"/>
        /// </summary>
        public static int INITIATE_ONLY => Clazz.GetField<int>("INITIATE_ONLY");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getMechs()"/> 
        /// </summary>
        public Org.Ietf.Jgss.Oid[] Mechs
        {
            get { return IExecuteArray<Org.Ietf.Jgss.Oid>("getMechs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getName()"/> 
        /// </summary>
        public Org.Ietf.Jgss.GSSName Name
        {
            get { return IExecute<Org.Ietf.Jgss.GSSName>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getRemainingLifetime()"/> 
        /// </summary>
        public int RemainingLifetime
        {
            get { return IExecute<int>("getRemainingLifetime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getUsage()"/> 
        /// </summary>
        public int Usage
        {
            get { return IExecute<int>("getUsage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getRemainingAcceptLifetime(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public int GetRemainingAcceptLifetime(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecute<int>("getRemainingAcceptLifetime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getRemainingInitLifetime(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public int GetRemainingInitLifetime(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecute<int>("getRemainingInitLifetime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getUsage(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public int GetUsage(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecute<int>("getUsage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getName(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSName"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSName GetName(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecute<Org.Ietf.Jgss.GSSName>("getName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#add(org.ietf.jgss.GSSName,int,int,org.ietf.jgss.Oid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.GSSName"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void Add(Org.Ietf.Jgss.GSSName arg0, int arg1, int arg2, Org.Ietf.Jgss.Oid arg3, int arg4)
        {
            IExecute("add", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#dispose()"/>
        /// </summary>
        
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
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