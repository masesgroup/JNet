/*
*  Copyright 2025 MASES s.r.l.
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
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/Method.html"/>
    /// </summary>
#if JNETREFLECTOR
    public class Method : Executable
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.lang.reflect.Method";
        /// <summary>
        /// Returns a <see cref="Type"/> object that represents the formal return type of the method represented by this <see cref="Method"/> object.
        /// </summary>
        public Type GenericReturnType => IExecute<Type>("getGenericReturnType");
        /// <summary>
        /// Returns a <see cref="Class"/> object that represents the formal return type of the method represented by this <see cref="Method"/> object.
        /// </summary>
        public Class ReturnType => IExecute<Class>("getReturnType");
        /// <summary>
        /// Returns <see langword="true"/> if this method is a default method; returns <see langword="false"/> otherwise.
        /// </summary>
        public bool IsDefault => IExecute<bool>("isDefault");
#else
    public partial class Method
    {
#endif
    }
}
