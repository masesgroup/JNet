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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Format
{
    #region ResolverStyle
    public partial class ResolverStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/ResolverStyle.html#LENIENT"/>
        /// </summary>
        public static Java.Time.Format.ResolverStyle LENIENT { get { if (!_LENIENTReady) { _LENIENTContent = SGetField<Java.Time.Format.ResolverStyle>(LocalBridgeClazz, "LENIENT"); _LENIENTReady = true; } return _LENIENTContent; } }
        private static Java.Time.Format.ResolverStyle _LENIENTContent = default;
        private static bool _LENIENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/ResolverStyle.html#SMART"/>
        /// </summary>
        public static Java.Time.Format.ResolverStyle SMART { get { if (!_SMARTReady) { _SMARTContent = SGetField<Java.Time.Format.ResolverStyle>(LocalBridgeClazz, "SMART"); _SMARTReady = true; } return _SMARTContent; } }
        private static Java.Time.Format.ResolverStyle _SMARTContent = default;
        private static bool _SMARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/ResolverStyle.html#STRICT"/>
        /// </summary>
        public static Java.Time.Format.ResolverStyle STRICT { get { if (!_STRICTReady) { _STRICTContent = SGetField<Java.Time.Format.ResolverStyle>(LocalBridgeClazz, "STRICT"); _STRICTReady = true; } return _STRICTContent; } }
        private static Java.Time.Format.ResolverStyle _STRICTContent = default;
        private static bool _STRICTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/ResolverStyle.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.Format.ResolverStyle"/></returns>
        public static Java.Time.Format.ResolverStyle ValueOf(string arg0)
        {
            return SExecute<Java.Time.Format.ResolverStyle>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/ResolverStyle.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Format.ResolverStyle"/></returns>
        public static Java.Time.Format.ResolverStyle[] Values()
        {
            return SExecuteArray<Java.Time.Format.ResolverStyle>(LocalBridgeClazz, "values");
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