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

namespace Java.Time
{
    #region DayOfWeek
    public partial class DayOfWeek
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.DayOfWeek"/> to <see cref="Java.Time.Temporal.TemporalAccessor"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAccessor(Java.Time.DayOfWeek t) => t.Cast<Java.Time.Temporal.TemporalAccessor>();
        /// <summary>
        /// Converter from <see cref="Java.Time.DayOfWeek"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.DayOfWeek t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#FRIDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek FRIDAY => Clazz.GetField<Java.Time.DayOfWeek>("FRIDAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#MONDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek MONDAY => Clazz.GetField<Java.Time.DayOfWeek>("MONDAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#SATURDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek SATURDAY => Clazz.GetField<Java.Time.DayOfWeek>("SATURDAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#SUNDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek SUNDAY => Clazz.GetField<Java.Time.DayOfWeek>("SUNDAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#THURSDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek THURSDAY => Clazz.GetField<Java.Time.DayOfWeek>("THURSDAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#TUESDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek TUESDAY => Clazz.GetField<Java.Time.DayOfWeek>("TUESDAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#WEDNESDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek WEDNESDAY => Clazz.GetField<Java.Time.DayOfWeek>("WEDNESDAY");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#values()"/> 
        /// </summary>
        public static Java.Time.DayOfWeek[] Values
        {
            get { return SExecuteArray<Java.Time.DayOfWeek>(LocalClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public static Java.Time.DayOfWeek From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecute<Java.Time.DayOfWeek>(LocalClazz, "from", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public static Java.Time.DayOfWeek Of(int arg0)
        {
            return SExecute<Java.Time.DayOfWeek>(LocalClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public static Java.Time.DayOfWeek ValueOf(string arg0)
        {
            return SExecute<Java.Time.DayOfWeek>(LocalClazz, "valueOf", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#getValue()"/> 
        /// </summary>
        public int Value
        {
            get { return IExecute<int>("getValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <returns><see cref="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecute<R>("query", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#minus(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public Java.Time.DayOfWeek Minus(long arg0)
        {
            return IExecute<Java.Time.DayOfWeek>("minus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#plus(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public Java.Time.DayOfWeek Plus(long arg0)
        {
            return IExecute<Java.Time.DayOfWeek>("plus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("adjustInto", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/DayOfWeek.html#getLong(java.time.temporal.TemporalField)"/>
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