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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Bootstrap
{
    #region DOMImplementationRegistry
    public partial class DOMImplementationRegistry
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#PROPERTY"/>
        /// </summary>
        public static string PROPERTY => LocalClazz.GetField<string>("PROPERTY");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#newInstance()"/> 
        /// </summary>
        public static Org.W3c.Dom.Bootstrap.DOMImplementationRegistry NewInstance
        {
            get { return SExecute<Org.W3c.Dom.Bootstrap.DOMImplementationRegistry>(LocalClazz, "newInstance"); }
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#getDOMImplementation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.DOMImplementation"/></returns>
        public Org.W3c.Dom.DOMImplementation GetDOMImplementation(string arg0)
        {
            return IExecute<Org.W3c.Dom.DOMImplementation>("getDOMImplementation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#getDOMImplementationList(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.DOMImplementationList"/></returns>
        public Org.W3c.Dom.DOMImplementationList GetDOMImplementationList(string arg0)
        {
            return IExecute<Org.W3c.Dom.DOMImplementationList>("getDOMImplementationList", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#addSource(org.w3c.dom.DOMImplementationSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.DOMImplementationSource"/></param>
        public void AddSource(Org.W3c.Dom.DOMImplementationSource arg0)
        {
            IExecute("addSource", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}