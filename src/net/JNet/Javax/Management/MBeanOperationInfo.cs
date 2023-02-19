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
    public class MBeanOperationInfo : MBeanFeatureInfo
    {
        public override string ClassName => "javax.management.MBeanOperationInfo";

        public MBeanOperationInfo() { }

        protected MBeanOperationInfo(params object[] args) : base(args) { }
        /// <summary>
        /// Constructs an <see cref="MBeanOperationInfo"/> object.
        /// </summary>
        public MBeanOperationInfo(string description, Java.Lang.Reflect.Method method) : base(description, method) { }
        /// <summary>
        /// Constructs an <see cref="MBeanOperationInfo"/> object.
        /// </summary>
        public MBeanOperationInfo(string name, string description, MBeanParameterInfo[] signature, string type, int impact)
            : base(name, description, signature, type, impact) { }
        /// <summary>
        /// Constructs an <see cref="MBeanOperationInfo"/> object.
        /// </summary>
        public MBeanOperationInfo(string name, string description, MBeanParameterInfo[] signature, string type, int impact, Descriptor descriptor)
            : base(name, description, signature, type, impact, descriptor) { }

        /// <summary>
        /// Indicates that the operation is write-like: it has an effect but does not return any information from the MBean.
        /// </summary>
        public static int ACTION => Clazz.GetField<int>("ACTION");
        /// <summary>
        /// Indicates that the operation is both read-like and write-like: it has an effect, and it also returns information from the MBean.
        /// </summary>
        public static int ACTION_INFO => Clazz.GetField<int>("ACTION_INFO");
        /// <summary>
        /// Indicates that the operation is read-like: it returns information but does not change any state.
        /// </summary>
        public static int INFO => Clazz.GetField<int>("INFO");
        /// <summary>
        /// Indicates that the impact of the operation is unknown or cannot be expressed using one of the other values.
        /// </summary>
        public static int UNKNOWN => Clazz.GetField<int>("UNKNOWN");
        /// <summary>
        /// Returns the impact of the method, one of <see cref="INFO"/>, <see cref="ACTION"/>, <see cref="ACTION_INFO"/>, <see cref="UNKNOWN"/>.
        /// </summary>
        public int Impact => IExecute<int>("getImpact");
        /// <summary>
        /// Returns the type of the method's return value.
        /// </summary>
        public string ReturnType => IExecute<string>("getReturnType");
        /// <summary>
        /// Returns the list of parameters for this constructor.
        /// </summary>
        public MBeanParameterInfo[] Signature => IExecuteArray<MBeanParameterInfo>("getSignature");
    }
}
