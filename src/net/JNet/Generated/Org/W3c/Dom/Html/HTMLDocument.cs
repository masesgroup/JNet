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
    #region IHTMLDocument
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLDocument : Org.W3c.Dom.IDocument
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getAnchors()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Anchors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getApplets()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Applets { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getBody()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setBody(org.w3c.dom.html.HTMLElement)"/>
        /// </summary>
        Org.W3c.Dom.Html.HTMLElement Body { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getCookie()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setCookie(java.lang.String)"/>
        /// </summary>
        string Cookie { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getDomain()"/> 
        /// </summary>
        string Domain { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getForms()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Forms { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getImages()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Images { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getLinks()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Links { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getReferrer()"/> 
        /// </summary>
        string Referrer { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getTitle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setTitle(java.lang.String)"/>
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getURL()"/> 
        /// </summary>
        string URL { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getElementsByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.NodeList"/></returns>
        Org.W3c.Dom.NodeList GetElementsByName(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#close()"/>
        /// </summary>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#open()"/>
        /// </summary>
        void Open();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#write(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        void Write(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#writeln(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        void Writeln(string arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLDocument
    public partial class HTMLDocument : Org.W3c.Dom.Html.IHTMLDocument
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getAnchors()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Anchors
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLCollection>("getAnchors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getApplets()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Applets
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLCollection>("getApplets"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getBody()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setBody(org.w3c.dom.html.HTMLElement)"/>
        /// </summary>
        public Org.W3c.Dom.Html.HTMLElement Body
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLElement>("getBody"); } set { IExecute("setBody", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getCookie()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setCookie(java.lang.String)"/>
        /// </summary>
        public string Cookie
        {
            get { return IExecute<string>("getCookie"); } set { IExecute("setCookie", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getDomain()"/> 
        /// </summary>
        public string Domain
        {
            get { return IExecute<string>("getDomain"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getForms()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Forms
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLCollection>("getForms"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getImages()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Images
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLCollection>("getImages"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getLinks()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Links
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLCollection>("getLinks"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getReferrer()"/> 
        /// </summary>
        public string Referrer
        {
            get { return IExecute<string>("getReferrer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getTitle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setTitle(java.lang.String)"/>
        /// </summary>
        public string Title
        {
            get { return IExecute<string>("getTitle"); } set { IExecute("setTitle", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getURL()"/> 
        /// </summary>
        public string URL
        {
            get { return IExecute<string>("getURL"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getElementsByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.NodeList"/></returns>
        public Org.W3c.Dom.NodeList GetElementsByName(string arg0)
        {
            return IExecute<Org.W3c.Dom.NodeList>("getElementsByName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#open()"/>
        /// </summary>
        public void Open()
        {
            IExecute("open");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#write(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void Write(string arg0)
        {
            IExecute("write", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#writeln(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void Writeln(string arg0)
        {
            IExecute("writeln", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}