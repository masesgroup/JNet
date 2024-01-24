/*
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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Thread
    public partial class Thread
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#%3Cinit%3E(java.lang.Runnable,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public Thread(Java.Lang.Runnable arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#%3Cinit%3E(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public Thread(Java.Lang.Runnable arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public Thread(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#%3Cinit%3E(java.lang.ThreadGroup,java.lang.Runnable,java.lang.String,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public Thread(Java.Lang.ThreadGroup arg0, Java.Lang.Runnable arg1, string arg2, long arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#%3Cinit%3E(java.lang.ThreadGroup,java.lang.Runnable,java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public Thread(Java.Lang.ThreadGroup arg0, Java.Lang.Runnable arg1, string arg2, long arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#%3Cinit%3E(java.lang.ThreadGroup,java.lang.Runnable,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        public Thread(Java.Lang.ThreadGroup arg0, Java.Lang.Runnable arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#%3Cinit%3E(java.lang.ThreadGroup,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public Thread(Java.Lang.ThreadGroup arg0, Java.Lang.Runnable arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#%3Cinit%3E(java.lang.ThreadGroup,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public Thread(Java.Lang.ThreadGroup arg0, string arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#MAX_PRIORITY"/>
        /// </summary>
        public static int MAX_PRIORITY { get { if (!_MAX_PRIORITYReady) { _MAX_PRIORITYContent = SGetField<int>(LocalBridgeClazz, "MAX_PRIORITY"); _MAX_PRIORITYReady = true; } return _MAX_PRIORITYContent; } }
        private static int _MAX_PRIORITYContent = default;
        private static bool _MAX_PRIORITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#MIN_PRIORITY"/>
        /// </summary>
        public static int MIN_PRIORITY { get { if (!_MIN_PRIORITYReady) { _MIN_PRIORITYContent = SGetField<int>(LocalBridgeClazz, "MIN_PRIORITY"); _MIN_PRIORITYReady = true; } return _MIN_PRIORITYContent; } }
        private static int _MIN_PRIORITYContent = default;
        private static bool _MIN_PRIORITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#NORM_PRIORITY"/>
        /// </summary>
        public static int NORM_PRIORITY { get { if (!_NORM_PRIORITYReady) { _NORM_PRIORITYContent = SGetField<int>(LocalBridgeClazz, "NORM_PRIORITY"); _NORM_PRIORITYReady = true; } return _NORM_PRIORITYContent; } }
        private static int _NORM_PRIORITYContent = default;
        private static bool _NORM_PRIORITYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#getAllStackTraces()"/> 
        /// </summary>
        public static Java.Util.Map<Java.Lang.Thread, Java.Lang.StackTraceElement[]> AllStackTraces
        {
            get { return SExecute<Java.Util.Map<Java.Lang.Thread, Java.Lang.StackTraceElement[]>>(LocalBridgeClazz, "getAllStackTraces"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#interrupted()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool Interrupted()
        {
            return SExecute<bool>(LocalBridgeClazz, "interrupted");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#activeCount()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int ActiveCount()
        {
            return SExecute<int>(LocalBridgeClazz, "activeCount");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#enumerate(java.lang.Thread[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Enumerate(Java.Lang.Thread[] arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "enumerate", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#holdsLock(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool HoldsLock(object arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "holdsLock", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#currentThread()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Thread"/></returns>
        public static Java.Lang.Thread CurrentThread()
        {
            return SExecute<Java.Lang.Thread>(LocalBridgeClazz, "currentThread");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#sleep(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public static void Sleep(long arg0)
        {
            SExecute(LocalBridgeClazz, "sleep", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#yield()"/>
        /// </summary>
        public static void Yield()
        {
            SExecute(LocalBridgeClazz, "yield");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#dumpStack()"/>
        /// </summary>
        public static void DumpStack()
        {
            SExecute(LocalBridgeClazz, "dumpStack");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#onSpinWait()"/>
        /// </summary>
        public static void OnSpinWait()
        {
            SExecute(LocalBridgeClazz, "onSpinWait");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#sleep(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public static void Sleep(long arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "sleep", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#getContextClassLoader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#setContextClassLoader(java.lang.ClassLoader)"/>
        /// </summary>
        public Java.Lang.ClassLoader ContextClassLoader
        {
            get { return IExecute<Java.Lang.ClassLoader>("getContextClassLoader"); } set { IExecute("setContextClassLoader", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#getState()"/> 
        /// </summary>
        public Java.Lang.Thread.State GetState
        {
            get { return IExecute<Java.Lang.Thread.State>("getState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#getId()"/> 
        /// </summary>
        public long Id
        {
            get { return IExecute<long>("getId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#setName(java.lang.String)"/>
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#getPriority()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#setPriority(int)"/>
        /// </summary>
        public int Priority
        {
            get { return IExecute<int>("getPriority"); } set { IExecute("setPriority", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#getStackTrace()"/> 
        /// </summary>
        public Java.Lang.StackTraceElement[] StackTrace
        {
            get { return IExecuteArray<Java.Lang.StackTraceElement>("getStackTrace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#getThreadGroup()"/> 
        /// </summary>
        public Java.Lang.ThreadGroup ThreadGroup
        {
            get { return IExecute<Java.Lang.ThreadGroup>("getThreadGroup"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#isInterrupted()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsInterrupted()
        {
            return IExecute<bool>("isInterrupted");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#isDaemon()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDaemon()
        {
            return IExecute<bool>("isDaemon");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#isAlive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAlive()
        {
            return IExecute<bool>("isAlive");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#join(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Join(long arg0, int arg1)
        {
            IExecute("join", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#join(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Join(long arg0)
        {
            IExecute("join", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#checkAccess()"/>
        /// </summary>
        public void CheckAccess()
        {
            IExecute("checkAccess");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#join()"/>
        /// </summary>

        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Join()
        {
            IExecute("join");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#setDaemon(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDaemon(bool arg0)
        {
            IExecute("setDaemon", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecute("start");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#interrupt()"/>
        /// </summary>
        public void Interrupt()
        {
            IExecute("interrupt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.html#run()"/>
        /// </summary>
        public void Run()
        {
            IExecute("run");
        }

        #endregion

        #region Nested classes
        #region State
        public partial class State
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#BLOCKED"/>
            /// </summary>
            public static Java.Lang.Thread.State BLOCKED { get { if (!_BLOCKEDReady) { _BLOCKEDContent = SGetField<Java.Lang.Thread.State>(LocalBridgeClazz, "BLOCKED"); _BLOCKEDReady = true; } return _BLOCKEDContent; } }
            private static Java.Lang.Thread.State _BLOCKEDContent = default;
            private static bool _BLOCKEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#NEW"/>
            /// </summary>
            public static Java.Lang.Thread.State NEW { get { if (!_NEWReady) { _NEWContent = SGetField<Java.Lang.Thread.State>(LocalBridgeClazz, "NEW"); _NEWReady = true; } return _NEWContent; } }
            private static Java.Lang.Thread.State _NEWContent = default;
            private static bool _NEWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#RUNNABLE"/>
            /// </summary>
            public static Java.Lang.Thread.State RUNNABLE { get { if (!_RUNNABLEReady) { _RUNNABLEContent = SGetField<Java.Lang.Thread.State>(LocalBridgeClazz, "RUNNABLE"); _RUNNABLEReady = true; } return _RUNNABLEContent; } }
            private static Java.Lang.Thread.State _RUNNABLEContent = default;
            private static bool _RUNNABLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#TERMINATED"/>
            /// </summary>
            public static Java.Lang.Thread.State TERMINATED { get { if (!_TERMINATEDReady) { _TERMINATEDContent = SGetField<Java.Lang.Thread.State>(LocalBridgeClazz, "TERMINATED"); _TERMINATEDReady = true; } return _TERMINATEDContent; } }
            private static Java.Lang.Thread.State _TERMINATEDContent = default;
            private static bool _TERMINATEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#TIMED_WAITING"/>
            /// </summary>
            public static Java.Lang.Thread.State TIMED_WAITING { get { if (!_TIMED_WAITINGReady) { _TIMED_WAITINGContent = SGetField<Java.Lang.Thread.State>(LocalBridgeClazz, "TIMED_WAITING"); _TIMED_WAITINGReady = true; } return _TIMED_WAITINGContent; } }
            private static Java.Lang.Thread.State _TIMED_WAITINGContent = default;
            private static bool _TIMED_WAITINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#WAITING"/>
            /// </summary>
            public static Java.Lang.Thread.State WAITING { get { if (!_WAITINGReady) { _WAITINGContent = SGetField<Java.Lang.Thread.State>(LocalBridgeClazz, "WAITING"); _WAITINGReady = true; } return _WAITINGContent; } }
            private static Java.Lang.Thread.State _WAITINGContent = default;
            private static bool _WAITINGReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Lang.Thread.State"/></returns>
            public static Java.Lang.Thread.State ValueOf(string arg0)
            {
                return SExecute<Java.Lang.Thread.State>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Thread.State.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Lang.Thread.State"/></returns>
            public static Java.Lang.Thread.State[] Values()
            {
                return SExecuteArray<Java.Lang.Thread.State>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}