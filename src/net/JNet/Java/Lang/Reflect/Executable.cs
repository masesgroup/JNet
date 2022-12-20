/*
*  Copyright 2022 MASES s.r.l.
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

using MASES.JCOBridge.C2JBridge;
using Microsoft.SqlServer.Server;
using System.Diagnostics.Contracts;
using System.Xml.Linq;
using System;
using MASES.JNet;

namespace Java.Lang.Reflect
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/Executable.html"/>
    /// </summary>
    public class Executable : AccessibleObject
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.reflect.Executable";
        /// <summary>
        /// Returns an array of <see cref="AnnotatedType"/> objects that represent the use of types to specify the declared exceptions of the method/constructor represented by this <see cref="Executable"/>.
        /// </summary>
        public AnnotatedType[] AnnotatedExceptionTypes => this.IExecuteArray<AnnotatedType>("getAnnotatedExceptionTypes");
        /// <summary>
        /// Returns an array of <see cref="AnnotatedType"/> objects that represent the use of types to specify formal parameter types of the method/constructor represented by this <see cref="Executable"/>.
        /// </summary>
        public AnnotatedType[] AnnotatedParameterTypes => this.IExecuteArray<AnnotatedType>("getAnnotatedParameterTypes");
        /// <summary>
        ///  Returns an <see cref="AnnotatedType"/> object that represents the use of a type to specify the receiver type of the method/constructor represented by this <see cref="Executable"/> object.
        /// </summary>
        public AnnotatedType AnnotatedReceiverType => IExecute<AnnotatedType>("getAnnotatedReceiverType");
        /// <summary>
        /// Returns an <see cref="AnnotatedType"/> object that represents the use of a type to specify the return type of the method/constructor represented by this <see cref="Executable"/>.
        /// </summary>
        public AnnotatedType AnnotatedReturnType => IExecute<AnnotatedType>("getAnnotatedReturnType");
        /// <summary>
        /// Returns the <see cref="Class"/> object representing the class or interface that declares the executable represented by this object.
        /// </summary>
        public Class DeclaringClass => IExecute<Class>("getDeclaringClass");
        /// <summary>
        /// Returns an array of <see cref="Class"/> objects that represent the types of exceptions declared to be thrown by the underlying executable represented by this object.
        /// </summary>
        public Class[] ExceptionTypes => this.IExecuteArray<Class>("getExceptionTypes");
        /// <summary>
        /// Returns an array of Type objects that represent the exceptions declared to be thrown by this executable object.
        /// </summary>
        public Type[] GenericExceptionTypes => this.IExecuteArray<Type>("getGenericExceptionTypes");
        /// <summary>
        /// Returns an array of Type objects that represent the formal parameter types, in declaration order, of the executable represented by this object.
        /// </summary>
        public Type[] GenericParameterTypes => this.IExecuteArray<Type>("getGenericParameterTypes");
        /// <summary>
        /// Returns the Java language modifiers for the executable represented by this object.
        /// </summary>
        public int Modifiers => IExecute<int>("getModifiers");
        /// <summary>
        ///  Returns the name of the executable represented by this object.
        /// </summary>
        public string Name => IExecute<string>("getName");

        //abstract Annotation[][] getParameterAnnotations()
        //Returns an array of arrays of Annotations that represent the annotations on the formal parameters, in declaration order, of the Executable represented by this object.

        /// <summary>
        /// Returns the number of formal parameters(whether explicitly declared or implicitly declared or neither) for the executable represented by this object.
        /// </summary>
        public int ParameterCount => IExecute<int>("getParameterCount");
        /// <summary>
        /// Returns an array of Parameter objects that represent all the parameters to the underlying executable represented by this object.
        /// </summary>
        public Parameter[] Parameters => this.IExecuteArray<Parameter>("getParameters");
        /// <summary>
        /// Returns an array of Class objects that represent the formal parameter types, in declaration order, of the executable represented by this object.
        /// </summary>
        public Class[] ParameterTypes => this.IExecuteArray<Class>("getParameterTypes");
        /// <summary>
        /// Returns an array of <see cref="TypeVariable"/> objects that represent the type variables declared by the generic declaration represented by this GenericDeclaration object, in declaration order.
        /// </summary>
        public TypeVariable[] TypeParameters => this.IExecuteArray<TypeVariable>("getTypeParameters");
        /// <summary>
        /// Returns <see langword="true"/> if this executable is a synthetic construct; returns <see langword="false"/> otherwise.
        /// </summary>
        public bool IsSynthetic => IExecute<bool>("isSynthetic");
        /// <summary>
        /// Returns <see langword="true"/> if this executable was declared to take a variable number of arguments; returns <see langword="false"/> otherwise.
        /// </summary>
        public bool IsVarArgs => IExecute<bool>("isVarArgs");
        /// <summary>
        /// Returns a <see langword="string"/> describing this <see cref="Executable"/>, including any type parameters.
        /// </summary>
        /// <returns></returns>
        public string GenericString => IExecute<string>("toGenericString");
    }
}
