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

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Enum.html"/>
    /// </summary>
    public class Enum : JVMBridgeBase<Enum>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.lang.Enum";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Enum() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Enum(params object[] args) : base(args) { }
        /// <summary>
        /// Returns the name of this enum constant, exactly as declared in its enum declaration.
        /// </summary>
        public string Name => IExecute<string>("name");
        /// <summary>
        /// Returns the ordinal of this enumeration constant(its position in its enum declaration, where the initial constant is assigned an ordinal of zero).
        /// </summary>
        public int Ordinal => IExecute<int>("ordinal");
    }

    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Enum.html"/>
    /// </summary>
    /// <typeparam name="E"><see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Enum.html"/></typeparam>
    public class Enum<E> : Enum where E : Enum<E>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Enum() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Enum(params object[] args) : base(args) { }
        /// <summary>
        /// Compares this enum with the specified object for order.
        /// </summary>
        public int CompareTo(E o) => IExecute<int>("compareTo", o);
        /// <summary>
        /// Returns the <see cref="Class"/> object corresponding to this enum constant's enum type.
        /// </summary>
        public Class<E> DeclaringClass => IExecute<Class<E>>("getDeclaringClass");
        /// <summary>
        /// Returns the enum constant of the specified enum type with the specified name.
        /// </summary>
        public static T ValueOf<T>(Class<T> enumType, string name) where T : Enum<T> => SExecute<T>("valueOf", enumType, name);
    }
}
