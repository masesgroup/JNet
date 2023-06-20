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
    #region ToDoubleFunction
    public partial class ToDoubleFunction
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
        /// <see cref="ToDoubleFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsDouble", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(ApplyAsDoubleEventHandler)); OnApplyAsDouble = ApplyAsDouble;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleFunction.html#applyAsDouble(java.lang.Object)"/>
        /// </summary>
        public System.Func<object, double> OnApplyAsDouble { get; set; }

        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            if (OnApplyAsDouble != null)
            {
                var executionResult = OnApplyAsDouble.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleFunction.html#applyAsDouble(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="double"/></returns>
        public virtual double ApplyAsDouble(object arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IToDoubleFunction<T>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.ToDoubleFunction implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleFunction.html"/>
    /// </summary>
    public partial interface IToDoubleFunction<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleFunction.html#applyAsDouble(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="double"/></returns>
        double ApplyAsDouble(T arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToDoubleFunction<T>
    public partial class ToDoubleFunction<T> : Java.Util.Function.IToDoubleFunction<T>
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
        /// <see cref="ToDoubleFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsDouble", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(ApplyAsDoubleEventHandler)); OnApplyAsDouble = ApplyAsDouble;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleFunction.html#applyAsDouble(java.lang.Object)"/>
        /// </summary>
        public System.Func<T, double> OnApplyAsDouble { get; set; }

        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            if (OnApplyAsDouble != null)
            {
                var executionResult = OnApplyAsDouble.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleFunction.html#applyAsDouble(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="double"/></returns>
        public virtual double ApplyAsDouble(T arg0)
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