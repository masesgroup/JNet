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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region IDoublePredicate
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.DoublePredicate implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html"/>
    /// </summary>
    public partial interface IDoublePredicate
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#test(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Test(double arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#and(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        Java.Util.Function.DoublePredicate And(Java.Util.Function.DoublePredicate arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        Java.Util.Function.DoublePredicate Negate();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#or(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        Java.Util.Function.DoublePredicate Or(Java.Util.Function.DoublePredicate arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DoublePredicate
    public partial class DoublePredicate : Java.Util.Function.IDoublePredicate
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
        /// Handlers initializer for <see cref="DoublePredicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new System.EventHandler<CLRListenerEventArgs<CLREventData<double>>>(TestEventHandler)); OnTest = Test;
            AddEventHandler("and", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.DoublePredicate>>>(AndEventHandler)); OnAnd = And;
            AddEventHandler("negate", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(NegateEventHandler)); OnNegate = Negate;
            AddEventHandler("or", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.DoublePredicate>>>(OrEventHandler)); OnOr = Or;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#test(double)"/>
        /// </summary>
        public System.Func<double, bool> OnTest { get; set; }

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            if (OnTest != null)
            {
                var executionResult = OnTest.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#test(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(double arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#and(java.util.function.DoublePredicate)"/>
        /// </summary>
        public System.Func<Java.Util.Function.DoublePredicate, Java.Util.Function.DoublePredicate> OnAnd { get; set; }

        void AndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.DoublePredicate>> data)
        {
            if (OnAnd != null)
            {
                var executionResult = OnAnd.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#and(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        public virtual Java.Util.Function.DoublePredicate And(Java.Util.Function.DoublePredicate arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#negate()"/>
        /// </summary>
        public System.Func<Java.Util.Function.DoublePredicate> OnNegate { get; set; }

        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnNegate != null)
            {
                var executionResult = OnNegate.Invoke();
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        public virtual Java.Util.Function.DoublePredicate Negate()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#or(java.util.function.DoublePredicate)"/>
        /// </summary>
        public System.Func<Java.Util.Function.DoublePredicate, Java.Util.Function.DoublePredicate> OnOr { get; set; }

        void OrEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.DoublePredicate>> data)
        {
            if (OnOr != null)
            {
                var executionResult = OnOr.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#or(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        public virtual Java.Util.Function.DoublePredicate Or(Java.Util.Function.DoublePredicate arg0)
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