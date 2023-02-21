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

namespace Org.W3c.Dom.Traversal
{
    #region TreeWalker
    public partial class TreeWalker
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getCurrentNode() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#setCurrentNode(org.w3c.dom.Node) throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Node CurrentNode
        {
            get { return IExecute<Org.W3c.Dom.Node>("getCurrentNode"); } set { IExecute("setCurrentNode", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getExpandEntityReferences() 
        /// </summary>
        public bool ExpandEntityReferences
        {
            get { return IExecute<bool>("getExpandEntityReferences"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getFilter() 
        /// </summary>
        public Org.W3c.Dom.Traversal.NodeFilter Filter
        {
            get { return IExecute<Org.W3c.Dom.Traversal.NodeFilter>("getFilter"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getRoot() 
        /// </summary>
        public Org.W3c.Dom.Node Root
        {
            get { return IExecute<Org.W3c.Dom.Node>("getRoot"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getWhatToShow() 
        /// </summary>
        public int WhatToShow
        {
            get { return IExecute<int>("getWhatToShow"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#firstChild()
        /// </summary>
        public Org.W3c.Dom.Node FirstChild()
        {
            return IExecute<Org.W3c.Dom.Node>("firstChild");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#lastChild()
        /// </summary>
        public Org.W3c.Dom.Node LastChild()
        {
            return IExecute<Org.W3c.Dom.Node>("lastChild");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#nextNode()
        /// </summary>
        public Org.W3c.Dom.Node NextNode()
        {
            return IExecute<Org.W3c.Dom.Node>("nextNode");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#nextSibling()
        /// </summary>
        public Org.W3c.Dom.Node NextSibling()
        {
            return IExecute<Org.W3c.Dom.Node>("nextSibling");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#parentNode()
        /// </summary>
        public Org.W3c.Dom.Node ParentNode()
        {
            return IExecute<Org.W3c.Dom.Node>("parentNode");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#previousNode()
        /// </summary>
        public Org.W3c.Dom.Node PreviousNode()
        {
            return IExecute<Org.W3c.Dom.Node>("previousNode");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#previousSibling()
        /// </summary>
        public Org.W3c.Dom.Node PreviousSibling()
        {
            return IExecute<Org.W3c.Dom.Node>("previousSibling");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}