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

namespace Javax.Management
{
    public class ObjectInstance : JVMBridgeBase<ObjectInstance>
    {
        public override string ClassName => "javax.management.ObjectInstance";

        public ObjectInstance() { }

        protected ObjectInstance(params object[] args) : base(args) { }
        /// <summary>
        /// Allows an object instance to be created given a string representation of an object name and the full class name, including the package name.
        /// </summary>
        public ObjectInstance(string objectName, string className) : base(objectName, className) { }
        /// <summary>
        /// Allows an object instance to be created given an object name and the full class name, including the package name.
        /// </summary>
        public ObjectInstance(ObjectName objectName, string className) :base(objectName, className) { }
        /// <summary>
        /// Returns the class part.
        /// </summary>
        public string ClassNameJMX => IExecute<string>("getClassName");
        /// <summary>
        /// Returns the object name part.
        /// </summary>
        public ObjectName ObjectName => IExecute<ObjectName>("getObjectName");
    }
}
