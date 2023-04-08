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

using System;
using System.Windows.Forms;
using MASES.JNetTest.GraphicCommon;
using Java.Awt.EventNs;

namespace MASES.JNetWinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
#if NET462_OR_GREATER
            Text = "Main Windows in WinForms .NET Framework";
#else
            Text = "Main Windows in WinForms .NET Core WindowsDesktop";
#endif
            if (MessageBox.Show(null, "Create AWT?", "AWT/Swing question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var javaControlWrapper = GraphicCommon.CreateAWTContent(ActionDone) as Control;
                javaControlWrapper.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(javaControlWrapper, 1, 0);
            }
            else
            {
                var javaControlWrapper = GraphicCommon.CreateSwingContent() as Control;
                javaControlWrapper.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(javaControlWrapper, 1, 0);
            }
        }

        void ActionDone(ActionEvent args)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(delegate { textBox1.Text += GraphicCommon.TextArea.Text + Environment.NewLine; }));
            }
            else
            {
                textBox1.Text += args.ActionCommand + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
