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

namespace Javax.Management
{
    public class MBeanAttributeInfo : MBeanFeatureInfo
    {
        public override string ClassName => "javax.management.MBeanAttributeInfo";

        public MBeanAttributeInfo() { }

        protected MBeanAttributeInfo(params object[] args) : base(args) { }
        /// <summary>
        /// This constructor takes the name of a simple attribute, and Method objects for reading and writing the attribute.
        /// </summary>
        public MBeanAttributeInfo(string name, string description, Java.Lang.Reflect.Method getter, Java.Lang.Reflect.Method setter)
            : base(name, description, getter, setter) { }

        /// <summary>
        /// Constructs an <see cref="MBeanAttributeInfo"/> object.
        /// </summary>
        public MBeanAttributeInfo(string name, string type, string description, bool isReadable, bool isWritable, bool isIs)
            : base(name, type, description, isReadable, isWritable, isIs) { }
        /// <summary>
        /// Constructs an <see cref="MBeanAttributeInfo"/> object.
        /// </summary>
        public MBeanAttributeInfo(string name, string type, string description, bool isReadable, bool isWritable, bool isIs, Descriptor descriptor)
            : base(name, type, description, isReadable, isWritable, isIs, descriptor) { }
        /// <summary>
        /// Returns the class name of the attribute.
        /// </summary>
        public string Type => IExecute<string>("getType");
        /// <summary>
        /// Indicates if this attribute has an "is" getter.
        /// </summary>
        public bool IsIs => IExecute<bool>("isIs");
        /// <summary>
        /// Whether the value of the attribute can be read.
        /// </summary>
        public bool IsReadable => IExecute<bool>("isReadable");
        /// <summary>
        /// Whether new values can be written to the attribute.
        /// </summary>
        public bool IsWritable => IExecute<bool>("isWritable");
    }
}
