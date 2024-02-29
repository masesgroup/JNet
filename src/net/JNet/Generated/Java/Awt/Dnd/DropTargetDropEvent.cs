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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Dnd
{
    #region DropTargetDropEvent
    public partial class DropTargetDropEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#%3Cinit%3E(java.awt.dnd.DropTargetContext,java.awt.Point,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public DropTargetDropEvent(Java.Awt.Dnd.DropTargetContext arg0, Java.Awt.Point arg1, int arg2, int arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#%3Cinit%3E(java.awt.dnd.DropTargetContext,java.awt.Point,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public DropTargetDropEvent(Java.Awt.Dnd.DropTargetContext arg0, Java.Awt.Point arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getCurrentDataFlavors()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.DataFlavor[] CurrentDataFlavors
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Datatransfer.DataFlavor>("getCurrentDataFlavors", "()[Ljava/awt/datatransfer/DataFlavor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getCurrentDataFlavorsAsList()"/> 
        /// </summary>
        public Java.Util.List<Java.Awt.Datatransfer.DataFlavor> CurrentDataFlavorsAsList
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Awt.Datatransfer.DataFlavor>>("getCurrentDataFlavorsAsList", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getDropAction()"/> 
        /// </summary>
        public int DropAction
        {
            get { return IExecuteWithSignature<int>("getDropAction", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getLocation()"/> 
        /// </summary>
        public Java.Awt.Point Location
        {
            get { return IExecuteWithSignature<Java.Awt.Point>("getLocation", "()Ljava/awt/Point;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getSourceActions()"/> 
        /// </summary>
        public int SourceActions
        {
            get { return IExecuteWithSignature<int>("getSourceActions", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getTransferable()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.Transferable Transferable
        {
            get { return IExecuteWithSignature<Java.Awt.Datatransfer.Transferable>("getTransferable", "()Ljava/awt/datatransfer/Transferable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#isDataFlavorSupported(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDataFlavorSupported(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecuteWithSignature<bool>("isDataFlavorSupported", "(Ljava/awt/datatransfer/DataFlavor;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#isLocalTransfer()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLocalTransfer()
        {
            return IExecuteWithSignature<bool>("isLocalTransfer", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#acceptDrop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcceptDrop(int arg0)
        {
            IExecuteWithSignature("acceptDrop", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#dropComplete(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void DropComplete(bool arg0)
        {
            IExecuteWithSignature("dropComplete", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#rejectDrop()"/>
        /// </summary>
        public void RejectDrop()
        {
            IExecuteWithSignature("rejectDrop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}