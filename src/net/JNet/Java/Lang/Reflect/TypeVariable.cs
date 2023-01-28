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

using MASES.JCOBridge.C2JBridge;
using MASES.JNet;

namespace Java.Lang.Reflect
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/TypeVariable.html"/>
    /// </summary>
    public class TypeVariable : AnnotatedElement
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.reflect.TypeVariable";

        public static implicit operator Type(TypeVariable t) => t.Cast<Type>();

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;
        /// <summary>
        /// Returns an array of <see cref="AnnotatedType"/> objects that represent the use of types to denote the upper bounds of the type parameter represented by this <see cref="TypeVariable"/>.
        /// </summary>
        public AnnotatedType[] AnnotatedBounds => IExecuteArray<AnnotatedType>("getAnnotatedBounds");
        /// <summary>
        /// Returns an array of <see cref="Type"/> objects representing the upper bound(s) of this type variable.
        /// </summary>
        public Type[] Bounds => IExecuteArray<Type>("getBounds");
        /// <summary>
        /// Returns the name of this type variable, as it occurs in the source code.
        /// </summary>
        public string Name => IExecute<string>("getName");
    }

    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/TypeVariable.html"/>
    /// </summary>
    public class TypeVariable<D> : TypeVariable where D : GenericDeclaration
    {
        /// <summary>
        /// Returns the <see cref="GenericDeclaration"/> object representing the generic declaration declared this type variable.
        /// </summary>
        public D GenericDeclaration => IExecute<D>("getGenericDeclaration");
    }
}
