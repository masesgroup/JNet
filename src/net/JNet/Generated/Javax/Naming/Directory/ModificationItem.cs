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
    #region ModificationItem
    public partial class ModificationItem
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/ModificationItem.html#<init>(int,javax.naming.directory.Attribute)
        /// </summary>
        public ModificationItem(int arg0, Javax.Naming.Directory.Attribute arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Serializable(Javax.Naming.Directory.ModificationItem t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/ModificationItem.html#getAttribute() 
        /// </summary>
        public Javax.Naming.Directory.Attribute Attribute
        {
            get { return IExecute<Javax.Naming.Directory.Attribute>("getAttribute"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/ModificationItem.html#getModificationOp() 
        /// </summary>
        public int ModificationOp
        {
            get { return IExecute<int>("getModificationOp"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}