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

namespace Java.Util.Concurrent
{
    #region TimeUnit
    public partial class TimeUnit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#DAYS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit DAYS { get { return SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "DAYS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#HOURS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit HOURS { get { return SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "HOURS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#MICROSECONDS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit MICROSECONDS { get { return SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "MICROSECONDS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#MILLISECONDS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit MILLISECONDS { get { return SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "MILLISECONDS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#MINUTES"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit MINUTES { get { return SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "MINUTES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#NANOSECONDS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit NANOSECONDS { get { return SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "NANOSECONDS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#SECONDS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit SECONDS { get { return SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "SECONDS"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#of(java.time.temporal.ChronoUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.ChronoUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.TimeUnit"/></returns>
        public static Java.Util.Concurrent.TimeUnit Of(Java.Time.Temporal.ChronoUnit arg0)
        {
            return SExecute<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Concurrent.TimeUnit"/></returns>
        public static Java.Util.Concurrent.TimeUnit ValueOf(string arg0)
        {
            return SExecute<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.TimeUnit"/></returns>
        public static Java.Util.Concurrent.TimeUnit[] Values()
        {
            return SExecuteArray<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#toChronoUnit()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Temporal.ChronoUnit"/></returns>
        public Java.Time.Temporal.ChronoUnit ToChronoUnit()
        {
            return IExecute<Java.Time.Temporal.ChronoUnit>("toChronoUnit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#convert(java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="long"/></returns>
        public long Convert(Java.Time.Duration arg0)
        {
            return IExecute<long>("convert", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#convert(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Convert(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<long>("convert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#toDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToDays(long arg0)
        {
            return IExecute<long>("toDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#toHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToHours(long arg0)
        {
            return IExecute<long>("toHours", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#toMicros(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToMicros(long arg0)
        {
            return IExecute<long>("toMicros", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#toMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToMillis(long arg0)
        {
            return IExecute<long>("toMillis", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#toMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToMinutes(long arg0)
        {
            return IExecute<long>("toMinutes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#toNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToNanos(long arg0)
        {
            return IExecute<long>("toNanos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#toSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToSeconds(long arg0)
        {
            return IExecute<long>("toSeconds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#sleep(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Sleep(long arg0)
        {
            IExecute("sleep", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#timedJoin(java.lang.Thread,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void TimedJoin(Java.Lang.Thread arg0, long arg1)
        {
            IExecute("timedJoin", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TimeUnit.html#timedWait(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void TimedWait(object arg0, long arg1)
        {
            IExecute("timedWait", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}