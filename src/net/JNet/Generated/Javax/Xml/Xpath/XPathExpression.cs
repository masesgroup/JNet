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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Xpath
{
    #region IXPathExpression
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXPathExpression
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(java.lang.Object,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        object Evaluate(object arg0, Javax.Xml.Namespace.QName arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(org.xml.sax.InputSource,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        object Evaluate(Org.Xml.Sax.InputSource arg0, Javax.Xml.Namespace.QName arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Java.Lang.String Evaluate(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Java.Lang.String Evaluate(Org.Xml.Sax.InputSource arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluateExpression(java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        T EvaluateExpression<T>(object arg0, Java.Lang.Class arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluateExpression(org.xml.sax.InputSource,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        T EvaluateExpression<T>(Org.Xml.Sax.InputSource arg0, Java.Lang.Class arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluateExpression(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluateExpression(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(Org.Xml.Sax.InputSource arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XPathExpression
    public partial class XPathExpression : Javax.Xml.Xpath.IXPathExpression
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(java.lang.Object,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public object Evaluate(object arg0, Javax.Xml.Namespace.QName arg1)
        {
            return IExecute("evaluate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(org.xml.sax.InputSource,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public object Evaluate(Org.Xml.Sax.InputSource arg0, Javax.Xml.Namespace.QName arg1)
        {
            return IExecute("evaluate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Java.Lang.String Evaluate(object arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("evaluate", "(Ljava/lang/Object;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluate(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Java.Lang.String Evaluate(Org.Xml.Sax.InputSource arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("evaluate", "(Lorg/xml/sax/InputSource;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluateExpression(java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public T EvaluateExpression<T>(object arg0, Java.Lang.Class arg1)
        {
            return IExecute<T>("evaluateExpression", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluateExpression(org.xml.sax.InputSource,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public T EvaluateExpression<T>(Org.Xml.Sax.InputSource arg0, Java.Lang.Class arg1)
        {
            return IExecute<T>("evaluateExpression", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluateExpression(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(object arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Xpath.XPathEvaluationResult<object>>("evaluateExpression", "(Ljava/lang/Object;)Ljavax/xml/xpath/XPathEvaluationResult;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathExpression.html#evaluateExpression(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(Org.Xml.Sax.InputSource arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Xpath.XPathEvaluationResult<object>>("evaluateExpression", "(Lorg/xml/sax/InputSource;)Ljavax/xml/xpath/XPathEvaluationResult;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}