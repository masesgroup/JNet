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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
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
        public static Javax.Print.Attribute.Standard.Finishings BIND { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "BIND"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#COVER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings COVER { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "COVER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH_BOTTOM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH_BOTTOM { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH_BOTTOM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH_LEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH_LEFT { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH_LEFT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH_RIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH_RIGHT { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH_RIGHT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#EDGE_STITCH_TOP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings EDGE_STITCH_TOP { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "EDGE_STITCH_TOP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#NONE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings NONE { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "NONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#SADDLE_STITCH"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings SADDLE_STITCH { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "SADDLE_STITCH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_BOTTOM_LEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_BOTTOM_LEFT { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_BOTTOM_LEFT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_BOTTOM_RIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_BOTTOM_RIGHT { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_BOTTOM_RIGHT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_DUAL_BOTTOM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_DUAL_BOTTOM { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_DUAL_BOTTOM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_DUAL_LEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_DUAL_LEFT { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_DUAL_LEFT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_DUAL_RIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_DUAL_RIGHT { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_DUAL_RIGHT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_DUAL_TOP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_DUAL_TOP { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_DUAL_TOP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_TOP_LEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_TOP_LEFT { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_TOP_LEFT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Finishings.html#STAPLE_TOP_RIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Finishings STAPLE_TOP_RIGHT { get { return SGetField<Javax.Print.Attribute.Standard.Finishings>(LocalBridgeClazz, "STAPLE_TOP_RIGHT"); } }

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