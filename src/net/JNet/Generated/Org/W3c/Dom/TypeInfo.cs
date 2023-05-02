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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom
{
    #region TypeInfo
    public partial class TypeInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#DERIVATION_EXTENSION"/>
        /// </summary>
        public static int DERIVATION_EXTENSION { get { return SGetField<int>(LocalBridgeClazz, "DERIVATION_EXTENSION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#DERIVATION_LIST"/>
        /// </summary>
        public static int DERIVATION_LIST { get { return SGetField<int>(LocalBridgeClazz, "DERIVATION_LIST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#DERIVATION_RESTRICTION"/>
        /// </summary>
        public static int DERIVATION_RESTRICTION { get { return SGetField<int>(LocalBridgeClazz, "DERIVATION_RESTRICTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#DERIVATION_UNION"/>
        /// </summary>
        public static int DERIVATION_UNION { get { return SGetField<int>(LocalBridgeClazz, "DERIVATION_UNION"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#getTypeName()"/> 
        /// </summary>
        public string TypeName
        {
            get { return IExecute<string>("getTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#getTypeNamespace()"/> 
        /// </summary>
        public string TypeNamespace
        {
            get { return IExecute<string>("getTypeNamespace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#isDerivedFrom(java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDerivedFrom(string arg0, string arg1, int arg2)
        {
            return IExecute<bool>("isDerivedFrom", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}