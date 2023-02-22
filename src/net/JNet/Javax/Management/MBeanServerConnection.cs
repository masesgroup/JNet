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

using Java.Util;
using MASES.JCOBridge.C2JBridge;
using System;

namespace Javax.Management
{
    public partial class MBeanServerConnection
    {
        // can be extended with methods not reflected or not available in Java;

        /// <summary>
        /// Retrieves the values of several attributes of a named MBean.
        /// </summary>
        public AttributeList GetAttributes(ObjectName name, string[] attributes) => IExecute<AttributeList>("getAttributes", name, attributes);
        /// <summary>
        /// Gets MBeans controlled by the MBean server.
        /// </summary>
        public Set<ObjectInstance> QueryMBeans(ObjectName name, QueryExp query) => IExecute<Set<ObjectInstance>>("queryMBeans", name, query);
        /// <summary>
        /// Gets the names of MBeans controlled by the MBean server.
        /// </summary>
        public Set<ObjectName> QueryNames(ObjectName name, QueryExp query) => IExecute<Set<ObjectName>>("queryNames", name, query);
        /// <summary>
        /// Sets the values of several attributes of a named MBean.
        /// </summary>
        public AttributeList SetAttributes(ObjectName name, AttributeList attributes) => IExecute<AttributeList>("setAttributes", name, attributes);
    }
}
