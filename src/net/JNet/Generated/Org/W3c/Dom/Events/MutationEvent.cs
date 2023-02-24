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
    #region MutationEvent
    public partial class MutationEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.W3c.Dom.Events.MutationEvent"/> to <see cref="Org.W3c.Dom.Events.Event"/>
        /// </summary>
        public static implicit operator Org.W3c.Dom.Events.Event(Org.W3c.Dom.Events.MutationEvent t) => t.Cast<Org.W3c.Dom.Events.Event>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#ADDITION"/>
        /// </summary>
        public static short ADDITION => Clazz.GetField<short>("ADDITION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#MODIFICATION"/>
        /// </summary>
        public static short MODIFICATION => Clazz.GetField<short>("MODIFICATION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#REMOVAL"/>
        /// </summary>
        public static short REMOVAL => Clazz.GetField<short>("REMOVAL");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getAttrChange()"/> 
        /// </summary>
        public short AttrChange
        {
            get { return IExecute<short>("getAttrChange"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getAttrName()"/> 
        /// </summary>
        public string AttrName
        {
            get { return IExecute<string>("getAttrName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getNewValue()"/> 
        /// </summary>
        public string NewValue
        {
            get { return IExecute<string>("getNewValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getPrevValue()"/> 
        /// </summary>
        public string PrevValue
        {
            get { return IExecute<string>("getPrevValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getRelatedNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node RelatedNode
        {
            get { return IExecute<Org.W3c.Dom.Node>("getRelatedNode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#initMutationEvent(java.lang.String,boolean,boolean,org.w3c.dom.Node,java.lang.String,java.lang.String,java.lang.String,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="string"/></param>
        /// <param name="arg7"><see cref="short"/></param>
        public void InitMutationEvent(string arg0, bool arg1, bool arg2, Org.W3c.Dom.Node arg3, string arg4, string arg5, string arg6, short arg7)
        {
            IExecute("initMutationEvent", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}