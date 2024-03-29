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

namespace Javax.Xml.Stream
{
    #region IXMLEventWriter
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXMLEventWriter : Javax.Xml.Stream.Util.IXMLEventConsumer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#getNamespaceContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#setNamespaceContext(javax.xml.namespace.NamespaceContext)"/>
        /// </summary>
        Javax.Xml.Namespace.NamespaceContext NamespaceContext { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#getPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        Java.Lang.String GetPrefix(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#add(javax.xml.stream.events.XMLEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.Events.XMLEvent"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Add(Javax.Xml.Stream.Events.XMLEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#add(javax.xml.stream.XMLEventReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLEventReader"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Add(Javax.Xml.Stream.XMLEventReader arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#flush()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Flush();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#setDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void SetDefaultNamespace(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#setPrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void SetPrefix(Java.Lang.String arg0, Java.Lang.String arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLEventWriter
    public partial class XMLEventWriter : Javax.Xml.Stream.IXMLEventWriter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#getNamespaceContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#setNamespaceContext(javax.xml.namespace.NamespaceContext)"/>
        /// </summary>
        public Javax.Xml.Namespace.NamespaceContext NamespaceContext
        {
            get { return IExecuteWithSignature<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext", "()Ljavax/xml/namespace/NamespaceContext;"); } set { IExecuteWithSignature("setNamespaceContext", "(Ljavax/xml/namespace/NamespaceContext;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#getPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Java.Lang.String GetPrefix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getPrefix", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#add(javax.xml.stream.events.XMLEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.Events.XMLEvent"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Add(Javax.Xml.Stream.Events.XMLEvent arg0)
        {
            IExecuteWithSignature("add", "(Ljavax/xml/stream/events/XMLEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#add(javax.xml.stream.XMLEventReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLEventReader"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Add(Javax.Xml.Stream.XMLEventReader arg0)
        {
            IExecuteWithSignature("add", "(Ljavax/xml/stream/XMLEventReader;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#flush()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#setDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void SetDefaultNamespace(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDefaultNamespace", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventWriter.html#setPrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void SetPrefix(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("setPrefix", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}