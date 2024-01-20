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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Channels
{
    #region SelectionKey
    public partial class SelectionKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#OP_ACCEPT"/>
        /// </summary>
        public static int OP_ACCEPT { get { return SGetField<int>(LocalBridgeClazz, "OP_ACCEPT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#OP_CONNECT"/>
        /// </summary>
        public static int OP_CONNECT { get { return SGetField<int>(LocalBridgeClazz, "OP_CONNECT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#OP_READ"/>
        /// </summary>
        public static int OP_READ { get { return SGetField<int>(LocalBridgeClazz, "OP_READ"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#OP_WRITE"/>
        /// </summary>
        public static int OP_WRITE { get { return SGetField<int>(LocalBridgeClazz, "OP_WRITE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isValid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecute<bool>("isValid");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#interestOps()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int InterestOps()
        {
            return IExecute<int>("interestOps");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#readyOps()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ReadyOps()
        {
            return IExecute<int>("readyOps");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#channel()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Channels.SelectableChannel"/></returns>
        public Java.Nio.Channels.SelectableChannel Channel()
        {
            return IExecute<Java.Nio.Channels.SelectableChannel>("channel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#interestOps(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Channels.SelectionKey"/></returns>
        public Java.Nio.Channels.SelectionKey InterestOps(int arg0)
        {
            return IExecute<Java.Nio.Channels.SelectionKey>("interestOps", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#selector()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Channels.Selector"/></returns>
        public Java.Nio.Channels.Selector Selector()
        {
            return IExecute<Java.Nio.Channels.Selector>("selector");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecute("cancel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isAcceptable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAcceptable()
        {
            return IExecute<bool>("isAcceptable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isConnectable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsConnectable()
        {
            return IExecute<bool>("isConnectable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isReadable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsReadable()
        {
            return IExecute<bool>("isReadable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isWritable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsWritable()
        {
            return IExecute<bool>("isWritable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#attach(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Attach(object arg0)
        {
            return IExecute("attach", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#attachment()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Attachment()
        {
            return IExecute("attachment");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#interestOpsAnd(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int InterestOpsAnd(int arg0)
        {
            return IExecute<int>("interestOpsAnd", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#interestOpsOr(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int InterestOpsOr(int arg0)
        {
            return IExecute<int>("interestOpsOr", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}