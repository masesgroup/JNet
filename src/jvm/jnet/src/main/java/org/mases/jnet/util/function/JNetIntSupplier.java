/*
 *  Copyright 2024 MASES s.r.l.
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

import java.util.function.IntSupplier;

/**
 * The {@link JNetIntSupplier} class represents a generic implementation of
 * {@link IntSupplier}
 */
public final class JNetIntSupplier extends JCListener implements IntSupplier {
    public JNetIntSupplier(String key) throws JCNativeException {
        super(key);
    }

    @Override
    public int getAsInt() {
        raiseEvent("getAsInt", null);
        Object retVal = getReturnData();
        return (int) retVal;
    }
}