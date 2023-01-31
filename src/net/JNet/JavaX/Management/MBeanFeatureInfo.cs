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
    public class MBeanFeatureInfo : JVMBridgeBase<MBeanFeatureInfo>
    {
        public override string ClassName => "javax.management.MBeanFeatureInfo";

        public MBeanFeatureInfo() { }

        protected MBeanFeatureInfo(params object[] args) : base(args) { }
        /// <summary>
        /// Constructs an <see cref="MBeanFeatureInfo"/> object.
        /// </summary>
        public MBeanFeatureInfo(string name, string description) : base(name, description) { }
        /// <summary>
        /// Constructs an <see cref="MBeanFeatureInfo"/> object.
        /// </summary>
        public MBeanFeatureInfo(string name, string description, Descriptor descriptor) : base(name, description, descriptor) { }
        /// <summary>
        /// Returns the human-readable description of the feature.
        /// </summary>
        public string Description => IExecute<string>("getDescription");
        /// <summary>
        /// Returns the descriptor for the feature.
        /// </summary>
        public Descriptor Descriptor => IExecute<Descriptor>("getDescriptor");
        /// <summary>
        /// Returns a <see cref="string"/> containing the name of the attribute.
        /// </summary>
        public string Name => IExecute<string>("getName");
    }
}
