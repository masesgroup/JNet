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

import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;

/**
 * The {@link JNetItemListener} class represents a generic implementation of
 * {@link ItemListener}
 */
public final class JNetItemListener extends JCListener implements ItemListener {
    public JNetItemListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Invoked when an item has been selected or deselected by the user. The code
     * written for this method performs the operations that need to occur when an
     * item is selected (or deselected).
     */
    public void itemStateChanged(ItemEvent e) {
        raiseEvent("itemStateChanged", e);
    }
}