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

namespace Java.Time.Temporal
{
    #region WeekFields
    public partial class WeekFields
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Temporal.WeekFields"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Temporal.WeekFields t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#WEEK_BASED_YEARS"/>
        /// </summary>
        public static Java.Time.Temporal.TemporalUnit WEEK_BASED_YEARS { get { return SGetField<Java.Time.Temporal.TemporalUnit>(LocalBridgeClazz, "WEEK_BASED_YEARS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#ISO"/>
        /// </summary>
        public static Java.Time.Temporal.WeekFields ISO { get { return SGetField<Java.Time.Temporal.WeekFields>(LocalBridgeClazz, "ISO"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#SUNDAY_START"/>
        /// </summary>
        public static Java.Time.Temporal.WeekFields SUNDAY_START { get { return SGetField<Java.Time.Temporal.WeekFields>(LocalBridgeClazz, "SUNDAY_START"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#of(java.time.DayOfWeek,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.DayOfWeek"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Temporal.WeekFields"/></returns>
        public static Java.Time.Temporal.WeekFields Of(Java.Time.DayOfWeek arg0, int arg1)
        {
            return SExecute<Java.Time.Temporal.WeekFields>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#of(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Temporal.WeekFields"/></returns>
        public static Java.Time.Temporal.WeekFields Of(Java.Util.Locale arg0)
        {
            return SExecute<Java.Time.Temporal.WeekFields>(LocalBridgeClazz, "of", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#dayOfWeek()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalField DayOfWeek
        {
            get { return IExecute<Java.Time.Temporal.TemporalField>("dayOfWeek"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#getFirstDayOfWeek()"/> 
        /// </summary>
        public Java.Time.DayOfWeek FirstDayOfWeek
        {
            get { return IExecute<Java.Time.DayOfWeek>("getFirstDayOfWeek"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#getMinimalDaysInFirstWeek()"/> 
        /// </summary>
        public int MinimalDaysInFirstWeek
        {
            get { return IExecute<int>("getMinimalDaysInFirstWeek"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#weekBasedYear()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalField WeekBasedYear
        {
            get { return IExecute<Java.Time.Temporal.TemporalField>("weekBasedYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#weekOfMonth()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalField WeekOfMonth
        {
            get { return IExecute<Java.Time.Temporal.TemporalField>("weekOfMonth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#weekOfWeekBasedYear()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalField WeekOfWeekBasedYear
        {
            get { return IExecute<Java.Time.Temporal.TemporalField>("weekOfWeekBasedYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#weekOfYear()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalField WeekOfYear
        {
            get { return IExecute<Java.Time.Temporal.TemporalField>("weekOfYear"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}