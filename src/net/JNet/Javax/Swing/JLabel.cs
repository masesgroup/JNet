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

namespace Javax.Swing
{
    public class JLabel : JComponent
    {
        public override string ClassName => "javax.swing.JLabel";

        public JLabel()
        {
        }

        //public JLabel(Icon image) : base(image)
        //{
        //}

        //public JLabel(Icon image, int horizontalAlignment) : base(image, horizontalAlignment)
        //{
        //}

        public JLabel(string text) : base(text)
        {
        }

        //public JLabel(string text, Icon icon, int horizontalAlignment) : base(text, icon, horizontalAlignment)
        //{
        //}

        public JLabel(string text, int horizontalAlignment) : base(text, horizontalAlignment)
        {
        }
    }
}
