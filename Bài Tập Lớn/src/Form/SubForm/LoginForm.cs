using BaiTapLon_CSharp.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp
{
    public partial class LoginForm : Form
    {
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
            this.Close();
            LoginMethod loginMethod = new LoginMethod();
            loginMethod.Show();
        }
    }
}