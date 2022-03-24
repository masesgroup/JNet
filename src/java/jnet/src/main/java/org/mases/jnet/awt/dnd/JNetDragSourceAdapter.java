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

package org.mases.jnet.awt.dnd;

import org.mases.jcobridge.*;

import java.awt.dnd.*;

/**
 * The {@link JNetDragSourceAdapter} class represents a generic implementation of
 * {@link DragSourceListener}, {@link DragSourceMotionListener}
 */
public final class JNetDragSourceAdapter extends JCListener implements DragSourceListener, DragSourceMotionListener {
    public JNetDragSourceAdapter(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Called as the cursor's hotspot enters a platform-dependent drop site. This
     * method is invoked when all the following conditions are true:
     * <UL>
     * <LI>The cursor's hotspot enters the operable part of a platform- dependent
     * drop site.
     * <LI>The drop site is active.
     * <LI>The drop site accepts the drag.
     * </UL>
     *
     * @param dsde the <code>DragSourceDragEvent</code>
     */
    public void dragEnter(DragSourceDragEvent dsde) {
        raiseEvent("dragEnter", dsde);
    }

    /**
     * Called as the cursor's hotspot moves over a platform-dependent drop site.
     * This method is invoked when all the following conditions are true:
     * <UL>
     * <LI>The cursor's hotspot has moved, but still intersects the operable part of
     * the drop site associated with the previous dragEnter() invocation.
     * <LI>The drop site is still active.
     * <LI>The drop site accepts the drag.
     * </UL>
     *
     * @param dsde the <code>DragSourceDragEvent</code>
     */
    public void dragOver(DragSourceDragEvent dsde) {
        raiseEvent("dragOver", dsde);
    }

    /**
     * Called when the user has modified the drop gesture. This method is invoked
     * when the state of the input device(s) that the user is interacting with
     * changes. Such devices are typically the mouse buttons or keyboard modifiers
     * that the user is interacting with.
     *
     * @param dsde the <code>DragSourceDragEvent</code>
     */
    public void dropActionChanged(DragSourceDragEvent dsde) {
        raiseEvent("dropActionChanged", dsde);
    }

    /**
     * Called as the cursor's hotspot exits a platform-dependent drop site. This
     * method is invoked when any of the following conditions are true:
     * <UL>
     * <LI>The cursor's hotspot no longer intersects the operable part of the drop
     * site associated with the previous dragEnter() invocation.
     * </UL>
     * OR
     * <UL>
     * <LI>The drop site associated with the previous dragEnter() invocation is no
     * longer active.
     * </UL>
     * OR
     * <UL>
     * <LI>The drop site associated with the previous dragEnter() invocation has
     * rejected the drag.
     * </UL>
     *
     * @param dse the <code>DragSourceEvent</code>
     */
    public void dragExit(DragSourceEvent dse) {
        raiseEvent("dragExit", dse);
    }

    /**
     * This method is invoked to signify that the Drag and Drop operation is
     * complete. The getDropSuccess() method of the <code>DragSourceDropEvent</code>
     * can be used to determine the termination state. The getDropAction() method
     * returns the operation that the drop site selected to apply to the Drop
     * operation. Once this method is complete, the current
     * <code>DragSourceContext</code> and associated resources become invalid.
     *
     * @param dsde the <code>DragSourceDropEvent</code>
     */
    public void dragDropEnd(DragSourceDropEvent dsde) {
        raiseEvent("dragDropEnd", dsde);
    }

    /**
     * Called whenever the mouse is moved during a drag operation.
     *
     * @param dsde the <code>DragSourceDragEvent</code>
     */
    public void dragMouseMoved(DragSourceDragEvent dsde) {
        raiseEvent("dragMouseMoved", dsde);
    }
}