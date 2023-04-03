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
using System;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Thread.html"/>
    /// </summary>
    public class Thread : JVMBridgeBase<Thread>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.lang.Thread";
        /// <summary>
        /// Allocates a new Thread object.
        /// </summary>
        public Thread() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Thread(params object[] args) : base(args) { }
        /// <summary>
        /// Allocates a new Thread object.
        /// </summary>
        /// <param name="target">the object whose run method is invoked when this thread is started. If null, this classes run method does nothing.</param>
        public Thread(Runnable target) : base(target) { }
        /// <summary>
        /// Allocates a new Thread object.
        /// </summary>
        /// <param name="target">the object whose run method is invoked when this thread is started. If null, this classes run method does nothing.</param>
        /// <param name="name">the name of the new thread</param>
        public Thread(Runnable target, string name) : base(target, name) { }
        /// <summary>
        /// Allocates a new Thread object.
        /// </summary>
        /// <param name="name">the name of the new thread</param>
        public Thread(string name) : base(name) { }
        /// <summary>
        /// Allocates a new Thread object.
        /// </summary>
        /// <param name="group">the thread group.</param>
        /// <param name="target">the object whose run method is invoked when this thread is started. If null, this thread's run method is invoked.</param>
        public Thread(ThreadGroup group, Runnable target) : base(group, target) { }
        /// <summary>
        /// Allocates a new Thread object so that it has target as its run object, has the specified name as its name, and belongs to the thread group referred to by group.
        /// </summary>
        /// <param name="group">the thread group</param>
        /// <param name="target">the object whose run method is invoked when this thread is started. If null, this thread's run method is invoked.</param>
        /// <param name="name">the name of the new thread</param>
        public Thread(ThreadGroup group, Runnable target, string name) : base(group, target, name) { }
        /// <summary>
        /// Allocates a new Thread object so that it has target as its run object, has the specified name as its name, and belongs to the thread group referred to by group.
        /// </summary>
        /// <param name="group">the thread group</param>
        /// <param name="target">the object whose run method is invoked when this thread is started. If null, this thread's run method is invoked.</param>
        /// <param name="name">the name of the new thread</param>
        /// <param name="stackSize">the desired stack size for the new thread, or zero to indicate that this parameter is to be ignored.</param>
        public Thread(ThreadGroup group, Runnable target, string name, long stackSize) : base(group, target, name, stackSize) { }
        /// <summary>
        /// Allocates a new Thread object.
        /// </summary>
        /// <param name="group">the thread group</param>
        /// <param name="name">the name of the new thread</param>
        public Thread(ThreadGroup group, string name) : base(group, name) { }
        /// <summary>
        /// Returns an estimate of the number of active threads in the current thread's thread group and its subgroups.
        /// </summary>
        public static int ActiveCount => SExecute<int>("activeCount");
        /// <summary>
        /// Set the default handler invoked when a thread abruptly terminates due to an uncaught exception, and no other handler has been defined for that thread. 
        /// </summary>
        /// <param name="eh">The object to use as the default uncaught exception handler. If null then there is no default handler.</param>
        public static void SetDefaultUncaughtExceptionHandler(UncaughtExceptionHandler eh) => SExecute("setDefaultUncaughtExceptionHandler", eh);
        /// <summary>
        /// Returns true if and only if the current thread holds the monitor lock on the specified object. 
        /// </summary>
        /// <param name="obj">The object on which to test lock ownership</param>
        /// <returns><see langword="true"/> if the current thread holds the monitor lock on the specified object.</returns>
        public static bool HoldsLock(object obj) => SExecute<bool>("holdsLock", obj);
        /// <summary>
        /// Tests whether the current thread has been interrupted.
        /// </summary>
        /// <returns><see langword="true"/> if the current thread has been interrupted; <see langword="false"/> otherwise.</returns>
        public static bool Interrupted => SExecute<bool>("interrupted");
        /// <summary>
        /// Causes the currently executing thread to sleep(temporarily cease execution) for the specified number of milliseconds, subject to the precision and accuracy of system timers and schedulers.
        /// </summary>
        /// <param name="millis">The length of time to sleep in milliseconds</param>
        public static void Sleep(long millis) => SExecute("sleep", millis);
        /// <summary>
        /// Causes the currently executing thread to sleep(temporarily cease execution) for the specified number of milliseconds plus the specified number of nanoseconds, subject to the precision and accuracy of system timers and schedulers.
        /// </summary>
        /// <param name="millis">The length of time to sleep in milliseconds</param>
        /// <param name="nanos">0-999999 additional nanoseconds to sleep</param>
        public static void Sleep(long millis, int nanos) => SExecute("sleep", millis, nanos);
        /// <summary>
        /// A hint to the scheduler that the current thread is willing to yield its current use of a processor.
        /// </summary>
        public static void Yield() => SExecute("yield");
        /// <summary>
        /// Returns the identifier of this Thread.
        /// </summary>
        public long Id => IExecute<long>("getId");
        /// <summary>
        /// Returns this thread's name.
        /// </summary>
        public string Name => IExecute<string>("getName");
        /// <summary>
        /// Returns this thread's priority.
        /// </summary>
        public int Priority => IExecute<int>("getPriority");
        /// <summary>
        /// Returns the thread group to which this thread belongs.
        /// </summary>
        public ThreadGroup ThreadGroup => IExecute<ThreadGroup>("getThreadGroup");
        /// <summary>
        /// Interrupts this thread.
        /// </summary>
        public void Interrupt() => IExecute("interrupt");
        /// <summary>
        /// Tests if this thread is alive.
        /// </summary>
        public bool IsAlive => IExecute<bool>("isAlive");
        /// <summary>
        /// Tests if this thread is a daemon thread.
        /// </summary>
        public bool IsDaemon => IExecute<bool>("isDaemon");
        /// <summary>
        /// Tests whether this thread has been interrupted.
        /// </summary>
        public bool IsInterrupted => IExecute<bool>("isInterrupted");
        /// <summary>
        /// Waits for this thread to die.
        /// </summary>
        public void Join() => IExecute("join");
        /// <summary>
        /// Waits at most millis milliseconds for this thread to die.
        /// </summary>
        /// <param name="millis">The time to wait in milliseconds</param>
        public void Join(long millis) => IExecute("join", millis);
        /// <summary>
        /// Waits at most millis milliseconds plus nanos nanoseconds for this thread to die.
        /// </summary>
        /// <param name="millis">The time to wait in milliseconds</param>
        /// <param name="nanos">0-999999 additional nanoseconds to wait</param>
        public void Join(long millis, int nanos) => IExecute("join", millis, nanos);
        /// <summary>
        /// If this thread was constructed using a separate Runnable run object, then that Runnable object's run method is called; otherwise, this method does nothing and returns.
        /// </summary>
        public void Run() => IExecute("run");
        /// <summary>
        /// Marks this thread as either a daemon thread or a user thread. The Java Virtual Machine exits when the only threads running are all daemon threads. 
        /// </summary>
        /// <param name="on">If <see langword="true"/>, marks this thread as a daemon thread</param>
        public void SetDaemon(bool on) => IExecute("setDaemon", on);
        /// <summary>
        /// Set the handler invoked when this thread abruptly terminates due to an uncaught exception. 
        /// </summary>
        /// <param name="eh">The object to use as this thread's uncaught exception handler. If null then this thread has no explicit handler.</param>
        public void SetUncaughtExceptionHandler(UncaughtExceptionHandler eh) => IExecute("setUncaughtExceptionHandler", eh);
        /// <summary>
        /// Changes the name of this thread to be equal to the argument name. 
        /// </summary>
        /// <param name="name">The new name for this thread.</param>
        public void SetName(string name) => IExecute("setName", name);
        /// <summary>
        /// Changes the priority of this thread.  
        /// </summary>
        /// <param name="newPriority">Priority to set this thread to</param>
        public void SetPriority(int newPriority) => IExecute("setPriority", newPriority);
        /// <summary>
        /// Causes this thread to begin execution; the Java Virtual Machine calls the run method of this thread.
        /// </summary>
        public void Start() => IExecute("start");

        #region Thread.State
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html"/>
        /// </summary>
        public class State : Java.Lang.Enum
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
            /// </summary>
            public override string ClassName => "java.lang.Thread$State";
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
            /// </summary>
            public override bool IsStatic => true;

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#BLOCKED"/>
            /// </summary>
            public static Java.Lang.Thread.State BLOCKED => Clazz.GetField<Java.Lang.Thread.State>("BLOCKED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#NEW"/>
            /// </summary>
            public static Java.Lang.Thread.State NEW => Clazz.GetField<Java.Lang.Thread.State>("NEW");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#RUNNABLE"/>
            /// </summary>
            public static Java.Lang.Thread.State RUNNABLE => Clazz.GetField<Java.Lang.Thread.State>("RUNNABLE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#TERMINATED"/>
            /// </summary>
            public static Java.Lang.Thread.State TERMINATED => Clazz.GetField<Java.Lang.Thread.State>("TERMINATED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#TIMED_WAITING"/>
            /// </summary>
            public static Java.Lang.Thread.State TIMED_WAITING => Clazz.GetField<Java.Lang.Thread.State>("TIMED_WAITING");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#WAITING"/>
            /// </summary>
            public static Java.Lang.Thread.State WAITING => Clazz.GetField<Java.Lang.Thread.State>("WAITING");

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Lang.Thread.State"/></returns>
            public static Java.Lang.Thread.State ValueOf(string arg0)
            {
                return SExecute<Java.Lang.Thread.State>("valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Thread.State"/></returns>
            public static Java.Lang.Thread.State[] Values()
            {
                return SExecuteArray<Java.Lang.Thread.State>("values");
            }

            #endregion
        }

        #endregion

        #region Thread.UncaughtExceptionHandler
        /// <summary>
        /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.UncaughtExceptionHandler.html"/>. Extends <see cref="JVMBridgeListener"/>
        /// </summary>
        /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
        public class UncaughtExceptionHandler : JVMBridgeListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
            /// </summary>
            public override string ClassName => "org.mases.jnet.lang.JNetUncaughtExceptionHandler";

            readonly Action<Thread, JVMBridgeException> executionFunction = null;
            /// <summary>
            /// The <see cref="Action{Thread, JVMBridgeException}"/> to be executed
            /// </summary>
            public virtual Action<Thread, JVMBridgeException> OnUncaughtException { get { return executionFunction; } }
            /// <summary>
            /// Initialize a new instance of <see cref="UncaughtExceptionHandler"/>
            /// </summary>
            /// <param name="action">The <see cref="Action{Thread, JVMBridgeException}"/> to be executed</param>
            /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
            public UncaughtExceptionHandler(Action<Thread, JVMBridgeException> action = null, bool attachEventHandler = true)
            {
                if (action != null) executionFunction = action;
                else executionFunction = UncaughtException;
                if (attachEventHandler)
                {
                    AddEventHandler("uncaughtException", new EventHandler<CLRListenerEventArgs<CLREventData<Thread>>>(EventHandler));
                }
            }

            void EventHandler(object sender, CLRListenerEventArgs<CLREventData<Thread>> data)
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
