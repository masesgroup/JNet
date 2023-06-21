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

namespace Org.W3c.Dom.Css
{
    #region ICSSImportRule
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICSSImportRule : Org.W3c.Dom.Css.ICSSRule
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSImportRule.html#getHref()"/> 
        /// </summary>
        string Href { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSImportRule.html#getMedia()"/> 
        /// </summary>
        Org.W3c.Dom.Stylesheets.MediaList Media { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSImportRule.html#getStyleSheet()"/> 
        /// </summary>
        Org.W3c.Dom.Css.CSSStyleSheet StyleSheet { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CSSImportRule
    public partial class CSSImportRule : Org.W3c.Dom.Css.ICSSImportRule
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSImportRule.html#getHref()"/> 
        /// </summary>
        public string Href
        {
            get { return IExecute<string>("getHref"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSImportRule.html#getMedia()"/> 
        /// </summary>
        public Org.W3c.Dom.Stylesheets.MediaList Media
        {
            get { return IExecute<Org.W3c.Dom.Stylesheets.MediaList>("getMedia"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSImportRule.html#getStyleSheet()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSStyleSheet StyleSheet
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSStyleSheet>("getStyleSheet"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}