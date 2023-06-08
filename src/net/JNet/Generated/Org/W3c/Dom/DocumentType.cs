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

namespace Org.W3c.Dom
{
    #region IDocumentType
    public partial interface IDocumentType
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getEntities()"/> 
        /// </summary>
        Org.W3c.Dom.NamedNodeMap Entities { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getInternalSubset()"/> 
        /// </summary>
        string InternalSubset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getName()"/> 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getNotations()"/> 
        /// </summary>
        Org.W3c.Dom.NamedNodeMap Notations { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getPublicId()"/> 
        /// </summary>
        string PublicId { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getSystemId()"/> 
        /// </summary>
        string SystemId { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DocumentType
    public partial class DocumentType : Org.W3c.Dom.IDocumentType
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getEntities()"/> 
        /// </summary>
        public Org.W3c.Dom.NamedNodeMap Entities
        {
            get { return IExecute<Org.W3c.Dom.NamedNodeMap>("getEntities"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getInternalSubset()"/> 
        /// </summary>
        public string InternalSubset
        {
            get { return IExecute<string>("getInternalSubset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getNotations()"/> 
        /// </summary>
        public Org.W3c.Dom.NamedNodeMap Notations
        {
            get { return IExecute<Org.W3c.Dom.NamedNodeMap>("getNotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getPublicId()"/> 
        /// </summary>
        public string PublicId
        {
            get { return IExecute<string>("getPublicId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getSystemId()"/> 
        /// </summary>
        public string SystemId
        {
            get { return IExecute<string>("getSystemId"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}