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

namespace Java.Lang.Reflect
{
    #region Method
    public partial class Method
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#getDefaultValue() 
        /// </summary>
        public object DefaultValue
        {
            get { return IExecute("getDefaultValue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#getGenericReturnType() 
        /// </summary>
        public Java.Lang.Reflect.Type GenericReturnType
        {
            get { return IExecute<Java.Lang.Reflect.Type>("getGenericReturnType"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#isBridge()
        /// </summary>
        public bool IsBridge()
        {
            return IExecute<bool>("isBridge");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#isDefault()
        /// </summary>
        public bool IsDefault()
        {
            return IExecute<bool>("isDefault");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#invoke(java.lang.Object,java.lang.Object...) throws java.lang.IllegalAccessException,java.lang.IllegalArgumentException,java.lang.reflect.InvocationTargetException
        /// </summary>
        public object Invoke(object arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecute("invoke", arg0); else return IExecute("invoke", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}