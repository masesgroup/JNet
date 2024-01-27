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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream.Util
{
    #region StreamReaderDelegate
    public partial class StreamReaderDelegate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#%3Cinit%3E(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        public StreamReaderDelegate(Javax.Xml.Stream.XMLStreamReader arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeCount()"/> 
        /// </summary>
        public int AttributeCount
        {
            get { return IExecute<int>("getAttributeCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getCharacterEncodingScheme()"/> 
        /// </summary>
        public string CharacterEncodingScheme
        {
            get { return IExecute<string>("getCharacterEncodingScheme"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getElementText()"/> 
        /// </summary>
        public string ElementText
        {
            get { return IExecute<string>("getElementText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getEncoding()"/> 
        /// </summary>
        public string Encoding
        {
            get { return IExecute<string>("getEncoding"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getEventType()"/> 
        /// </summary>
        public int EventType
        {
            get { return IExecute<int>("getEventType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getLocalName()"/> 
        /// </summary>
        public string LocalName
        {
            get { return IExecute<string>("getLocalName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getLocation()"/> 
        /// </summary>
        public Javax.Xml.Stream.Location Location
        {
            get { return IExecute<Javax.Xml.Stream.Location>("getLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getName()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName Name
        {
            get { return IExecute<Javax.Xml.Namespace.QName>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceContext()"/> 
        /// </summary>
        public Javax.Xml.Namespace.NamespaceContext NamespaceContext
        {
            get { return IExecute<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceCount()"/> 
        /// </summary>
        public int NamespaceCount
        {
            get { return IExecute<int>("getNamespaceCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceURI()"/> 
        /// </summary>
        public string NamespaceURI
        {
            get { return IExecute<string>("getNamespaceURI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#setParent(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader Parent
        {
            get { return IExecute<Javax.Xml.Stream.XMLStreamReader>("getParent"); } set { IExecute("setParent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getPIData()"/> 
        /// </summary>
        public string PIData
        {
            get { return IExecute<string>("getPIData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getPITarget()"/> 
        /// </summary>
        public string PITarget
        {
            get { return IExecute<string>("getPITarget"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getPrefix()"/> 
        /// </summary>
        public string Prefix
        {
            get { return IExecute<string>("getPrefix"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getText()"/> 
        /// </summary>
        public string Text
        {
            get { return IExecute<string>("getText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextCharacters()"/> 
        /// </summary>
        public char[] TextCharacters
        {
            get { return IExecuteArray<char>("getTextCharacters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextLength()"/> 
        /// </summary>
        public int TextLength
        {
            get { return IExecute<int>("getTextLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextStart()"/> 
        /// </summary>
        public int TextStart
        {
            get { return IExecute<int>("getTextStart"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getVersion()"/> 
        /// </summary>
        public string Version
        {
            get { return IExecute<string>("getVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#hasName()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasName()
        {
            return IExecute<bool>("hasName");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#hasNext()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public bool HasNext()
        {
            return IExecute<bool>("hasNext");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#hasText()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasText()
        {
            return IExecute<bool>("hasText");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isAttributeSpecified(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeSpecified(int arg0)
        {
            return IExecute<bool>("isAttributeSpecified", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isCharacters()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCharacters()
        {
            return IExecute<bool>("isCharacters");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isEndElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEndElement()
        {
            return IExecute<bool>("isEndElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isStandalone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStandalone()
        {
            return IExecute<bool>("isStandalone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isStartElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStartElement()
        {
            return IExecute<bool>("isStartElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isWhiteSpace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsWhiteSpace()
        {
            return IExecute<bool>("isWhiteSpace");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#standaloneSet()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool StandaloneSet()
        {
            return IExecute<bool>("standaloneSet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextCharacters(int,char[],int,int)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#next()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public int Next()
        {
            return IExecute<int>("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#nextTag()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public int NextTag()
        {
            return IExecute<int>("nextTag");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeLocalName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeLocalName(int arg0)
        {
            return IExecute<string>("getAttributeLocalName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeNamespace(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeNamespace(int arg0)
        {
            return IExecute<string>("getAttributeNamespace", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributePrefix(int arg0)
        {
            return IExecute<string>("getAttributePrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeType(int arg0)
        {
            return IExecute<string>("getAttributeType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeValue(int arg0)
        {
            return IExecute<string>("getAttributeValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeValue(string arg0, string arg1)
        {
            return IExecute<string>("getAttributeValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespacePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNamespacePrefix(int arg0)
        {
            return IExecute<string>("getNamespacePrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceURI(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNamespaceURI(int arg0)
        {
            return IExecute<string>("getNamespaceURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNamespaceURI(string arg0)
        {
            return IExecute<string>("getNamespaceURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Namespace.QName"/></returns>
        public Javax.Xml.Namespace.QName GetAttributeName(int arg0)
        {
            return IExecute<Javax.Xml.Namespace.QName>("getAttributeName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#require(int,java.lang.String,java.lang.String)"/>
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