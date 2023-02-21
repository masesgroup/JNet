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
    #region Temporal
    public partial class Temporal
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Time.Temporal.TemporalAccessor(Java.Time.Temporal.Temporal t) => t.Cast<Java.Time.Temporal.TemporalAccessor>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/Temporal.html#isSupported(java.time.temporal.TemporalUnit)
        /// </summary>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/Temporal.html#plus(long,java.time.temporal.TemporalUnit)
        /// </summary>
        public Java.Time.Temporal.Temporal Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/Temporal.html#with(java.time.temporal.TemporalField,long)
        /// </summary>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalField arg0, long arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/Temporal.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)
        /// </summary>
        public long Until(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<long>("until", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/Temporal.html#minus(java.time.temporal.TemporalAmount)
        /// </summary>
        public Java.Time.Temporal.Temporal Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/Temporal.html#minus(long,java.time.temporal.TemporalUnit)
        /// </summary>
        public Java.Time.Temporal.Temporal Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/Temporal.html#plus(java.time.temporal.TemporalAmount)
        /// </summary>
        public Java.Time.Temporal.Temporal Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/Temporal.html#with(java.time.temporal.TemporalAdjuster)
        /// </summary>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalAdjuster arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}