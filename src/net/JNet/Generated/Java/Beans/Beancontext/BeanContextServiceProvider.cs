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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans.Beancontext
{
    #region BeanContextServiceProvider
    public partial class BeanContextServiceProvider
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceProvider.html#getService(java.beans.beancontext.BeanContextServices,java.lang.Object,java.lang.Class,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServices"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetService(Java.Beans.Beancontext.BeanContextServices arg0, object arg1, Java.Lang.Class arg2, object arg3)
        {
            return IExecute("getService", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceProvider.html#getCurrentServiceSelectors(java.beans.beancontext.BeanContextServices,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServices"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="ReturnExtendsobject"></typeparam>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<ReturnExtendsobject> GetCurrentServiceSelectors<ReturnExtendsobject>(Java.Beans.Beancontext.BeanContextServices arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.Iterator<ReturnExtendsobject>>("getCurrentServiceSelectors", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceProvider.html#releaseService(java.beans.beancontext.BeanContextServices,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServices"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void ReleaseService(Java.Beans.Beancontext.BeanContextServices arg0, object arg1, object arg2)
        {
            IExecute("releaseService", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}