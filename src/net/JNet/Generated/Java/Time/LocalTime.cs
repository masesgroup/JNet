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
    #region LocalTime
    public partial class LocalTime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalTime"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.LocalTime t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalTime"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.LocalTime t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalTime"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.LocalTime t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#MAX"/>
        /// </summary>
        public static Java.Time.LocalTime MAX => Clazz.GetField<Java.Time.LocalTime>("MAX");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#MIDNIGHT"/>
        /// </summary>
        public static Java.Time.LocalTime MIDNIGHT => Clazz.GetField<Java.Time.LocalTime>("MIDNIGHT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#MIN"/>
        /// </summary>
        public static Java.Time.LocalTime MIN => Clazz.GetField<Java.Time.LocalTime>("MIN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#NOON"/>
        /// </summary>
        public static Java.Time.LocalTime NOON => Clazz.GetField<Java.Time.LocalTime>("NOON");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecute<Java.Time.LocalTime>("from", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#now()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Now()
        {
            return SExecute<Java.Time.LocalTime>("now");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Now(Java.Time.Clock arg0)
        {
            return SExecute<Java.Time.LocalTime>("now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Now(Java.Time.ZoneId arg0)
        {
            return SExecute<Java.Time.LocalTime>("now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#of(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Of(int arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Time.LocalTime>("of", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#of(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Of(int arg0, int arg1, int arg2)
        {
            return SExecute<Java.Time.LocalTime>("of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#of(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Of(int arg0, int arg1)
        {
            return SExecute<Java.Time.LocalTime>("of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#ofInstant(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.LocalTime>("ofInstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#ofNanoOfDay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime OfNanoOfDay(long arg0)
        {
            return SExecute<Java.Time.LocalTime>("ofNanoOfDay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#ofSecondOfDay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime OfSecondOfDay(long arg0)
        {
            return SExecute<Java.Time.LocalTime>("ofSecondOfDay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.LocalTime>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Parse(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Time.LocalTime>("parse", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getHour()"/> 
        /// </summary>
        public int Hour
        {
            get { return IExecute<int>("getHour"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getMinute()"/> 
        /// </summary>
        public int Minute
        {
            get { return IExecute<int>("getMinute"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getNano()"/> 
        /// </summary>
        public int Nano
        {
            get { return IExecute<int>("getNano"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getSecond()"/> 
        /// </summary>
        public int Second
        {
            get { return IExecute<int>("getSecond"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#isAfter(java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsAfter(Java.Time.LocalTime arg0)
        {
            return IExecute<bool>("isAfter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#isBefore(java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsBefore(Java.Time.LocalTime arg0)
        {
            return IExecute<bool>("isBefore", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#compareTo(java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see langword="int"/></returns>
        public int CompareTo(Java.Time.LocalTime arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see langword="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#toSecondOfDay()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int ToSecondOfDay()
        {
            return IExecute<int>("toSecondOfDay");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see langword="string"/></returns>
        public string Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#atDate(java.time.LocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtDate(Java.Time.LocalDate arg0)
        {
            return IExecute<Java.Time.LocalDateTime>("atDate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime MinusHours(long arg0)
        {
            return IExecute<Java.Time.LocalTime>("minusHours", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime MinusMinutes(long arg0)
        {
            return IExecute<Java.Time.LocalTime>("minusMinutes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime MinusNanos(long arg0)
        {
            return IExecute<Java.Time.LocalTime>("minusNanos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime MinusSeconds(long arg0)
        {
            return IExecute<Java.Time.LocalTime>("minusSeconds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime PlusHours(long arg0)
        {
            return IExecute<Java.Time.LocalTime>("plusHours", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime PlusMinutes(long arg0)
        {
            return IExecute<Java.Time.LocalTime>("plusMinutes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime PlusNanos(long arg0)
        {
            return IExecute<Java.Time.LocalTime>("plusNanos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime PlusSeconds(long arg0)
        {
            return IExecute<Java.Time.LocalTime>("plusSeconds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#truncatedTo(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<Java.Time.LocalTime>("truncatedTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#withHour(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime WithHour(int arg0)
        {
            return IExecute<Java.Time.LocalTime>("withHour", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#withMinute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime WithMinute(int arg0)
        {
            return IExecute<Java.Time.LocalTime>("withMinute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#withNano(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime WithNano(int arg0)
        {
            return IExecute<Java.Time.LocalTime>("withNano", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#withSecond(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime WithSecond(int arg0)
        {
            return IExecute<Java.Time.LocalTime>("withSecond", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#atOffset(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime AtOffset(Java.Time.ZoneOffset arg0)
        {
            return IExecute<Java.Time.OffsetTime>("atOffset", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("adjustInto", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#with(java.time.temporal.TemporalAdjuster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAdjuster"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalAdjuster arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#with(java.time.temporal.TemporalField,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalField arg0, long arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see langword="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<long>("getLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#toEpochSecond(java.time.LocalDate,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see langword="long"/></returns>
        public long ToEpochSecond(Java.Time.LocalDate arg0, Java.Time.ZoneOffset arg1)
        {
            return IExecute<long>("toEpochSecond", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#toNanoOfDay()"/>
        /// </summary>
        
        /// <returns><see langword="long"/></returns>
        public long ToNanoOfDay()
        {
            return IExecute<long>("toNanoOfDay");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
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