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

namespace Org.W3c.Dom.Html
{
    #region HTMLTableSectionElement
    public partial class HTMLTableSectionElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Org.W3c.Dom.Html.HTMLElement(Org.W3c.Dom.Html.HTMLTableSectionElement t) => t.Cast<Org.W3c.Dom.Html.HTMLElement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#getAlign() https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#setAlign(java.lang.String)
        /// </summary>
        public string Align
        {
            get { return IExecute<string>("getAlign"); } set { IExecute("setAlign", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#getCh() https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#setCh(java.lang.String)
        /// </summary>
        public string Ch
        {
            get { return IExecute<string>("getCh"); } set { IExecute("setCh", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#getChOff() https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#setChOff(java.lang.String)
        /// </summary>
        public string ChOff
        {
            get { return IExecute<string>("getChOff"); } set { IExecute("setChOff", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#getRows() 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Rows
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLCollection>("getRows"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#getVAlign() https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#setVAlign(java.lang.String)
        /// </summary>
        public string VAlign
        {
            get { return IExecute<string>("getVAlign"); } set { IExecute("setVAlign", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#insertRow(int) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Html.HTMLElement InsertRow(int arg0)
        {
            return IExecute<Org.W3c.Dom.Html.HTMLElement>("insertRow", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableSectionElement.html#deleteRow(int) throws org.w3c.dom.DOMException
        /// </summary>
        public void DeleteRow(int arg0)
        {
            IExecute("deleteRow", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}