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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Validation
{
    #region SchemaFactory
    public partial class SchemaFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#newDefaultInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Validation.SchemaFactory"/></returns>
        public static Javax.Xml.Validation.SchemaFactory NewDefaultInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Validation.SchemaFactory>(LocalBridgeClazz, "newDefaultInstance", "()Ljavax/xml/validation/SchemaFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#newInstance(java.lang.String,java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Validation.SchemaFactory"/></returns>
        public static Javax.Xml.Validation.SchemaFactory NewInstance(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Javax.Xml.Validation.SchemaFactory>(LocalBridgeClazz, "newInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#newInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Validation.SchemaFactory"/></returns>
        public static Javax.Xml.Validation.SchemaFactory NewInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Xml.Validation.SchemaFactory>(LocalBridgeClazz, "newInstance", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#getErrorHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        public Org.Xml.Sax.ErrorHandler ErrorHandler
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.ErrorHandler>("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;"); } set { IExecuteWithSignature("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#getResourceResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#setResourceResolver(org.w3c.dom.ls.LSResourceResolver)"/>
        /// </summary>
        public Org.W3c.Dom.Ls.LSResourceResolver ResourceResolver
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Ls.LSResourceResolver>("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;"); } set { IExecuteWithSignature("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#isSchemaLanguageSupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSchemaLanguageSupported(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isSchemaLanguageSupported", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#newSchema()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema()
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "()Ljavax/xml/validation/Schema;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#newSchema(javax.xml.transform.Source[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema(Javax.Xml.Transform.Source[] arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#newSchema(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "(Ljava/io/File;)Ljavax/xml/validation/Schema;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#newSchema(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "(Ljava/net/URL;)Ljavax/xml/validation/Schema;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#newSchema(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "(Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/SchemaFactory.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}