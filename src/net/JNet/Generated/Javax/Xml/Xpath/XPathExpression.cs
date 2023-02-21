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

namespace Javax.Xml.Xpath
{
    #region XPathExpression
    public partial class XPathExpression
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(java.lang.Object,javax.xml.namespace.QName) throws javax.xml.xpath.XPathExpressionException
        /// </summary>
        public object Evaluate(object arg0, Javax.Xml.Namespace.QName arg1)
        {
            return IExecute("evaluate", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(org.xml.sax.InputSource,javax.xml.namespace.QName) throws javax.xml.xpath.XPathExpressionException
        /// </summary>
        public object Evaluate(Org.Xml.Sax.InputSource arg0, Javax.Xml.Namespace.QName arg1)
        {
            return IExecute("evaluate", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(java.lang.Object) throws javax.xml.xpath.XPathExpressionException
        /// </summary>
        public string Evaluate(object arg0)
        {
            return IExecute<string>("evaluate", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(org.xml.sax.InputSource) throws javax.xml.xpath.XPathExpressionException
        /// </summary>
        public string Evaluate(Org.Xml.Sax.InputSource arg0)
        {
            return IExecute<string>("evaluate", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}