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

namespace Javax.Naming.Ldap
{
    #region LdapContext
    public partial class LdapContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapContext.html#CONTROL_FACTORIES"/>
        /// </summary>
        public static string CONTROL_FACTORIES { get { return LocalClazz.GetField<string>("CONTROL_FACTORIES"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapContext.html#getConnectControls()"/> 
        /// </summary>
        public Javax.Naming.Ldap.Control[] ConnectControls
        {
            get { return IExecuteArray<Javax.Naming.Ldap.Control>("getConnectControls"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapContext.html#getRequestControls()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapContext.html#setRequestControls(javax.naming.ldap.Control[])"/>
        /// </summary>
        public Javax.Naming.Ldap.Control[] RequestControls
        {
            get { return IExecuteArray<Javax.Naming.Ldap.Control>("getRequestControls"); } set { IExecute("setRequestControls", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapContext.html#getResponseControls()"/> 
        /// </summary>
        public Javax.Naming.Ldap.Control[] ResponseControls
        {
            get { return IExecuteArray<Javax.Naming.Ldap.Control>("getResponseControls"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapContext.html#extendedOperation(javax.naming.ldap.ExtendedRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.ExtendedRequest"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.ExtendedResponse"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Ldap.ExtendedResponse ExtendedOperation(Javax.Naming.Ldap.ExtendedRequest arg0)
        {
            return IExecute<Javax.Naming.Ldap.ExtendedResponse>("extendedOperation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapContext.html#newInstance(javax.naming.ldap.Control[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.Control"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.LdapContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Ldap.LdapContext NewInstance(Javax.Naming.Ldap.Control[] arg0)
        {
            return IExecute<Javax.Naming.Ldap.LdapContext>("newInstance", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapContext.html#reconnect(javax.naming.ldap.Control[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.Control"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Reconnect(Javax.Naming.Ldap.Control[] arg0)
        {
            IExecute("reconnect", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}