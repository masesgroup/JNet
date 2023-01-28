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

using Java.Awt.Datatransfer;
using Java.Util;

namespace Java.Awt.Dnd
{
    public class DropTargetDropEvent : DropTargetEvent
    {
        public override string ClassName => "java.awt.dnd.DropTargetDropEvent";
        /// <summary>
        /// accept the drop, using the specified action.
        /// </summary>
        /// <param name="dropAction">the specified action</param>
        public void AcceptDrop(int dropAction) => IExecute("acceptDrop", dropAction);
        /// <summary>
        /// This method notifies the DragSource that the drop transfer(s) are completed.
        /// </summary>
        /// <param name="success">a boolean indicating that the drop transfer(s) are completed.</param>
        public void DropComplete(bool success) => IExecute("dropComplete", success);
        /// <summary>
        /// This method returns the current DataFlavors.
        /// </summary>
        public DataFlavor[] CurrentDataFlavors => IExecute<DataFlavor[]>("getCurrentDataFlavors");
        /// <summary>
        /// This method returns the currently available DataFlavors as a java.util.List.
        /// </summary>
        public List<DataFlavor> CurrentDataFlavorsAsList => IExecute<List<DataFlavor>>("getCurrentDataFlavorsAsList");
        /// <summary>
        /// This method returns the user drop action.
        /// </summary>
        public int DropAction => IExecute<int>("getDropAction");
        /// <summary>
        /// This method returns a Point indicating the Cursor's current location in the Component's coordinates.
        /// </summary>
        public Point Location => IExecute<Point>("getLocation");
        /// <summary>
        /// This method returns the source drop actions.
        /// </summary>
        public int SourceActions => IExecute<int>("getSourceActions");
        /// <summary>
        /// This method returns the Transferable object associated with the drop.
        /// </summary>
        public Transferable Transferable => IExecute<Transferable>("dropComplete");
        /// <summary>
        /// This method returns a boolean indicating if the specified DataFlavor is available from the source.
        /// </summary>
        /// <param name="df">the DataFlavor to test </param>
        /// <returns>if the DataFlavor specified is available from the source</returns>
        public bool IsDataFlavorSupported(DataFlavor df) => IExecute<bool>("isDataFlavorSupported", df);
        /// <summary>
        /// This method returns an int indicating if the source is in the same JVM as the target.
        /// </summary>
        public bool IsLocalTransfer => IExecute<bool>("isLocalTransfer");
        /// <summary>
        /// reject the Drop.
        /// </summary>
        public void RejectDrop() { IExecute("rejectDrop"); }
    }
}
