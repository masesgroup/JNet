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

namespace Java.Time
{
    #region ZonedDateTime
    public partial class ZonedDateTime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.ZonedDateTime"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.ZonedDateTime t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.ZonedDateTime"/> to <see cref="Java.Time.Chrono.ChronoZonedDateTime"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.ChronoZonedDateTime(Java.Time.ZonedDateTime t) => t.Cast<Java.Time.Chrono.ChronoZonedDateTime>();
        /// <summary>
        /// Converter from <see cref="Java.Time.ZonedDateTime"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.ZonedDateTime t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#now()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Now()
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "now");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Now(Java.Time.Clock arg0)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Now(Java.Time.ZoneId arg0)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#of(int,int,int,int,int,int,int,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Of(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Java.Time.ZoneId arg7)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#of(java.time.LocalDate,java.time.LocalTime,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.LocalTime"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Of(Java.Time.LocalDate arg0, Java.Time.LocalTime arg1, Java.Time.ZoneId arg2)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#of(java.time.LocalDateTime,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Of(Java.Time.LocalDateTime arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#ofInstant(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "ofInstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#ofInstant(java.time.LocalDateTime,java.time.ZoneOffset,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime OfInstant(Java.Time.LocalDateTime arg0, Java.Time.ZoneOffset arg1, Java.Time.ZoneId arg2)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "ofInstant", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#ofLocal(java.time.LocalDateTime,java.time.ZoneId,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime OfLocal(Java.Time.LocalDateTime arg0, Java.Time.ZoneId arg1, Java.Time.ZoneOffset arg2)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "ofLocal", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#ofStrict(java.time.LocalDateTime,java.time.ZoneOffset,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime OfStrict(Java.Time.LocalDateTime arg0, Java.Time.ZoneOffset arg1, Java.Time.ZoneId arg2)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "ofStrict", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Parse(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "parse", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getDayOfMonth()"/> 
        /// </summary>
        public int DayOfMonth
        {
            get { return IExecute<int>("getDayOfMonth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getDayOfWeek()"/> 
        /// </summary>
        public Java.Time.DayOfWeek DayOfWeek
        {
            get { return IExecute<Java.Time.DayOfWeek>("getDayOfWeek"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getDayOfYear()"/> 
        /// </summary>
        public int DayOfYear
        {
            get { return IExecute<int>("getDayOfYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getHour()"/> 
        /// </summary>
        public int Hour
        {
            get { return IExecute<int>("getHour"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getMinute()"/> 
        /// </summary>
        public int Minute
        {
            get { return IExecute<int>("getMinute"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getMonth()"/> 
        /// </summary>
        public Java.Time.Month Month
        {
            get { return IExecute<Java.Time.Month>("getMonth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getMonthValue()"/> 
        /// </summary>
        public int MonthValue
        {
            get { return IExecute<int>("getMonthValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getNano()"/> 
        /// </summary>
        public int Nano
        {
            get { return IExecute<int>("getNano"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getOffset()"/> 
        /// </summary>
        public Java.Time.ZoneOffset Offset
        {
            get { return IExecute<Java.Time.ZoneOffset>("getOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getSecond()"/> 
        /// </summary>
        public int Second
        {
            get { return IExecute<int>("getSecond"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getYear()"/> 
        /// </summary>
        public int Year
        {
            get { return IExecute<int>("getYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getZone()"/> 
        /// </summary>
        public Java.Time.ZoneId Zone
        {
            get { return IExecute<Java.Time.ZoneId>("getZone"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecute<R>("query", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="string"/></returns>
        public string Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#toLocalDate()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate ToLocalDate()
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("toLocalDate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#toLocalDateTime()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></returns>
        public Java.Time.Chrono.ChronoLocalDateTime ToLocalDateTime()
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDateTime>("toLocalDateTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withEarlierOffsetAtOverlap()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime WithEarlierOffsetAtOverlap()
        {
            return IExecute<Java.Time.Chrono.ChronoZonedDateTime>("withEarlierOffsetAtOverlap");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withLaterOffsetAtOverlap()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime WithLaterOffsetAtOverlap()
        {
            return IExecute<Java.Time.Chrono.ChronoZonedDateTime>("withLaterOffsetAtOverlap");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withZoneSameInstant(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime WithZoneSameInstant(Java.Time.ZoneId arg0)
        {
            return IExecute<Java.Time.Chrono.ChronoZonedDateTime>("withZoneSameInstant", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withZoneSameLocal(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime WithZoneSameLocal(Java.Time.ZoneId arg0)
        {
            return IExecute<Java.Time.Chrono.ChronoZonedDateTime>("withZoneSameLocal", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#toLocalTime()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime ToLocalTime()
        {
            return IExecute<Java.Time.LocalTime>("toLocalTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#toOffsetDateTime()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.OffsetDateTime"/></returns>
        public Java.Time.OffsetDateTime ToOffsetDateTime()
        {
            return IExecute<Java.Time.OffsetDateTime>("toOffsetDateTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#minusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusDays(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("minusDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#minusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusHours(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("minusHours", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#minusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusMinutes(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("minusMinutes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#minusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusMonths(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("minusMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#minusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusNanos(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("minusNanos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#minusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusSeconds(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("minusSeconds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#minusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusWeeks(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("minusWeeks", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#minusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusYears(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("minusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#plusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusDays(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("plusDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#plusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusHours(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("plusHours", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#plusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusMinutes(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("plusMinutes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#plusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusMonths(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("plusMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#plusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusNanos(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("plusNanos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#plusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusSeconds(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("plusSeconds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#plusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusWeeks(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("plusWeeks", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#plusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusYears(long arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("plusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#truncatedTo(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("truncatedTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withDayOfMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithDayOfMonth(int arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("withDayOfMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withDayOfYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithDayOfYear(int arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("withDayOfYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withFixedOffsetZone()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithFixedOffsetZone()
        {
            return IExecute<Java.Time.ZonedDateTime>("withFixedOffsetZone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withHour(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithHour(int arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("withHour", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withMinute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithMinute(int arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("withMinute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithMonth(int arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("withMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withNano(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithNano(int arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("withNano", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withSecond(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithSecond(int arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("withSecond", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#withYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithYear(int arg0)
        {
            return IExecute<Java.Time.ZonedDateTime>("withYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<long>("getLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZonedDateTime.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
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