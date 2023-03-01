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
    #region HTMLIFrameElement
    public partial class HTMLIFrameElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.W3c.Dom.Html.HTMLIFrameElement"/> to <see cref="Org.W3c.Dom.Html.HTMLElement"/>
        /// </summary>
        public static implicit operator Org.W3c.Dom.Html.HTMLElement(Org.W3c.Dom.Html.HTMLIFrameElement t) => t.Cast<Org.W3c.Dom.Html.HTMLElement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        public string Align
        {
            get { return IExecute<string>("getAlign"); } set { IExecute("setAlign", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getContentDocument()"/> 
        /// </summary>
        public Org.W3c.Dom.Document ContentDocument
        {
            get { return IExecute<Org.W3c.Dom.Document>("getContentDocument"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getFrameBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setFrameBorder(java.lang.String)"/>
        /// </summary>
        public string FrameBorder
        {
            get { return IExecute<string>("getFrameBorder"); } set { IExecute("setFrameBorder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setHeight(java.lang.String)"/>
        /// </summary>
        public string Height
        {
            get { return IExecute<string>("getHeight"); } set { IExecute("setHeight", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getLongDesc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setLongDesc(java.lang.String)"/>
        /// </summary>
        public string LongDesc
        {
            get { return IExecute<string>("getLongDesc"); } set { IExecute("setLongDesc", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getMarginHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setMarginHeight(java.lang.String)"/>
        /// </summary>
        public string MarginHeight
        {
            get { return IExecute<string>("getMarginHeight"); } set { IExecute("setMarginHeight", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getMarginWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setMarginWidth(java.lang.String)"/>
        /// </summary>
        public string MarginWidth
        {
            get { return IExecute<string>("getMarginWidth"); } set { IExecute("setMarginWidth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setName(java.lang.String)"/>
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getScrolling()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setScrolling(java.lang.String)"/>
        /// </summary>
        public string Scrolling
        {
            get { return IExecute<string>("getScrolling"); } set { IExecute("setScrolling", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setSrc(java.lang.String)"/>
        /// </summary>
        public string Src
        {
            get { return IExecute<string>("getSrc"); } set { IExecute("setSrc", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLIFrameElement.html#setWidth(java.lang.String)"/>
        /// </summary>
        public string Width
        {
            get { return IExecute<string>("getWidth"); } set { IExecute("setWidth", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}