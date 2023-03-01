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

namespace Javax.Net.Ssl
{
    #region SSLEngineResult
    public partial class SSLEngineResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#%3Cinit%3E(javax.net.ssl.SSLEngineResult$Status,javax.net.ssl.SSLEngineResult$HandshakeStatus,int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLEngineResult.Status"/></param>
        /// <param name="arg1"><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        public SSLEngineResult(Javax.Net.Ssl.SSLEngineResult.Status arg0, Javax.Net.Ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3, long arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#%3Cinit%3E(javax.net.ssl.SSLEngineResult$Status,javax.net.ssl.SSLEngineResult$HandshakeStatus,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLEngineResult.Status"/></param>
        /// <param name="arg1"><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SSLEngineResult(Javax.Net.Ssl.SSLEngineResult.Status arg0, Javax.Net.Ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#bytesConsumed()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int BytesConsumed()
        {
            return IExecute<int>("bytesConsumed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#bytesProduced()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int BytesProduced()
        {
            return IExecute<int>("bytesProduced");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#getHandshakeStatus()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></returns>
        public Javax.Net.Ssl.SSLEngineResult.HandshakeStatus GetHandshakeStatus()
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("getHandshakeStatus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#getStatus()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.Status"/></returns>
        public Javax.Net.Ssl.SSLEngineResult.Status GetStatus()
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult.Status>("getStatus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#sequenceNumber()"/>
        /// </summary>
        
        /// <returns><see langword="long"/></returns>
        public long SequenceNumber()
        {
            return IExecute<long>("sequenceNumber");
        }
        
        #endregion

        #region Nested classes
        #region HandshakeStatus
        public partial class HandshakeStatus
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#FINISHED"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus FINISHED => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("FINISHED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NEED_TASK"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NEED_TASK => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("NEED_TASK");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NEED_UNWRAP"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("NEED_UNWRAP");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NEED_UNWRAP_AGAIN"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP_AGAIN => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("NEED_UNWRAP_AGAIN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NEED_WRAP"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NEED_WRAP => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("NEED_WRAP");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NOT_HANDSHAKING"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NOT_HANDSHAKING => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("NOT_HANDSHAKING");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></returns>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus ValueOf(string arg0)
            {
                return SExecute<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#values()"/>
            /// </summary>
            
            /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></returns>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus[] Values()
            {
                return SExecuteArray<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("values");
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Status
        public partial class Status
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#BUFFER_OVERFLOW"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.Status BUFFER_OVERFLOW => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.Status>("BUFFER_OVERFLOW");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#BUFFER_UNDERFLOW"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.Status BUFFER_UNDERFLOW => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.Status>("BUFFER_UNDERFLOW");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#CLOSED"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.Status CLOSED => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.Status>("CLOSED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#OK"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.Status OK => Clazz.GetField<Javax.Net.Ssl.SSLEngineResult.Status>("OK");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.Status"/></returns>
            public static Javax.Net.Ssl.SSLEngineResult.Status ValueOf(string arg0)
            {
                return SExecute<Javax.Net.Ssl.SSLEngineResult.Status>("valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#values()"/>
            /// </summary>
            
            /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.Status"/></returns>
            public static Javax.Net.Ssl.SSLEngineResult.Status[] Values()
            {
                return SExecuteArray<Javax.Net.Ssl.SSLEngineResult.Status>("values");
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}