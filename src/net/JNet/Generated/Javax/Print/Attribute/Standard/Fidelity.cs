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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region Fidelity
    public partial class Fidelity
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.Fidelity"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.Fidelity t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.Fidelity"/> to <see cref="Javax.Print.Attribute.PrintRequestAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintRequestAttribute(Javax.Print.Attribute.Standard.Fidelity t) => t.Cast<Javax.Print.Attribute.PrintRequestAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Fidelity.html#FIDELITY_FALSE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Fidelity FIDELITY_FALSE { get { if (!_FIDELITY_FALSEReady) { _FIDELITY_FALSEContent = SGetField<Javax.Print.Attribute.Standard.Fidelity>(LocalBridgeClazz, "FIDELITY_FALSE"); _FIDELITY_FALSEReady = true; } return _FIDELITY_FALSEContent; } }
        private static Javax.Print.Attribute.Standard.Fidelity _FIDELITY_FALSEContent = default;
        private static bool _FIDELITY_FALSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Fidelity.html#FIDELITY_TRUE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Fidelity FIDELITY_TRUE { get { if (!_FIDELITY_TRUEReady) { _FIDELITY_TRUEContent = SGetField<Javax.Print.Attribute.Standard.Fidelity>(LocalBridgeClazz, "FIDELITY_TRUE"); _FIDELITY_TRUEReady = true; } return _FIDELITY_TRUEContent; } }
        private static Javax.Print.Attribute.Standard.Fidelity _FIDELITY_TRUEContent = default;
        private static bool _FIDELITY_TRUEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Fidelity.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecute<Java.Lang.Class>("getCategory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Fidelity.html#getName()"/> 
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