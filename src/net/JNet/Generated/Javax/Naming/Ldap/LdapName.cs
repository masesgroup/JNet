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
    #region LdapName
    public partial class LdapName
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Naming.InvalidNameException"/>
        public LdapName(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#%3Cinit%3E(java.util.List%3Cjavax.naming.ldap.Rdn%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public LdapName(Java.Util.List arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Ldap.LdapName"/> to <see cref="Javax.Naming.Name"/>
        /// </summary>
        public static implicit operator Javax.Naming.Name(Javax.Naming.Ldap.LdapName t) => t.Cast<Javax.Naming.Name>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#getAll()"/> 
        /// </summary>
        public Java.Util.Enumeration All
        {
            get { return IExecute<Java.Util.Enumeration>("getAll"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#getRdns()"/> 
        /// </summary>
        public Java.Util.List Rdns
        {
            get { return IExecute<Java.Util.List>("getRdns"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#endsWith(java.util.List%3Cjavax.naming.ldap.Rdn%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EndsWith(Java.Util.List arg0)
        {
            return IExecute<bool>("endsWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#endsWith(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EndsWith(Javax.Naming.Name arg0)
        {
            return IExecute<bool>("endsWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#isEmpty()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#startsWith(java.util.List%3Cjavax.naming.ldap.Rdn%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StartsWith(Java.Util.List arg0)
        {
            return IExecute<bool>("startsWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#startsWith(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StartsWith(Javax.Naming.Name arg0)
        {
            return IExecute<bool>("startsWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#size()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.InvalidNameException"/>
        public object Remove(int arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string Get(int arg0)
        {
            return IExecute<string>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#getRdn(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.Rdn"/></returns>
        public Javax.Naming.Ldap.Rdn GetRdn(int arg0)
        {
            return IExecute<Javax.Naming.Ldap.Rdn>("getRdn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#add(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        /// <exception cref="Javax.Naming.InvalidNameException"/>
        public Javax.Naming.Name Add(int arg0, string arg1)
        {
            return IExecute<Javax.Naming.Name>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#add(int,javax.naming.ldap.Rdn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Ldap.Rdn"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        public Javax.Naming.Name Add(int arg0, Javax.Naming.Ldap.Rdn arg1)
        {
            return IExecute<Javax.Naming.Name>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#add(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        /// <exception cref="Javax.Naming.InvalidNameException"/>
        public Javax.Naming.Name Add(string arg0)
        {
            return IExecute<Javax.Naming.Name>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#add(javax.naming.ldap.Rdn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.Rdn"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        public Javax.Naming.Name Add(Javax.Naming.Ldap.Rdn arg0)
        {
            return IExecute<Javax.Naming.Name>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#addAll(int,java.util.List%3Cjavax.naming.ldap.Rdn%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        public Javax.Naming.Name AddAll(int arg0, Java.Util.List arg1)
        {
            return IExecute<Javax.Naming.Name>("addAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#addAll(int,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        /// <exception cref="Javax.Naming.InvalidNameException"/>
        public Javax.Naming.Name AddAll(int arg0, Javax.Naming.Name arg1)
        {
            return IExecute<Javax.Naming.Name>("addAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#addAll(java.util.List%3Cjavax.naming.ldap.Rdn%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        public Javax.Naming.Name AddAll(Java.Util.List arg0)
        {
            return IExecute<Javax.Naming.Name>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#addAll(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        /// <exception cref="Javax.Naming.InvalidNameException"/>
        public Javax.Naming.Name AddAll(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Name>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#getPrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        public Javax.Naming.Name GetPrefix(int arg0)
        {
            return IExecute<Javax.Naming.Name>("getPrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/LdapName.html#getSuffix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        public Javax.Naming.Name GetSuffix(int arg0)
        {
            return IExecute<Javax.Naming.Name>("getSuffix", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}