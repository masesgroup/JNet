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

namespace Javax.Management.Openmbean
{
    #region OpenType
    public partial class OpenType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.OpenType"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Management.Openmbean.OpenType t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#ALLOWED_CLASSNAMES_LIST"/>
        /// </summary>
        public static Java.Util.List ALLOWED_CLASSNAMES_LIST => Clazz.GetField<Java.Util.List>("ALLOWED_CLASSNAMES_LIST");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#getDescription()"/> 
        /// </summary>
        public string Description
        {
            get { return IExecute<string>("getDescription"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#getTypeName()"/> 
        /// </summary>
        public string TypeName
        {
            get { return IExecute<string>("getTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#isValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsValue(object arg0)
        {
            return IExecute<bool>("isValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#isArray()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsArray()
        {
            return IExecute<bool>("isArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#getClassName()"/>
        /// </summary>
        
        /// <returns><see langword="string"/></returns>
        public string GetClassName()
        {
            return IExecute<string>("getClassName");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}