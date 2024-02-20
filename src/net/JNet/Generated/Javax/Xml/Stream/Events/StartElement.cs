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

namespace Javax.Xml.Stream.Events
{
    #region IStartElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStartElement : Javax.Xml.Stream.Events.IXMLEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getAttributes()"/> 
        /// </summary>
        Java.Util.Iterator<Javax.Xml.Stream.Events.Attribute> Attributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getName()"/> 
        /// </summary>
        Javax.Xml.Namespace.QName Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getNamespaceContext()"/> 
        /// </summary>
        Javax.Xml.Namespace.NamespaceContext NamespaceContext { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getNamespaces()"/> 
        /// </summary>
        Java.Util.Iterator<Javax.Xml.Stream.Events.Namespace> Namespaces { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetNamespaceURI(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getAttributeByName(javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Attribute"/></returns>
        Javax.Xml.Stream.Events.Attribute GetAttributeByName(Javax.Xml.Namespace.QName arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StartElement
    public partial class StartElement : Javax.Xml.Stream.Events.IStartElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Iterator<Javax.Xml.Stream.Events.Attribute> Attributes
        {
            get { return IExecute<Java.Util.Iterator<Javax.Xml.Stream.Events.Attribute>>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getName()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName Name
        {
            get { return IExecute<Javax.Xml.Namespace.QName>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getNamespaceContext()"/> 
        /// </summary>
        public Javax.Xml.Namespace.NamespaceContext NamespaceContext
        {
            get { return IExecute<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getNamespaces()"/> 
        /// </summary>
        public Java.Util.Iterator<Javax.Xml.Stream.Events.Namespace> Namespaces
        {
            get { return IExecute<Java.Util.Iterator<Javax.Xml.Stream.Events.Namespace>>("getNamespaces"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespaceURI(Java.Lang.String arg0)
        {
            return IExecute<Java.Lang.String>("getNamespaceURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getAttributeByName(javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="Javax.Xml.Stream.Events.Attribute"/></returns>
        public Javax.Xml.Stream.Events.Attribute GetAttributeByName(Javax.Xml.Namespace.QName arg0)
        {
            return IExecute<Javax.Xml.Stream.Events.Attribute>("getAttributeByName", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}