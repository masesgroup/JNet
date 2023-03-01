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
    #region DefaultComboBoxModel
    public partial class DefaultComboBoxModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#%3Cinit%3E(java.util.Vector%3CE%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        public DefaultComboBoxModel(Java.Util.Vector arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultComboBoxModel"/> to <see cref="Javax.Swing.MutableComboBoxModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.MutableComboBoxModel(Javax.Swing.DefaultComboBoxModel t) => t.Cast<Javax.Swing.MutableComboBoxModel>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultComboBoxModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.DefaultComboBoxModel t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#getSelectedItem()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#setSelectedItem(java.lang.Object)"/>
        /// </summary>
        public object SelectedItem
        {
            get { return IExecute("getSelectedItem"); } set { IExecute("setSelectedItem", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#getIndexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetIndexOf(object arg0)
        {
            return IExecute<int>("getIndexOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#addAll(int,java.util.Collection%3C? extends E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        public void AddAll(int arg0, Java.Util.Collection arg1)
        {
            IExecute("addAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#addAll(java.util.Collection%3C? extends E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void AddAll(Java.Util.Collection arg0)
        {
            IExecute("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#addElement(E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddElement(object arg0)
        {
            IExecute("addElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#insertElementAt(E,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void InsertElementAt(object arg0, int arg1)
        {
            IExecute("insertElementAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#removeAllElements()"/>
        /// </summary>
        public void RemoveAllElements()
        {
            IExecute("removeAllElements");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#removeElement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveElement(object arg0)
        {
            IExecute("removeElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#removeElementAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveElementAt(int arg0)
        {
            IExecute("removeElementAt", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}