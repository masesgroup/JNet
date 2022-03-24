/*
*  Copyright 2022 MASES s.r.l.
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

using Java.Awt.Datatransfer;
using Java.Util;

namespace Java.Awt.Dnd
{
    public class DropTargetDragEvent : DropTargetEvent
    {
        public override string ClassName => "java.awt.dnd.DropTargetDragEvent";
        /// <summary>
        ///  Accepts the drag. This method should be called from a DropTargetListeners dragEnter, dragOver, and dropActionChanged methods if the implementation wishes to accept an operation from the srcActions other than the one selected by the user as represented by the dropAction.
        /// </summary>
        /// <param name="dragOperation">The operation accepted by the target</param>
        public void AcceptDrag(int dragOperation) => IExecute("acceptDrag", dragOperation);
        /// <summary>
        /// This method returns the current DataFlavors from the DropTargetContext.
        /// </summary>
        public DataFlavor[] CurrentDataFlavors => IExecute<DataFlavor[]>("getCurrentDataFlavors");
        /// <summary>
        /// This method returns the current DataFlavors as a java.util.List
        /// </summary>
        public List<DataFlavor> CurrentDataFlavorsAsList => IExecute<List<DataFlavor>>("getCurrentDataFlavorsAsList");
        /// <summary>
        /// This method returns the user drop action.
        /// </summary>
        public int DropAction => IExecute<int>("getDropAction");
        /// <summary>
        /// This method returns a Point indicating the Cursor's current location within the Component's coordinates.
        /// </summary>
        public Point Location => IExecute<Point>("getLocation");
        /// <summary>
        /// This method returns the source drop actions.
        /// </summary>
        public int SourceActions => IExecute<int>("getSourceActions");
        /// <summary>
        /// This method returns the Transferable object that represents the data associated with the current drag operation.
        /// </summary>
        public Transferable Transferable => IExecute<Transferable>("getTransferable");
        /// <summary>
        /// This method returns a boolean indicating if the specified DataFlavor is supported.
        /// </summary>
        /// <param name="df">The DataFlavor to test </param>
        /// <returns>If a particular DataFlavor is supported</returns>
        public bool IsDataFlavorSupported(DataFlavor df) => IExecute<bool>("isDataFlavorSupported", df);
        /// <summary>
        /// Rejects the drag as a result of examining either the dropAction or the available DataFlavor types.
        /// </summary>
        public void RejectDrag() => IExecute("rejectDrag");
    }
}
