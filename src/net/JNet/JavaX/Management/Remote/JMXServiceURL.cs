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

namespace JavaX.Management.Remote
{
    public class JMXServiceURL : JVMBridgeBase<JMXServiceURL>
    {
        public override string ClassName => "javax.management.remote.JMXServiceURL";

        public JMXServiceURL() { }
        /// <summary>
        /// Constructs a <see cref="JMXServiceURL"/> by parsing a Service URL string.
        /// </summary>
        public JMXServiceURL(string serviceURL) : base(serviceURL) { }
        /// <summary>
        /// Constructs a <see cref="JMXServiceURL"/> with the given protocol, host, and port.
        /// </summary>
        public JMXServiceURL(string protocol, string host, int port) : base(protocol, host, port) { }
        /// <summary>
        /// Constructs a <see cref="JMXServiceURL"/> with the given parts.
        /// </summary>
        public JMXServiceURL(string protocol, string host, int port, string urlPath) : base(protocol, host, port, urlPath) { }
        /// <summary>
        /// The host part of the Service URL.
        /// </summary>
        public string Host => IExecute<string>("getHost");
        /// <summary>
        /// The port of the Service URL.
        /// </summary>
        public int Port => IExecute<int>("getPort");
        /// <summary>
        /// The protocol part of the Service URL.
        /// </summary>
        public string Protocol => IExecute<string>("getProtocol");
        /// <summary>
        /// The URL Path part of the Service URL.
        /// </summary>
        public string URLPath => IExecute<string>("getURLPath");
    }
}
