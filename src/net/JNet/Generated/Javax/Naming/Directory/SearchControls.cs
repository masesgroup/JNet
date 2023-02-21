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

namespace Javax.Naming.Directory
{
    #region SearchControls
    public partial class SearchControls
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#<init>(int,long,int,java.lang.String[],boolean,boolean)
        /// </summary>
        public SearchControls(int arg0, long arg1, int arg2, string[] arg3, bool arg4, bool arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Serializable(Javax.Naming.Directory.SearchControls t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#OBJECT_SCOPE
        /// </summary>
        public static int OBJECT_SCOPE => Clazz.GetField<int>("OBJECT_SCOPE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#ONELEVEL_SCOPE
        /// </summary>
        public static int ONELEVEL_SCOPE => Clazz.GetField<int>("ONELEVEL_SCOPE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#SUBTREE_SCOPE
        /// </summary>
        public static int SUBTREE_SCOPE => Clazz.GetField<int>("SUBTREE_SCOPE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getCountLimit() https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setCountLimit(long)
        /// </summary>
        public long CountLimit
        {
            get { return IExecute<long>("getCountLimit"); } set { IExecute("setCountLimit", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getDerefLinkFlag() https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setDerefLinkFlag(boolean)
        /// </summary>
        public bool DerefLinkFlag
        {
            get { return IExecute<bool>("getDerefLinkFlag"); } set { IExecute("setDerefLinkFlag", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getReturningAttributes() https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setReturningAttributes(java.lang.String[])
        /// </summary>
        public string[] ReturningAttributes
        {
            get { return IExecuteArray<string>("getReturningAttributes"); } set { IExecute("setReturningAttributes", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getReturningObjFlag() https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setReturningObjFlag(boolean)
        /// </summary>
        public bool ReturningObjFlag
        {
            get { return IExecute<bool>("getReturningObjFlag"); } set { IExecute("setReturningObjFlag", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getSearchScope() https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setSearchScope(int)
        /// </summary>
        public int SearchScope
        {
            get { return IExecute<int>("getSearchScope"); } set { IExecute("setSearchScope", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getTimeLimit() https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setTimeLimit(int)
        /// </summary>
        public int TimeLimit
        {
            get { return IExecute<int>("getTimeLimit"); } set { IExecute("setTimeLimit", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}