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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#getMaxSortKeys() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setMaxSortKeys(int)
        /// </summary>
        public int MaxSortKeys
        {
            get { return IExecute<int>("getMaxSortKeys"); } set { IExecute("setMaxSortKeys", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#getSortsOnUpdates() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setSortsOnUpdates(boolean)
        /// </summary>
        public bool SortsOnUpdates
        {
            get { return IExecute<bool>("getSortsOnUpdates"); } set { IExecute("setSortsOnUpdates", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#isSortable(int)
        /// </summary>
        public bool IsSortable(int arg0)
        {
            return IExecute<bool>("isSortable", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#setSortable(int,boolean)
        /// </summary>
        public void SetSortable(int arg0, bool arg1)
        {
            IExecute("setSortable", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultRowSorter.html#sort()
        /// </summary>
        public void Sort()
        {
            IExecute("sort");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}