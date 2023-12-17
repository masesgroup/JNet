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

namespace Javax.Lang.Model.Element
{
    #region ITypeElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITypeElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getEnclosedElements()"/> 
        /// </summary>
        Java.Util.List EnclosedElements { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getEnclosingElement()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Element EnclosingElement { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getInterfaces()"/> 
        /// </summary>
        Java.Util.List Interfaces { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getNestingKind()"/> 
        /// </summary>
        Javax.Lang.Model.Element.NestingKind NestingKind { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getQualifiedName()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Name QualifiedName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getSimpleName()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Name SimpleName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getSuperclass()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror Superclass { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getTypeParameters()"/> 
        /// </summary>
        Java.Util.List TypeParameters { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TypeElement
    public partial class TypeElement : Javax.Lang.Model.Element.ITypeElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.TypeElement"/> to <see cref="Javax.Lang.Model.Element.Element"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.Element(Javax.Lang.Model.Element.TypeElement t) => t.Cast<Javax.Lang.Model.Element.Element>();
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.TypeElement"/> to <see cref="Javax.Lang.Model.Element.Parameterizable"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.Parameterizable(Javax.Lang.Model.Element.TypeElement t) => t.Cast<Javax.Lang.Model.Element.Parameterizable>();
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.TypeElement"/> to <see cref="Javax.Lang.Model.Element.QualifiedNameable"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.QualifiedNameable(Javax.Lang.Model.Element.TypeElement t) => t.Cast<Javax.Lang.Model.Element.QualifiedNameable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getEnclosedElements()"/> 
        /// </summary>
        public Java.Util.List EnclosedElements
        {
            get { return IExecute<Java.Util.List>("getEnclosedElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getEnclosingElement()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Element EnclosingElement
        {
            get { return IExecute<Javax.Lang.Model.Element.Element>("getEnclosingElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getInterfaces()"/> 
        /// </summary>
        public Java.Util.List Interfaces
        {
            get { return IExecute<Java.Util.List>("getInterfaces"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getNestingKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.NestingKind NestingKind
        {
            get { return IExecute<Javax.Lang.Model.Element.NestingKind>("getNestingKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getQualifiedName()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Name QualifiedName
        {
            get { return IExecute<Javax.Lang.Model.Element.Name>("getQualifiedName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getSimpleName()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Name SimpleName
        {
            get { return IExecute<Javax.Lang.Model.Element.Name>("getSimpleName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getSuperclass()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror Superclass
        {
            get { return IExecute<Javax.Lang.Model.Type.TypeMirror>("getSuperclass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getTypeParameters()"/> 
        /// </summary>
        public Java.Util.List TypeParameters
        {
            get { return IExecute<Java.Util.List>("getTypeParameters"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}