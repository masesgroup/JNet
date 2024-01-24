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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region PresentationDirection
    public partial class PresentationDirection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PresentationDirection"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.PresentationDirection t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PresentationDirection"/> to <see cref="Javax.Print.Attribute.PrintRequestAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintRequestAttribute(Javax.Print.Attribute.Standard.PresentationDirection t) => t.Cast<Javax.Print.Attribute.PrintRequestAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOBOTTOM_TOLEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOBOTTOM_TOLEFT { get { if (!_TOBOTTOM_TOLEFTReady) { _TOBOTTOM_TOLEFTContent = SGetField<Javax.Print.Attribute.Standard.PresentationDirection>(LocalBridgeClazz, "TOBOTTOM_TOLEFT"); _TOBOTTOM_TOLEFTReady = true; } return _TOBOTTOM_TOLEFTContent; } }
        private static Javax.Print.Attribute.Standard.PresentationDirection _TOBOTTOM_TOLEFTContent = default;
        private static bool _TOBOTTOM_TOLEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOBOTTOM_TORIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOBOTTOM_TORIGHT { get { if (!_TOBOTTOM_TORIGHTReady) { _TOBOTTOM_TORIGHTContent = SGetField<Javax.Print.Attribute.Standard.PresentationDirection>(LocalBridgeClazz, "TOBOTTOM_TORIGHT"); _TOBOTTOM_TORIGHTReady = true; } return _TOBOTTOM_TORIGHTContent; } }
        private static Javax.Print.Attribute.Standard.PresentationDirection _TOBOTTOM_TORIGHTContent = default;
        private static bool _TOBOTTOM_TORIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOLEFT_TOBOTTOM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOLEFT_TOBOTTOM { get { if (!_TOLEFT_TOBOTTOMReady) { _TOLEFT_TOBOTTOMContent = SGetField<Javax.Print.Attribute.Standard.PresentationDirection>(LocalBridgeClazz, "TOLEFT_TOBOTTOM"); _TOLEFT_TOBOTTOMReady = true; } return _TOLEFT_TOBOTTOMContent; } }
        private static Javax.Print.Attribute.Standard.PresentationDirection _TOLEFT_TOBOTTOMContent = default;
        private static bool _TOLEFT_TOBOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOLEFT_TOTOP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOLEFT_TOTOP { get { if (!_TOLEFT_TOTOPReady) { _TOLEFT_TOTOPContent = SGetField<Javax.Print.Attribute.Standard.PresentationDirection>(LocalBridgeClazz, "TOLEFT_TOTOP"); _TOLEFT_TOTOPReady = true; } return _TOLEFT_TOTOPContent; } }
        private static Javax.Print.Attribute.Standard.PresentationDirection _TOLEFT_TOTOPContent = default;
        private static bool _TOLEFT_TOTOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TORIGHT_TOBOTTOM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TORIGHT_TOBOTTOM { get { if (!_TORIGHT_TOBOTTOMReady) { _TORIGHT_TOBOTTOMContent = SGetField<Javax.Print.Attribute.Standard.PresentationDirection>(LocalBridgeClazz, "TORIGHT_TOBOTTOM"); _TORIGHT_TOBOTTOMReady = true; } return _TORIGHT_TOBOTTOMContent; } }
        private static Javax.Print.Attribute.Standard.PresentationDirection _TORIGHT_TOBOTTOMContent = default;
        private static bool _TORIGHT_TOBOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TORIGHT_TOTOP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TORIGHT_TOTOP { get { if (!_TORIGHT_TOTOPReady) { _TORIGHT_TOTOPContent = SGetField<Javax.Print.Attribute.Standard.PresentationDirection>(LocalBridgeClazz, "TORIGHT_TOTOP"); _TORIGHT_TOTOPReady = true; } return _TORIGHT_TOTOPContent; } }
        private static Javax.Print.Attribute.Standard.PresentationDirection _TORIGHT_TOTOPContent = default;
        private static bool _TORIGHT_TOTOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOTOP_TOLEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOTOP_TOLEFT { get { if (!_TOTOP_TOLEFTReady) { _TOTOP_TOLEFTContent = SGetField<Javax.Print.Attribute.Standard.PresentationDirection>(LocalBridgeClazz, "TOTOP_TOLEFT"); _TOTOP_TOLEFTReady = true; } return _TOTOP_TOLEFTContent; } }
        private static Javax.Print.Attribute.Standard.PresentationDirection _TOTOP_TOLEFTContent = default;
        private static bool _TOTOP_TOLEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOTOP_TORIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOTOP_TORIGHT { get { if (!_TOTOP_TORIGHTReady) { _TOTOP_TORIGHTContent = SGetField<Javax.Print.Attribute.Standard.PresentationDirection>(LocalBridgeClazz, "TOTOP_TORIGHT"); _TOTOP_TORIGHTReady = true; } return _TOTOP_TORIGHTContent; } }
        private static Javax.Print.Attribute.Standard.PresentationDirection _TOTOP_TORIGHTContent = default;
        private static bool _TOTOP_TORIGHTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecute<Java.Lang.Class>("getCategory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#getName()"/> 
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