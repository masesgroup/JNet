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
    #region IMenuElement
    public partial interface IMenuElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#getComponent()"/> 
        /// </summary>
        Java.Awt.Component Component { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#getSubElements()"/> 
        /// </summary>
        Javax.Swing.MenuElement[] SubElements { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#menuSelectionChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void MenuSelectionChanged(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#processKeyEvent(java.awt.event.KeyEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        void ProcessKeyEvent(Java.Awt.EventNs.KeyEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#processMouseEvent(java.awt.event.MouseEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        void ProcessMouseEvent(Java.Awt.EventNs.MouseEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuElement
    public partial class MenuElement : Javax.Swing.IMenuElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#getComponent()"/> 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecute<Java.Awt.Component>("getComponent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#getSubElements()"/> 
        /// </summary>
        public Javax.Swing.MenuElement[] SubElements
        {
            get { return IExecuteArray<Javax.Swing.MenuElement>("getSubElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#menuSelectionChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void MenuSelectionChanged(bool arg0)
        {
            IExecute("menuSelectionChanged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#processKeyEvent(java.awt.event.KeyEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        public void ProcessKeyEvent(Java.Awt.EventNs.KeyEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2)
        {
            IExecute("processKeyEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/MenuElement.html#processMouseEvent(java.awt.event.MouseEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        public void ProcessMouseEvent(Java.Awt.EventNs.MouseEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2)
        {
            IExecute("processMouseEvent", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}