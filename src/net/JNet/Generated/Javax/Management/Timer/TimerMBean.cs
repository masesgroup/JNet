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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Timer
{
    #region ITimerMBean
    public partial interface ITimerMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getAllNotificationIDs()"/> 
        /// </summary>
        Java.Util.Vector<int?> AllNotificationIDs { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#isActive()"/> 
        /// </summary>
        bool IsActive { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#isEmpty()"/> 
        /// </summary>
        bool IsEmpty { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNbNotifications()"/> 
        /// </summary>
        int NbNotifications { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getSendPastNotifications()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#setSendPastNotifications(boolean)"/>
        /// </summary>
        bool SendPastNotifications { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getFixedRate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool? GetFixedRate(int? arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        int? AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5, bool arg6);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        int? AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        int? AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        int? AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNbOccurences(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        long? GetNbOccurences(int? arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getPeriod(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        long? GetPeriod(int? arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationUserData(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        object GetNotificationUserData(int? arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationMessage(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetNotificationMessage(int? arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationType(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetNotificationType(int? arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getDate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        Java.Util.Date GetDate(int? arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationIDs(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Vector"/></returns>
        Java.Util.Vector<int?> GetNotificationIDs(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeAllNotifications()"/>
        /// </summary>
        void RemoveAllNotifications();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeNotification(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        void RemoveNotification(int? arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeNotifications(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        void RemoveNotifications(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#start()"/>
        /// </summary>
        void Start();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#stop()"/>
        /// </summary>
        void Stop();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TimerMBean
    public partial class TimerMBean : Javax.Management.Timer.ITimerMBean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getAllNotificationIDs()"/> 
        /// </summary>
        public Java.Util.Vector<int?> AllNotificationIDs
        {
            get { return IExecute<Java.Util.Vector<int?>>("getAllNotificationIDs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#isActive()"/> 
        /// </summary>
        public bool IsActive
        {
            get { return IExecute<bool>("isActive"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNbNotifications()"/> 
        /// </summary>
        public int NbNotifications
        {
            get { return IExecute<int>("getNbNotifications"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getSendPastNotifications()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#setSendPastNotifications(boolean)"/>
        /// </summary>
        public bool SendPastNotifications
        {
            get { return IExecute<bool>("getSendPastNotifications"); } set { IExecute("setSendPastNotifications", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getFixedRate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool? GetFixedRate(int? arg0)
        {
            return IExecute<bool?>("getFixedRate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public int? AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5, bool arg6)
        {
            return IExecute<int?>("addNotification", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public int? AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5)
        {
            return IExecute<int?>("addNotification", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public int? AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4)
        {
            return IExecute<int?>("addNotification", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public int? AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3)
        {
            return IExecute<int?>("addNotification", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNbOccurences(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long? GetNbOccurences(int? arg0)
        {
            return IExecute<long?>("getNbOccurences", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getPeriod(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long? GetPeriod(int? arg0)
        {
            return IExecute<long?>("getPeriod", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationUserData(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetNotificationUserData(int? arg0)
        {
            return IExecute("getNotificationUserData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationMessage(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNotificationMessage(int? arg0)
        {
            return IExecute<string>("getNotificationMessage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationType(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNotificationType(int? arg0)
        {
            return IExecute<string>("getNotificationType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getDate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetDate(int? arg0)
        {
            return IExecute<Java.Util.Date>("getDate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationIDs(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Vector"/></returns>
        public Java.Util.Vector<int?> GetNotificationIDs(string arg0)
        {
            return IExecute<Java.Util.Vector<int?>>("getNotificationIDs", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeAllNotifications()"/>
        /// </summary>
        public void RemoveAllNotifications()
        {
            IExecute("removeAllNotifications");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeNotification(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        public void RemoveNotification(int? arg0)
        {
            IExecute("removeNotification", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeNotifications(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        public void RemoveNotifications(string arg0)
        {
            IExecute("removeNotifications", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecute("start");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecute("stop");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}