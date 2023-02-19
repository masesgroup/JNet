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

using Java.Lang;
using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Loading
{
    public class ClassLoaderRepository : JVMBridgeBase<ClassLoaderRepository>
    {
        public override bool IsInterface => true;
        public override string ClassName => "javax.management.loading.ClassLoaderRepository";
        /// <summary>
        /// Load the given class name through the list of class loaders.
        /// </summary>
        public Class LoadClass(string className) => IExecute<Class>("loadClass", className);
        /// <summary>
        /// Load the given class name through the list of class loaders, stopping at the given one.
        /// </summary>
        public Class LoadClassBefore(ClassLoader stop, string className) => IExecute<Class>("loadClassBefore", stop, className);
        /// <summary>
        /// Load the given class name through the list of class loaders, excluding the given one.
        /// </summary>
        public Class LoadClassWithout(ClassLoader exclude, string className) => IExecute<Class>("loadClassWithout", exclude, className);
    }
}
