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

namespace Java.Security
{
    #region AccessController
    public partial class AccessController
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#getContext()"/> 
        /// </summary>
        public static Java.Security.AccessControlContext Context
        {
            get { return SExecute<Java.Security.AccessControlContext>(LocalBridgeClazz, "getContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivileged(java.security.PrivilegedAction,java.security.AccessControlContext,java.security.Permission[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <param name="arg1"><see cref="Java.Security.AccessControlContext"/></param>
        /// <param name="arg2"><see cref="Java.Security.Permission"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T DoPrivileged<T>(Java.Security.PrivilegedAction<T> arg0, Java.Security.AccessControlContext arg1, params Java.Security.Permission[] arg2)
        {
            if (arg2.Length == 0) return SExecute<T>(LocalBridgeClazz, "doPrivileged", arg0, arg1); else return SExecute<T>(LocalBridgeClazz, "doPrivileged", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivileged(java.security.PrivilegedExceptionAction,java.security.AccessControlContext,java.security.Permission[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <param name="arg1"><see cref="Java.Security.AccessControlContext"/></param>
        /// <param name="arg2"><see cref="Java.Security.Permission"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Security.PrivilegedActionException"/>
        public static T DoPrivileged<T>(Java.Security.PrivilegedExceptionAction<T> arg0, Java.Security.AccessControlContext arg1, params Java.Security.Permission[] arg2)
        {
            if (arg2.Length == 0) return SExecute<T>(LocalBridgeClazz, "doPrivileged", arg0, arg1); else return SExecute<T>(LocalBridgeClazz, "doPrivileged", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivilegedWithCombiner(java.security.PrivilegedAction,java.security.AccessControlContext,java.security.Permission[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <param name="arg1"><see cref="Java.Security.AccessControlContext"/></param>
        /// <param name="arg2"><see cref="Java.Security.Permission"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T DoPrivilegedWithCombiner<T>(Java.Security.PrivilegedAction<T> arg0, Java.Security.AccessControlContext arg1, params Java.Security.Permission[] arg2)
        {
            if (arg2.Length == 0) return SExecute<T>(LocalBridgeClazz, "doPrivilegedWithCombiner", arg0, arg1); else return SExecute<T>(LocalBridgeClazz, "doPrivilegedWithCombiner", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivilegedWithCombiner(java.security.PrivilegedAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T DoPrivilegedWithCombiner<T>(Java.Security.PrivilegedAction<T> arg0)
        {
            return SExecute<T>(LocalBridgeClazz, "doPrivilegedWithCombiner", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivilegedWithCombiner(java.security.PrivilegedExceptionAction,java.security.AccessControlContext,java.security.Permission[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <param name="arg1"><see cref="Java.Security.AccessControlContext"/></param>
        /// <param name="arg2"><see cref="Java.Security.Permission"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Security.PrivilegedActionException"/>
        public static T DoPrivilegedWithCombiner<T>(Java.Security.PrivilegedExceptionAction<T> arg0, Java.Security.AccessControlContext arg1, params Java.Security.Permission[] arg2)
        {
            if (arg2.Length == 0) return SExecute<T>(LocalBridgeClazz, "doPrivilegedWithCombiner", arg0, arg1); else return SExecute<T>(LocalBridgeClazz, "doPrivilegedWithCombiner", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivilegedWithCombiner(java.security.PrivilegedExceptionAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Security.PrivilegedActionException"/>
        public static T DoPrivilegedWithCombiner<T>(Java.Security.PrivilegedExceptionAction<T> arg0)
        {
            return SExecute<T>(LocalBridgeClazz, "doPrivilegedWithCombiner", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivileged(java.security.PrivilegedAction,java.security.AccessControlContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <param name="arg1"><see cref="Java.Security.AccessControlContext"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T DoPrivileged<T>(Java.Security.PrivilegedAction<T> arg0, Java.Security.AccessControlContext arg1)
        {
            return SExecute<T>(LocalBridgeClazz, "doPrivileged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivileged(java.security.PrivilegedAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T DoPrivileged<T>(Java.Security.PrivilegedAction<T> arg0)
        {
            return SExecute<T>(LocalBridgeClazz, "doPrivileged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivileged(java.security.PrivilegedExceptionAction,java.security.AccessControlContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <param name="arg1"><see cref="Java.Security.AccessControlContext"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Security.PrivilegedActionException"/>
        public static T DoPrivileged<T>(Java.Security.PrivilegedExceptionAction<T> arg0, Java.Security.AccessControlContext arg1)
        {
            return SExecute<T>(LocalBridgeClazz, "doPrivileged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#doPrivileged(java.security.PrivilegedExceptionAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Security.PrivilegedActionException"/>
        public static T DoPrivileged<T>(Java.Security.PrivilegedExceptionAction<T> arg0)
        {
            return SExecute<T>(LocalBridgeClazz, "doPrivileged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AccessController.html#checkPermission(java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Permission"/></param>
        /// <exception cref="Java.Security.AccessControlException"/>
        public static void CheckPermission(Java.Security.Permission arg0)
        {
            SExecute(LocalBridgeClazz, "checkPermission", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}