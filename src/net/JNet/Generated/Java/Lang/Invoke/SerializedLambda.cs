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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Invoke
{
    #region SerializedLambda
    public partial class SerializedLambda
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getCapturedArgCount()"/> 
        /// </summary>
        public int CapturedArgCount
        {
            get { return IExecuteWithSignature<int>("getCapturedArgCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getCapturingClass()"/> 
        /// </summary>
        public Java.Lang.String CapturingClass
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCapturingClass", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getFunctionalInterfaceClass()"/> 
        /// </summary>
        public Java.Lang.String FunctionalInterfaceClass
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFunctionalInterfaceClass", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getFunctionalInterfaceMethodName()"/> 
        /// </summary>
        public Java.Lang.String FunctionalInterfaceMethodName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFunctionalInterfaceMethodName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getFunctionalInterfaceMethodSignature()"/> 
        /// </summary>
        public Java.Lang.String FunctionalInterfaceMethodSignature
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFunctionalInterfaceMethodSignature", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getImplClass()"/> 
        /// </summary>
        public Java.Lang.String ImplClass
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getImplClass", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getImplMethodKind()"/> 
        /// </summary>
        public int ImplMethodKind
        {
            get { return IExecuteWithSignature<int>("getImplMethodKind", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getImplMethodName()"/> 
        /// </summary>
        public Java.Lang.String ImplMethodName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getImplMethodName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getImplMethodSignature()"/> 
        /// </summary>
        public Java.Lang.String ImplMethodSignature
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getImplMethodSignature", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getInstantiatedMethodType()"/> 
        /// </summary>
        public Java.Lang.String InstantiatedMethodType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getInstantiatedMethodType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SerializedLambda.html#getCapturedArg(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetCapturedArg(int arg0)
        {
            return IExecuteWithSignature("getCapturedArg", "(I)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}