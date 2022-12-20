﻿/*
*  Copyright 2022 MASES s.r.l.
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
using MASES.JNet;

namespace Java.Lang.Reflect
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/AccessibleObject.html"/>
    /// </summary>
    public class AccessibleObject : JVMBridgeBase<AccessibleObject>
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.reflect.AccessibleObject";
        /// <summary>
        /// Returns this element's annotation for the specified type if such an annotation is present, else null.
        /// </summary>
        public T GetAnnotation<T>(Class<T> annotationClass) where T : Annotation.Annotation => IExecute<T>("getAnnotation", annotationClass);
        /// <summary>
        /// Returns annotations that are present on this element.
        /// </summary>
        public Annotation.Annotation[] Annotations => this.IExecuteArray<Annotation.Annotation>("getAnnotations");
        /// <summary>
        /// Returns annotations that are associated with this element.
        /// </summary>
        public T[] GetAnnotationsByType<T>(Class<T> annotationClass) where T : Annotation.Annotation => this.IExecuteArray<T>("getAnnotationsByType", annotationClass);
        /// <summary>
        /// Returns this element's annotation for the specified type if such an annotation is directly present, else null.
        /// </summary>
        public T GetDeclaredAnnotation<T>(Class<T> annotationClass) where T : Annotation.Annotation => IExecute<T>("getDeclaredAnnotation", annotationClass);
        /// <summary>
        /// Returns annotations that are directly present on this element.
        /// </summary>
        public Annotation.Annotation[] DeclaredAnnotations => this.IExecuteArray<Annotation.Annotation>("getDeclaredAnnotations");
        /// <summary>
        /// Returns this element's annotation(s) for the specified type if such annotations are either directly present or indirectly present.
        /// </summary>
        public T[] GetDeclaredAnnotationsByType<T>(Class<T> annotationClass) where T : Annotation.Annotation => this.IExecuteArray<T>("getDeclaredAnnotationsByType", annotationClass);
        /// <summary>
        /// Get the value of the accessible flag for this object.
        /// </summary>
        public bool IsAccessible => IExecute<bool>("isAccessible");
        /// <summary>
        /// Returns <see langword="true"/> if an annotation for the specified type is present on this element, else <see langword="false"/>.
        /// </summary>
        public bool IsAnnotationPresent<T>(Class<T> annotationClass) where T : Annotation.Annotation => IExecute<bool>("isAnnotationPresent", annotationClass);
        /// <summary>
        /// Convenience method to set the accessible flag for an array of objects with a single security check(for efficiency).
        /// </summary>
        public static void SetAccessible(AccessibleObject[] array, bool flag) => SExecute("setAccessible", array, flag);
        /// <summary>
        /// Set the accessible flag for this object to the indicated boolean value.
        /// </summary>
        public void SetAccessible(bool flag) => IExecute("setAccessible", flag);
    }
}