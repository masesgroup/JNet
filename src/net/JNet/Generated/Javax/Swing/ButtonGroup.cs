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
    #region ButtonGroup
    public partial class ButtonGroup
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#getButtonCount()"/> 
        /// </summary>
        public int ButtonCount
        {
            get { return IExecute<int>("getButtonCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#getElements()"/> 
        /// </summary>
        public Java.Util.Enumeration<Javax.Swing.AbstractButton> Elements
        {
            get { return IExecute<Java.Util.Enumeration<Javax.Swing.AbstractButton>>("getElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#getSelection()"/> 
        /// </summary>
        public Javax.Swing.ButtonModel Selection
        {
            get { return IExecute<Javax.Swing.ButtonModel>("getSelection"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#isSelected(javax.swing.ButtonModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.ButtonModel"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelected(Javax.Swing.ButtonModel arg0)
        {
            return IExecute<bool>("isSelected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#add(javax.swing.AbstractButton)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.AbstractButton"/></param>
        public void Add(Javax.Swing.AbstractButton arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecute("clearSelection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#remove(javax.swing.AbstractButton)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.AbstractButton"/></param>
        public void Remove(Javax.Swing.AbstractButton arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#setSelected(javax.swing.ButtonModel,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.ButtonModel"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetSelected(Javax.Swing.ButtonModel arg0, bool arg1)
        {
            IExecute("setSelected", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}