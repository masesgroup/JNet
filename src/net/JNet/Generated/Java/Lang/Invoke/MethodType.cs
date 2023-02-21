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

namespace Java.Lang.Invoke
{
    #region MethodType
    public partial class MethodType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Serializable(Java.Lang.Invoke.MethodType t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#fromMethodDescriptorString(java.lang.String,java.lang.ClassLoader) throws java.lang.IllegalArgumentException,java.lang.TypeNotPresentException
        /// </summary>
        public static Java.Lang.Invoke.MethodType FromMethodDescriptorString(string arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("fromMethodDescriptorString", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#genericMethodType(int,boolean)
        /// </summary>
        public static Java.Lang.Invoke.MethodType GenericMethodType(int arg0, bool arg1)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("genericMethodType", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#genericMethodType(int)
        /// </summary>
        public static Java.Lang.Invoke.MethodType GenericMethodType(int arg0)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("genericMethodType", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#hasPrimitives()
        /// </summary>
        public bool HasPrimitives()
        {
            return IExecute<bool>("hasPrimitives");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#hasWrappers()
        /// </summary>
        public bool HasWrappers()
        {
            return IExecute<bool>("hasWrappers");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterCount()
        /// </summary>
        public int ParameterCount()
        {
            return IExecute<int>("parameterCount");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterArray()
        /// </summary>
        public Java.Lang.Class[] ParameterArray()
        {
            return IExecuteArray<Java.Lang.Class>("parameterArray");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#appendParameterTypes(java.lang.Class<?>...)
        /// </summary>
        public Java.Lang.Invoke.MethodType AppendParameterTypes(params Java.Lang.Class[] arg0)
        {
            if (arg0.Length == 0) return IExecute<Java.Lang.Invoke.MethodType>("appendParameterTypes"); else return IExecute<Java.Lang.Invoke.MethodType>("appendParameterTypes", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#dropParameterTypes(int,int)
        /// </summary>
        public Java.Lang.Invoke.MethodType DropParameterTypes(int arg0, int arg1)
        {
            return IExecute<Java.Lang.Invoke.MethodType>("dropParameterTypes", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#erase()
        /// </summary>
        public Java.Lang.Invoke.MethodType Erase()
        {
            return IExecute<Java.Lang.Invoke.MethodType>("erase");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#generic()
        /// </summary>
        public Java.Lang.Invoke.MethodType Generic()
        {
            return IExecute<Java.Lang.Invoke.MethodType>("generic");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#insertParameterTypes(int,java.lang.Class<?>...)
        /// </summary>
        public Java.Lang.Invoke.MethodType InsertParameterTypes(int arg0, params Java.Lang.Class[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Lang.Invoke.MethodType>("insertParameterTypes", arg0); else return IExecute<Java.Lang.Invoke.MethodType>("insertParameterTypes", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#unwrap()
        /// </summary>
        public Java.Lang.Invoke.MethodType Unwrap()
        {
            return IExecute<Java.Lang.Invoke.MethodType>("unwrap");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#wrap()
        /// </summary>
        public Java.Lang.Invoke.MethodType Wrap()
        {
            return IExecute<Java.Lang.Invoke.MethodType>("wrap");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#toMethodDescriptorString()
        /// </summary>
        public string ToMethodDescriptorString()
        {
            return IExecute<string>("toMethodDescriptorString");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}