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

namespace Java.Lang.Reflect
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/Parameter.html"/>
    /// </summary>
#if JNETREFLECTOR
    public class Parameter : AnnotatedElement
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.reflect.Parameter";
        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;
        /// <summary>
        /// Returns an <see cref="AnnotatedType"/> object that represents the use of a type to specify the type of the formal parameter represented by this <see cref="Parameter"/>.
        /// </summary>
        public AnnotatedType AnnotatedType => IExecute<AnnotatedType>("getAnnotatedType");
        /// <summary>
        /// Get the modifier flags for this the parameter represented by this <see cref="Parameter"/> object.
        /// </summary>
        public int Modifiers => IExecute<int>("getModifiers");
        /// <summary>
        /// Returns the name of the parameter.
        /// </summary>
        public string Name => IExecute<string>("getName");
        /// <summary>
        /// Returns a <see cref="Type"/> object that identifies the parameterized type for the parameter represented by this <see cref="Parameter"/> object.
        /// </summary>
        public Type ParameterizedType => IExecute<Type>("getParameterizedType");
        /// <summary>
        /// Returns a <see cref="Class"/> object that identifies the declared type for the parameter represented by this <see cref="Parameter"/> object.
        /// </summary>
        public Class Type => IExecute<Class>("getType");
        /// <summary>
        /// Returns <see langword="true"/> if this parameter is implicitly declared in source code; returns <see langword="false"/> otherwise.
        /// </summary>
        public bool IsImplicit => IExecute<bool>("isImplicit");
        /// <summary>
        /// Returns <see langword="true"/> if the parameter has a name according to the class file; returns <see langword="false"/> otherwise.
        /// </summary>
        public bool IsNamePresent => IExecute<bool>("isNamePresent");
        /// <summary>
        /// Returns <see langword="true"/> if this parameter is neither implicitly nor explicitly declared in source code; returns <see langword="false"/> otherwise.
        /// </summary>
        public bool IsSynthetic => IExecute<bool>("isSynthetic");
        /// <summary>
        /// Returns <see langword="true"/> if this parameter represents a variable argument list; returns <see langword="false"/> otherwise.
        /// </summary>
        public bool IsVarArgs => IExecute<bool>("isVarArgs");
#else
    public partial class Parameter
    {

#endif
    }
}
