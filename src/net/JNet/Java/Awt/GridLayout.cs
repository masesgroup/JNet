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

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    public class GridLayout : JVMBridgeBase<GridLayout>
    {
        public override string ClassName => "java.awt.GridLayout";

        public GridLayout()
        {
        }

        public GridLayout(int rows, int cols) : base(rows, cols)
        {
        }

        public GridLayout(int rows, int cols, int hgap, int vgap) : base(rows, cols, hgap, vgap)
        {
        }

        // TODO: complete the class
    }
}
