/*
*  Copyright 2022 MASES s.r.l.
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

using Java.Lang;
using Java.Util;
using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;

namespace JavaX.Naming.Event
{
    public class NamingExceptionEvent : EventObject
    {
        public override string ClassName => "javax.naming.event.NamingExceptionEvent";
        /// <summary>
        /// Invokes the namingExceptionThrown() method on a listener using this event.
        /// </summary>
        /// <param name="listener">The non-null naming listener on which to invoke the method.</param>
        public void Dispatch(NamingListener listener) => IExecute("dispatch", listener);
        /// <summary>
        /// Retrieves the EventContext that fired this event.
        /// </summary>
        public EventContext EventContext => IExecute<EventContext>("getEventContext");
        /// <summary>
        /// Retrieves the exception that was thrown.
        /// </summary>
        public NamingException Exception { get { var obj = IExecute<IJavaObject>("getException"); return JVMBridgeException.New(obj) as NamingException; } }
    }
}
