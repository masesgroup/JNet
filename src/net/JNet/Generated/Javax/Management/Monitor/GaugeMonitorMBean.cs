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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Monitor
{
    #region IGaugeMonitorMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IGaugeMonitorMBean : Javax.Management.Monitor.IMonitorMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getDifferenceMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#setDifferenceMode(boolean)"/>
        /// </summary>
        bool DifferenceMode { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getHighThreshold()"/> 
        /// </summary>
        Java.Lang.Number HighThreshold { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getLowThreshold()"/> 
        /// </summary>
        Java.Lang.Number LowThreshold { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getNotifyHigh()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#setNotifyHigh(boolean)"/>
        /// </summary>
        bool NotifyHigh { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getNotifyLow()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#setNotifyLow(boolean)"/>
        /// </summary>
        bool NotifyLow { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getDerivedGauge(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        Java.Lang.Number GetDerivedGauge(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getDerivedGaugeTimeStamp(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="long"/></returns>
        long GetDerivedGaugeTimeStamp(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#setThresholds(java.lang.Number,java.lang.Number)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Number"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Number"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        void SetThresholds(Java.Lang.Number arg0, Java.Lang.Number arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region GaugeMonitorMBean
    public partial class GaugeMonitorMBean : Javax.Management.Monitor.IGaugeMonitorMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getDifferenceMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#setDifferenceMode(boolean)"/>
        /// </summary>
        public bool DifferenceMode
        {
            get { return IExecute<bool>("getDifferenceMode"); } set { IExecute("setDifferenceMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getHighThreshold()"/> 
        /// </summary>
        public Java.Lang.Number HighThreshold
        {
            get { return IExecute<Java.Lang.Number>("getHighThreshold"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getLowThreshold()"/> 
        /// </summary>
        public Java.Lang.Number LowThreshold
        {
            get { return IExecute<Java.Lang.Number>("getLowThreshold"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getNotifyHigh()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#setNotifyHigh(boolean)"/>
        /// </summary>
        public bool NotifyHigh
        {
            get { return IExecute<bool>("getNotifyHigh"); } set { IExecute("setNotifyHigh", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getNotifyLow()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#setNotifyLow(boolean)"/>
        /// </summary>
        public bool NotifyLow
        {
            get { return IExecute<bool>("getNotifyLow"); } set { IExecute("setNotifyLow", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getDerivedGauge(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetDerivedGauge(Javax.Management.ObjectName arg0)
        {
            return IExecute<Java.Lang.Number>("getDerivedGauge", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#getDerivedGaugeTimeStamp(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetDerivedGaugeTimeStamp(Javax.Management.ObjectName arg0)
        {
            return IExecute<long>("getDerivedGaugeTimeStamp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitorMBean.html#setThresholds(java.lang.Number,java.lang.Number)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Number"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Number"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetThresholds(Java.Lang.Number arg0, Java.Lang.Number arg1)
        {
            IExecute("setThresholds", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}