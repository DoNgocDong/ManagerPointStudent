using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Controller.Login;
using BaiTapLon_CSharp.src.Database;
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
        private Login loginController = new Login();
        private ConnectDB dbController = new ConnectDB();

        string tableUserAccount = Globals.currentTableUserAccount;
        string userName = Globals.currentAccount;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void eyeOldPass_Click(object sender, EventArgs e)
        {
            loginController.handleChangeStatusPassword(oldPasswordTxt, eyeOldPass);
        }

        private void eyeNewPass_Click(object sender, EventArgs e)
        {
            loginController.handleChangeStatusPassword(newPasswordTxt, eyeNewPass);
        }

        private void eyeConfirmPass_Click(object sender, EventArgs e)
        {
            loginController.handleChangeStatusPassword(confirmPasswordTxt, eyeConfirmPass);
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPasswordTxt.Text.Trim();
            string newUserPassword = newPasswordTxt.Text.Trim();
            string confirmPassword = confirmPasswordTxt.Text.Trim();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (newUserPassword == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newPasswordTxt.Focus();
            }
            else
            {
                try
                {
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (confirmPassword == newUserPassword)
                            {
                                bool check = loginController.changePassword(userName, oldPassword, newUserPassword, tableUserAccount);

                                if (check)
                                    MessageBox.Show("Đổi mật khẩu thành công!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("Đổi mật khẩu thất bại!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Xác nhận mật khẩu không thành công!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        case DialogResult.No:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkChangePassBtn_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPasswordTxt.Text.Trim();
            string newUserPassword = newPasswordTxt.Text.Trim();
            string confirmPassword = confirmPasswordTxt.Text.Trim();

            bool checkOldPass = dbController.checkExistValueInDatabase(oldPassword, "userPassword", tableUserAccount);
            bool checkConfirmPass = confirmPassword == newUserPassword;

            if(newUserPassword == "")
            {
                statusNewPassLabel.Text = "Chưa nhập mật khẩu mới";
                statusNewPassLabel.ForeColor = Color.Red;
            }
            else
            {
                statusNewPassLabel.Text = "OK";
                statusNewPassLabel.ForeColor = Color.Green;
            }
            statusNewPassLabel.Visible = true;

            if (checkOldPass)
            {
                statusOldPassLabel.Text = "Đúng";
                statusOldPassLabel.ForeColor = Color.Green;
            }
            else
            {
                statusOldPassLabel.Text = "Sai mật khẩu";
                statusOldPassLabel.ForeColor = Color.Red;
            }
            statusOldPassLabel.Visible = true;

            if (checkConfirmPass)
            {
                statusConfirmPassLabel.Text = "Đúng";
                statusConfirmPassLabel.ForeColor = Color.Green;
            }
            else
            {
                statusConfirmPassLabel.Text = "Không trùng lặp";
                statusConfirmPassLabel.ForeColor = Color.Red;
            }
            statusConfirmPassLabel.Visible = true;
        }
    }
}
