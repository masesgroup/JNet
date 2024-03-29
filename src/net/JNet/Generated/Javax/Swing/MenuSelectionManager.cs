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

namespace Javax.Swing
{
    #region MenuSelectionManager
    public partial class MenuSelectionManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#defaultManager()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.MenuSelectionManager"/></returns>
        public static Javax.Swing.MenuSelectionManager DefaultManager()
        {
            return SExecuteWithSignature<Javax.Swing.MenuSelectionManager>(LocalBridgeClazz, "defaultManager", "()Ljavax/swing/MenuSelectionManager;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ChangeListener>("getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#getSelectedPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#setSelectedPath(javax.swing.MenuElement[])"/>
        /// </summary>
        public Javax.Swing.MenuElement[] SelectedPath
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.MenuElement>("getSelectedPath", "()[Ljavax/swing/MenuElement;"); } set { IExecuteWithSignature("setSelectedPath", "([Ljavax/swing/MenuElement;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#isComponentPartOfCurrentMenu(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsComponentPartOfCurrentMenu(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<bool>("isComponentPartOfCurrentMenu", "(Ljava/awt/Component;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#componentForPoint(java.awt.Component,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component ComponentForPoint(Java.Awt.Component arg0, Java.Awt.Point arg1)
        {
            return IExecute<Java.Awt.Component>("componentForPoint", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#clearSelectedPath()"/>
        /// </summary>
        public void ClearSelectedPath()
        {
            IExecuteWithSignature("clearSelectedPath", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#processKeyEvent(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public void ProcessKeyEvent(Java.Awt.EventNs.KeyEvent arg0)
        {
            IExecuteWithSignature("processKeyEvent", "(Ljava/awt/event/KeyEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#processMouseEvent(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void ProcessMouseEvent(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("processMouseEvent", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuSelectionManager.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}