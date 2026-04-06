/*
 *  Copyright (c) 2022-2026 MASES s.r.l.
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

package org.mases.jnet.developed;

public class JNetEventResult {
   volatile boolean _hasOverrideSet = false;
   volatile boolean _hasOverride = false;
   volatile Object _returnData;

   public boolean getHasOverride() {
      if (!_hasOverrideSet) throw new IllegalStateException(".NET side never changed the value of HasOverride property.");
      return _hasOverride;
   }

   public void setHasOverride(boolean hasOverride) {
      _hasOverrideSet = true;
      _hasOverride = hasOverride;
   }

   public Object getReturnData() {
      if (!_hasOverrideSet) throw new IllegalStateException(".NET side never changed the value of HasOverride property.");
      return _returnData;
   }

   public void setReturnData(Object retData) {
      throw new IllegalStateException(".NET side shall never invoke this method.");
      //_returnData = retData;
   }
   
   public void setReturnData(boolean hasOverride, Object retData) {
      _hasOverrideSet = true;
      _hasOverride = hasOverride;
      _returnData = retData;
   }
}