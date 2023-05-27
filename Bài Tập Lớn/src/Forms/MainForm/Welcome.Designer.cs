namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    partial class Welcome
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
            this.backGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).BeginInit();
            this.SuspendLayout();
            // 
            // backGround
            // 
            this.backGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backGround.Image = global::BaiTapLon_CSharp.Properties.Resources.welcome2;
            this.backGround.Location = new System.Drawing.Point(0, 0);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(856, 401);
            this.backGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backGround.TabIndex = 2;
            this.backGround.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(856, 401);
            this.Controls.Add(this.backGround);
            this.Name = "Welcome";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backGround;
    }
}