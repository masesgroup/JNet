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

namespace Java.Time.Format
{
    #region DateTimeFormatter
    public partial class DateTimeFormatter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#BASIC_ISO_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter BASIC_ISO_DATE => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("BASIC_ISO_DATE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_DATE => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_DATE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_DATE_TIME => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_DATE_TIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_INSTANT"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_INSTANT => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_INSTANT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_LOCAL_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_LOCAL_DATE => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_LOCAL_DATE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_LOCAL_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_LOCAL_DATE_TIME => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_LOCAL_DATE_TIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_LOCAL_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_LOCAL_TIME => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_LOCAL_TIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_OFFSET_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_OFFSET_DATE => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_OFFSET_DATE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_OFFSET_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_OFFSET_DATE_TIME => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_OFFSET_DATE_TIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_OFFSET_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_OFFSET_TIME => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_OFFSET_TIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_ORDINAL_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_ORDINAL_DATE => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_ORDINAL_DATE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_TIME => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_TIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_WEEK_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_WEEK_DATE => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_WEEK_DATE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ISO_ZONED_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_ZONED_DATE_TIME => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("ISO_ZONED_DATE_TIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#RFC_1123_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter RFC_1123_DATE_TIME => LocalClazz.GetField<Java.Time.Format.DateTimeFormatter>("RFC_1123_DATE_TIME");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#parsedExcessDays()"/> 
        /// </summary>
        public static Java.Time.Temporal.TemporalQuery<Java.Time.Period> ParsedExcessDays
        {
            get { return SExecute<Java.Time.Temporal.TemporalQuery<Java.Time.Period>>(LocalClazz, "parsedExcessDays"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#parsedLeapSecond()"/> 
        /// </summary>
        public static Java.Time.Temporal.TemporalQuery<bool?> ParsedLeapSecond
        {
            get { return SExecute<Java.Time.Temporal.TemporalQuery<bool?>>(LocalClazz, "parsedLeapSecond"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ofLocalizedDate(java.time.format.FormatStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfLocalizedDate(Java.Time.Format.FormatStyle arg0)
        {
            return SExecute<Java.Time.Format.DateTimeFormatter>(LocalClazz, "ofLocalizedDate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ofLocalizedDateTime(java.time.format.FormatStyle,java.time.format.FormatStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfLocalizedDateTime(Java.Time.Format.FormatStyle arg0, Java.Time.Format.FormatStyle arg1)
        {
            return SExecute<Java.Time.Format.DateTimeFormatter>(LocalClazz, "ofLocalizedDateTime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ofLocalizedDateTime(java.time.format.FormatStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfLocalizedDateTime(Java.Time.Format.FormatStyle arg0)
        {
            return SExecute<Java.Time.Format.DateTimeFormatter>(LocalClazz, "ofLocalizedDateTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ofLocalizedTime(java.time.format.FormatStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfLocalizedTime(Java.Time.Format.FormatStyle arg0)
        {
            return SExecute<Java.Time.Format.DateTimeFormatter>(LocalClazz, "ofLocalizedTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ofPattern(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfPattern(string arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Time.Format.DateTimeFormatter>(LocalClazz, "ofPattern", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#ofPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfPattern(string arg0)
        {
            return SExecute<Java.Time.Format.DateTimeFormatter>(LocalClazz, "ofPattern", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#getChronology()"/> 
        /// </summary>
        public Java.Time.Chrono.Chronology Chronology
        {
            get { return IExecute<Java.Time.Chrono.Chronology>("getChronology"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#getDecimalStyle()"/> 
        /// </summary>
        public Java.Time.Format.DecimalStyle DecimalStyle
        {
            get { return IExecute<Java.Time.Format.DecimalStyle>("getDecimalStyle"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecute<Java.Util.Locale>("getLocale"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#getResolverFields()"/> 
        /// </summary>
        public Java.Util.Set<Java.Time.Temporal.TemporalField> ResolverFields
        {
            get { return IExecute<Java.Util.Set<Java.Time.Temporal.TemporalField>>("getResolverFields"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#getResolverStyle()"/> 
        /// </summary>
        public Java.Time.Format.ResolverStyle ResolverStyle
        {
            get { return IExecute<Java.Time.Format.ResolverStyle>("getResolverStyle"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#getZone()"/> 
        /// </summary>
        public Java.Time.ZoneId Zone
        {
            get { return IExecute<Java.Time.ZoneId>("getZone"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#parse(java.lang.CharSequence,java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <returns><see cref="T"/></returns>
        public T Parse<T>(Java.Lang.CharSequence arg0, Java.Time.Temporal.TemporalQuery<T> arg1)
        {
            return IExecute<T>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#format(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="string"/></returns>
        public string Format(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#toFormat()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Text.Format"/></returns>
        public Java.Text.Format ToFormat()
        {
            return IExecute<Java.Text.Format>("toFormat");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#toFormat(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <returns><see cref="Java.Text.Format"/></returns>
        public Java.Text.Format ToFormat<Arg0Extendsobject>(Java.Time.Temporal.TemporalQuery<Arg0Extendsobject> arg0)
        {
            return IExecute<Java.Text.Format>("toFormat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#localizedBy(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter LocalizedBy(Java.Util.Locale arg0)
        {
            return IExecute<Java.Time.Format.DateTimeFormatter>("localizedBy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#withChronology(java.time.chrono.Chronology)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Chronology"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithChronology(Java.Time.Chrono.Chronology arg0)
        {
            return IExecute<Java.Time.Format.DateTimeFormatter>("withChronology", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#withDecimalStyle(java.time.format.DecimalStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DecimalStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithDecimalStyle(Java.Time.Format.DecimalStyle arg0)
        {
            return IExecute<Java.Time.Format.DateTimeFormatter>("withDecimalStyle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#withLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithLocale(Java.Util.Locale arg0)
        {
            return IExecute<Java.Time.Format.DateTimeFormatter>("withLocale", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#withResolverFields(java.time.temporal.TemporalField[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithResolverFields(params Java.Time.Temporal.TemporalField[] arg0)
        {
            if (arg0.Length == 0) return IExecute<Java.Time.Format.DateTimeFormatter>("withResolverFields", new object[] { arg0 }); else return IExecute<Java.Time.Format.DateTimeFormatter>("withResolverFields", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#withResolverFields(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithResolverFields(Java.Util.Set<Java.Time.Temporal.TemporalField> arg0)
        {
            return IExecute<Java.Time.Format.DateTimeFormatter>("withResolverFields", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#withResolverStyle(java.time.format.ResolverStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.ResolverStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithResolverStyle(Java.Time.Format.ResolverStyle arg0)
        {
            return IExecute<Java.Time.Format.DateTimeFormatter>("withResolverStyle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#withZone(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithZone(Java.Time.ZoneId arg0)
        {
            return IExecute<Java.Time.Format.DateTimeFormatter>("withZone", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#parse(java.lang.CharSequence,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        public Java.Time.Temporal.TemporalAccessor Parse(Java.Lang.CharSequence arg0, Java.Text.ParsePosition arg1)
        {
            return IExecute<Java.Time.Temporal.TemporalAccessor>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        public Java.Time.Temporal.TemporalAccessor Parse(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Time.Temporal.TemporalAccessor>("parse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#parseBest(java.lang.CharSequence,java.time.temporal.TemporalQuery[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        public Java.Time.Temporal.TemporalAccessor ParseBest<Arg1Extendsobject>(Java.Lang.CharSequence arg0, params Java.Time.Temporal.TemporalQuery<Arg1Extendsobject>[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Time.Temporal.TemporalAccessor>("parseBest", arg0); else return IExecute<Java.Time.Temporal.TemporalAccessor>("parseBest", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#parseUnresolved(java.lang.CharSequence,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        public Java.Time.Temporal.TemporalAccessor ParseUnresolved(Java.Lang.CharSequence arg0, Java.Text.ParsePosition arg1)
        {
            return IExecute<Java.Time.Temporal.TemporalAccessor>("parseUnresolved", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DateTimeFormatter.html#formatTo(java.time.temporal.TemporalAccessor,java.lang.Appendable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Appendable"/></param>
        public void FormatTo(Java.Time.Temporal.TemporalAccessor arg0, Java.Lang.Appendable arg1)
        {
            IExecute("formatTo", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}