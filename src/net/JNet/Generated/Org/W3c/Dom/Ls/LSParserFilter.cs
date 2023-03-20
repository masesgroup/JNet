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

namespace Org.W3c.Dom.Ls
{
    #region LSParserFilter
    public partial class LSParserFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParserFilter.html#FILTER_ACCEPT"/>
        /// </summary>
        public static short FILTER_ACCEPT => Clazz.GetField<short>("FILTER_ACCEPT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParserFilter.html#FILTER_INTERRUPT"/>
        /// </summary>
        public static short FILTER_INTERRUPT => Clazz.GetField<short>("FILTER_INTERRUPT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParserFilter.html#FILTER_REJECT"/>
        /// </summary>
        public static short FILTER_REJECT => Clazz.GetField<short>("FILTER_REJECT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParserFilter.html#FILTER_SKIP"/>
        /// </summary>
        public static short FILTER_SKIP => Clazz.GetField<short>("FILTER_SKIP");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParserFilter.html#getWhatToShow()"/> 
        /// </summary>
        public int WhatToShow
        {
            get { return IExecute<int>("getWhatToShow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParserFilter.html#acceptNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        public short AcceptNode(Org.W3c.Dom.Node arg0)
        {
            return IExecute<short>("acceptNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParserFilter.html#startElement(org.w3c.dom.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Element"/></param>
        /// <returns><see cref="short"/></returns>
        public short StartElement(Org.W3c.Dom.Element arg0)
        {
            return IExecute<short>("startElement", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}