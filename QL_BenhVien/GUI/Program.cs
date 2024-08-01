using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {

        public static frmMain FrmMain = null;
        public static frmDangNhap FrmDangNhap = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmDangNhap = new frmDangNhap();
            Application.Run(new frmXepLichLamViec());
        }
    }
}
