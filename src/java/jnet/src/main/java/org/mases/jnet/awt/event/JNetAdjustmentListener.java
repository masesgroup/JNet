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

import java.awt.event.AdjustmentEvent;
import java.awt.event.AdjustmentListener;

/**
 * The {@link JNetAdjustmentListener} class represents a generic implementation of
 * {@link AdjustmentListener}
 */
public class JNetAdjustmentListener extends JCListener implements AdjustmentListener {
    public JNetAdjustmentListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Invoked when the value of the adjustable has changed.
     */
    public void adjustmentValueChanged(AdjustmentEvent e) {
        raiseEvent("adjustmentValueChanged", e);
    }

}