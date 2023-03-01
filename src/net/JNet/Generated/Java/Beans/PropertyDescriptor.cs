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

namespace Java.Beans
{
    #region PropertyDescriptor
    public partial class PropertyDescriptor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class%3C?%3E,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public PropertyDescriptor(string arg0, Java.Lang.Class arg1, string arg2, string arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public PropertyDescriptor(string arg0, Java.Lang.Class arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.reflect.Method,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public PropertyDescriptor(string arg0, Java.Lang.Reflect.Method arg1, Java.Lang.Reflect.Method arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#getPropertyEditorClass()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setPropertyEditorClass(java.lang.Class%3C?%3E)"/>
        /// </summary>
        public Java.Lang.Class PropertyEditorClass
        {
            get { return IExecute<Java.Lang.Class>("getPropertyEditorClass"); } set { IExecute("setPropertyEditorClass", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#getPropertyType()"/> 
        /// </summary>
        public Java.Lang.Class PropertyType
        {
            get { return IExecute<Java.Lang.Class>("getPropertyType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#getReadMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setReadMethod(java.lang.reflect.Method)"/>
        /// </summary>
        public Java.Lang.Reflect.Method ReadMethod
        {
            get { return IExecute<Java.Lang.Reflect.Method>("getReadMethod"); } set { IExecute("setReadMethod", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#getWriteMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setWriteMethod(java.lang.reflect.Method)"/>
        /// </summary>
        public Java.Lang.Reflect.Method WriteMethod
        {
            get { return IExecute<Java.Lang.Reflect.Method>("getWriteMethod"); } set { IExecute("setWriteMethod", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#isBound()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsBound()
        {
            return IExecute<bool>("isBound");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#isConstrained()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsConstrained()
        {
            return IExecute<bool>("isConstrained");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#createPropertyEditor(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Beans.PropertyEditor"/></returns>
        public Java.Beans.PropertyEditor CreatePropertyEditor(object arg0)
        {
            return IExecute<Java.Beans.PropertyEditor>("createPropertyEditor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setBound(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBound(bool arg0)
        {
            IExecute("setBound", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setConstrained(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetConstrained(bool arg0)
        {
            IExecute("setConstrained", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}