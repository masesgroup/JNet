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

namespace Java.Text
{
    #region DateFormatSymbols
    public partial class DateFormatSymbols
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public DateFormatSymbols(Java.Util.Locale arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Text.DateFormatSymbols"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Text.DateFormatSymbols t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Text.DateFormatSymbols"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Text.DateFormatSymbols t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteArray<Java.Util.Locale>(LocalClazz, "getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getInstance()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Text.DateFormatSymbols"/></returns>
        public static Java.Text.DateFormatSymbols GetInstance()
        {
            return SExecute<Java.Text.DateFormatSymbols>(LocalClazz, "getInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.DateFormatSymbols"/></returns>
        public static Java.Text.DateFormatSymbols GetInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.DateFormatSymbols>(LocalClazz, "getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getAmPmStrings()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setAmPmStrings(java.lang.String[])"/>
        /// </summary>
        public string[] AmPmStrings
        {
            get { return IExecuteArray<string>("getAmPmStrings"); } set { IExecute("setAmPmStrings", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getEras()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setEras(java.lang.String[])"/>
        /// </summary>
        public string[] Eras
        {
            get { return IExecuteArray<string>("getEras"); } set { IExecute("setEras", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getLocalPatternChars()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setLocalPatternChars(java.lang.String)"/>
        /// </summary>
        public string LocalPatternChars
        {
            get { return IExecute<string>("getLocalPatternChars"); } set { IExecute("setLocalPatternChars", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getMonths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setMonths(java.lang.String[])"/>
        /// </summary>
        public string[] Months
        {
            get { return IExecuteArray<string>("getMonths"); } set { IExecute("setMonths", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getShortMonths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setShortMonths(java.lang.String[])"/>
        /// </summary>
        public string[] ShortMonths
        {
            get { return IExecuteArray<string>("getShortMonths"); } set { IExecute("setShortMonths", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getShortWeekdays()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setShortWeekdays(java.lang.String[])"/>
        /// </summary>
        public string[] ShortWeekdays
        {
            get { return IExecuteArray<string>("getShortWeekdays"); } set { IExecute("setShortWeekdays", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getWeekdays()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setWeekdays(java.lang.String[])"/>
        /// </summary>
        public string[] Weekdays
        {
            get { return IExecuteArray<string>("getWeekdays"); } set { IExecute("setWeekdays", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getZoneStrings()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setZoneStrings(java.lang.String[][])"/>
        /// </summary>
        public string[] ZoneStrings
        {
            get { return IExecuteArray<string>("getZoneStrings"); } set { IExecute("setZoneStrings", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}