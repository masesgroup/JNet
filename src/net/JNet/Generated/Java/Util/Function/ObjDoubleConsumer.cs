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

namespace Java.Util.Function
{
    #region ObjDoubleConsumer
    public partial class ObjDoubleConsumer
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
        /// Handlers initializer for <see cref="ObjDoubleConsumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(AcceptEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjDoubleConsumer.html#accept(java.lang.Object,double)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<object, double> OnAccept { get; set; } = null;

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<double>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjDoubleConsumer.html#accept(java.lang.Object,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public virtual void Accept(object arg0, double arg1)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IObjDoubleConsumer<T>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.ObjDoubleConsumer implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjDoubleConsumer.html"/>
    /// </summary>
    public partial interface IObjDoubleConsumer<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjDoubleConsumer.html#accept(java.lang.Object,double)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        void Accept(T arg0, double arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ObjDoubleConsumer<T>
    public partial class ObjDoubleConsumer<T> : Java.Util.Function.IObjDoubleConsumer<T>
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
        /// Handlers initializer for <see cref="ObjDoubleConsumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(AcceptEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjDoubleConsumer.html#accept(java.lang.Object,double)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<T, double> OnAccept { get; set; } = null;

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<double>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjDoubleConsumer.html#accept(java.lang.Object,double)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public virtual void Accept(T arg0, double arg1)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}