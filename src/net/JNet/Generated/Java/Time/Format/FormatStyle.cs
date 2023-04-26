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
    #region FormatStyle
    public partial class FormatStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#FULL"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle FULL => LocalClazz.GetField<Java.Time.Format.FormatStyle>("FULL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#LONG"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle LONG => LocalClazz.GetField<Java.Time.Format.FormatStyle>("LONG");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#MEDIUM"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle MEDIUM => LocalClazz.GetField<Java.Time.Format.FormatStyle>("MEDIUM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#SHORT"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle SHORT => LocalClazz.GetField<Java.Time.Format.FormatStyle>("SHORT");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#values()"/> 
        /// </summary>
        public static Java.Time.Format.FormatStyle[] Values
        {
            get { return SExecuteArray<Java.Time.Format.FormatStyle>(LocalClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.Format.FormatStyle"/></returns>
        public static Java.Time.Format.FormatStyle ValueOf(string arg0)
        {
            return SExecute<Java.Time.Format.FormatStyle>(LocalClazz, "valueOf", arg0);
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