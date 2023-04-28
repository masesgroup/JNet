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
    #region Collator
    public partial class Collator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Text.Collator"/> to <see cref="Java.Util.Comparator"/>
        /// </summary>
        public static implicit operator Java.Util.Comparator(Java.Text.Collator t) => t.Cast<Java.Util.Comparator>();
        /// <summary>
        /// Converter from <see cref="Java.Text.Collator"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Text.Collator t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#CANONICAL_DECOMPOSITION"/>
        /// </summary>
        public static int CANONICAL_DECOMPOSITION { get { return SGetField<int>(LocalClazz, "CANONICAL_DECOMPOSITION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#FULL_DECOMPOSITION"/>
        /// </summary>
        public static int FULL_DECOMPOSITION { get { return SGetField<int>(LocalClazz, "FULL_DECOMPOSITION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#IDENTICAL"/>
        /// </summary>
        public static int IDENTICAL { get { return SGetField<int>(LocalClazz, "IDENTICAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#NO_DECOMPOSITION"/>
        /// </summary>
        public static int NO_DECOMPOSITION { get { return SGetField<int>(LocalClazz, "NO_DECOMPOSITION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#PRIMARY"/>
        /// </summary>
        public static int PRIMARY { get { return SGetField<int>(LocalClazz, "PRIMARY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#SECONDARY"/>
        /// </summary>
        public static int SECONDARY { get { return SGetField<int>(LocalClazz, "SECONDARY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#TERTIARY"/>
        /// </summary>
        public static int TERTIARY { get { return SGetField<int>(LocalClazz, "TERTIARY"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteArray<Java.Util.Locale>(LocalClazz, "getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.Collator"/></returns>
        public static Java.Text.Collator GetInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.Collator>(LocalClazz, "getInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getInstance()"/>
        /// </summary>

        /// <returns><see cref="Java.Text.Collator"/></returns>
        public static Java.Text.Collator GetInstance()
        {
            return SExecute<Java.Text.Collator>(LocalClazz, "getInstance");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getDecomposition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#setDecomposition(int)"/>
        /// </summary>
        public int Decomposition
        {
            get { return IExecute<int>("getDecomposition"); } set { IExecute("setDecomposition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getStrength()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#setStrength(int)"/>
        /// </summary>
        public int Strength
        {
            get { return IExecute<int>("getStrength"); } set { IExecute("setStrength", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#compare(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(string arg0, string arg1)
        {
            return IExecute<int>("compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#getCollationKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Text.CollationKey"/></returns>
        public Java.Text.CollationKey GetCollationKey(string arg0)
        {
            return IExecute<Java.Text.CollationKey>("getCollationKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#equals(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Equals(string arg0, string arg1)
        {
            return IExecute<bool>("equals", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Collator.html#compare(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(object arg0, object arg1)
        {
            return IExecute<int>("compare", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}