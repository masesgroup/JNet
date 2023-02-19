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
using Javax.Management.Remote;
using MASES.JNet.Extensions;
using MASES.JNetPSCore.Cmdlet;
using System.Collections.Generic;
using System.Management.Automation;

namespace MASES.JNetPS.Cmdlet.JMX
{
    [Cmdlet(VerbsCommon.Get, "JMXConnector")]
    [OutputType(typeof(JMXConnector))]
    public class GetJMXConnectorCmdletCommand : JNetPSCmdlet<JNetPSCore>
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The address of the connector server to connect to.")]
        public JMXServiceURL ServiceURL { get; set; }

        [Parameter(
            Position = 1,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "A set of attributes to determine how the connection is made. This parameter can be null. Keys in this map must be Strings. The appropriate type of each associated value depends on the attribute. The contents of environment are not changed by this call.")]
        public IDictionary<string, object> Environment { get; set; }

        [Parameter(
            Position = 2,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Use method NewJMXConnector to create a JMXConnector.")]
        public SwitchParameter UseNewJMXConnector { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            JMXConnector result;
            if (UseNewJMXConnector.IsPresent)
            {
                result = JMXConnectorFactory.NewJMXConnector(ServiceURL, Environment != null ? Environment.ToMap() : Collections.EmptyMap<string, object>());
            }
            else
            {
                if (Environment == null)
                {
                    result = JMXConnectorFactory.Connect(ServiceURL);
                }
                else
                {
                    result = JMXConnectorFactory.Connect(ServiceURL, Environment.ToMap());
                }
            }

            WriteObject(result);
        }
    }
}
