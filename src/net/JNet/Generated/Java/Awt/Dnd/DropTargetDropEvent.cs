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
            get { return IExecuteArray<Java.Awt.Datatransfer.DataFlavor>("getCurrentDataFlavors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getCurrentDataFlavorsAsList()"/> 
        /// </summary>
        public Java.Util.List<Java.Awt.Datatransfer.DataFlavor> CurrentDataFlavorsAsList
        {
            get { return IExecute<Java.Util.List<Java.Awt.Datatransfer.DataFlavor>>("getCurrentDataFlavorsAsList"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getDropAction()"/> 
        /// </summary>
        public int DropAction
        {
            get { return IExecute<int>("getDropAction"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getLocation()"/> 
        /// </summary>
        public Java.Awt.Point Location
        {
            get { return IExecute<Java.Awt.Point>("getLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getSourceActions()"/> 
        /// </summary>
        public int SourceActions
        {
            get { return IExecute<int>("getSourceActions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#getTransferable()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.Transferable Transferable
        {
            get { return IExecute<Java.Awt.Datatransfer.Transferable>("getTransferable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#isDataFlavorSupported(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDataFlavorSupported(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecute<bool>("isDataFlavorSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#isLocalTransfer()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLocalTransfer()
        {
            return IExecute<bool>("isLocalTransfer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#acceptDrop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcceptDrop(int arg0)
        {
            IExecute("acceptDrop", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#dropComplete(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void DropComplete(bool arg0)
        {
            IExecute("dropComplete", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDropEvent.html#rejectDrop()"/>
        /// </summary>
        public void RejectDrop()
        {
            IExecute("rejectDrop");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}