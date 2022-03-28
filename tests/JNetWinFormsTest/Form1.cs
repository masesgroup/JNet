using System;
using System.Windows.Forms;
using MASES.JNetGraphicCommon;
using Java.Awt.Event;

namespace MASES.JNetWinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
#if NETFRAMEWORK
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
                textBox1.Invoke(new MethodInvoker(delegate { textBox1.Text += GraphicCommon.TextArea.getText() + Environment.NewLine; }));
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
