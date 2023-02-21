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

namespace Javax.Xml.Validation
{
    #region ValidatorHandler
    public partial class ValidatorHandler
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Org.Xml.Sax.ContentHandler(Javax.Xml.Validation.ValidatorHandler t) => t.Cast<Org.Xml.Sax.ContentHandler>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getContentHandler() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setContentHandler(org.xml.sax.ContentHandler)
        /// </summary>
        public Org.Xml.Sax.ContentHandler ContentHandler
        {
            get { return IExecute<Org.Xml.Sax.ContentHandler>("getContentHandler"); } set { IExecute("setContentHandler", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getErrorHandler() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setErrorHandler(org.xml.sax.ErrorHandler)
        /// </summary>
        public Org.Xml.Sax.ErrorHandler ErrorHandler
        {
            get { return IExecute<Org.Xml.Sax.ErrorHandler>("getErrorHandler"); } set { IExecute("setErrorHandler", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getResourceResolver() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setResourceResolver(org.w3c.dom.ls.LSResourceResolver)
        /// </summary>
        public Org.W3c.Dom.Ls.LSResourceResolver ResourceResolver
        {
            get { return IExecute<Org.W3c.Dom.Ls.LSResourceResolver>("getResourceResolver"); } set { IExecute("setResourceResolver", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getTypeInfoProvider() 
        /// </summary>
        public Javax.Xml.Validation.TypeInfoProvider TypeInfoProvider
        {
            get { return IExecute<Javax.Xml.Validation.TypeInfoProvider>("getTypeInfoProvider"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getFeature(java.lang.String) throws org.xml.sax.SAXNotRecognizedException,org.xml.sax.SAXNotSupportedException
        /// </summary>
        public bool GetFeature(string arg0)
        {
            return IExecute<bool>("getFeature", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getProperty(java.lang.String) throws org.xml.sax.SAXNotRecognizedException,org.xml.sax.SAXNotSupportedException
        /// </summary>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setFeature(java.lang.String,boolean) throws org.xml.sax.SAXNotRecognizedException,org.xml.sax.SAXNotSupportedException
        /// </summary>
        public void SetFeature(string arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setProperty(java.lang.String,java.lang.Object) throws org.xml.sax.SAXNotRecognizedException,org.xml.sax.SAXNotSupportedException
        /// </summary>
        public void SetProperty(string arg0, object arg1)
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