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
    #region ValueRange
    public partial class ValueRange
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Temporal.ValueRange"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Temporal.ValueRange t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#of(long,long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public static Java.Time.Temporal.ValueRange Of(long arg0, long arg1, long arg2, long arg3)
        {
            return SExecute<Java.Time.Temporal.ValueRange>("of", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#of(long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public static Java.Time.Temporal.ValueRange Of(long arg0, long arg1, long arg2)
        {
            return SExecute<Java.Time.Temporal.ValueRange>("of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#of(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public static Java.Time.Temporal.ValueRange Of(long arg0, long arg1)
        {
            return SExecute<Java.Time.Temporal.ValueRange>("of", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#getLargestMinimum()"/> 
        /// </summary>
        public long LargestMinimum
        {
            get { return IExecute<long>("getLargestMinimum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#getMaximum()"/> 
        /// </summary>
        public long Maximum
        {
            get { return IExecute<long>("getMaximum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#getMinimum()"/> 
        /// </summary>
        public long Minimum
        {
            get { return IExecute<long>("getMinimum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#getSmallestMaximum()"/> 
        /// </summary>
        public long SmallestMaximum
        {
            get { return IExecute<long>("getSmallestMaximum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#isFixed()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsFixed()
        {
            return IExecute<bool>("isFixed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#isIntValue()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsIntValue()
        {
            return IExecute<bool>("isIntValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#isValidIntValue(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidIntValue(long arg0)
        {
            return IExecute<bool>("isValidIntValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#isValidValue(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidValue(long arg0)
        {
            return IExecute<bool>("isValidValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#checkValidIntValue(long,java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int CheckValidIntValue(long arg0, Java.Time.Temporal.TemporalField arg1)
        {
            return IExecute<int>("checkValidIntValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ValueRange.html#checkValidValue(long,java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long CheckValidValue(long arg0, Java.Time.Temporal.TemporalField arg1)
        {
            return IExecute<long>("checkValidValue", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}