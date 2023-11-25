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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DefaultSingleSelectionModel
    public partial class DefaultSingleSelectionModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultSingleSelectionModel"/> to <see cref="Javax.Swing.SingleSelectionModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.SingleSelectionModel(Javax.Swing.DefaultSingleSelectionModel t) => t.Cast<Javax.Swing.SingleSelectionModel>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultSingleSelectionModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.DefaultSingleSelectionModel t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultSingleSelectionModel.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.ChangeListener>("getChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultSingleSelectionModel.html#getSelectedIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultSingleSelectionModel.html#setSelectedIndex(int)"/>
        /// </summary>
        public int SelectedIndex
        {
            get { return IExecute<int>("getSelectedIndex"); } set { IExecute("setSelectedIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultSingleSelectionModel.html#isSelected()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSelected()
        {
            return IExecute<bool>("isSelected");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultSingleSelectionModel.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("addChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultSingleSelectionModel.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecute("clearSelection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultSingleSelectionModel.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
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