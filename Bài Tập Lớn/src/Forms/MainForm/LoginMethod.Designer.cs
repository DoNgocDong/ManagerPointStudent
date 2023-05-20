using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Forms.SubForm;

namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    partial class LoginMethod
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginStudent = new System.Windows.Forms.Button();
            this.loginLecturer = new System.Windows.Forms.Button();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.pictureLecturers = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP VỚI TƯ CÁCH:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginStudent);
            this.panel1.Controls.Add(this.loginLecturer);
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 62);
            this.panel1.TabIndex = 1;
            // 
            // loginStudent
            // 
            this.loginStudent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginStudent.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStudent.Location = new System.Drawing.Point(400, 9);
            this.loginStudent.Name = "loginStudent";
            this.loginStudent.Size = new System.Drawing.Size(110, 50);
            this.loginStudent.TabIndex = 1;
            this.loginStudent.Text = "SINH VIÊN";
            this.loginStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loginStudent.UseVisualStyleBackColor = false;
            this.loginStudent.Click += new System.EventHandler(this.loginStudent_Click);
            // 
            // loginLecturer
            // 
            this.loginLecturer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLecturer.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLecturer.Location = new System.Drawing.Point(180, 9);
            this.loginLecturer.Name = "loginLecturer";
            this.loginLecturer.Size = new System.Drawing.Size(110, 50);
            this.loginLecturer.TabIndex = 0;
            this.loginLecturer.Text = "QUẢN TRỊ VIÊN";
            this.loginLecturer.UseVisualStyleBackColor = false;
            this.loginLecturer.Click += new System.EventHandler(this.loginLecturer_Click);
            // 
            // pictureStudent
            // 
            this.pictureStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureStudent.Image = global::BaiTapLon_CSharp.Properties.Resources.iconStudent;
            this.pictureStudent.Location = new System.Drawing.Point(400, 141);
            this.pictureStudent.Name = "pictureStudent";
            this.pictureStudent.Size = new System.Drawing.Size(110, 95);
            this.pictureStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStudent.TabIndex = 3;
            this.pictureStudent.TabStop = false;
            this.pictureStudent.Click += new System.EventHandler(this.pictureStudent_Click);
            // 
            // pictureLecturers
            // 
            this.pictureLecturers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLecturers.Image = global::BaiTapLon_CSharp.Properties.Resources.iconLecturer;
            this.pictureLecturers.ImageLocation = "";
            this.pictureLecturers.Location = new System.Drawing.Point(180, 141);
            this.pictureLecturers.Name = "pictureLecturers";
            this.pictureLecturers.Size = new System.Drawing.Size(110, 95);
            this.pictureLecturers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLecturers.TabIndex = 2;
            this.pictureLecturers.TabStop = false;
            this.pictureLecturers.Click += new System.EventHandler(this.pictureLecturers_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(639, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(61, 25);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "THOÁT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 424);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureStudent);
            this.Controls.Add(this.pictureLecturers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "LoginMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginStudent;
        private System.Windows.Forms.Button loginLecturer;
        private System.Windows.Forms.PictureBox pictureLecturers;
        private System.Windows.Forms.PictureBox pictureStudent;
        private System.Windows.Forms.Button exitBtn;

        private FormController formController = new FormController();

        private void loginByLecturer()
        {
            Globals.isAdmin = true;

            LoginForm loginForm = new LoginForm();
            formController.hideAndShow(this, loginForm);
        }

        private void loginByStudent()
        {
            Globals.isAdmin = false;

            LoginForm loginForm = new LoginForm();
            formController.hideAndShow(this, loginForm);
        }
    }
}