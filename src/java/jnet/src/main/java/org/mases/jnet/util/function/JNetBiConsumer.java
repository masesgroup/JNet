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

package org.mases.jnet.util.function;

import org.mases.jcobridge.*;

import java.util.function.BiConsumer;

/**
 * The {@link JNetBiConsumer} class represents a generic implementation of
 * {@link BiConsumer}
 */
public final class JNetBiConsumer extends JCListener implements BiConsumer {
    public JNetBiConsumer(String key) throws JCNativeException {
        super(key);
    }

    @Override
    public void accept(Object e1, Object e2) {
        raiseEvent("accept", e1, e2);
    }
}