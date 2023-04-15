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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Metal
{
    #region MetalComboBoxButton
    public partial class MetalComboBoxButton
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxButton.html#%3Cinit%3E(javax.swing.JComboBox,javax.swing.Icon,boolean,javax.swing.CellRendererPane,javax.swing.JList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComboBox"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.CellRendererPane"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.JList"/></param>
        public MetalComboBoxButton(Javax.Swing.JComboBox arg0, Javax.Swing.Icon arg1, bool arg2, Javax.Swing.CellRendererPane arg3, Javax.Swing.JList arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxButton.html#%3Cinit%3E(javax.swing.JComboBox,javax.swing.Icon,javax.swing.CellRendererPane,javax.swing.JList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComboBox"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.CellRendererPane"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.JList"/></param>
        public MetalComboBoxButton(Javax.Swing.JComboBox arg0, Javax.Swing.Icon arg1, Javax.Swing.CellRendererPane arg2, Javax.Swing.JList arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxButton.html#getComboBox()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxButton.html#setComboBox(javax.swing.JComboBox)"/>
        /// </summary>
        public Javax.Swing.JComboBox<object> ComboBox
        {
            get { return IExecute<Javax.Swing.JComboBox<object>>("getComboBox"); } set { IExecute("setComboBox", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxButton.html#getComboIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxButton.html#setComboIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon ComboIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getComboIcon"); } set { IExecute("setComboIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxButton.html#isIconOnly()"/> 
        /// </summary>
        public bool IsIconOnly
        {
            get { return IExecute<bool>("isIconOnly"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxButton.html#setIconOnly(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIconOnly(bool arg0)
        {
            IExecute("setIconOnly", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxButton.html#paintComponent(java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        public void PaintComponent(Java.Awt.Graphics arg0)
        {
            IExecute("paintComponent", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}