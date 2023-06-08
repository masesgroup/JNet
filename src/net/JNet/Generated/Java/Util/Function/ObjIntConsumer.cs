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

namespace Java.Util.Function
{
    #region ObjIntConsumer
    public partial class ObjIntConsumer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjIntConsumer.html#accept(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Accept(object arg0, int arg1)
        {
            IExecute("accept", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IObjIntConsumer<T>
    public partial interface IObjIntConsumer<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjIntConsumer.html#accept(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void Accept(T arg0, int arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ObjIntConsumer<T>
    public partial class ObjIntConsumer<T> : Java.Util.Function.IObjIntConsumer<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Function.ObjIntConsumer{T}"/> to <see cref="Java.Util.Function.ObjIntConsumer"/>
        /// </summary>
        public static implicit operator Java.Util.Function.ObjIntConsumer(Java.Util.Function.ObjIntConsumer<T> t) => t.Cast<Java.Util.Function.ObjIntConsumer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjIntConsumer.html#accept(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Accept(T arg0, int arg1)
        {
            IExecute("accept", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}