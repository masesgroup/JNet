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

namespace Java.Util.Concurrent
{
    #region RunnableScheduledFuture
    public partial class RunnableScheduledFuture
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableScheduledFuture"/> to <see cref="Java.Util.Concurrent.RunnableFuture"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.RunnableFuture(Java.Util.Concurrent.RunnableScheduledFuture t) => t.Cast<Java.Util.Concurrent.RunnableFuture>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableScheduledFuture"/> to <see cref="Java.Util.Concurrent.ScheduledFuture"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ScheduledFuture(Java.Util.Concurrent.RunnableScheduledFuture t) => t.Cast<Java.Util.Concurrent.ScheduledFuture>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/RunnableScheduledFuture.html#isPeriodic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPeriodic()
        {
            return IExecuteWithSignature<bool>("isPeriodic", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IRunnableScheduledFuture<V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRunnableScheduledFuture<V>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/RunnableScheduledFuture.html#isPeriodic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsPeriodic();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RunnableScheduledFuture<V>
    public partial class RunnableScheduledFuture<V> : Java.Util.Concurrent.IRunnableScheduledFuture<V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableScheduledFuture{V}"/> to <see cref="Java.Util.Concurrent.RunnableFuture{V}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.RunnableFuture<V>(Java.Util.Concurrent.RunnableScheduledFuture<V> t) => t.Cast<Java.Util.Concurrent.RunnableFuture<V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableScheduledFuture{V}"/> to <see cref="Java.Util.Concurrent.ScheduledFuture{V}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ScheduledFuture<V>(Java.Util.Concurrent.RunnableScheduledFuture<V> t) => t.Cast<Java.Util.Concurrent.ScheduledFuture<V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableScheduledFuture{V}"/> to <see cref="Java.Util.Concurrent.RunnableScheduledFuture"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.RunnableScheduledFuture(Java.Util.Concurrent.RunnableScheduledFuture<V> t) => t.Cast<Java.Util.Concurrent.RunnableScheduledFuture>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/RunnableScheduledFuture.html#isPeriodic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPeriodic()
        {
            return IExecuteWithSignature<bool>("isPeriodic", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}