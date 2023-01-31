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

package org.mases.jnet.management;

import org.mases.jcobridge.JCListener;
import org.mases.jcobridge.JCNativeException;

import javax.management.Notification;
import javax.management.NotificationFilter;

/**
 * The {@link JNetNotificationFilter} class represents a generic implementation of
 * {@link NotificationFilter}
 */
public class JNetNotificationFilter extends JCListener implements NotificationFilter {
    public JNetNotificationFilter(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Invoked before sending the specified notification to the listener.
     */
    @Override
    public boolean isNotificationEnabled(Notification notification) {
        raiseEvent("isNotificationEnabled", notification);
        Object retVal = getReturnData();
        return (boolean) retVal;
    }
}
