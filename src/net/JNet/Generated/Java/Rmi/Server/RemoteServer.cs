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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Server
{
    #region RemoteServer
    public partial class RemoteServer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteServer.html#getClientHost()"/> 
        /// </summary>
        public static string ClientHost
        {
            get { return SExecute<string>(LocalClazz, "getClientHost"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteServer.html#getLog()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteServer.html#setLog(java.io.OutputStream)"/>
        /// </summary>
        public static Java.Io.PrintStream Log
        {
            get { return SExecute<Java.Io.PrintStream>(LocalClazz, "getLog"); } set { SExecute(LocalClazz, "setLog", value); }
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}