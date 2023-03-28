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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream.Util
{
    #region EventReaderDelegate
    public partial class EventReaderDelegate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#%3Cinit%3E(javax.xml.stream.XMLEventReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLEventReader"/></param>
        public EventReaderDelegate(Javax.Xml.Stream.XMLEventReader arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Stream.Util.EventReaderDelegate"/> to <see cref="Javax.Xml.Stream.XMLEventReader"/>
        /// </summary>
        public static implicit operator Javax.Xml.Stream.XMLEventReader(Javax.Xml.Stream.Util.EventReaderDelegate t) => t.Cast<Javax.Xml.Stream.XMLEventReader>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#getElementText()"/> 
        /// </summary>
        public string ElementText
        {
            get { return IExecute<string>("getElementText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#setParent(javax.xml.stream.XMLEventReader)"/>
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader Parent
        {
            get { return IExecute<Javax.Xml.Stream.XMLEventReader>("getParent"); } set { IExecute("setParent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#hasNext()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecute<bool>("hasNext");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#next()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object Next()
        {
            return IExecute("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#nextEvent()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent NextEvent()
        {
            return IExecute<Javax.Xml.Stream.Events.XMLEvent>("nextEvent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#nextTag()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent NextTag()
        {
            return IExecute<Javax.Xml.Stream.Events.XMLEvent>("nextTag");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#peek()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent Peek()
        {
            return IExecute<Javax.Xml.Stream.Events.XMLEvent>("peek");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#close()"/>
        /// </summary>
        
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}