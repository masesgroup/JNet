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

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
#if JNETREFLECTOR
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Package.html"/>
    /// </summary>
    public sealed class Package : JVMBridgeBase<Package>
    {
        /// <inheritdoc/>
        public Package() { }
        /// <inheritdoc/>
        public Package(IJVMBridgeBaseInitializer initializer) : base(initializer) { }
        /// <inheritdoc />
        public override string BridgeClassName => "java.lang.Package";
        /// <summary>
        /// Returns this element's annotation for the specified type if such an annotation is present, else null.
        /// </summary>
        public A GetAnnotation<A>(Class<A> annotationClass) where A : Annotation.Annotation => IExecute< A>("getAnnotation", annotationClass);
        /// <summary>
        /// Returns annotations that are present on this element.
        /// </summary>
        public Annotation.Annotation[] Annotations => IExecuteArray<Annotation.Annotation>("getAnnotations");
        /// <summary>
        /// Returns annotations that are associated with this element.
        /// </summary>
        public A[] GetAnnotationsByType<A>(Class<A> annotationClass) where A : Annotation.Annotation => IExecuteArray<A>("getAnnotationsByType", annotationClass);
        /// <summary>
        /// Returns this element's annotation for the specified type if such an annotation is directly present, else null.
        /// </summary>
        public A GetDeclaredAnnotation<A>(Class<A> annotationClass) where A : Annotation.Annotation => IExecute<A>("getDeclaredAnnotation", annotationClass);
        /// <summary>
        /// Returns annotations that are directly present on this element.
        /// </summary>
        public Annotation.Annotation[] DeclaredAnnotations => IExecuteArray<Annotation.Annotation>("getDeclaredAnnotations");
        /// <summary>
        /// Returns this element's annotation(s) for the specified type if such annotations are either directly present or indirectly present.
        /// </summary>
        public A[] GetDeclaredAnnotationsByType<A>(Class<A> annotationClass) where A : Annotation.Annotation => IExecuteArray<A>("getDeclaredAnnotationsByType", annotationClass);
        /// <summary>
        /// Return the title of this package.
        /// </summary>
        public string ImplementationTitle => IExecute<string>("getImplementationTitle");
        /// <summary>
        /// Returns the name of the organization, vendor or company that provided this implementation.
        /// </summary>
        public string ImplementationVendor => IExecute<string>("getImplementationVendor");
        /// <summary>
        /// Return the version of this implementation.
        /// </summary>
        public string ImplementationVersion => IExecute<string>("getImplementationVersion");
        /// <summary>
        /// Return the name of this package.
        /// </summary>
        public string Name => IExecute<string>("getName");
        /// <summary>
        /// Find a package by name in the callers ClassLoader instance.
        /// </summary>
        public static Package GetPackage(string name) => SExecute<Package>("getPackage", name);
        /// <summary>
        /// Get all the packages currently known for the caller's ClassLoader instance.
        /// </summary>
        public static Package[] Packages => SExecuteArray<Package>("getPackages");
        /// <summary>
        /// Return the title of the specification that this package implements.
        /// </summary>
        public string SpecificationTitle => IExecute<string>("getSpecificationTitle");
        /// <summary>
        /// Return the name of the organization, vendor, or company that owns and maintains the specification of the classes that implement this package.
        /// </summary>
        public string SpecificationVendor => IExecute<string>("getSpecificationVendor");
        /// <summary>
        /// Returns the version number of the specification that this package implements.
        /// </summary>
        public string SpecificationVersion => IExecute<string>("getSpecificationVersion");
        /// <summary>
        /// Returns true if an annotation for the specified type is present on this element, else false.
        /// </summary>
        public bool IsAnnotationPresent(Class annotationClass) => IExecute<bool>("isAnnotationPresent", annotationClass);
        /// <summary>
        /// Compare this package's specification version with a desired version.
        /// </summary>
        public bool IsCompatibleWith(string desired) => IExecute<bool>("isCompatibleWith", desired);
        /// <summary>
        /// Returns true if this package is sealed.
        /// </summary>
        public bool IsSealed() => IExecute<bool>("isSealed");
    }
#endif
}
