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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#isDesignTime()
        /// </summary>
        public static bool IsDesignTime()
        {
            return SExecute<bool>("isDesignTime");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#isGuiAvailable()
        /// </summary>
        public static bool IsGuiAvailable()
        {
            return SExecute<bool>("isGuiAvailable");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#instantiate(java.lang.ClassLoader,java.lang.String,java.beans.beancontext.BeanContext) throws java.io.IOException,java.lang.ClassNotFoundException
        /// </summary>
        public static object Instantiate(Java.Lang.ClassLoader arg0, string arg1, Java.Beans.Beancontext.BeanContext arg2)
        {
            return SExecute("instantiate", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#instantiate(java.lang.ClassLoader,java.lang.String) throws java.io.IOException,java.lang.ClassNotFoundException
        /// </summary>
        public static object Instantiate(Java.Lang.ClassLoader arg0, string arg1)
        {
            return SExecute("instantiate", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#setDesignTime(boolean) throws java.lang.SecurityException
        /// </summary>
        public static void SetDesignTime(bool arg0)
        {
            SExecute("setDesignTime", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Beans.html#setGuiAvailable(boolean) throws java.lang.SecurityException
        /// </summary>
        public static void SetGuiAvailable(bool arg0)
        {
            SExecute("setGuiAvailable", arg0);
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