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
    #region StringMonitor
    public partial class StringMonitor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Monitor.StringMonitor"/> to <see cref="Javax.Management.Monitor.StringMonitorMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Monitor.StringMonitorMBean(Javax.Management.Monitor.StringMonitor t) => t.Cast<Javax.Management.Monitor.StringMonitorMBean>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/StringMonitor.html#getNotifyDiffer()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/StringMonitor.html#setNotifyDiffer(boolean)"/>
        /// </summary>
        public bool NotifyDiffer
        {
            get { return IExecute<bool>("getNotifyDiffer"); } set { IExecute("setNotifyDiffer", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/StringMonitor.html#getNotifyMatch()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/StringMonitor.html#setNotifyMatch(boolean)"/>
        /// </summary>
        public bool NotifyMatch
        {
            get { return IExecute<bool>("getNotifyMatch"); } set { IExecute("setNotifyMatch", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/StringMonitor.html#getStringToCompare()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/StringMonitor.html#setStringToCompare(java.lang.String)"/>
        /// </summary>
        public string StringToCompare
        {
            get { return IExecute<string>("getStringToCompare"); } set { IExecute("setStringToCompare", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/StringMonitor.html#getDerivedGauge(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDerivedGauge(Javax.Management.ObjectName arg0)
        {
            return IExecute<string>("getDerivedGauge", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/StringMonitor.html#getDerivedGaugeTimeStamp(javax.management.ObjectName)"/>
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