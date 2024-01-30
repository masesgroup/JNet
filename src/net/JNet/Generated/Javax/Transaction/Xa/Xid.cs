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

namespace Javax.Transaction.Xa
{
    #region IXid
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXid
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getBranchQualifier()"/> 
        /// </summary>
        byte[] BranchQualifier { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getFormatId()"/> 
        /// </summary>
        int FormatId { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getGlobalTransactionId()"/> 
        /// </summary>
        byte[] GlobalTransactionId { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Xid
    public partial class Xid : Javax.Transaction.Xa.IXid
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#MAXBQUALSIZE"/>
        /// </summary>
        public static int MAXBQUALSIZE { get { if (!_MAXBQUALSIZEReady) { _MAXBQUALSIZEContent = SGetField<int>(LocalBridgeClazz, "MAXBQUALSIZE"); _MAXBQUALSIZEReady = true; } return _MAXBQUALSIZEContent; } }
        private static int _MAXBQUALSIZEContent = default;
        private static bool _MAXBQUALSIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#MAXGTRIDSIZE"/>
        /// </summary>
        public static int MAXGTRIDSIZE { get { if (!_MAXGTRIDSIZEReady) { _MAXGTRIDSIZEContent = SGetField<int>(LocalBridgeClazz, "MAXGTRIDSIZE"); _MAXGTRIDSIZEReady = true; } return _MAXGTRIDSIZEContent; } }
        private static int _MAXGTRIDSIZEContent = default;
        private static bool _MAXGTRIDSIZEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getBranchQualifier()"/> 
        /// </summary>
        public byte[] BranchQualifier
        {
            get { return IExecuteArray<byte>("getBranchQualifier"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getFormatId()"/> 
        /// </summary>
        public int FormatId
        {
            get { return IExecute<int>("getFormatId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getGlobalTransactionId()"/> 
        /// </summary>
        public byte[] GlobalTransactionId
        {
            get { return IExecuteArray<byte>("getGlobalTransactionId"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}