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
    #region Module
    public partial class Module
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Module"/> to <see cref="Java.Lang.Reflect.AnnotatedElement"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.AnnotatedElement(Java.Lang.Module t) => t.Cast<Java.Lang.Reflect.AnnotatedElement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] Annotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getAnnotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getClassLoader()"/> 
        /// </summary>
        public Java.Lang.ClassLoader ClassLoader
        {
            get { return IExecute<Java.Lang.ClassLoader>("getClassLoader"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getDeclaredAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] DeclaredAnnotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getDescriptor()"/> 
        /// </summary>
        public Java.Lang.ModuleNs.ModuleDescriptor Descriptor
        {
            get { return IExecute<Java.Lang.ModuleNs.ModuleDescriptor>("getDescriptor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getLayer()"/> 
        /// </summary>
        public Java.Lang.ModuleLayer Layer
        {
            get { return IExecute<Java.Lang.ModuleLayer>("getLayer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getPackages()"/> 
        /// </summary>
        public Java.Util.Set Packages
        {
            get { return IExecute<Java.Util.Set>("getPackages"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getAnnotation(java.lang.Class%3CT%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation GetAnnotation(Java.Lang.Class arg0)
        {
            return IExecute<Java.Lang.Annotation.Annotation>("getAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#canRead(java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanRead(Java.Lang.Module arg0)
        {
            return IExecute<bool>("canRead", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#canUse(java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanUse(Java.Lang.Class arg0)
        {
            return IExecute<bool>("canUse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isExported(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsExported(string arg0, Java.Lang.Module arg1)
        {
            return IExecute<bool>("isExported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isExported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsExported(string arg0)
        {
            return IExecute<bool>("isExported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isNamed()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsNamed()
        {
            return IExecute<bool>("isNamed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isOpen(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen(string arg0, Java.Lang.Module arg1)
        {
            return IExecute<bool>("isOpen", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isOpen(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen(string arg0)
        {
            return IExecute<bool>("isOpen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getResourceAsStream(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream GetResourceAsStream(string arg0)
        {
            return IExecute<Java.Io.InputStream>("getResourceAsStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#addExports(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Lang.Module"/></returns>
        public Java.Lang.Module AddExports(string arg0, Java.Lang.Module arg1)
        {
            return IExecute<Java.Lang.Module>("addExports", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#addOpens(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Lang.Module"/></returns>
        public Java.Lang.Module AddOpens(string arg0, Java.Lang.Module arg1)
        {
            return IExecute<Java.Lang.Module>("addOpens", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#addReads(java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Lang.Module"/></returns>
        public Java.Lang.Module AddReads(Java.Lang.Module arg0)
        {
            return IExecute<Java.Lang.Module>("addReads", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#addUses(java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Module"/></returns>
        public Java.Lang.Module AddUses(Java.Lang.Class arg0)
        {
            return IExecute<Java.Lang.Module>("addUses", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}