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

namespace Javax.Management
{
    #region MBeanServerInvocationHandler
    public partial class MBeanServerInvocationHandler
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerInvocationHandler.html#%3Cinit%3E(javax.management.MBeanServerConnection,javax.management.ObjectName,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public MBeanServerInvocationHandler(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerInvocationHandler.html#%3Cinit%3E(javax.management.MBeanServerConnection,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        public MBeanServerInvocationHandler(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerInvocationHandler.html#newProxyInstance(javax.management.MBeanServerConnection,javax.management.ObjectName,java.lang.Class,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T NewProxyInstance<T>(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, Java.Lang.Class arg2, bool arg3)
        {
            return SExecute<T>(LocalBridgeClazz, "newProxyInstance", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerInvocationHandler.html#getMBeanServerConnection()"/> 
        /// </summary>
        public Javax.Management.MBeanServerConnection MBeanServerConnection
        {
            get { return IExecuteWithSignature<Javax.Management.MBeanServerConnection>("getMBeanServerConnection", "()Ljavax/management/MBeanServerConnection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerInvocationHandler.html#getObjectName()"/> 
        /// </summary>
        public Javax.Management.ObjectName ObjectName
        {
            get { return IExecuteWithSignature<Javax.Management.ObjectName>("getObjectName", "()Ljavax/management/ObjectName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerInvocationHandler.html#isMXBean()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMXBean()
        {
            return IExecuteWithSignature<bool>("isMXBean", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerInvocationHandler.html#invoke(java.lang.Object,java.lang.reflect.Method,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object Invoke(object arg0, Java.Lang.Reflect.Method arg1, object[] arg2)
        {
            return IExecute("invoke", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}