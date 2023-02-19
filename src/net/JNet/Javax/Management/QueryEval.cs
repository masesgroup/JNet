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

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    public class QueryEval : JVMBridgeBase<QueryEval>
    {
        public override string ClassName => "javax.management.QueryEval";
        /// <summary>
        /// Return the MBean server that was most recently given to the setMBeanServer method by this thread.
        /// </summary>
        public static MBeanServer MBeanServer => SExecute<MBeanServer>("getMBeanServer");
        /// <summary>
        /// Sets the MBean server on which the query is to be performed.
        /// </summary>
        public void SetMBeanServer(MBeanServer mbs) => IExecute<bool>("setMBeanServer", mbs);
    }
}
