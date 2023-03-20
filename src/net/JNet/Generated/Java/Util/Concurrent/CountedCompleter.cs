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

namespace Java.Util.Concurrent
{
    #region CountedCompleter
    public partial class CountedCompleter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#getCompleter()"/> 
        /// </summary>
        public Java.Util.Concurrent.CountedCompleter Completer
        {
            get { return IExecute<Java.Util.Concurrent.CountedCompleter>("getCompleter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#getPendingCount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#setPendingCount(int)"/>
        /// </summary>
        public int PendingCount
        {
            get { return IExecute<int>("getPendingCount"); } set { IExecute("setPendingCount", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#getRoot()"/> 
        /// </summary>
        public Java.Util.Concurrent.CountedCompleter Root
        {
            get { return IExecute<Java.Util.Concurrent.CountedCompleter>("getRoot"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#compute()"/>
        /// </summary>
        public void Compute()
        {
            IExecute("compute");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#onExceptionalCompletion(java.lang.Throwable,java.util.concurrent.CountedCompleter%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnExceptionalCompletion(Java.Lang.Throwable arg0, Java.Util.Concurrent.CountedCompleter arg1)
        {
            return IExecute<bool>("onExceptionalCompletion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#compareAndSetPendingCount(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSetPendingCount(int arg0, int arg1)
        {
            return IExecute<bool>("compareAndSetPendingCount", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#decrementPendingCountUnlessZero()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int DecrementPendingCountUnlessZero()
        {
            return IExecute<int>("decrementPendingCountUnlessZero");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#firstComplete()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter FirstComplete()
        {
            return IExecute<Java.Util.Concurrent.CountedCompleter>("firstComplete");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#nextComplete()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter NextComplete()
        {
            return IExecute<Java.Util.Concurrent.CountedCompleter>("nextComplete");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#addToPendingCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AddToPendingCount(int arg0)
        {
            IExecute("addToPendingCount", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#helpComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void HelpComplete(int arg0)
        {
            IExecute("helpComplete", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#propagateCompletion()"/>
        /// </summary>
        public void PropagateCompletion()
        {
            IExecute("propagateCompletion");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#quietlyCompleteRoot()"/>
        /// </summary>
        public void QuietlyCompleteRoot()
        {
            IExecute("quietlyCompleteRoot");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#tryComplete()"/>
        /// </summary>
        public void TryComplete()
        {
            IExecute("tryComplete");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#onCompletion(java.util.concurrent.CountedCompleter%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        public void OnCompletion(Java.Util.Concurrent.CountedCompleter arg0)
        {
            IExecute("onCompletion", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}