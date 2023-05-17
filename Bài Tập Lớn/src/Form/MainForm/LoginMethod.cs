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
    public partial class LoginMethod : Form
    {
        public LoginMethod()
        {
            InitializeComponent();
        }
        private void loginLecturer_Click(object sender, EventArgs e)
        {
            loginByLecturer();
        }

        private void pictureLecturers_Click(object sender, EventArgs e)
        {
            loginByLecturer();
        }

        private void loginStudent_Click(object sender, EventArgs e)
        {
            loginByStudent();
        }

        private void pictureStudent_Click(object sender, EventArgs e)
        {
            loginByStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
