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
using JavaX.Management.Loading;

namespace JavaX.Management
{
    public class MBeanServer : MBeanServerConnection
    {
        public override bool IsInterface => true;

        public override string ClassName => "javax.management.MBeanServer";
        /// <summary>
        /// Return the named ClassLoader.
        /// </summary>
        public ClassLoader GetClassLoader(ObjectName loaderName) => IExecute<ClassLoader>("getClassLoader", loaderName);
        /// <summary>
        /// Return the ClassLoader that was used for loading the class of the named MBean.
        /// </summary>
        public ClassLoader GetClassLoaderFor(ObjectName mbeanName) => IExecute<ClassLoader>("getClassLoaderFor", mbeanName);
        /// <summary>
        /// Return the ClassLoaderRepository for this MBeanServer.
        /// </summary>
        public ClassLoaderRepository ClassLoaderRepository => IExecute<ClassLoaderRepository>("getClassLoaderRepository");
        /// <summary>
        /// Instantiates an object using the list of all class loaders registered in the MBean server's Class Loader Repository.
        /// </summary>
        public object Instantiate(string className) => IExecute<object>("instantiate", className);
        /// <summary>
        /// Instantiates an object using the list of all class loaders registered in the MBean server Class Loader Repository.
        /// </summary>
        public object Instantiate(string className, object[] parameters, string[] signature) => IExecute<object>("instantiate", className, parameters, signature);
        /// <summary>
        /// Instantiates an object using the class Loader specified by its ObjectName.
        /// </summary>
        public object Instantiate(string className, ObjectName loaderName) => IExecute<object>("instantiate", className, loaderName);
        /// <summary>
        /// Instantiates an object.
        /// </summary>
        public object Instantiate(string className, ObjectName loaderName, object[] parameters, string[] signature) => IExecute<object>("instantiate", className, loaderName, parameters, signature);
        /// <summary>
        /// Registers a pre-existing object as an MBean with the MBean server.
        /// </summary>
        public ObjectInstance RegisterMBean(object o, ObjectName name) => IExecute<ObjectInstance>("registerMBean", o, name);
    }
}
