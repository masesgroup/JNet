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

namespace Org.W3c.Dom.Css
{
    #region CSSValue
    public partial class CSSValue
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#CSS_CUSTOM"/>
        /// </summary>
        public static short CSS_CUSTOM { get { return SGetField<short>(LocalBridgeClazz, "CSS_CUSTOM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#CSS_INHERIT"/>
        /// </summary>
        public static short CSS_INHERIT { get { return SGetField<short>(LocalBridgeClazz, "CSS_INHERIT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#CSS_PRIMITIVE_VALUE"/>
        /// </summary>
        public static short CSS_PRIMITIVE_VALUE { get { return SGetField<short>(LocalBridgeClazz, "CSS_PRIMITIVE_VALUE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#CSS_VALUE_LIST"/>
        /// </summary>
        public static short CSS_VALUE_LIST { get { return SGetField<short>(LocalBridgeClazz, "CSS_VALUE_LIST"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#getCssText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#setCssText(java.lang.String)"/>
        /// </summary>
        public string CssText
        {
            get { return IExecute<string>("getCssText"); } set { IExecute("setCssText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#getCssValueType()"/> 
        /// </summary>
        public short CssValueType
        {
            get { return IExecute<short>("getCssValueType"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}