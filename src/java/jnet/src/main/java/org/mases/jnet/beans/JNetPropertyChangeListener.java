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

package org.mases.jnet.beans;

import org.mases.jcobridge.*;

import java.beans.PropertyChangeEvent;
import java.beans.PropertyChangeListener;

/**
 * The {@link JNetPropertyChangeListener} class represents a generic implementation of
 * {@link PropertyChangeListener}
 */
public final class JNetPropertyChangeListener extends JCListener implements PropertyChangeListener {
    public JNetPropertyChangeListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * This method gets called when a bound property is changed.
     *
     * @param evt A {@link PropertyChangeEvent} object describing the event source
     *            and the property that has changed.
     */
    public void propertyChange(PropertyChangeEvent evt) {
        raiseEvent("propertyChange", evt);
    }
}