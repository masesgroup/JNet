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

namespace Javax.Xml.Stream.Util
{
    #region IXMLEventAllocator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXMLEventAllocator
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/XMLEventAllocator.html#allocate(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        Javax.Xml.Stream.Events.XMLEvent Allocate(Javax.Xml.Stream.XMLStreamReader arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/XMLEventAllocator.html#newInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Util.XMLEventAllocator"/></returns>
        Javax.Xml.Stream.Util.XMLEventAllocator NewInstance();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/XMLEventAllocator.html#allocate(javax.xml.stream.XMLStreamReader,javax.xml.stream.util.XMLEventConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Stream.Util.XMLEventConsumer"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Allocate(Javax.Xml.Stream.XMLStreamReader arg0, Javax.Xml.Stream.Util.XMLEventConsumer arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLEventAllocator
    public partial class XMLEventAllocator : Javax.Xml.Stream.Util.IXMLEventAllocator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/XMLEventAllocator.html#allocate(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent Allocate(Javax.Xml.Stream.XMLStreamReader arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.XMLEvent>("allocate", "(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/events/XMLEvent;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/XMLEventAllocator.html#newInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Util.XMLEventAllocator"/></returns>
        public Javax.Xml.Stream.Util.XMLEventAllocator NewInstance()
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Util.XMLEventAllocator>("newInstance", "()Ljavax/xml/stream/util/XMLEventAllocator;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/XMLEventAllocator.html#allocate(javax.xml.stream.XMLStreamReader,javax.xml.stream.util.XMLEventConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Stream.Util.XMLEventConsumer"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Allocate(Javax.Xml.Stream.XMLStreamReader arg0, Javax.Xml.Stream.Util.XMLEventConsumer arg1)
        {
            IExecute("allocate", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}