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

namespace Javax.Management.Remote
{
    #region JMXConnectionNotification
    public partial class JMXConnectionNotification
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#<init>(java.lang.String,java.lang.Object,java.lang.String,long,java.lang.String,java.lang.Object)
        /// </summary>
        public JMXConnectionNotification(string arg0, object arg1, string arg2, long arg3, string arg4, object arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#OPENED
        /// </summary>
        public static string OPENED => Clazz.GetField<string>("OPENED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#CLOSED
        /// </summary>
        public static string CLOSED => Clazz.GetField<string>("CLOSED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#FAILED
        /// </summary>
        public static string FAILED => Clazz.GetField<string>("FAILED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#NOTIFS_LOST
        /// </summary>
        public static string NOTIFS_LOST => Clazz.GetField<string>("NOTIFS_LOST");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#getConnectionId() 
        /// </summary>
        public string ConnectionId
        {
            get { return IExecute<string>("getConnectionId"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}