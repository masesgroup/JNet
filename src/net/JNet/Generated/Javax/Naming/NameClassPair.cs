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
    #region NameClassPair
    public partial class NameClassPair
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#%3Cinit%3E(java.lang.String,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public NameClassPair(string arg0, string arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public NameClassPair(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.NameClassPair"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Naming.NameClassPair t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#setName(java.lang.String)"/>
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#getNameInNamespace()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#setNameInNamespace(java.lang.String)"/>
        /// </summary>
        public string NameInNamespace
        {
            get { return IExecute<string>("getNameInNamespace"); } set { IExecute("setNameInNamespace", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#isRelative()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsRelative()
        {
            return IExecute<bool>("isRelative");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#getClassName()"/>
        /// </summary>
        
        /// <returns><see langword="string"/></returns>
        public string GetClassName()
        {
            return IExecute<string>("getClassName");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#setClassName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void SetClassName(string arg0)
        {
            IExecute("setClassName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#setRelative(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRelative(bool arg0)
        {
            IExecute("setRelative", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}