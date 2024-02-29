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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region GregorianCalendar
    public partial class GregorianCalendar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#%3Cinit%3E(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#%3Cinit%3E(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public GregorianCalendar(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public GregorianCalendar(Java.Util.Locale arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#%3Cinit%3E(java.util.TimeZone,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public GregorianCalendar(Java.Util.TimeZone arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#%3Cinit%3E(java.util.TimeZone)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimeZone"/></param>
        public GregorianCalendar(Java.Util.TimeZone arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#AD"/>
        /// </summary>
        public static int AD { get { if (!_ADReady) { _ADContent = SGetField<int>(LocalBridgeClazz, "AD"); _ADReady = true; } return _ADContent; } }
        private static int _ADContent = default;
        private static bool _ADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#BC"/>
        /// </summary>
        public static int BC { get { if (!_BCReady) { _BCContent = SGetField<int>(LocalBridgeClazz, "BC"); _BCReady = true; } return _BCContent; } }
        private static int _BCContent = default;
        private static bool _BCReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#from(java.time.ZonedDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZonedDateTime"/></param>
        /// <returns><see cref="Java.Util.GregorianCalendar"/></returns>
        public static Java.Util.GregorianCalendar From(Java.Time.ZonedDateTime arg0)
        {
            return SExecuteWithSignature<Java.Util.GregorianCalendar>(LocalBridgeClazz, "from", "(Ljava/time/ZonedDateTime;)Ljava/util/GregorianCalendar;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#getGregorianChange()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#setGregorianChange(java.util.Date)"/>
        /// </summary>
        public Java.Util.Date GregorianChange
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getGregorianChange", "()Ljava/util/Date;"); } set { IExecuteWithSignature("setGregorianChange", "(Ljava/util/Date;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#isLeapYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeapYear(int arg0)
        {
            return IExecuteWithSignature<bool>("isLeapYear", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/GregorianCalendar.html#toZonedDateTime()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime ToZonedDateTime()
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("toZonedDateTime", "()Ljava/time/ZonedDateTime;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}