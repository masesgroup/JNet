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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Invoke
{
    #region MethodHandle
    public partial class MethodHandle
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#isVarargsCollector()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVarargsCollector()
        {
            return IExecute<bool>("isVarargsCollector");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#invoke(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object Invoke(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("invoke"); else return IExecute("invoke", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#invokeExact(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object InvokeExact(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("invokeExact"); else return IExecute("invokeExact", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asCollector(int,java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsCollector(int arg0, Java.Lang.Class arg1, int arg2)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asCollector", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asCollector(java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsCollector(Java.Lang.Class arg0, int arg1)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asCollector", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asFixedArity()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsFixedArity()
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asFixedArity");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asSpreader(int,java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsSpreader(int arg0, Java.Lang.Class arg1, int arg2)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asSpreader", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asSpreader(java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsSpreader(Java.Lang.Class arg0, int arg1)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asSpreader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asType(java.lang.invoke.MethodType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsType(Java.Lang.Invoke.MethodType arg0)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asVarargsCollector(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsVarargsCollector(Java.Lang.Class arg0)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asVarargsCollector", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#bindTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle BindTo(object arg0)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("bindTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#withVarargs(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle WithVarargs(bool arg0)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("withVarargs", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#type()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Type()
        {
            return IExecute<Java.Lang.Invoke.MethodType>("type");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#invokeWithArguments(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object InvokeWithArguments(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("invokeWithArguments"); else return IExecute("invokeWithArguments", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#invokeWithArguments(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object InvokeWithArguments(Java.Util.List<object> arg0)
        {
            return IExecute("invokeWithArguments", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}