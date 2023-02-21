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
    #region PagedResultsControl
    public partial class PagedResultsControl
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/PagedResultsControl.html#<init>(int,boolean) throws java.io.IOException
        /// </summary>
        public PagedResultsControl(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/PagedResultsControl.html#<init>(int,byte[],boolean) throws java.io.IOException
        /// </summary>
        public PagedResultsControl(int arg0, byte[] arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/PagedResultsControl.html#OID
        /// </summary>
        public static string OID => Clazz.GetField<string>("OID");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}