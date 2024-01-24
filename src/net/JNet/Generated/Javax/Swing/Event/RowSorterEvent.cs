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

namespace Javax.Swing.Event
{
    #region RowSorterEvent
    public partial class RowSorterEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/RowSorterEvent.html#%3Cinit%3E(javax.swing.RowSorter,javax.swing.event.RowSorterEvent.Type,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowSorter"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Event.RowSorterEvent.Type"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public RowSorterEvent(Javax.Swing.RowSorter<object> arg0, Javax.Swing.Event.RowSorterEvent.Type arg1, int[] arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/RowSorterEvent.html#%3Cinit%3E(javax.swing.RowSorter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowSorter"/></param>
        public RowSorterEvent(Javax.Swing.RowSorter<object> arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/RowSorterEvent.html#getType()"/> 
        /// </summary>
        public Javax.Swing.Event.RowSorterEvent.Type GetType
        {
            get { return IExecute<Javax.Swing.Event.RowSorterEvent.Type>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/RowSorterEvent.html#getPreviousRowCount()"/> 
        /// </summary>
        public int PreviousRowCount
        {
            get { return IExecute<int>("getPreviousRowCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/RowSorterEvent.html#convertPreviousRowIndexToModel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConvertPreviousRowIndexToModel(int arg0)
        {
            return IExecute<int>("convertPreviousRowIndexToModel", arg0);
        }

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/RowSorterEvent.Type.html#SORT_ORDER_CHANGED"/>
            /// </summary>
            public static Javax.Swing.Event.RowSorterEvent.Type SORT_ORDER_CHANGED { get { if (!_SORT_ORDER_CHANGEDReady) { _SORT_ORDER_CHANGEDContent = SGetField<Javax.Swing.Event.RowSorterEvent.Type>(LocalBridgeClazz, "SORT_ORDER_CHANGED"); _SORT_ORDER_CHANGEDReady = true; } return _SORT_ORDER_CHANGEDContent; } }
            private static Javax.Swing.Event.RowSorterEvent.Type _SORT_ORDER_CHANGEDContent = default;
            private static bool _SORT_ORDER_CHANGEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/RowSorterEvent.Type.html#SORTED"/>
            /// </summary>
            public static Javax.Swing.Event.RowSorterEvent.Type SORTED { get { if (!_SORTEDReady) { _SORTEDContent = SGetField<Javax.Swing.Event.RowSorterEvent.Type>(LocalBridgeClazz, "SORTED"); _SORTEDReady = true; } return _SORTEDContent; } }
            private static Javax.Swing.Event.RowSorterEvent.Type _SORTEDContent = default;
            private static bool _SORTEDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/RowSorterEvent.Type.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Swing.Event.RowSorterEvent.Type"/></returns>
            public static Javax.Swing.Event.RowSorterEvent.Type ValueOf(string arg0)
            {
                return SExecute<Javax.Swing.Event.RowSorterEvent.Type>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/RowSorterEvent.Type.html#values()"/>
            /// </summary>

            /// <returns><see cref="Javax.Swing.Event.RowSorterEvent.Type"/></returns>
            public static Javax.Swing.Event.RowSorterEvent.Type[] Values()
            {
                return SExecuteArray<Javax.Swing.Event.RowSorterEvent.Type>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}