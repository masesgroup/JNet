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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*/

package org.mases.jnet.generated.java.util.prefs;

public final class NodeChangeListener extends org.mases.jcobridge.JCListener implements java.util.prefs.NodeChangeListener {
    public NodeChangeListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void childAdded(java.util.prefs.NodeChangeEvent arg0) {
        raiseEvent("childAdded", arg0);
    }
    //@Override
    public void childRemoved(java.util.prefs.NodeChangeEvent arg0) {
        raiseEvent("childRemoved", arg0);
    }

}