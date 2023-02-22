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
#if !JNETREFLECTOR
using Java.Io;
using Java.Util;
#endif
using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html"/>
    /// </summary>
    public sealed class Module : JVMBridgeBase<Module>
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.Module";
        /// <summary>
        /// If the caller's module is this module then update this module to export the given package to the given module.
        /// </summary>
        public Module AddExports​(string pn, Module other) => IExecute<Module>("addExports​", pn, other);
        /// <summary>
        /// If this module has opened a package to at least the caller module then update this module to open the package to the given module.
        /// </summary>
        public Module AddOpens​(string pn, Module other) => IExecute<Module>("addOpens​​", pn, other);
        /// <summary>
        /// If the caller's module is this module then update this module to read the given module.
        /// </summary>
        public Module AddReads​(Module other) => IExecute<Module>("addReads​​​", other);
        /// <summary>
        /// If the caller's module is this module then update this module to add a service dependence on the given service type.
        /// </summary>
        public Module AddUses​(Class service) => IExecute<Module>("addUses​​​​", service);
        /// <summary>
        /// Indicates if this module reads the given module.
        /// </summary>
        public bool CanRead​(Module other) => IExecute<bool>("canRead​​​​​", other);
        /// <summary>
        /// Indicates if this module has a service dependence on the given service type.
        /// </summary>
        public bool CanUse​(Class service) => IExecute<bool>("canUse​​​​​​", service);
        /// <summary>
        /// Returns this element's annotation for the specified type if such an annotation is present, else null.
        /// </summary>
        public T GetAnnotation​<T>(Class<T> annotationClass) where T : Annotation.Annotation => IExecute<T>("getAnnotation​​​​​​​", annotationClass);
        /// <summary>
        /// Returns annotations that are present on this element.
        /// </summary>
        /// <returns></returns>
        public Annotation.Annotation[] Annotations => IExecuteArray<Annotation.Annotation>("getAnnotations");
        /// <summary>
        /// Returns the ClassLoader for this module.
        /// </summary>
        public ClassLoader ClassLoader => IExecute<ClassLoader>("getClassLoader​​​​​​");
        /// <summary>
        /// Returns annotations that are directly present on this element.
        /// </summary>
        public Annotation.Annotation[] DeclaredAnnotations => IExecuteArray<Annotation.Annotation>("getDeclaredAnnotations");
#if !JNETREFLECTOR
        /// <summary>
        /// Returns the module descriptor for this module or null if this module is an unnamed module.
        /// </summary>
        public Lang.ModuleNs.ModuleDescriptor Descriptor => IExecute<Lang.ModuleNs.ModuleDescriptor>("getDescriptor​​​​​​");
        /// <summary>
        /// Returns the module layer that contains this module or null if this module is not in a module layer.
        /// </summary>
        public ModuleLayer Layer => IExecute<ModuleLayer>("getLayer​​​​​​");
#endif
        /// <summary>
        /// Returns the module name or null if this module is an unnamed module.
        /// </summary>
        public string Name => IExecute<string>("getName​​​​​​");
#if !JNETREFLECTOR
        /// <summary>
        /// Returns the set of package names for the packages in this module.
        /// </summary>
        public Set<string> Packages => IExecute<Set<string>>("getPackages​​​​​​");
        /// <summary>
        /// Returns an input stream for reading a resource in this module.
        /// </summary>
        public InputStream GetResourceAsStream​(string name) => IExecute<InputStream>("getResourceAsStream​​​​​​​", name);
#endif
        /// <summary>
        /// Returns true if this module exports the given package unconditionally.
        /// </summary>
        public bool IsExported​(string pn) => IExecute<bool>("isExported​​​​​​", pn);
        /// <summary>
        /// Returns true if this module exports the given package to at least the given module.
        /// </summary>
        public bool IsExported​(string pn, Module other) => IExecute<bool>("isExported​​​​​​", pn, other);
        /// <summary>
        /// Returns true if this module is a named module.
        /// </summary>
        public bool IsNamed => IExecute<bool>("isNamed​​​");
        /// <summary>
        /// Returns true if this module has opened a package unconditionally.
        /// </summary>
        public bool IsOpen​(string pn) => IExecute<bool>("isOpen​​​​​​​", pn);
        /// <summary>
        /// Returns true if this module has opened a package to at least the given module.
        /// </summary>
        public bool IsOpen​(string pn, Module other) => IExecute<bool>("isOpen​​​​​​​", pn, other);
    }
}
