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

namespace Javax.Print.Attribute.Standard
{
    #region ReferenceUriSchemesSupported
    public partial class ReferenceUriSchemesSupported
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported"/> to <see cref="Javax.Print.Attribute.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.Attribute(Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported t) => t.Cast<Javax.Print.Attribute.Attribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#FILE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported FILE { get { return SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "FILE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#FTP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported FTP { get { return SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "FTP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#GOPHER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported GOPHER { get { return SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "GOPHER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#HTTP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported HTTP { get { return SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "HTTP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#HTTPS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported HTTPS { get { return SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "HTTPS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#NEWS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported NEWS { get { return SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "NEWS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#NNTP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported NNTP { get { return SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "NNTP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#WAIS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported WAIS { get { return SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "WAIS"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecute<Java.Lang.Class>("getCategory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#getName()"/> 
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