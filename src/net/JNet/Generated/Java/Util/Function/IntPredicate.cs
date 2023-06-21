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
    #region IIntPredicate
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.IntPredicate implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html"/>
    /// </summary>
    public partial interface IIntPredicate
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#test(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Test(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#and(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        Java.Util.Function.IntPredicate And(Java.Util.Function.IntPredicate arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        Java.Util.Function.IntPredicate Negate();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#or(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        Java.Util.Function.IntPredicate Or(Java.Util.Function.IntPredicate arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntPredicate
    public partial class IntPredicate : Java.Util.Function.IIntPredicate
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
        /// <see cref="IntPredicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(TestEventHandler)); OnTest = Test;
            AddEventHandler("and", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.IntPredicate>>>(AndEventHandler)); OnAnd = And;
            AddEventHandler("negate", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(NegateEventHandler)); OnNegate = Negate;
            AddEventHandler("or", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.IntPredicate>>>(OrEventHandler)); OnOr = Or;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#test(int)"/>
        /// </summary>
        public System.Func<int, bool> OnTest { get; set; }

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            if (OnTest != null)
            {
                var executionResult = OnTest.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#test(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#and(java.util.function.IntPredicate)"/>
        /// </summary>
        public System.Func<Java.Util.Function.IntPredicate, Java.Util.Function.IntPredicate> OnAnd { get; set; }

        void AndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.IntPredicate>> data)
        {
            if (OnAnd != null)
            {
                var executionResult = OnAnd.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#and(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        public virtual Java.Util.Function.IntPredicate And(Java.Util.Function.IntPredicate arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#negate()"/>
        /// </summary>
        public System.Func<Java.Util.Function.IntPredicate> OnNegate { get; set; }

        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnNegate != null)
            {
                var executionResult = OnNegate.Invoke();
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        public virtual Java.Util.Function.IntPredicate Negate()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#or(java.util.function.IntPredicate)"/>
        /// </summary>
        public System.Func<Java.Util.Function.IntPredicate, Java.Util.Function.IntPredicate> OnOr { get; set; }

        void OrEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.IntPredicate>> data)
        {
            if (OnOr != null)
            {
                var executionResult = OnOr.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#or(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        public virtual Java.Util.Function.IntPredicate Or(Java.Util.Function.IntPredicate arg0)
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