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

namespace Javax.Swing
{
    #region SingleSelectionModel
    public partial class SingleSelectionModel
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SingleSelectionModel.html#getSelectedIndex() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SingleSelectionModel.html#setSelectedIndex(int)
        /// </summary>
        public int SelectedIndex
        {
            get { return IExecute<int>("getSelectedIndex"); } set { IExecute("setSelectedIndex", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SingleSelectionModel.html#isSelected()
        /// </summary>
        public bool IsSelected()
        {
            return IExecute<bool>("isSelected");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SingleSelectionModel.html#addChangeListener(javax.swing.event.ChangeListener)
        /// </summary>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("addChangeListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SingleSelectionModel.html#clearSelection()
        /// </summary>
        public void ClearSelection()
        {
            IExecute("clearSelection");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SingleSelectionModel.html#removeChangeListener(javax.swing.event.ChangeListener)
        /// </summary>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("removeChangeListener", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}