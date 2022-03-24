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

import java.awt.event.FocusEvent;
import java.awt.event.FocusListener;

/**
 * The {@link JNetFocusListener} class represents a generic implementation of
 * {@link FocusListener}
 */
public final class JNetFocusListener extends JCListener implements FocusListener {
    public JNetFocusListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Invoked when a component gains the keyboard focus.
     */
    public void focusGained(FocusEvent e) {
        raiseEvent("focusGained", e);
    }

    /**
     * Invoked when a component loses the keyboard focus.
     */
    public void focusLost(FocusEvent e) {
        raiseEvent("focusLost", e);
    }
}