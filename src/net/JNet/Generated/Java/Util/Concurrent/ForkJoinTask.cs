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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region ForkJoinTask
    public partial class ForkJoinTask
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask"/> to <see cref="Java.Util.Concurrent.Future"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future(Java.Util.Concurrent.ForkJoinTask t) => t.Cast<Java.Util.Concurrent.Future>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.ForkJoinTask t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#inForkJoinPool()"/> 
        /// </summary>
        public static bool InForkJoinPool
        {
            get { return SExecute<bool>(LocalClazz, "inForkJoinPool"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getPool()"/> 
        /// </summary>
        public static Java.Util.Concurrent.ForkJoinPool Pool
        {
            get { return SExecute<Java.Util.Concurrent.ForkJoinPool>(LocalClazz, "getPool"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getQueuedTaskCount()"/> 
        /// </summary>
        public static int QueuedTaskCount
        {
            get { return SExecute<int>(LocalClazz, "getQueuedTaskCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getSurplusQueuedTaskCount()"/> 
        /// </summary>
        public static int SurplusQueuedTaskCount
        {
            get { return SExecute<int>(LocalClazz, "getSurplusQueuedTaskCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public static Java.Util.Collection InvokeAll(Java.Util.Collection arg0)
        {
            return SExecute<Java.Util.Collection>(LocalClazz, "invokeAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask Adapt(Java.Lang.Runnable arg0, object arg1)
        {
            return SExecute<Java.Util.Concurrent.ForkJoinTask>(LocalClazz, "adapt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask Adapt(Java.Util.Concurrent.Callable arg0)
        {
            return SExecute<Java.Util.Concurrent.ForkJoinTask>(LocalClazz, "adapt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask Adapt(Java.Lang.Runnable arg0)
        {
            return SExecute<Java.Util.Concurrent.ForkJoinTask>(LocalClazz, "adapt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#helpQuiesce()"/>
        /// </summary>
        public static void HelpQuiesce()
        {
            SExecute(LocalClazz, "helpQuiesce");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.concurrent.ForkJoinTask,java.util.concurrent.ForkJoinTask)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        public static void InvokeAll(Java.Util.Concurrent.ForkJoinTask arg0, Java.Util.Concurrent.ForkJoinTask arg1)
        {
            SExecute(LocalClazz, "invokeAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.concurrent.ForkJoinTask[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        public static void InvokeAll(params Java.Util.Concurrent.ForkJoinTask[] arg0)
        {
            if (arg0.Length == 0) SExecute(LocalClazz, "invokeAll"); else SExecute(LocalClazz, "invokeAll", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getException()"/> 
        /// </summary>
        public Java.Lang.Throwable Exception
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#fork()"/> 
        /// </summary>
        public Java.Util.Concurrent.ForkJoinTask Fork
        {
            get { return IExecute<Java.Util.Concurrent.ForkJoinTask>("fork"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getForkJoinTaskTag()"/> 
        /// </summary>
        public short ForkJoinTaskTag
        {
            get { return IExecute<short>("getForkJoinTaskTag"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#invoke()"/> 
        /// </summary>
        public object Invoke
        {
            get { return IExecute("invoke"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#isCancelled()"/> 
        /// </summary>
        public bool IsCancelled
        {
            get { return IExecute<bool>("isCancelled"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#isCompletedAbnormally()"/> 
        /// </summary>
        public bool IsCompletedAbnormally
        {
            get { return IExecute<bool>("isCompletedAbnormally"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#isCompletedNormally()"/> 
        /// </summary>
        public bool IsCompletedNormally
        {
            get { return IExecute<bool>("isCompletedNormally"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#isDone()"/> 
        /// </summary>
        public bool IsDone
        {
            get { return IExecute<bool>("isDone"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#join()"/> 
        /// </summary>
        public object Join
        {
            get { return IExecute("join"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getRawResult()"/> 
        /// </summary>
        public object RawResult
        {
            get { return IExecute("getRawResult"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#tryUnfork()"/> 
        /// </summary>
        public bool TryUnfork
        {
            get { return IExecute<bool>("tryUnfork"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#cancel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Cancel(bool arg0)
        {
            return IExecute<bool>("cancel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#compareAndSetForkJoinTaskTag(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSetForkJoinTaskTag(short arg0, short arg1)
        {
            return IExecute<bool>("compareAndSetForkJoinTaskTag", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#setForkJoinTaskTag(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public short SetForkJoinTaskTag(short arg0)
        {
            return IExecute<short>("setForkJoinTaskTag", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#get()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public object Get()
        {
            return IExecute("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#get(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public object Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#quietlyComplete()"/>
        /// </summary>
        public void QuietlyComplete()
        {
            IExecute("quietlyComplete");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#quietlyInvoke()"/>
        /// </summary>
        public void QuietlyInvoke()
        {
            IExecute("quietlyInvoke");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#quietlyJoin()"/>
        /// </summary>
        public void QuietlyJoin()
        {
            IExecute("quietlyJoin");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#complete(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Complete(object arg0)
        {
            IExecute("complete", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#completeExceptionally(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void CompleteExceptionally(Java.Lang.Throwable arg0)
        {
            IExecute("completeExceptionally", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#reinitialize()"/>
        /// </summary>
        public void Reinitialize()
        {
            IExecute("reinitialize");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ForkJoinTask<V>
    public partial class ForkJoinTask<V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask{V}"/> to <see cref="Java.Util.Concurrent.Future{V}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future<V>(Java.Util.Concurrent.ForkJoinTask<V> t) => t.Cast<Java.Util.Concurrent.Future<V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask{V}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.ForkJoinTask<V> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask{V}"/> to <see cref="Java.Util.Concurrent.ForkJoinTask"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ForkJoinTask(Java.Util.Concurrent.ForkJoinTask<V> t) => t.Cast<Java.Util.Concurrent.ForkJoinTask>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#inForkJoinPool()"/> 
        /// </summary>
        public static bool InForkJoinPool
        {
            get { return SExecute<bool>(LocalClazz, "inForkJoinPool"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getPool()"/> 
        /// </summary>
        public static Java.Util.Concurrent.ForkJoinPool Pool
        {
            get { return SExecute<Java.Util.Concurrent.ForkJoinPool>(LocalClazz, "getPool"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getQueuedTaskCount()"/> 
        /// </summary>
        public static int QueuedTaskCount
        {
            get { return SExecute<int>(LocalClazz, "getQueuedTaskCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getSurplusQueuedTaskCount()"/> 
        /// </summary>
        public static int SurplusQueuedTaskCount
        {
            get { return SExecute<int>(LocalClazz, "getSurplusQueuedTaskCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public static Java.Util.Collection<T> InvokeAll<T>(Java.Util.Collection<T> arg0)
        {
            return SExecute<Java.Util.Collection<T>>(LocalClazz, "invokeAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask<T> Adapt<T>(Java.Lang.Runnable arg0, T arg1)
        {
            return SExecute<Java.Util.Concurrent.ForkJoinTask<T>>(LocalClazz, "adapt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask<T> Adapt<T, Arg0ExtendsT>(Java.Util.Concurrent.Callable<Arg0ExtendsT> arg0) where Arg0ExtendsT: T
        {
            return SExecute<Java.Util.Concurrent.ForkJoinTask<T>>(LocalClazz, "adapt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <typeparam name="ReturnExtendsobject"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask<ReturnExtendsobject> Adapt<ReturnExtendsobject>(Java.Lang.Runnable arg0)
        {
            return SExecute<Java.Util.Concurrent.ForkJoinTask<ReturnExtendsobject>>(LocalClazz, "adapt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#helpQuiesce()"/>
        /// </summary>
        public static void HelpQuiesce()
        {
            SExecute(LocalClazz, "helpQuiesce");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.concurrent.ForkJoinTask,java.util.concurrent.ForkJoinTask)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        /// <typeparam name="Arg1Extendsobject"></typeparam>
        public static void InvokeAll<Arg0Extendsobject, Arg1Extendsobject>(Java.Util.Concurrent.ForkJoinTask<Arg0Extendsobject> arg0, Java.Util.Concurrent.ForkJoinTask<Arg1Extendsobject> arg1)
        {
            SExecute(LocalClazz, "invokeAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.concurrent.ForkJoinTask[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        public static void InvokeAll<Arg0Extendsobject>(params Java.Util.Concurrent.ForkJoinTask<Arg0Extendsobject>[] arg0)
        {
            if (arg0.Length == 0) SExecute(LocalClazz, "invokeAll"); else SExecute(LocalClazz, "invokeAll", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getException()"/> 
        /// </summary>
        public Java.Lang.Throwable Exception
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#fork()"/> 
        /// </summary>
        public Java.Util.Concurrent.ForkJoinTask<V> Fork
        {
            get { return IExecute<Java.Util.Concurrent.ForkJoinTask<V>>("fork"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getForkJoinTaskTag()"/> 
        /// </summary>
        public short ForkJoinTaskTag
        {
            get { return IExecute<short>("getForkJoinTaskTag"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#invoke()"/> 
        /// </summary>
        public V Invoke
        {
            get { return IExecute<V>("invoke"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#isCancelled()"/> 
        /// </summary>
        public bool IsCancelled
        {
            get { return IExecute<bool>("isCancelled"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#isCompletedAbnormally()"/> 
        /// </summary>
        public bool IsCompletedAbnormally
        {
            get { return IExecute<bool>("isCompletedAbnormally"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#isCompletedNormally()"/> 
        /// </summary>
        public bool IsCompletedNormally
        {
            get { return IExecute<bool>("isCompletedNormally"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#isDone()"/> 
        /// </summary>
        public bool IsDone
        {
            get { return IExecute<bool>("isDone"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#join()"/> 
        /// </summary>
        public V Join
        {
            get { return IExecute<V>("join"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#getRawResult()"/> 
        /// </summary>
        public V RawResult
        {
            get { return IExecute<V>("getRawResult"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#tryUnfork()"/> 
        /// </summary>
        public bool TryUnfork
        {
            get { return IExecute<bool>("tryUnfork"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#cancel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Cancel(bool arg0)
        {
            return IExecute<bool>("cancel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#compareAndSetForkJoinTaskTag(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSetForkJoinTaskTag(short arg0, short arg1)
        {
            return IExecute<bool>("compareAndSetForkJoinTaskTag", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#setForkJoinTaskTag(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public short SetForkJoinTaskTag(short arg0)
        {
            return IExecute<short>("setForkJoinTaskTag", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#get()"/>
        /// </summary>

        /// <returns><typeparamref name="V"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public V Get()
        {
            return IExecute<V>("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#get(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><typeparamref name="V"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public V Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<V>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#quietlyComplete()"/>
        /// </summary>
        public void QuietlyComplete()
        {
            IExecute("quietlyComplete");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#quietlyInvoke()"/>
        /// </summary>
        public void QuietlyInvoke()
        {
            IExecute("quietlyInvoke");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#quietlyJoin()"/>
        /// </summary>
        public void QuietlyJoin()
        {
            IExecute("quietlyJoin");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#complete(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        public void Complete(V arg0)
        {
            IExecute("complete", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#completeExceptionally(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void CompleteExceptionally(Java.Lang.Throwable arg0)
        {
            IExecute("completeExceptionally", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinTask.html#reinitialize()"/>
        /// </summary>
        public void Reinitialize()
        {
            IExecute("reinitialize");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}