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
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/ParameterizedType.html"/>
    /// </summary>
#if JNETREFLECTOR
    public class ParameterizedType : Type
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.reflect.ParameterizedType";
        /// <summary>
        /// Returns an array of <see cref="Type"/> objects representing the actual type arguments to this type.
        /// </summary>
        public Type[] ActualTypeArguments => IExecuteArray<Type>("getActualTypeArguments");
        /// <summary>
        /// Returns a <see cref="Type"/> object representing the type that this type is a member of.
        /// </summary>
        public Type OwnerType => IExecute<Type>("getOwnerType");
        /// <summary>
        /// Returns the <see cref="Type"/> object representing the class or interface that declared this type.
        /// </summary>
        public Type RawType => IExecute<Type>("getOwnerType");
#else
    public partial class ParameterizedType
    {

#endif
    }
}
