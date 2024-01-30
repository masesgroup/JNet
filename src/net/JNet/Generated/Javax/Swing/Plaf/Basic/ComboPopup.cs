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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region IComboPopup
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IComboPopup
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#getKeyListener()"/> 
        /// </summary>
        Java.Awt.EventNs.KeyListener KeyListener { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#getList()"/> 
        /// </summary>
        Javax.Swing.JList<object> List { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#getMouseListener()"/> 
        /// </summary>
        Java.Awt.EventNs.MouseListener MouseListener { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#getMouseMotionListener()"/> 
        /// </summary>
        Java.Awt.EventNs.MouseMotionListener MouseMotionListener { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#isVisible()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsVisible();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#hide()"/>
        /// </summary>
        void Hide();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#show()"/>
        /// </summary>
        void Show();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#uninstallingUI()"/>
        /// </summary>
        void UninstallingUI();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ComboPopup
    public partial class ComboPopup : Javax.Swing.Plaf.Basic.IComboPopup
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#getKeyListener()"/> 
        /// </summary>
        public Java.Awt.EventNs.KeyListener KeyListener
        {
            get { return IExecute<Java.Awt.EventNs.KeyListener>("getKeyListener"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#getList()"/> 
        /// </summary>
        public Javax.Swing.JList<object> List
        {
            get { return IExecute<Javax.Swing.JList<object>>("getList"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#getMouseListener()"/> 
        /// </summary>
        public Java.Awt.EventNs.MouseListener MouseListener
        {
            get { return IExecute<Java.Awt.EventNs.MouseListener>("getMouseListener"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#getMouseMotionListener()"/> 
        /// </summary>
        public Java.Awt.EventNs.MouseMotionListener MouseMotionListener
        {
            get { return IExecute<Java.Awt.EventNs.MouseMotionListener>("getMouseMotionListener"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#isVisible()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVisible()
        {
            return IExecute<bool>("isVisible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#hide()"/>
        /// </summary>
        public void Hide()
        {
            IExecute("hide");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#show()"/>
        /// </summary>
        public void Show()
        {
            IExecute("show");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/ComboPopup.html#uninstallingUI()"/>
        /// </summary>
        public void UninstallingUI()
        {
            IExecute("uninstallingUI");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}