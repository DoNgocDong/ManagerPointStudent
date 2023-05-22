using BaiTapLon_CSharp.src;
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
    public partial class LoginForm : Form
    {
        private FormController formController = new FormController();
        private Login loginController = new Login();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (Globals.isAdmin)
                loginByAdmin();
            else
                loginByStudent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            LoginMethod loginMethod = new LoginMethod();

            formController.closeAndShow(this, loginMethod);
        }

        private void eyePictureBox_Click(object sender, EventArgs e)
        {
            loginController.handleChangeStatusPassword(userPassword, eyePictureBox);
        }
    }
}