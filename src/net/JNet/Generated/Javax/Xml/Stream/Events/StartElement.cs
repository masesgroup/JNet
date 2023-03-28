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

namespace Javax.Xml.Stream.Events
{
    #region StartElement
    public partial class StartElement
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
        public Java.Util.Iterator Attributes
        {
            get { return IExecute<Java.Util.Iterator>("getAttributes"); }
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
        public Java.Util.Iterator Namespaces
        {
            get { return IExecute<Java.Util.Iterator>("getNamespaces"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartElement.html#getNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNamespaceURI(string arg0)
        {
            return IExecute<string>("getNamespaceURI", arg0);
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