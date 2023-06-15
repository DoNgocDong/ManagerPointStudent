namespace BaiTapLon_CSharp.src.Forms.SubFormMonHoc
{
    partial class Sua
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.txtsotinchi = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttmmoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstcmoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmmmoi = new System.Windows.Forms.TextBox();
            this.maMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txthocki = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbhocki = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sửa Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên môn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tín chỉ:";
            // 
            // txtmamon
            // 
            this.txtmamon.Enabled = false;
            this.txtmamon.Location = new System.Drawing.Point(158, 31);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(317, 26);
            this.txtmamon.TabIndex = 4;
            // 
            // txttenmon
            // 
            this.txttenmon.Enabled = false;
            this.txttenmon.Location = new System.Drawing.Point(158, 63);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(317, 26);
            this.txttenmon.TabIndex = 5;
            // 
            // txtsotinchi
            // 
            this.txtsotinchi.Enabled = false;
            this.txtsotinchi.Location = new System.Drawing.Point(158, 95);
            this.txtsotinchi.Name = "txtsotinchi";
            this.txtsotinchi.Size = new System.Drawing.Size(317, 26);
            this.txtsotinchi.TabIndex = 6;
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(137, 408);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(267, 66);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMon,
            this.tenMon,
            this.soTinChi,
            this.hocKi});
            this.DGV.Location = new System.Drawing.Point(548, 77);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(581, 397);
            this.DGV.TabIndex = 8;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txthocki);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttenmon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsotinchi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmamon);
            this.groupBox1.Location = new System.Drawing.Point(29, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 168);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cũ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbhocki);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txttmmoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtstcmoi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtmmmoi);
            this.groupBox2.Location = new System.Drawing.Point(29, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 168);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mới";
            // 
            // txttmmoi
            // 
            this.txttmmoi.Location = new System.Drawing.Point(158, 64);
            this.txttmmoi.Name = "txttmmoi";
            this.txttmmoi.Size = new System.Drawing.Size(317, 26);
            this.txttmmoi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã môn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên môn:";
            // 
            // txtstcmoi
            // 
            this.txtstcmoi.Location = new System.Drawing.Point(158, 97);
            this.txtstcmoi.Name = "txtstcmoi";
            this.txtstcmoi.Size = new System.Drawing.Size(317, 26);
            this.txtstcmoi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số tín chỉ:";
            // 
            // txtmmmoi
            // 
            this.txtmmmoi.Location = new System.Drawing.Point(158, 31);
            this.txtmmmoi.Name = "txtmmmoi";
            this.txtmmmoi.Size = new System.Drawing.Size(317, 26);
            this.txtmmmoi.TabIndex = 4;
            // 
            // maMon
            // 
            this.maMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maMon.DataPropertyName = "maMon";
            this.maMon.HeaderText = "Mã Môn";
            this.maMon.MinimumWidth = 8;
            this.maMon.Name = "maMon";
            // 
            // tenMon
            // 
            this.tenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenMon.DataPropertyName = "tenMon";
            this.tenMon.HeaderText = "Tên Môn";
            this.tenMon.MinimumWidth = 8;
            this.tenMon.Name = "tenMon";
            // 
            // soTinChi
            // 
            this.soTinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soTinChi.DataPropertyName = "soTinChi";
            this.soTinChi.HeaderText = "Số tín chỉ";
            this.soTinChi.MinimumWidth = 8;
            this.soTinChi.Name = "soTinChi";
            // 
            // hocKi
            // 
            this.hocKi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hocKi.DataPropertyName = "hocKi";
            this.hocKi.HeaderText = "Học kì";
            this.hocKi.MinimumWidth = 8;
            this.hocKi.Name = "hocKi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Học kì:";
            // 
            // txthocki
            // 
            this.txthocki.Enabled = false;
            this.txthocki.Location = new System.Drawing.Point(158, 127);
            this.txthocki.Name = "txthocki";
            this.txthocki.Size = new System.Drawing.Size(317, 26);
            this.txthocki.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Học kì:";
            // 
            // cbhocki
            // 
            this.cbhocki.FormattingEnabled = true;
            this.cbhocki.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbhocki.Location = new System.Drawing.Point(158, 130);
            this.cbhocki.Name = "cbhocki";
            this.cbhocki.Size = new System.Drawing.Size(121, 28);
            this.cbhocki.TabIndex = 10;
            // 
            // Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label1);
            this.Name = "Sua";
            this.Text = "Sua";
            this.Load += new System.EventHandler(this.Sua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.TextBox txtsotinchi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttmmoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstcmoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmmmoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKi;
        private System.Windows.Forms.TextBox txthocki;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbhocki;
        private System.Windows.Forms.Label label9;
    }
}