namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    partial class ManagerStudent
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
            this.dgvDisplayStudents = new System.Windows.Forms.DataGridView();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.keywordTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedStudentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayStudents
            // 
            this.dgvDisplayStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien,
            this.hoTen,
            this.tenLop,
            this.khoa,
            this.tenNganh,
            this.ngaySinh,
            this.gioiTinh,
            this.diaChi,
            this.sdt,
            this.cccd,
            this.email});
            this.dgvDisplayStudents.Location = new System.Drawing.Point(0, 216);
            this.dgvDisplayStudents.Name = "dgvDisplayStudents";
            this.dgvDisplayStudents.Size = new System.Drawing.Size(854, 285);
            this.dgvDisplayStudents.TabIndex = 0;
            this.dgvDisplayStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayStudents_CellClick);
            // 
            // maSinhVien
            // 
            this.maSinhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maSinhVien.DataPropertyName = "maSinhVien";
            this.maSinhVien.HeaderText = "Mã sinh viên";
            this.maSinhVien.Name = "maSinhVien";
            this.maSinhVien.Width = 92;
            // 
            // hoTen
            // 
            this.hoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.Name = "hoTen";
            // 
            // tenLop
            // 
            this.tenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tenLop.DataPropertyName = "tenLop";
            this.tenLop.HeaderText = "Tên Lớp";
            this.tenLop.Name = "tenLop";
            this.tenLop.Width = 72;
            // 
            // khoa
            // 
            this.khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.khoa.DataPropertyName = "khoa";
            this.khoa.HeaderText = "Khóa";
            this.khoa.Name = "khoa";
            this.khoa.Width = 57;
            // 
            // tenNganh
            // 
            this.tenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNganh.DataPropertyName = "tenNganh";
            this.tenNganh.HeaderText = "Chuyên ngành";
            this.tenNganh.Name = "tenNganh";
            // 
            // ngaySinh
            // 
            this.ngaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 79;
            // 
            // gioiTinh
            // 
            this.gioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 67;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 48;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.Width = 54;
            // 
            // cccd
            // 
            this.cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cccd.DataPropertyName = "cccd";
            this.cccd.HeaderText = "CCCD";
            this.cccd.Name = "cccd";
            this.cccd.Width = 61;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // keywordTxt
            // 
            this.keywordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keywordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordTxt.Location = new System.Drawing.Point(543, 29);
            this.keywordTxt.Name = "keywordTxt";
            this.keywordTxt.Size = new System.Drawing.Size(176, 24);
            this.keywordTxt.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.Aqua;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(742, 29);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 24);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.Aqua;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(543, 177);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.BackColor = System.Drawing.Color.Aqua;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(644, 177);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.Aqua;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(742, 177);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Aqua;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(12, 177);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(68, 23);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Tải lại";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(540, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "* Lọc theo mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sĩnh viên đang chọn:";
            // 
            // selectedStudentLabel
            // 
            this.selectedStudentLabel.AutoSize = true;
            this.selectedStudentLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStudentLabel.Location = new System.Drawing.Point(272, 181);
            this.selectedStudentLabel.Name = "selectedStudentLabel";
            this.selectedStudentLabel.Size = new System.Drawing.Size(50, 19);
            this.selectedStudentLabel.TabIndex = 10;
            this.selectedStudentLabel.Text = "Không";
            // 
            // ManagerStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(854, 501);
            this.Controls.Add(this.selectedStudentLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.keywordTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDisplayStudents);
            this.Name = "ManagerStudent";
            this.Text = "ManagerStudent";
            this.Load += new System.EventHandler(this.ManagerStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keywordTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedStudentLabel;
    }
}