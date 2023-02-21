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
    #region TransferQueue
    public partial class TransferQueue
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TransferQueue.html#getWaitingConsumerCount() 
        /// </summary>
        public int WaitingConsumerCount
        {
            get { return IExecute<int>("getWaitingConsumerCount"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TransferQueue.html#hasWaitingConsumer()
        /// </summary>
        public bool HasWaitingConsumer()
        {
            return IExecute<bool>("hasWaitingConsumer");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TransferQueue.html#tryTransfer(E)
        /// </summary>
        public bool TryTransfer(object arg0)
        {
            return IExecute<bool>("tryTransfer", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/TransferQueue.html#transfer(E) throws java.lang.InterruptedException
        /// </summary>
        public void Transfer(object arg0)
        {
            IExecute("transfer", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}