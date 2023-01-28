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
using MASES.JNet;
using System.Management.Automation;
using System.Reflection;

namespace MASES.JNetPSCore.Cmdlet
{
    /// <summary>
    /// Base class to be extended in derived projects for all PS cmdlet which needs the core active
    /// </summary>
    public abstract class JNetPSCmdlet<TCore> : PSCmdlet
        where TCore : JNetCore<TCore>
    {
        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin of JNetPSCmdlet");
            WriteVerbose(MyInvocation.Line);
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected sealed override void ProcessRecord()
        {
            if (!JNetPSHelper<TCore>.InstanceCreated)
            {
                WriteWarning("Engine was not started, cannot execute the command");
                return;
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
            WriteVerbose("End of JNetPSCmdlet");
        }
    }
}
