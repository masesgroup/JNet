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

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/Field.html"/>
    /// </summary>
#if JNETREFLECTOR
    public class Field : AccessibleObject
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.lang.reflect.Field";
        /// <summary>
        /// Returns an <see cref="AnnotatedType"/> object that represents the use of a type to specify the declared type of the field represented by this <see cref="Field"/>.
        /// </summary>
        public AnnotatedType AnnotatedType => IExecute<AnnotatedType>("getAnnotatedType");
        /// <summary>
        /// Returns the <see cref="Class"/> object representing the class or interface that declares the field represented by this <see cref="Field"/> object.
        /// </summary>
        public Class DeclaringClass => IExecute<Class>("getDeclaringClass");
        /// <summary>
        /// Returns a <see cref="Type"/> object that represents the declared type for the field represented by this <see cref="Field"/> object.
        /// </summary>
        public Type GenericType => IExecute<Type>("getGenericType");
        /// <summary>
        /// Returns a <see cref="Class"/> object that identifies the declared type for the field represented by this <see cref="Field"/> object.
        /// </summary>
        public Class Type => IExecute<Class>("getType");
        /// <summary>
        /// Returns the Java language modifiers for the field represented by this Field object, as an integer.
        /// </summary>
        public int Modifiers => IExecute<int>("getModifiers");
        /// <summary>
        /// Returns the name of the field represented by this <see cref="Field"/> object.
        /// </summary>
        public string Name => IExecute<string>("getName");
        /// <summary>
        /// Returns a string describing this Field, including its generic type.
        /// </summary>
        public string GenericString => IExecute<string>("toGenericString");
        /// <summary>
        /// Returns true if this field represents an element of an enumerated type; returns false otherwise.
        /// </summary>
        public bool IsEnumConstant => IExecute<bool>("isEnumConstant");
        /// <summary>
        /// Returns true if this field is a synthetic field; returns false otherwise.
        /// </summary>
        public bool IsSynthetic => IExecute<bool>("isSynthetic");
#else
    public partial class Field
    {
        /// <summary>
        /// Returns a string describing this Field, including its generic type.
        /// </summary>
        public string GenericString => IExecute<string>("toGenericString");
#endif
    }
}
