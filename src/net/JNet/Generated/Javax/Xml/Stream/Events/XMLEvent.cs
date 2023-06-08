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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream.Events
{
    #region IXMLEvent
    public partial interface IXMLEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asCharacters()"/> 
        /// </summary>
        Javax.Xml.Stream.Events.Characters AsCharacters { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asEndElement()"/> 
        /// </summary>
        Javax.Xml.Stream.Events.EndElement AsEndElement { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asStartElement()"/> 
        /// </summary>
        Javax.Xml.Stream.Events.StartElement AsStartElement { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getEventType()"/> 
        /// </summary>
        int EventType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isAttribute()"/> 
        /// </summary>
        bool IsAttribute { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isCharacters()"/> 
        /// </summary>
        bool IsCharacters { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEndDocument()"/> 
        /// </summary>
        bool IsEndDocument { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEndElement()"/> 
        /// </summary>
        bool IsEndElement { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEntityReference()"/> 
        /// </summary>
        bool IsEntityReference { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isNamespace()"/> 
        /// </summary>
        bool IsNamespace { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isProcessingInstruction()"/> 
        /// </summary>
        bool IsProcessingInstruction { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isStartDocument()"/> 
        /// </summary>
        bool IsStartDocument { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isStartElement()"/> 
        /// </summary>
        bool IsStartElement { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getLocation()"/> 
        /// </summary>
        Javax.Xml.Stream.Location Location { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getSchemaType()"/> 
        /// </summary>
        Javax.Xml.Namespace.QName SchemaType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#writeAsEncodedUnicode(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteAsEncodedUnicode(Java.Io.Writer arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLEvent
    public partial class XMLEvent : Javax.Xml.Stream.Events.IXMLEvent
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asCharacters()"/> 
        /// </summary>
        public Javax.Xml.Stream.Events.Characters AsCharacters
        {
            get { return IExecute<Javax.Xml.Stream.Events.Characters>("asCharacters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asEndElement()"/> 
        /// </summary>
        public Javax.Xml.Stream.Events.EndElement AsEndElement
        {
            get { return IExecute<Javax.Xml.Stream.Events.EndElement>("asEndElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asStartElement()"/> 
        /// </summary>
        public Javax.Xml.Stream.Events.StartElement AsStartElement
        {
            get { return IExecute<Javax.Xml.Stream.Events.StartElement>("asStartElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getEventType()"/> 
        /// </summary>
        public int EventType
        {
            get { return IExecute<int>("getEventType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isAttribute()"/> 
        /// </summary>
        public bool IsAttribute
        {
            get { return IExecute<bool>("isAttribute"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isCharacters()"/> 
        /// </summary>
        public bool IsCharacters
        {
            get { return IExecute<bool>("isCharacters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEndDocument()"/> 
        /// </summary>
        public bool IsEndDocument
        {
            get { return IExecute<bool>("isEndDocument"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEndElement()"/> 
        /// </summary>
        public bool IsEndElement
        {
            get { return IExecute<bool>("isEndElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEntityReference()"/> 
        /// </summary>
        public bool IsEntityReference
        {
            get { return IExecute<bool>("isEntityReference"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isNamespace()"/> 
        /// </summary>
        public bool IsNamespace
        {
            get { return IExecute<bool>("isNamespace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isProcessingInstruction()"/> 
        /// </summary>
        public bool IsProcessingInstruction
        {
            get { return IExecute<bool>("isProcessingInstruction"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isStartDocument()"/> 
        /// </summary>
        public bool IsStartDocument
        {
            get { return IExecute<bool>("isStartDocument"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isStartElement()"/> 
        /// </summary>
        public bool IsStartElement
        {
            get { return IExecute<bool>("isStartElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getLocation()"/> 
        /// </summary>
        public Javax.Xml.Stream.Location Location
        {
            get { return IExecute<Javax.Xml.Stream.Location>("getLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getSchemaType()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName SchemaType
        {
            get { return IExecute<Javax.Xml.Namespace.QName>("getSchemaType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#writeAsEncodedUnicode(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteAsEncodedUnicode(Java.Io.Writer arg0)
        {
            IExecute("writeAsEncodedUnicode", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}