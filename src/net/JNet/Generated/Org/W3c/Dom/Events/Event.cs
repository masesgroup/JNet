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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Events
{
    #region Event
    public partial class Event
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#CAPTURING_PHASE
        /// </summary>
        public static short CAPTURING_PHASE => Clazz.GetField<short>("CAPTURING_PHASE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#AT_TARGET
        /// </summary>
        public static short AT_TARGET => Clazz.GetField<short>("AT_TARGET");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#BUBBLING_PHASE
        /// </summary>
        public static short BUBBLING_PHASE => Clazz.GetField<short>("BUBBLING_PHASE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getBubbles() 
        /// </summary>
        public bool Bubbles
        {
            get { return IExecute<bool>("getBubbles"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getCancelable() 
        /// </summary>
        public bool Cancelable
        {
            get { return IExecute<bool>("getCancelable"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getCurrentTarget() 
        /// </summary>
        public Org.W3c.Dom.Events.EventTarget CurrentTarget
        {
            get { return IExecute<Org.W3c.Dom.Events.EventTarget>("getCurrentTarget"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getEventPhase() 
        /// </summary>
        public short EventPhase
        {
            get { return IExecute<short>("getEventPhase"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getTarget() 
        /// </summary>
        public Org.W3c.Dom.Events.EventTarget Target
        {
            get { return IExecute<Org.W3c.Dom.Events.EventTarget>("getTarget"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getTimeStamp() 
        /// </summary>
        public long TimeStamp
        {
            get { return IExecute<long>("getTimeStamp"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#getType() 
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#initEvent(java.lang.String,boolean,boolean)
        /// </summary>
        public void InitEvent(string arg0, bool arg1, bool arg2)
        {
            IExecute("initEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#preventDefault()
        /// </summary>
        public void PreventDefault()
        {
            IExecute("preventDefault");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/Event.html#stopPropagation()
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