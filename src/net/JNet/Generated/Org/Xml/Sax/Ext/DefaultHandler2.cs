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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Xml.Sax.Ext
{
    #region DefaultHandler2
    public partial class DefaultHandler2
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Ext.DefaultHandler2"/> to <see cref="Org.Xml.Sax.Ext.LexicalHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.Ext.LexicalHandler(Org.Xml.Sax.Ext.DefaultHandler2 t) => t.Cast<Org.Xml.Sax.Ext.LexicalHandler>();
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Ext.DefaultHandler2"/> to <see cref="Org.Xml.Sax.Ext.DeclHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.Ext.DeclHandler(Org.Xml.Sax.Ext.DefaultHandler2 t) => t.Cast<Org.Xml.Sax.Ext.DeclHandler>();
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Ext.DefaultHandler2"/> to <see cref="Org.Xml.Sax.Ext.EntityResolver2"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.Ext.EntityResolver2(Org.Xml.Sax.Ext.DefaultHandler2 t) => t.Cast<Org.Xml.Sax.Ext.EntityResolver2>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#getExternalSubset(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.Xml.Sax.InputSource GetExternalSubset(string arg0, string arg1)
        {
            return IExecute<Org.Xml.Sax.InputSource>("getExternalSubset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#resolveEntity(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.Xml.Sax.InputSource ResolveEntity(string arg0, string arg1, string arg2, string arg3)
        {
            return IExecute<Org.Xml.Sax.InputSource>("resolveEntity", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#attributeDecl(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void AttributeDecl(string arg0, string arg1, string arg2, string arg3, string arg4)
        {
            IExecute("attributeDecl", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#comment(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Comment(char[] arg0, int arg1, int arg2)
        {
            IExecute("comment", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#elementDecl(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void ElementDecl(string arg0, string arg1)
        {
            IExecute("elementDecl", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#endCDATA()"/>
        /// </summary>

        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndCDATA()
        {
            IExecute("endCDATA");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#endDTD()"/>
        /// </summary>

        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndDTD()
        {
            IExecute("endDTD");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#endEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndEntity(string arg0)
        {
            IExecute("endEntity", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#externalEntityDecl(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void ExternalEntityDecl(string arg0, string arg1, string arg2)
        {
            IExecute("externalEntityDecl", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#internalEntityDecl(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void InternalEntityDecl(string arg0, string arg1)
        {
            IExecute("internalEntityDecl", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#startCDATA()"/>
        /// </summary>

        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartCDATA()
        {
            IExecute("startCDATA");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#startDTD(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartDTD(string arg0, string arg1, string arg2)
        {
            IExecute("startDTD", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/DefaultHandler2.html#startEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartEntity(string arg0)
        {
            IExecute("startEntity", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}