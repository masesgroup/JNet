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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom
{
    #region IEntity
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEntity : Org.W3c.Dom.INode
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getInputEncoding()"/> 
        /// </summary>
        string InputEncoding { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getNotationName()"/> 
        /// </summary>
        string NotationName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getPublicId()"/> 
        /// </summary>
        string PublicId { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getSystemId()"/> 
        /// </summary>
        string SystemId { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getXmlEncoding()"/> 
        /// </summary>
        string XmlEncoding { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getXmlVersion()"/> 
        /// </summary>
        string XmlVersion { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Entity
    public partial class Entity : Org.W3c.Dom.IEntity
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getInputEncoding()"/> 
        /// </summary>
        public string InputEncoding
        {
            get { return IExecute<string>("getInputEncoding"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getNotationName()"/> 
        /// </summary>
        public string NotationName
        {
            get { return IExecute<string>("getNotationName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getPublicId()"/> 
        /// </summary>
        public string PublicId
        {
            get { return IExecute<string>("getPublicId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getSystemId()"/> 
        /// </summary>
        public string SystemId
        {
            get { return IExecute<string>("getSystemId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getXmlEncoding()"/> 
        /// </summary>
        public string XmlEncoding
        {
            get { return IExecute<string>("getXmlEncoding"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Entity.html#getXmlVersion()"/> 
        /// </summary>
        public string XmlVersion
        {
            get { return IExecute<string>("getXmlVersion"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}