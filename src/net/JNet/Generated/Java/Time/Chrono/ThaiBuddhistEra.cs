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

namespace Java.Time.Chrono
{
    #region ThaiBuddhistEra
    public partial class ThaiBuddhistEra
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.ThaiBuddhistEra"/> to <see cref="Java.Time.Chrono.Era"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.Era(Java.Time.Chrono.ThaiBuddhistEra t) => t.Cast<Java.Time.Chrono.Era>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistEra.html#BE"/>
        /// </summary>
        public static Java.Time.Chrono.ThaiBuddhistEra BE { get { if (!_BEReady) { _BEContent = SGetField<Java.Time.Chrono.ThaiBuddhistEra>(LocalBridgeClazz, "BE"); _BEReady = true; } return _BEContent; } }
        private static Java.Time.Chrono.ThaiBuddhistEra _BEContent = default;
        private static bool _BEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistEra.html#BEFORE_BE"/>
        /// </summary>
        public static Java.Time.Chrono.ThaiBuddhistEra BEFORE_BE { get { if (!_BEFORE_BEReady) { _BEFORE_BEContent = SGetField<Java.Time.Chrono.ThaiBuddhistEra>(LocalBridgeClazz, "BEFORE_BE"); _BEFORE_BEReady = true; } return _BEFORE_BEContent; } }
        private static Java.Time.Chrono.ThaiBuddhistEra _BEFORE_BEContent = default;
        private static bool _BEFORE_BEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistEra.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ThaiBuddhistEra"/></returns>
        public static Java.Time.Chrono.ThaiBuddhistEra Of(int arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.ThaiBuddhistEra>(LocalBridgeClazz, "of", "(I)Ljava/time/chrono/ThaiBuddhistEra;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistEra.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Chrono.ThaiBuddhistEra"/></returns>
        public static Java.Time.Chrono.ThaiBuddhistEra ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.ThaiBuddhistEra>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/chrono/ThaiBuddhistEra;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistEra.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Chrono.ThaiBuddhistEra"/></returns>
        public static Java.Time.Chrono.ThaiBuddhistEra[] Values()
        {
            return SExecuteWithSignatureArray<Java.Time.Chrono.ThaiBuddhistEra>(LocalBridgeClazz, "values", "()[Ljava/time/chrono/ThaiBuddhistEra;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistEra.html#getValue()"/> 
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/ThaiBuddhistEra.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}