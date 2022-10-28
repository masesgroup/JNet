/*
*  Copyright 2022 MASES s.r.l.
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
using System.Collections.Generic;
using System.Management.Automation;
using System.Reflection;

namespace MASES.JNetPSCore.Cmdlet
{
    public abstract class NewObjectCmdletCommandBase<T> : PSCmdlet
        where T : JNetCore<T>
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The java class name to be initialized")]
        public string Class { get; set; }

        [Parameter(
            Position = 1,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The constructor arguments to be used")]
        public object[] Arguments { get; set; }

        private static readonly MethodInfo NewMethod = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetMethod(nameof(JNetCore.New), new System.Type[] { typeof(string), typeof(object[])});

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            object[] args = Arguments;
            if (Arguments != null)
            {
                List<object> objects = new List<object>();
                foreach (var item in Arguments)
                {
                    if (item is PSObject psObject)
                    {
                        objects.Add(psObject.BaseObject);
                    }
                    else
                    {
                        objects.Add(item);
                    }
                }
                args = objects.ToArray();
            }

            var result = NewMethod.Invoke(null, new object[] { Class, args });
            WriteObject(result);
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
