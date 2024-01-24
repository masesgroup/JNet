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

namespace Java.Time.Temporal
{
    #region ChronoField
    public partial class ChronoField
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Temporal.ChronoField"/> to <see cref="Java.Time.Temporal.TemporalField"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalField(Java.Time.Temporal.ChronoField t) => t.Cast<Java.Time.Temporal.TemporalField>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ALIGNED_DAY_OF_WEEK_IN_MONTH"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ALIGNED_DAY_OF_WEEK_IN_MONTH { get { if (!_ALIGNED_DAY_OF_WEEK_IN_MONTHReady) { _ALIGNED_DAY_OF_WEEK_IN_MONTHContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ALIGNED_DAY_OF_WEEK_IN_MONTH"); _ALIGNED_DAY_OF_WEEK_IN_MONTHReady = true; } return _ALIGNED_DAY_OF_WEEK_IN_MONTHContent; } }
        private static Java.Time.Temporal.ChronoField _ALIGNED_DAY_OF_WEEK_IN_MONTHContent = default;
        private static bool _ALIGNED_DAY_OF_WEEK_IN_MONTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ALIGNED_DAY_OF_WEEK_IN_YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ALIGNED_DAY_OF_WEEK_IN_YEAR { get { if (!_ALIGNED_DAY_OF_WEEK_IN_YEARReady) { _ALIGNED_DAY_OF_WEEK_IN_YEARContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ALIGNED_DAY_OF_WEEK_IN_YEAR"); _ALIGNED_DAY_OF_WEEK_IN_YEARReady = true; } return _ALIGNED_DAY_OF_WEEK_IN_YEARContent; } }
        private static Java.Time.Temporal.ChronoField _ALIGNED_DAY_OF_WEEK_IN_YEARContent = default;
        private static bool _ALIGNED_DAY_OF_WEEK_IN_YEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ALIGNED_WEEK_OF_MONTH"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ALIGNED_WEEK_OF_MONTH { get { if (!_ALIGNED_WEEK_OF_MONTHReady) { _ALIGNED_WEEK_OF_MONTHContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ALIGNED_WEEK_OF_MONTH"); _ALIGNED_WEEK_OF_MONTHReady = true; } return _ALIGNED_WEEK_OF_MONTHContent; } }
        private static Java.Time.Temporal.ChronoField _ALIGNED_WEEK_OF_MONTHContent = default;
        private static bool _ALIGNED_WEEK_OF_MONTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ALIGNED_WEEK_OF_YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ALIGNED_WEEK_OF_YEAR { get { if (!_ALIGNED_WEEK_OF_YEARReady) { _ALIGNED_WEEK_OF_YEARContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ALIGNED_WEEK_OF_YEAR"); _ALIGNED_WEEK_OF_YEARReady = true; } return _ALIGNED_WEEK_OF_YEARContent; } }
        private static Java.Time.Temporal.ChronoField _ALIGNED_WEEK_OF_YEARContent = default;
        private static bool _ALIGNED_WEEK_OF_YEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#AMPM_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField AMPM_OF_DAY { get { if (!_AMPM_OF_DAYReady) { _AMPM_OF_DAYContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "AMPM_OF_DAY"); _AMPM_OF_DAYReady = true; } return _AMPM_OF_DAYContent; } }
        private static Java.Time.Temporal.ChronoField _AMPM_OF_DAYContent = default;
        private static bool _AMPM_OF_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#CLOCK_HOUR_OF_AMPM"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField CLOCK_HOUR_OF_AMPM { get { if (!_CLOCK_HOUR_OF_AMPMReady) { _CLOCK_HOUR_OF_AMPMContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "CLOCK_HOUR_OF_AMPM"); _CLOCK_HOUR_OF_AMPMReady = true; } return _CLOCK_HOUR_OF_AMPMContent; } }
        private static Java.Time.Temporal.ChronoField _CLOCK_HOUR_OF_AMPMContent = default;
        private static bool _CLOCK_HOUR_OF_AMPMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#CLOCK_HOUR_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField CLOCK_HOUR_OF_DAY { get { if (!_CLOCK_HOUR_OF_DAYReady) { _CLOCK_HOUR_OF_DAYContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "CLOCK_HOUR_OF_DAY"); _CLOCK_HOUR_OF_DAYReady = true; } return _CLOCK_HOUR_OF_DAYContent; } }
        private static Java.Time.Temporal.ChronoField _CLOCK_HOUR_OF_DAYContent = default;
        private static bool _CLOCK_HOUR_OF_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#DAY_OF_MONTH"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField DAY_OF_MONTH { get { if (!_DAY_OF_MONTHReady) { _DAY_OF_MONTHContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "DAY_OF_MONTH"); _DAY_OF_MONTHReady = true; } return _DAY_OF_MONTHContent; } }
        private static Java.Time.Temporal.ChronoField _DAY_OF_MONTHContent = default;
        private static bool _DAY_OF_MONTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#DAY_OF_WEEK"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField DAY_OF_WEEK { get { if (!_DAY_OF_WEEKReady) { _DAY_OF_WEEKContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "DAY_OF_WEEK"); _DAY_OF_WEEKReady = true; } return _DAY_OF_WEEKContent; } }
        private static Java.Time.Temporal.ChronoField _DAY_OF_WEEKContent = default;
        private static bool _DAY_OF_WEEKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#DAY_OF_YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField DAY_OF_YEAR { get { if (!_DAY_OF_YEARReady) { _DAY_OF_YEARContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "DAY_OF_YEAR"); _DAY_OF_YEARReady = true; } return _DAY_OF_YEARContent; } }
        private static Java.Time.Temporal.ChronoField _DAY_OF_YEARContent = default;
        private static bool _DAY_OF_YEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#EPOCH_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField EPOCH_DAY { get { if (!_EPOCH_DAYReady) { _EPOCH_DAYContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "EPOCH_DAY"); _EPOCH_DAYReady = true; } return _EPOCH_DAYContent; } }
        private static Java.Time.Temporal.ChronoField _EPOCH_DAYContent = default;
        private static bool _EPOCH_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ERA"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ERA { get { if (!_ERAReady) { _ERAContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ERA"); _ERAReady = true; } return _ERAContent; } }
        private static Java.Time.Temporal.ChronoField _ERAContent = default;
        private static bool _ERAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#HOUR_OF_AMPM"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField HOUR_OF_AMPM { get { if (!_HOUR_OF_AMPMReady) { _HOUR_OF_AMPMContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "HOUR_OF_AMPM"); _HOUR_OF_AMPMReady = true; } return _HOUR_OF_AMPMContent; } }
        private static Java.Time.Temporal.ChronoField _HOUR_OF_AMPMContent = default;
        private static bool _HOUR_OF_AMPMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#HOUR_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField HOUR_OF_DAY { get { if (!_HOUR_OF_DAYReady) { _HOUR_OF_DAYContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "HOUR_OF_DAY"); _HOUR_OF_DAYReady = true; } return _HOUR_OF_DAYContent; } }
        private static Java.Time.Temporal.ChronoField _HOUR_OF_DAYContent = default;
        private static bool _HOUR_OF_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#INSTANT_SECONDS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField INSTANT_SECONDS { get { if (!_INSTANT_SECONDSReady) { _INSTANT_SECONDSContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "INSTANT_SECONDS"); _INSTANT_SECONDSReady = true; } return _INSTANT_SECONDSContent; } }
        private static Java.Time.Temporal.ChronoField _INSTANT_SECONDSContent = default;
        private static bool _INSTANT_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MICRO_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MICRO_OF_DAY { get { if (!_MICRO_OF_DAYReady) { _MICRO_OF_DAYContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MICRO_OF_DAY"); _MICRO_OF_DAYReady = true; } return _MICRO_OF_DAYContent; } }
        private static Java.Time.Temporal.ChronoField _MICRO_OF_DAYContent = default;
        private static bool _MICRO_OF_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MICRO_OF_SECOND"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MICRO_OF_SECOND { get { if (!_MICRO_OF_SECONDReady) { _MICRO_OF_SECONDContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MICRO_OF_SECOND"); _MICRO_OF_SECONDReady = true; } return _MICRO_OF_SECONDContent; } }
        private static Java.Time.Temporal.ChronoField _MICRO_OF_SECONDContent = default;
        private static bool _MICRO_OF_SECONDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MILLI_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MILLI_OF_DAY { get { if (!_MILLI_OF_DAYReady) { _MILLI_OF_DAYContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MILLI_OF_DAY"); _MILLI_OF_DAYReady = true; } return _MILLI_OF_DAYContent; } }
        private static Java.Time.Temporal.ChronoField _MILLI_OF_DAYContent = default;
        private static bool _MILLI_OF_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MILLI_OF_SECOND"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MILLI_OF_SECOND { get { if (!_MILLI_OF_SECONDReady) { _MILLI_OF_SECONDContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MILLI_OF_SECOND"); _MILLI_OF_SECONDReady = true; } return _MILLI_OF_SECONDContent; } }
        private static Java.Time.Temporal.ChronoField _MILLI_OF_SECONDContent = default;
        private static bool _MILLI_OF_SECONDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MINUTE_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MINUTE_OF_DAY { get { if (!_MINUTE_OF_DAYReady) { _MINUTE_OF_DAYContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MINUTE_OF_DAY"); _MINUTE_OF_DAYReady = true; } return _MINUTE_OF_DAYContent; } }
        private static Java.Time.Temporal.ChronoField _MINUTE_OF_DAYContent = default;
        private static bool _MINUTE_OF_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MINUTE_OF_HOUR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MINUTE_OF_HOUR { get { if (!_MINUTE_OF_HOURReady) { _MINUTE_OF_HOURContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MINUTE_OF_HOUR"); _MINUTE_OF_HOURReady = true; } return _MINUTE_OF_HOURContent; } }
        private static Java.Time.Temporal.ChronoField _MINUTE_OF_HOURContent = default;
        private static bool _MINUTE_OF_HOURReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MONTH_OF_YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MONTH_OF_YEAR { get { if (!_MONTH_OF_YEARReady) { _MONTH_OF_YEARContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MONTH_OF_YEAR"); _MONTH_OF_YEARReady = true; } return _MONTH_OF_YEARContent; } }
        private static Java.Time.Temporal.ChronoField _MONTH_OF_YEARContent = default;
        private static bool _MONTH_OF_YEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#NANO_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField NANO_OF_DAY { get { if (!_NANO_OF_DAYReady) { _NANO_OF_DAYContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "NANO_OF_DAY"); _NANO_OF_DAYReady = true; } return _NANO_OF_DAYContent; } }
        private static Java.Time.Temporal.ChronoField _NANO_OF_DAYContent = default;
        private static bool _NANO_OF_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#NANO_OF_SECOND"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField NANO_OF_SECOND { get { if (!_NANO_OF_SECONDReady) { _NANO_OF_SECONDContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "NANO_OF_SECOND"); _NANO_OF_SECONDReady = true; } return _NANO_OF_SECONDContent; } }
        private static Java.Time.Temporal.ChronoField _NANO_OF_SECONDContent = default;
        private static bool _NANO_OF_SECONDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#OFFSET_SECONDS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField OFFSET_SECONDS { get { if (!_OFFSET_SECONDSReady) { _OFFSET_SECONDSContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "OFFSET_SECONDS"); _OFFSET_SECONDSReady = true; } return _OFFSET_SECONDSContent; } }
        private static Java.Time.Temporal.ChronoField _OFFSET_SECONDSContent = default;
        private static bool _OFFSET_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#PROLEPTIC_MONTH"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField PROLEPTIC_MONTH { get { if (!_PROLEPTIC_MONTHReady) { _PROLEPTIC_MONTHContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "PROLEPTIC_MONTH"); _PROLEPTIC_MONTHReady = true; } return _PROLEPTIC_MONTHContent; } }
        private static Java.Time.Temporal.ChronoField _PROLEPTIC_MONTHContent = default;
        private static bool _PROLEPTIC_MONTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#SECOND_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField SECOND_OF_DAY { get { if (!_SECOND_OF_DAYReady) { _SECOND_OF_DAYContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "SECOND_OF_DAY"); _SECOND_OF_DAYReady = true; } return _SECOND_OF_DAYContent; } }
        private static Java.Time.Temporal.ChronoField _SECOND_OF_DAYContent = default;
        private static bool _SECOND_OF_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#SECOND_OF_MINUTE"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField SECOND_OF_MINUTE { get { if (!_SECOND_OF_MINUTEReady) { _SECOND_OF_MINUTEContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "SECOND_OF_MINUTE"); _SECOND_OF_MINUTEReady = true; } return _SECOND_OF_MINUTEContent; } }
        private static Java.Time.Temporal.ChronoField _SECOND_OF_MINUTEContent = default;
        private static bool _SECOND_OF_MINUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField YEAR { get { if (!_YEARReady) { _YEARContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "YEAR"); _YEARReady = true; } return _YEARContent; } }
        private static Java.Time.Temporal.ChronoField _YEARContent = default;
        private static bool _YEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#YEAR_OF_ERA"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField YEAR_OF_ERA { get { if (!_YEAR_OF_ERAReady) { _YEAR_OF_ERAContent = SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "YEAR_OF_ERA"); _YEAR_OF_ERAReady = true; } return _YEAR_OF_ERAContent; } }
        private static Java.Time.Temporal.ChronoField _YEAR_OF_ERAContent = default;
        private static bool _YEAR_OF_ERAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.Temporal.ChronoField"/></returns>
        public static Java.Time.Temporal.ChronoField ValueOf(string arg0)
        {
            return SExecute<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Temporal.ChronoField"/></returns>
        public static Java.Time.Temporal.ChronoField[] Values()
        {
            return SExecuteArray<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#getBaseUnit()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalUnit BaseUnit
        {
            get { return IExecute<Java.Time.Temporal.TemporalUnit>("getBaseUnit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#getRangeUnit()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalUnit RangeUnit
        {
            get { return IExecute<Java.Time.Temporal.TemporalUnit>("getRangeUnit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#adjustInto(java.time.temporal.Temporal,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="R"><see cref="Java.Time.Temporal.ITemporal"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R AdjustInto<R>(R arg0, long arg1) where R: Java.Time.Temporal.ITemporal, new()
        {
            return IExecute<R>("adjustInto", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#isDateBased()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDateBased()
        {
            return IExecute<bool>("isDateBased");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#isSupportedBy(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupportedBy(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecute<bool>("isSupportedBy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#isTimeBased()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTimeBased()
        {
            return IExecute<bool>("isTimeBased");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#checkValidIntValue(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int CheckValidIntValue(long arg0)
        {
            return IExecute<int>("checkValidIntValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#getDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayName(Java.Util.Locale arg0)
        {
            return IExecute<string>("getDisplayName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#range()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range()
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#rangeRefinedBy(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange RangeRefinedBy(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("rangeRefinedBy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#checkValidValue(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long CheckValidValue(long arg0)
        {
            return IExecute<long>("checkValidValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#getFrom(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetFrom(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecute<long>("getFrom", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}