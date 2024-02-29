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

namespace Javax.Xml.Stream
{
    #region XMLEventFactory
    public partial class XMLEventFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#newDefaultFactory()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.XMLEventFactory"/></returns>
        public static Javax.Xml.Stream.XMLEventFactory NewDefaultFactory()
        {
            return SExecuteWithSignature<Javax.Xml.Stream.XMLEventFactory>(LocalBridgeClazz, "newDefaultFactory", "()Ljavax/xml/stream/XMLEventFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#newFactory()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.XMLEventFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLEventFactory NewFactory()
        {
            return SExecuteWithSignature<Javax.Xml.Stream.XMLEventFactory>(LocalBridgeClazz, "newFactory", "()Ljavax/xml/stream/XMLEventFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#newFactory(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLEventFactory NewFactory(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Stream.XMLEventFactory>(LocalBridgeClazz, "newFactory", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#newInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.XMLEventFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLEventFactory NewInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Stream.XMLEventFactory>(LocalBridgeClazz, "newInstance", "()Ljavax/xml/stream/XMLEventFactory;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createAttribute(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Attribute"/></returns>
        public Javax.Xml.Stream.Events.Attribute CreateAttribute(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            return IExecute<Javax.Xml.Stream.Events.Attribute>("createAttribute", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createAttribute(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Attribute"/></returns>
        public Javax.Xml.Stream.Events.Attribute CreateAttribute(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Xml.Stream.Events.Attribute>("createAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createAttribute(javax.xml.namespace.QName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Attribute"/></returns>
        public Javax.Xml.Stream.Events.Attribute CreateAttribute(Javax.Xml.Namespace.QName arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Xml.Stream.Events.Attribute>("createAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createCData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Characters"/></returns>
        public Javax.Xml.Stream.Events.Characters CreateCData(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.Characters>("createCData", "(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createCharacters(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Characters"/></returns>
        public Javax.Xml.Stream.Events.Characters CreateCharacters(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.Characters>("createCharacters", "(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createIgnorableSpace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Characters"/></returns>
        public Javax.Xml.Stream.Events.Characters CreateIgnorableSpace(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.Characters>("createIgnorableSpace", "(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createSpace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Characters"/></returns>
        public Javax.Xml.Stream.Events.Characters CreateSpace(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.Characters>("createSpace", "(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Comment"/></returns>
        public Javax.Xml.Stream.Events.Comment CreateComment(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.Comment>("createComment", "(Ljava/lang/String;)Ljavax/xml/stream/events/Comment;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createDTD(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.DTD"/></returns>
        public Javax.Xml.Stream.Events.DTD CreateDTD(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.DTD>("createDTD", "(Ljava/lang/String;)Ljavax/xml/stream/events/DTD;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createEndDocument()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Events.EndDocument"/></returns>
        public Javax.Xml.Stream.Events.EndDocument CreateEndDocument()
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.EndDocument>("createEndDocument", "()Ljavax/xml/stream/events/EndDocument;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createEndElement(java.lang.String,java.lang.String,java.lang.String,java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.Iterator"/></param>
        /// <typeparam name="Arg3ExtendsJavax_Xml_Stream_Events_Namespace"><see cref="Javax.Xml.Stream.Events.Namespace"/></typeparam>
        /// <returns><see cref="Javax.Xml.Stream.Events.EndElement"/></returns>
        public Javax.Xml.Stream.Events.EndElement CreateEndElement<Arg3ExtendsJavax_Xml_Stream_Events_Namespace>(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.Iterator<Arg3ExtendsJavax_Xml_Stream_Events_Namespace> arg3) where Arg3ExtendsJavax_Xml_Stream_Events_Namespace: Javax.Xml.Stream.Events.Namespace
        {
            return IExecute<Javax.Xml.Stream.Events.EndElement>("createEndElement", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createEndElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.EndElement"/></returns>
        public Javax.Xml.Stream.Events.EndElement CreateEndElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Javax.Xml.Stream.Events.EndElement>("createEndElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createEndElement(javax.xml.namespace.QName,java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <param name="arg1"><see cref="Java.Util.Iterator"/></param>
        /// <typeparam name="Arg1ExtendsJavax_Xml_Stream_Events_Namespace"><see cref="Javax.Xml.Stream.Events.Namespace"/></typeparam>
        /// <returns><see cref="Javax.Xml.Stream.Events.EndElement"/></returns>
        public Javax.Xml.Stream.Events.EndElement CreateEndElement<Arg1ExtendsJavax_Xml_Stream_Events_Namespace>(Javax.Xml.Namespace.QName arg0, Java.Util.Iterator<Arg1ExtendsJavax_Xml_Stream_Events_Namespace> arg1) where Arg1ExtendsJavax_Xml_Stream_Events_Namespace: Javax.Xml.Stream.Events.Namespace
        {
            return IExecute<Javax.Xml.Stream.Events.EndElement>("createEndElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createEntityReference(java.lang.String,javax.xml.stream.events.EntityDeclaration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Stream.Events.EntityDeclaration"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.EntityReference"/></returns>
        public Javax.Xml.Stream.Events.EntityReference CreateEntityReference(Java.Lang.String arg0, Javax.Xml.Stream.Events.EntityDeclaration arg1)
        {
            return IExecute<Javax.Xml.Stream.Events.EntityReference>("createEntityReference", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createNamespace(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Namespace"/></returns>
        public Javax.Xml.Stream.Events.Namespace CreateNamespace(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Xml.Stream.Events.Namespace>("createNamespace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Namespace"/></returns>
        public Javax.Xml.Stream.Events.Namespace CreateNamespace(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.Namespace>("createNamespace", "(Ljava/lang/String;)Ljavax/xml/stream/events/Namespace;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createProcessingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.ProcessingInstruction"/></returns>
        public Javax.Xml.Stream.Events.ProcessingInstruction CreateProcessingInstruction(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Xml.Stream.Events.ProcessingInstruction>("createProcessingInstruction", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createStartDocument()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Events.StartDocument"/></returns>
        public Javax.Xml.Stream.Events.StartDocument CreateStartDocument()
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.StartDocument>("createStartDocument", "()Ljavax/xml/stream/events/StartDocument;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createStartDocument(java.lang.String,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.StartDocument"/></returns>
        public Javax.Xml.Stream.Events.StartDocument CreateStartDocument(Java.Lang.String arg0, Java.Lang.String arg1, bool arg2)
        {
            return IExecute<Javax.Xml.Stream.Events.StartDocument>("createStartDocument", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createStartDocument(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.StartDocument"/></returns>
        public Javax.Xml.Stream.Events.StartDocument CreateStartDocument(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Xml.Stream.Events.StartDocument>("createStartDocument", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createStartDocument(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.StartDocument"/></returns>
        public Javax.Xml.Stream.Events.StartDocument CreateStartDocument(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.StartDocument>("createStartDocument", "(Ljava/lang/String;)Ljavax/xml/stream/events/StartDocument;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createStartElement(java.lang.String,java.lang.String,java.lang.String,java.util.Iterator,java.util.Iterator,javax.xml.namespace.NamespaceContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.Iterator"/></param>
        /// <param name="arg4"><see cref="Java.Util.Iterator"/></param>
        /// <param name="arg5"><see cref="Javax.Xml.Namespace.NamespaceContext"/></param>
        /// <typeparam name="Arg3ExtendsJavax_Xml_Stream_Events_Attribute"><see cref="Javax.Xml.Stream.Events.Attribute"/></typeparam>
        /// <typeparam name="Arg4ExtendsJavax_Xml_Stream_Events_Namespace"><see cref="Javax.Xml.Stream.Events.Namespace"/></typeparam>
        /// <returns><see cref="Javax.Xml.Stream.Events.StartElement"/></returns>
        public Javax.Xml.Stream.Events.StartElement CreateStartElement<Arg3ExtendsJavax_Xml_Stream_Events_Attribute, Arg4ExtendsJavax_Xml_Stream_Events_Namespace>(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.Iterator<Arg3ExtendsJavax_Xml_Stream_Events_Attribute> arg3, Java.Util.Iterator<Arg4ExtendsJavax_Xml_Stream_Events_Namespace> arg4, Javax.Xml.Namespace.NamespaceContext arg5) where Arg3ExtendsJavax_Xml_Stream_Events_Attribute: Javax.Xml.Stream.Events.Attribute where Arg4ExtendsJavax_Xml_Stream_Events_Namespace: Javax.Xml.Stream.Events.Namespace
        {
            return IExecute<Javax.Xml.Stream.Events.StartElement>("createStartElement", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createStartElement(java.lang.String,java.lang.String,java.lang.String,java.util.Iterator,java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.Iterator"/></param>
        /// <param name="arg4"><see cref="Java.Util.Iterator"/></param>
        /// <typeparam name="Arg3ExtendsJavax_Xml_Stream_Events_Attribute"><see cref="Javax.Xml.Stream.Events.Attribute"/></typeparam>
        /// <typeparam name="Arg4ExtendsJavax_Xml_Stream_Events_Namespace"><see cref="Javax.Xml.Stream.Events.Namespace"/></typeparam>
        /// <returns><see cref="Javax.Xml.Stream.Events.StartElement"/></returns>
        public Javax.Xml.Stream.Events.StartElement CreateStartElement<Arg3ExtendsJavax_Xml_Stream_Events_Attribute, Arg4ExtendsJavax_Xml_Stream_Events_Namespace>(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.Iterator<Arg3ExtendsJavax_Xml_Stream_Events_Attribute> arg3, Java.Util.Iterator<Arg4ExtendsJavax_Xml_Stream_Events_Namespace> arg4) where Arg3ExtendsJavax_Xml_Stream_Events_Attribute: Javax.Xml.Stream.Events.Attribute where Arg4ExtendsJavax_Xml_Stream_Events_Namespace: Javax.Xml.Stream.Events.Namespace
        {
            return IExecute<Javax.Xml.Stream.Events.StartElement>("createStartElement", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createStartElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.StartElement"/></returns>
        public Javax.Xml.Stream.Events.StartElement CreateStartElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Javax.Xml.Stream.Events.StartElement>("createStartElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#createStartElement(javax.xml.namespace.QName,java.util.Iterator,java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <param name="arg1"><see cref="Java.Util.Iterator"/></param>
        /// <param name="arg2"><see cref="Java.Util.Iterator"/></param>
        /// <typeparam name="Arg1ExtendsJavax_Xml_Stream_Events_Attribute"><see cref="Javax.Xml.Stream.Events.Attribute"/></typeparam>
        /// <typeparam name="Arg2ExtendsJavax_Xml_Stream_Events_Namespace"><see cref="Javax.Xml.Stream.Events.Namespace"/></typeparam>
        /// <returns><see cref="Javax.Xml.Stream.Events.StartElement"/></returns>
        public Javax.Xml.Stream.Events.StartElement CreateStartElement<Arg1ExtendsJavax_Xml_Stream_Events_Attribute, Arg2ExtendsJavax_Xml_Stream_Events_Namespace>(Javax.Xml.Namespace.QName arg0, Java.Util.Iterator<Arg1ExtendsJavax_Xml_Stream_Events_Attribute> arg1, Java.Util.Iterator<Arg2ExtendsJavax_Xml_Stream_Events_Namespace> arg2) where Arg1ExtendsJavax_Xml_Stream_Events_Attribute: Javax.Xml.Stream.Events.Attribute where Arg2ExtendsJavax_Xml_Stream_Events_Namespace: Javax.Xml.Stream.Events.Namespace
        {
            return IExecute<Javax.Xml.Stream.Events.StartElement>("createStartElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventFactory.html#setLocation(javax.xml.stream.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.Location"/></param>
        public void SetLocation(Javax.Xml.Stream.Location arg0)
        {
            IExecuteWithSignature("setLocation", "(Ljavax/xml/stream/Location;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}