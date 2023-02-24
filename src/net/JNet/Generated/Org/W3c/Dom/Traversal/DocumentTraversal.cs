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
    #region DocumentTraversal
    public partial class DocumentTraversal
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/DocumentTraversal.html#createNodeIterator(org.w3c.dom.Node,int,org.w3c.dom.traversal.NodeFilter,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.Traversal.NodeFilter"/></param>
        /// <param name="arg3"><see langword="bool"/></param>
        /// <returns><see cref="Org.W3c.Dom.Traversal.NodeIterator"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Traversal.NodeIterator CreateNodeIterator(Org.W3c.Dom.Node arg0, int arg1, Org.W3c.Dom.Traversal.NodeFilter arg2, bool arg3)
        {
            return IExecute<Org.W3c.Dom.Traversal.NodeIterator>("createNodeIterator", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/DocumentTraversal.html#createTreeWalker(org.w3c.dom.Node,int,org.w3c.dom.traversal.NodeFilter,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.Traversal.NodeFilter"/></param>
        /// <param name="arg3"><see langword="bool"/></param>
        /// <returns><see cref="Org.W3c.Dom.Traversal.TreeWalker"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Traversal.TreeWalker CreateTreeWalker(Org.W3c.Dom.Node arg0, int arg1, Org.W3c.Dom.Traversal.NodeFilter arg2, bool arg3)
        {
            return IExecute<Org.W3c.Dom.Traversal.TreeWalker>("createTreeWalker", arg0, arg1, arg2, arg3);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}