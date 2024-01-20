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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Element
{
    #region AnnotationValueVisitor
    public partial class AnnotationValueVisitor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visit(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Element.AnnotationValue arg0, object arg1)
        {
            return IExecute("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitAnnotation(javax.lang.model.element.AnnotationMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitAnnotation(Javax.Lang.Model.Element.AnnotationMirror arg0, object arg1)
        {
            return IExecute("visitAnnotation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitArray(java.util.List,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitArray(Java.Util.List arg0, object arg1)
        {
            return IExecute("visitArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitBoolean(boolean,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitBoolean(bool arg0, object arg1)
        {
            return IExecute("visitBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitByte(byte,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitByte(byte arg0, object arg1)
        {
            return IExecute("visitByte", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitChar(char,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitChar(char arg0, object arg1)
        {
            return IExecute("visitChar", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitDouble(double,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitDouble(double arg0, object arg1)
        {
            return IExecute("visitDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitEnumConstant(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitEnumConstant(Javax.Lang.Model.Element.VariableElement arg0, object arg1)
        {
            return IExecute("visitEnumConstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitFloat(float,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitFloat(float arg0, object arg1)
        {
            return IExecute("visitFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitInt(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitInt(int arg0, object arg1)
        {
            return IExecute("visitInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitLong(long,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitLong(long arg0, object arg1)
        {
            return IExecute("visitLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitShort(short,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitShort(short arg0, object arg1)
        {
            return IExecute("visitShort", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitString(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitString(string arg0, object arg1)
        {
            return IExecute("visitString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitType(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitType(Javax.Lang.Model.Type.TypeMirror arg0, object arg1)
        {
            return IExecute("visitType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitUnknown(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitUnknown(Javax.Lang.Model.Element.AnnotationValue arg0, object arg1)
        {
            return IExecute("visitUnknown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visit(javax.lang.model.element.AnnotationValue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Element.AnnotationValue arg0)
        {
            return IExecute("visit", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IAnnotationValueVisitor<R, P>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAnnotationValueVisitor<R, P>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visit(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R Visit(Javax.Lang.Model.Element.AnnotationValue arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitAnnotation(javax.lang.model.element.AnnotationMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitAnnotation(Javax.Lang.Model.Element.AnnotationMirror arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitArray(java.util.List,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_AnnotationValue"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        R VisitArray<Arg0ExtendsJavax_Lang_Model_Element_AnnotationValue>(Java.Util.List<Arg0ExtendsJavax_Lang_Model_Element_AnnotationValue> arg0, P arg1) where Arg0ExtendsJavax_Lang_Model_Element_AnnotationValue: Javax.Lang.Model.Element.AnnotationValue;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitBoolean(boolean,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitBoolean(bool arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitByte(byte,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitByte(byte arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitChar(char,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitChar(char arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitDouble(double,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitDouble(double arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitEnumConstant(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitEnumConstant(Javax.Lang.Model.Element.VariableElement arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitFloat(float,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitFloat(float arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitInt(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitInt(int arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitLong(long,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitLong(long arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitShort(short,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitShort(short arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitString(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitString(string arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitType(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitType(Javax.Lang.Model.Type.TypeMirror arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitUnknown(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitUnknown(Javax.Lang.Model.Element.AnnotationValue arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visit(javax.lang.model.element.AnnotationValue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R Visit(Javax.Lang.Model.Element.AnnotationValue arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AnnotationValueVisitor<R, P>
    public partial class AnnotationValueVisitor<R, P> : Javax.Lang.Model.Element.IAnnotationValueVisitor<R, P>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.AnnotationValueVisitor{R, P}"/> to <see cref="Javax.Lang.Model.Element.AnnotationValueVisitor"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.AnnotationValueVisitor(Javax.Lang.Model.Element.AnnotationValueVisitor<R, P> t) => t.Cast<Javax.Lang.Model.Element.AnnotationValueVisitor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visit(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Element.AnnotationValue arg0, P arg1)
        {
            return IExecute<R>("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitAnnotation(javax.lang.model.element.AnnotationMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitAnnotation(Javax.Lang.Model.Element.AnnotationMirror arg0, P arg1)
        {
            return IExecute<R>("visitAnnotation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitArray(java.util.List,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_AnnotationValue"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitArray<Arg0ExtendsJavax_Lang_Model_Element_AnnotationValue>(Java.Util.List<Arg0ExtendsJavax_Lang_Model_Element_AnnotationValue> arg0, P arg1) where Arg0ExtendsJavax_Lang_Model_Element_AnnotationValue: Javax.Lang.Model.Element.AnnotationValue
        {
            return IExecute<R>("visitArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitBoolean(boolean,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitBoolean(bool arg0, P arg1)
        {
            return IExecute<R>("visitBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitByte(byte,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitByte(byte arg0, P arg1)
        {
            return IExecute<R>("visitByte", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitChar(char,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitChar(char arg0, P arg1)
        {
            return IExecute<R>("visitChar", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitDouble(double,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitDouble(double arg0, P arg1)
        {
            return IExecute<R>("visitDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitEnumConstant(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitEnumConstant(Javax.Lang.Model.Element.VariableElement arg0, P arg1)
        {
            return IExecute<R>("visitEnumConstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitFloat(float,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitFloat(float arg0, P arg1)
        {
            return IExecute<R>("visitFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitInt(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitInt(int arg0, P arg1)
        {
            return IExecute<R>("visitInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitLong(long,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitLong(long arg0, P arg1)
        {
            return IExecute<R>("visitLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitShort(short,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitShort(short arg0, P arg1)
        {
            return IExecute<R>("visitShort", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitString(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitString(string arg0, P arg1)
        {
            return IExecute<R>("visitString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitType(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitType(Javax.Lang.Model.Type.TypeMirror arg0, P arg1)
        {
            return IExecute<R>("visitType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visitUnknown(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitUnknown(Javax.Lang.Model.Element.AnnotationValue arg0, P arg1)
        {
            return IExecute<R>("visitUnknown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValueVisitor.html#visit(javax.lang.model.element.AnnotationValue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Element.AnnotationValue arg0)
        {
            return IExecute<R>("visit", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}