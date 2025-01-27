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

using Java.Lang;
using Javax.Management;
using Javax.Management.Remote;
using MASES.JNetPSCore.Cmdlet;
using System;
using System.Management.Automation;

namespace MASES.JNetPS.Cmdlet.JMX
{
    [Cmdlet(VerbsCommon.New, "MXBeanProxy")]
    public class NewMXBeanProxyCmdletCommand : JNetPSCmdlet<JNetPSCore>
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The connection to use.")]
        public JMXConnector Connector { get; set; }

        [Parameter(
            Position = 1,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The name of the MBean within connection to forward to.")]
        public ObjectName ObjectName { get; set; }

        [Parameter(
            Position = 2,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The management interface that the MBean exports, which will also be implemented by the returned proxy.")]
        public Class Class { get; set; }

        [Parameter(
            Position = 3,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The management interface that the MBean exports, which will also be implemented by the returned proxy.")]
        public string InterfaceName { get; set; }

        [Parameter(
            Position = 4,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Make the returned proxy implement NotificationEmitter by forwarding its methods via connection.")]
        public SwitchParameter WithNotificationEmitter { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            object result;
            if (Class != null)
            {
                if (WithNotificationEmitter.IsPresent)
                {
                    result = Javax.Management.JMX.NewMXBeanProxy(Connector.MBeanServerConnection, ObjectName, Class, true);
                }
                else
                {
                    result = Javax.Management.JMX.NewMXBeanProxy(Connector.MBeanServerConnection, ObjectName, Class);
                }
            }
            else if (InterfaceName != null)
            {
                if (WithNotificationEmitter.IsPresent)
                {
                    result = Javax.Management.JMX.NewMXBeanProxy(Connector.MBeanServerConnection, ObjectName, Java.Lang.Class.ForName(InterfaceName), true);
                }
                else
                {
                    result = Javax.Management.JMX.NewMXBeanProxy(Connector.MBeanServerConnection, ObjectName, Java.Lang.Class.ForName(InterfaceName));
                }
            }
            else throw new ArgumentException("Class or InterfaceName shall be set.");

            WriteObject(result);
        }
    }
}
