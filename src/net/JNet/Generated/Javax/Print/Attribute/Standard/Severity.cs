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
    #region Severity
    public partial class Severity
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.Severity"/> to <see cref="Javax.Print.Attribute.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.Attribute(Javax.Print.Attribute.Standard.Severity t) => t.Cast<Javax.Print.Attribute.Attribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Severity.html#ERROR"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Severity ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<Javax.Print.Attribute.Standard.Severity>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
        private static Javax.Print.Attribute.Standard.Severity _ERRORContent = default;
        private static bool _ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Severity.html#REPORT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Severity REPORT { get { if (!_REPORTReady) { _REPORTContent = SGetField<Javax.Print.Attribute.Standard.Severity>(LocalBridgeClazz, "REPORT"); _REPORTReady = true; } return _REPORTContent; } }
        private static Javax.Print.Attribute.Standard.Severity _REPORTContent = default;
        private static bool _REPORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Severity.html#WARNING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Severity WARNING { get { if (!_WARNINGReady) { _WARNINGContent = SGetField<Javax.Print.Attribute.Standard.Severity>(LocalBridgeClazz, "WARNING"); _WARNINGReady = true; } return _WARNINGContent; } }
        private static Javax.Print.Attribute.Standard.Severity _WARNINGContent = default;
        private static bool _WARNINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Severity.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecute<Java.Lang.Class>("getCategory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Severity.html#getName()"/> 
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