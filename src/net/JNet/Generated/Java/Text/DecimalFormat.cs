/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Text
{
    #region DecimalFormat
    public partial class DecimalFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#%3Cinit%3E(java.lang.String,java.text.DecimalFormatSymbols)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Text.DecimalFormatSymbols"/></param>
        public DecimalFormat(string arg0, Java.Text.DecimalFormatSymbols arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public DecimalFormat(string arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getDecimalFormatSymbols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setDecimalFormatSymbols(java.text.DecimalFormatSymbols)"/>
        /// </summary>
        public Java.Text.DecimalFormatSymbols DecimalFormatSymbols
        {
            get { return IExecute<Java.Text.DecimalFormatSymbols>("getDecimalFormatSymbols"); } set { IExecute("setDecimalFormatSymbols", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getGroupingSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setGroupingSize(int)"/>
        /// </summary>
        public int GroupingSize
        {
            get { return IExecute<int>("getGroupingSize"); } set { IExecute("setGroupingSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getMultiplier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setMultiplier(int)"/>
        /// </summary>
        public int Multiplier
        {
            get { return IExecute<int>("getMultiplier"); } set { IExecute("setMultiplier", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getNegativePrefix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setNegativePrefix(java.lang.String)"/>
        /// </summary>
        public string NegativePrefix
        {
            get { return IExecute<string>("getNegativePrefix"); } set { IExecute("setNegativePrefix", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getNegativeSuffix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setNegativeSuffix(java.lang.String)"/>
        /// </summary>
        public string NegativeSuffix
        {
            get { return IExecute<string>("getNegativeSuffix"); } set { IExecute("setNegativeSuffix", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getPositivePrefix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setPositivePrefix(java.lang.String)"/>
        /// </summary>
        public string PositivePrefix
        {
            get { return IExecute<string>("getPositivePrefix"); } set { IExecute("setPositivePrefix", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getPositiveSuffix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setPositiveSuffix(java.lang.String)"/>
        /// </summary>
        public string PositiveSuffix
        {
            get { return IExecute<string>("getPositiveSuffix"); } set { IExecute("setPositiveSuffix", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#isDecimalSeparatorAlwaysShown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDecimalSeparatorAlwaysShown()
        {
            return IExecute<bool>("isDecimalSeparatorAlwaysShown");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#isParseBigDecimal()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsParseBigDecimal()
        {
            return IExecute<bool>("isParseBigDecimal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#toLocalizedPattern()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ToLocalizedPattern()
        {
            return IExecute<string>("toLocalizedPattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#toPattern()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ToPattern()
        {
            return IExecute<string>("toPattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#applyLocalizedPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void ApplyLocalizedPattern(string arg0)
        {
            IExecute("applyLocalizedPattern", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#applyPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void ApplyPattern(string arg0)
        {
            IExecute("applyPattern", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setDecimalSeparatorAlwaysShown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDecimalSeparatorAlwaysShown(bool arg0)
        {
            IExecute("setDecimalSeparatorAlwaysShown", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setParseBigDecimal(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetParseBigDecimal(bool arg0)
        {
            IExecute("setParseBigDecimal", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}