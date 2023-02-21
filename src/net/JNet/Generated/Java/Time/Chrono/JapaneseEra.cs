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

namespace Java.Time.Chrono
{
    #region JapaneseEra
    public partial class JapaneseEra
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Time.Chrono.Era(Java.Time.Chrono.JapaneseEra t) => t.Cast<Java.Time.Chrono.Era>();
        public static implicit operator Java.Io.Serializable(Java.Time.Chrono.JapaneseEra t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#MEIJI
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra MEIJI => Clazz.GetField<Java.Time.Chrono.JapaneseEra>("MEIJI");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#TAISHO
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra TAISHO => Clazz.GetField<Java.Time.Chrono.JapaneseEra>("TAISHO");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#SHOWA
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra SHOWA => Clazz.GetField<Java.Time.Chrono.JapaneseEra>("SHOWA");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#HEISEI
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra HEISEI => Clazz.GetField<Java.Time.Chrono.JapaneseEra>("HEISEI");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#of(int)
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra Of(int arg0)
        {
            return SExecute<Java.Time.Chrono.JapaneseEra>("of", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#valueOf(java.lang.String)
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra ValueOf(string arg0)
        {
            return SExecute<Java.Time.Chrono.JapaneseEra>("valueOf", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#values()
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra[] Values()
        {
            return SExecuteArray<Java.Time.Chrono.JapaneseEra>("values");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#getValue() 
        /// </summary>
        public int Value
        {
            get { return IExecute<int>("getValue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#range(java.time.temporal.TemporalField)
        /// </summary>
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