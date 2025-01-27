/*
 *  Copyright 2025 MASES s.r.l.
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

package org.mases.jnet.developed.java.lang;

import org.mases.jcobridge.JCListener;
import org.mases.jcobridge.JCNativeException;
import org.mases.jcobridge.JCObject;

/**
 * The {@link Thread_UncaughtExceptionHandler} class represents a generic implementation of
 * {@link Thread.UncaughtExceptionHandler}
 */
public class Thread_UncaughtExceptionHandler extends JCListener implements Thread.UncaughtExceptionHandler {
    public Thread_UncaughtExceptionHandler(String key) throws JCNativeException {
        super(key);
    }

    /**
     * Method invoked when the given thread terminates due to the given uncaught exception.
     */
    public void uncaughtException(Thread t, Throwable e) {
        raiseEvent("uncaughtException", t, e);
    }
}