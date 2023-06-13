namespace BaiTapLon_CSharp.src.Forms.MainForm.Manager
{
    partial class ManagerClass
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
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGVCN = new System.Windows.Forms.TextBox();
            this.label7777 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grvLop = new System.Windows.Forms.DataGridView();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaNganh = new System.Windows.Forms.ComboBox();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvChuNhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(140, 49);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(136, 22);
            this.txtMalop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khoá Học:";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(140, 129);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(136, 22);
            this.txtKhoa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(392, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên Lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(487, 52);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(386, 22);
            this.txtTenLop.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(371, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên Ngành:";
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(487, 90);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(386, 22);
            this.txtTenNganh.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(331, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "GV Chủ Nghiệm:";
            // 
            // txtGVCN
            // 
            this.txtGVCN.Location = new System.Drawing.Point(487, 129);
            this.txtGVCN.Name = "txtGVCN";
            this.txtGVCN.Size = new System.Drawing.Size(386, 22);
            this.txtGVCN.TabIndex = 10;
            // 
            // label7777
            // 
            this.label7777.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7777.AutoEllipsis = true;
            this.label7777.AutoSize = true;
            this.label7777.BackColor = System.Drawing.Color.Transparent;
            this.label7777.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7777.Font = new System.Drawing.Font("UVF Slim Tony", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7777.ForeColor = System.Drawing.Color.Coral;
            this.label7777.Location = new System.Drawing.Point(947, 13);
            this.label7777.Name = "label7777";
            this.label7777.Size = new System.Drawing.Size(151, 267);
            this.label7777.TabIndex = 12;
            this.label7777.Text = "Quản \r\nLý \r\nLớp";
            this.label7777.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(158, 182);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(365, 30);
            this.txtTimKiem.TabIndex = 14;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // grvLop
            // 
            this.grvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvLop.BackgroundColor = System.Drawing.Color.Silver;
            this.grvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLop,
            this.tenLop,
            this.maNganh,
            this.tenNganh,
            this.khoa,
            this.gvChuNhiem});
            this.grvLop.Location = new System.Drawing.Point(12, 218);
            this.grvLop.Name = "grvLop";
            this.grvLop.RowHeadersWidth = 51;
            this.grvLop.RowTemplate.Height = 24;
            this.grvLop.Size = new System.Drawing.Size(861, 265);
            this.grvLop.TabIndex = 15;
            this.grvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvLop_CellClick);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(16, 182);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(121, 30);
            this.btTimKiem.TabIndex = 16;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Location = new System.Drawing.Point(948, 283);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(150, 44);
            this.btThem.TabIndex = 17;
            this.btThem.Text = "[✚] Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Location = new System.Drawing.Point(948, 333);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(150, 44);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "[🛠] Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Location = new System.Drawing.Point(948, 383);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(150, 44);
            this.btXoa.TabIndex = 19;
            this.btXoa.Text = "[♻️] Xoá\r\n";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Location = new System.Drawing.Point(948, 439);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(150, 44);
            this.btThoat.TabIndex = 20;
            this.btThoat.Text = "[↶] Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Ngành:";
            // 
            // cbMaNganh
            // 
            this.cbMaNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNganh.FormattingEnabled = true;
            this.cbMaNganh.Location = new System.Drawing.Point(140, 87);
            this.cbMaNganh.Name = "cbMaNganh";
            this.cbMaNganh.Size = new System.Drawing.Size(136, 24);
            this.cbMaNganh.TabIndex = 23;
            this.cbMaNganh.TextChanged += new System.EventHandler(this.cbMaNganh_TextChanged);
            // 
            // maLop
            // 
            this.maLop.DataPropertyName = "maLop";
            this.maLop.HeaderText = "Mã Lớp";
            this.maLop.MinimumWidth = 6;
            this.maLop.Name = "maLop";
            // 
            // tenLop
            // 
            this.tenLop.DataPropertyName = "tenLop";
            this.tenLop.HeaderText = "Tên Lớp";
            this.tenLop.MinimumWidth = 6;
            this.tenLop.Name = "tenLop";
            // 
            // maNganh
            // 
            this.maNganh.DataPropertyName = "maNganh";
            this.maNganh.HeaderText = "Mã Ngành";
            this.maNganh.MinimumWidth = 6;
            this.maNganh.Name = "maNganh";
            // 
            // tenNganh
            // 
            this.tenNganh.DataPropertyName = "tenNganh";
            this.tenNganh.HeaderText = "Tên Ngành";
            this.tenNganh.MinimumWidth = 6;
            this.tenNganh.Name = "tenNganh";
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "khoa";
            this.khoa.HeaderText = "Khoá";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            // 
            // gvChuNhiem
            // 
            this.gvChuNhiem.DataPropertyName = "gvChuNhiem";
            this.gvChuNhiem.HeaderText = "Giáo Viên Chủ Nhiệm";
            this.gvChuNhiem.MinimumWidth = 6;
            this.gvChuNhiem.Name = "gvChuNhiem";
            // 
            // ManagerClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 495);
            this.Controls.Add(this.cbMaNganh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.grvLop);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7777);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGVCN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenNganh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMalop);
            this.Name = "ManagerClass";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ManagerClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGVCN;
        private System.Windows.Forms.Label label7777;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView grvLop;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvChuNhiem;
    }
}