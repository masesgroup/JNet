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

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

/**
 * The {@link JNetKeyListener} class represents a generic implementation of
 * {@link KeyListener}
 */
public final class JNetKeyListener extends JCListener implements KeyListener {
    public JNetKeyListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Invoked when a key has been typed. See the class description for
     * {@link KeyEvent} for a definition of a key typed event.
     */
    public void keyTyped(KeyEvent e) {
        raiseEvent("keyTyped", e);
    }

    /**
     * Invoked when a key has been pressed. See the class description for
     * {@link KeyEvent} for a definition of a key pressed event.
     */
    public void keyPressed(KeyEvent e) {
        raiseEvent("keyPressed", e);
    }

    /**
     * Invoked when a key has been released. See the class description for
     * {@link KeyEvent} for a definition of a key released event.
     */
    public void keyReleased(KeyEvent e) {
        raiseEvent("keyReleased", e);
    }
}