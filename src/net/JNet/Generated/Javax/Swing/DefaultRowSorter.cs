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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DefaultRowSorter
    public partial class DefaultRowSorter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#getMaxSortKeys()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setMaxSortKeys(int)"/>
        /// </summary>
        public int MaxSortKeys
        {
            get { return IExecuteWithSignature<int>("getMaxSortKeys", "()I"); } set { IExecuteWithSignature("setMaxSortKeys", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#getRowFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setRowFilter(javax.swing.RowFilter)"/>
        /// </summary>
        public Javax.Swing.RowFilter RowFilter
        {
            get { return IExecuteWithSignature<Javax.Swing.RowFilter>("getRowFilter", "()Ljavax/swing/RowFilter;"); } set { IExecuteWithSignature("setRowFilter", "(Ljavax/swing/RowFilter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#getSortsOnUpdates()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setSortsOnUpdates(boolean)"/>
        /// </summary>
        public bool SortsOnUpdates
        {
            get { return IExecuteWithSignature<bool>("getSortsOnUpdates", "()Z"); } set { IExecuteWithSignature("setSortsOnUpdates", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#isSortable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSortable(int arg0)
        {
            return IExecuteWithSignature<bool>("isSortable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setSortable(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetSortable(int arg0, bool arg1)
        {
            IExecute("setSortable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#sort()"/>
        /// </summary>
        public void Sort()
        {
            IExecuteWithSignature("sort", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DefaultRowSorter<M, I>
    public partial class DefaultRowSorter<M, I>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultRowSorter{M, I}"/> to <see cref="Javax.Swing.DefaultRowSorter"/>
        /// </summary>
        public static implicit operator Javax.Swing.DefaultRowSorter(Javax.Swing.DefaultRowSorter<M, I> t) => t.Cast<Javax.Swing.DefaultRowSorter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#getMaxSortKeys()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setMaxSortKeys(int)"/>
        /// </summary>
        public int MaxSortKeys
        {
            get { return IExecuteWithSignature<int>("getMaxSortKeys", "()I"); } set { IExecuteWithSignature("setMaxSortKeys", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#getRowFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setRowFilter(javax.swing.RowFilter)"/>
        /// </summary>
        public Javax.Swing.RowFilter RowFilter
        {
            get { return IExecuteWithSignature<Javax.Swing.RowFilter>("getRowFilter", "()Ljavax/swing/RowFilter;"); } set { IExecuteWithSignature("setRowFilter", "(Ljavax/swing/RowFilter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#getSortsOnUpdates()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setSortsOnUpdates(boolean)"/>
        /// </summary>
        public bool SortsOnUpdates
        {
            get { return IExecuteWithSignature<bool>("getSortsOnUpdates", "()Z"); } set { IExecuteWithSignature("setSortsOnUpdates", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#isSortable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSortable(int arg0)
        {
            return IExecuteWithSignature<bool>("isSortable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setSortable(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetSortable(int arg0, bool arg1)
        {
            IExecute("setSortable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#sort()"/>
        /// </summary>
        public void Sort()
        {
            IExecuteWithSignature("sort", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}