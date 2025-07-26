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
using System;

namespace Java.Lang
{
    public partial class Thread
    {
        /// <summary>
        /// Set the handler invoked when this thread abruptly terminates due to an uncaught exception. 
        /// </summary>
        /// <param name="eh">The object to use as this thread's uncaught exception handler. If null then this thread has no explicit handler.</param>
        public void SetUncaughtExceptionHandler(UncaughtExceptionHandler eh) => IExecute("setUncaughtExceptionHandler", eh);

        #region Thread.UncaughtExceptionHandler
        /// <summary>
        /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.UncaughtExceptionHandler.html"/>. Extends <see cref="JVMBridgeListener"/>
        /// </summary>
        /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
        public class UncaughtExceptionHandler : JVMBridgeListener
        {
            /// <inheritdoc />
            public override string BridgeClassName => "org.mases.jnet.developed.java.lang.Thread_UncaughtExceptionHandler";

            /// <summary>
            /// The <see cref="Action{Thread, JVMBridgeException}"/> to be executed
            /// </summary>
            public virtual Action<Thread, JVMBridgeException> OnUncaughtException { get; set; }
            /// <summary>
            /// Initialize a new instance of <see cref="UncaughtExceptionHandler"/>
            /// </summary>
            public UncaughtExceptionHandler()
            {
                AddEventHandler("uncaughtException", new EventHandler<CLRListenerEventArgs<CLREventData<Thread>>>(UncaughtExceptionEventHandler)); OnUncaughtException = UncaughtException;
            }

            void UncaughtExceptionEventHandler(object sender, CLRListenerEventArgs<CLREventData<Thread>> data)
            {
                OnUncaughtException(data.EventData.TypedEventData, JVMBridgeException.New(data.EventData.ExtraData.Get(0) as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.UncaughtExceptionHandler.html#uncaughtException(java.lang.Thread,java.lang.Throwable)"/>
            /// </summary>
            public virtual void UncaughtException(Thread t, JVMBridgeException e) { }
        }
        #endregion
    }
}
