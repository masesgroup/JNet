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

namespace Javax.Smartcardio
{
    #region CommandAPDU
    public partial class CommandAPDU
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#<init>(int,int,int,int,byte[],int,int)
        /// </summary>
        public CommandAPDU(int arg0, int arg1, int arg2, int arg3, byte[] arg4, int arg5, int arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#<init>(int,int,int,int,byte[])
        /// </summary>
        public CommandAPDU(int arg0, int arg1, int arg2, int arg3, byte[] arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#<init>(int,int,int,int,int)
        /// </summary>
        public CommandAPDU(int arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#<init>(int,int,int,int,byte[],int)
        /// </summary>
        public CommandAPDU(int arg0, int arg1, int arg2, int arg3, byte[] arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#<init>(int,int,int,int,byte[],int,int,int)
        /// </summary>
        public CommandAPDU(int arg0, int arg1, int arg2, int arg3, byte[] arg4, int arg5, int arg6, int arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#<init>(byte[])
        /// </summary>
        public CommandAPDU(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#<init>(byte[],int,int)
        /// </summary>
        public CommandAPDU(byte[] arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#<init>(java.nio.ByteBuffer)
        /// </summary>
        public CommandAPDU(Java.Nio.ByteBuffer arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#<init>(int,int,int,int)
        /// </summary>
        public CommandAPDU(int arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Serializable(Javax.Smartcardio.CommandAPDU t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#getBytes() 
        /// </summary>
        public byte[] Bytes
        {
            get { return IExecuteArray<byte>("getBytes"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#getCLA() 
        /// </summary>
        public int CLA
        {
            get { return IExecute<int>("getCLA"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#getData() 
        /// </summary>
        public byte[] Data
        {
            get { return IExecuteArray<byte>("getData"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#getINS() 
        /// </summary>
        public int INS
        {
            get { return IExecute<int>("getINS"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#getNc() 
        /// </summary>
        public int Nc
        {
            get { return IExecute<int>("getNc"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#getNe() 
        /// </summary>
        public int Ne
        {
            get { return IExecute<int>("getNe"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#getP1() 
        /// </summary>
        public int P1
        {
            get { return IExecute<int>("getP1"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CommandAPDU.html#getP2() 
        /// </summary>
        public int P2
        {
            get { return IExecute<int>("getP2"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}