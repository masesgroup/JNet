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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*/

package org.mases.jnet.generated.javax.imageio.event;

public final class IIOWriteProgressListener extends org.mases.jcobridge.JCListener implements javax.imageio.event.IIOWriteProgressListener {
    public IIOWriteProgressListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void imageComplete(javax.imageio.ImageWriter arg0) {
        raiseEvent("imageComplete", arg0);
    }
    //@Override
    public void imageProgress(javax.imageio.ImageWriter arg0, float arg1) {
        raiseEvent("imageProgress", arg0, arg1);
    }
    //@Override
    public void imageStarted(javax.imageio.ImageWriter arg0, int arg1) {
        raiseEvent("imageStarted", arg0, arg1);
    }
    //@Override
    public void thumbnailComplete(javax.imageio.ImageWriter arg0) {
        raiseEvent("thumbnailComplete", arg0);
    }
    //@Override
    public void thumbnailProgress(javax.imageio.ImageWriter arg0, float arg1) {
        raiseEvent("thumbnailProgress", arg0, arg1);
    }
    //@Override
    public void thumbnailStarted(javax.imageio.ImageWriter arg0, int arg1, int arg2) {
        raiseEvent("thumbnailStarted", arg0, arg1, arg2);
    }
    //@Override
    public void writeAborted(javax.imageio.ImageWriter arg0) {
        raiseEvent("writeAborted", arg0);
    }

}