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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
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
        Java.Lang.String Type { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#initEvent(java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        void InitEvent(Java.Lang.String arg0, bool arg1, bool arg2);
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
        public static short AT_TARGET { get { if (!_AT_TARGETReady) { _AT_TARGETContent = SGetField<short>(LocalBridgeClazz, "AT_TARGET"); _AT_TARGETReady = true; } return _AT_TARGETContent; } }
        private static short _AT_TARGETContent = default;
        private static bool _AT_TARGETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#BUBBLING_PHASE"/>
        /// </summary>
        public static short BUBBLING_PHASE { get { if (!_BUBBLING_PHASEReady) { _BUBBLING_PHASEContent = SGetField<short>(LocalBridgeClazz, "BUBBLING_PHASE"); _BUBBLING_PHASEReady = true; } return _BUBBLING_PHASEContent; } }
        private static short _BUBBLING_PHASEContent = default;
        private static bool _BUBBLING_PHASEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#CAPTURING_PHASE"/>
        /// </summary>
        public static short CAPTURING_PHASE { get { if (!_CAPTURING_PHASEReady) { _CAPTURING_PHASEContent = SGetField<short>(LocalBridgeClazz, "CAPTURING_PHASE"); _CAPTURING_PHASEReady = true; } return _CAPTURING_PHASEContent; } }
        private static short _CAPTURING_PHASEContent = default;
        private static bool _CAPTURING_PHASEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getBubbles()"/> 
        /// </summary>
        public bool Bubbles
        {
            get { return IExecuteWithSignature<bool>("getBubbles", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getCancelable()"/> 
        /// </summary>
        public bool Cancelable
        {
            get { return IExecuteWithSignature<bool>("getCancelable", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getCurrentTarget()"/> 
        /// </summary>
        public Org.W3c.Dom.Events.EventTarget CurrentTarget
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Events.EventTarget>("getCurrentTarget", "()Lorg/w3c/dom/events/EventTarget;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getEventPhase()"/> 
        /// </summary>
        public short EventPhase
        {
            get { return IExecuteWithSignature<short>("getEventPhase", "()S"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getTarget()"/> 
        /// </summary>
        public Org.W3c.Dom.Events.EventTarget Target
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Events.EventTarget>("getTarget", "()Lorg/w3c/dom/events/EventTarget;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getTimeStamp()"/> 
        /// </summary>
        public long TimeStamp
        {
            get { return IExecuteWithSignature<long>("getTimeStamp", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getType()"/> 
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#initEvent(java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void InitEvent(Java.Lang.String arg0, bool arg1, bool arg2)
        {
            IExecute("initEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#preventDefault()"/>
        /// </summary>
        public void PreventDefault()
        {
            IExecuteWithSignature("preventDefault", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#stopPropagation()"/>
        /// </summary>
        public void StopPropagation()
        {
            IExecuteWithSignature("stopPropagation", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}