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

namespace Java.Awt
{
    #region KeyboardFocusManager
    public partial class KeyboardFocusManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.KeyboardFocusManager"/> to <see cref="Java.Awt.KeyEventDispatcher"/>
        /// </summary>
        public static implicit operator Java.Awt.KeyEventDispatcher(Java.Awt.KeyboardFocusManager t) => t.Cast<Java.Awt.KeyEventDispatcher>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.KeyboardFocusManager"/> to <see cref="Java.Awt.KeyEventPostProcessor"/>
        /// </summary>
        public static implicit operator Java.Awt.KeyEventPostProcessor(Java.Awt.KeyboardFocusManager t) => t.Cast<Java.Awt.KeyEventPostProcessor>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#BACKWARD_TRAVERSAL_KEYS"/>
        /// </summary>
        public static int BACKWARD_TRAVERSAL_KEYS => Clazz.GetField<int>("BACKWARD_TRAVERSAL_KEYS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#DOWN_CYCLE_TRAVERSAL_KEYS"/>
        /// </summary>
        public static int DOWN_CYCLE_TRAVERSAL_KEYS => Clazz.GetField<int>("DOWN_CYCLE_TRAVERSAL_KEYS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#FORWARD_TRAVERSAL_KEYS"/>
        /// </summary>
        public static int FORWARD_TRAVERSAL_KEYS => Clazz.GetField<int>("FORWARD_TRAVERSAL_KEYS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#UP_CYCLE_TRAVERSAL_KEYS"/>
        /// </summary>
        public static int UP_CYCLE_TRAVERSAL_KEYS => Clazz.GetField<int>("UP_CYCLE_TRAVERSAL_KEYS");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getCurrentKeyboardFocusManager()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#setCurrentKeyboardFocusManager(java.awt.KeyboardFocusManager)"/>
        /// </summary>
        public static Java.Awt.KeyboardFocusManager CurrentKeyboardFocusManager
        {
            get { return SExecute<Java.Awt.KeyboardFocusManager>("getCurrentKeyboardFocusManager"); } set { SExecute("setCurrentKeyboardFocusManager", value); }
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getActiveWindow()"/> 
        /// </summary>
        public Java.Awt.Window ActiveWindow
        {
            get { return IExecute<Java.Awt.Window>("getActiveWindow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getCurrentFocusCycleRoot()"/> 
        /// </summary>
        public Java.Awt.Container CurrentFocusCycleRoot
        {
            get { return IExecute<Java.Awt.Container>("getCurrentFocusCycleRoot"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getDefaultFocusTraversalPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#setDefaultFocusTraversalPolicy(java.awt.FocusTraversalPolicy)"/>
        /// </summary>
        public Java.Awt.FocusTraversalPolicy DefaultFocusTraversalPolicy
        {
            get { return IExecute<Java.Awt.FocusTraversalPolicy>("getDefaultFocusTraversalPolicy"); } set { IExecute("setDefaultFocusTraversalPolicy", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getFocusedWindow()"/> 
        /// </summary>
        public Java.Awt.Window FocusedWindow
        {
            get { return IExecute<Java.Awt.Window>("getFocusedWindow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component FocusOwner
        {
            get { return IExecute<Java.Awt.Component>("getFocusOwner"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getPermanentFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component PermanentFocusOwner
        {
            get { return IExecute<Java.Awt.Component>("getPermanentFocusOwner"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getVetoableChangeListeners()"/> 
        /// </summary>
        public Java.Beans.VetoableChangeListener[] VetoableChangeListeners
        {
            get { return IExecuteArray<Java.Beans.VetoableChangeListener>("getVetoableChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#dispatchEvent(java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool DispatchEvent(Java.Awt.AWTEvent arg0)
        {
            return IExecute<bool>("dispatchEvent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#dispatchKeyEvent(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool DispatchKeyEvent(Java.Awt.EventNs.KeyEvent arg0)
        {
            return IExecute<bool>("dispatchKeyEvent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#postProcessKeyEvent(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool PostProcessKeyEvent(Java.Awt.EventNs.KeyEvent arg0)
        {
            return IExecute<bool>("postProcessKeyEvent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#downFocusCycle(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void DownFocusCycle(Java.Awt.Container arg0)
        {
            IExecute("downFocusCycle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#focusNextComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void FocusNextComponent(Java.Awt.Component arg0)
        {
            IExecute("focusNextComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#focusPreviousComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void FocusPreviousComponent(Java.Awt.Component arg0)
        {
            IExecute("focusPreviousComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#processKeyEvent(java.awt.Component,java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public void ProcessKeyEvent(Java.Awt.Component arg0, Java.Awt.EventNs.KeyEvent arg1)
        {
            IExecute("processKeyEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#upFocusCycle(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void UpFocusCycle(Java.Awt.Component arg0)
        {
            IExecute("upFocusCycle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#downFocusCycle()"/>
        /// </summary>
        public void DownFocusCycle()
        {
            IExecute("downFocusCycle");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#focusNextComponent()"/>
        /// </summary>
        public void FocusNextComponent()
        {
            IExecute("focusNextComponent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#focusPreviousComponent()"/>
        /// </summary>
        public void FocusPreviousComponent()
        {
            IExecute("focusPreviousComponent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#redispatchEvent(java.awt.Component,java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.AWTEvent"/></param>
        public void RedispatchEvent(Java.Awt.Component arg0, Java.Awt.AWTEvent arg1)
        {
            IExecute("redispatchEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#upFocusCycle()"/>
        /// </summary>
        public void UpFocusCycle()
        {
            IExecute("upFocusCycle");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getDefaultFocusTraversalKeys(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set GetDefaultFocusTraversalKeys(int arg0)
        {
            return IExecute<Java.Util.Set>("getDefaultFocusTraversalKeys", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getPropertyChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener[] GetPropertyChangeListeners(string arg0)
        {
            return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getVetoableChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Beans.VetoableChangeListener"/></returns>
        public Java.Beans.VetoableChangeListener[] GetVetoableChangeListeners(string arg0)
        {
            return IExecuteArray<Java.Beans.VetoableChangeListener>("getVetoableChangeListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addKeyEventDispatcher(java.awt.KeyEventDispatcher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.KeyEventDispatcher"/></param>
        public void AddKeyEventDispatcher(Java.Awt.KeyEventDispatcher arg0)
        {
            IExecute("addKeyEventDispatcher", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addKeyEventPostProcessor(java.awt.KeyEventPostProcessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.KeyEventPostProcessor"/></param>
        public void AddKeyEventPostProcessor(Java.Awt.KeyEventPostProcessor arg0)
        {
            IExecute("addKeyEventPostProcessor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("addPropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("addPropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecute("addVetoableChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(string arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("addVetoableChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#clearFocusOwner()"/>
        /// </summary>
        public void ClearFocusOwner()
        {
            IExecute("clearFocusOwner");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#clearGlobalFocusOwner()"/>
        /// </summary>
        
        /// <exception cref="Java.Lang.SecurityException"/>
        public void ClearGlobalFocusOwner()
        {
            IExecute("clearGlobalFocusOwner");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removeKeyEventDispatcher(java.awt.KeyEventDispatcher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.KeyEventDispatcher"/></param>
        public void RemoveKeyEventDispatcher(Java.Awt.KeyEventDispatcher arg0)
        {
            IExecute("removeKeyEventDispatcher", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removeKeyEventPostProcessor(java.awt.KeyEventPostProcessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.KeyEventPostProcessor"/></param>
        public void RemoveKeyEventPostProcessor(Java.Awt.KeyEventPostProcessor arg0)
        {
            IExecute("removeKeyEventPostProcessor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("removePropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("removePropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removeVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecute("removeVetoableChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removeVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(string arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("removeVetoableChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#setDefaultFocusTraversalKeys(int,java.util.Set%3C? extends java.awt.AWTKeyStroke%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        public void SetDefaultFocusTraversalKeys(int arg0, Java.Util.Set arg1)
        {
            IExecute("setDefaultFocusTraversalKeys", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#setGlobalCurrentFocusCycleRoot(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void SetGlobalCurrentFocusCycleRoot(Java.Awt.Container arg0)
        {
            IExecute("setGlobalCurrentFocusCycleRoot", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}