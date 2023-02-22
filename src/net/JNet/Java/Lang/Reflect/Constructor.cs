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
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/Constructor.html"/>
    /// </summary>
#if JNETREFLECTOR
    public class Constructor : Executable
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.reflect.Constructor";
#else
    public partial class Constructor
    {
#endif
}

    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/Constructor.html"/>
    /// </summary>
    public class Constructor<T> : Constructor
    {
        /// <summary>
        /// Uses the constructor represented by this <see cref="Constructor"/> object to create and initialize a new instance of the constructor's declaring class, with the specified initialization parameters.
        /// </summary>
        public T NewInstance(params object[] initargs) => initargs.Length == 0 ? IExecute<T>("newInstance") : IExecute<T>("newInstance", initargs);
    }
}
