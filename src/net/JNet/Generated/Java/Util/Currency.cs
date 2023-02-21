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

namespace Java.Util
{
    #region Currency
    public partial class Currency
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Serializable(Java.Util.Currency t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getInstance(java.lang.String)
        /// </summary>
        public static Java.Util.Currency GetInstance(string arg0)
        {
            return SExecute<Java.Util.Currency>("getInstance", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getInstance(java.util.Locale)
        /// </summary>
        public static Java.Util.Currency GetInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Util.Currency>("getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getCurrencyCode() 
        /// </summary>
        public string CurrencyCode
        {
            get { return IExecute<string>("getCurrencyCode"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getDefaultFractionDigits() 
        /// </summary>
        public int DefaultFractionDigits
        {
            get { return IExecute<int>("getDefaultFractionDigits"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getDisplayName() 
        /// </summary>
        public string DisplayName
        {
            get { return IExecute<string>("getDisplayName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getNumericCode() 
        /// </summary>
        public int NumericCode
        {
            get { return IExecute<int>("getNumericCode"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getNumericCodeAsString() 
        /// </summary>
        public string NumericCodeAsString
        {
            get { return IExecute<string>("getNumericCodeAsString"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getSymbol() 
        /// </summary>
        public string Symbol
        {
            get { return IExecute<string>("getSymbol"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getDisplayName(java.util.Locale)
        /// </summary>
        public string GetDisplayName(Java.Util.Locale arg0)
        {
            return IExecute<string>("getDisplayName", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Currency.html#getSymbol(java.util.Locale)
        /// </summary>
        public string GetSymbol(Java.Util.Locale arg0)
        {
            return IExecute<string>("getSymbol", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}