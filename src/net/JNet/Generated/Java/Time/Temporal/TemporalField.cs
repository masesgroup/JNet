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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Temporal
{
    #region ITemporalField
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITemporalField
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#getBaseUnit()"/> 
        /// </summary>
        Java.Time.Temporal.TemporalUnit BaseUnit { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#getRangeUnit()"/> 
        /// </summary>
        Java.Time.Temporal.TemporalUnit RangeUnit { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#adjustInto(java.time.temporal.Temporal,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="R"><see cref="Java.Time.Temporal.ITemporal"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        R AdjustInto<R>(R arg0, long arg1) where R: Java.Time.Temporal.ITemporal, new();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#isDateBased()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsDateBased();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#isSupportedBy(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSupportedBy(Java.Time.Temporal.TemporalAccessor arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#isTimeBased()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsTimeBased();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#range()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        Java.Time.Temporal.ValueRange Range();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#rangeRefinedBy(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        Java.Time.Temporal.ValueRange RangeRefinedBy(Java.Time.Temporal.TemporalAccessor arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#getFrom(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="long"/></returns>
        long GetFrom(Java.Time.Temporal.TemporalAccessor arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#getDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetDisplayName(Java.Util.Locale arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#resolve(java.util.Map,java.time.temporal.TemporalAccessor,java.time.format.ResolverStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <param name="arg2"><see cref="Java.Time.Format.ResolverStyle"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        Java.Time.Temporal.TemporalAccessor Resolve(Java.Util.Map<Java.Time.Temporal.TemporalField, Java.Lang.Long> arg0, Java.Time.Temporal.TemporalAccessor arg1, Java.Time.Format.ResolverStyle arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TemporalField
    public partial class TemporalField : Java.Time.Temporal.ITemporalField
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#getBaseUnit()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalUnit BaseUnit
        {
            get { return IExecuteWithSignature<Java.Time.Temporal.TemporalUnit>("getBaseUnit", "()Ljava/time/temporal/TemporalUnit;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#getRangeUnit()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalUnit RangeUnit
        {
            get { return IExecuteWithSignature<Java.Time.Temporal.TemporalUnit>("getRangeUnit", "()Ljava/time/temporal/TemporalUnit;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#adjustInto(java.time.temporal.Temporal,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="R"><see cref="Java.Time.Temporal.ITemporal"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R AdjustInto<R>(R arg0, long arg1) where R: Java.Time.Temporal.ITemporal, new()
        {
            return IExecute<R>("adjustInto", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#isDateBased()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDateBased()
        {
            return IExecuteWithSignature<bool>("isDateBased", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#isSupportedBy(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupportedBy(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecuteWithSignature<bool>("isSupportedBy", "(Ljava/time/temporal/TemporalAccessor;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#isTimeBased()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTimeBased()
        {
            return IExecuteWithSignature<bool>("isTimeBased", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#range()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range()
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "()Ljava/time/temporal/ValueRange;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#rangeRefinedBy(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange RangeRefinedBy(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("rangeRefinedBy", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#getFrom(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetFrom(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecuteWithSignature<long>("getFrom", "(Ljava/time/temporal/TemporalAccessor;)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#getDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalField.html#resolve(java.util.Map,java.time.temporal.TemporalAccessor,java.time.format.ResolverStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <param name="arg2"><see cref="Java.Time.Format.ResolverStyle"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        public Java.Time.Temporal.TemporalAccessor Resolve(Java.Util.Map<Java.Time.Temporal.TemporalField, Java.Lang.Long> arg0, Java.Time.Temporal.TemporalAccessor arg1, Java.Time.Format.ResolverStyle arg2)
        {
            return IExecute<Java.Time.Temporal.TemporalAccessor>("resolve", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}