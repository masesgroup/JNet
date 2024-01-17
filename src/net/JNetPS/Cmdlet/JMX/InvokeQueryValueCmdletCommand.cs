/*
*  Copyright 2024 MASES s.r.l.
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
using MASES.JNetPSCore.Cmdlet;
using System;
using System.Management.Automation;

namespace MASES.JNetPS.Cmdlet.JMX
{
    [Cmdlet(VerbsLifecycle.Invoke, "QueryValue")]
    [OutputType(typeof(ValueExp))]
    public class InvokeQueryValueCmdletCommand : JNetPSCmdlet<JNetPSCore>
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The input to be used to create a ValueExp.")]
        public object Value { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            if (Value is PSObject psVal) ExecOnObject(psVal.BaseObject);
            else ExecOnObject(Value);
        }

        void ExecOnObject(object obj)
        {
            ValueExp result;
            if (obj is bool boolean) result = Query.Value(boolean);
            else if (obj is double @double) result = Query.Value(@double);
            else if (obj is float single) result = Query.Value(single);
            else if (obj is int int1) result = Query.Value(int1);
            else if (obj is long @int) result = Query.Value(@int);
            else if (obj is Java.Lang.Number) result = Query.Value(obj as Java.Lang.Number);
            else if (obj is string) result = Query.Value(obj as string);
            else throw new ArgumentException("Input does not have a valid type", "Value");

            WriteObject(result);
        }
    }
}
