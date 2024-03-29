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

namespace Org.W3c.Dom
{
    #region IDOMErrorHandler
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDOMErrorHandler
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMErrorHandler.html#handleError(org.w3c.dom.DOMError)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.DOMError"/></param>
        /// <returns><see cref="bool"/></returns>
        bool HandleError(Org.W3c.Dom.DOMError arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DOMErrorHandler
    public partial class DOMErrorHandler : Org.W3c.Dom.IDOMErrorHandler
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMErrorHandler.html#handleError(org.w3c.dom.DOMError)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.DOMError"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HandleError(Org.W3c.Dom.DOMError arg0)
        {
            return IExecuteWithSignature<bool>("handleError", "(Lorg/w3c/dom/DOMError;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}