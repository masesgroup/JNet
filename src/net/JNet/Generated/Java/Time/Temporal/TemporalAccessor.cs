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

namespace Java.Time.Temporal
{
    #region TemporalAccessor
    public partial class TemporalAccessor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAccessor.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAccessor.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see langword="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<long>("getLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAccessor.html#query(java.time.temporal.TemporalQuery%3CR%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <returns><see langword="object"/></returns>
        public object Query(Java.Time.Temporal.TemporalQuery arg0)
        {
            return IExecute("query", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAccessor.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see langword="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAccessor.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}