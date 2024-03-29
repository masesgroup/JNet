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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region TypeVariable
    public partial class TypeVariable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable"/> to <see cref="Java.Lang.Reflect.Type"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.Type(Java.Lang.Reflect.TypeVariable t) => t.Cast<Java.Lang.Reflect.Type>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable"/> to <see cref="Java.Lang.Reflect.AnnotatedElement"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.AnnotatedElement(Java.Lang.Reflect.TypeVariable t) => t.Cast<Java.Lang.Reflect.AnnotatedElement>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getAnnotatedBounds()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType[] AnnotatedBounds
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.AnnotatedType>("getAnnotatedBounds", "()[Ljava/lang/reflect/AnnotatedType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getBounds()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type[] Bounds
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.Type>("getBounds", "()[Ljava/lang/reflect/Type;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getGenericDeclaration()"/> 
        /// </summary>
        public Java.Lang.Reflect.GenericDeclaration GenericDeclaration
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.GenericDeclaration>("getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ITypeVariable<D>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITypeVariable<D>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getAnnotatedBounds()"/> 
        /// </summary>
        Java.Lang.Reflect.AnnotatedType[] AnnotatedBounds { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getBounds()"/> 
        /// </summary>
        Java.Lang.Reflect.Type[] Bounds { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getGenericDeclaration()"/> 
        /// </summary>
        D GenericDeclaration { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TypeVariable<D>
    public partial class TypeVariable<D> : Java.Lang.Reflect.ITypeVariable<D>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable{D}"/> to <see cref="Java.Lang.Reflect.Type"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.Type(Java.Lang.Reflect.TypeVariable<D> t) => t.Cast<Java.Lang.Reflect.Type>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable{D}"/> to <see cref="Java.Lang.Reflect.AnnotatedElement"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.AnnotatedElement(Java.Lang.Reflect.TypeVariable<D> t) => t.Cast<Java.Lang.Reflect.AnnotatedElement>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable{D}"/> to <see cref="Java.Lang.Reflect.TypeVariable"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.TypeVariable(Java.Lang.Reflect.TypeVariable<D> t) => t.Cast<Java.Lang.Reflect.TypeVariable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getAnnotatedBounds()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType[] AnnotatedBounds
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.AnnotatedType>("getAnnotatedBounds", "()[Ljava/lang/reflect/AnnotatedType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getBounds()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type[] Bounds
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.Type>("getBounds", "()[Ljava/lang/reflect/Type;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getGenericDeclaration()"/> 
        /// </summary>
        public D GenericDeclaration
        {
            get { return IExecuteWithSignature<D>("getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}