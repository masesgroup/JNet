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

namespace Javax.Xml.Stream
{
    #region XMLInputFactory
    public partial class XMLInputFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_NAMESPACE_AWARE
        /// </summary>
        public static string IS_NAMESPACE_AWARE => Clazz.GetField<string>("IS_NAMESPACE_AWARE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_VALIDATING
        /// </summary>
        public static string IS_VALIDATING => Clazz.GetField<string>("IS_VALIDATING");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_COALESCING
        /// </summary>
        public static string IS_COALESCING => Clazz.GetField<string>("IS_COALESCING");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_REPLACING_ENTITY_REFERENCES
        /// </summary>
        public static string IS_REPLACING_ENTITY_REFERENCES => Clazz.GetField<string>("IS_REPLACING_ENTITY_REFERENCES");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_SUPPORTING_EXTERNAL_ENTITIES
        /// </summary>
        public static string IS_SUPPORTING_EXTERNAL_ENTITIES => Clazz.GetField<string>("IS_SUPPORTING_EXTERNAL_ENTITIES");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#SUPPORT_DTD
        /// </summary>
        public static string SUPPORT_DTD => Clazz.GetField<string>("SUPPORT_DTD");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#REPORTER
        /// </summary>
        public static string REPORTER => Clazz.GetField<string>("REPORTER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#RESOLVER
        /// </summary>
        public static string RESOLVER => Clazz.GetField<string>("RESOLVER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#ALLOCATOR
        /// </summary>
        public static string ALLOCATOR => Clazz.GetField<string>("ALLOCATOR");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newDefaultFactory()
        /// </summary>
        public static Javax.Xml.Stream.XMLInputFactory NewDefaultFactory()
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>("newDefaultFactory");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newFactory() throws javax.xml.stream.FactoryConfigurationError
        /// </summary>
        public static Javax.Xml.Stream.XMLInputFactory NewFactory()
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>("newFactory");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newFactory(java.lang.String,java.lang.ClassLoader) throws javax.xml.stream.FactoryConfigurationError
        /// </summary>
        public static Javax.Xml.Stream.XMLInputFactory NewFactory(string arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>("newFactory", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newInstance() throws javax.xml.stream.FactoryConfigurationError
        /// </summary>
        public static Javax.Xml.Stream.XMLInputFactory NewInstance()
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>("newInstance");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getEventAllocator() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setEventAllocator(javax.xml.stream.util.XMLEventAllocator)
        /// </summary>
        public Javax.Xml.Stream.Util.XMLEventAllocator EventAllocator
        {
            get { return IExecute<Javax.Xml.Stream.Util.XMLEventAllocator>("getEventAllocator"); } set { IExecute("setEventAllocator", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getXMLReporter() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setXMLReporter(javax.xml.stream.XMLReporter)
        /// </summary>
        public Javax.Xml.Stream.XMLReporter XMLReporter
        {
            get { return IExecute<Javax.Xml.Stream.XMLReporter>("getXMLReporter"); } set { IExecute("setXMLReporter", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getXMLResolver() https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setXMLResolver(javax.xml.stream.XMLResolver)
        /// </summary>
        public Javax.Xml.Stream.XMLResolver XMLResolver
        {
            get { return IExecute<Javax.Xml.Stream.XMLResolver>("getXMLResolver"); } set { IExecute("setXMLResolver", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#isPropertySupported(java.lang.String)
        /// </summary>
        public bool IsPropertySupported(string arg0)
        {
            return IExecute<bool>("isPropertySupported", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getProperty(java.lang.String) throws java.lang.IllegalArgumentException
        /// </summary>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createFilteredReader(javax.xml.stream.XMLEventReader,javax.xml.stream.EventFilter) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader CreateFilteredReader(Javax.Xml.Stream.XMLEventReader arg0, Javax.Xml.Stream.EventFilter arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createFilteredReader", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.io.InputStream,java.lang.String) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Io.InputStream arg0, string arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.io.InputStream) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Io.InputStream arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.io.Reader) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Io.Reader arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.lang.String,java.io.InputStream) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(string arg0, Java.Io.InputStream arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.lang.String,java.io.Reader) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(string arg0, Java.Io.Reader arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(javax.xml.stream.XMLStreamReader) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Javax.Xml.Stream.XMLStreamReader arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(javax.xml.transform.Source) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Javax.Xml.Transform.Source arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createFilteredReader(javax.xml.stream.XMLStreamReader,javax.xml.stream.StreamFilter) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader CreateFilteredReader(Javax.Xml.Stream.XMLStreamReader arg0, Javax.Xml.Stream.StreamFilter arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createFilteredReader", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.io.InputStream,java.lang.String) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Io.InputStream arg0, string arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.io.InputStream) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Io.InputStream arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.io.Reader) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Io.Reader arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.lang.String,java.io.InputStream) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(string arg0, Java.Io.InputStream arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.lang.String,java.io.Reader) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(string arg0, Java.Io.Reader arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(javax.xml.transform.Source) throws javax.xml.stream.XMLStreamException
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Javax.Xml.Transform.Source arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setProperty(java.lang.String,java.lang.Object) throws java.lang.IllegalArgumentException
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