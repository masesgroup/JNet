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

namespace JavaX.Management
{
    public class Descriptor : JVMBridgeBase<Descriptor>
    {
        public override bool IsInterface => true;

        public override string ClassName => "javax.management.Descriptor";
        /// <summary>
        /// Returns all the field names in the descriptor.
        /// </summary>
        public string[] FieldNames => IExecuteArray<string>("getFieldNames");
        /// <summary>
        /// Returns all of the fields contained in this descriptor as a string array.
        /// </summary>
        public string[] Fields => IExecuteArray<string>("getFields");
        /// <summary>
        /// Returns the value for a specific field name, or null if no value is present for that name.
        /// </summary>
        public object GetFieldValue(string fieldName) => IExecute("getFieldValue", fieldName);
        /// <summary>
        /// Returns all the field values in the descriptor as an array of Objects.
        /// </summary>
        public object[] GetFieldValues(params string[] fieldNames) => fieldNames.Length == 0 ? IExecuteArray<object>("getFieldValues") : IExecuteArray<object>("getFieldValues", fieldNames);
        /// <summary>
        /// Returns true if all of the fields have legal values given their names.
        /// </summary>
        public bool IsValid => IExecute<bool>("isValid");
        /// <summary>
        /// Removes a field from the descriptor.
        /// </summary>
        public void RemoveField(string fieldName) => IExecute("removeField", fieldName);
        /// <summary>
        /// Sets the value for a specific field name.
        /// </summary>
        public void SetField(string fieldName, object fieldValue) => IExecute("setField", fieldName, fieldValue);
        /// <summary>
        /// Sets all fields in the field names array to the new value with the same index in the field values array.
        /// </summary>
        public void SetFields(string[] fieldNames, object[] fieldValues) => IExecute("setFields", fieldNames, fieldValues);
    }
}
