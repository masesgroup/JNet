/*
*  Copyright 2025 MASES s.r.l.
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

using Javax.Management.Remote;
using MASES.JNetPSCore.Cmdlet;
using System;
using System.Management.Automation;

namespace MASES.JNetPS.Cmdlet.JMX
{
    [Cmdlet(VerbsCommon.New, "JMXServiceURL")]
    [OutputType(typeof(JMXServiceURL))]
    public class NewJMXServiceURLCmdletCommand : JNetPSCmdlet<JNetPSCore>
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The URL string to be parsed or the protocol part of the URL. If null, defaults to jmxmp.")]
        public string ServiceURLOrProtocol { get; set; }

        [Parameter(
            Position = 1,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The host part of the URL. If null, defaults to the local host name, as determined by InetAddress.getLocalHost().getHostName(). If it is a numeric IPv6 address, it can optionally be enclosed in square brackets [].")]
        public string HostName { get; set; }

        [Parameter(
            Position = 2,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The port part of the URL.")]
        public int? Port { get; set; }

        [Parameter(
            Position = 3,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The URL path part of the URL. If null, defaults to the empty string.")]
        public string UrlPath { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            JMXServiceURL result;
            if (HostName == null)
            {
                result = new JMXServiceURL(ServiceURLOrProtocol);
            }
            else
            {
                if (!Port.HasValue) throw new ArgumentException("If HostName is set, Port must be set too.", "Port");
                if (UrlPath != null)
                {
                    result = new JMXServiceURL(ServiceURLOrProtocol, HostName, Port.Value, UrlPath);
                }
                else
                {
                    result = new JMXServiceURL(ServiceURLOrProtocol, HostName, Port.Value);
                }
            }

            WriteObject(result);
        }
    }
}
