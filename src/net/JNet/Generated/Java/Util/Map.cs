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

namespace Java.Util
{
    #region Map
    public partial class Map
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#copyOf(java.util.Map%3C? extends K, ? extends V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map CopyOf(Java.Util.Map arg0)
        {
            return SExecute<Java.Util.Map>("copyOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of()
        {
            return SExecute<Java.Util.Map>("of");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V,K,V,K,V,K,V,K,V,K,V,K,V,K,V,K,V,K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="object"/></param>
        /// <param name="arg9"><see cref="object"/></param>
        /// <param name="arg10"><see cref="object"/></param>
        /// <param name="arg11"><see cref="object"/></param>
        /// <param name="arg12"><see cref="object"/></param>
        /// <param name="arg13"><see cref="object"/></param>
        /// <param name="arg14"><see cref="object"/></param>
        /// <param name="arg15"><see cref="object"/></param>
        /// <param name="arg16"><see cref="object"/></param>
        /// <param name="arg17"><see cref="object"/></param>
        /// <param name="arg18"><see cref="object"/></param>
        /// <param name="arg19"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V,K,V,K,V,K,V,K,V,K,V,K,V,K,V,K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="object"/></param>
        /// <param name="arg9"><see cref="object"/></param>
        /// <param name="arg10"><see cref="object"/></param>
        /// <param name="arg11"><see cref="object"/></param>
        /// <param name="arg12"><see cref="object"/></param>
        /// <param name="arg13"><see cref="object"/></param>
        /// <param name="arg14"><see cref="object"/></param>
        /// <param name="arg15"><see cref="object"/></param>
        /// <param name="arg16"><see cref="object"/></param>
        /// <param name="arg17"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V,K,V,K,V,K,V,K,V,K,V,K,V,K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="object"/></param>
        /// <param name="arg9"><see cref="object"/></param>
        /// <param name="arg10"><see cref="object"/></param>
        /// <param name="arg11"><see cref="object"/></param>
        /// <param name="arg12"><see cref="object"/></param>
        /// <param name="arg13"><see cref="object"/></param>
        /// <param name="arg14"><see cref="object"/></param>
        /// <param name="arg15"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V,K,V,K,V,K,V,K,V,K,V,K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="object"/></param>
        /// <param name="arg9"><see cref="object"/></param>
        /// <param name="arg10"><see cref="object"/></param>
        /// <param name="arg11"><see cref="object"/></param>
        /// <param name="arg12"><see cref="object"/></param>
        /// <param name="arg13"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V,K,V,K,V,K,V,K,V,K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="object"/></param>
        /// <param name="arg9"><see cref="object"/></param>
        /// <param name="arg10"><see cref="object"/></param>
        /// <param name="arg11"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V,K,V,K,V,K,V,K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="object"/></param>
        /// <param name="arg9"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V,K,V,K,V,K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V,K,V,K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V,K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1, object arg2, object arg3)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#of(K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map Of(object arg0, object arg1)
        {
            return SExecute<Java.Util.Map>("of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#ofEntries(java.util.Map$Entry%3C? extends K, ? extends V%3E...)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map.Entry"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map OfEntries(params Java.Util.Map.Entry[] arg0)
        {
            if (arg0.Length == 0) return SExecute<Java.Util.Map>("ofEntries"); else return SExecute<Java.Util.Map>("ofEntries", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#entry(K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public static Java.Util.Map.Entry EntryMethod(object arg0, object arg1)
        {
            return SExecute<Java.Util.Map.Entry>("entry", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#isEmpty()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#size()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#values()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection Values()
        {
            return IExecute<Java.Util.Collection>("values");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#entrySet()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set EntrySet()
        {
            return IExecute<Java.Util.Set>("entrySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#keySet()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set KeySet()
        {
            return IExecute<Java.Util.Set>("keySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#put(K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Put(object arg0, object arg1)
        {
            return IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(object arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#putAll(java.util.Map%3C? extends K, ? extends V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void PutAll(Java.Util.Map arg0)
        {
            IExecute("putAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#remove(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0, object arg1)
        {
            return IExecute<bool>("remove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#replace(K,V,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Replace(object arg0, object arg1, object arg2)
        {
            return IExecute<bool>("replace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#compute(K,java.util.function.BiFunction%3C? super K, ? super V, ? extends V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object Compute(object arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecute("compute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#computeIfAbsent(K,java.util.function.Function%3C? super K, ? extends V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="object"/></returns>
        public object ComputeIfAbsent(object arg0, Java.Util.Function.Function arg1)
        {
            return IExecute("computeIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#computeIfPresent(K,java.util.function.BiFunction%3C? super K, ? super V, ? extends V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object ComputeIfPresent(object arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecute("computeIfPresent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#getOrDefault(java.lang.Object,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetOrDefault(object arg0, object arg1)
        {
            return IExecute("getOrDefault", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#merge(K,V,java.util.function.BiFunction%3C? super V, ? super V, ? extends V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object Merge(object arg0, object arg1, Java.Util.Function.BiFunction arg2)
        {
            return IExecute("merge", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#putIfAbsent(K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object PutIfAbsent(object arg0, object arg1)
        {
            return IExecute("putIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#replace(K,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Replace(object arg0, object arg1)
        {
            return IExecute("replace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#forEach(java.util.function.BiConsumer%3C? super K, ? super V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        public void ForEach(Java.Util.Function.BiConsumer arg0)
        {
            IExecute("forEach", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#replaceAll(java.util.function.BiFunction%3C? super K, ? super V, ? extends V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        public void ReplaceAll(Java.Util.Function.BiFunction arg0)
        {
            IExecute("replaceAll", arg0);
        }
        
        #endregion

        #region Nested classes
        #region Entry
        public partial class Entry
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#comparingByKey()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Comparator"/></returns>
            public static Java.Util.Comparator ComparingByKey()
            {
                return SExecute<Java.Util.Comparator>("comparingByKey");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#comparingByKey(java.util.Comparator%3C? super K%3E)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
            /// <returns><see cref="Java.Util.Comparator"/></returns>
            public static Java.Util.Comparator ComparingByKey(Java.Util.Comparator arg0)
            {
                return SExecute<Java.Util.Comparator>("comparingByKey", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#comparingByValue()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Comparator"/></returns>
            public static Java.Util.Comparator ComparingByValue()
            {
                return SExecute<Java.Util.Comparator>("comparingByValue");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#comparingByValue(java.util.Comparator%3C? super V%3E)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
            /// <returns><see cref="Java.Util.Comparator"/></returns>
            public static Java.Util.Comparator ComparingByValue(Java.Util.Comparator arg0)
            {
                return SExecute<Java.Util.Comparator>("comparingByValue", arg0);
            }
            
            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#getKey()"/> 
            /// </summary>
            public object Key
            {
                get { return IExecute("getKey"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#getValue()"/> 
            /// </summary>
            public object Value
            {
                get { return IExecute("getValue"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#setValue(V)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object SetValue(object arg0)
            {
                return IExecute("setValue", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}