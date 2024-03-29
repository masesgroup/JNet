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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*/

package org.mases.jnet.generated.java.util.function;

public final class UnaryOperator extends org.mases.jcobridge.JCListener implements java.util.function.UnaryOperator {
    public UnaryOperator(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public java.lang.Object apply(java.lang.Object arg0) {
        raiseEvent("apply", arg0); Object retVal = getReturnData(); return (java.lang.Object)retVal;
    }
    //@Override
    public java.util.function.Function andThen(java.util.function.Function arg0) {
        raiseEvent("andThen", arg0); Object retVal = getReturnData(); return (java.util.function.Function)retVal;
    }
    //@Override
    public java.util.function.Function andThenDefault(java.util.function.Function arg0) {
        return java.util.function.UnaryOperator.super.andThen(arg0);
    }
    //@Override
    public java.util.function.Function compose(java.util.function.Function arg0) {
        raiseEvent("compose", arg0); Object retVal = getReturnData(); return (java.util.function.Function)retVal;
    }
    //@Override
    public java.util.function.Function composeDefault(java.util.function.Function arg0) {
        return java.util.function.UnaryOperator.super.compose(arg0);
    }

}