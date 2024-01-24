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
    #region ListModel
    public partial class ListModel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#getSize()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("getSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#getElementAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetElementAt(int arg0)
        {
            return IExecute("getElementAt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#addListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        public void AddListDataListener(Javax.Swing.Event.ListDataListener arg0)
        {
            IExecute("addListDataListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#removeListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        public void RemoveListDataListener(Javax.Swing.Event.ListDataListener arg0)
        {
            IExecute("removeListDataListener", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IListModel<E>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IListModel<E>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#getSize()"/> 
        /// </summary>
        int Size { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#getElementAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        E GetElementAt(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#addListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        void AddListDataListener(Javax.Swing.Event.ListDataListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#removeListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        void RemoveListDataListener(Javax.Swing.Event.ListDataListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ListModel<E>
    public partial class ListModel<E> : Javax.Swing.IListModel<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.ListModel{E}"/> to <see cref="Javax.Swing.ListModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.ListModel(Javax.Swing.ListModel<E> t) => t.Cast<Javax.Swing.ListModel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#getSize()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("getSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#getElementAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E GetElementAt(int arg0)
        {
            return IExecute<E>("getElementAt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#addListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        public void AddListDataListener(Javax.Swing.Event.ListDataListener arg0)
        {
            IExecute("addListDataListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListModel.html#removeListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        public void RemoveListDataListener(Javax.Swing.Event.ListDataListener arg0)
        {
            IExecute("removeListDataListener", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}