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
        /// <summary>
        /// Converter from <see cref="Java.Lang.Invoke.MethodType"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Lang.Invoke.MethodType t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#fromMethodDescriptorString(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.TypeNotPresentException"/>
        public static Java.Lang.Invoke.MethodType FromMethodDescriptorString(string arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("fromMethodDescriptorString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#genericMethodType(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType GenericMethodType(int arg0, bool arg1)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("genericMethodType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#genericMethodType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType GenericMethodType(int arg0)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("genericMethodType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class%3C?%3E,java.lang.Class%3C?%3E,java.lang.Class%3C?%3E...)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Lang.Class arg1, params Java.Lang.Class[] arg2)
        {
            if (arg2.Length == 0) return SExecute<Java.Lang.Invoke.MethodType>("methodType", arg0, arg1); else return SExecute<Java.Lang.Invoke.MethodType>("methodType", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class%3C?%3E,java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Lang.Class arg1)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("methodType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class%3C?%3E,java.lang.Class%3C?%3E[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Lang.Class[] arg1)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("methodType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class%3C?%3E,java.lang.invoke.MethodType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Lang.Invoke.MethodType arg1)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("methodType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class%3C?%3E,java.util.List%3Cjava.lang.Class%3C?%3E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Util.List arg1)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("methodType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0)
        {
            return SExecute<Java.Lang.Invoke.MethodType>("methodType", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#hasPrimitives()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool HasPrimitives()
        {
            return IExecute<bool>("hasPrimitives");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#hasWrappers()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool HasWrappers()
        {
            return IExecute<bool>("hasWrappers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterCount()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int ParameterCount()
        {
            return IExecute<int>("parameterCount");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#lastParameterType()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class LastParameterType()
        {
            return IExecute<Java.Lang.Class>("lastParameterType");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class ParameterType(int arg0)
        {
            return IExecute<Java.Lang.Class>("parameterType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#returnType()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class ReturnType()
        {
            return IExecute<Java.Lang.Class>("returnType");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterArray()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class[] ParameterArray()
        {
            return IExecuteArray<Java.Lang.Class>("parameterArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#appendParameterTypes(java.lang.Class%3C?%3E...)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType AppendParameterTypes(params Java.Lang.Class[] arg0)
        {
            if (arg0.Length == 0) return IExecute<Java.Lang.Invoke.MethodType>("appendParameterTypes"); else return IExecute<Java.Lang.Invoke.MethodType>("appendParameterTypes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#appendParameterTypes(java.util.List%3Cjava.lang.Class%3C?%3E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType AppendParameterTypes(Java.Util.List arg0)
        {
            return IExecute<Java.Lang.Invoke.MethodType>("appendParameterTypes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#changeParameterType(int,java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType ChangeParameterType(int arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Lang.Invoke.MethodType>("changeParameterType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#changeReturnType(java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType ChangeReturnType(Java.Lang.Class arg0)
        {
            return IExecute<Java.Lang.Invoke.MethodType>("changeReturnType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#dropParameterTypes(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType DropParameterTypes(int arg0, int arg1)
        {
            return IExecute<Java.Lang.Invoke.MethodType>("dropParameterTypes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#erase()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Erase()
        {
            return IExecute<Java.Lang.Invoke.MethodType>("erase");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#generic()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Generic()
        {
            return IExecute<Java.Lang.Invoke.MethodType>("generic");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#insertParameterTypes(int,java.lang.Class%3C?%3E...)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType InsertParameterTypes(int arg0, params Java.Lang.Class[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Lang.Invoke.MethodType>("insertParameterTypes", arg0); else return IExecute<Java.Lang.Invoke.MethodType>("insertParameterTypes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#insertParameterTypes(int,java.util.List%3Cjava.lang.Class%3C?%3E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType InsertParameterTypes(int arg0, Java.Util.List arg1)
        {
            return IExecute<Java.Lang.Invoke.MethodType>("insertParameterTypes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#unwrap()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Unwrap()
        {
            return IExecute<Java.Lang.Invoke.MethodType>("unwrap");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#wrap()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Wrap()
        {
            return IExecute<Java.Lang.Invoke.MethodType>("wrap");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#toMethodDescriptorString()"/>
        /// </summary>
        
        /// <returns><see cref="string"/></returns>
        public string ToMethodDescriptorString()
        {
            return IExecute<string>("toMethodDescriptorString");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterList()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List ParameterList()
        {
            return IExecute<Java.Util.List>("parameterList");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}