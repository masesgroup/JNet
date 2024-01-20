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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Format
{
    #region TextStyle
    public partial class TextStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#FULL"/>
        /// </summary>
        public static Java.Time.Format.TextStyle FULL { get { return SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "FULL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#FULL_STANDALONE"/>
        /// </summary>
        public static Java.Time.Format.TextStyle FULL_STANDALONE { get { return SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "FULL_STANDALONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#NARROW"/>
        /// </summary>
        public static Java.Time.Format.TextStyle NARROW { get { return SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "NARROW"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#NARROW_STANDALONE"/>
        /// </summary>
        public static Java.Time.Format.TextStyle NARROW_STANDALONE { get { return SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "NARROW_STANDALONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#SHORT"/>
        /// </summary>
        public static Java.Time.Format.TextStyle SHORT { get { return SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "SHORT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#SHORT_STANDALONE"/>
        /// </summary>
        public static Java.Time.Format.TextStyle SHORT_STANDALONE { get { return SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "SHORT_STANDALONE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public static Java.Time.Format.TextStyle ValueOf(string arg0)
        {
            return SExecute<Java.Time.Format.TextStyle>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public static Java.Time.Format.TextStyle[] Values()
        {
            return SExecuteArray<Java.Time.Format.TextStyle>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#isStandalone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStandalone()
        {
            return IExecute<bool>("isStandalone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#asNormal()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public Java.Time.Format.TextStyle AsNormal()
        {
            return IExecute<Java.Time.Format.TextStyle>("asNormal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#asStandalone()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public Java.Time.Format.TextStyle AsStandalone()
        {
            return IExecute<Java.Time.Format.TextStyle>("asStandalone");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}