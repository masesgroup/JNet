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

using Java.Awt.Event;
using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    public class Adjustable : JVMBridgeBase<Adjustable>
    {
        public override string ClassName => "java.awt.Adjustable";

        public void AddAdjustmentListener(AdjustmentListener l) { IExecute("addAdjustmentListener", l); }

        public void RemoveAdjustmentListener(AdjustmentListener l) { IExecute("removeAdjustmentListener", l); }

        public int BlockIncrement { get { return IExecute<int>("getBlockIncrement"); } set { IExecute("setBlockIncrement", value); } }

        public int Maximum { get { return IExecute<int>("getMaximum"); } set { IExecute("setMaximum", value); } }

        public int Minimum { get { return IExecute<int>("getMinimum"); } set { IExecute("setMinimum", value); } }

        public int Orientation { get { return IExecute<int>("getOrientation"); } }

        public int UnitIncrement { get { return IExecute<int>("getUnitIncrement"); } set { IExecute("setUnitIncrement", value); } }

        public int Value { get { return IExecute<int>("getValue"); } set { IExecute("setValue", value); } }

        public int VisibleAmount { get { return IExecute<int>("getVisibleAmount"); } set { IExecute("setVisibleAmount", value); } }
    }
}
