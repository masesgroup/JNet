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
    #region IListSelectionModel
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IListSelectionModel
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getAnchorSelectionIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setAnchorSelectionIndex(int)"/>
        /// </summary>
        int AnchorSelectionIndex { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getLeadSelectionIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setLeadSelectionIndex(int)"/>
        /// </summary>
        int LeadSelectionIndex { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getMaxSelectionIndex()"/> 
        /// </summary>
        int MaxSelectionIndex { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getMinSelectionIndex()"/> 
        /// </summary>
        int MinSelectionIndex { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getSelectedIndices()"/> 
        /// </summary>
        int[] SelectedIndices { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getSelectedItemsCount()"/> 
        /// </summary>
        int SelectedItemsCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setSelectionMode(int)"/>
        /// </summary>
        int SelectionMode { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        bool ValueIsAdjusting { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#isSelectedIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSelectedIndex(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#isSelectionEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsSelectionEmpty();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#addListSelectionListener(javax.swing.event.ListSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionListener"/></param>
        void AddListSelectionListener(Javax.Swing.Event.ListSelectionListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#addSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void AddSelectionInterval(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#clearSelection()"/>
        /// </summary>
        void ClearSelection();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#insertIndexInterval(int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        void InsertIndexInterval(int arg0, int arg1, bool arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#removeIndexInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void RemoveIndexInterval(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#removeListSelectionListener(javax.swing.event.ListSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionListener"/></param>
        void RemoveListSelectionListener(Javax.Swing.Event.ListSelectionListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#removeSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void RemoveSelectionInterval(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void SetSelectionInterval(int arg0, int arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ListSelectionModel
    public partial class ListSelectionModel : Javax.Swing.IListSelectionModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#MULTIPLE_INTERVAL_SELECTION"/>
        /// </summary>
        public static int MULTIPLE_INTERVAL_SELECTION { get { if (!_MULTIPLE_INTERVAL_SELECTIONReady) { _MULTIPLE_INTERVAL_SELECTIONContent = SGetField<int>(LocalBridgeClazz, "MULTIPLE_INTERVAL_SELECTION"); _MULTIPLE_INTERVAL_SELECTIONReady = true; } return _MULTIPLE_INTERVAL_SELECTIONContent; } }
        private static int _MULTIPLE_INTERVAL_SELECTIONContent = default;
        private static bool _MULTIPLE_INTERVAL_SELECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#SINGLE_INTERVAL_SELECTION"/>
        /// </summary>
        public static int SINGLE_INTERVAL_SELECTION { get { if (!_SINGLE_INTERVAL_SELECTIONReady) { _SINGLE_INTERVAL_SELECTIONContent = SGetField<int>(LocalBridgeClazz, "SINGLE_INTERVAL_SELECTION"); _SINGLE_INTERVAL_SELECTIONReady = true; } return _SINGLE_INTERVAL_SELECTIONContent; } }
        private static int _SINGLE_INTERVAL_SELECTIONContent = default;
        private static bool _SINGLE_INTERVAL_SELECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#SINGLE_SELECTION"/>
        /// </summary>
        public static int SINGLE_SELECTION { get { if (!_SINGLE_SELECTIONReady) { _SINGLE_SELECTIONContent = SGetField<int>(LocalBridgeClazz, "SINGLE_SELECTION"); _SINGLE_SELECTIONReady = true; } return _SINGLE_SELECTIONContent; } }
        private static int _SINGLE_SELECTIONContent = default;
        private static bool _SINGLE_SELECTIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getAnchorSelectionIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setAnchorSelectionIndex(int)"/>
        /// </summary>
        public int AnchorSelectionIndex
        {
            get { return IExecute<int>("getAnchorSelectionIndex"); } set { IExecute("setAnchorSelectionIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getLeadSelectionIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setLeadSelectionIndex(int)"/>
        /// </summary>
        public int LeadSelectionIndex
        {
            get { return IExecute<int>("getLeadSelectionIndex"); } set { IExecute("setLeadSelectionIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getMaxSelectionIndex()"/> 
        /// </summary>
        public int MaxSelectionIndex
        {
            get { return IExecute<int>("getMaxSelectionIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getMinSelectionIndex()"/> 
        /// </summary>
        public int MinSelectionIndex
        {
            get { return IExecute<int>("getMinSelectionIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getSelectedIndices()"/> 
        /// </summary>
        public int[] SelectedIndices
        {
            get { return IExecuteArray<int>("getSelectedIndices"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getSelectedItemsCount()"/> 
        /// </summary>
        public int SelectedItemsCount
        {
            get { return IExecute<int>("getSelectedItemsCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setSelectionMode(int)"/>
        /// </summary>
        public int SelectionMode
        {
            get { return IExecute<int>("getSelectionMode"); } set { IExecute("setSelectionMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecute<bool>("getValueIsAdjusting"); } set { IExecute("setValueIsAdjusting", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#isSelectedIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelectedIndex(int arg0)
        {
            return IExecute<bool>("isSelectedIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#isSelectionEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSelectionEmpty()
        {
            return IExecute<bool>("isSelectionEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#addListSelectionListener(javax.swing.event.ListSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionListener"/></param>
        public void AddListSelectionListener(Javax.Swing.Event.ListSelectionListener arg0)
        {
            IExecute("addListSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#addSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void AddSelectionInterval(int arg0, int arg1)
        {
            IExecute("addSelectionInterval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecute("clearSelection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#insertIndexInterval(int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void InsertIndexInterval(int arg0, int arg1, bool arg2)
        {
            IExecute("insertIndexInterval", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#removeIndexInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RemoveIndexInterval(int arg0, int arg1)
        {
            IExecute("removeIndexInterval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#removeListSelectionListener(javax.swing.event.ListSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionListener"/></param>
        public void RemoveListSelectionListener(Javax.Swing.Event.ListSelectionListener arg0)
        {
            IExecute("removeListSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#removeSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RemoveSelectionInterval(int arg0, int arg1)
        {
            IExecute("removeSelectionInterval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ListSelectionModel.html#setSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetSelectionInterval(int arg0, int arg1)
        {
            IExecute("setSelectionInterval", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}