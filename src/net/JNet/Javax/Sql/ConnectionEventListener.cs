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

using MASES.JCOBridge.C2JBridge;
using System;

namespace Javax.Sql
{
    public interface IConnectionEventListener : IJVMBridgeBase
    {
        void ConnectionClosed(ConnectionEvent e);

        void ConnectionErrorOccurred(ConnectionEvent e);
    }

    /// <summary>
    /// Listener for ConnectionEventListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IConnectionEventListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class ConnectionEventListener : IConnectionEventListener
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.sql.JNetConnectionEventListener";

        readonly Action<ConnectionEvent> ConnectionClosedFunction = null;
        readonly Action<ConnectionEvent> ConnectionErrorOccurredFunction = null;
        /// <summary>
        /// The <see cref="Action{ConnectionEvent}"/> to be executed on ConnectionClosed
        /// </summary>
        public virtual Action<ConnectionEvent> OnConnectionClosed { get { return ConnectionClosedFunction; } }
        /// <summary>
        /// The <see cref="Action{ConnectionEvent}"/> to be executed on ConnectionErrorOccurred
        /// </summary>
        public virtual Action<ConnectionEvent> OnConnectionErrorOccurred { get { return ConnectionErrorOccurredFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="ConnectionEventListener"/>
        /// </summary>
        /// <param name="connectionClosed">The <see cref="Action{ConnectionEvent}"/> to be executed on ConnectionClosed</param>
        /// <param name="connectionErrorOccurred">The <see cref="Action{ConnectionEvent}"/> to be executed on ConnectionErrorOccurred</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public ConnectionEventListener(Action<ConnectionEvent> connectionClosed = null, Action<ConnectionEvent> connectionErrorOccurred = null, bool attachEventHandler = true)
        {
            if (connectionClosed != null) ConnectionClosedFunction = connectionClosed;
            else ConnectionClosedFunction = ConnectionClosed;
            if (connectionErrorOccurred != null) ConnectionErrorOccurredFunction = connectionErrorOccurred;
            else ConnectionErrorOccurredFunction = ConnectionErrorOccurred;

            if (attachEventHandler)
            {
                AddEventHandler("connectionClosed", new EventHandler<CLRListenerEventArgs<CLREventData<ConnectionEvent>>>(EventHandlerConnectionClosed));
                AddEventHandler("connectionErrorOccurred", new EventHandler<CLRListenerEventArgs<CLREventData<ConnectionEvent>>>(EventHandlerConnectionErrorOccurred));
            }
        }

        void EventHandlerConnectionClosed(object sender, CLRListenerEventArgs<CLREventData<ConnectionEvent>> data)
        {
            OnConnectionClosed(data.EventData.TypedEventData);
        }

        void EventHandlerConnectionErrorOccurred(object sender, CLRListenerEventArgs<CLREventData<ConnectionEvent>> data)
        {
            OnConnectionErrorOccurred(data.EventData.TypedEventData);
        }

        public virtual void ConnectionClosed(ConnectionEvent e)
        {

        }

        public virtual void ConnectionErrorOccurred(ConnectionEvent e)
        {

        }
    }
}
