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

using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace Java.Util
{
    #region IEventListener
    /// <summary>
    /// .NET interface for org.mases.jnet.util.EventListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EventListener.html"/>
    /// </summary>
    public partial interface IEventListener
    {

    }
    #endregion

    #region EventListener
    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EventListener.html"/>
    /// </summary>
    public partial class EventListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener, Java.Util.IEventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EventListener() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EventListener(params object[] args) : base(args) { }

        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.EventListener";
    }
    #endregion

    #region EventListener
    /// <summary>
    /// Direct override of <see cref="EventListener"/> or its generic type if there is one
    /// </summary>
    public partial class EventListenerDirect : EventListener
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        const string _bridgeClassName = "java.util.EventListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <inheritdoc />
        public override string BridgeClassName => _bridgeClassName;
        /// <inheritdoc />
        public override bool IsBridgeAbstract => true;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;
    }
    #endregion
}
