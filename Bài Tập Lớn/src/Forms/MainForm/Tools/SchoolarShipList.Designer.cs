namespace BaiTapLon_CSharp.src.Forms.MainForm.Tools
{
    partial class SchoolarShipList
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
            this.displaySchoolarShipListDgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bxuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displaySchoolarShipListDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displaySchoolarShipListDgv
            // 
            this.displaySchoolarShipListDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaySchoolarShipListDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displaySchoolarShipListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displaySchoolarShipListDgv.Location = new System.Drawing.Point(0, 271);
            this.displaySchoolarShipListDgv.Margin = new System.Windows.Forms.Padding(4);
            this.displaySchoolarShipListDgv.Name = "displaySchoolarShipListDgv";
            this.displaySchoolarShipListDgv.RowHeadersWidth = 51;
            this.displaySchoolarShipListDgv.Size = new System.Drawing.Size(1067, 283);
            this.displaySchoolarShipListDgv.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH HỌC BỔNG";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bxuat);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(636, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bxuat
            // 
            this.bxuat.Location = new System.Drawing.Point(48, 90);
            this.bxuat.Margin = new System.Windows.Forms.Padding(4);
            this.bxuat.Name = "bxuat";
            this.bxuat.Size = new System.Drawing.Size(100, 28);
            this.bxuat.TabIndex = 4;
            this.bxuat.Text = "Xuất excel";
            this.bxuat.UseVisualStyleBackColor = true;
            this.bxuat.Click += new System.EventHandler(this.bxuat_Click);
            // 
            // SchoolarShipList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displaySchoolarShipListDgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SchoolarShipList";
            this.Text = "SchoolarShipList";
            ((System.ComponentModel.ISupportInitialize)(this.displaySchoolarShipListDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView displaySchoolarShipListDgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bxuat;
    }
}