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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Package
    public partial class Package
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Package"/> to <see cref="Java.Lang.Reflect.AnnotatedElement"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.AnnotatedElement(Java.Lang.Package t) => t.Cast<Java.Lang.Reflect.AnnotatedElement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getPackages()"/> 
        /// </summary>
        public static Java.Lang.Package[] Packages
        {
            get { return SExecuteArray<Java.Lang.Package>("getPackages"); }
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] Annotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getAnnotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getDeclaredAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] DeclaredAnnotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getImplementationTitle()"/> 
        /// </summary>
        public string ImplementationTitle
        {
            get { return IExecute<string>("getImplementationTitle"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getImplementationVendor()"/> 
        /// </summary>
        public string ImplementationVendor
        {
            get { return IExecute<string>("getImplementationVendor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getImplementationVersion()"/> 
        /// </summary>
        public string ImplementationVersion
        {
            get { return IExecute<string>("getImplementationVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getSpecificationTitle()"/> 
        /// </summary>
        public string SpecificationTitle
        {
            get { return IExecute<string>("getSpecificationTitle"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getSpecificationVendor()"/> 
        /// </summary>
        public string SpecificationVendor
        {
            get { return IExecute<string>("getSpecificationVendor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getSpecificationVersion()"/> 
        /// </summary>
        public string SpecificationVersion
        {
            get { return IExecute<string>("getSpecificationVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getAnnotation(java.lang.Class%3CA%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation GetAnnotation(Java.Lang.Class arg0)
        {
            return IExecute<Java.Lang.Annotation.Annotation>("getAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getDeclaredAnnotation(java.lang.Class%3CA%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation GetDeclaredAnnotation(Java.Lang.Class arg0)
        {
            return IExecute<Java.Lang.Annotation.Annotation>("getDeclaredAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getAnnotationsByType(java.lang.Class%3CA%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetAnnotationsByType(Java.Lang.Class arg0)
        {
            return IExecuteArray<Java.Lang.Annotation.Annotation>("getAnnotationsByType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#getDeclaredAnnotationsByType(java.lang.Class%3CA%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetDeclaredAnnotationsByType(Java.Lang.Class arg0)
        {
            return IExecuteArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotationsByType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#isAnnotationPresent(java.lang.Class%3C? extends java.lang.annotation.Annotation%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAnnotationPresent(Java.Lang.Class arg0)
        {
            return IExecute<bool>("isAnnotationPresent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#isCompatibleWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public bool IsCompatibleWith(string arg0)
        {
            return IExecute<bool>("isCompatibleWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#isSealed()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsSealed()
        {
            return IExecute<bool>("isSealed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Package.html#isSealed(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSealed(Java.Net.URL arg0)
        {
            return IExecute<bool>("isSealed", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}