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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Ldap
{
    #region SortResponseControl
    public partial class SortResponseControl
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/SortResponseControl.html#%3Cinit%3E(java.lang.String,boolean,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public SortResponseControl(string arg0, bool arg1, byte[] arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/SortResponseControl.html#OID"/>
        /// </summary>
        public static string OID { get { return SGetField<string>(LocalBridgeClazz, "OID"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/SortResponseControl.html#getAttributeID()"/> 
        /// </summary>
        public string AttributeID
        {
            get { return IExecute<string>("getAttributeID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/SortResponseControl.html#getException()"/> 
        /// </summary>
        public Javax.Naming.NamingException Exception
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Javax.Naming.NamingException>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/SortResponseControl.html#getResultCode()"/> 
        /// </summary>
        public int ResultCode
        {
            get { return IExecute<int>("getResultCode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/SortResponseControl.html#isSorted()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSorted()
        {
            return IExecute<bool>("isSorted");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}