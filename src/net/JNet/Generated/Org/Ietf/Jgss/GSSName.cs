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
    #region GSSName
    public partial class GSSName
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#NT_ANONYMOUS"/>
        /// </summary>
        public static Org.Ietf.Jgss.Oid NT_ANONYMOUS => Clazz.GetField<Org.Ietf.Jgss.Oid>("NT_ANONYMOUS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#NT_EXPORT_NAME"/>
        /// </summary>
        public static Org.Ietf.Jgss.Oid NT_EXPORT_NAME => Clazz.GetField<Org.Ietf.Jgss.Oid>("NT_EXPORT_NAME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#NT_HOSTBASED_SERVICE"/>
        /// </summary>
        public static Org.Ietf.Jgss.Oid NT_HOSTBASED_SERVICE => Clazz.GetField<Org.Ietf.Jgss.Oid>("NT_HOSTBASED_SERVICE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#NT_MACHINE_UID_NAME"/>
        /// </summary>
        public static Org.Ietf.Jgss.Oid NT_MACHINE_UID_NAME => Clazz.GetField<Org.Ietf.Jgss.Oid>("NT_MACHINE_UID_NAME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#NT_STRING_UID_NAME"/>
        /// </summary>
        public static Org.Ietf.Jgss.Oid NT_STRING_UID_NAME => Clazz.GetField<Org.Ietf.Jgss.Oid>("NT_STRING_UID_NAME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#NT_USER_NAME"/>
        /// </summary>
        public static Org.Ietf.Jgss.Oid NT_USER_NAME => Clazz.GetField<Org.Ietf.Jgss.Oid>("NT_USER_NAME");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#getStringNameType()"/> 
        /// </summary>
        public Org.Ietf.Jgss.Oid StringNameType
        {
            get { return IExecute<Org.Ietf.Jgss.Oid>("getStringNameType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#isAnonymous()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsAnonymous()
        {
            return IExecute<bool>("isAnonymous");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#isMN()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsMN()
        {
            return IExecute<bool>("isMN");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#export()"/>
        /// </summary>
        
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public byte[] Export()
        {
            return IExecuteArray<byte>("export");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSName.html#canonicalize(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSName"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSName Canonicalize(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecute<Org.Ietf.Jgss.GSSName>("canonicalize", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}