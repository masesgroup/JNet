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

package org.mases.jnet.awt.event;

import org.mases.jcobridge.*;

import java.awt.event.*;

/**
 * The {@link JNetMouseAdapter} class represents a generic implementation of
 * {@link MouseListener}, {@link MouseMotionListener}, {@link MouseWheelListener}
 */
public class JNetMouseAdapter extends JCListener implements MouseListener, MouseMotionListener, MouseWheelListener {
    public JNetMouseAdapter(String key) throws JCNativeException {
        super(key);
    }

    public void mouseClicked(MouseEvent e) {
        raiseEvent("mouseClicked", e);
    }

    public void mouseEntered(MouseEvent e) {
        raiseEvent("mouseEntered", e);
    }

    public void mouseExited(MouseEvent e) {
        raiseEvent("mouseExited", e);
    }

    public void mousePressed(MouseEvent e) {
        raiseEvent("mousePressed", e);
    }

    public void mouseReleased(MouseEvent e) {
        raiseEvent("mouseReleased", e);
    }

    public void mouseDragged(MouseEvent e) {
        raiseEvent("mouseDragged", e);
    }

    public void mouseMoved(MouseEvent e) {
        raiseEvent("mouseMoved", e);
    }

    public void mouseWheelMoved(MouseWheelEvent e) {
        raiseEvent("mouseWheelMoved", e);
    }
}