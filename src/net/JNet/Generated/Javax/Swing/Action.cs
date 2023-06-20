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

namespace Javax.Swing
{
    #region IAction
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.Action implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html"/>
    /// </summary>
    public partial interface IAction
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsEnabled();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetValue(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        void PutValue(string arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetEnabled(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Accept(object arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Action
    public partial class Action : Javax.Swing.IAction
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
        /// <see cref="Action"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("isEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(IsEnabledEventHandler)); OnIsEnabled = IsEnabled;
            AddEventHandler("getValue", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(GetValueEventHandler)); OnGetValue = GetValue;
            AddEventHandler("addPropertyChangeListener", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeListener>>>(AddPropertyChangeListenerEventHandler)); OnAddPropertyChangeListener = AddPropertyChangeListener;
            AddEventHandler("putValue", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(PutValueEventHandler)); OnPutValue = PutValue;
            AddEventHandler("removePropertyChangeListener", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeListener>>>(RemovePropertyChangeListenerEventHandler)); OnRemovePropertyChangeListener = RemovePropertyChangeListener;
            AddEventHandler("setEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(SetEnabledEventHandler)); OnSetEnabled = SetEnabled;
            AddEventHandler("accept", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(AcceptEventHandler)); OnAccept = Accept;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>
        public System.Func<bool> OnIsEnabled { get; set; }

        void IsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnIsEnabled != null)
            {
                var executionResult = OnIsEnabled.Invoke();
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEnabled()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        public System.Func<string, object> OnGetValue { get; set; }

        void GetValueEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            if (OnGetValue != null)
            {
                var executionResult = OnGetValue.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object GetValue(string arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        public System.Action<Java.Beans.PropertyChangeListener> OnAddPropertyChangeListener { get; set; }

        void AddPropertyChangeListenerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeListener>> data)
        {
            if (OnAddPropertyChangeListener != null) OnAddPropertyChangeListener.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public virtual void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        public System.Action<string, object> OnPutValue { get; set; }

        void PutValueEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            if (OnPutValue != null) OnPutValue.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public virtual void PutValue(string arg0, object arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        public System.Action<Java.Beans.PropertyChangeListener> OnRemovePropertyChangeListener { get; set; }

        void RemovePropertyChangeListenerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeListener>> data)
        {
            if (OnRemovePropertyChangeListener != null) OnRemovePropertyChangeListener.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public virtual void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        public System.Action<bool> OnSetEnabled { get; set; }

        void SetEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
        {
            if (OnSetEnabled != null) OnSetEnabled.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public virtual void SetEnabled(bool arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        public System.Func<object, bool> OnAccept { get; set; }

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            if (OnAccept != null)
            {
                var executionResult = OnAccept.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Accept(object arg0)
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