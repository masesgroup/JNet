/*
*  Copyright 2022 MASES s.r.l.
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

using Java.Sql;
using Java.Util;
using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;

namespace JavaX.Sql
{
    public class ConnectionEvent : EventObject
    {
        public override string ClassName => "javax.sql.ConnectionEvent";
        /// <summary>
        /// Retrieves the SQLException for this ConnectionEvent object.
        /// </summary>
        public SQLException SQLException { get { var obj = IExecute<IJavaObject>("getSQLException"); return JVMBridgeException.New(obj) as SQLException; } }
    }
}
