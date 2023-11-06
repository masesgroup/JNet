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

import java.awt.event.InputMethodEvent;
import java.awt.event.InputMethodListener;

/**
 * The {@link JNetInputMethodListener} class represents a generic implementation
 * of {@link InputMethodListener}
 */
public final class JNetInputMethodListener extends JCListener implements InputMethodListener {
    public JNetInputMethodListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Invoked when the text entered through an input method has changed.
     */
    public void inputMethodTextChanged(InputMethodEvent event) {
        raiseEvent("inputMethodTextChanged", event);
    }

    /**
     * Invoked when the caret within composed text has changed.
     */
    public void caretPositionChanged(InputMethodEvent event) {
        raiseEvent("caretPositionChanged", event);
    }
}