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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Monitor
{
    #region CounterMonitor
    public partial class CounterMonitor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Monitor.CounterMonitor"/> to <see cref="Javax.Management.Monitor.CounterMonitorMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Monitor.CounterMonitorMBean(Javax.Management.Monitor.CounterMonitor t) => t.Cast<Javax.Management.Monitor.CounterMonitorMBean>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#getDifferenceMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#setDifferenceMode(boolean)"/>
        /// </summary>
        public bool DifferenceMode
        {
            get { return IExecute<bool>("getDifferenceMode"); } set { IExecute("setDifferenceMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#getInitThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#setInitThreshold(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number InitThreshold
        {
            get { return IExecute<Java.Lang.Number>("getInitThreshold"); } set { IExecute("setInitThreshold", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#getModulus()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#setModulus(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number Modulus
        {
            get { return IExecute<Java.Lang.Number>("getModulus"); } set { IExecute("setModulus", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#getNotify()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#setNotify(boolean)"/>
        /// </summary>
        public bool Notify
        {
            get { return IExecute<bool>("getNotify"); } set { IExecute("setNotify", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#getOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#setOffset(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number Offset
        {
            get { return IExecute<Java.Lang.Number>("getOffset"); } set { IExecute("setOffset", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#getDerivedGauge(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetDerivedGauge(Javax.Management.ObjectName arg0)
        {
            return IExecute<Java.Lang.Number>("getDerivedGauge", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#getThreshold(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetThreshold(Javax.Management.ObjectName arg0)
        {
            return IExecute<Java.Lang.Number>("getThreshold", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitor.html#getDerivedGaugeTimeStamp(javax.management.ObjectName)"/>
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