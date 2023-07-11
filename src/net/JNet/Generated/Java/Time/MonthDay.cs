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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region MonthDay
    public partial class MonthDay
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.MonthDay"/> to <see cref="Java.Time.Temporal.TemporalAccessor"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAccessor(Java.Time.MonthDay t) => t.Cast<Java.Time.Temporal.TemporalAccessor>();
        /// <summary>
        /// Converter from <see cref="Java.Time.MonthDay"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.MonthDay t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.MonthDay"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Time.MonthDay t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Time.MonthDay"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.MonthDay t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "from", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#now()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Now()
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "now");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Now(Java.Time.Clock arg0)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Now(Java.Time.ZoneId arg0)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#of(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Of(int arg0, int arg1)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#of(java.time.Month,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Month"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Of(Java.Time.Month arg0, int arg1)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Parse(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "parse", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#getDayOfMonth()"/> 
        /// </summary>
        public int DayOfMonth
        {
            get { return IExecute<int>("getDayOfMonth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#getMonth()"/> 
        /// </summary>
        public Java.Time.Month Month
        {
            get { return IExecute<Java.Time.Month>("getMonth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#getMonthValue()"/> 
        /// </summary>
        public int MonthValue
        {
            get { return IExecute<int>("getMonthValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecute<R>("query", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#isAfter(java.time.MonthDay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.MonthDay"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfter(Java.Time.MonthDay arg0)
        {
            return IExecute<bool>("isAfter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#isBefore(java.time.MonthDay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.MonthDay"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBefore(Java.Time.MonthDay arg0)
        {
            return IExecute<bool>("isBefore", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#isValidYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidYear(int arg0)
        {
            return IExecute<bool>("isValidYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#compareTo(java.time.MonthDay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.MonthDay"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.MonthDay arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="string"/></returns>
        public string Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#atYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate AtYear(int arg0)
        {
            return IExecute<Java.Time.LocalDate>("atYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#with(java.time.Month)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Month"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public Java.Time.MonthDay With(Java.Time.Month arg0)
        {
            return IExecute<Java.Time.MonthDay>("with", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#withDayOfMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public Java.Time.MonthDay WithDayOfMonth(int arg0)
        {
            return IExecute<Java.Time.MonthDay>("withDayOfMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#withMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public Java.Time.MonthDay WithMonth(int arg0)
        {
            return IExecute<Java.Time.MonthDay>("withMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("adjustInto", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/MonthDay.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<long>("getLong", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}