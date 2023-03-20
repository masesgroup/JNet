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

namespace Java.Time.Zone
{
    #region ZoneRules
    public partial class ZoneRules
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Zone.ZoneRules"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Zone.ZoneRules t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#of(java.time.ZoneOffset,java.time.ZoneOffset,java.util.List%3Cjava.time.zone.ZoneOffsetTransition%3E,java.util.List%3Cjava.time.zone.ZoneOffsetTransition%3E,java.util.List%3Cjava.time.zone.ZoneOffsetTransitionRule%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <param name="arg3"><see cref="Java.Util.List"/></param>
        /// <param name="arg4"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneRules"/></returns>
        public static Java.Time.Zone.ZoneRules Of(Java.Time.ZoneOffset arg0, Java.Time.ZoneOffset arg1, Java.Util.List arg2, Java.Util.List arg3, Java.Util.List arg4)
        {
            return SExecute<Java.Time.Zone.ZoneRules>("of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#of(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneRules"/></returns>
        public static Java.Time.Zone.ZoneRules Of(Java.Time.ZoneOffset arg0)
        {
            return SExecute<Java.Time.Zone.ZoneRules>("of", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#getTransitionRules()"/> 
        /// </summary>
        public Java.Util.List TransitionRules
        {
            get { return IExecute<Java.Util.List>("getTransitionRules"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#getTransitions()"/> 
        /// </summary>
        public Java.Util.List Transitions
        {
            get { return IExecute<Java.Util.List>("getTransitions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#isDaylightSavings(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDaylightSavings(Java.Time.Instant arg0)
        {
            return IExecute<bool>("isDaylightSavings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#isFixedOffset()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsFixedOffset()
        {
            return IExecute<bool>("isFixedOffset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#isValidOffset(java.time.LocalDateTime,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidOffset(Java.Time.LocalDateTime arg0, Java.Time.ZoneOffset arg1)
        {
            return IExecute<bool>("isValidOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#getDaylightSavings(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration GetDaylightSavings(Java.Time.Instant arg0)
        {
            return IExecute<Java.Time.Duration>("getDaylightSavings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#getTransition(java.time.LocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransition"/></returns>
        public Java.Time.Zone.ZoneOffsetTransition GetTransition(Java.Time.LocalDateTime arg0)
        {
            return IExecute<Java.Time.Zone.ZoneOffsetTransition>("getTransition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#nextTransition(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransition"/></returns>
        public Java.Time.Zone.ZoneOffsetTransition NextTransition(Java.Time.Instant arg0)
        {
            return IExecute<Java.Time.Zone.ZoneOffsetTransition>("nextTransition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#previousTransition(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransition"/></returns>
        public Java.Time.Zone.ZoneOffsetTransition PreviousTransition(Java.Time.Instant arg0)
        {
            return IExecute<Java.Time.Zone.ZoneOffsetTransition>("previousTransition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#getOffset(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetOffset(Java.Time.Instant arg0)
        {
            return IExecute<Java.Time.ZoneOffset>("getOffset", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#getOffset(java.time.LocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetOffset(Java.Time.LocalDateTime arg0)
        {
            return IExecute<Java.Time.ZoneOffset>("getOffset", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#getStandardOffset(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetStandardOffset(Java.Time.Instant arg0)
        {
            return IExecute<Java.Time.ZoneOffset>("getStandardOffset", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRules.html#getValidOffsets(java.time.LocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List GetValidOffsets(Java.Time.LocalDateTime arg0)
        {
            return IExecute<Java.Util.List>("getValidOffsets", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}