using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Controller.Login;
using BaiTapLon_CSharp.src.Forms.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.SubForm
{
    public partial class ChangePassword : Form
    {
        private Login loginConroller = new Login();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTxt.Text.Trim();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void checkNewPassBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
