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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region AWTEventListenerProxy
    public partial class AWTEventListenerProxy
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AWTEventListenerProxy.html#%3Cinit%3E(long,java.awt.event.AWTEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Awt.EventNs.AWTEventListener"/></param>
        public AWTEventListenerProxy(long arg0, Java.Awt.EventNs.AWTEventListener arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.EventNs.AWTEventListenerProxy"/> to <see cref="Java.Awt.EventNs.AWTEventListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.AWTEventListener(Java.Awt.EventNs.AWTEventListenerProxy t) => t.Cast<Java.Awt.EventNs.AWTEventListener>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AWTEventListenerProxy.html#getEventMask()"/> 
        /// </summary>
        public long EventMask
        {
            get { return IExecuteWithSignature<long>("getEventMask", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AWTEventListenerProxy.html#eventDispatched(java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        public void EventDispatched(Java.Awt.AWTEvent arg0)
        {
            IExecuteWithSignature("eventDispatched", "(Ljava/awt/AWTEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}