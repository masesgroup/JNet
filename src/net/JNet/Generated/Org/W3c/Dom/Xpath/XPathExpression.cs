/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Xpath
{
    #region IXPathExpression
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXPathExpression
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathExpression.html#evaluate(org.w3c.dom.Node,short,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.W3c.Dom.Xpath.XPathException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        object Evaluate(Org.W3c.Dom.Node arg0, short arg1, object arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XPathExpression
    public partial class XPathExpression : Org.W3c.Dom.Xpath.IXPathExpression
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathExpression.html#evaluate(org.w3c.dom.Node,short,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.W3c.Dom.Xpath.XPathException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public object Evaluate(Org.W3c.Dom.Node arg0, short arg1, object arg2)
        {
            return IExecute("evaluate", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}