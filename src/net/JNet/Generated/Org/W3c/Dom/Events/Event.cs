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

namespace Org.W3c.Dom.Events
{
    #region IEvent
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getBubbles()"/> 
        /// </summary>
        bool Bubbles { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getCancelable()"/> 
        /// </summary>
        bool Cancelable { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getCurrentTarget()"/> 
        /// </summary>
        Org.W3c.Dom.Events.EventTarget CurrentTarget { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getEventPhase()"/> 
        /// </summary>
        short EventPhase { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getTarget()"/> 
        /// </summary>
        Org.W3c.Dom.Events.EventTarget Target { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getTimeStamp()"/> 
        /// </summary>
        long TimeStamp { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getType()"/> 
        /// </summary>
        string Type { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#initEvent(java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        void InitEvent(string arg0, bool arg1, bool arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#preventDefault()"/>
        /// </summary>
        void PreventDefault();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#stopPropagation()"/>
        /// </summary>
        void StopPropagation();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Event
    public partial class Event : Org.W3c.Dom.Events.IEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#AT_TARGET"/>
        /// </summary>
        public static short AT_TARGET { get { return SGetField<short>(LocalBridgeClazz, "AT_TARGET"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#BUBBLING_PHASE"/>
        /// </summary>
        public static short BUBBLING_PHASE { get { return SGetField<short>(LocalBridgeClazz, "BUBBLING_PHASE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#CAPTURING_PHASE"/>
        /// </summary>
        public static short CAPTURING_PHASE { get { return SGetField<short>(LocalBridgeClazz, "CAPTURING_PHASE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getBubbles()"/> 
        /// </summary>
        public bool Bubbles
        {
            get { return IExecute<bool>("getBubbles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getCancelable()"/> 
        /// </summary>
        public bool Cancelable
        {
            get { return IExecute<bool>("getCancelable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getCurrentTarget()"/> 
        /// </summary>
        public Org.W3c.Dom.Events.EventTarget CurrentTarget
        {
            get { return IExecute<Org.W3c.Dom.Events.EventTarget>("getCurrentTarget"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getEventPhase()"/> 
        /// </summary>
        public short EventPhase
        {
            get { return IExecute<short>("getEventPhase"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getTarget()"/> 
        /// </summary>
        public Org.W3c.Dom.Events.EventTarget Target
        {
            get { return IExecute<Org.W3c.Dom.Events.EventTarget>("getTarget"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getTimeStamp()"/> 
        /// </summary>
        public long TimeStamp
        {
            get { return IExecute<long>("getTimeStamp"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getType()"/> 
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#initEvent(java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void InitEvent(string arg0, bool arg1, bool arg2)
        {
            IExecute("initEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#preventDefault()"/>
        /// </summary>
        public void PreventDefault()
        {
            IExecute("preventDefault");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#stopPropagation()"/>
        /// </summary>
        public void StopPropagation()
        {
            IExecute("stopPropagation");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}