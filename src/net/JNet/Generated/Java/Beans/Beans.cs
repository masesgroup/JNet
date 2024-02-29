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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region Beans
    public partial class Beans
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#isDesignTime()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsDesignTime()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDesignTime", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#isGuiAvailable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsGuiAvailable()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isGuiAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#isInstanceOf(java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInstanceOf(object arg0, Java.Lang.Class arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isInstanceOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#getInstanceOf(java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        public static object GetInstanceOf(object arg0, Java.Lang.Class arg1)
        {
            return SExecute(LocalBridgeClazz, "getInstanceOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#instantiate(java.lang.ClassLoader,java.lang.String,java.beans.beancontext.BeanContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Beans.Beancontext.BeanContext"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public static object Instantiate(Java.Lang.ClassLoader arg0, Java.Lang.String arg1, Java.Beans.Beancontext.BeanContext arg2)
        {
            return SExecute(LocalBridgeClazz, "instantiate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#instantiate(java.lang.ClassLoader,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public static object Instantiate(Java.Lang.ClassLoader arg0, Java.Lang.String arg1)
        {
            return SExecute(LocalBridgeClazz, "instantiate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#setDesignTime(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public static void SetDesignTime(bool arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDesignTime", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#setGuiAvailable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public static void SetGuiAvailable(bool arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setGuiAvailable", "(Z)V", arg0);
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