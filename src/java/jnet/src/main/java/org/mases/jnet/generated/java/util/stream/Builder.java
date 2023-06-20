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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*/

package org.mases.jnet.generated.java.util.stream;

public final class Builder extends org.mases.jcobridge.JCListener implements java.util.stream.Stream.Builder {
    public Builder(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public java.util.stream.Stream build() {
        raiseEvent("build"); Object retVal = getReturnData(); return (java.util.stream.Stream)retVal;
    }
    //@Override
    public void accept(java.lang.Object arg0) {
        raiseEvent("accept", arg0);
    }
    //@Override
    public java.util.function.Consumer andThen(java.util.function.Consumer arg0) {
        raiseEvent("andThen", arg0); Object retVal = getReturnData(); return (java.util.function.Consumer)retVal;
    }
    //@Override
    public java.util.stream.Stream.Builder add(java.lang.Object arg0) {
        raiseEvent("add", arg0); Object retVal = getReturnData(); return (java.util.stream.Stream.Builder)retVal;
    }

}