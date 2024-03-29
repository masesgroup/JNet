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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region LongFunction
    public partial class LongFunction
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
        /// Handlers initializer for <see cref="LongFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongFunction.html#apply(long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApply"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<long, object> OnApply { get; set; } = null;

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnApply != null) ? OnApply : Apply;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongFunction.html#apply(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object Apply(long arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ILongFunction<R>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.LongFunction implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongFunction.html"/>
    /// </summary>
    public partial interface ILongFunction<R>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongFunction.html#apply(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R Apply(long arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongFunction<R>
    public partial class LongFunction<R> : Java.Util.Function.ILongFunction<R>
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
        /// Handlers initializer for <see cref="LongFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongFunction.html#apply(long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApply"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<long, R> OnApply { get; set; } = null;

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnApply != null) ? OnApply : Apply;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongFunction.html#apply(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public virtual R Apply(long arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}