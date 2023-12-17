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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Dnd.Peer
{
    #region IDragSourceContextPeer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDragSourceContextPeer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DragSourceContextPeer.html#getCursor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DragSourceContextPeer.html#setCursor(java.awt.Cursor)"/>
        /// </summary>
        Java.Awt.Cursor Cursor { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DragSourceContextPeer.html#startDrag(java.awt.dnd.DragSourceContext,java.awt.Cursor,java.awt.Image,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Cursor"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Point"/></param>
        /// <exception cref="Java.Awt.Dnd.InvalidDnDOperationException"/>
        void StartDrag(Java.Awt.Dnd.DragSourceContext arg0, Java.Awt.Cursor arg1, Java.Awt.Image arg2, Java.Awt.Point arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DragSourceContextPeer.html#transferablesFlavorsChanged()"/>
        /// </summary>
        void TransferablesFlavorsChanged();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DragSourceContextPeer
    public partial class DragSourceContextPeer : Java.Awt.Dnd.Peer.IDragSourceContextPeer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DragSourceContextPeer.html#getCursor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DragSourceContextPeer.html#setCursor(java.awt.Cursor)"/>
        /// </summary>
        public Java.Awt.Cursor Cursor
        {
            get { return IExecute<Java.Awt.Cursor>("getCursor"); } set { IExecute("setCursor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DragSourceContextPeer.html#startDrag(java.awt.dnd.DragSourceContext,java.awt.Cursor,java.awt.Image,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Cursor"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Point"/></param>
        /// <exception cref="Java.Awt.Dnd.InvalidDnDOperationException"/>
        public void StartDrag(Java.Awt.Dnd.DragSourceContext arg0, Java.Awt.Cursor arg1, Java.Awt.Image arg2, Java.Awt.Point arg3)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DragSourceContextPeer.html#transferablesFlavorsChanged()"/>
        /// </summary>
        public void TransferablesFlavorsChanged()
        {
            IExecute("transferablesFlavorsChanged");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}