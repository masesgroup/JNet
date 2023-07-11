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
    #region ILongSupplier
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.LongSupplier implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongSupplier.html"/>
    /// </summary>
    public partial interface ILongSupplier
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongSupplier.html#getAsLong()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        long GetAsLong();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongSupplier
    public partial class LongSupplier : Java.Util.Function.ILongSupplier
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
        /// Handlers initializer for <see cref="LongSupplier"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getAsLong", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetAsLongEventHandler)); OnGetAsLong = GetAsLong;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongSupplier.html#getAsLong()"/>
        /// </summary>
        public System.Func<long> OnGetAsLong { get; set; }

        void GetAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnGetAsLong != null)
            {
                var executionResult = OnGetAsLong.Invoke();
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongSupplier.html#getAsLong()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public virtual long GetAsLong()
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