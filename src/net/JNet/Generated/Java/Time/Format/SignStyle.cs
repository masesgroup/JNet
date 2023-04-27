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
    #region SignStyle
    public partial class SignStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#ALWAYS"/>
        /// </summary>
        public static Java.Time.Format.SignStyle ALWAYS { get { return LocalClazz.GetField<Java.Time.Format.SignStyle>("ALWAYS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#EXCEEDS_PAD"/>
        /// </summary>
        public static Java.Time.Format.SignStyle EXCEEDS_PAD { get { return LocalClazz.GetField<Java.Time.Format.SignStyle>("EXCEEDS_PAD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#NEVER"/>
        /// </summary>
        public static Java.Time.Format.SignStyle NEVER { get { return LocalClazz.GetField<Java.Time.Format.SignStyle>("NEVER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#NORMAL"/>
        /// </summary>
        public static Java.Time.Format.SignStyle NORMAL { get { return LocalClazz.GetField<Java.Time.Format.SignStyle>("NORMAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#NOT_NEGATIVE"/>
        /// </summary>
        public static Java.Time.Format.SignStyle NOT_NEGATIVE { get { return LocalClazz.GetField<Java.Time.Format.SignStyle>("NOT_NEGATIVE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#values()"/> 
        /// </summary>
        public static Java.Time.Format.SignStyle[] Values
        {
            get { return SExecuteArray<Java.Time.Format.SignStyle>(LocalClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.Format.SignStyle"/></returns>
        public static Java.Time.Format.SignStyle ValueOf(string arg0)
        {
            return SExecute<Java.Time.Format.SignStyle>(LocalClazz, "valueOf", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}