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

namespace Javax.Xml.Catalog
{
    #region ICatalogResolver
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICatalogResolver
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogResolver.html#resolve(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Source"/></returns>
        Javax.Xml.Transform.Source Resolve(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogResolver.html#resolveResource(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSInput"/></returns>
        Org.W3c.Dom.Ls.LSInput ResolveResource(string arg0, string arg1, string arg2, string arg3, string arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogResolver.html#resolveEntity(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        Org.Xml.Sax.InputSource ResolveEntity(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogResolver.html#resolveEntity(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        object ResolveEntity(string arg0, string arg1, string arg2, string arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CatalogResolver
    public partial class CatalogResolver : Javax.Xml.Catalog.ICatalogResolver
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Catalog.CatalogResolver"/> to <see cref="Org.Xml.Sax.EntityResolver"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.EntityResolver(Javax.Xml.Catalog.CatalogResolver t) => t.Cast<Org.Xml.Sax.EntityResolver>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Catalog.CatalogResolver"/> to <see cref="Javax.Xml.Stream.XMLResolver"/>
        /// </summary>
        public static implicit operator Javax.Xml.Stream.XMLResolver(Javax.Xml.Catalog.CatalogResolver t) => t.Cast<Javax.Xml.Stream.XMLResolver>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Catalog.CatalogResolver"/> to <see cref="Javax.Xml.Transform.URIResolver"/>
        /// </summary>
        public static implicit operator Javax.Xml.Transform.URIResolver(Javax.Xml.Catalog.CatalogResolver t) => t.Cast<Javax.Xml.Transform.URIResolver>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Catalog.CatalogResolver"/> to <see cref="Org.W3c.Dom.Ls.LSResourceResolver"/>
        /// </summary>
        public static implicit operator Org.W3c.Dom.Ls.LSResourceResolver(Javax.Xml.Catalog.CatalogResolver t) => t.Cast<Org.W3c.Dom.Ls.LSResourceResolver>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogResolver.html#resolve(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Source"/></returns>
        public Javax.Xml.Transform.Source Resolve(string arg0, string arg1)
        {
            return IExecute<Javax.Xml.Transform.Source>("resolve", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogResolver.html#resolveResource(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSInput"/></returns>
        public Org.W3c.Dom.Ls.LSInput ResolveResource(string arg0, string arg1, string arg2, string arg3, string arg4)
        {
            return IExecute<Org.W3c.Dom.Ls.LSInput>("resolveResource", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogResolver.html#resolveEntity(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        public Org.Xml.Sax.InputSource ResolveEntity(string arg0, string arg1)
        {
            return IExecute<Org.Xml.Sax.InputSource>("resolveEntity", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogResolver.html#resolveEntity(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public object ResolveEntity(string arg0, string arg1, string arg2, string arg3)
        {
            return IExecute("resolveEntity", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}