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

namespace Javax.Net.Ssl
{
    #region ISSLSessionBindingListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.net.ssl.SSLSessionBindingListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionBindingListener.html"/>
    /// </summary>
    public partial interface ISSLSessionBindingListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionBindingListener.html#valueBound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSessionBindingEvent"/></param>
        void ValueBound(Javax.Net.Ssl.SSLSessionBindingEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionBindingListener.html#valueUnbound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSessionBindingEvent"/></param>
        void ValueUnbound(Javax.Net.Ssl.SSLSessionBindingEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SSLSessionBindingListener
    public partial class SSLSessionBindingListener : Javax.Net.Ssl.ISSLSessionBindingListener
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
        /// Handlers initializer for <see cref="SSLSessionBindingListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("valueBound", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Net.Ssl.SSLSessionBindingEvent>>>(ValueBoundEventHandler));
            AddEventHandler("valueUnbound", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Net.Ssl.SSLSessionBindingEvent>>>(ValueUnboundEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionBindingListener.html#valueBound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnValueBound"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Net.Ssl.SSLSessionBindingEvent> OnValueBound { get; set; } = null;

        void ValueBoundEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Net.Ssl.SSLSessionBindingEvent>> data)
        {
            var methodToExecute = (OnValueBound != null) ? OnValueBound : ValueBound;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionBindingListener.html#valueBound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSessionBindingEvent"/></param>
        public virtual void ValueBound(Javax.Net.Ssl.SSLSessionBindingEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionBindingListener.html#valueUnbound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnValueUnbound"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Net.Ssl.SSLSessionBindingEvent> OnValueUnbound { get; set; } = null;

        void ValueUnboundEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Net.Ssl.SSLSessionBindingEvent>> data)
        {
            var methodToExecute = (OnValueUnbound != null) ? OnValueUnbound : ValueUnbound;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionBindingListener.html#valueUnbound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSessionBindingEvent"/></param>
        public virtual void ValueUnbound(Javax.Net.Ssl.SSLSessionBindingEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}