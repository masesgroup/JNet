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
        /// <returns><see langword="object"/></returns>
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
}