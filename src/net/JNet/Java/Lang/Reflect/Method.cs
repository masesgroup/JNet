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
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/Method.html"/>
    /// </summary>
    public class Method : Executable
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.reflect.Method";

        /// <summary>
        /// Returns the default value for the annotation member represented by this <see cref="Method"/> instance.
        /// </summary>
        public object DefaultValue => IExecute("getDefaultValue");
        /// <summary>
        /// Returns a <see cref="Type"/> object that represents the formal return type of the method represented by this <see cref="Method"/> object.
        /// </summary>
        public Type GenericReturnType => IExecute<Type>("getGenericReturnType");
        /// <summary>
        /// Returns a <see cref="Class"/> object that represents the formal return type of the method represented by this <see cref="Method"/> object.
        /// </summary>
        public Class ReturnType => IExecute<Class>("getReturnType");
        /// <summary>
        /// Invokes the underlying method represented by this Method object, on the specified object with the specified parameters.
        /// </summary>
        public object Invoke(object obj, params object[] args) => IExecute("invoke", obj, args);
        /// <summary>
        /// Returns <see langword="true"/> if this method is a bridge method; returns <see langword="false"/> otherwise.
        /// </summary>
        public bool IsBridge => IExecute<bool>("isBridge");
        /// <summary>
        /// Returns <see langword="true"/> if this method is a default method; returns <see langword="false"/> otherwise.
        /// </summary>
        public bool IsDefault => IExecute<bool>("isDefault");
    }
}
