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

package org.mases.jnet.developed.java.util;

import org.mases.jcobridge.*;

import java.util.function.Function;
import java.util.function.ToDoubleFunction;
import java.util.function.ToIntFunction;
import java.util.function.ToLongFunction;

/**
 * The {@link Comparator} class represents a generic implementation
 * of {@link java.util.Comparator}
 */
public class Comparator extends JCListener implements java.util.Comparator {
    public Comparator(String key) throws JCNativeException {
        super(key);
    }

    public int compare(Object o1, Object o2) {
        raiseEvent("compare", o1, o2);
        Object returnVal = getReturnData();
        return (int) returnVal;
    }

    @Override
    public boolean equals(Object obj) {
        raiseEvent("equals", obj);
        Object returnVal = getReturnData();
        return (boolean) returnVal;
    }
}