using MASES.JNet;
using System;
using System.Windows.Forms;

namespace MASES.JNetWinFormsTest
{
    class JNetTest : JNetCore<JNetTest> { }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            JNetTest.CreateGlobalInstance();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
