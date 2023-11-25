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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Xpath
{
    #region IXPath
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXPath
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getNamespaceContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setNamespaceContext(javax.xml.namespace.NamespaceContext)"/>
        /// </summary>
        Javax.Xml.Namespace.NamespaceContext NamespaceContext { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getXPathFunctionResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver)"/>
        /// </summary>
        Javax.Xml.Xpath.XPathFunctionResolver XPathFunctionResolver { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getXPathVariableResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver)"/>
        /// </summary>
        Javax.Xml.Xpath.XPathVariableResolver XPathVariableResolver { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,java.lang.Object,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        object Evaluate(string arg0, object arg1, Javax.Xml.Namespace.QName arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,org.xml.sax.InputSource,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        object Evaluate(string arg0, Org.Xml.Sax.InputSource arg1, Javax.Xml.Namespace.QName arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        string Evaluate(string arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        string Evaluate(string arg0, Org.Xml.Sax.InputSource arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#compile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathExpression"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Javax.Xml.Xpath.XPathExpression Compile(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#reset()"/>
        /// </summary>
        void Reset();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        T EvaluateExpression<T>(string arg0, object arg1, Java.Lang.Class arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,org.xml.sax.InputSource,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        T EvaluateExpression<T>(string arg0, Org.Xml.Sax.InputSource arg1, Java.Lang.Class arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(string arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(string arg0, Org.Xml.Sax.InputSource arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XPath
    public partial class XPath : Javax.Xml.Xpath.IXPath
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getNamespaceContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setNamespaceContext(javax.xml.namespace.NamespaceContext)"/>
        /// </summary>
        public Javax.Xml.Namespace.NamespaceContext NamespaceContext
        {
            get { return IExecute<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext"); } set { IExecute("setNamespaceContext", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getXPathFunctionResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver)"/>
        /// </summary>
        public Javax.Xml.Xpath.XPathFunctionResolver XPathFunctionResolver
        {
            get { return IExecute<Javax.Xml.Xpath.XPathFunctionResolver>("getXPathFunctionResolver"); } set { IExecute("setXPathFunctionResolver", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getXPathVariableResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver)"/>
        /// </summary>
        public Javax.Xml.Xpath.XPathVariableResolver XPathVariableResolver
        {
            get { return IExecute<Javax.Xml.Xpath.XPathVariableResolver>("getXPathVariableResolver"); } set { IExecute("setXPathVariableResolver", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,java.lang.Object,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public object Evaluate(string arg0, object arg1, Javax.Xml.Namespace.QName arg2)
        {
            return IExecute("evaluate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,org.xml.sax.InputSource,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public object Evaluate(string arg0, Org.Xml.Sax.InputSource arg1, Javax.Xml.Namespace.QName arg2)
        {
            return IExecute("evaluate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public string Evaluate(string arg0, object arg1)
        {
            return IExecute<string>("evaluate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public string Evaluate(string arg0, Org.Xml.Sax.InputSource arg1)
        {
            return IExecute<string>("evaluate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#compile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathExpression"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Javax.Xml.Xpath.XPathExpression Compile(string arg0)
        {
            return IExecute<Javax.Xml.Xpath.XPathExpression>("compile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public T EvaluateExpression<T>(string arg0, object arg1, Java.Lang.Class arg2)
        {
            return IExecute<T>("evaluateExpression", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,org.xml.sax.InputSource,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public T EvaluateExpression<T>(string arg0, Org.Xml.Sax.InputSource arg1, Java.Lang.Class arg2)
        {
            return IExecute<T>("evaluateExpression", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(string arg0, object arg1)
        {
            return IExecute<Javax.Xml.Xpath.XPathEvaluationResult<object>>("evaluateExpression", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(string arg0, Org.Xml.Sax.InputSource arg1)
        {
            return IExecute<Javax.Xml.Xpath.XPathEvaluationResult<object>>("evaluateExpression", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}