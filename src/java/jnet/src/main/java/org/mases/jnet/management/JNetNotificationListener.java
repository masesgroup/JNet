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
import org.mases.jcobridge.JCObject;

import javax.management.Notification;
import javax.management.NotificationListener;

/**
 * The {@link JNetNotificationListener} class represents a generic implementation of
 * {@link NotificationListener}
 */
public class JNetNotificationListener extends JCListener implements NotificationListener {
    public JNetNotificationListener(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Invoked when a JMX notification occurs. The implementation of this method should return as soon as possible, to avoid blocking its notification broadcaster.
     *
     * @param notification The notification.
     * @param handback     An opaque object which helps the listener to associate
     *                     information regarding the MBean emitter. This object is passed to the
     *                     addNotificationListener call and resent, without modification, to the
     *                     listener.
     */
    @Override
    public void handleNotification(Notification notification, Object handback) {
        raiseEvent("handleNotification", notification, handback);
    }
}
