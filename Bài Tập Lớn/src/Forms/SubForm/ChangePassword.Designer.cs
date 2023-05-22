namespace BaiTapLon_CSharp.src.Forms.SubForm
{
    partial class ChangePassword
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
            this.caption = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.eyeOldPass = new System.Windows.Forms.PictureBox();
            this.oldPasswordTxt = new System.Windows.Forms.TextBox();
            this.eyeNewPass = new System.Windows.Forms.PictureBox();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.eyeConfirmPass = new System.Windows.Forms.PictureBox();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOldPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeConfirmPass)).BeginInit();
            this.SuspendLayout();
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caption.Location = new System.Drawing.Point(317, 32);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(222, 31);
            this.caption.TabIndex = 0;
            this.caption.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePasswordBtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.Location = new System.Drawing.Point(358, 303);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(130, 39);
            this.changePasswordBtn.TabIndex = 7;
            this.changePasswordBtn.Text = "Đổi mật khẩu";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // eyeOldPass
            // 
            this.eyeOldPass.BackColor = System.Drawing.Color.White;
            this.eyeOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyeOldPass.Image = global::BaiTapLon_CSharp.Properties.Resources.hideEye;
            this.eyeOldPass.Location = new System.Drawing.Point(631, 88);
            this.eyeOldPass.Name = "eyeOldPass";
            this.eyeOldPass.Size = new System.Drawing.Size(29, 27);
            this.eyeOldPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeOldPass.TabIndex = 9;
            this.eyeOldPass.TabStop = false;
            // 
            // oldPasswordTxt
            // 
            this.oldPasswordTxt.CausesValidation = false;
            this.oldPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordTxt.Location = new System.Drawing.Point(358, 88);
            this.oldPasswordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.oldPasswordTxt.Multiline = true;
            this.oldPasswordTxt.Name = "oldPasswordTxt";
            this.oldPasswordTxt.PasswordChar = '*';
            this.oldPasswordTxt.Size = new System.Drawing.Size(302, 27);
            this.oldPasswordTxt.TabIndex = 8;
            // 
            // eyeNewPass
            // 
            this.eyeNewPass.BackColor = System.Drawing.Color.White;
            this.eyeNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyeNewPass.Image = global::BaiTapLon_CSharp.Properties.Resources.hideEye;
            this.eyeNewPass.Location = new System.Drawing.Point(631, 152);
            this.eyeNewPass.Name = "eyeNewPass";
            this.eyeNewPass.Size = new System.Drawing.Size(29, 27);
            this.eyeNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeNewPass.TabIndex = 11;
            this.eyeNewPass.TabStop = false;
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.CausesValidation = false;
            this.newPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTxt.Location = new System.Drawing.Point(358, 152);
            this.newPasswordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.newPasswordTxt.Multiline = true;
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.PasswordChar = '*';
            this.newPasswordTxt.Size = new System.Drawing.Size(302, 27);
            this.newPasswordTxt.TabIndex = 10;
            // 
            // eyeConfirmPass
            // 
            this.eyeConfirmPass.BackColor = System.Drawing.Color.White;
            this.eyeConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyeConfirmPass.Image = global::BaiTapLon_CSharp.Properties.Resources.hideEye;
            this.eyeConfirmPass.Location = new System.Drawing.Point(631, 216);
            this.eyeConfirmPass.Name = "eyeConfirmPass";
            this.eyeConfirmPass.Size = new System.Drawing.Size(29, 27);
            this.eyeConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeConfirmPass.TabIndex = 13;
            this.eyeConfirmPass.TabStop = false;
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.CausesValidation = false;
            this.confirmPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTxt.Location = new System.Drawing.Point(358, 216);
            this.confirmPasswordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPasswordTxt.Multiline = true;
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.PasswordChar = '*';
            this.confirmPasswordTxt.Size = new System.Drawing.Size(302, 27);
            this.confirmPasswordTxt.TabIndex = 12;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(856, 400);
            this.Controls.Add(this.eyeConfirmPass);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.eyeNewPass);
            this.Controls.Add(this.newPasswordTxt);
            this.Controls.Add(this.eyeOldPass);
            this.Controls.Add(this.oldPasswordTxt);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caption);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.eyeOldPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeConfirmPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.PictureBox eyeOldPass;
        private System.Windows.Forms.TextBox oldPasswordTxt;
        private System.Windows.Forms.PictureBox eyeNewPass;
        private System.Windows.Forms.TextBox newPasswordTxt;
        private System.Windows.Forms.PictureBox eyeConfirmPass;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
    }
}