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

using MASES.JNet;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace MASES.JNet.PowerShell.Cmdlet
{
    public abstract class NewObjectCmdletCommandBase<TCmdlet, TCore> : JNetPSCmdlet<TCore>
        where TCmdlet : NewObjectCmdletCommandBase<TCmdlet, TCore>
        where TCore : JNetCore<TCore>
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The java class name to be initialized")]
        public string Class { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The constructor arguments to be used")]
        public object[] Arguments { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            object[] args = JNetPSHelper.ConvertArguments(Arguments).ToArray();
            var result = JNetPSHelper<TCore>.New(Class, args);
            WriteObject(result);
        }
    }
}
