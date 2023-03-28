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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region ThreadInfo
    public partial class ThreadInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#from(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public static Java.Lang.Management.ThreadInfo From(Javax.Management.Openmbean.CompositeData arg0)
        {
            return SExecute<Java.Lang.Management.ThreadInfo>("from", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getBlockedCount()"/> 
        /// </summary>
        public long BlockedCount
        {
            get { return IExecute<long>("getBlockedCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getBlockedTime()"/> 
        /// </summary>
        public long BlockedTime
        {
            get { return IExecute<long>("getBlockedTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockedMonitors()"/> 
        /// </summary>
        public Java.Lang.Management.MonitorInfo[] LockedMonitors
        {
            get { return IExecuteArray<Java.Lang.Management.MonitorInfo>("getLockedMonitors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockedSynchronizers()"/> 
        /// </summary>
        public Java.Lang.Management.LockInfo[] LockedSynchronizers
        {
            get { return IExecuteArray<Java.Lang.Management.LockInfo>("getLockedSynchronizers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockInfo()"/> 
        /// </summary>
        public Java.Lang.Management.LockInfo LockInfo
        {
            get { return IExecute<Java.Lang.Management.LockInfo>("getLockInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockName()"/> 
        /// </summary>
        public string LockName
        {
            get { return IExecute<string>("getLockName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockOwnerId()"/> 
        /// </summary>
        public long LockOwnerId
        {
            get { return IExecute<long>("getLockOwnerId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockOwnerName()"/> 
        /// </summary>
        public string LockOwnerName
        {
            get { return IExecute<string>("getLockOwnerName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getPriority()"/> 
        /// </summary>
        public int Priority
        {
            get { return IExecute<int>("getPriority"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getStackTrace()"/> 
        /// </summary>
        public Java.Lang.StackTraceElement[] StackTrace
        {
            get { return IExecuteArray<Java.Lang.StackTraceElement>("getStackTrace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getThreadId()"/> 
        /// </summary>
        public long ThreadId
        {
            get { return IExecute<long>("getThreadId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getThreadName()"/> 
        /// </summary>
        public string ThreadName
        {
            get { return IExecute<string>("getThreadName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getThreadState()"/> 
        /// </summary>
        public Java.Lang.Thread.State ThreadState
        {
            get { return IExecute<Java.Lang.Thread.State>("getThreadState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getWaitedCount()"/> 
        /// </summary>
        public long WaitedCount
        {
            get { return IExecute<long>("getWaitedCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getWaitedTime()"/> 
        /// </summary>
        public long WaitedTime
        {
            get { return IExecute<long>("getWaitedTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#isDaemon()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsDaemon()
        {
            return IExecute<bool>("isDaemon");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#isInNative()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsInNative()
        {
            return IExecute<bool>("isInNative");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#isSuspended()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsSuspended()
        {
            return IExecute<bool>("isSuspended");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}