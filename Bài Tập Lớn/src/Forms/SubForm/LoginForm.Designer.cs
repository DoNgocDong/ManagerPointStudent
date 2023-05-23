using BaiTapLon_CSharp.src;
using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Controller.Login;
using BaiTapLon_CSharp.src.Forms.MainForm;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.SubForm
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.eyePictureBox = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.logoUTT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoUTT)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG\r\nQUẢN LÝ ĐIỂM SINH VIÊN\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(49, 165);
            this.userName.Margin = new System.Windows.Forms.Padding(2);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(302, 27);
            this.userName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu :";
            // 
            // userPassword
            // 
            this.userPassword.CausesValidation = false;
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.Location = new System.Drawing.Point(49, 233);
            this.userPassword.Margin = new System.Windows.Forms.Padding(2);
            this.userPassword.Multiline = true;
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.Size = new System.Drawing.Size(302, 27);
            this.userPassword.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.cancelBtn.Location = new System.Drawing.Point(0, 1);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Quay lại";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // eyePictureBox
            // 
            this.eyePictureBox.BackColor = System.Drawing.Color.White;
            this.eyePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eyePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyePictureBox.Image = global::BaiTapLon_CSharp.Properties.Resources.hideEye;
            this.eyePictureBox.Location = new System.Drawing.Point(322, 233);
            this.eyePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.eyePictureBox.Name = "eyePictureBox";
            this.eyePictureBox.Size = new System.Drawing.Size(29, 27);
            this.eyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyePictureBox.TabIndex = 7;
            this.eyePictureBox.TabStop = false;
            this.eyePictureBox.Click += new System.EventHandler(this.eyePictureBox_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = true;
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Image = global::BaiTapLon_CSharp.Properties.Resources.Chưa_có_tên_removebg_preview;
            this.loginBtn.Location = new System.Drawing.Point(100, 314);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(206, 80);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Đăng Nhập";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // logoUTT
            // 
            this.logoUTT.Image = global::BaiTapLon_CSharp.Properties.Resources.logo_utt_border_removebg_preview1;
            this.logoUTT.Location = new System.Drawing.Point(299, 397);
            this.logoUTT.Margin = new System.Windows.Forms.Padding(2);
            this.logoUTT.Name = "logoUTT";
            this.logoUTT.Size = new System.Drawing.Size(128, 88);
            this.logoUTT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoUTT.TabIndex = 1;
            this.logoUTT.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(430, 488);
            this.ControlBox = false;
            this.Controls.Add(this.eyePictureBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoUTT);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoUTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoUTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Button loginBtn;
        private Button cancelBtn;

        private void loginByAdmin()
        {
            string table = Globals.tableAdminAccount;
            string adminName = this.userName.Text.Trim();
            string adminPassword = this.userPassword.Text.Trim();
            if (loginController.CheckLogin(adminName, adminPassword, table))
            {
                Globals.currentAccount = adminName;
                Globals.currentTableUserAccount = table;

                HomePage homePage = new HomePage();
                formController.closeAndShow(this, homePage);
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }
        }

        private void loginByStudent()
        {
            string table = Globals.tableStudentAccount;
            string userName = this.userName.Text.Trim();
            string userPassword = this.userPassword.Text.Trim();
            if (loginController.CheckLogin(userName, userPassword, table))
            {
                Globals.currentAccount = userName;
                Globals.currentTableUserAccount = table;

                HomePage homePage = new HomePage();
                formController.closeAndShow(this, homePage);
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }
        }

        private PictureBox eyePictureBox;
    }
}

