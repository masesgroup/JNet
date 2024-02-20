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

namespace Java.Time.Chrono
{
    #region ThaiBuddhistDate
    public partial class ThaiBuddhistDate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.ThaiBuddhistDate"/> to <see cref="Java.Time.Chrono.ChronoLocalDate"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.ChronoLocalDate(Java.Time.Chrono.ThaiBuddhistDate t) => t.Cast<Java.Time.Chrono.ChronoLocalDate>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.ThaiBuddhistDate"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Chrono.ThaiBuddhistDate t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistDate.html#now()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Chrono.ThaiBuddhistDate"/></returns>
        public static Java.Time.Chrono.ThaiBuddhistDate Now()
        {
            return SExecute<Java.Time.Chrono.ThaiBuddhistDate>(LocalBridgeClazz, "now");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistDate.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.Chrono.ThaiBuddhistDate"/></returns>
        public static Java.Time.Chrono.ThaiBuddhistDate Now(Java.Time.Clock arg0)
        {
            return SExecute<Java.Time.Chrono.ThaiBuddhistDate>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistDate.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ThaiBuddhistDate"/></returns>
        public static Java.Time.Chrono.ThaiBuddhistDate Now(Java.Time.ZoneId arg0)
        {
            return SExecute<Java.Time.Chrono.ThaiBuddhistDate>(LocalBridgeClazz, "now", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistDate.html#of(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ThaiBuddhistDate"/></returns>
        public static Java.Time.Chrono.ThaiBuddhistDate Of(int arg0, int arg1, int arg2)
        {
            return SExecute<Java.Time.Chrono.ThaiBuddhistDate>(LocalBridgeClazz, "of", arg0, arg1, arg2);
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