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

namespace Javax.Naming.Ldap
{
    #region StartTlsRequest
    public partial class StartTlsRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Naming.Ldap.ExtendedRequest(Javax.Naming.Ldap.StartTlsRequest t) => t.Cast<Javax.Naming.Ldap.ExtendedRequest>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsRequest.html#OID
        /// </summary>
        public static string OID => Clazz.GetField<string>("OID");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsRequest.html#getEncodedValue() 
        /// </summary>
        public byte[] EncodedValue
        {
            get { return IExecuteArray<byte>("getEncodedValue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsRequest.html#getID() 
        /// </summary>
        public string ID
        {
            get { return IExecute<string>("getID"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsRequest.html#createExtendedResponse(java.lang.String,byte[],int,int) throws javax.naming.NamingException
        /// </summary>
        public Javax.Naming.Ldap.ExtendedResponse CreateExtendedResponse(string arg0, byte[] arg1, int arg2, int arg3)
        {
            return IExecute<Javax.Naming.Ldap.ExtendedResponse>("createExtendedResponse", arg0, arg1, arg2, arg3);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}