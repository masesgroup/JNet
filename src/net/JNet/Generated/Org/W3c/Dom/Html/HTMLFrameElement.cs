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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Html
{
    #region IHTMLFrameElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLFrameElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getContentDocument()"/> 
        /// </summary>
        Org.W3c.Dom.Document ContentDocument { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getFrameBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setFrameBorder(java.lang.String)"/>
        /// </summary>
        string FrameBorder { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getLongDesc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setLongDesc(java.lang.String)"/>
        /// </summary>
        string LongDesc { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getMarginHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setMarginHeight(java.lang.String)"/>
        /// </summary>
        string MarginHeight { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getMarginWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setMarginWidth(java.lang.String)"/>
        /// </summary>
        string MarginWidth { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setName(java.lang.String)"/>
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getNoResize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setNoResize(boolean)"/>
        /// </summary>
        bool NoResize { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getScrolling()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setScrolling(java.lang.String)"/>
        /// </summary>
        string Scrolling { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setSrc(java.lang.String)"/>
        /// </summary>
        string Src { get; set; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLFrameElement
    public partial class HTMLFrameElement : Org.W3c.Dom.Html.IHTMLFrameElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getContentDocument()"/> 
        /// </summary>
        public Org.W3c.Dom.Document ContentDocument
        {
            get { return IExecute<Org.W3c.Dom.Document>("getContentDocument"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getFrameBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setFrameBorder(java.lang.String)"/>
        /// </summary>
        public string FrameBorder
        {
            get { return IExecute<string>("getFrameBorder"); } set { IExecute("setFrameBorder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getLongDesc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setLongDesc(java.lang.String)"/>
        /// </summary>
        public string LongDesc
        {
            get { return IExecute<string>("getLongDesc"); } set { IExecute("setLongDesc", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getMarginHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setMarginHeight(java.lang.String)"/>
        /// </summary>
        public string MarginHeight
        {
            get { return IExecute<string>("getMarginHeight"); } set { IExecute("setMarginHeight", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getMarginWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setMarginWidth(java.lang.String)"/>
        /// </summary>
        public string MarginWidth
        {
            get { return IExecute<string>("getMarginWidth"); } set { IExecute("setMarginWidth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setName(java.lang.String)"/>
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getNoResize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setNoResize(boolean)"/>
        /// </summary>
        public bool NoResize
        {
            get { return IExecute<bool>("getNoResize"); } set { IExecute("setNoResize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getScrolling()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setScrolling(java.lang.String)"/>
        /// </summary>
        public string Scrolling
        {
            get { return IExecute<string>("getScrolling"); } set { IExecute("setScrolling", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#getSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFrameElement.html#setSrc(java.lang.String)"/>
        /// </summary>
        public string Src
        {
            get { return IExecute<string>("getSrc"); } set { IExecute("setSrc", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}