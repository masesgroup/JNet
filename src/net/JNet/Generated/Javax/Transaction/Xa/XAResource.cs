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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Transaction.Xa
{
    #region IXAResource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXAResource
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#getTransactionTimeout()"/> 
        /// </summary>
        int TransactionTimeout { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#isSameRM(javax.transaction.xa.XAResource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.XAResource"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        bool IsSameRM(Javax.Transaction.Xa.XAResource arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#setTransactionTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        bool SetTransactionTimeout(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#prepare(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        int Prepare(Javax.Transaction.Xa.Xid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#recover(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Transaction.Xa.Xid"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        Javax.Transaction.Xa.Xid[] Recover(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#commit(javax.transaction.xa.Xid,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void Commit(Javax.Transaction.Xa.Xid arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#end(javax.transaction.xa.Xid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void End(Javax.Transaction.Xa.Xid arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#forget(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void Forget(Javax.Transaction.Xa.Xid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#rollback(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void Rollback(Javax.Transaction.Xa.Xid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#start(javax.transaction.xa.Xid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void Start(Javax.Transaction.Xa.Xid arg0, int arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XAResource
    public partial class XAResource : Javax.Transaction.Xa.IXAResource
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMENDRSCAN"/>
        /// </summary>
        public static int TMENDRSCAN { get { return SGetField<int>(LocalBridgeClazz, "TMENDRSCAN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMFAIL"/>
        /// </summary>
        public static int TMFAIL { get { return SGetField<int>(LocalBridgeClazz, "TMFAIL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMJOIN"/>
        /// </summary>
        public static int TMJOIN { get { return SGetField<int>(LocalBridgeClazz, "TMJOIN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMNOFLAGS"/>
        /// </summary>
        public static int TMNOFLAGS { get { return SGetField<int>(LocalBridgeClazz, "TMNOFLAGS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMONEPHASE"/>
        /// </summary>
        public static int TMONEPHASE { get { return SGetField<int>(LocalBridgeClazz, "TMONEPHASE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMRESUME"/>
        /// </summary>
        public static int TMRESUME { get { return SGetField<int>(LocalBridgeClazz, "TMRESUME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMSTARTRSCAN"/>
        /// </summary>
        public static int TMSTARTRSCAN { get { return SGetField<int>(LocalBridgeClazz, "TMSTARTRSCAN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMSUCCESS"/>
        /// </summary>
        public static int TMSUCCESS { get { return SGetField<int>(LocalBridgeClazz, "TMSUCCESS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMSUSPEND"/>
        /// </summary>
        public static int TMSUSPEND { get { return SGetField<int>(LocalBridgeClazz, "TMSUSPEND"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#XA_OK"/>
        /// </summary>
        public static int XA_OK { get { return SGetField<int>(LocalBridgeClazz, "XA_OK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#XA_RDONLY"/>
        /// </summary>
        public static int XA_RDONLY { get { return SGetField<int>(LocalBridgeClazz, "XA_RDONLY"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#getTransactionTimeout()"/> 
        /// </summary>
        public int TransactionTimeout
        {
            get { return IExecute<int>("getTransactionTimeout"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#isSameRM(javax.transaction.xa.XAResource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.XAResource"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public bool IsSameRM(Javax.Transaction.Xa.XAResource arg0)
        {
            return IExecute<bool>("isSameRM", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#setTransactionTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public bool SetTransactionTimeout(int arg0)
        {
            return IExecute<bool>("setTransactionTimeout", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#prepare(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public int Prepare(Javax.Transaction.Xa.Xid arg0)
        {
            return IExecute<int>("prepare", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#recover(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Transaction.Xa.Xid"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public Javax.Transaction.Xa.Xid[] Recover(int arg0)
        {
            return IExecuteArray<Javax.Transaction.Xa.Xid>("recover", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#commit(javax.transaction.xa.Xid,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void Commit(Javax.Transaction.Xa.Xid arg0, bool arg1)
        {
            IExecute("commit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#end(javax.transaction.xa.Xid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void End(Javax.Transaction.Xa.Xid arg0, int arg1)
        {
            IExecute("end", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#forget(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void Forget(Javax.Transaction.Xa.Xid arg0)
        {
            IExecute("forget", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#rollback(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void Rollback(Javax.Transaction.Xa.Xid arg0)
        {
            IExecute("rollback", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#start(javax.transaction.xa.Xid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void Start(Javax.Transaction.Xa.Xid arg0, int arg1)
        {
            IExecute("start", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}