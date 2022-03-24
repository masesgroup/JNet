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

import java.awt.event.ComponentEvent;
import java.awt.event.ComponentListener;

/**
 * The {@link JNetComponentListener} class represents a generic implementation of
 * {@link ComponentListener}
 */
public final class JNetComponentListener extends JCListener implements ComponentListener {
    public JNetComponentListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Invoked when the component's size changes.
     */
    public void componentResized(ComponentEvent e) {
        raiseEvent("componentResized", e);
    }

    /**
     * Invoked when the component's position changes.
     */
    public void componentMoved(ComponentEvent e) {
        raiseEvent("componentMoved", e);
    }

    /**
     * Invoked when the component has been made visible.
     */
    public void componentShown(ComponentEvent e) {
        raiseEvent("componentShown", e);
    }

    /**
     * Invoked when the component has been made invisible.
     */
    public void componentHidden(ComponentEvent e) {
        raiseEvent("componentHidden", e);
    }
}