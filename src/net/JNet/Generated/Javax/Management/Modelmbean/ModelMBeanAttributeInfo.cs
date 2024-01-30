/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Modelmbean
{
    #region ModelMBeanAttributeInfo
    public partial class ModelMBeanAttributeInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanAttributeInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.reflect.Method,java.lang.reflect.Method,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg4"><see cref="Javax.Management.Descriptor"/></param>
        /// <exception cref="Javax.Management.IntrospectionException"/>
        public ModelMBeanAttributeInfo(string arg0, string arg1, Java.Lang.Reflect.Method arg2, Java.Lang.Reflect.Method arg3, Javax.Management.Descriptor arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanAttributeInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.reflect.Method,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <exception cref="Javax.Management.IntrospectionException"/>
        public ModelMBeanAttributeInfo(string arg0, string arg1, Java.Lang.Reflect.Method arg2, Java.Lang.Reflect.Method arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanAttributeInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,boolean,boolean,boolean,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="Javax.Management.Descriptor"/></param>
        public ModelMBeanAttributeInfo(string arg0, string arg1, string arg2, bool arg3, bool arg4, bool arg5, Javax.Management.Descriptor arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanAttributeInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,boolean,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        public ModelMBeanAttributeInfo(string arg0, string arg1, string arg2, bool arg3, bool arg4, bool arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanAttributeInfo.html#%3Cinit%3E(javax.management.modelmbean.ModelMBeanAttributeInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Modelmbean.ModelMBeanAttributeInfo"/></param>
        public ModelMBeanAttributeInfo(Javax.Management.Modelmbean.ModelMBeanAttributeInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.ModelMBeanAttributeInfo"/> to <see cref="Javax.Management.DescriptorAccess"/>
        /// </summary>
        public static implicit operator Javax.Management.DescriptorAccess(Javax.Management.Modelmbean.ModelMBeanAttributeInfo t) => t.Cast<Javax.Management.DescriptorAccess>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanAttributeInfo.html#setDescriptor(javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Descriptor"/></param>
        public void SetDescriptor(Javax.Management.Descriptor arg0)
        {
            IExecute("setDescriptor", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}