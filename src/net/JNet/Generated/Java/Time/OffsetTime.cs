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
    #region OffsetTime
    public partial class OffsetTime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.OffsetTime t) => t.Cast<Java.Time.Temporal.Temporal>();
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.OffsetTime t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        public static implicit operator Java.Io.Serializable(Java.Time.OffsetTime t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#MIN
        /// </summary>
        public static Java.Time.OffsetTime MIN => Clazz.GetField<Java.Time.OffsetTime>("MIN");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#MAX
        /// </summary>
        public static Java.Time.OffsetTime MAX => Clazz.GetField<Java.Time.OffsetTime>("MAX");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#from(java.time.temporal.TemporalAccessor)
        /// </summary>
        public static Java.Time.OffsetTime From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecute<Java.Time.OffsetTime>("from", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#now()
        /// </summary>
        public static Java.Time.OffsetTime Now()
        {
            return SExecute<Java.Time.OffsetTime>("now");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#now(java.time.Clock)
        /// </summary>
        public static Java.Time.OffsetTime Now(Java.Time.Clock arg0)
        {
            return SExecute<Java.Time.OffsetTime>("now", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#now(java.time.ZoneId)
        /// </summary>
        public static Java.Time.OffsetTime Now(Java.Time.ZoneId arg0)
        {
            return SExecute<Java.Time.OffsetTime>("now", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#of(int,int,int,int,java.time.ZoneOffset)
        /// </summary>
        public static Java.Time.OffsetTime Of(int arg0, int arg1, int arg2, int arg3, Java.Time.ZoneOffset arg4)
        {
            return SExecute<Java.Time.OffsetTime>("of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#of(java.time.LocalTime,java.time.ZoneOffset)
        /// </summary>
        public static Java.Time.OffsetTime Of(Java.Time.LocalTime arg0, Java.Time.ZoneOffset arg1)
        {
            return SExecute<Java.Time.OffsetTime>("of", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#ofInstant(java.time.Instant,java.time.ZoneId)
        /// </summary>
        public static Java.Time.OffsetTime OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.OffsetTime>("ofInstant", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)
        /// </summary>
        public static Java.Time.OffsetTime Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.OffsetTime>("parse", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#parse(java.lang.CharSequence)
        /// </summary>
        public static Java.Time.OffsetTime Parse(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Time.OffsetTime>("parse", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#getHour() 
        /// </summary>
        public int Hour
        {
            get { return IExecute<int>("getHour"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#getMinute() 
        /// </summary>
        public int Minute
        {
            get { return IExecute<int>("getMinute"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#getNano() 
        /// </summary>
        public int Nano
        {
            get { return IExecute<int>("getNano"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#getOffset() 
        /// </summary>
        public Java.Time.ZoneOffset Offset
        {
            get { return IExecute<Java.Time.ZoneOffset>("getOffset"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#getSecond() 
        /// </summary>
        public int Second
        {
            get { return IExecute<int>("getSecond"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#isAfter(java.time.OffsetTime)
        /// </summary>
        public bool IsAfter(Java.Time.OffsetTime arg0)
        {
            return IExecute<bool>("isAfter", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#isBefore(java.time.OffsetTime)
        /// </summary>
        public bool IsBefore(Java.Time.OffsetTime arg0)
        {
            return IExecute<bool>("isBefore", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#isEqual(java.time.OffsetTime)
        /// </summary>
        public bool IsEqual(Java.Time.OffsetTime arg0)
        {
            return IExecute<bool>("isEqual", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#isSupported(java.time.temporal.TemporalField)
        /// </summary>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#isSupported(java.time.temporal.TemporalUnit)
        /// </summary>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#compareTo(java.lang.Object)
        /// </summary>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#compareTo(java.time.OffsetTime)
        /// </summary>
        public int CompareTo(Java.Time.OffsetTime arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#get(java.time.temporal.TemporalField)
        /// </summary>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#format(java.time.format.DateTimeFormatter)
        /// </summary>
        public string Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#toLocalTime()
        /// </summary>
        public Java.Time.LocalTime ToLocalTime()
        {
            return IExecute<Java.Time.LocalTime>("toLocalTime");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#atDate(java.time.LocalDate)
        /// </summary>
        public Java.Time.OffsetDateTime AtDate(Java.Time.LocalDate arg0)
        {
            return IExecute<Java.Time.OffsetDateTime>("atDate", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#minusHours(long)
        /// </summary>
        public Java.Time.OffsetTime MinusHours(long arg0)
        {
            return IExecute<Java.Time.OffsetTime>("minusHours", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#minusMinutes(long)
        /// </summary>
        public Java.Time.OffsetTime MinusMinutes(long arg0)
        {
            return IExecute<Java.Time.OffsetTime>("minusMinutes", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#minusNanos(long)
        /// </summary>
        public Java.Time.OffsetTime MinusNanos(long arg0)
        {
            return IExecute<Java.Time.OffsetTime>("minusNanos", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#minusSeconds(long)
        /// </summary>
        public Java.Time.OffsetTime MinusSeconds(long arg0)
        {
            return IExecute<Java.Time.OffsetTime>("minusSeconds", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#plusHours(long)
        /// </summary>
        public Java.Time.OffsetTime PlusHours(long arg0)
        {
            return IExecute<Java.Time.OffsetTime>("plusHours", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#plusMinutes(long)
        /// </summary>
        public Java.Time.OffsetTime PlusMinutes(long arg0)
        {
            return IExecute<Java.Time.OffsetTime>("plusMinutes", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#plusNanos(long)
        /// </summary>
        public Java.Time.OffsetTime PlusNanos(long arg0)
        {
            return IExecute<Java.Time.OffsetTime>("plusNanos", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#plusSeconds(long)
        /// </summary>
        public Java.Time.OffsetTime PlusSeconds(long arg0)
        {
            return IExecute<Java.Time.OffsetTime>("plusSeconds", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#truncatedTo(java.time.temporal.TemporalUnit)
        /// </summary>
        public Java.Time.OffsetTime TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<Java.Time.OffsetTime>("truncatedTo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#withHour(int)
        /// </summary>
        public Java.Time.OffsetTime WithHour(int arg0)
        {
            return IExecute<Java.Time.OffsetTime>("withHour", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#withMinute(int)
        /// </summary>
        public Java.Time.OffsetTime WithMinute(int arg0)
        {
            return IExecute<Java.Time.OffsetTime>("withMinute", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#withNano(int)
        /// </summary>
        public Java.Time.OffsetTime WithNano(int arg0)
        {
            return IExecute<Java.Time.OffsetTime>("withNano", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#withOffsetSameInstant(java.time.ZoneOffset)
        /// </summary>
        public Java.Time.OffsetTime WithOffsetSameInstant(Java.Time.ZoneOffset arg0)
        {
            return IExecute<Java.Time.OffsetTime>("withOffsetSameInstant", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#withOffsetSameLocal(java.time.ZoneOffset)
        /// </summary>
        public Java.Time.OffsetTime WithOffsetSameLocal(Java.Time.ZoneOffset arg0)
        {
            return IExecute<Java.Time.OffsetTime>("withOffsetSameLocal", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#withSecond(int)
        /// </summary>
        public Java.Time.OffsetTime WithSecond(int arg0)
        {
            return IExecute<Java.Time.OffsetTime>("withSecond", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#adjustInto(java.time.temporal.Temporal)
        /// </summary>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("adjustInto", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#minus(java.time.temporal.TemporalAmount)
        /// </summary>
        public Java.Time.Temporal.Temporal Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#minus(long,java.time.temporal.TemporalUnit)
        /// </summary>
        public Java.Time.Temporal.Temporal Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#plus(java.time.temporal.TemporalAmount)
        /// </summary>
        public Java.Time.Temporal.Temporal Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#plus(long,java.time.temporal.TemporalUnit)
        /// </summary>
        public Java.Time.Temporal.Temporal Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#with(java.time.temporal.TemporalAdjuster)
        /// </summary>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalAdjuster arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#with(java.time.temporal.TemporalField,long)
        /// </summary>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalField arg0, long arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#range(java.time.temporal.TemporalField)
        /// </summary>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#getLong(java.time.temporal.TemporalField)
        /// </summary>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<long>("getLong", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#toEpochSecond(java.time.LocalDate)
        /// </summary>
        public long ToEpochSecond(Java.Time.LocalDate arg0)
        {
            return IExecute<long>("toEpochSecond", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/OffsetTime.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)
        /// </summary>
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