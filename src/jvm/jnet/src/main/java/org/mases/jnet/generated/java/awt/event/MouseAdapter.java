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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*/

package org.mases.jnet.generated.java.awt.event;

public final class MouseAdapter extends org.mases.jcobridge.JCListener implements java.awt.event.MouseListener, java.awt.event.MouseWheelListener, java.awt.event.MouseMotionListener {
    public MouseAdapter(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void mouseClicked(java.awt.event.MouseEvent arg0) {
        raiseEvent("mouseClicked", arg0);
    }
    //@Override
    public void mouseDragged(java.awt.event.MouseEvent arg0) {
        raiseEvent("mouseDragged", arg0);
    }
    //@Override
    public void mouseEntered(java.awt.event.MouseEvent arg0) {
        raiseEvent("mouseEntered", arg0);
    }
    //@Override
    public void mouseExited(java.awt.event.MouseEvent arg0) {
        raiseEvent("mouseExited", arg0);
    }
    //@Override
    public void mouseMoved(java.awt.event.MouseEvent arg0) {
        raiseEvent("mouseMoved", arg0);
    }
    //@Override
    public void mousePressed(java.awt.event.MouseEvent arg0) {
        raiseEvent("mousePressed", arg0);
    }
    //@Override
    public void mouseReleased(java.awt.event.MouseEvent arg0) {
        raiseEvent("mouseReleased", arg0);
    }
    //@Override
    public void mouseWheelMoved(java.awt.event.MouseWheelEvent arg0) {
        raiseEvent("mouseWheelMoved", arg0);
    }

}