using BaiTapLon_CSharp.src;
using BaiTapLon_CSharp.src.Controller.Login;
using System.Windows.Forms;

namespace BaiTapLon_CSharp
{
    partial class LoginForm
    {
        Login controller = new Login();

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
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 133);
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
            this.userName.Location = new System.Drawing.Point(47, 165);
            this.userName.Margin = new System.Windows.Forms.Padding(2);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(302, 23);
            this.userName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu :";
            // 
            // userPassword
            // 
            this.userPassword.CausesValidation = false;
            this.userPassword.Location = new System.Drawing.Point(47, 233);
            this.userPassword.Margin = new System.Windows.Forms.Padding(2);
            this.userPassword.Multiline = true;
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(302, 23);
            this.userPassword.TabIndex = 4;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiTapLon_CSharp.Properties.Resources.logo_utt_border_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(299, 397);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(430, 488);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Button loginBtn;
        private Button cancelBtn;

        private void loginByAdmin()
        {
            string table = Globals.tableAdmin;
            string adminName = this.userName.Text.Trim();
            string adminPassword = this.userPassword.Text.Trim();
            if (controller.CheckLogin(adminName, adminPassword, table))
            {
                this.Hide();
                Form homePage = new HomePage();
                homePage.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }
        }

        private void loginByStudent()
        {
            string table = Globals.tableStudent;
            string userName = this.userName.Text.Trim();
            string userPassword = this.userPassword.Text.Trim();
            if (controller.CheckLogin(userName, userPassword, table))
            {
                this.Hide();
                Form homePage = new HomePage();
                homePage.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }
        }
    }
}

