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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region IIntSupplier
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.IntSupplier implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntSupplier.html"/>
    /// </summary>
    public partial interface IIntSupplier
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntSupplier.html#getAsInt()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        int GetAsInt();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntSupplier
    public partial class IntSupplier : Java.Util.Function.IIntSupplier
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
        /// Handlers initializer for <see cref="IntSupplier"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getAsInt", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetAsIntEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntSupplier.html#getAsInt()"/>
        /// </summary>
        public System.Func<int> OnGetAsInt { get; set; }

        void GetAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetAsInt != null) ? OnGetAsInt : GetAsInt;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntSupplier.html#getAsInt()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public virtual int GetAsInt()
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