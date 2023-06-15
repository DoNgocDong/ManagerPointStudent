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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterTxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.displaySchoolarShipListDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.maSinhVien,
            this.diemTK,
            this.diemChu,
            this.danhGia,
            this.hocKy});
            this.displaySchoolarShipListDgv.Location = new System.Drawing.Point(0, 220);
            this.displaySchoolarShipListDgv.Name = "displaySchoolarShipListDgv";
            this.displaySchoolarShipListDgv.RowHeadersWidth = 51;
            this.displaySchoolarShipListDgv.Size = new System.Drawing.Size(800, 230);
            this.displaySchoolarShipListDgv.TabIndex = 0;
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
            // filterTxt
            // 
            this.filterTxt.Location = new System.Drawing.Point(31, 30);
            this.filterTxt.Name = "filterTxt";
            this.filterTxt.Size = new System.Drawing.Size(61, 31);
            this.filterTxt.TabIndex = 1;
            this.filterTxt.Text = "Lọc";
            this.filterTxt.UseVisualStyleBackColor = true;
            this.filterTxt.Click += new System.EventHandler(this.filterTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH HỌC BỔNG";
            // 
            // sizeTxt
            // 
            this.sizeTxt.Location = new System.Drawing.Point(114, 36);
            this.sizeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.sizeTxt.Name = "sizeTxt";
            this.sizeTxt.Size = new System.Drawing.Size(128, 20);
            this.sizeTxt.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bxuat);
            this.groupBox1.Controls.Add(this.sizeTxt);
            this.groupBox1.Controls.Add(this.filterTxt);
            this.groupBox1.Location = new System.Drawing.Point(11, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(370, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý học bổng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(111, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Nhập số lượng học bổng";
            // 
            // bxuat
            // 
            this.bxuat.Location = new System.Drawing.Point(279, 30);
            this.bxuat.Name = "bxuat";
            this.bxuat.Size = new System.Drawing.Size(75, 31);
            this.bxuat.TabIndex = 4;
            this.bxuat.Text = "Xuất excel";
            this.bxuat.UseVisualStyleBackColor = true;
            this.bxuat.Click += new System.EventHandler(this.bxuat_Click);
            // 
            // SchoolarShipList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displaySchoolarShipListDgv);
            this.Name = "SchoolarShipList";
            this.Text = "danh sách học bổng";
            ((System.ComponentModel.ISupportInitialize)(this.displaySchoolarShipListDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView displaySchoolarShipListDgv;
        private System.Windows.Forms.Button filterTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bxuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKy;
    }
}