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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream
{
    #region IXMLStreamReader
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXMLStreamReader : Javax.Xml.Stream.IXMLStreamConstants
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeCount()"/> 
        /// </summary>
        int AttributeCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getCharacterEncodingScheme()"/> 
        /// </summary>
        string CharacterEncodingScheme { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getElementText()"/> 
        /// </summary>
        string ElementText { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getEncoding()"/> 
        /// </summary>
        string Encoding { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getEventType()"/> 
        /// </summary>
        int EventType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getLocalName()"/> 
        /// </summary>
        string LocalName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getLocation()"/> 
        /// </summary>
        Javax.Xml.Stream.Location Location { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getName()"/> 
        /// </summary>
        Javax.Xml.Namespace.QName Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceContext()"/> 
        /// </summary>
        Javax.Xml.Namespace.NamespaceContext NamespaceContext { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceCount()"/> 
        /// </summary>
        int NamespaceCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceURI()"/> 
        /// </summary>
        string NamespaceURI { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getPIData()"/> 
        /// </summary>
        string PIData { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getPITarget()"/> 
        /// </summary>
        string PITarget { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getPrefix()"/> 
        /// </summary>
        string Prefix { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getText()"/> 
        /// </summary>
        string Text { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getTextCharacters()"/> 
        /// </summary>
        char[] TextCharacters { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getTextLength()"/> 
        /// </summary>
        int TextLength { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getTextStart()"/> 
        /// </summary>
        int TextStart { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getVersion()"/> 
        /// </summary>
        string Version { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#hasName()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasName();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#hasNext()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        bool HasNext();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#hasText()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasText();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isAttributeSpecified(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsAttributeSpecified(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isCharacters()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsCharacters();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isEndElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsEndElement();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isStandalone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsStandalone();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isStartElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsStartElement();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isWhiteSpace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsWhiteSpace();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#standaloneSet()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool StandaloneSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getTextCharacters(int,char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        int GetTextCharacters(int arg0, char[] arg1, int arg2, int arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#next()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        int Next();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#nextTag()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        int NextTag();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        object GetProperty(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeLocalName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributeLocalName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeNamespace(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributeNamespace(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributePrefix(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributeType(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributeValue(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributeValue(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespacePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetNamespacePrefix(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceURI(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetNamespaceURI(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string GetNamespaceURI(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Namespace.QName"/></returns>
        Javax.Xml.Namespace.QName GetAttributeName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#require(int,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Require(int arg0, string arg1, string arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLStreamReader
    public partial class XMLStreamReader : Javax.Xml.Stream.IXMLStreamReader
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeCount()"/> 
        /// </summary>
        public int AttributeCount
        {
            get { return IExecute<int>("getAttributeCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getCharacterEncodingScheme()"/> 
        /// </summary>
        public string CharacterEncodingScheme
        {
            get { return IExecute<string>("getCharacterEncodingScheme"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getElementText()"/> 
        /// </summary>
        public string ElementText
        {
            get { return IExecute<string>("getElementText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getEncoding()"/> 
        /// </summary>
        public string Encoding
        {
            get { return IExecute<string>("getEncoding"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getEventType()"/> 
        /// </summary>
        public int EventType
        {
            get { return IExecute<int>("getEventType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getLocalName()"/> 
        /// </summary>
        public string LocalName
        {
            get { return IExecute<string>("getLocalName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getLocation()"/> 
        /// </summary>
        public Javax.Xml.Stream.Location Location
        {
            get { return IExecute<Javax.Xml.Stream.Location>("getLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getName()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName Name
        {
            get { return IExecute<Javax.Xml.Namespace.QName>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceContext()"/> 
        /// </summary>
        public Javax.Xml.Namespace.NamespaceContext NamespaceContext
        {
            get { return IExecute<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceCount()"/> 
        /// </summary>
        public int NamespaceCount
        {
            get { return IExecute<int>("getNamespaceCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceURI()"/> 
        /// </summary>
        public string NamespaceURI
        {
            get { return IExecute<string>("getNamespaceURI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getPIData()"/> 
        /// </summary>
        public string PIData
        {
            get { return IExecute<string>("getPIData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getPITarget()"/> 
        /// </summary>
        public string PITarget
        {
            get { return IExecute<string>("getPITarget"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getPrefix()"/> 
        /// </summary>
        public string Prefix
        {
            get { return IExecute<string>("getPrefix"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getText()"/> 
        /// </summary>
        public string Text
        {
            get { return IExecute<string>("getText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getTextCharacters()"/> 
        /// </summary>
        public char[] TextCharacters
        {
            get { return IExecuteArray<char>("getTextCharacters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getTextLength()"/> 
        /// </summary>
        public int TextLength
        {
            get { return IExecute<int>("getTextLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getTextStart()"/> 
        /// </summary>
        public int TextStart
        {
            get { return IExecute<int>("getTextStart"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getVersion()"/> 
        /// </summary>
        public string Version
        {
            get { return IExecute<string>("getVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#hasName()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasName()
        {
            return IExecute<bool>("hasName");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#hasNext()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public bool HasNext()
        {
            return IExecute<bool>("hasNext");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#hasText()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasText()
        {
            return IExecute<bool>("hasText");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isAttributeSpecified(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeSpecified(int arg0)
        {
            return IExecute<bool>("isAttributeSpecified", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isCharacters()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCharacters()
        {
            return IExecute<bool>("isCharacters");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isEndElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEndElement()
        {
            return IExecute<bool>("isEndElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isStandalone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStandalone()
        {
            return IExecute<bool>("isStandalone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isStartElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStartElement()
        {
            return IExecute<bool>("isStartElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#isWhiteSpace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsWhiteSpace()
        {
            return IExecute<bool>("isWhiteSpace");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#standaloneSet()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool StandaloneSet()
        {
            return IExecute<bool>("standaloneSet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getTextCharacters(int,char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public int GetTextCharacters(int arg0, char[] arg1, int arg2, int arg3)
        {
            return IExecute<int>("getTextCharacters", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#next()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public int Next()
        {
            return IExecute<int>("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#nextTag()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public int NextTag()
        {
            return IExecute<int>("nextTag");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeLocalName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeLocalName(int arg0)
        {
            return IExecute<string>("getAttributeLocalName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeNamespace(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeNamespace(int arg0)
        {
            return IExecute<string>("getAttributeNamespace", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributePrefix(int arg0)
        {
            return IExecute<string>("getAttributePrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeType(int arg0)
        {
            return IExecute<string>("getAttributeType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeValue(int arg0)
        {
            return IExecute<string>("getAttributeValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeValue(string arg0, string arg1)
        {
            return IExecute<string>("getAttributeValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespacePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNamespacePrefix(int arg0)
        {
            return IExecute<string>("getNamespacePrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceURI(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNamespaceURI(int arg0)
        {
            return IExecute<string>("getNamespaceURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNamespaceURI(string arg0)
        {
            return IExecute<string>("getNamespaceURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#getAttributeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Namespace.QName"/></returns>
        public Javax.Xml.Namespace.QName GetAttributeName(int arg0)
        {
            return IExecute<Javax.Xml.Namespace.QName>("getAttributeName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamReader.html#require(int,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Require(int arg0, string arg1, string arg2)
        {
            IExecute("require", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}