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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region LocalDate
    public partial class LocalDate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDate"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.LocalDate t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDate"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.LocalDate t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDate"/> to <see cref="Java.Time.Chrono.ChronoLocalDate"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.ChronoLocalDate(Java.Time.LocalDate t) => t.Cast<Java.Time.Chrono.ChronoLocalDate>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDate"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.LocalDate t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#EPOCH"/>
        /// </summary>
        public static Java.Time.LocalDate EPOCH { get { return SGetField<Java.Time.LocalDate>(LocalBridgeClazz, "EPOCH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#MAX"/>
        /// </summary>
        public static Java.Time.LocalDate MAX { get { return SGetField<Java.Time.LocalDate>(LocalBridgeClazz, "MAX"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#MIN"/>
        /// </summary>
        public static Java.Time.LocalDate MIN { get { return SGetField<Java.Time.LocalDate>(LocalBridgeClazz, "MIN"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#now()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Now()
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "now");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Now(Java.Time.Clock arg0)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Now(Java.Time.ZoneId arg0)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#of(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Of(int arg0, int arg1, int arg2)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#of(int,java.time.Month,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Time.Month"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Of(int arg0, Java.Time.Month arg1, int arg2)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#ofEpochDay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate OfEpochDay(long arg0)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "ofEpochDay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#ofInstant(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "ofInstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#ofYearDay(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate OfYearDay(int arg0, int arg1)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "ofYearDay", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Parse(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "parse", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#getChronology()"/> 
        /// </summary>
        public Java.Time.Chrono.Chronology Chronology
        {
            get { return IExecute<Java.Time.Chrono.Chronology>("getChronology"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#getDayOfMonth()"/> 
        /// </summary>
        public int DayOfMonth
        {
            get { return IExecute<int>("getDayOfMonth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#getDayOfWeek()"/> 
        /// </summary>
        public Java.Time.DayOfWeek DayOfWeek
        {
            get { return IExecute<Java.Time.DayOfWeek>("getDayOfWeek"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#getDayOfYear()"/> 
        /// </summary>
        public int DayOfYear
        {
            get { return IExecute<int>("getDayOfYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#getEra()"/> 
        /// </summary>
        public Java.Time.Chrono.Era Era
        {
            get { return IExecute<Java.Time.Chrono.Era>("getEra"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#getMonth()"/> 
        /// </summary>
        public Java.Time.Month Month
        {
            get { return IExecute<Java.Time.Month>("getMonth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#getMonthValue()"/> 
        /// </summary>
        public int MonthValue
        {
            get { return IExecute<int>("getMonthValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#getYear()"/> 
        /// </summary>
        public int Year
        {
            get { return IExecute<int>("getYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecute<R>("query", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#isAfter(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfter(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecute<bool>("isAfter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#isBefore(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBefore(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecute<bool>("isBefore", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#isEqual(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqual(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecute<bool>("isEqual", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#isLeapYear()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLeapYear()
        {
            return IExecute<bool>("isLeapYear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#compareTo(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#lengthOfMonth()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LengthOfMonth()
        {
            return IExecute<int>("lengthOfMonth");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#lengthOfYear()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LengthOfYear()
        {
            return IExecute<int>("lengthOfYear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="string"/></returns>
        public string Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#atTime(java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></returns>
        public Java.Time.Chrono.ChronoLocalDateTime AtTime(Java.Time.LocalTime arg0)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDateTime>("atTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#until(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Until(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecute<Java.Time.Chrono.ChronoPeriod>("until", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#minusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate MinusDays(long arg0)
        {
            return IExecute<Java.Time.LocalDate>("minusDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#minusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate MinusMonths(long arg0)
        {
            return IExecute<Java.Time.LocalDate>("minusMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#minusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate MinusWeeks(long arg0)
        {
            return IExecute<Java.Time.LocalDate>("minusWeeks", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#minusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate MinusYears(long arg0)
        {
            return IExecute<Java.Time.LocalDate>("minusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#plusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate PlusDays(long arg0)
        {
            return IExecute<Java.Time.LocalDate>("plusDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#plusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate PlusMonths(long arg0)
        {
            return IExecute<Java.Time.LocalDate>("plusMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#plusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate PlusWeeks(long arg0)
        {
            return IExecute<Java.Time.LocalDate>("plusWeeks", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#plusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate PlusYears(long arg0)
        {
            return IExecute<Java.Time.LocalDate>("plusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#withDayOfMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate WithDayOfMonth(int arg0)
        {
            return IExecute<Java.Time.LocalDate>("withDayOfMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#withDayOfYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate WithDayOfYear(int arg0)
        {
            return IExecute<Java.Time.LocalDate>("withDayOfYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#withMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate WithMonth(int arg0)
        {
            return IExecute<Java.Time.LocalDate>("withMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#withYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate WithYear(int arg0)
        {
            return IExecute<Java.Time.LocalDate>("withYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#atStartOfDay()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtStartOfDay()
        {
            return IExecute<Java.Time.LocalDateTime>("atStartOfDay");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#atTime(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtTime(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Java.Time.LocalDateTime>("atTime", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#atTime(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtTime(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Time.LocalDateTime>("atTime", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#atTime(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtTime(int arg0, int arg1)
        {
            return IExecute<Java.Time.LocalDateTime>("atTime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#atTime(java.time.OffsetTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.OffsetTime"/></param>
        /// <returns><see cref="Java.Time.OffsetDateTime"/></returns>
        public Java.Time.OffsetDateTime AtTime(Java.Time.OffsetTime arg0)
        {
            return IExecute<Java.Time.OffsetDateTime>("atTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("adjustInto", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#atStartOfDay(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime AtStartOfDay(Java.Time.ZoneId arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("atStartOfDay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#datesUntil(java.time.LocalDate,java.time.Period)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.Period"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Time.LocalDate> DatesUntil(Java.Time.LocalDate arg0, Java.Time.Period arg1)
        {
            return IExecute<Java.Util.Stream.Stream<Java.Time.LocalDate>>("datesUntil", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#datesUntil(java.time.LocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Time.LocalDate> DatesUntil(Java.Time.LocalDate arg0)
        {
            return IExecute<Java.Util.Stream.Stream<Java.Time.LocalDate>>("datesUntil", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<long>("getLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#toEpochDay()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ToEpochDay()
        {
            return IExecute<long>("toEpochDay");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#toEpochSecond(java.time.LocalTime,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToEpochSecond(Java.Time.LocalTime arg0, Java.Time.ZoneOffset arg1)
        {
            return IExecute<long>("toEpochSecond", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDate.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Until(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<long>("until", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}