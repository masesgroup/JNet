/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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
using Javax.Management;
using MASES.JCOBridge.C2JBridge;
using MASES.JNet.Specific.Extensions;
using MASES.JNet.PowerShell.Cmdlet;
using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace MASES.JNet.PowerShell.Cmdlet.JMX
{
    [Cmdlet(VerbsCommon.New, "ObjectName")]
    [OutputType(typeof(ObjectName))]
    public class NewObjectNameCmdletCommand : JNetPSCmdlet<JNetPSCore>
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "A string representation of the object name or the domain part of the object name.")]
        public string NameOrDomain { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The attribute in the key property of the object name.")]
        public string Key { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The value in the key property of the object name.")]
        public string Value { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "A hash table containing one or more key properties. The key of each entry in the table is the key of a key property in the object name. The associated value in the table is the associated value in the object name.")]
        public IDictionary<string, string> Table { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Apply the quote on name.")]
        public SwitchParameter ApplyQuote { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            ObjectName result;
            if (Key == null && Table == null)
            {
                var name = NameOrDomain;
                if (ApplyQuote.IsPresent) name = ObjectName.Quote(name);
                result = new ObjectName(name);
            }
            else if (Key != null)
            {
                if (Value == null) throw new ArgumentException("If Key is set, Value must be set too.", "Value");
                result = new ObjectName(NameOrDomain, Key, Value);
            }
            else if (Table != null)
            {
                result = new ObjectName(NameOrDomain, Table.ToJVMDictionary<Hashtable<Java.Lang.String, Java.Lang.String>, Java.Lang.String, Java.Lang.String, string, string>());
            }
            else throw new InvalidOperationException("Never been here.");

            WriteObject(result);
        }
    }
}
