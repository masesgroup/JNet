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
    #region BasicAttributes
    public partial class BasicAttributes
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public BasicAttributes(bool arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#%3Cinit%3E(java.lang.String,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public BasicAttributes(string arg0, object arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#%3Cinit%3E(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public BasicAttributes(string arg0, object arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Directory.BasicAttributes"/> to <see cref="Javax.Naming.Directory.Attributes"/>
        /// </summary>
        public static implicit operator Javax.Naming.Directory.Attributes(Javax.Naming.Directory.BasicAttributes t) => t.Cast<Javax.Naming.Directory.Attributes>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#getAll()"/> 
        /// </summary>
        public Javax.Naming.NamingEnumeration All
        {
            get { return IExecute<Javax.Naming.NamingEnumeration>("getAll"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#getIDs()"/> 
        /// </summary>
        public Javax.Naming.NamingEnumeration IDs
        {
            get { return IExecute<Javax.Naming.NamingEnumeration>("getIDs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#isCaseIgnored()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsCaseIgnored()
        {
            return IExecute<bool>("isCaseIgnored");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#size()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Get(string arg0)
        {
            return IExecute<Javax.Naming.Directory.Attribute>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Put(string arg0, object arg1)
        {
            return IExecute<Javax.Naming.Directory.Attribute>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#put(javax.naming.directory.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Directory.Attribute"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Put(Javax.Naming.Directory.Attribute arg0)
        {
            return IExecute<Javax.Naming.Directory.Attribute>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#remove(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Remove(string arg0)
        {
            return IExecute<Javax.Naming.Directory.Attribute>("remove", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}