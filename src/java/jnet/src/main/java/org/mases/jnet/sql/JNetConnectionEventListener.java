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

package org.mases.jnet.sql;

import org.mases.jcobridge.*;

import javax.sql.ConnectionEvent;
import javax.sql.ConnectionEventListener;

/**
 * The {@link JNetConnectionEventListener} class represents a generic
 * implementation of {@link ConnectionEventListener}
 */
public final class JNetConnectionEventListener extends JCListener implements ConnectionEventListener {
    public JNetConnectionEventListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Notifies this <code>ConnectionEventListener</code> that the application has
     * called the method <code>close</code> on its representation of a pooled
     * connection.
     *
     * @param event an event object describing the source of the event
     */
    public void connectionClosed(ConnectionEvent event) {
        raiseEvent("connectionClosed", event);
    }

    /**
     * Notifies this <code>ConnectionEventListener</code> that a fatal error has
     * occurred and the pooled connection can no longer be used. The driver makes
     * this notification just before it throws the application the
     * <code>SQLException</code> contained in the given <code>ConnectionEvent</code>
     * object.
     *
     * @param event an event object describing the source of the event and
     *              containing the <code>SQLException</code> that the driver is
     *              about to throw
     */
    public void connectionErrorOccurred(ConnectionEvent event) {
        raiseEvent("connectionErrorOccurred", event);
    }
}