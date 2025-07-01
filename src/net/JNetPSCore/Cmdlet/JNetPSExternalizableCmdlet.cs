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

using MASES.JCOBridge.C2JBridge;
using System;
using System.Management.Automation;
using System.Reflection;

namespace MASES.JNet.PowerShell.Cmdlet
{
    /// <summary>
    /// Set to indicate the class need to run externally
    /// </summary>
    public class JNetPSExternalize : Attribute
    {
    }

    /// <summary>
    /// Base class to be extended in derived projects to execute externally
    /// </summary>
    public abstract class JNetPSExternalizableCmdlet<T> : PSCmdlet
        where T : JNetPSExternalizableCmdlet<T>
    {
        /// <summary>
        /// Used internally
        /// </summary>
        [Parameter(DontShow = true, ValueFromPipelineByPropertyName = true)]
        public SwitchParameter JNetPSCmdletDetached { get; set; }

        /// <summary>
        /// Permit to bypass the <see cref="JNetPSExternalize"/> attribute
        /// </summary>
        [Parameter(DontShow = true, ValueFromPipelineByPropertyName = true)]
        public SwitchParameter BypassJNetPSExternalize { get; set; }

        /// <summary>
        /// Force the external execution even if the <see cref="JNetPSExternalize"/> attribute was not defined
        /// </summary>
        [Parameter(DontShow = true, ValueFromPipelineByPropertyName = true)]
        public SwitchParameter ForceJNetPSExternalize { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin of JNetPSExternalizableCmdlet");
            WriteVerbose(MyInvocation.Line);
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected sealed override void ProcessRecord()
        {
            if (ForceJNetPSExternalize.IsPresent || (!BypassJNetPSExternalize.IsPresent && JNetPSHelper.NeedExternalProcess<T>()))
            {
                if (!this.IsExternal()) { this.InvokeExternal(); return; }
            }
            try
            {
                ProcessCommand();
            }
            catch (TargetInvocationException tie)
            {
                this.WriteExtendedError(tie.InnerException);
            }
            catch (JCOBridge.C2JBridge.JVMInterop.JavaException je)
            {
                var newEx = je.Convert();
                this.WriteExtendedError(newEx);
            }
            catch (JVMBridgeException je)
            {
                this.WriteExtendedError(je);
            }
        }

        protected abstract void ProcessCommand();

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End of JNetPSExternalizableCmdlet");
        }
    }
}
