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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region HyperlinkEvent
    public partial class HyperlinkEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.html#%3Cinit%3E(java.lang.Object,javax.swing.event.HyperlinkEvent.EventType,java.net.URL,java.lang.String,javax.swing.text.Element,java.awt.event.InputEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Event.HyperlinkEvent.EventType"/></param>
        /// <param name="arg2"><see cref="Java.Net.URL"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg5"><see cref="Java.Awt.EventNs.InputEvent"/></param>
        public HyperlinkEvent(object arg0, Javax.Swing.Event.HyperlinkEvent.EventType arg1, Java.Net.URL arg2, string arg3, Javax.Swing.Text.Element arg4, Java.Awt.EventNs.InputEvent arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.html#%3Cinit%3E(java.lang.Object,javax.swing.event.HyperlinkEvent.EventType,java.net.URL,java.lang.String,javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Event.HyperlinkEvent.EventType"/></param>
        /// <param name="arg2"><see cref="Java.Net.URL"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.Element"/></param>
        public HyperlinkEvent(object arg0, Javax.Swing.Event.HyperlinkEvent.EventType arg1, Java.Net.URL arg2, string arg3, Javax.Swing.Text.Element arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.html#%3Cinit%3E(java.lang.Object,javax.swing.event.HyperlinkEvent.EventType,java.net.URL,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Event.HyperlinkEvent.EventType"/></param>
        /// <param name="arg2"><see cref="Java.Net.URL"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        public HyperlinkEvent(object arg0, Javax.Swing.Event.HyperlinkEvent.EventType arg1, Java.Net.URL arg2, string arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.html#%3Cinit%3E(java.lang.Object,javax.swing.event.HyperlinkEvent.EventType,java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Event.HyperlinkEvent.EventType"/></param>
        /// <param name="arg2"><see cref="Java.Net.URL"/></param>
        public HyperlinkEvent(object arg0, Javax.Swing.Event.HyperlinkEvent.EventType arg1, Java.Net.URL arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.html#getDescription()"/> 
        /// </summary>
        public string Description
        {
            get { return IExecute<string>("getDescription"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.html#getEventType()"/> 
        /// </summary>
        public Javax.Swing.Event.HyperlinkEvent.EventType GetEventType
        {
            get { return IExecute<Javax.Swing.Event.HyperlinkEvent.EventType>("getEventType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.html#getInputEvent()"/> 
        /// </summary>
        public Java.Awt.EventNs.InputEvent InputEvent
        {
            get { return IExecute<Java.Awt.EventNs.InputEvent>("getInputEvent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.html#getSourceElement()"/> 
        /// </summary>
        public Javax.Swing.Text.Element SourceElement
        {
            get { return IExecute<Javax.Swing.Text.Element>("getSourceElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.html#getURL()"/> 
        /// </summary>
        public Java.Net.URL URL
        {
            get { return IExecute<Java.Net.URL>("getURL"); }
        }
        
        #endregion

        #region Nested classes
        #region EventType
        public partial class EventType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.EventType.html#ACTIVATED"/>
            /// </summary>
            public static Javax.Swing.Event.HyperlinkEvent.EventType ACTIVATED => LocalClazz.GetField<Javax.Swing.Event.HyperlinkEvent.EventType>("ACTIVATED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.EventType.html#ENTERED"/>
            /// </summary>
            public static Javax.Swing.Event.HyperlinkEvent.EventType ENTERED => LocalClazz.GetField<Javax.Swing.Event.HyperlinkEvent.EventType>("ENTERED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkEvent.EventType.html#EXITED"/>
            /// </summary>
            public static Javax.Swing.Event.HyperlinkEvent.EventType EXITED => LocalClazz.GetField<Javax.Swing.Event.HyperlinkEvent.EventType>("EXITED");
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}