using MASES.JNet;
using System;
using System.Windows.Forms;

namespace MASES.JNetWinFormsTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            JNetCore.CreateGlobalInstance();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
