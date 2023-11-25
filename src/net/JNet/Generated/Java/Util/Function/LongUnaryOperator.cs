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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region ILongUnaryOperator
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.LongUnaryOperator implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html"/>
    /// </summary>
    public partial interface ILongUnaryOperator
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#applyAsLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        long ApplyAsLong(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#andThen(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        Java.Util.Function.LongUnaryOperator AndThen(Java.Util.Function.LongUnaryOperator arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#compose(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        Java.Util.Function.LongUnaryOperator Compose(Java.Util.Function.LongUnaryOperator arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongUnaryOperator
    public partial class LongUnaryOperator : Java.Util.Function.ILongUnaryOperator
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
        /// Handlers initializer for <see cref="LongUnaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsLong", new System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyAsLongEventHandler));
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.LongUnaryOperator>>>(AndThenEventHandler));
            AddEventHandler("compose", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.LongUnaryOperator>>>(ComposeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#applyAsLong(long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsLong"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<long, long> OnApplyAsLong { get; set; } = null;

        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnApplyAsLong != null) ? OnApplyAsLong : ApplyAsLong;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#applyAsLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long ApplyAsLong(long arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#andThen(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.LongUnaryOperator, Java.Util.Function.LongUnaryOperator> OnAndThen { get; set; } = null;

        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.LongUnaryOperator>> data)
        {
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#andThen(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        public virtual Java.Util.Function.LongUnaryOperator AndThen(Java.Util.Function.LongUnaryOperator arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#compose(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCompose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.LongUnaryOperator, Java.Util.Function.LongUnaryOperator> OnCompose { get; set; } = null;

        void ComposeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.LongUnaryOperator>> data)
        {
            var methodToExecute = (OnCompose != null) ? OnCompose : Compose;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#compose(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        public virtual Java.Util.Function.LongUnaryOperator Compose(Java.Util.Function.LongUnaryOperator arg0)
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