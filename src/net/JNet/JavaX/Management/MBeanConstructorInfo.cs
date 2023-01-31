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

namespace JavaX.Management
{
    public class MBeanConstructorInfo : MBeanFeatureInfo
    {
        public override string ClassName => "javax.management.MBeanConstructorInfo";

        public MBeanConstructorInfo() { }

        protected MBeanConstructorInfo(params object[] args) : base(args) { }
        /// <summary>
        /// Constructs an <see cref="MBeanConstructorInfo"/> object.
        /// </summary>
        public MBeanConstructorInfo(string description, Java.Lang.Reflect.Constructor constructor)
            : base(description, constructor) { }
        /// <summary>
        /// Constructs an <see cref="MBeanConstructorInfo"/> object.
        /// </summary>
        public MBeanConstructorInfo(string name, string description, MBeanParameterInfo[] signature)
            : base(name, description, signature) { }
        /// <summary>
        /// Constructs an <see cref="MBeanConstructorInfo"/> object.
        /// </summary>
        public MBeanConstructorInfo(string name, string description, MBeanParameterInfo[] signature, Descriptor descriptor)
            : base(name, description, signature, descriptor) { }
        /// <summary>
        /// Returns the list of parameters for this constructor.
        /// </summary>
        public MBeanParameterInfo[] Signature => IExecuteArray<MBeanParameterInfo>("getSignature");
    }
}
