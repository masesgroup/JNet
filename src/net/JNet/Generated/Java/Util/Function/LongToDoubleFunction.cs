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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region ILongToDoubleFunction
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.LongToDoubleFunction implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongToDoubleFunction.html"/>
    /// </summary>
    public partial interface ILongToDoubleFunction
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongToDoubleFunction.html#applyAsDouble(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="double"/></returns>
        double ApplyAsDouble(long arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongToDoubleFunction
    public partial class LongToDoubleFunction : Java.Util.Function.ILongToDoubleFunction
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
        /// Handlers initializer for <see cref="LongToDoubleFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsDouble", new System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyAsDoubleEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongToDoubleFunction.html#applyAsDouble(long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsDouble"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<long, double> OnApplyAsDouble { get; set; } = null;

        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnApplyAsDouble != null) ? OnApplyAsDouble : ApplyAsDouble;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongToDoubleFunction.html#applyAsDouble(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="double"/></returns>
        public virtual double ApplyAsDouble(long arg0)
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