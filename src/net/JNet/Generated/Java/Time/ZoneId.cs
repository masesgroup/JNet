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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region ZoneId
    public partial class ZoneId
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#SHORT_IDS"/>
        /// </summary>
        public static Java.Util.Map SHORT_IDS { get { return SGetField<Java.Util.Map>(LocalBridgeClazz, "SHORT_IDS"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#getAvailableZoneIds()"/> 
        /// </summary>
        public static Java.Util.Set<string> AvailableZoneIds
        {
            get { return SExecute<Java.Util.Set<string>>(LocalBridgeClazz, "getAvailableZoneIds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#systemDefault()"/> 
        /// </summary>
        public static Java.Time.ZoneId SystemDefault
        {
            get { return SExecute<Java.Time.ZoneId>(LocalBridgeClazz, "systemDefault"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public static Java.Time.ZoneId From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecute<Java.Time.ZoneId>(LocalBridgeClazz, "from", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#of(java.lang.String,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public static Java.Time.ZoneId Of(string arg0, Java.Util.Map<string, string> arg1)
        {
            return SExecute<Java.Time.ZoneId>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#of(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public static Java.Time.ZoneId Of(string arg0)
        {
            return SExecute<Java.Time.ZoneId>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#ofOffset(java.lang.String,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public static Java.Time.ZoneId OfOffset(string arg0, Java.Time.ZoneOffset arg1)
        {
            return SExecute<Java.Time.ZoneId>(LocalBridgeClazz, "ofOffset", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#getId()"/> 
        /// </summary>
        public string Id
        {
            get { return IExecute<string>("getId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#normalized()"/> 
        /// </summary>
        public Java.Time.ZoneId Normalized
        {
            get { return IExecute<Java.Time.ZoneId>("normalized"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#getRules()"/> 
        /// </summary>
        public Java.Time.Zone.ZoneRules Rules
        {
            get { return IExecute<Java.Time.Zone.ZoneRules>("getRules"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/ZoneId.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getDisplayName", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}