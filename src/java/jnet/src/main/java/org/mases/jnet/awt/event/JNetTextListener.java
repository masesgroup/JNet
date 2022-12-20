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

import java.awt.event.TextEvent;
import java.awt.event.TextListener;

/**
 * The {@link JNetTextListener} class represents a generic implementation of
 * {@link TextListener}
 */
public final class JNetTextListener extends JCListener implements TextListener {
    public JNetTextListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Invoked when the value of the text has changed. The code written for this
     * method performs the operations that need to occur when text changes.
     */
    public void textValueChanged(TextEvent e) {
        raiseEvent("textValueChanged", e);
    }
}