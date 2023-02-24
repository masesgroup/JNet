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
    #region CSSStyleSheet
    public partial class CSSStyleSheet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.W3c.Dom.Css.CSSStyleSheet"/> to <see cref="Org.W3c.Dom.Stylesheets.StyleSheet"/>
        /// </summary>
        public static implicit operator Org.W3c.Dom.Stylesheets.StyleSheet(Org.W3c.Dom.Css.CSSStyleSheet t) => t.Cast<Org.W3c.Dom.Stylesheets.StyleSheet>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#getCssRules()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSRuleList CssRules
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSRuleList>("getCssRules"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#getOwnerRule()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSRule OwnerRule
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSRule>("getOwnerRule"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#insertRule(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public int InsertRule(string arg0, int arg1)
        {
            return IExecute<int>("insertRule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#deleteRule(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void DeleteRule(int arg0)
        {
            IExecute("deleteRule", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}