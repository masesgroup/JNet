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

namespace Javax.Print.Attribute
{
    #region AttributeSetUtilities
    public partial class AttributeSetUtilities
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#verifyAttributeCategory(java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public static Java.Lang.Class VerifyAttributeCategory(object arg0, Java.Lang.Class arg1)
        {
            return SExecute<Java.Lang.Class>(LocalBridgeClazz, "verifyAttributeCategory", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#verifyAttributeValue(java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Javax.Print.Attribute.Attribute"/></returns>
        public static Javax.Print.Attribute.Attribute VerifyAttributeValue(object arg0, Java.Lang.Class arg1)
        {
            return SExecute<Javax.Print.Attribute.Attribute>(LocalBridgeClazz, "verifyAttributeValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#synchronizedView(javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.AttributeSet"/></returns>
        public static Javax.Print.Attribute.AttributeSet SynchronizedView(Javax.Print.Attribute.AttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.AttributeSet>(LocalBridgeClazz, "synchronizedView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#unmodifiableView(javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.AttributeSet"/></returns>
        public static Javax.Print.Attribute.AttributeSet UnmodifiableView(Javax.Print.Attribute.AttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.AttributeSet>(LocalBridgeClazz, "unmodifiableView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#synchronizedView(javax.print.attribute.DocAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.DocAttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.DocAttributeSet"/></returns>
        public static Javax.Print.Attribute.DocAttributeSet SynchronizedView(Javax.Print.Attribute.DocAttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.DocAttributeSet>(LocalBridgeClazz, "synchronizedView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#unmodifiableView(javax.print.attribute.DocAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.DocAttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.DocAttributeSet"/></returns>
        public static Javax.Print.Attribute.DocAttributeSet UnmodifiableView(Javax.Print.Attribute.DocAttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.DocAttributeSet>(LocalBridgeClazz, "unmodifiableView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#synchronizedView(javax.print.attribute.PrintJobAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintJobAttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.PrintJobAttributeSet"/></returns>
        public static Javax.Print.Attribute.PrintJobAttributeSet SynchronizedView(Javax.Print.Attribute.PrintJobAttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.PrintJobAttributeSet>(LocalBridgeClazz, "synchronizedView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#unmodifiableView(javax.print.attribute.PrintJobAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintJobAttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.PrintJobAttributeSet"/></returns>
        public static Javax.Print.Attribute.PrintJobAttributeSet UnmodifiableView(Javax.Print.Attribute.PrintJobAttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.PrintJobAttributeSet>(LocalBridgeClazz, "unmodifiableView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#synchronizedView(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></returns>
        public static Javax.Print.Attribute.PrintRequestAttributeSet SynchronizedView(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.PrintRequestAttributeSet>(LocalBridgeClazz, "synchronizedView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#unmodifiableView(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></returns>
        public static Javax.Print.Attribute.PrintRequestAttributeSet UnmodifiableView(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.PrintRequestAttributeSet>(LocalBridgeClazz, "unmodifiableView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#synchronizedView(javax.print.attribute.PrintServiceAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintServiceAttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.PrintServiceAttributeSet"/></returns>
        public static Javax.Print.Attribute.PrintServiceAttributeSet SynchronizedView(Javax.Print.Attribute.PrintServiceAttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.PrintServiceAttributeSet>(LocalBridgeClazz, "synchronizedView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#unmodifiableView(javax.print.attribute.PrintServiceAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintServiceAttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.PrintServiceAttributeSet"/></returns>
        public static Javax.Print.Attribute.PrintServiceAttributeSet UnmodifiableView(Javax.Print.Attribute.PrintServiceAttributeSet arg0)
        {
            return SExecute<Javax.Print.Attribute.PrintServiceAttributeSet>(LocalBridgeClazz, "unmodifiableView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSetUtilities.html#verifyCategoryForValue(java.lang.Class,javax.print.attribute.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.Attribute"/></param>
        public static void VerifyCategoryForValue(Java.Lang.Class arg0, Javax.Print.Attribute.Attribute arg1)
        {
            SExecute(LocalBridgeClazz, "verifyCategoryForValue", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}