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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*/

package org.mases.jnet.generated.java.util.function;

public final class BiPredicate extends org.mases.jcobridge.JCListener implements java.util.function.BiPredicate {
    public BiPredicate(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public boolean test(java.lang.Object arg0, java.lang.Object arg1) {
        raiseEvent("test", arg0, arg1); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public java.util.function.BiPredicate and(java.util.function.BiPredicate arg0) {
        raiseEvent("and", arg0); Object retVal = getReturnData(); return (java.util.function.BiPredicate)retVal;
    }
    //@Override
    public java.util.function.BiPredicate andDefault(java.util.function.BiPredicate arg0) {
        return java.util.function.BiPredicate.super.and(arg0);
    }
    //@Override
    public java.util.function.BiPredicate negate() {
        raiseEvent("negate"); Object retVal = getReturnData(); return (java.util.function.BiPredicate)retVal;
    }
    //@Override
    public java.util.function.BiPredicate negateDefault() {
        return java.util.function.BiPredicate.super.negate();
    }
    //@Override
    public java.util.function.BiPredicate or(java.util.function.BiPredicate arg0) {
        raiseEvent("or", arg0); Object retVal = getReturnData(); return (java.util.function.BiPredicate)retVal;
    }
    //@Override
    public java.util.function.BiPredicate orDefault(java.util.function.BiPredicate arg0) {
        return java.util.function.BiPredicate.super.or(arg0);
    }

}