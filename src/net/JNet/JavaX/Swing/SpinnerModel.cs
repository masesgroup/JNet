/*
*  Copyright 2022 MASES s.r.l.
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

using JavaX.Swing.Event;
using MASES.JCOBridge.C2JBridge;

namespace JavaX.Swing
{
    public class SpinnerModel : JVMBridgeBase<SpinnerModel>
    {
        public override bool IsInterface => true;

        public override string ClassName => "javax.swing.SpinnerModel";

        public void AddChangeListener(ChangeListener l) => IExecute("addChangeListener", l);

        public object NextValue => IExecute("getNextValue");

        public object PreviousValue => IExecute("getPreviousValue");

        public object Value
        {
            get { return IExecute("getValue"); }
            set { IExecute("setValue", value); }
        }

        public void RemoveChangeListener(ChangeListener l) => IExecute("removeChangeListener", l);
    }
}
