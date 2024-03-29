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
    #region Executable
    public partial class Executable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.Executable"/> to <see cref="Java.Lang.Reflect.Member"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.Member(Java.Lang.Reflect.Executable t) => t.Cast<Java.Lang.Reflect.Member>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.Executable"/> to <see cref="Java.Lang.Reflect.GenericDeclaration"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.GenericDeclaration(Java.Lang.Reflect.Executable t) => t.Cast<Java.Lang.Reflect.GenericDeclaration>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getAnnotatedExceptionTypes()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType[] AnnotatedExceptionTypes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.AnnotatedType>("getAnnotatedExceptionTypes", "()[Ljava/lang/reflect/AnnotatedType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getAnnotatedParameterTypes()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType[] AnnotatedParameterTypes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.AnnotatedType>("getAnnotatedParameterTypes", "()[Ljava/lang/reflect/AnnotatedType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getAnnotatedReceiverType()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType AnnotatedReceiverType
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.AnnotatedType>("getAnnotatedReceiverType", "()Ljava/lang/reflect/AnnotatedType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getAnnotatedReturnType()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType AnnotatedReturnType
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.AnnotatedType>("getAnnotatedReturnType", "()Ljava/lang/reflect/AnnotatedType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getDeclaringClass()"/> 
        /// </summary>
        public Java.Lang.Class DeclaringClass
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getDeclaringClass", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getExceptionTypes()"/> 
        /// </summary>
        public Java.Lang.Class[] ExceptionTypes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Class>("getExceptionTypes", "()[Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getGenericExceptionTypes()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type[] GenericExceptionTypes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.Type>("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getGenericParameterTypes()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type[] GenericParameterTypes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.Type>("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getModifiers()"/> 
        /// </summary>
        public int Modifiers
        {
            get { return IExecuteWithSignature<int>("getModifiers", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getParameterAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] ParameterAnnotations
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getParameterCount()"/> 
        /// </summary>
        public int ParameterCount
        {
            get { return IExecuteWithSignature<int>("getParameterCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getParameters()"/> 
        /// </summary>
        public Java.Lang.Reflect.Parameter[] Parameters
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.Parameter>("getParameters", "()[Ljava/lang/reflect/Parameter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getParameterTypes()"/> 
        /// </summary>
        public Java.Lang.Class[] ParameterTypes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Class>("getParameterTypes", "()[Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getTypeParameters()"/> 
        /// </summary>
        public Java.Lang.Reflect.TypeVariable[] TypeParameters
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.TypeVariable>("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#toGenericString()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToGenericString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toGenericString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#isSynthetic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSynthetic()
        {
            return IExecuteWithSignature<bool>("isSynthetic", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#isVarArgs()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVarArgs()
        {
            return IExecuteWithSignature<bool>("isVarArgs", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}