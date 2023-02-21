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
    #region CheckboxMenuItem
    public partial class CheckboxMenuItem
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#<init>(java.lang.String,boolean) throws java.awt.HeadlessException
        /// </summary>
        public CheckboxMenuItem(string arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#<init>(java.lang.String) throws java.awt.HeadlessException
        /// </summary>
        public CheckboxMenuItem(string arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Awt.ItemSelectable(Java.Awt.CheckboxMenuItem t) => t.Cast<Java.Awt.ItemSelectable>();
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.CheckboxMenuItem t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#getItemListeners() 
        /// </summary>
        public Java.Awt.EventNs.ItemListener[] ItemListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ItemListener>("getItemListeners"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#getSelectedObjects() 
        /// </summary>
        public object[] SelectedObjects
        {
            get { return IExecuteArray<object>("getSelectedObjects"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#getState() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#setState(boolean)
        /// </summary>
        public bool State
        {
            get { return IExecute<bool>("getState"); } set { IExecute("setState", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#addItemListener(java.awt.event.ItemListener)
        /// </summary>
        public void AddItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecute("addItemListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#removeItemListener(java.awt.event.ItemListener)
        /// </summary>
        public void RemoveItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecute("removeItemListener", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}