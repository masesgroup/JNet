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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Css
{
    #region ICSSPrimitiveValue
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICSSPrimitiveValue : Org.W3c.Dom.Css.ICSSValue
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getCounterValue()"/> 
        /// </summary>
        Org.W3c.Dom.Css.Counter CounterValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getPrimitiveType()"/> 
        /// </summary>
        short PrimitiveType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getRectValue()"/> 
        /// </summary>
        Org.W3c.Dom.Css.Rect RectValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getRGBColorValue()"/> 
        /// </summary>
        Org.W3c.Dom.Css.RGBColor RGBColorValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getStringValue()"/> 
        /// </summary>
        string StringValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getFloatValue(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        float GetFloatValue(short arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#setFloatValue(short,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SetFloatValue(short arg0, float arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#setStringValue(short,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SetStringValue(short arg0, string arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CSSPrimitiveValue
    public partial class CSSPrimitiveValue : Org.W3c.Dom.Css.ICSSPrimitiveValue
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_ATTR"/>
        /// </summary>
        public static short CSS_ATTR { get { if (!_CSS_ATTRReady) { _CSS_ATTRContent = SGetField<short>(LocalBridgeClazz, "CSS_ATTR"); _CSS_ATTRReady = true; } return _CSS_ATTRContent; } }
        private static short _CSS_ATTRContent = default;
        private static bool _CSS_ATTRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_CM"/>
        /// </summary>
        public static short CSS_CM { get { if (!_CSS_CMReady) { _CSS_CMContent = SGetField<short>(LocalBridgeClazz, "CSS_CM"); _CSS_CMReady = true; } return _CSS_CMContent; } }
        private static short _CSS_CMContent = default;
        private static bool _CSS_CMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_COUNTER"/>
        /// </summary>
        public static short CSS_COUNTER { get { if (!_CSS_COUNTERReady) { _CSS_COUNTERContent = SGetField<short>(LocalBridgeClazz, "CSS_COUNTER"); _CSS_COUNTERReady = true; } return _CSS_COUNTERContent; } }
        private static short _CSS_COUNTERContent = default;
        private static bool _CSS_COUNTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_DEG"/>
        /// </summary>
        public static short CSS_DEG { get { if (!_CSS_DEGReady) { _CSS_DEGContent = SGetField<short>(LocalBridgeClazz, "CSS_DEG"); _CSS_DEGReady = true; } return _CSS_DEGContent; } }
        private static short _CSS_DEGContent = default;
        private static bool _CSS_DEGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_DIMENSION"/>
        /// </summary>
        public static short CSS_DIMENSION { get { if (!_CSS_DIMENSIONReady) { _CSS_DIMENSIONContent = SGetField<short>(LocalBridgeClazz, "CSS_DIMENSION"); _CSS_DIMENSIONReady = true; } return _CSS_DIMENSIONContent; } }
        private static short _CSS_DIMENSIONContent = default;
        private static bool _CSS_DIMENSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_EMS"/>
        /// </summary>
        public static short CSS_EMS { get { if (!_CSS_EMSReady) { _CSS_EMSContent = SGetField<short>(LocalBridgeClazz, "CSS_EMS"); _CSS_EMSReady = true; } return _CSS_EMSContent; } }
        private static short _CSS_EMSContent = default;
        private static bool _CSS_EMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_EXS"/>
        /// </summary>
        public static short CSS_EXS { get { if (!_CSS_EXSReady) { _CSS_EXSContent = SGetField<short>(LocalBridgeClazz, "CSS_EXS"); _CSS_EXSReady = true; } return _CSS_EXSContent; } }
        private static short _CSS_EXSContent = default;
        private static bool _CSS_EXSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_GRAD"/>
        /// </summary>
        public static short CSS_GRAD { get { if (!_CSS_GRADReady) { _CSS_GRADContent = SGetField<short>(LocalBridgeClazz, "CSS_GRAD"); _CSS_GRADReady = true; } return _CSS_GRADContent; } }
        private static short _CSS_GRADContent = default;
        private static bool _CSS_GRADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_HZ"/>
        /// </summary>
        public static short CSS_HZ { get { if (!_CSS_HZReady) { _CSS_HZContent = SGetField<short>(LocalBridgeClazz, "CSS_HZ"); _CSS_HZReady = true; } return _CSS_HZContent; } }
        private static short _CSS_HZContent = default;
        private static bool _CSS_HZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_IDENT"/>
        /// </summary>
        public static short CSS_IDENT { get { if (!_CSS_IDENTReady) { _CSS_IDENTContent = SGetField<short>(LocalBridgeClazz, "CSS_IDENT"); _CSS_IDENTReady = true; } return _CSS_IDENTContent; } }
        private static short _CSS_IDENTContent = default;
        private static bool _CSS_IDENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_IN"/>
        /// </summary>
        public static short CSS_IN { get { if (!_CSS_INReady) { _CSS_INContent = SGetField<short>(LocalBridgeClazz, "CSS_IN"); _CSS_INReady = true; } return _CSS_INContent; } }
        private static short _CSS_INContent = default;
        private static bool _CSS_INReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_KHZ"/>
        /// </summary>
        public static short CSS_KHZ { get { if (!_CSS_KHZReady) { _CSS_KHZContent = SGetField<short>(LocalBridgeClazz, "CSS_KHZ"); _CSS_KHZReady = true; } return _CSS_KHZContent; } }
        private static short _CSS_KHZContent = default;
        private static bool _CSS_KHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_MM"/>
        /// </summary>
        public static short CSS_MM { get { if (!_CSS_MMReady) { _CSS_MMContent = SGetField<short>(LocalBridgeClazz, "CSS_MM"); _CSS_MMReady = true; } return _CSS_MMContent; } }
        private static short _CSS_MMContent = default;
        private static bool _CSS_MMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_MS"/>
        /// </summary>
        public static short CSS_MS { get { if (!_CSS_MSReady) { _CSS_MSContent = SGetField<short>(LocalBridgeClazz, "CSS_MS"); _CSS_MSReady = true; } return _CSS_MSContent; } }
        private static short _CSS_MSContent = default;
        private static bool _CSS_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_NUMBER"/>
        /// </summary>
        public static short CSS_NUMBER { get { if (!_CSS_NUMBERReady) { _CSS_NUMBERContent = SGetField<short>(LocalBridgeClazz, "CSS_NUMBER"); _CSS_NUMBERReady = true; } return _CSS_NUMBERContent; } }
        private static short _CSS_NUMBERContent = default;
        private static bool _CSS_NUMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_PC"/>
        /// </summary>
        public static short CSS_PC { get { if (!_CSS_PCReady) { _CSS_PCContent = SGetField<short>(LocalBridgeClazz, "CSS_PC"); _CSS_PCReady = true; } return _CSS_PCContent; } }
        private static short _CSS_PCContent = default;
        private static bool _CSS_PCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_PERCENTAGE"/>
        /// </summary>
        public static short CSS_PERCENTAGE { get { if (!_CSS_PERCENTAGEReady) { _CSS_PERCENTAGEContent = SGetField<short>(LocalBridgeClazz, "CSS_PERCENTAGE"); _CSS_PERCENTAGEReady = true; } return _CSS_PERCENTAGEContent; } }
        private static short _CSS_PERCENTAGEContent = default;
        private static bool _CSS_PERCENTAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_PT"/>
        /// </summary>
        public static short CSS_PT { get { if (!_CSS_PTReady) { _CSS_PTContent = SGetField<short>(LocalBridgeClazz, "CSS_PT"); _CSS_PTReady = true; } return _CSS_PTContent; } }
        private static short _CSS_PTContent = default;
        private static bool _CSS_PTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_PX"/>
        /// </summary>
        public static short CSS_PX { get { if (!_CSS_PXReady) { _CSS_PXContent = SGetField<short>(LocalBridgeClazz, "CSS_PX"); _CSS_PXReady = true; } return _CSS_PXContent; } }
        private static short _CSS_PXContent = default;
        private static bool _CSS_PXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_RAD"/>
        /// </summary>
        public static short CSS_RAD { get { if (!_CSS_RADReady) { _CSS_RADContent = SGetField<short>(LocalBridgeClazz, "CSS_RAD"); _CSS_RADReady = true; } return _CSS_RADContent; } }
        private static short _CSS_RADContent = default;
        private static bool _CSS_RADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_RECT"/>
        /// </summary>
        public static short CSS_RECT { get { if (!_CSS_RECTReady) { _CSS_RECTContent = SGetField<short>(LocalBridgeClazz, "CSS_RECT"); _CSS_RECTReady = true; } return _CSS_RECTContent; } }
        private static short _CSS_RECTContent = default;
        private static bool _CSS_RECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_RGBCOLOR"/>
        /// </summary>
        public static short CSS_RGBCOLOR { get { if (!_CSS_RGBCOLORReady) { _CSS_RGBCOLORContent = SGetField<short>(LocalBridgeClazz, "CSS_RGBCOLOR"); _CSS_RGBCOLORReady = true; } return _CSS_RGBCOLORContent; } }
        private static short _CSS_RGBCOLORContent = default;
        private static bool _CSS_RGBCOLORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_S"/>
        /// </summary>
        public static short CSS_S { get { if (!_CSS_SReady) { _CSS_SContent = SGetField<short>(LocalBridgeClazz, "CSS_S"); _CSS_SReady = true; } return _CSS_SContent; } }
        private static short _CSS_SContent = default;
        private static bool _CSS_SReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_STRING"/>
        /// </summary>
        public static short CSS_STRING { get { if (!_CSS_STRINGReady) { _CSS_STRINGContent = SGetField<short>(LocalBridgeClazz, "CSS_STRING"); _CSS_STRINGReady = true; } return _CSS_STRINGContent; } }
        private static short _CSS_STRINGContent = default;
        private static bool _CSS_STRINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_UNKNOWN"/>
        /// </summary>
        public static short CSS_UNKNOWN { get { if (!_CSS_UNKNOWNReady) { _CSS_UNKNOWNContent = SGetField<short>(LocalBridgeClazz, "CSS_UNKNOWN"); _CSS_UNKNOWNReady = true; } return _CSS_UNKNOWNContent; } }
        private static short _CSS_UNKNOWNContent = default;
        private static bool _CSS_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_URI"/>
        /// </summary>
        public static short CSS_URI { get { if (!_CSS_URIReady) { _CSS_URIContent = SGetField<short>(LocalBridgeClazz, "CSS_URI"); _CSS_URIReady = true; } return _CSS_URIContent; } }
        private static short _CSS_URIContent = default;
        private static bool _CSS_URIReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getCounterValue()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.Counter CounterValue
        {
            get { return IExecute<Org.W3c.Dom.Css.Counter>("getCounterValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getPrimitiveType()"/> 
        /// </summary>
        public short PrimitiveType
        {
            get { return IExecute<short>("getPrimitiveType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getRectValue()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.Rect RectValue
        {
            get { return IExecute<Org.W3c.Dom.Css.Rect>("getRectValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getRGBColorValue()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.RGBColor RGBColorValue
        {
            get { return IExecute<Org.W3c.Dom.Css.RGBColor>("getRGBColorValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getStringValue()"/> 
        /// </summary>
        public string StringValue
        {
            get { return IExecute<string>("getStringValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getFloatValue(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public float GetFloatValue(short arg0)
        {
            return IExecute<float>("getFloatValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#setFloatValue(short,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetFloatValue(short arg0, float arg1)
        {
            IExecute("setFloatValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#setStringValue(short,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetStringValue(short arg0, string arg1)
        {
            IExecute("setStringValue", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}