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

using JavaX.Management;
using MASES.JNetPSCore.Cmdlet;
using System.Management.Automation;

namespace MASES.JNetPS.Cmdlet.JMX
{
    [Cmdlet(VerbsLifecycle.Invoke, "QueryOr")]
    public class InvokeQueryOrCmdletCommand : JNetPSCmdlet<JNetPSCore>
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "A query expression.")]
        public QueryExp Q1 { get; set; }

        [Parameter(
            Position = 1,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Another query expression.")]
        public QueryExp Q2 { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            QueryExp result = Query.Or(Q1, Q2);

            WriteObject(result);
        }
    }
}
