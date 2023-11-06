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

import java.awt.dnd.DragGestureEvent;
import java.awt.dnd.DragGestureListener;

/**
 * The {@link JNetDragGestureListener} class represents a generic implementation
 * of {@link DragGestureListener}
 */
public final class JNetDragGestureListener extends JCListener implements DragGestureListener {
    public JNetDragGestureListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * This method is invoked by the {@code DragGestureRecognizer} when the
     * {@code DragGestureRecognizer} detects a platform-dependent drag initiating
     * gesture. To initiate the drag and drop operation, if appropriate,
     * {@link DragGestureEvent#startDrag startDrag()} method on the
     * {@code DragGestureEvent} has to be invoked.
     * <p>
     *
     * @param dge the <code>DragGestureEvent</code> describing the gesture that has
     *            just occurred
     * @see java.awt.dnd.DragGestureRecognizer
     * @see java.awt.dnd.DragGestureEvent
     */
    public void dragGestureRecognized(DragGestureEvent dge) {
        raiseEvent("dragGestureRecognized", dge);
    }
}