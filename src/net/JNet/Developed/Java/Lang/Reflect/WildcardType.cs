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
using MASES.JNet;

namespace Java.Lang.Reflect
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/WildcardType.html"/>
    /// </summary>
#if JNETREFLECTOR
    public class WildcardType : Type
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.lang.reflect.WildcardType";
        /// <summary>
        /// Returns an array of <see cref="Type"/> objects representing the lower bound(s) of this type variable.
        /// </summary>
        public Type[] LowerBounds => IExecuteArray<Type>("getLowerBounds");
        /// <summary>
        /// Returns an array of <see cref="Type"/> objects representing the upper bound(s) of this type variable.
        /// </summary>
        public Type[] UpperBounds => IExecuteArray<Type>("getUpperBounds");
#else
    public partial class WildcardType
    {

#endif
}
}
