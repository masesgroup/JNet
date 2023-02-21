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

namespace Org.W3c.Dom.Css
{
    #region CSSPageRule
    public partial class CSSPageRule
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Org.W3c.Dom.Css.CSSRule(Org.W3c.Dom.Css.CSSPageRule t) => t.Cast<Org.W3c.Dom.Css.CSSRule>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPageRule.html#getSelectorText() https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPageRule.html#setSelectorText(java.lang.String) throws org.w3c.dom.DOMException
        /// </summary>
        public string SelectorText
        {
            get { return IExecute<string>("getSelectorText"); } set { IExecute("setSelectorText", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPageRule.html#getStyle() 
        /// </summary>
        public Org.W3c.Dom.Css.CSSStyleDeclaration Style
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSStyleDeclaration>("getStyle"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}