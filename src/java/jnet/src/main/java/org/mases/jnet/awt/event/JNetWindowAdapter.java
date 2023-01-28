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

package org.mases.jnet.awt.event;

import org.mases.jcobridge.*;

import java.awt.event.WindowEvent;
import java.awt.event.WindowFocusListener;
import java.awt.event.WindowListener;
import java.awt.event.WindowStateListener;

/**
 * The {@link JNetWindowAdapter} class represents a generic implementation of
 * {@link WindowListener}, {@link WindowStateListener}, {@link WindowFocusListener}
 */
public class JNetWindowAdapter extends JCListener implements WindowListener, WindowStateListener, WindowFocusListener {
    public JNetWindowAdapter(String key) throws JCNativeException {
        super(key);
    }

    public void windowActivated(WindowEvent e) {
        raiseEvent("windowActivated", e);
    }

    public void windowClosed(WindowEvent e) {
        raiseEvent("windowClosed", e);
    }

    public void windowClosing(WindowEvent e) {
        raiseEvent("windowClosing", e);
    }

    public void windowDeactivated(WindowEvent e) {
        raiseEvent("windowDeactivated", e);
    }

    public void windowDeiconified(WindowEvent e) {
        raiseEvent("windowDeiconified", e);
    }

    public void windowGainedFocus(WindowEvent e) {
        raiseEvent("windowGainedFocus", e);
    }

    public void windowIconified(WindowEvent e) {
        raiseEvent("windowIconified", e);
    }

    public void windowLostFocus(WindowEvent e) {
        raiseEvent("windowLostFocus", e);
    }

    public void windowOpened(WindowEvent e) {
        raiseEvent("windowOpened", e);
    }

    public void windowStateChanged(WindowEvent e) {
        raiseEvent("windowStateChanged", e);
    }
}