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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf
{
    #region LayerUI
    public partial class LayerUI
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.LayerUI"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Plaf.LayerUI t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#imageUpdate(java.awt.Image,int,int,int,int,int,javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Javax.Swing.JLayer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ImageUpdate(Java.Awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5, Javax.Swing.JLayer arg6)
        {
            return IExecute<bool>("imageUpdate", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#getPropertyChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener[] GetPropertyChangeListeners(string arg0)
        {
            return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("addPropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("addPropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#applyPropertyChange(java.beans.PropertyChangeEvent,javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JLayer"/></param>
        public void ApplyPropertyChange(Java.Beans.PropertyChangeEvent arg0, Javax.Swing.JLayer arg1)
        {
            IExecute("applyPropertyChange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#doLayout(javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JLayer"/></param>
        public void DoLayout(Javax.Swing.JLayer arg0)
        {
            IExecute("doLayout", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#eventDispatched(java.awt.AWTEvent,javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JLayer"/></param>
        public void EventDispatched(Java.Awt.AWTEvent arg0, Javax.Swing.JLayer arg1)
        {
            IExecute("eventDispatched", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#paintImmediately(int,int,int,int,javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.JLayer"/></param>
        public void PaintImmediately(int arg0, int arg1, int arg2, int arg3, Javax.Swing.JLayer arg4)
        {
            IExecute("paintImmediately", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("removePropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("removePropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#updateUI(javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JLayer"/></param>
        public void UpdateUI(Javax.Swing.JLayer arg0)
        {
            IExecute("updateUI", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LayerUI<V>
    public partial class LayerUI<V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.LayerUI{V}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Plaf.LayerUI<V> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.LayerUI{V}"/> to <see cref="Javax.Swing.Plaf.LayerUI"/>
        /// </summary>
        public static implicit operator Javax.Swing.Plaf.LayerUI(Javax.Swing.Plaf.LayerUI<V> t) => t.Cast<Javax.Swing.Plaf.LayerUI>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#imageUpdate(java.awt.Image,int,int,int,int,int,javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Javax.Swing.JLayer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ImageUpdate(Java.Awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5, Javax.Swing.JLayer arg6)
        {
            return IExecute<bool>("imageUpdate", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#getPropertyChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener[] GetPropertyChangeListeners(string arg0)
        {
            return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("addPropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("addPropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#applyPropertyChange(java.beans.PropertyChangeEvent,javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JLayer"/></param>
        public void ApplyPropertyChange(Java.Beans.PropertyChangeEvent arg0, Javax.Swing.JLayer arg1)
        {
            IExecute("applyPropertyChange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#doLayout(javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JLayer"/></param>
        public void DoLayout(Javax.Swing.JLayer arg0)
        {
            IExecute("doLayout", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#eventDispatched(java.awt.AWTEvent,javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JLayer"/></param>
        public void EventDispatched(Java.Awt.AWTEvent arg0, Javax.Swing.JLayer arg1)
        {
            IExecute("eventDispatched", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#paintImmediately(int,int,int,int,javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.JLayer"/></param>
        public void PaintImmediately(int arg0, int arg1, int arg2, int arg3, Javax.Swing.JLayer arg4)
        {
            IExecute("paintImmediately", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("removePropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("removePropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/LayerUI.html#updateUI(javax.swing.JLayer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JLayer"/></param>
        public void UpdateUI(Javax.Swing.JLayer arg0)
        {
            IExecute("updateUI", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}