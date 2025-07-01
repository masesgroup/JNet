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
using MASES.JNet.Specific;
using System;
using System.Management.Automation;

namespace MASES.JNet.PowerShell.Cmdlet
{
    public abstract class InvokeCommandCmdletCommandBase<TCmdlet, TCore> : StartJNetPSCmdletCommandBase<TCmdlet, TCore>
        where TCmdlet : InvokeCommandCmdletCommandBase<TCmdlet, TCore>
        where TCore : JNetCore<TCore>
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The java Main-Class name to be launched")]
        public string MainClass { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Main-Class arguments to be used. Put them within a single string.")]
        public string Arguments { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void OnAfterCreateGlobalInstance()
        {
            string[] arguments = Array.Empty<string>();
            if (Arguments != null)
            {
                arguments = Arguments.Split(' ');
            }

            GenericCommand.CreateAndLaunch(MainClass, arguments);
        }
    }
}
