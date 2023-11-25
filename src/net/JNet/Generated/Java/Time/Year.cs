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
    #region Year
    public partial class Year
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Year"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.Year t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Year"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.Year t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Year"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Time.Year t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Year"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Year t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#MAX_VALUE"/>
        /// </summary>
        public static int MAX_VALUE { get { return SGetField<int>(LocalBridgeClazz, "MAX_VALUE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#MIN_VALUE"/>
        /// </summary>
        public static int MIN_VALUE { get { return SGetField<int>(LocalBridgeClazz, "MIN_VALUE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#isLeap(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLeap(long arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isLeap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Year"/></returns>
        public static Java.Time.Year From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecute<Java.Time.Year>(LocalBridgeClazz, "from", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#now()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Year"/></returns>
        public static Java.Time.Year Now()
        {
            return SExecute<Java.Time.Year>(LocalBridgeClazz, "now");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.Year"/></returns>
        public static Java.Time.Year Now(Java.Time.Clock arg0)
        {
            return SExecute<Java.Time.Year>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Year"/></returns>
        public static Java.Time.Year Now(Java.Time.ZoneId arg0)
        {
            return SExecute<Java.Time.Year>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Year"/></returns>
        public static Java.Time.Year Of(int arg0)
        {
            return SExecute<Java.Time.Year>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.Year"/></returns>
        public static Java.Time.Year Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.Year>(LocalBridgeClazz, "parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.Year"/></returns>
        public static Java.Time.Year Parse(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Time.Year>(LocalBridgeClazz, "parse", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#getValue()"/> 
        /// </summary>
        public int Value
        {
            get { return IExecute<int>("getValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecute<R>("query", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#isAfter(java.time.Year)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Year"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfter(Java.Time.Year arg0)
        {
            return IExecute<bool>("isAfter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#isBefore(java.time.Year)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Year"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBefore(Java.Time.Year arg0)
        {
            return IExecute<bool>("isBefore", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#isLeap()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLeap()
        {
            return IExecute<bool>("isLeap");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#isValidMonthDay(java.time.MonthDay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.MonthDay"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidMonthDay(Java.Time.MonthDay arg0)
        {
            return IExecute<bool>("isValidMonthDay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#compareTo(java.time.Year)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Year"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Year arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#length()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecute<int>("length");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="string"/></returns>
        public string Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#atDay(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate AtDay(int arg0)
        {
            return IExecute<Java.Time.LocalDate>("atDay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#atMonthDay(java.time.MonthDay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.MonthDay"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate AtMonthDay(Java.Time.MonthDay arg0)
        {
            return IExecute<Java.Time.LocalDate>("atMonthDay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("adjustInto", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#minus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#minus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#plus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#plus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#with(java.time.temporal.TemporalAdjuster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAdjuster"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalAdjuster arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#with(java.time.temporal.TemporalField,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalField arg0, long arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#minusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Year"/></returns>
        public Java.Time.Year MinusYears(long arg0)
        {
            return IExecute<Java.Time.Year>("minusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#plusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Year"/></returns>
        public Java.Time.Year PlusYears(long arg0)
        {
            return IExecute<Java.Time.Year>("plusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#atMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.YearMonth"/></returns>
        public Java.Time.YearMonth AtMonth(int arg0)
        {
            return IExecute<Java.Time.YearMonth>("atMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#atMonth(java.time.Month)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Month"/></param>
        /// <returns><see cref="Java.Time.YearMonth"/></returns>
        public Java.Time.YearMonth AtMonth(Java.Time.Month arg0)
        {
            return IExecute<Java.Time.YearMonth>("atMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<long>("getLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Year.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
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