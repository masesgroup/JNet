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

namespace Org.W3c.Dom.Traversal
{
    #region NodeFilter
    public partial class NodeFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ALL"/>
        /// </summary>
        public static int SHOW_ALL { get { return SGetField<int>(LocalClazz, "SHOW_ALL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ATTRIBUTE"/>
        /// </summary>
        public static int SHOW_ATTRIBUTE { get { return SGetField<int>(LocalClazz, "SHOW_ATTRIBUTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_CDATA_SECTION"/>
        /// </summary>
        public static int SHOW_CDATA_SECTION { get { return SGetField<int>(LocalClazz, "SHOW_CDATA_SECTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_COMMENT"/>
        /// </summary>
        public static int SHOW_COMMENT { get { return SGetField<int>(LocalClazz, "SHOW_COMMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_DOCUMENT"/>
        /// </summary>
        public static int SHOW_DOCUMENT { get { return SGetField<int>(LocalClazz, "SHOW_DOCUMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_DOCUMENT_FRAGMENT"/>
        /// </summary>
        public static int SHOW_DOCUMENT_FRAGMENT { get { return SGetField<int>(LocalClazz, "SHOW_DOCUMENT_FRAGMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_DOCUMENT_TYPE"/>
        /// </summary>
        public static int SHOW_DOCUMENT_TYPE { get { return SGetField<int>(LocalClazz, "SHOW_DOCUMENT_TYPE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ELEMENT"/>
        /// </summary>
        public static int SHOW_ELEMENT { get { return SGetField<int>(LocalClazz, "SHOW_ELEMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ENTITY"/>
        /// </summary>
        public static int SHOW_ENTITY { get { return SGetField<int>(LocalClazz, "SHOW_ENTITY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ENTITY_REFERENCE"/>
        /// </summary>
        public static int SHOW_ENTITY_REFERENCE { get { return SGetField<int>(LocalClazz, "SHOW_ENTITY_REFERENCE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_NOTATION"/>
        /// </summary>
        public static int SHOW_NOTATION { get { return SGetField<int>(LocalClazz, "SHOW_NOTATION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_PROCESSING_INSTRUCTION"/>
        /// </summary>
        public static int SHOW_PROCESSING_INSTRUCTION { get { return SGetField<int>(LocalClazz, "SHOW_PROCESSING_INSTRUCTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_TEXT"/>
        /// </summary>
        public static int SHOW_TEXT { get { return SGetField<int>(LocalClazz, "SHOW_TEXT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#FILTER_ACCEPT"/>
        /// </summary>
        public static short FILTER_ACCEPT { get { return SGetField<short>(LocalClazz, "FILTER_ACCEPT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#FILTER_REJECT"/>
        /// </summary>
        public static short FILTER_REJECT { get { return SGetField<short>(LocalClazz, "FILTER_REJECT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#FILTER_SKIP"/>
        /// </summary>
        public static short FILTER_SKIP { get { return SGetField<short>(LocalClazz, "FILTER_SKIP"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#acceptNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        public short AcceptNode(Org.W3c.Dom.Node arg0)
        {
            return IExecute<short>("acceptNode", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}