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

namespace Javax.Security.Auth.Kerberos
{
    #region KeyTab
    public partial class KeyTab
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getUnboundInstance() 
        /// </summary>
        public static Javax.Security.Auth.Kerberos.KeyTab UnboundInstance
        {
            get { return SExecute<Javax.Security.Auth.Kerberos.KeyTab>("getUnboundInstance"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getInstance()
        /// </summary>
        public static Javax.Security.Auth.Kerberos.KeyTab GetInstance()
        {
            return SExecute<Javax.Security.Auth.Kerberos.KeyTab>("getInstance");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getInstance(java.io.File)
        /// </summary>
        public static Javax.Security.Auth.Kerberos.KeyTab GetInstance(Java.Io.File arg0)
        {
            return SExecute<Javax.Security.Auth.Kerberos.KeyTab>("getInstance", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getInstance(javax.security.auth.kerberos.KerberosPrincipal,java.io.File)
        /// </summary>
        public static Javax.Security.Auth.Kerberos.KeyTab GetInstance(Javax.Security.Auth.Kerberos.KerberosPrincipal arg0, Java.Io.File arg1)
        {
            return SExecute<Javax.Security.Auth.Kerberos.KeyTab>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getInstance(javax.security.auth.kerberos.KerberosPrincipal)
        /// </summary>
        public static Javax.Security.Auth.Kerberos.KeyTab GetInstance(Javax.Security.Auth.Kerberos.KerberosPrincipal arg0)
        {
            return SExecute<Javax.Security.Auth.Kerberos.KeyTab>("getInstance", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getUnboundInstance(java.io.File)
        /// </summary>
        public static Javax.Security.Auth.Kerberos.KeyTab GetUnboundInstance(Java.Io.File arg0)
        {
            return SExecute<Javax.Security.Auth.Kerberos.KeyTab>("getUnboundInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getPrincipal() 
        /// </summary>
        public Javax.Security.Auth.Kerberos.KerberosPrincipal Principal
        {
            get { return IExecute<Javax.Security.Auth.Kerberos.KerberosPrincipal>("getPrincipal"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#exists()
        /// </summary>
        public bool Exists()
        {
            return IExecute<bool>("exists");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#isBound()
        /// </summary>
        public bool IsBound()
        {
            return IExecute<bool>("isBound");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getKeys(javax.security.auth.kerberos.KerberosPrincipal)
        /// </summary>
        public Javax.Security.Auth.Kerberos.KerberosKey[] GetKeys(Javax.Security.Auth.Kerberos.KerberosPrincipal arg0)
        {
            return IExecuteArray<Javax.Security.Auth.Kerberos.KerberosKey>("getKeys", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}