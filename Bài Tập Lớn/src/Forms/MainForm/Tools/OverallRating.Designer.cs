namespace BaiTapLon_CSharp.src.Forms.MainForm.Tools
{
    partial class OverallRating
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
            this.cbhocki = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noteMsvLabel = new System.Windows.Forms.Label();
            this.cbbMasv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.displayReviewsDgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayReviewsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbhocki
            // 
            this.cbhocki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbhocki.Location = new System.Drawing.Point(433, 31);
            this.cbhocki.Margin = new System.Windows.Forms.Padding(2);
            this.cbhocki.Name = "cbhocki";
            this.cbhocki.Size = new System.Drawing.Size(82, 21);
            this.cbhocki.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(364, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Học kì:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "ĐÁNH GIÁ THÀNH TÍCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.reviewsBtn);
            this.groupBox1.Controls.Add(this.noteMsvLabel);
            this.groupBox1.Controls.Add(this.cbhocki);
            this.groupBox1.Controls.Add(this.cbbMasv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(312, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 129);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // noteMsvLabel
            // 
            this.noteMsvLabel.AutoSize = true;
            this.noteMsvLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.noteMsvLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.noteMsvLabel.Location = new System.Drawing.Point(103, 58);
            this.noteMsvLabel.Name = "noteMsvLabel";
            this.noteMsvLabel.Size = new System.Drawing.Size(129, 15);
            this.noteMsvLabel.TabIndex = 37;
            this.noteMsvLabel.Text = "* Vui lòng chọn lớp trước";
            // 
            // cbbMasv
            // 
            this.cbbMasv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMasv.Enabled = false;
            this.cbbMasv.FormattingEnabled = true;
            this.cbbMasv.Location = new System.Drawing.Point(106, 31);
            this.cbbMasv.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMasv.Name = "cbbMasv";
            this.cbbMasv.Size = new System.Drawing.Size(176, 21);
            this.cbbMasv.TabIndex = 36;
            this.cbbMasv.TextChanged += new System.EventHandler(this.cbbMasv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(52, 120);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(176, 21);
            this.cbbLop.TabIndex = 34;
            this.cbbLop.TextChanged += new System.EventHandler(this.cbbLop_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(11, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Lớp:";
            // 
            // displayReviewsDgv
            // 
            this.displayReviewsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayReviewsDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayReviewsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayReviewsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.maSinhVien,
            this.diemTK,
            this.diemChu,
            this.danhGia,
            this.hocKy});
            this.displayReviewsDgv.Location = new System.Drawing.Point(0, 193);
            this.displayReviewsDgv.Name = "displayReviewsDgv";
            this.displayReviewsDgv.RowHeadersWidth = 51;
            this.displayReviewsDgv.Size = new System.Drawing.Size(856, 208);
            this.displayReviewsDgv.TabIndex = 35;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // maSinhVien
            // 
            this.maSinhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maSinhVien.DataPropertyName = "maSinhVien";
            this.maSinhVien.HeaderText = "Mã sinh viên";
            this.maSinhVien.Name = "maSinhVien";
            // 
            // diemTK
            // 
            this.diemTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.diemTK.DataPropertyName = "diemTK";
            this.diemTK.HeaderText = "Điểm tổng kết";
            this.diemTK.Name = "diemTK";
            this.diemTK.Width = 98;
            // 
            // diemChu
            // 
            this.diemChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.diemChu.DataPropertyName = "diemChu";
            this.diemChu.HeaderText = "Điểm chữ";
            this.diemChu.Name = "diemChu";
            this.diemChu.Width = 77;
            // 
            // danhGia
            // 
            this.danhGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.danhGia.DataPropertyName = "danhGia";
            this.danhGia.HeaderText = "Đánh giá";
            this.danhGia.Name = "danhGia";
            this.danhGia.Width = 75;
            // 
            // hocKy
            // 
            this.hocKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hocKy.DataPropertyName = "hocKy";
            this.hocKy.HeaderText = "Học kỳ";
            this.hocKy.Name = "hocKy";
            this.hocKy.Width = 66;
            // 
            // reviewsBtn
            // 
            this.reviewsBtn.Location = new System.Drawing.Point(387, 83);
            this.reviewsBtn.Name = "reviewsBtn";
            this.reviewsBtn.Size = new System.Drawing.Size(89, 33);
            this.reviewsBtn.TabIndex = 38;
            this.reviewsBtn.Text = "Xét thành tích";
            this.reviewsBtn.UseVisualStyleBackColor = true;
            this.reviewsBtn.Click += new System.EventHandler(this.reviewsBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Họ Tên:";
            // 
            // txthoten
            // 
            this.txthoten.Enabled = false;
            this.txthoten.Location = new System.Drawing.Point(106, 90);
            this.txthoten.Margin = new System.Windows.Forms.Padding(2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(176, 20);
            this.txthoten.TabIndex = 39;
            // 
            // OverallRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(856, 401);
            this.Controls.Add(this.displayReviewsDgv);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "OverallRating";
            this.Text = "OverallRating";
            this.Load += new System.EventHandler(this.OverallRating_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayReviewsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbhocki;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label noteMsvLabel;
        private System.Windows.Forms.ComboBox cbbMasv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView displayReviewsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKy;
        private System.Windows.Forms.Button reviewsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthoten;
    }
}