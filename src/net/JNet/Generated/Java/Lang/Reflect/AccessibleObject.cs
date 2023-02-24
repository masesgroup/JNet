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

namespace Java.Lang.Reflect
{
    #region AccessibleObject
    public partial class AccessibleObject
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.AccessibleObject"/> to <see cref="Java.Lang.Reflect.AnnotatedElement"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.AnnotatedElement(Java.Lang.Reflect.AccessibleObject t) => t.Cast<Java.Lang.Reflect.AnnotatedElement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#setAccessible(java.lang.reflect.AccessibleObject[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Reflect.AccessibleObject"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public static void SetAccessible(Java.Lang.Reflect.AccessibleObject[] arg0, bool arg1)
        {
            SExecute("setAccessible", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] Annotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getAnnotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getDeclaredAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] DeclaredAnnotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#canAccess(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool CanAccess(object arg0)
        {
            return IExecute<bool>("canAccess", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#trySetAccessible()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool TrySetAccessible()
        {
            return IExecute<bool>("trySetAccessible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#setAccessible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAccessible(bool arg0)
        {
            IExecute("setAccessible", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}