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

namespace Java.Util.Spi
{
    #region LocaleNameProvider
    public partial class LocaleNameProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/LocaleNameProvider.html#getDisplayCountry(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayCountry(string arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getDisplayCountry", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/LocaleNameProvider.html#getDisplayLanguage(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayLanguage(string arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getDisplayLanguage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/LocaleNameProvider.html#getDisplayVariant(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayVariant(string arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getDisplayVariant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/LocaleNameProvider.html#getDisplayScript(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayScript(string arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getDisplayScript", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/LocaleNameProvider.html#getDisplayUnicodeExtensionKey(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayUnicodeExtensionKey(string arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getDisplayUnicodeExtensionKey", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/LocaleNameProvider.html#getDisplayUnicodeExtensionType(java.lang.String,java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayUnicodeExtensionType(string arg0, string arg1, Java.Util.Locale arg2)
        {
            return IExecute<string>("getDisplayUnicodeExtensionType", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}