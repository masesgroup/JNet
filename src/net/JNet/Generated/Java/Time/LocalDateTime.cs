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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region LocalDateTime
    public partial class LocalDateTime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDateTime"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.LocalDateTime t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDateTime"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.LocalDateTime t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDateTime"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.LocalDateTime t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#MAX"/>
        /// </summary>
        public static Java.Time.LocalDateTime MAX => Clazz.GetField<Java.Time.LocalDateTime>("MAX");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#MIN"/>
        /// </summary>
        public static Java.Time.LocalDateTime MIN => Clazz.GetField<Java.Time.LocalDateTime>("MIN");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#now()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Now()
        {
            return SExecute<Java.Time.LocalDateTime>("now");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Now(Java.Time.Clock arg0)
        {
            return SExecute<Java.Time.LocalDateTime>("now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Now(Java.Time.ZoneId arg0)
        {
            return SExecute<Java.Time.LocalDateTime>("now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#of(int,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <param name="arg3"><see langword="int"/></param>
        /// <param name="arg4"><see langword="int"/></param>
        /// <param name="arg5"><see langword="int"/></param>
        /// <param name="arg6"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
        {
            return SExecute<Java.Time.LocalDateTime>("of", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#of(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <param name="arg3"><see langword="int"/></param>
        /// <param name="arg4"><see langword="int"/></param>
        /// <param name="arg5"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return SExecute<Java.Time.LocalDateTime>("of", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#of(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <param name="arg3"><see langword="int"/></param>
        /// <param name="arg4"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(int arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return SExecute<Java.Time.LocalDateTime>("of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#of(java.time.LocalDate,java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(Java.Time.LocalDate arg0, Java.Time.LocalTime arg1)
        {
            return SExecute<Java.Time.LocalDateTime>("of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#ofEpochSecond(long,int,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime OfEpochSecond(long arg0, int arg1, Java.Time.ZoneOffset arg2)
        {
            return SExecute<Java.Time.LocalDateTime>("ofEpochSecond", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#ofInstant(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.LocalDateTime>("ofInstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.LocalDateTime>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Parse(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Time.LocalDateTime>("parse", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#getDayOfMonth()"/> 
        /// </summary>
        public int DayOfMonth
        {
            get { return IExecute<int>("getDayOfMonth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#getDayOfYear()"/> 
        /// </summary>
        public int DayOfYear
        {
            get { return IExecute<int>("getDayOfYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#getHour()"/> 
        /// </summary>
        public int Hour
        {
            get { return IExecute<int>("getHour"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#getMinute()"/> 
        /// </summary>
        public int Minute
        {
            get { return IExecute<int>("getMinute"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#getMonthValue()"/> 
        /// </summary>
        public int MonthValue
        {
            get { return IExecute<int>("getMonthValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#getNano()"/> 
        /// </summary>
        public int Nano
        {
            get { return IExecute<int>("getNano"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#getSecond()"/> 
        /// </summary>
        public int Second
        {
            get { return IExecute<int>("getSecond"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#getYear()"/> 
        /// </summary>
        public int Year
        {
            get { return IExecute<int>("getYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see langword="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see langword="string"/></returns>
        public string Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#toLocalDate()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate ToLocalDate()
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("toLocalDate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#minusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusDays(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("minusDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#minusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusHours(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("minusHours", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#minusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusMinutes(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("minusMinutes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#minusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusMonths(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("minusMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#minusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusNanos(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("minusNanos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#minusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusSeconds(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("minusSeconds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#minusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusWeeks(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("minusWeeks", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#minusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusYears(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("minusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#plusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusDays(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("plusDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#plusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusHours(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("plusHours", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#plusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusMinutes(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("plusMinutes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#plusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusMonths(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("plusMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#plusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusNanos(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("plusNanos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#plusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusSeconds(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("plusSeconds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#plusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusWeeks(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("plusWeeks", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#plusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusYears(long arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("plusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#truncatedTo(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("truncatedTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#withDayOfMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithDayOfMonth(int arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("withDayOfMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#withDayOfYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithDayOfYear(int arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("withDayOfYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#withHour(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithHour(int arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("withHour", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#withMinute(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithMinute(int arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("withMinute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#withMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithMonth(int arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("withMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#withNano(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithNano(int arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("withNano", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#withSecond(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithSecond(int arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("withSecond", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#withYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithYear(int arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("withYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#toLocalTime()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime ToLocalTime()
        {
            return IExecute<Java.Time.LocalTime>("toLocalTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#atOffset(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.OffsetDateTime"/></returns>
        public Java.Time.OffsetDateTime AtOffset(Java.Time.ZoneOffset arg0)
        {
            return IExecute<Java.Time.OffsetDateTime>("atOffset", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("adjustInto", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see langword="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<long>("getLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalDateTime.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see langword="long"/></returns>
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