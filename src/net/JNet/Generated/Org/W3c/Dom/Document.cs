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

namespace Org.W3c.Dom
{
    #region Document
    public partial class Document
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Org.W3c.Dom.Node(Org.W3c.Dom.Document t) => t.Cast<Org.W3c.Dom.Node>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getDoctype() 
        /// </summary>
        public Org.W3c.Dom.DocumentType Doctype
        {
            get { return IExecute<Org.W3c.Dom.DocumentType>("getDoctype"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getDocumentElement() 
        /// </summary>
        public Org.W3c.Dom.Element DocumentElement
        {
            get { return IExecute<Org.W3c.Dom.Element>("getDocumentElement"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getDocumentURI() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#setDocumentURI(java.lang.String)
        /// </summary>
        public string DocumentURI
        {
            get { return IExecute<string>("getDocumentURI"); } set { IExecute("setDocumentURI", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getDomConfig() 
        /// </summary>
        public Org.W3c.Dom.DOMConfiguration DomConfig
        {
            get { return IExecute<Org.W3c.Dom.DOMConfiguration>("getDomConfig"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getImplementation() 
        /// </summary>
        public Org.W3c.Dom.DOMImplementation Implementation
        {
            get { return IExecute<Org.W3c.Dom.DOMImplementation>("getImplementation"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getInputEncoding() 
        /// </summary>
        public string InputEncoding
        {
            get { return IExecute<string>("getInputEncoding"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getStrictErrorChecking() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#setStrictErrorChecking(boolean)
        /// </summary>
        public bool StrictErrorChecking
        {
            get { return IExecute<bool>("getStrictErrorChecking"); } set { IExecute("setStrictErrorChecking", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getXmlEncoding() 
        /// </summary>
        public string XmlEncoding
        {
            get { return IExecute<string>("getXmlEncoding"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getXmlStandalone() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#setXmlStandalone(boolean) throws org.w3c.dom.DOMException
        /// </summary>
        public bool XmlStandalone
        {
            get { return IExecute<bool>("getXmlStandalone"); } set { IExecute("setXmlStandalone", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getXmlVersion() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#setXmlVersion(java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public string XmlVersion
        {
            get { return IExecute<string>("getXmlVersion"); } set { IExecute("setXmlVersion", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createAttribute(java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Attr CreateAttribute(string arg0)
        {
            return IExecute<Org.W3c.Dom.Attr>("createAttribute", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createAttributeNS(java.lang.String,java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Attr CreateAttributeNS(string arg0, string arg1)
        {
            return IExecute<Org.W3c.Dom.Attr>("createAttributeNS", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createCDATASection(java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.CDATASection CreateCDATASection(string arg0)
        {
            return IExecute<Org.W3c.Dom.CDATASection>("createCDATASection", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createComment(java.lang.String)
        /// </summary>
        public Org.W3c.Dom.Comment CreateComment(string arg0)
        {
            return IExecute<Org.W3c.Dom.Comment>("createComment", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createDocumentFragment()
        /// </summary>
        public Org.W3c.Dom.DocumentFragment CreateDocumentFragment()
        {
            return IExecute<Org.W3c.Dom.DocumentFragment>("createDocumentFragment");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createElement(java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Element CreateElement(string arg0)
        {
            return IExecute<Org.W3c.Dom.Element>("createElement", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createElementNS(java.lang.String,java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Element CreateElementNS(string arg0, string arg1)
        {
            return IExecute<Org.W3c.Dom.Element>("createElementNS", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getElementById(java.lang.String)
        /// </summary>
        public Org.W3c.Dom.Element GetElementById(string arg0)
        {
            return IExecute<Org.W3c.Dom.Element>("getElementById", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createEntityReference(java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.EntityReference CreateEntityReference(string arg0)
        {
            return IExecute<Org.W3c.Dom.EntityReference>("createEntityReference", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#adoptNode(org.w3c.dom.Node) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Node AdoptNode(Org.W3c.Dom.Node arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("adoptNode", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#importNode(org.w3c.dom.Node,boolean) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Node ImportNode(Org.W3c.Dom.Node arg0, bool arg1)
        {
            return IExecute<Org.W3c.Dom.Node>("importNode", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#renameNode(org.w3c.dom.Node,java.lang.String,java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Node RenameNode(Org.W3c.Dom.Node arg0, string arg1, string arg2)
        {
            return IExecute<Org.W3c.Dom.Node>("renameNode", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getElementsByTagName(java.lang.String)
        /// </summary>
        public Org.W3c.Dom.NodeList GetElementsByTagName(string arg0)
        {
            return IExecute<Org.W3c.Dom.NodeList>("getElementsByTagName", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#getElementsByTagNameNS(java.lang.String,java.lang.String)
        /// </summary>
        public Org.W3c.Dom.NodeList GetElementsByTagNameNS(string arg0, string arg1)
        {
            return IExecute<Org.W3c.Dom.NodeList>("getElementsByTagNameNS", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createProcessingInstruction(java.lang.String,java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.ProcessingInstruction CreateProcessingInstruction(string arg0, string arg1)
        {
            return IExecute<Org.W3c.Dom.ProcessingInstruction>("createProcessingInstruction", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#createTextNode(java.lang.String)
        /// </summary>
        public Org.W3c.Dom.Text CreateTextNode(string arg0)
        {
            return IExecute<Org.W3c.Dom.Text>("createTextNode", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Document.html#normalizeDocument()
        /// </summary>
        public void NormalizeDocument()
        {
            IExecute("normalizeDocument");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}