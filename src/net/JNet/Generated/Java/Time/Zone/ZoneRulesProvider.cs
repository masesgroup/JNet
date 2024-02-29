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

namespace Java.Time.Zone
{
    #region ZoneRulesProvider
    public partial class ZoneRulesProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#getAvailableZoneIds()"/> 
        /// </summary>
        public static Java.Util.Set<Java.Lang.String> AvailableZoneIds
        {
            get { return SExecuteWithSignature<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "getAvailableZoneIds", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#refresh()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool Refresh()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "refresh", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#getRules(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneRules"/></returns>
        public static Java.Time.Zone.ZoneRules GetRules(Java.Lang.String arg0, bool arg1)
        {
            return SExecute<Java.Time.Zone.ZoneRules>(LocalBridgeClazz, "getRules", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#getVersions(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public static Java.Util.NavigableMap<Java.Lang.String, Java.Time.Zone.ZoneRules> GetVersions(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.NavigableMap<Java.Lang.String, Java.Time.Zone.ZoneRules>>(LocalBridgeClazz, "getVersions", "(Ljava/lang/String;)Ljava/util/NavigableMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#registerProvider(java.time.zone.ZoneRulesProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Zone.ZoneRulesProvider"/></param>
        public static void RegisterProvider(Java.Time.Zone.ZoneRulesProvider arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "registerProvider", "(Ljava/time/zone/ZoneRulesProvider;)V", arg0);
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