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
    #region NodeIterator
    public partial class NodeIterator
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getExpandEntityReferences() 
        /// </summary>
        public bool ExpandEntityReferences
        {
            get { return IExecute<bool>("getExpandEntityReferences"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getFilter() 
        /// </summary>
        public Org.W3c.Dom.Traversal.NodeFilter Filter
        {
            get { return IExecute<Org.W3c.Dom.Traversal.NodeFilter>("getFilter"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getRoot() 
        /// </summary>
        public Org.W3c.Dom.Node Root
        {
            get { return IExecute<Org.W3c.Dom.Node>("getRoot"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getWhatToShow() 
        /// </summary>
        public int WhatToShow
        {
            get { return IExecute<int>("getWhatToShow"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#nextNode() throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Node NextNode()
        {
            return IExecute<Org.W3c.Dom.Node>("nextNode");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#previousNode() throws org.w3c.dom.DOMException
        /// </summary>
        public Org.W3c.Dom.Node PreviousNode()
        {
            return IExecute<Org.W3c.Dom.Node>("previousNode");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#detach()
        /// </summary>
        public void Detach()
        {
            IExecute("detach");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}