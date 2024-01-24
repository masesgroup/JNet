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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region RunnableFuture
    public partial class RunnableFuture
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableFuture"/> to <see cref="Java.Lang.Runnable"/>
        /// </summary>
        public static implicit operator Java.Lang.Runnable(Java.Util.Concurrent.RunnableFuture t) => t.Cast<Java.Lang.Runnable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableFuture"/> to <see cref="Java.Util.Concurrent.Future"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future(Java.Util.Concurrent.RunnableFuture t) => t.Cast<Java.Util.Concurrent.Future>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/RunnableFuture.html#run()"/>
        /// </summary>
        public void Run()
        {
            IExecute("run");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IRunnableFuture<V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRunnableFuture<V>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/RunnableFuture.html#run()"/>
        /// </summary>
        void Run();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RunnableFuture<V>
    public partial class RunnableFuture<V> : Java.Util.Concurrent.IRunnableFuture<V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableFuture{V}"/> to <see cref="Java.Lang.Runnable"/>
        /// </summary>
        public static implicit operator Java.Lang.Runnable(Java.Util.Concurrent.RunnableFuture<V> t) => t.Cast<Java.Lang.Runnable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableFuture{V}"/> to <see cref="Java.Util.Concurrent.Future{V}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future<V>(Java.Util.Concurrent.RunnableFuture<V> t) => t.Cast<Java.Util.Concurrent.Future<V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.RunnableFuture{V}"/> to <see cref="Java.Util.Concurrent.RunnableFuture"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.RunnableFuture(Java.Util.Concurrent.RunnableFuture<V> t) => t.Cast<Java.Util.Concurrent.RunnableFuture>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/RunnableFuture.html#run()"/>
        /// </summary>
        public void Run()
        {
            IExecute("run");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}