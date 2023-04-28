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

namespace Java.Lang.Invoke
{
    #region VarHandle
    public partial class VarHandle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#acquireFence()"/>
        /// </summary>
        public static void AcquireFence()
        {
            SExecute(LocalClazz, "acquireFence");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#fullFence()"/>
        /// </summary>
        public static void FullFence()
        {
            SExecute(LocalClazz, "fullFence");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#loadLoadFence()"/>
        /// </summary>
        public static void LoadLoadFence()
        {
            SExecute(LocalClazz, "loadLoadFence");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#releaseFence()"/>
        /// </summary>
        public static void ReleaseFence()
        {
            SExecute(LocalClazz, "releaseFence");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#storeStoreFence()"/>
        /// </summary>
        public static void StoreStoreFence()
        {
            SExecute(LocalClazz, "storeStoreFence");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#coordinateTypes()"/> 
        /// </summary>
        public Java.Util.List CoordinateTypes
        {
            get { return IExecute<Java.Util.List>("coordinateTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#varType()"/> 
        /// </summary>
        public Java.Lang.Class VarType
        {
            get { return IExecute<Java.Lang.Class>("varType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#isAccessModeSupported(java.lang.invoke.VarHandle.AccessMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.VarHandle.AccessMode"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAccessModeSupported(Java.Lang.Invoke.VarHandle.AccessMode arg0)
        {
            return IExecute<bool>("isAccessModeSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#toMethodHandle(java.lang.invoke.VarHandle.AccessMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.VarHandle.AccessMode"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle ToMethodHandle(Java.Lang.Invoke.VarHandle.AccessMode arg0)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("toMethodHandle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#accessModeType(java.lang.invoke.VarHandle.AccessMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.VarHandle.AccessMode"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType AccessModeType(Java.Lang.Invoke.VarHandle.AccessMode arg0)
        {
            return IExecute<Java.Lang.Invoke.MethodType>("accessModeType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#compareAndSet(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute<bool>("compareAndSet", new object[] { arg0 }); else return IExecute<bool>("compareAndSet", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#weakCompareAndSet(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute<bool>("weakCompareAndSet", new object[] { arg0 }); else return IExecute<bool>("weakCompareAndSet", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#weakCompareAndSetAcquire(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetAcquire(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute<bool>("weakCompareAndSetAcquire", new object[] { arg0 }); else return IExecute<bool>("weakCompareAndSetAcquire", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#weakCompareAndSetPlain(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetPlain(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute<bool>("weakCompareAndSetPlain", new object[] { arg0 }); else return IExecute<bool>("weakCompareAndSetPlain", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#weakCompareAndSetRelease(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetRelease(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute<bool>("weakCompareAndSetRelease", new object[] { arg0 }); else return IExecute<bool>("weakCompareAndSetRelease", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#compareAndExchange(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CompareAndExchange(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("compareAndExchange", new object[] { arg0 }); else return IExecute("compareAndExchange", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#compareAndExchangeAcquire(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CompareAndExchangeAcquire(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("compareAndExchangeAcquire", new object[] { arg0 }); else return IExecute("compareAndExchangeAcquire", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#compareAndExchangeRelease(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CompareAndExchangeRelease(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("compareAndExchangeRelease", new object[] { arg0 }); else return IExecute("compareAndExchangeRelease", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#get(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("get", new object[] { arg0 }); else return IExecute("get", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAcquire(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAcquire(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAcquire", new object[] { arg0 }); else return IExecute("getAcquire", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndAdd(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndAdd(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndAdd", new object[] { arg0 }); else return IExecute("getAndAdd", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndAddAcquire(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndAddAcquire(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndAddAcquire", new object[] { arg0 }); else return IExecute("getAndAddAcquire", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndAddRelease(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndAddRelease(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndAddRelease", new object[] { arg0 }); else return IExecute("getAndAddRelease", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndBitwiseAnd(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndBitwiseAnd(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndBitwiseAnd", new object[] { arg0 }); else return IExecute("getAndBitwiseAnd", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndBitwiseAndAcquire(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndBitwiseAndAcquire(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndBitwiseAndAcquire", new object[] { arg0 }); else return IExecute("getAndBitwiseAndAcquire", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndBitwiseAndRelease(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndBitwiseAndRelease(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndBitwiseAndRelease", new object[] { arg0 }); else return IExecute("getAndBitwiseAndRelease", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndBitwiseOr(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndBitwiseOr(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndBitwiseOr", new object[] { arg0 }); else return IExecute("getAndBitwiseOr", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndBitwiseOrAcquire(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndBitwiseOrAcquire(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndBitwiseOrAcquire", new object[] { arg0 }); else return IExecute("getAndBitwiseOrAcquire", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndBitwiseOrRelease(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndBitwiseOrRelease(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndBitwiseOrRelease", new object[] { arg0 }); else return IExecute("getAndBitwiseOrRelease", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndBitwiseXor(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndBitwiseXor(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndBitwiseXor", new object[] { arg0 }); else return IExecute("getAndBitwiseXor", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndBitwiseXorAcquire(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndBitwiseXorAcquire(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndBitwiseXorAcquire", new object[] { arg0 }); else return IExecute("getAndBitwiseXorAcquire", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndBitwiseXorRelease(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndBitwiseXorRelease(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndBitwiseXorRelease", new object[] { arg0 }); else return IExecute("getAndBitwiseXorRelease", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndSet(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndSet(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndSet", new object[] { arg0 }); else return IExecute("getAndSet", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndSetAcquire(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndSetAcquire(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndSetAcquire", new object[] { arg0 }); else return IExecute("getAndSetAcquire", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getAndSetRelease(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndSetRelease(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getAndSetRelease", new object[] { arg0 }); else return IExecute("getAndSetRelease", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getOpaque(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetOpaque(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getOpaque", new object[] { arg0 }); else return IExecute("getOpaque", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#getVolatile(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetVolatile(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecute("getVolatile", new object[] { arg0 }); else return IExecute("getVolatile", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#set(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Set(params object[] arg0)
        {
            if (arg0.Length == 0) IExecute("set", new object[] { arg0 }); else IExecute("set", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#setOpaque(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetOpaque(params object[] arg0)
        {
            if (arg0.Length == 0) IExecute("setOpaque", new object[] { arg0 }); else IExecute("setOpaque", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#setRelease(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetRelease(params object[] arg0)
        {
            if (arg0.Length == 0) IExecute("setRelease", new object[] { arg0 }); else IExecute("setRelease", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.html#setVolatile(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetVolatile(params object[] arg0)
        {
            if (arg0.Length == 0) IExecute("setVolatile", new object[] { arg0 }); else IExecute("setVolatile", new object[] { arg0 }, arg0);
        }

        #endregion

        #region Nested classes
        #region AccessMode
        public partial class AccessMode
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#COMPARE_AND_EXCHANGE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode COMPARE_AND_EXCHANGE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "COMPARE_AND_EXCHANGE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#COMPARE_AND_EXCHANGE_ACQUIRE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode COMPARE_AND_EXCHANGE_ACQUIRE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "COMPARE_AND_EXCHANGE_ACQUIRE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#COMPARE_AND_EXCHANGE_RELEASE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode COMPARE_AND_EXCHANGE_RELEASE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "COMPARE_AND_EXCHANGE_RELEASE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#COMPARE_AND_SET"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode COMPARE_AND_SET { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "COMPARE_AND_SET"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_ACQUIRE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_ACQUIRE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_ACQUIRE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_ADD"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_ADD { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_ADD"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_ADD_ACQUIRE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_ADD_ACQUIRE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_ADD_ACQUIRE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_ADD_RELEASE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_ADD_RELEASE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_ADD_RELEASE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_BITWISE_AND"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_BITWISE_AND { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_BITWISE_AND"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_BITWISE_AND_ACQUIRE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_BITWISE_AND_ACQUIRE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_BITWISE_AND_ACQUIRE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_BITWISE_AND_RELEASE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_BITWISE_AND_RELEASE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_BITWISE_AND_RELEASE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_BITWISE_OR"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_BITWISE_OR { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_BITWISE_OR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_BITWISE_OR_ACQUIRE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_BITWISE_OR_ACQUIRE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_BITWISE_OR_ACQUIRE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_BITWISE_OR_RELEASE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_BITWISE_OR_RELEASE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_BITWISE_OR_RELEASE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_BITWISE_XOR"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_BITWISE_XOR { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_BITWISE_XOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_BITWISE_XOR_ACQUIRE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_BITWISE_XOR_ACQUIRE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_BITWISE_XOR_ACQUIRE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_BITWISE_XOR_RELEASE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_BITWISE_XOR_RELEASE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_BITWISE_XOR_RELEASE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_SET"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_SET { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_SET"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_SET_ACQUIRE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_SET_ACQUIRE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_SET_ACQUIRE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_AND_SET_RELEASE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_AND_SET_RELEASE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_AND_SET_RELEASE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_OPAQUE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_OPAQUE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_OPAQUE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#GET_VOLATILE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode GET_VOLATILE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "GET_VOLATILE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#SET"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode SET { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "SET"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#SET_OPAQUE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode SET_OPAQUE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "SET_OPAQUE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#SET_RELEASE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode SET_RELEASE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "SET_RELEASE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#SET_VOLATILE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode SET_VOLATILE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "SET_VOLATILE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#WEAK_COMPARE_AND_SET"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode WEAK_COMPARE_AND_SET { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "WEAK_COMPARE_AND_SET"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#WEAK_COMPARE_AND_SET_ACQUIRE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode WEAK_COMPARE_AND_SET_ACQUIRE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "WEAK_COMPARE_AND_SET_ACQUIRE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#WEAK_COMPARE_AND_SET_PLAIN"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode WEAK_COMPARE_AND_SET_PLAIN { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "WEAK_COMPARE_AND_SET_PLAIN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#WEAK_COMPARE_AND_SET_RELEASE"/>
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode WEAK_COMPARE_AND_SET_RELEASE { get { return SGetField<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "WEAK_COMPARE_AND_SET_RELEASE"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#values()"/> 
            /// </summary>
            public static Java.Lang.Invoke.VarHandle.AccessMode[] Values
            {
                get { return SExecuteArray<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#valueFromMethodName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Lang.Invoke.VarHandle.AccessMode"/></returns>
            public static Java.Lang.Invoke.VarHandle.AccessMode ValueFromMethodName(string arg0)
            {
                return SExecute<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "valueFromMethodName", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Lang.Invoke.VarHandle.AccessMode"/></returns>
            public static Java.Lang.Invoke.VarHandle.AccessMode ValueOf(string arg0)
            {
                return SExecute<Java.Lang.Invoke.VarHandle.AccessMode>(LocalClazz, "valueOf", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/VarHandle.AccessMode.html#methodName()"/> 
            /// </summary>
            public string MethodName
            {
                get { return IExecute<string>("methodName"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}