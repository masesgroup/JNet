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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region MethodDescriptor
    public partial class MethodDescriptor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/MethodDescriptor.html#%3Cinit%3E(java.lang.reflect.Method,java.beans.ParameterDescriptor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg1"><see cref="Java.Beans.ParameterDescriptor"/></param>
        public MethodDescriptor(Java.Lang.Reflect.Method arg0, Java.Beans.ParameterDescriptor[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/MethodDescriptor.html#%3Cinit%3E(java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Reflect.Method"/></param>
        public MethodDescriptor(Java.Lang.Reflect.Method arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/MethodDescriptor.html#getMethod()"/> 
        /// </summary>
        public Java.Lang.Reflect.Method Method
        {
            get { return IExecute<Java.Lang.Reflect.Method>("getMethod"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/MethodDescriptor.html#getParameterDescriptors()"/> 
        /// </summary>
        public Java.Beans.ParameterDescriptor[] ParameterDescriptors
        {
            get { return IExecuteArray<Java.Beans.ParameterDescriptor>("getParameterDescriptors"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}