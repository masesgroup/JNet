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

package org.mases.jnet.generated.javax.imageio.event;

public final class IIOReadWarningListener extends org.mases.jcobridge.JCListener implements javax.imageio.event.IIOReadWarningListener {
    public IIOReadWarningListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void warningOccurred(javax.imageio.ImageReader arg0, java.lang.String arg1) {
        raiseEvent("warningOccurred", arg0, arg1);
    }

}