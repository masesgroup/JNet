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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Html
{
    #region IHTMLTableElement
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html"/>
    /// </summary>
    public partial interface IHTMLTableElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        string Align { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getBgColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setBgColor(java.lang.String)"/>
        /// </summary>
        string BgColor { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setBorder(java.lang.String)"/>
        /// </summary>
        string Border { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCaption()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCaption(org.w3c.dom.html.HTMLTableCaptionElement)"/>
        /// </summary>
        Org.W3c.Dom.Html.HTMLTableCaptionElement Caption { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCellPadding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCellPadding(java.lang.String)"/>
        /// </summary>
        string CellPadding { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCellSpacing()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCellSpacing(java.lang.String)"/>
        /// </summary>
        string CellSpacing { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getFrame()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setFrame(java.lang.String)"/>
        /// </summary>
        string Frame { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getRows()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Rows { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getRules()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setRules(java.lang.String)"/>
        /// </summary>
        string Rules { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getSummary()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setSummary(java.lang.String)"/>
        /// </summary>
        string Summary { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTBodies()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection TBodies { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTFoot()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setTFoot(org.w3c.dom.html.HTMLTableSectionElement)"/>
        /// </summary>
        Org.W3c.Dom.Html.HTMLTableSectionElement TFoot { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTHead()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setTHead(org.w3c.dom.html.HTMLTableSectionElement)"/>
        /// </summary>
        Org.W3c.Dom.Html.HTMLTableSectionElement THead { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setWidth(java.lang.String)"/>
        /// </summary>
        string Width { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createCaption()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        Org.W3c.Dom.Html.HTMLElement CreateCaption();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createTFoot()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        Org.W3c.Dom.Html.HTMLElement CreateTFoot();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createTHead()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        Org.W3c.Dom.Html.HTMLElement CreateTHead();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#insertRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Html.HTMLElement InsertRow(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteCaption()"/>
        /// </summary>
        void DeleteCaption();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void DeleteRow(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteTFoot()"/>
        /// </summary>
        void DeleteTFoot();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteTHead()"/>
        /// </summary>
        void DeleteTHead();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLTableElement
    public partial class HTMLTableElement : Org.W3c.Dom.Html.IHTMLTableElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        public string Align
        {
            get { return IExecute<string>("getAlign"); } set { IExecute("setAlign", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getBgColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setBgColor(java.lang.String)"/>
        /// </summary>
        public string BgColor
        {
            get { return IExecute<string>("getBgColor"); } set { IExecute("setBgColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setBorder(java.lang.String)"/>
        /// </summary>
        public string Border
        {
            get { return IExecute<string>("getBorder"); } set { IExecute("setBorder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCaption()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCaption(org.w3c.dom.html.HTMLTableCaptionElement)"/>
        /// </summary>
        public Org.W3c.Dom.Html.HTMLTableCaptionElement Caption
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLTableCaptionElement>("getCaption"); } set { IExecute("setCaption", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCellPadding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCellPadding(java.lang.String)"/>
        /// </summary>
        public string CellPadding
        {
            get { return IExecute<string>("getCellPadding"); } set { IExecute("setCellPadding", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCellSpacing()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCellSpacing(java.lang.String)"/>
        /// </summary>
        public string CellSpacing
        {
            get { return IExecute<string>("getCellSpacing"); } set { IExecute("setCellSpacing", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getFrame()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setFrame(java.lang.String)"/>
        /// </summary>
        public string Frame
        {
            get { return IExecute<string>("getFrame"); } set { IExecute("setFrame", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getRows()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Rows
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLCollection>("getRows"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getRules()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setRules(java.lang.String)"/>
        /// </summary>
        public string Rules
        {
            get { return IExecute<string>("getRules"); } set { IExecute("setRules", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getSummary()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setSummary(java.lang.String)"/>
        /// </summary>
        public string Summary
        {
            get { return IExecute<string>("getSummary"); } set { IExecute("setSummary", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTBodies()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection TBodies
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLCollection>("getTBodies"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTFoot()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setTFoot(org.w3c.dom.html.HTMLTableSectionElement)"/>
        /// </summary>
        public Org.W3c.Dom.Html.HTMLTableSectionElement TFoot
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLTableSectionElement>("getTFoot"); } set { IExecute("setTFoot", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTHead()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setTHead(org.w3c.dom.html.HTMLTableSectionElement)"/>
        /// </summary>
        public Org.W3c.Dom.Html.HTMLTableSectionElement THead
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLTableSectionElement>("getTHead"); } set { IExecute("setTHead", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setWidth(java.lang.String)"/>
        /// </summary>
        public string Width
        {
            get { return IExecute<string>("getWidth"); } set { IExecute("setWidth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createCaption()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        public Org.W3c.Dom.Html.HTMLElement CreateCaption()
        {
            return IExecute<Org.W3c.Dom.Html.HTMLElement>("createCaption");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createTFoot()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        public Org.W3c.Dom.Html.HTMLElement CreateTFoot()
        {
            return IExecute<Org.W3c.Dom.Html.HTMLElement>("createTFoot");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createTHead()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        public Org.W3c.Dom.Html.HTMLElement CreateTHead()
        {
            return IExecute<Org.W3c.Dom.Html.HTMLElement>("createTHead");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#insertRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Html.HTMLElement InsertRow(int arg0)
        {
            return IExecute<Org.W3c.Dom.Html.HTMLElement>("insertRow", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteCaption()"/>
        /// </summary>
        public void DeleteCaption()
        {
            IExecute("deleteCaption");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void DeleteRow(int arg0)
        {
            IExecute("deleteRow", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteTFoot()"/>
        /// </summary>
        public void DeleteTFoot()
        {
            IExecute("deleteTFoot");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteTHead()"/>
        /// </summary>
        public void DeleteTHead()
        {
            IExecute("deleteTHead");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}