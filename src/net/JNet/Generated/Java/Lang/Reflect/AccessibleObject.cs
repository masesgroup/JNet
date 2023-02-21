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
        public static implicit operator Java.Lang.Reflect.AnnotatedElement(Java.Lang.Reflect.AccessibleObject t) => t.Cast<Java.Lang.Reflect.AnnotatedElement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#setAccessible(java.lang.reflect.AccessibleObject[],boolean)
        /// </summary>
        public static void SetAccessible(Java.Lang.Reflect.AccessibleObject[] arg0, bool arg1)
        {
            SExecute("setAccessible", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getAnnotations() 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] Annotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getAnnotations"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getDeclaredAnnotations() 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] DeclaredAnnotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#canAccess(java.lang.Object)
        /// </summary>
        public bool CanAccess(object arg0)
        {
            return IExecute<bool>("canAccess", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#trySetAccessible()
        /// </summary>
        public bool TrySetAccessible()
        {
            return IExecute<bool>("trySetAccessible");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#setAccessible(boolean)
        /// </summary>
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