using BaiTapLon_CSharp.src.Forms.MainForm;
using BaiTapLon_CSharp.src.Forms.MainForm.Actions;
using BaiTapLon_CSharp.src.Forms.MainForm.Manager;
using System;
using System.Windows.Forms;

namespace BaiTapLon_CSharp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewProfileStudent());
        }
    }
}
