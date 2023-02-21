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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Html
{
    #region HTMLLIElement
    public partial class HTMLLIElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Org.W3c.Dom.Html.HTMLElement(Org.W3c.Dom.Html.HTMLLIElement t) => t.Cast<Org.W3c.Dom.Html.HTMLElement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLIElement.html#getType() https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLIElement.html#setType(java.lang.String)
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); } set { IExecute("setType", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLIElement.html#getValue() https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLIElement.html#setValue(int)
        /// </summary>
        public int Value
        {
            get { return IExecute<int>("getValue"); } set { IExecute("setValue", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}