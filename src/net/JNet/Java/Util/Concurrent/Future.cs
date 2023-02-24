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

namespace Java.Util.Concurrent
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Future.html"/>
    /// </summary>
    public class Future<E> : JVMBridgeBase<Future<E>>
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public override string ClassName => "java.util.concurrent.Future";
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Future.html#cancel(boolean)"/>
        /// </summary>
        public bool Cancel(bool mayInterruptIfRunning)
        {
            return IExecute<bool>("cancel", mayInterruptIfRunning);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Future.html#get()"/>
        /// </summary>
        public E Get()
        {
            return IExecute<E>("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Future.html#get(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        public E Get(long timeout, TimeUnit unit)
        {
            return IExecute<E>("get", timeout, unit);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Future.html#isCancelled()"/>
        /// </summary>
        public bool IsCancelled => IExecute<bool>("isCancelled");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Future.html#isDone()"/>
        /// </summary>
        public bool IsDone => IExecute<bool>("isDone");
    }
}
