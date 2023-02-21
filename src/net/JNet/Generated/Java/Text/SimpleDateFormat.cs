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

namespace Java.Text
{
    #region SimpleDateFormat
    public partial class SimpleDateFormat
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#<init>(java.lang.String,java.text.DateFormatSymbols)
        /// </summary>
        public SimpleDateFormat(string arg0, Java.Text.DateFormatSymbols arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#<init>(java.lang.String,java.util.Locale)
        /// </summary>
        public SimpleDateFormat(string arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#<init>(java.lang.String)
        /// </summary>
        public SimpleDateFormat(string arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#getDateFormatSymbols() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#setDateFormatSymbols(java.text.DateFormatSymbols)
        /// </summary>
        public Java.Text.DateFormatSymbols DateFormatSymbols
        {
            get { return IExecute<Java.Text.DateFormatSymbols>("getDateFormatSymbols"); } set { IExecute("setDateFormatSymbols", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#toLocalizedPattern()
        /// </summary>
        public string ToLocalizedPattern()
        {
            return IExecute<string>("toLocalizedPattern");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#toPattern()
        /// </summary>
        public string ToPattern()
        {
            return IExecute<string>("toPattern");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#get2DigitYearStart()
        /// </summary>
        public Java.Util.Date Get2DigitYearStart()
        {
            return IExecute<Java.Util.Date>("get2DigitYearStart");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#applyLocalizedPattern(java.lang.String)
        /// </summary>
        public void ApplyLocalizedPattern(string arg0)
        {
            IExecute("applyLocalizedPattern", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#applyPattern(java.lang.String)
        /// </summary>
        public void ApplyPattern(string arg0)
        {
            IExecute("applyPattern", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/SimpleDateFormat.html#set2DigitYearStart(java.util.Date)
        /// </summary>
        public void Set2DigitYearStart(Java.Util.Date arg0)
        {
            IExecute("set2DigitYearStart", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}