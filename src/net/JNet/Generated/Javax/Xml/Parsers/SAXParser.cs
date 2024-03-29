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

namespace Javax.Xml.Parsers
{
    #region SAXParser
    public partial class SAXParser
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#getSchema()"/> 
        /// </summary>
        public Javax.Xml.Validation.Schema Schema
        {
            get { return IExecuteWithSignature<Javax.Xml.Validation.Schema>("getSchema", "()Ljavax/xml/validation/Schema;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#getXMLReader()"/> 
        /// </summary>
        public Org.Xml.Sax.XMLReader XMLReader
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.XMLReader>("getXMLReader", "()Lorg/xml/sax/XMLReader;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#isNamespaceAware()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsNamespaceAware()
        {
            return IExecuteWithSignature<bool>("isNamespaceAware", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#isValidating()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValidating()
        {
            return IExecuteWithSignature<bool>("isValidating", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#getProperty(java.lang.String)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#isXIncludeAware()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsXIncludeAware()
        {
            return IExecuteWithSignature<bool>("isXIncludeAware", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#parse(java.io.File,org.xml.sax.helpers.DefaultHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.Helpers.DefaultHandler"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Parse(Java.Io.File arg0, Org.Xml.Sax.Helpers.DefaultHandler arg1)
        {
            IExecute("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#parse(java.io.InputStream,org.xml.sax.helpers.DefaultHandler,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.Helpers.DefaultHandler"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Parse(Java.Io.InputStream arg0, Org.Xml.Sax.Helpers.DefaultHandler arg1, Java.Lang.String arg2)
        {
            IExecute("parse", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#parse(java.io.InputStream,org.xml.sax.helpers.DefaultHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.Helpers.DefaultHandler"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Parse(Java.Io.InputStream arg0, Org.Xml.Sax.Helpers.DefaultHandler arg1)
        {
            IExecute("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#parse(java.lang.String,org.xml.sax.helpers.DefaultHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.Helpers.DefaultHandler"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Parse(Java.Lang.String arg0, Org.Xml.Sax.Helpers.DefaultHandler arg1)
        {
            IExecute("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#parse(org.xml.sax.InputSource,org.xml.sax.helpers.DefaultHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.Helpers.DefaultHandler"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Parse(Org.Xml.Sax.InputSource arg0, Org.Xml.Sax.Helpers.DefaultHandler arg1)
        {
            IExecute("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParser.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}