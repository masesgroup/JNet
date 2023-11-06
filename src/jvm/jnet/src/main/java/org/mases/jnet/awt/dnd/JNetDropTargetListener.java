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

package org.mases.jnet.awt.dnd;

import org.mases.jcobridge.*;

import java.awt.dnd.DropTargetDragEvent;
import java.awt.dnd.DropTargetDropEvent;
import java.awt.dnd.DropTargetEvent;
import java.awt.dnd.DropTargetListener;

/**
 * The {@link JNetDropTargetListener} class represents a generic implementation of
 * {@link DropTargetListener}
 */
public final class JNetDropTargetListener extends JCListener implements DropTargetListener {
    public JNetDropTargetListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Called while a drag operation is ongoing, when the mouse pointer enters the
     * operable part of the drop site for the <code>DropTarget</code> registered
     * with this listener.
     *
     * @param dtde the <code>DropTargetDragEvent</code>
     */
    public void dragEnter(DropTargetDragEvent dtde) {
        raiseEvent("dragEnter", dtde);
    }

    /**
     * Called when a drag operation is ongoing, while the mouse pointer is still
     * over the operable part of the drop site for the <code>DropTarget</code>
     * registered with this listener.
     *
     * @param dtde the <code>DropTargetDragEvent</code>
     */
    public void dragOver(DropTargetDragEvent dtde) {
        raiseEvent("dragOver", dtde);
    }

    /**
     * Called if the user has modified the current drop gesture.
     * <p>
     *
     * @param dtde the <code>DropTargetDragEvent</code>
     */

    public void dropActionChanged(DropTargetDragEvent dtde) {
        raiseEvent("dropActionChanged", dtde);
    }

    /**
     * Called while a drag operation is ongoing, when the mouse pointer has exited
     * the operable part of the drop site for the <code>DropTarget</code> registered
     * with this listener.
     *
     * @param dte the <code>DropTargetEvent</code>
     */

    public void dragExit(DropTargetEvent dte) {
        raiseEvent("dragExit", dte);
    }

    /**
     * Called when the drag operation has terminated with a drop on the operable
     * part of the drop site for the <code>DropTarget</code> registered with this
     * listener.
     * <p>
     * This method is responsible for undertaking the transfer of the data
     * associated with the gesture. The <code>DropTargetDropEvent</code> provides a
     * means to obtain a <code>Transferable</code> object that represents the data
     * object(s) to be transfered.
     * <p>
     * From this method, the <code>DropTargetListener</code> shall accept or reject
     * the drop via the acceptDrop(int dropAction) or rejectDrop() methods of the
     * <code>DropTargetDropEvent</code> parameter.
     * <p>
     * Subsequent to acceptDrop(), but not before,
     * <code>DropTargetDropEvent</code>'s getTransferable() method may be invoked,
     * and data transfer may be performed via the returned
     * <code>Transferable</code>'s getTransferData() method.
     * <p>
     * At the completion of a drop, an implementation of this method is required to
     * signal the success/failure of the drop by passing an appropriate
     * <code>boolean</code> to the <code>DropTargetDropEvent</code>'s
     * dropComplete(boolean success) method.
     * <p>
     * Note: The data transfer should be completed before the call to the
     * <code>DropTargetDropEvent</code>'s dropComplete(boolean success) method.
     * After that, a call to the getTransferData() method of the
     * <code>Transferable</code> returned by
     * <code>DropTargetDropEvent.getTransferable()</code> is guaranteed to succeed
     * only if the data transfer is local; that is, only if
     * <code>DropTargetDropEvent.isLocalTransfer()</code> returns <code>true</code>.
     * Otherwise, the behavior of the call is implementation-dependent.
     * <p>
     *
     * @param dtde the <code>DropTargetDropEvent</code>
     */

    public void drop(DropTargetDropEvent dtde) {
        raiseEvent("drop", dtde);
    }
}