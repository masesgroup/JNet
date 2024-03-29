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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Monitor
{
    #region GaugeMonitor
    public partial class GaugeMonitor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Monitor.GaugeMonitor"/> to <see cref="Javax.Management.Monitor.GaugeMonitorMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Monitor.GaugeMonitorMBean(Javax.Management.Monitor.GaugeMonitor t) => t.Cast<Javax.Management.Monitor.GaugeMonitorMBean>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#getDifferenceMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#setDifferenceMode(boolean)"/>
        /// </summary>
        public bool DifferenceMode
        {
            get { return IExecuteWithSignature<bool>("getDifferenceMode", "()Z"); } set { IExecuteWithSignature("setDifferenceMode", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#getHighThreshold()"/> 
        /// </summary>
        public Java.Lang.Number HighThreshold
        {
            get { return IExecuteWithSignature<Java.Lang.Number>("getHighThreshold", "()Ljava/lang/Number;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#getLowThreshold()"/> 
        /// </summary>
        public Java.Lang.Number LowThreshold
        {
            get { return IExecuteWithSignature<Java.Lang.Number>("getLowThreshold", "()Ljava/lang/Number;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#getNotifyHigh()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#setNotifyHigh(boolean)"/>
        /// </summary>
        public bool NotifyHigh
        {
            get { return IExecuteWithSignature<bool>("getNotifyHigh", "()Z"); } set { IExecuteWithSignature("setNotifyHigh", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#getNotifyLow()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#setNotifyLow(boolean)"/>
        /// </summary>
        public bool NotifyLow
        {
            get { return IExecuteWithSignature<bool>("getNotifyLow", "()Z"); } set { IExecuteWithSignature("setNotifyLow", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#getDerivedGauge(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetDerivedGauge(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<Java.Lang.Number>("getDerivedGauge", "(Ljavax/management/ObjectName;)Ljava/lang/Number;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#getDerivedGaugeTimeStamp(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetDerivedGaugeTimeStamp(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<long>("getDerivedGaugeTimeStamp", "(Ljavax/management/ObjectName;)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/GaugeMonitor.html#setThresholds(java.lang.Number,java.lang.Number)"/>
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