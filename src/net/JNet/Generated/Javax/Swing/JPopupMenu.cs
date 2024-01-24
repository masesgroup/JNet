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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JPopupMenu
    public partial class JPopupMenu
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public JPopupMenu(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JPopupMenu"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JPopupMenu t) => t.Cast<Javax.Accessibility.Accessible>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JPopupMenu"/> to <see cref="Javax.Swing.MenuElement"/>
        /// </summary>
        public static implicit operator Javax.Swing.MenuElement(Javax.Swing.JPopupMenu t) => t.Cast<Javax.Swing.MenuElement>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getDefaultLightWeightPopupEnabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setDefaultLightWeightPopupEnabled(boolean)"/>
        /// </summary>
        public static bool DefaultLightWeightPopupEnabled
        {
            get { return SExecute<bool>(LocalBridgeClazz, "getDefaultLightWeightPopupEnabled"); } set { SExecute(LocalBridgeClazz, "setDefaultLightWeightPopupEnabled", value); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getComponent()"/> 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecute<Java.Awt.Component>("getComponent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getInvoker()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setInvoker(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component Invoker
        {
            get { return IExecute<Java.Awt.Component>("getInvoker"); } set { IExecute("setInvoker", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getLabel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setLabel(java.lang.String)"/>
        /// </summary>
        public string Label
        {
            get { return IExecute<string>("getLabel"); } set { IExecute("setLabel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getMargin()"/> 
        /// </summary>
        public Java.Awt.Insets Margin
        {
            get { return IExecute<Java.Awt.Insets>("getMargin"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getMenuKeyListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.MenuKeyListener[] MenuKeyListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.MenuKeyListener>("getMenuKeyListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getPopupMenuListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.PopupMenuListener[] PopupMenuListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.PopupMenuListener>("getPopupMenuListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setSelectionModel(javax.swing.SingleSelectionModel)"/>
        /// </summary>
        public Javax.Swing.SingleSelectionModel SelectionModel
        {
            get { return IExecute<Javax.Swing.SingleSelectionModel>("getSelectionModel"); } set { IExecute("setSelectionModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getSubElements()"/> 
        /// </summary>
        public Javax.Swing.MenuElement[] SubElements
        {
            get { return IExecuteArray<Javax.Swing.MenuElement>("getSubElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#isBorderPainted()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsBorderPainted()
        {
            return IExecute<bool>("isBorderPainted");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#isLightWeightPopupEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLightWeightPopupEnabled()
        {
            return IExecute<bool>("isLightWeightPopupEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#isPopupTrigger(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPopupTrigger(Java.Awt.EventNs.MouseEvent arg0)
        {
            return IExecute<bool>("isPopupTrigger", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#getComponentIndex(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetComponentIndex(Java.Awt.Component arg0)
        {
            return IExecute<int>("getComponentIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#add(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Add(string arg0)
        {
            return IExecute<Javax.Swing.JMenuItem>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#add(javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Add(Javax.Swing.Action arg0)
        {
            return IExecute<Javax.Swing.JMenuItem>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#add(javax.swing.JMenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JMenuItem"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Add(Javax.Swing.JMenuItem arg0)
        {
            return IExecute<Javax.Swing.JMenuItem>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#addMenuKeyListener(javax.swing.event.MenuKeyListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyListener"/></param>
        public void AddMenuKeyListener(Javax.Swing.Event.MenuKeyListener arg0)
        {
            IExecute("addMenuKeyListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#addPopupMenuListener(javax.swing.event.PopupMenuListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuListener"/></param>
        public void AddPopupMenuListener(Javax.Swing.Event.PopupMenuListener arg0)
        {
            IExecute("addPopupMenuListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#addSeparator()"/>
        /// </summary>
        public void AddSeparator()
        {
            IExecute("addSeparator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#insert(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Java.Awt.Component arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#insert(javax.swing.Action,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Javax.Swing.Action arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#menuSelectionChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void MenuSelectionChanged(bool arg0)
        {
            IExecute("menuSelectionChanged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#pack()"/>
        /// </summary>
        public void Pack()
        {
            IExecute("pack");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#processKeyEvent(java.awt.event.KeyEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        public void ProcessKeyEvent(Java.Awt.EventNs.KeyEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2)
        {
            IExecute("processKeyEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#processMouseEvent(java.awt.event.MouseEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        public void ProcessMouseEvent(Java.Awt.EventNs.MouseEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2)
        {
            IExecute("processMouseEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#removeMenuKeyListener(javax.swing.event.MenuKeyListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyListener"/></param>
        public void RemoveMenuKeyListener(Javax.Swing.Event.MenuKeyListener arg0)
        {
            IExecute("removeMenuKeyListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#removePopupMenuListener(javax.swing.event.PopupMenuListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuListener"/></param>
        public void RemovePopupMenuListener(Javax.Swing.Event.PopupMenuListener arg0)
        {
            IExecute("removePopupMenuListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setBorderPainted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBorderPainted(bool arg0)
        {
            IExecute("setBorderPainted", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setLightWeightPopupEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLightWeightPopupEnabled(bool arg0)
        {
            IExecute("setLightWeightPopupEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setPopupSize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetPopupSize(int arg0, int arg1)
        {
            IExecute("setPopupSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setPopupSize(java.awt.Dimension)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
        public void SetPopupSize(Java.Awt.Dimension arg0)
        {
            IExecute("setPopupSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setSelected(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetSelected(Java.Awt.Component arg0)
        {
            IExecute("setSelected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#setUI(javax.swing.plaf.PopupMenuUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.PopupMenuUI"/></param>
        public void SetUI(Javax.Swing.Plaf.PopupMenuUI arg0)
        {
            IExecute("setUI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JPopupMenu.html#show(java.awt.Component,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void Show(Java.Awt.Component arg0, int arg1, int arg2)
        {
            IExecute("show", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region Separator
        public partial class Separator
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}