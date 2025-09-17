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
#if JNETREFLECTOR
//using Java.Io;
//using Java.Net;
using Java.Util;
using MASES.JCOBridge.C2JBridge;
using System.Xml.Linq;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/ClassLoader.html"/>
    /// </summary>
    public class ClassLoader : JVMBridgeBase<ClassLoader>
    {
        /// <inheritdoc />
        public override string BridgeClassName => "java.lang.ClassLoader";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ClassLoader() { }
        /// <inheritdoc/>
        public ClassLoader(IJVMBridgeBaseInitializer initializer) : base(initializer) { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ClassLoader(params object[] args) : base(args) { }
#if !JNETREFLECTOR
        /// <summary>
        /// Sets the default assertion status for this class loader to false and discards any package defaults or class assertion status settings associated with the class loader.
        /// </summary>
        public void ClearAssertionStatus() => IExecute("clearAssertionStatus");
        /// <summary>
        /// Returns the parent class loader for delegation.
        /// </summary>
        public ClassLoader Parent => IExecute<ClassLoader>("getParent");
        /// <summary>
        /// Finds the resource with the given name.
        /// </summary>
        public URL GetResource(string name) => IExecute<URL>("getResource", name);
        /// <summary>
        /// Returns an input stream for reading the specified resource.
        /// </summary>
        public InputStream GetResourceAsStream(string name) => IExecute<InputStream>("getResourceAsStream", name);
        /// <summary>
        /// Finds all the resources with the given name.
        /// </summary>
        public Enumeration<URL> GetResources(string name) => IExecute<Enumeration<URL>>("getResources", name);
#endif
        /// <summary>
        /// Returns the system class loader for delegation.
        /// </summary>
        public static ClassLoader SystemClassLoader => SExecute<ClassLoader>("getSystemClassLoader");
#if !JNETREFLECTOR
        /// <summary>
        /// Find a resource of the specified name from the search path used to load classes.
        /// </summary>
        public static URL GetSystemResource(string name) => SExecute<URL>("getSystemResource", name);
        /// <summary>
        /// Open for reading, a resource of the specified name from the search path used to load classes.
        /// </summary>
        public static InputStream GetSystemResourceAsStream(string name) => SExecute<InputStream>("getSystemResourceAsStream", name);
        /// <summary>
        /// Finds all resources of the specified name from the search path used to load classes.
        /// </summary>
        public static Enumeration<URL> GetSystemResources(string name) => SExecute<Enumeration<URL>>("getSystemResources", name);
        /// <summary>
        /// Loads the class with the specified binary name.
        /// </summary>
        public Class LoadClass(string name) => IExecute<Class>("loadClass", name);
        /// <summary>
        /// Sets the desired assertion status for the named top-level class in this class loader and any nested classes contained therein.
        /// </summary>
        public void SetClassAssertionStatus(string className, bool enabled) => IExecute<Class>("setClassAssertionStatus", className, enabled);
        /// <summary>
        /// Sets the default assertion status for this class loader.
        /// </summary>
        public void SetDefaultAssertionStatus(bool enabled) => IExecute<Class>("setDefaultAssertionStatus", enabled);
        /// <summary>
        /// Sets the package default assertion status for the named package.
        /// </summary>
        public void SetPackageAssertionStatus(string packageName, bool enabled) => IExecute<Class>("setDefaultAssertionStatus", packageName, enabled);
#endif
    }
}
#endif
