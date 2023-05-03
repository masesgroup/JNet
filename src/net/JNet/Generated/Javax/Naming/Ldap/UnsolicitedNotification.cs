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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Ldap
{
    #region UnsolicitedNotification
    public partial class UnsolicitedNotification
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Ldap.UnsolicitedNotification"/> to <see cref="Javax.Naming.Ldap.ExtendedResponse"/>
        /// </summary>
        public static implicit operator Javax.Naming.Ldap.ExtendedResponse(Javax.Naming.Ldap.UnsolicitedNotification t) => t.Cast<Javax.Naming.Ldap.ExtendedResponse>();
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Ldap.UnsolicitedNotification"/> to <see cref="Javax.Naming.Ldap.HasControls"/>
        /// </summary>
        public static implicit operator Javax.Naming.Ldap.HasControls(Javax.Naming.Ldap.UnsolicitedNotification t) => t.Cast<Javax.Naming.Ldap.HasControls>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotification.html#getException()"/> 
        /// </summary>
        public Javax.Naming.NamingException Exception
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Javax.Naming.NamingException>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotification.html#getReferrals()"/> 
        /// </summary>
        public string[] Referrals
        {
            get { return IExecuteArray<string>("getReferrals"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}