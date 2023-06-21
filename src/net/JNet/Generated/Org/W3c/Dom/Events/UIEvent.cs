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
    #region IUIEvent
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IUIEvent : Org.W3c.Dom.Events.IEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/UIEvent.html#getDetail()"/> 
        /// </summary>
        int Detail { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/UIEvent.html#getView()"/> 
        /// </summary>
        Org.W3c.Dom.Views.AbstractView View { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/UIEvent.html#initUIEvent(java.lang.String,boolean,boolean,org.w3c.dom.views.AbstractView,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Org.W3c.Dom.Views.AbstractView"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        void InitUIEvent(string arg0, bool arg1, bool arg2, Org.W3c.Dom.Views.AbstractView arg3, int arg4);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UIEvent
    public partial class UIEvent : Org.W3c.Dom.Events.IUIEvent
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/UIEvent.html#getDetail()"/> 
        /// </summary>
        public int Detail
        {
            get { return IExecute<int>("getDetail"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/UIEvent.html#getView()"/> 
        /// </summary>
        public Org.W3c.Dom.Views.AbstractView View
        {
            get { return IExecute<Org.W3c.Dom.Views.AbstractView>("getView"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/UIEvent.html#initUIEvent(java.lang.String,boolean,boolean,org.w3c.dom.views.AbstractView,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Org.W3c.Dom.Views.AbstractView"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void InitUIEvent(string arg0, bool arg1, bool arg2, Org.W3c.Dom.Views.AbstractView arg3, int arg4)
        {
            IExecute("initUIEvent", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}