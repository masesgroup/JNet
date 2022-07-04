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

using JavaX.Swing.Text;

namespace JavaX.Swing
{
    public class JTextArea : JTextComponent
    {
        public override string ClassName => "javax.swing.JTextArea";

        public JTextArea()
        {
        }

        //public JTextArea(Document doc) : base(doc)
        //{
        //}

        //public JTextArea(Document doc, string text, int rows, int columns) : base(doc, text, rows, columns)
        //{
        //}

        public JTextArea(int rows, int columns) : base(rows, columns)
        {
        }

        public JTextArea(string text) : base(text)
        {
        }

        public JTextArea(string text, int rows, int columns) : base(text, rows, columns)
        {
        }
    }
}
