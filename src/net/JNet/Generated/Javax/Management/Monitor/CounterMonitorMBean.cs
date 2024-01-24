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

namespace Javax.Management.Monitor
{
    #region ICounterMonitorMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICounterMonitorMBean : Javax.Management.Monitor.IMonitorMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDifferenceMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setDifferenceMode(boolean)"/>
        /// </summary>
        bool DifferenceMode { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getInitThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setInitThreshold(java.lang.Number)"/>
        /// </summary>
        Java.Lang.Number InitThreshold { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getModulus()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setModulus(java.lang.Number)"/>
        /// </summary>
        Java.Lang.Number Modulus { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getNotify()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setNotify(boolean)"/>
        /// </summary>
        bool Notify { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setOffset(java.lang.Number)"/>
        /// </summary>
        Java.Lang.Number Offset { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDerivedGauge(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        Java.Lang.Number GetDerivedGauge(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getThreshold(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        Java.Lang.Number GetThreshold(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDerivedGaugeTimeStamp(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="long"/></returns>
        long GetDerivedGaugeTimeStamp(Javax.Management.ObjectName arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CounterMonitorMBean
    public partial class CounterMonitorMBean : Javax.Management.Monitor.ICounterMonitorMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDifferenceMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setDifferenceMode(boolean)"/>
        /// </summary>
        public bool DifferenceMode
        {
            get { return IExecute<bool>("getDifferenceMode"); } set { IExecute("setDifferenceMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getInitThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setInitThreshold(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number InitThreshold
        {
            get { return IExecute<Java.Lang.Number>("getInitThreshold"); } set { IExecute("setInitThreshold", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getModulus()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setModulus(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number Modulus
        {
            get { return IExecute<Java.Lang.Number>("getModulus"); } set { IExecute("setModulus", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getNotify()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setNotify(boolean)"/>
        /// </summary>
        public bool Notify
        {
            get { return IExecute<bool>("getNotify"); } set { IExecute("setNotify", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setOffset(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number Offset
        {
            get { return IExecute<Java.Lang.Number>("getOffset"); } set { IExecute("setOffset", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDerivedGauge(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetDerivedGauge(Javax.Management.ObjectName arg0)
        {
            return IExecute<Java.Lang.Number>("getDerivedGauge", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getThreshold(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetThreshold(Javax.Management.ObjectName arg0)
        {
            return IExecute<Java.Lang.Number>("getThreshold", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDerivedGaugeTimeStamp(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetDerivedGaugeTimeStamp(Javax.Management.ObjectName arg0)
        {
            return IExecute<long>("getDerivedGaugeTimeStamp", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}