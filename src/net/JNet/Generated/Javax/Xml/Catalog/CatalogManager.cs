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

namespace Javax.Xml.Catalog
{
    #region CatalogManager
    public partial class CatalogManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogManager.html#catalog(javax.xml.catalog.CatalogFeatures,java.net.URI[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Catalog.CatalogFeatures"/></param>
        /// <param name="arg1"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Javax.Xml.Catalog.Catalog"/></returns>
        public static Javax.Xml.Catalog.Catalog Catalog(Javax.Xml.Catalog.CatalogFeatures arg0, params Java.Net.URI[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Javax.Xml.Catalog.Catalog>("catalog", arg0); else return SExecute<Javax.Xml.Catalog.Catalog>("catalog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogManager.html#catalogResolver(javax.xml.catalog.Catalog)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Catalog.Catalog"/></param>
        /// <returns><see cref="Javax.Xml.Catalog.CatalogResolver"/></returns>
        public static Javax.Xml.Catalog.CatalogResolver CatalogResolver(Javax.Xml.Catalog.Catalog arg0)
        {
            return SExecute<Javax.Xml.Catalog.CatalogResolver>("catalogResolver", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogManager.html#catalogResolver(javax.xml.catalog.CatalogFeatures,java.net.URI[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Catalog.CatalogFeatures"/></param>
        /// <param name="arg1"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Javax.Xml.Catalog.CatalogResolver"/></returns>
        public static Javax.Xml.Catalog.CatalogResolver CatalogResolver(Javax.Xml.Catalog.CatalogFeatures arg0, params Java.Net.URI[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Javax.Xml.Catalog.CatalogResolver>("catalogResolver", arg0); else return SExecute<Javax.Xml.Catalog.CatalogResolver>("catalogResolver", arg0, arg1);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}