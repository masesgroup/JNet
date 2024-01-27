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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region Finishings
    public partial class Finishings
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.Finishings"/> to <see cref="Javax.Print.Attribute.DocAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.DocAttribute(Javax.Print.Attribute.Standard.Finishings t) => t.Cast<Javax.Print.Attribute.DocAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.Finishings"/> to <see cref="Javax.Print.Attribute.PrintRequestAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintRequestAttribute(Javax.Print.Attribute.Standard.Finishings t) => t.Cast<Javax.Print.Attribute.PrintRequestAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.Finishings"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.Finishings t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#BIND"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings BIND { get { if (!_BINDReady) { _BINDContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "BIND"); _BINDReady = true; } return _BINDContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _BINDContent = default;
        private static bool _BINDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#COVER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings COVER { get { if (!_COVERReady) { _COVERContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "COVER"); _COVERReady = true; } return _COVERContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _COVERContent = default;
        private static bool _COVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH { get { if (!_EDGE_STITCHReady) { _EDGE_STITCHContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH"); _EDGE_STITCHReady = true; } return _EDGE_STITCHContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _EDGE_STITCHContent = default;
        private static bool _EDGE_STITCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH_BOTTOM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH_BOTTOM { get { if (!_EDGE_STITCH_BOTTOMReady) { _EDGE_STITCH_BOTTOMContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH_BOTTOM"); _EDGE_STITCH_BOTTOMReady = true; } return _EDGE_STITCH_BOTTOMContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _EDGE_STITCH_BOTTOMContent = default;
        private static bool _EDGE_STITCH_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH_LEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH_LEFT { get { if (!_EDGE_STITCH_LEFTReady) { _EDGE_STITCH_LEFTContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH_LEFT"); _EDGE_STITCH_LEFTReady = true; } return _EDGE_STITCH_LEFTContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _EDGE_STITCH_LEFTContent = default;
        private static bool _EDGE_STITCH_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH_RIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH_RIGHT { get { if (!_EDGE_STITCH_RIGHTReady) { _EDGE_STITCH_RIGHTContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH_RIGHT"); _EDGE_STITCH_RIGHTReady = true; } return _EDGE_STITCH_RIGHTContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _EDGE_STITCH_RIGHTContent = default;
        private static bool _EDGE_STITCH_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH_TOP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH_TOP { get { if (!_EDGE_STITCH_TOPReady) { _EDGE_STITCH_TOPContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH_TOP"); _EDGE_STITCH_TOPReady = true; } return _EDGE_STITCH_TOPContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _EDGE_STITCH_TOPContent = default;
        private static bool _EDGE_STITCH_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#NONE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _NONEContent = default;
        private static bool _NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#SADDLE_STITCH"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings SADDLE_STITCH { get { if (!_SADDLE_STITCHReady) { _SADDLE_STITCHContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "SADDLE_STITCH"); _SADDLE_STITCHReady = true; } return _SADDLE_STITCHContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _SADDLE_STITCHContent = default;
        private static bool _SADDLE_STITCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE { get { if (!_STAPLEReady) { _STAPLEContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE"); _STAPLEReady = true; } return _STAPLEContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _STAPLEContent = default;
        private static bool _STAPLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_BOTTOM_LEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_BOTTOM_LEFT { get { if (!_STAPLE_BOTTOM_LEFTReady) { _STAPLE_BOTTOM_LEFTContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_BOTTOM_LEFT"); _STAPLE_BOTTOM_LEFTReady = true; } return _STAPLE_BOTTOM_LEFTContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _STAPLE_BOTTOM_LEFTContent = default;
        private static bool _STAPLE_BOTTOM_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_BOTTOM_RIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_BOTTOM_RIGHT { get { if (!_STAPLE_BOTTOM_RIGHTReady) { _STAPLE_BOTTOM_RIGHTContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_BOTTOM_RIGHT"); _STAPLE_BOTTOM_RIGHTReady = true; } return _STAPLE_BOTTOM_RIGHTContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _STAPLE_BOTTOM_RIGHTContent = default;
        private static bool _STAPLE_BOTTOM_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_DUAL_BOTTOM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_DUAL_BOTTOM { get { if (!_STAPLE_DUAL_BOTTOMReady) { _STAPLE_DUAL_BOTTOMContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_DUAL_BOTTOM"); _STAPLE_DUAL_BOTTOMReady = true; } return _STAPLE_DUAL_BOTTOMContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _STAPLE_DUAL_BOTTOMContent = default;
        private static bool _STAPLE_DUAL_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_DUAL_LEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_DUAL_LEFT { get { if (!_STAPLE_DUAL_LEFTReady) { _STAPLE_DUAL_LEFTContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_DUAL_LEFT"); _STAPLE_DUAL_LEFTReady = true; } return _STAPLE_DUAL_LEFTContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _STAPLE_DUAL_LEFTContent = default;
        private static bool _STAPLE_DUAL_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_DUAL_RIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_DUAL_RIGHT { get { if (!_STAPLE_DUAL_RIGHTReady) { _STAPLE_DUAL_RIGHTContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_DUAL_RIGHT"); _STAPLE_DUAL_RIGHTReady = true; } return _STAPLE_DUAL_RIGHTContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _STAPLE_DUAL_RIGHTContent = default;
        private static bool _STAPLE_DUAL_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_DUAL_TOP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_DUAL_TOP { get { if (!_STAPLE_DUAL_TOPReady) { _STAPLE_DUAL_TOPContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_DUAL_TOP"); _STAPLE_DUAL_TOPReady = true; } return _STAPLE_DUAL_TOPContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _STAPLE_DUAL_TOPContent = default;
        private static bool _STAPLE_DUAL_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_TOP_LEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_TOP_LEFT { get { if (!_STAPLE_TOP_LEFTReady) { _STAPLE_TOP_LEFTContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_TOP_LEFT"); _STAPLE_TOP_LEFTReady = true; } return _STAPLE_TOP_LEFTContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _STAPLE_TOP_LEFTContent = default;
        private static bool _STAPLE_TOP_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_TOP_RIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_TOP_RIGHT { get { if (!_STAPLE_TOP_RIGHTReady) { _STAPLE_TOP_RIGHTContent = SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_TOP_RIGHT"); _STAPLE_TOP_RIGHTReady = true; } return _STAPLE_TOP_RIGHTContent; } }
        private static Javax.Print.Attribute.Standard.Finishings _STAPLE_TOP_RIGHTContent = default;
        private static bool _STAPLE_TOP_RIGHTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecute<Java.Lang.Class>("getCategory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}