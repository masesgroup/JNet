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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region MBeanOperationInfo
    public partial class MBeanOperationInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#%3Cinit%3E(java.lang.String,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Method"/></param>
        public MBeanOperationInfo(string arg0, Java.Lang.Reflect.Method arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.MBeanParameterInfo[],java.lang.String,int,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanParameterInfo"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Javax.Management.Descriptor"/></param>
        public MBeanOperationInfo(string arg0, string arg1, Javax.Management.MBeanParameterInfo[] arg2, string arg3, int arg4, Javax.Management.Descriptor arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.MBeanParameterInfo[],java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanParameterInfo"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public MBeanOperationInfo(string arg0, string arg1, Javax.Management.MBeanParameterInfo[] arg2, string arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanOperationInfo"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Management.MBeanOperationInfo t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#ACTION"/>
        /// </summary>
        public static int ACTION { get { return SGetField<int>(LocalBridgeClazz, "ACTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#ACTION_INFO"/>
        /// </summary>
        public static int ACTION_INFO { get { return SGetField<int>(LocalBridgeClazz, "ACTION_INFO"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#INFO"/>
        /// </summary>
        public static int INFO { get { return SGetField<int>(LocalBridgeClazz, "INFO"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#UNKNOWN"/>
        /// </summary>
        public static int UNKNOWN { get { return SGetField<int>(LocalBridgeClazz, "UNKNOWN"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#getImpact()"/> 
        /// </summary>
        public int Impact
        {
            get { return IExecute<int>("getImpact"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#getReturnType()"/> 
        /// </summary>
        public string ReturnType
        {
            get { return IExecute<string>("getReturnType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#getSignature()"/> 
        /// </summary>
        public Javax.Management.MBeanParameterInfo[] Signature
        {
            get { return IExecuteArray<Javax.Management.MBeanParameterInfo>("getSignature"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}