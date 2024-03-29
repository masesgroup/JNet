﻿/*
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
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.JNetEventListener";
    }
    #endregion
}
