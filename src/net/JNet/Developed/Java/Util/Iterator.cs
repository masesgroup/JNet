/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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
using System.Collections.Generic;

namespace Java.Util
{
    #region Iterator
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html"/>
    /// </summary>
    public partial class Iterator : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Iterator>
    {
        /// <inheritdoc />
        public override string BridgeClassName => "java.util.Iterator";
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Iterator() { }
        /// <inheritdoc/>
        public Iterator(IJVMBridgeCore parent) : base(parent) { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Iterator(params object[] args) : base(args) { }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#hasNext()"/> 
        /// </summary>
        public bool HasNext() => IExecute<bool>("hasNext");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#next()"/> 
        /// </summary>
        public object Next() => IExecute("next");
#if !JNETREFLECTOR
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#forEachRemaining(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void ForEachRemaining(Java.Util.Function.Consumer arg0)
        {
            IExecute("forEachRemaining", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }
#endif
    }
    #endregion

    #region IIterator<E>
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html"/>
    /// </summary>
    public partial interface IIterator<E>
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#hasNext()"/> 
        /// </summary>
        bool HasNext();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#next()"/> 
        /// </summary>
        E Next();
#if !JNETREFLECTOR
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#forEachRemaining(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        void ForEachRemaining<Arg0objectSuperE>(Java.Util.Function.Consumer<Arg0objectSuperE> arg0) where Arg0objectSuperE : E;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#remove()"/>
        /// </summary>
        void Remove();
#endif
    }
    #endregion
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html"/>
    /// </summary>
    public partial class Iterator<E> : JVMBridgeBase<Iterator<E>>, IIterator<E>
    {
        /// <inheritdoc />
        public override string BridgeClassName => "java.util.Iterator";
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Iterator() { }
        /// <inheritdoc/>
        public Iterator(IJVMBridgeCore parent) : base(parent) { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Iterator(params object[] args) : base(args) { }
        /// <summary>
        /// Converts an <see cref="Iterator{E}"/> to a <see cref="JVMBridgeBaseEnumerator{E}"/>
        /// </summary>
        public static implicit operator JVMBridgeBaseEnumerator<E>(Iterator<E> it) => new JVMBridgeBaseEnumerator<E>(it.BridgeInstance);
        /// <summary>
        /// Converts an <see cref="Iterator{E}"/> to a <see cref="IEnumerator{E}"/>
        /// </summary>
        public IEnumerator<E> ToIEnumerator() => new JVMBridgeBaseEnumerator<E>(this.BridgeInstance);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#hasNext()"/> 
        /// </summary>
        public bool HasNext() => IExecute<bool>("hasNext");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#next()"/> 
        /// </summary>
        public E Next() => IExecute<E>("next");
#if !JNETREFLECTOR
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#forEachRemaining(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        public void ForEachRemaining<Arg0objectSuperE>(Java.Util.Function.Consumer<Arg0objectSuperE> arg0) where Arg0objectSuperE : E
        {
            IExecute("forEachRemaining", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }
#endif
    }
}