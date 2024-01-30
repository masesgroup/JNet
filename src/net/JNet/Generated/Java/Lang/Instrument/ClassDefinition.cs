/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Instrument
{
    #region ClassDefinition
    public partial class ClassDefinition
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/ClassDefinition.html#%3Cinit%3E(java.lang.Class,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public ClassDefinition(Java.Lang.Class arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/ClassDefinition.html#getDefinitionClass()"/> 
        /// </summary>
        public Java.Lang.Class DefinitionClass
        {
            get { return IExecute<Java.Lang.Class>("getDefinitionClass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/ClassDefinition.html#getDefinitionClassFile()"/> 
        /// </summary>
        public byte[] DefinitionClassFile
        {
            get { return IExecuteArray<byte>("getDefinitionClassFile"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}