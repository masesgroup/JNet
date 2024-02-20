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

namespace Java.Lang.Ref
{
    #region Reference
    public partial class Reference
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#reachabilityFence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public static void ReachabilityFence(object arg0)
        {
            SExecute(LocalBridgeClazz, "reachabilityFence", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#enqueue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Enqueue()
        {
            return IExecute<bool>("enqueue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#isEnqueued()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEnqueued()
        {
            return IExecute<bool>("isEnqueued");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#get()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Get()
        {
            return IExecute("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Reference<T>
    public partial class Reference<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Ref.Reference{T}"/> to <see cref="Java.Lang.Ref.Reference"/>
        /// </summary>
        public static implicit operator Java.Lang.Ref.Reference(Java.Lang.Ref.Reference<T> t) => t.Cast<Java.Lang.Ref.Reference>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#reachabilityFence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public static void ReachabilityFence(object arg0)
        {
            SExecute(LocalBridgeClazz, "reachabilityFence", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#enqueue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Enqueue()
        {
            return IExecute<bool>("enqueue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#isEnqueued()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEnqueued()
        {
            return IExecute<bool>("isEnqueued");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#get()"/>
        /// </summary>

        /// <returns><typeparamref name="T"/></returns>
        public T Get()
        {
            return IExecute<T>("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Reference.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}