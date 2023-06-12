namespace BaiTapLon_CSharp.src.Forms.MainForm.Tools
{
    partial class Exambanlist
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.bxuat = new System.Windows.Forms.Button();
            this.btk = new System.Windows.Forms.Button();
            this.txttiemkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7777 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv1.Location = new System.Drawing.Point(0, 347);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1145, 148);
            this.dgv1.TabIndex = 0;
            // 
            // bxuat
            // 
            this.bxuat.Location = new System.Drawing.Point(15, 111);
            this.bxuat.Name = "bxuat";
            this.bxuat.Size = new System.Drawing.Size(77, 32);
            this.bxuat.TabIndex = 1;
            this.bxuat.Text = "Xuất Excel";
            this.bxuat.UseVisualStyleBackColor = true;
            this.bxuat.Click += new System.EventHandler(this.bxuat_Click);
            // 
            // btk
            // 
            this.btk.Location = new System.Drawing.Point(15, 48);
            this.btk.Name = "btk";
            this.btk.Size = new System.Drawing.Size(77, 32);
            this.btk.TabIndex = 2;
            this.btk.Text = "Tìm kiếm";
            this.btk.UseVisualStyleBackColor = true;
            this.btk.Click += new System.EventHandler(this.button2_Click);
            // 
            // txttiemkiem
            // 
            this.txttiemkiem.Location = new System.Drawing.Point(135, 48);
            this.txttiemkiem.Multiline = true;
            this.txttiemkiem.Name = "txttiemkiem";
            this.txttiemkiem.Size = new System.Drawing.Size(212, 32);
            this.txttiemkiem.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttiemkiem);
            this.groupBox1.Controls.Add(this.btk);
            this.groupBox1.Controls.Add(this.bxuat);
            this.groupBox1.Location = new System.Drawing.Point(25, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 199);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label7777
            // 
            this.label7777.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7777.AutoEllipsis = true;
            this.label7777.AutoSize = true;
            this.label7777.BackColor = System.Drawing.Color.Transparent;
            this.label7777.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7777.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7777.ForeColor = System.Drawing.Color.Coral;
            this.label7777.Location = new System.Drawing.Point(387, 24);
            this.label7777.Name = "label7777";
            this.label7777.Size = new System.Drawing.Size(350, 44);
            this.label7777.TabIndex = 13;
            this.label7777.Text = "Danh sách cấm thi";
            this.label7777.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exambanlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1145, 495);
            this.Controls.Add(this.label7777);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv1);
            this.Name = "Exambanlist";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button bxuat;
        private System.Windows.Forms.Button btk;
        private System.Windows.Forms.TextBox txttiemkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7777;
    }
}