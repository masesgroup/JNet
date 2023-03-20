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

namespace Javax.Naming
{
    #region Context
    public partial class Context
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#AUTHORITATIVE"/>
        /// </summary>
        public static string AUTHORITATIVE => Clazz.GetField<string>("AUTHORITATIVE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#BATCHSIZE"/>
        /// </summary>
        public static string BATCHSIZE => Clazz.GetField<string>("BATCHSIZE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#DNS_URL"/>
        /// </summary>
        public static string DNS_URL => Clazz.GetField<string>("DNS_URL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#INITIAL_CONTEXT_FACTORY"/>
        /// </summary>
        public static string INITIAL_CONTEXT_FACTORY => Clazz.GetField<string>("INITIAL_CONTEXT_FACTORY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#LANGUAGE"/>
        /// </summary>
        public static string LANGUAGE => Clazz.GetField<string>("LANGUAGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#OBJECT_FACTORIES"/>
        /// </summary>
        public static string OBJECT_FACTORIES => Clazz.GetField<string>("OBJECT_FACTORIES");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#PROVIDER_URL"/>
        /// </summary>
        public static string PROVIDER_URL => Clazz.GetField<string>("PROVIDER_URL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#REFERRAL"/>
        /// </summary>
        public static string REFERRAL => Clazz.GetField<string>("REFERRAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#SECURITY_AUTHENTICATION"/>
        /// </summary>
        public static string SECURITY_AUTHENTICATION => Clazz.GetField<string>("SECURITY_AUTHENTICATION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#SECURITY_CREDENTIALS"/>
        /// </summary>
        public static string SECURITY_CREDENTIALS => Clazz.GetField<string>("SECURITY_CREDENTIALS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#SECURITY_PRINCIPAL"/>
        /// </summary>
        public static string SECURITY_PRINCIPAL => Clazz.GetField<string>("SECURITY_PRINCIPAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#SECURITY_PROTOCOL"/>
        /// </summary>
        public static string SECURITY_PROTOCOL => Clazz.GetField<string>("SECURITY_PROTOCOL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#STATE_FACTORIES"/>
        /// </summary>
        public static string STATE_FACTORIES => Clazz.GetField<string>("STATE_FACTORIES");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#URL_PKG_PREFIXES"/>
        /// </summary>
        public static string URL_PKG_PREFIXES => Clazz.GetField<string>("URL_PKG_PREFIXES");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getEnvironment()"/> 
        /// </summary>
        public Java.Util.Hashtable Environment
        {
            get { return IExecute<Java.Util.Hashtable>("getEnvironment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getNameInNamespace()"/> 
        /// </summary>
        public string NameInNamespace
        {
            get { return IExecute<string>("getNameInNamespace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#addToEnvironment(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object AddToEnvironment(string arg0, object arg1)
        {
            return IExecute("addToEnvironment", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Lookup(string arg0)
        {
            return IExecute("lookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookup(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Lookup(Javax.Naming.Name arg0)
        {
            return IExecute("lookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookupLink(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object LookupLink(string arg0)
        {
            return IExecute("lookupLink", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookupLink(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object LookupLink(Javax.Naming.Name arg0)
        {
            return IExecute("lookupLink", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#removeFromEnvironment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object RemoveFromEnvironment(string arg0)
        {
            return IExecute("removeFromEnvironment", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#composeName(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public string ComposeName(string arg0, string arg1)
        {
            return IExecute<string>("composeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#createSubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Context CreateSubcontext(string arg0)
        {
            return IExecute<Javax.Naming.Context>("createSubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#createSubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Context CreateSubcontext(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Context>("createSubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#composeName(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Name ComposeName(Javax.Naming.Name arg0, Javax.Naming.Name arg1)
        {
            return IExecute<Javax.Naming.Name>("composeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getNameParser(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NameParser GetNameParser(string arg0)
        {
            return IExecute<Javax.Naming.NameParser>("getNameParser", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getNameParser(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NameParser GetNameParser(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.NameParser>("getNameParser", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#listBindings(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration ListBindings(string arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration>("listBindings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#listBindings(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration ListBindings(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration>("listBindings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#list(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration List(string arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration>("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#list(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration List(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration>("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#bind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(string arg0, object arg1)
        {
            IExecute("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#bind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(Javax.Naming.Name arg0, object arg1)
        {
            IExecute("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#close()"/>
        /// </summary>
        
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#destroySubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void DestroySubcontext(string arg0)
        {
            IExecute("destroySubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#destroySubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void DestroySubcontext(Javax.Naming.Name arg0)
        {
            IExecute("destroySubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rebind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(string arg0, object arg1)
        {
            IExecute("rebind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rebind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(Javax.Naming.Name arg0, object arg1)
        {
            IExecute("rebind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rename(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rename(string arg0, string arg1)
        {
            IExecute("rename", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rename(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rename(Javax.Naming.Name arg0, Javax.Naming.Name arg1)
        {
            IExecute("rename", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#unbind(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Unbind(string arg0)
        {
            IExecute("unbind", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#unbind(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Unbind(Javax.Naming.Name arg0)
        {
            IExecute("unbind", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}