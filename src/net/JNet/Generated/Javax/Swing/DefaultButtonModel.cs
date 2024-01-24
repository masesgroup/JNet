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

namespace Javax.Swing
{
    #region DefaultButtonModel
    public partial class DefaultButtonModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultButtonModel"/> to <see cref="Javax.Swing.ButtonModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.ButtonModel(Javax.Swing.DefaultButtonModel t) => t.Cast<Javax.Swing.ButtonModel>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultButtonModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.DefaultButtonModel t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#ARMED"/>
        /// </summary>
        public static int ARMED { get { if (!_ARMEDReady) { _ARMEDContent = SGetField<int>(LocalBridgeClazz, "ARMED"); _ARMEDReady = true; } return _ARMEDContent; } }
        private static int _ARMEDContent = default;
        private static bool _ARMEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#ENABLED"/>
        /// </summary>
        public static int ENABLED { get { if (!_ENABLEDReady) { _ENABLEDContent = SGetField<int>(LocalBridgeClazz, "ENABLED"); _ENABLEDReady = true; } return _ENABLEDContent; } }
        private static int _ENABLEDContent = default;
        private static bool _ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#PRESSED"/>
        /// </summary>
        public static int PRESSED { get { if (!_PRESSEDReady) { _PRESSEDContent = SGetField<int>(LocalBridgeClazz, "PRESSED"); _PRESSEDReady = true; } return _PRESSEDContent; } }
        private static int _PRESSEDContent = default;
        private static bool _PRESSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#ROLLOVER"/>
        /// </summary>
        public static int ROLLOVER { get { if (!_ROLLOVERReady) { _ROLLOVERContent = SGetField<int>(LocalBridgeClazz, "ROLLOVER"); _ROLLOVERReady = true; } return _ROLLOVERContent; } }
        private static int _ROLLOVERContent = default;
        private static bool _ROLLOVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#SELECTED"/>
        /// </summary>
        public static int SELECTED { get { if (!_SELECTEDReady) { _SELECTEDContent = SGetField<int>(LocalBridgeClazz, "SELECTED"); _SELECTEDReady = true; } return _SELECTEDContent; } }
        private static int _SELECTEDContent = default;
        private static bool _SELECTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public string ActionCommand
        {
            get { return IExecute<string>("getActionCommand"); } set { IExecute("setActionCommand", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ActionListener>("getActionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.ChangeListener>("getChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getGroup()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setGroup(javax.swing.ButtonGroup)"/>
        /// </summary>
        public Javax.Swing.ButtonGroup Group
        {
            get { return IExecute<Javax.Swing.ButtonGroup>("getGroup"); } set { IExecute("setGroup", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getItemListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ItemListener[] ItemListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ItemListener>("getItemListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getMnemonic()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setMnemonic(int)"/>
        /// </summary>
        public int Mnemonic
        {
            get { return IExecute<int>("getMnemonic"); } set { IExecute("setMnemonic", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getSelectedObjects()"/> 
        /// </summary>
        public object[] SelectedObjects
        {
            get { return IExecuteArray<object>("getSelectedObjects"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isArmed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsArmed()
        {
            return IExecute<bool>("isArmed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecute<bool>("isEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isPressed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPressed()
        {
            return IExecute<bool>("isPressed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isRollover()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRollover()
        {
            return IExecute<bool>("isRollover");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isSelected()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSelected()
        {
            return IExecute<bool>("isSelected");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("addActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("addChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#addItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void AddItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecute("addItemListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("removeActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("removeChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#removeItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void RemoveItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecute("removeItemListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setArmed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetArmed(bool arg0)
        {
            IExecute("setArmed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecute("setEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setPressed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPressed(bool arg0)
        {
            IExecute("setPressed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setRollover(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRollover(bool arg0)
        {
            IExecute("setRollover", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setSelected(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSelected(bool arg0)
        {
            IExecute("setSelected", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}