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

using Javax.Management;
using Javax.Management.Monitor;
using Javax.Management.Relation;
using Javax.Management.Remote;
using Javax.Management.Timer;
using MASES.JCOBridge.C2JBridge;
using MASES.JNetPSCore.Cmdlet;
using System;
using System.Management.Automation;

namespace MASES.JNetPS.Cmdlet.JMX
{
    [Cmdlet(VerbsCommon.New, "NotificationListener")]
    [OutputType(typeof(NotificationListener))]
    public class NewNotificationListenerCmdletCommand : JNetPSCmdlet<JNetPSCore>
    {
        [Parameter(
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Notification handler.")]
        public Action<Notification, object> Handler { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            NotificationListener listener = new NotificationListener() { OnHandleNotification = Handler ?? NotificationHandler };
            WriteObject(listener);
        }

        void NotificationHandler(Notification notification, object handback)
        {
            if (notification.IsInstanceOf<AttributeChangeNotification>())
            {
                WriteDebug("AttributeChangeNotification");

                AttributeChangeNotification a = notification.Cast<AttributeChangeNotification>();
            }
            else if (notification.IsInstanceOf<MBeanServerNotification>())
            {
                WriteDebug("MBeanServerNotification");

                MBeanServerNotification a = notification.Cast<MBeanServerNotification>();
            }
            else if (notification.IsInstanceOf<JMXConnectionNotification>())
            {
                WriteDebug("JMXConnectionNotification");

                JMXConnectionNotification a = notification.Cast<JMXConnectionNotification>();
            }
            else if (notification.IsInstanceOf<MonitorNotification>())
            {
                WriteDebug("MonitorNotification");

                MonitorNotification a = notification.Cast<MonitorNotification>();

            }
            else if (notification.IsInstanceOf<RelationNotification>())
            {
                WriteDebug("RelationNotification");

                RelationNotification a = notification.Cast<RelationNotification>();
            }
            else if (notification.IsInstanceOf<TimerNotification>())
            {
                WriteDebug("TimerNotification");

                TimerNotification a = notification.Cast<TimerNotification>();
            }

        }
    }
}
