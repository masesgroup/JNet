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

namespace Javax.Security.Auth
{
    #region Subject
    public partial class Subject
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#%3Cinit%3E(boolean,java.util.Set,java.util.Set,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        public Subject(bool arg0, Java.Util.Set arg1, Java.Util.Set arg2, Java.Util.Set arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Subject"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Subject t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#doAs(javax.security.auth.Subject,java.security.PrivilegedAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <param name="arg1"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T DoAs<T>(Javax.Security.Auth.Subject arg0, Java.Security.PrivilegedAction<T> arg1)
        {
            return SExecute<T>(LocalBridgeClazz, "doAs", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#doAs(javax.security.auth.Subject,java.security.PrivilegedExceptionAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <param name="arg1"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Security.PrivilegedActionException"/>
        public static T DoAs<T>(Javax.Security.Auth.Subject arg0, Java.Security.PrivilegedExceptionAction<T> arg1)
        {
            return SExecute<T>(LocalBridgeClazz, "doAs", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#doAsPrivileged(javax.security.auth.Subject,java.security.PrivilegedAction,java.security.AccessControlContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <param name="arg1"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <param name="arg2"><see cref="Java.Security.AccessControlContext"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T DoAsPrivileged<T>(Javax.Security.Auth.Subject arg0, Java.Security.PrivilegedAction<T> arg1, Java.Security.AccessControlContext arg2)
        {
            return SExecute<T>(LocalBridgeClazz, "doAsPrivileged", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#doAsPrivileged(javax.security.auth.Subject,java.security.PrivilegedExceptionAction,java.security.AccessControlContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <param name="arg1"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <param name="arg2"><see cref="Java.Security.AccessControlContext"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Security.PrivilegedActionException"/>
        public static T DoAsPrivileged<T>(Javax.Security.Auth.Subject arg0, Java.Security.PrivilegedExceptionAction<T> arg1, Java.Security.AccessControlContext arg2)
        {
            return SExecute<T>(LocalBridgeClazz, "doAsPrivileged", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#getSubject(java.security.AccessControlContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.AccessControlContext"/></param>
        /// <returns><see cref="Javax.Security.Auth.Subject"/></returns>
        public static Javax.Security.Auth.Subject GetSubject(Java.Security.AccessControlContext arg0)
        {
            return SExecute<Javax.Security.Auth.Subject>(LocalBridgeClazz, "getSubject", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#isReadOnly()"/> 
        /// </summary>
        public bool IsReadOnly
        {
            get { return IExecute<bool>("isReadOnly"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#getPrincipals()"/> 
        /// </summary>
        public Java.Util.Set<Java.Security.Principal> Principals
        {
            get { return IExecute<Java.Util.Set<Java.Security.Principal>>("getPrincipals"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#getPrivateCredentials()"/> 
        /// </summary>
        public Java.Util.Set<object> PrivateCredentials
        {
            get { return IExecute<Java.Util.Set<object>>("getPrivateCredentials"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#getPublicCredentials()"/> 
        /// </summary>
        public Java.Util.Set<object> PublicCredentials
        {
            get { return IExecute<Java.Util.Set<object>>("getPublicCredentials"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#getPrincipals(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Security.Principal"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<T> GetPrincipals<T>(Java.Lang.Class arg0) where T: Java.Security.Principal
        {
            return IExecute<Java.Util.Set<T>>("getPrincipals", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#getPrivateCredentials(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<T> GetPrivateCredentials<T>(Java.Lang.Class arg0)
        {
            return IExecute<Java.Util.Set<T>>("getPrivateCredentials", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#getPublicCredentials(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<T> GetPublicCredentials<T>(Java.Lang.Class arg0)
        {
            return IExecute<Java.Util.Set<T>>("getPublicCredentials", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/Subject.html#setReadOnly()"/>
        /// </summary>
        public void SetReadOnly()
        {
            IExecute("setReadOnly");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}