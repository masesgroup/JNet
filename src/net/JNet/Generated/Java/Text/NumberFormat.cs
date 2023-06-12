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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Text
{
    #region NumberFormat
    public partial class NumberFormat
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#FRACTION_FIELD"/>
        /// </summary>
        public static int FRACTION_FIELD { get { return SGetField<int>(LocalBridgeClazz, "FRACTION_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#INTEGER_FIELD"/>
        /// </summary>
        public static int INTEGER_FIELD { get { return SGetField<int>(LocalBridgeClazz, "INTEGER_FIELD"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getCurrencyInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat CurrencyInstance
        {
            get { return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getCurrencyInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat Instance
        {
            get { return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getIntegerInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat IntegerInstance
        {
            get { return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getIntegerInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getNumberInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat NumberInstance
        {
            get { return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getNumberInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getPercentInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat PercentInstance
        {
            get { return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getPercentInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getCurrencyInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetCurrencyInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getCurrencyInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getIntegerInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetIntegerInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getIntegerInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getNumberInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetNumberInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getNumberInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getPercentInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetPercentInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.NumberFormat>(LocalBridgeClazz, "getPercentInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getCurrency()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setCurrency(java.util.Currency)"/>
        /// </summary>
        public Java.Util.Currency Currency
        {
            get { return IExecute<Java.Util.Currency>("getCurrency"); } set { IExecute("setCurrency", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getMaximumFractionDigits()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setMaximumFractionDigits(int)"/>
        /// </summary>
        public int MaximumFractionDigits
        {
            get { return IExecute<int>("getMaximumFractionDigits"); } set { IExecute("setMaximumFractionDigits", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getMaximumIntegerDigits()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setMaximumIntegerDigits(int)"/>
        /// </summary>
        public int MaximumIntegerDigits
        {
            get { return IExecute<int>("getMaximumIntegerDigits"); } set { IExecute("setMaximumIntegerDigits", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getMinimumFractionDigits()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setMinimumFractionDigits(int)"/>
        /// </summary>
        public int MinimumFractionDigits
        {
            get { return IExecute<int>("getMinimumFractionDigits"); } set { IExecute("setMinimumFractionDigits", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getMinimumIntegerDigits()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setMinimumIntegerDigits(int)"/>
        /// </summary>
        public int MinimumIntegerDigits
        {
            get { return IExecute<int>("getMinimumIntegerDigits"); } set { IExecute("setMinimumIntegerDigits", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getRoundingMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setRoundingMode(java.math.RoundingMode)"/>
        /// </summary>
        public Java.Math.RoundingMode RoundingMode
        {
            get { return IExecute<Java.Math.RoundingMode>("getRoundingMode"); } set { IExecute("setRoundingMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#parse(java.lang.String,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number Parse(string arg0, Java.Text.ParsePosition arg1)
        {
            return IExecute<Java.Lang.Number>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#format(double,java.lang.StringBuffer,java.text.FieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Text.FieldPosition"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer Format(double arg0, Java.Lang.StringBuffer arg1, Java.Text.FieldPosition arg2)
        {
            return IExecute<Java.Lang.StringBuffer>("format", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#format(long,java.lang.StringBuffer,java.text.FieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Text.FieldPosition"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer Format(long arg0, Java.Lang.StringBuffer arg1, Java.Text.FieldPosition arg2)
        {
            return IExecute<Java.Lang.StringBuffer>("format", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#isGroupingUsed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsGroupingUsed()
        {
            return IExecute<bool>("isGroupingUsed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#isParseIntegerOnly()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsParseIntegerOnly()
        {
            return IExecute<bool>("isParseIntegerOnly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#format(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="string"/></returns>
        public string Format(double arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#format(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="string"/></returns>
        public string Format(long arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        /// <exception cref="Java.Text.ParseException"/>
        public Java.Lang.Number Parse(string arg0)
        {
            return IExecute<Java.Lang.Number>("parse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setGroupingUsed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetGroupingUsed(bool arg0)
        {
            IExecute("setGroupingUsed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setParseIntegerOnly(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetParseIntegerOnly(bool arg0)
        {
            IExecute("setParseIntegerOnly", arg0);
        }

        #endregion

        #region Nested classes
        #region Field
        public partial class Field
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#CURRENCY"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field CURRENCY { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "CURRENCY"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#DECIMAL_SEPARATOR"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field DECIMAL_SEPARATOR { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "DECIMAL_SEPARATOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#EXPONENT"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field EXPONENT { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "EXPONENT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#EXPONENT_SIGN"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field EXPONENT_SIGN { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "EXPONENT_SIGN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#EXPONENT_SYMBOL"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field EXPONENT_SYMBOL { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "EXPONENT_SYMBOL"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#FRACTION"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field FRACTION { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "FRACTION"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#GROUPING_SEPARATOR"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field GROUPING_SEPARATOR { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "GROUPING_SEPARATOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#INTEGER"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field INTEGER { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "INTEGER"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#PERCENT"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field PERCENT { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "PERCENT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#PERMILLE"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field PERMILLE { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "PERMILLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#SIGN"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field SIGN { get { return SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "SIGN"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}