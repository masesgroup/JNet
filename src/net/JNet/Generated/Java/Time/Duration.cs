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
    #region Duration
    public partial class Duration
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Time.Temporal.TemporalAmount(Java.Time.Duration t) => t.Cast<Java.Time.Temporal.TemporalAmount>();
        public static implicit operator Java.Io.Serializable(Java.Time.Duration t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#ZERO
        /// </summary>
        public static Java.Time.Duration ZERO => Clazz.GetField<Java.Time.Duration>("ZERO");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#between(java.time.temporal.Temporal,java.time.temporal.Temporal)
        /// </summary>
        public static Java.Time.Duration Between(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.Temporal arg1)
        {
            return SExecute<Java.Time.Duration>("between", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#from(java.time.temporal.TemporalAmount)
        /// </summary>
        public static Java.Time.Duration From(Java.Time.Temporal.TemporalAmount arg0)
        {
            return SExecute<Java.Time.Duration>("from", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#of(long,java.time.temporal.TemporalUnit)
        /// </summary>
        public static Java.Time.Duration Of(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return SExecute<Java.Time.Duration>("of", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#ofDays(long)
        /// </summary>
        public static Java.Time.Duration OfDays(long arg0)
        {
            return SExecute<Java.Time.Duration>("ofDays", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#ofHours(long)
        /// </summary>
        public static Java.Time.Duration OfHours(long arg0)
        {
            return SExecute<Java.Time.Duration>("ofHours", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#ofMillis(long)
        /// </summary>
        public static Java.Time.Duration OfMillis(long arg0)
        {
            return SExecute<Java.Time.Duration>("ofMillis", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#ofMinutes(long)
        /// </summary>
        public static Java.Time.Duration OfMinutes(long arg0)
        {
            return SExecute<Java.Time.Duration>("ofMinutes", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#ofNanos(long)
        /// </summary>
        public static Java.Time.Duration OfNanos(long arg0)
        {
            return SExecute<Java.Time.Duration>("ofNanos", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#ofSeconds(long,long)
        /// </summary>
        public static Java.Time.Duration OfSeconds(long arg0, long arg1)
        {
            return SExecute<Java.Time.Duration>("ofSeconds", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#ofSeconds(long)
        /// </summary>
        public static Java.Time.Duration OfSeconds(long arg0)
        {
            return SExecute<Java.Time.Duration>("ofSeconds", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#parse(java.lang.CharSequence)
        /// </summary>
        public static Java.Time.Duration Parse(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Time.Duration>("parse", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#getNano() 
        /// </summary>
        public int Nano
        {
            get { return IExecute<int>("getNano"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#getSeconds() 
        /// </summary>
        public long Seconds
        {
            get { return IExecute<long>("getSeconds"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#isNegative()
        /// </summary>
        public bool IsNegative()
        {
            return IExecute<bool>("isNegative");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#isZero()
        /// </summary>
        public bool IsZero()
        {
            return IExecute<bool>("isZero");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#compareTo(java.lang.Object)
        /// </summary>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#compareTo(java.time.Duration)
        /// </summary>
        public int CompareTo(Java.Time.Duration arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toHoursPart()
        /// </summary>
        public int ToHoursPart()
        {
            return IExecute<int>("toHoursPart");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toMillisPart()
        /// </summary>
        public int ToMillisPart()
        {
            return IExecute<int>("toMillisPart");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toMinutesPart()
        /// </summary>
        public int ToMinutesPart()
        {
            return IExecute<int>("toMinutesPart");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toNanosPart()
        /// </summary>
        public int ToNanosPart()
        {
            return IExecute<int>("toNanosPart");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toSecondsPart()
        /// </summary>
        public int ToSecondsPart()
        {
            return IExecute<int>("toSecondsPart");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#abs()
        /// </summary>
        public Java.Time.Duration Abs()
        {
            return IExecute<Java.Time.Duration>("abs");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#dividedBy(long)
        /// </summary>
        public Java.Time.Duration DividedBy(long arg0)
        {
            return IExecute<Java.Time.Duration>("dividedBy", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#minus(java.time.Duration)
        /// </summary>
        public Java.Time.Duration Minus(Java.Time.Duration arg0)
        {
            return IExecute<Java.Time.Duration>("minus", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#minus(long,java.time.temporal.TemporalUnit)
        /// </summary>
        public Java.Time.Duration Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Duration>("minus", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#minusDays(long)
        /// </summary>
        public Java.Time.Duration MinusDays(long arg0)
        {
            return IExecute<Java.Time.Duration>("minusDays", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#minusHours(long)
        /// </summary>
        public Java.Time.Duration MinusHours(long arg0)
        {
            return IExecute<Java.Time.Duration>("minusHours", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#minusMillis(long)
        /// </summary>
        public Java.Time.Duration MinusMillis(long arg0)
        {
            return IExecute<Java.Time.Duration>("minusMillis", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#minusMinutes(long)
        /// </summary>
        public Java.Time.Duration MinusMinutes(long arg0)
        {
            return IExecute<Java.Time.Duration>("minusMinutes", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#minusNanos(long)
        /// </summary>
        public Java.Time.Duration MinusNanos(long arg0)
        {
            return IExecute<Java.Time.Duration>("minusNanos", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#minusSeconds(long)
        /// </summary>
        public Java.Time.Duration MinusSeconds(long arg0)
        {
            return IExecute<Java.Time.Duration>("minusSeconds", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#multipliedBy(long)
        /// </summary>
        public Java.Time.Duration MultipliedBy(long arg0)
        {
            return IExecute<Java.Time.Duration>("multipliedBy", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#negated()
        /// </summary>
        public Java.Time.Duration Negated()
        {
            return IExecute<Java.Time.Duration>("negated");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#plus(java.time.Duration)
        /// </summary>
        public Java.Time.Duration Plus(Java.Time.Duration arg0)
        {
            return IExecute<Java.Time.Duration>("plus", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#plus(long,java.time.temporal.TemporalUnit)
        /// </summary>
        public Java.Time.Duration Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Duration>("plus", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#plusDays(long)
        /// </summary>
        public Java.Time.Duration PlusDays(long arg0)
        {
            return IExecute<Java.Time.Duration>("plusDays", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#plusHours(long)
        /// </summary>
        public Java.Time.Duration PlusHours(long arg0)
        {
            return IExecute<Java.Time.Duration>("plusHours", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#plusMillis(long)
        /// </summary>
        public Java.Time.Duration PlusMillis(long arg0)
        {
            return IExecute<Java.Time.Duration>("plusMillis", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#plusMinutes(long)
        /// </summary>
        public Java.Time.Duration PlusMinutes(long arg0)
        {
            return IExecute<Java.Time.Duration>("plusMinutes", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#plusNanos(long)
        /// </summary>
        public Java.Time.Duration PlusNanos(long arg0)
        {
            return IExecute<Java.Time.Duration>("plusNanos", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#plusSeconds(long)
        /// </summary>
        public Java.Time.Duration PlusSeconds(long arg0)
        {
            return IExecute<Java.Time.Duration>("plusSeconds", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#truncatedTo(java.time.temporal.TemporalUnit)
        /// </summary>
        public Java.Time.Duration TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<Java.Time.Duration>("truncatedTo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#withNanos(int)
        /// </summary>
        public Java.Time.Duration WithNanos(int arg0)
        {
            return IExecute<Java.Time.Duration>("withNanos", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#withSeconds(long)
        /// </summary>
        public Java.Time.Duration WithSeconds(long arg0)
        {
            return IExecute<Java.Time.Duration>("withSeconds", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#addTo(java.time.temporal.Temporal)
        /// </summary>
        public Java.Time.Temporal.Temporal AddTo(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("addTo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#subtractFrom(java.time.temporal.Temporal)
        /// </summary>
        public Java.Time.Temporal.Temporal SubtractFrom(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("subtractFrom", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#dividedBy(java.time.Duration)
        /// </summary>
        public long DividedBy(Java.Time.Duration arg0)
        {
            return IExecute<long>("dividedBy", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#get(java.time.temporal.TemporalUnit)
        /// </summary>
        public long Get(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<long>("get", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toDays()
        /// </summary>
        public long ToDays()
        {
            return IExecute<long>("toDays");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toDaysPart()
        /// </summary>
        public long ToDaysPart()
        {
            return IExecute<long>("toDaysPart");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toHours()
        /// </summary>
        public long ToHours()
        {
            return IExecute<long>("toHours");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toMillis()
        /// </summary>
        public long ToMillis()
        {
            return IExecute<long>("toMillis");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toMinutes()
        /// </summary>
        public long ToMinutes()
        {
            return IExecute<long>("toMinutes");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toNanos()
        /// </summary>
        public long ToNanos()
        {
            return IExecute<long>("toNanos");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Duration.html#toSeconds()
        /// </summary>
        public long ToSeconds()
        {
            return IExecute<long>("toSeconds");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}