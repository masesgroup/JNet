/*
*  Copyright (c) 2022-2026 MASES s.r.l.
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
    #region IIterable
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/>
    /// </summary>
    public partial interface IIterable
    {
        /// <summary>
        /// Returns an iterator over elements of type <see langref="object"/>
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        Java.Util.Iterator Iterator();
    }
    #endregion

    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/>
    /// </summary>
    public class Iterable : JVMBridgeBaseEnumerable<Iterable>, IIterable
    {
        /// <inheritdoc />
        public override string BridgeClassName => "java.lang.Iterable";
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc/>
        public Iterable(IJVMBridgeBaseInitializer initializer) : base(initializer) { }
        /// <summary>
        /// Returns an iterator over elements of type <see langref="object"/>
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        public Util.Iterator Iterator() => IExecute<Util.Iterator>("iterator");
    }

    #region IIterable<E>
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/>
    /// </summary>
    public partial interface IIterable<T>
    {
        /// <summary>
        /// Returns an iterator over elements of type <typeparamref name="T"/>.
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        Java.Util.Iterator<T> Iterator();
    }
    #endregion

    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/>
    /// </summary>
    /// <typeparam name="T"><see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/></typeparam>
    public class Iterable<T> : MASES.JNet.Specific.JNetAsyncEnumerable<Iterable<T>, T>, IIterable<T>
    {
        /// <inheritdoc />
        public override string BridgeClassName => "java.lang.Iterable";
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc/>
        public Iterable(IJVMBridgeBaseInitializer initializer) : base(initializer) { }

        /// <summary>
        /// Returns an iterator over elements of type <typeparamref name="T"/>.
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        public Util.Iterator<T> Iterator() => IExecute<Util.Iterator<T>>("iterator");
    }
}
