using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BaiTapLon_CSharp.src.Forms.MainForm.Manager
{
    public partial class ManagerClass : Form
    {
        FormController ctl = new FormController();
        Services svs = new Services();
        public ManagerClass()
        {
            InitializeComponent();
        }

        private const bool V = true;
        private static ConnectDB database = new ConnectDB();
        private string connectString = database.getConnectionString();
        private void load_gvrlophoc()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                string query = "SELECT * from lop";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable tb = new DataTable();
                    da.SelectCommand = command;
                    da.Fill(tb);
                    grvLop.DataSource = tb;
                    grvLop.Refresh();
                }
            }
        }
        private void load_cbMaNganh()
        {
            ctl.load_ComboBox(cbMaNganh, "Nganh", "maNganh", "tenNganh");
            /* using (SqlConnection connection = new SqlConnection(connectString))
             {
                 connection.Open();
                 string query = "SELECT * from lop";
                 using (SqlCommand command = new SqlCommand(query, connection))
                 {
                     SqlDataAdapter da = new SqlDataAdapter();
                     DataTable tb = new DataTable();
                     da.SelectCommand = command;
                     da.Fill(tb);
                     DataRow r = tb.NewRow();
                     r["tenNganh"] = "";
                     r["maNganh"] = "*  Mã Ngành *";
                     tb.Rows.InsertAt(r, 0);
                     cbMaNganh.DataSource = tb;
                     cbMaNganh.DisplayMember = "maNganh";
                     cbMaNganh.ValueMember = "maNganh";
                     cbMaNganh.Refresh();
                 }
             }*/
        }
        PrivateFontCollection pfc;
        private void ManagerClass_Load(object sender, EventArgs e)
        {
            load_gvrlophoc();
            load_cbMaNganh();
            txtMalop.Text = "";
            txtTenLop.Text = "";
            txtKhoa.Text = "";
            txtGVCN.Text = "";
            grvLop.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = true;
            txtGVCN.Enabled = true; txtKhoa.Enabled = true; txtMalop.Enabled = true;
            txtTenLop.Enabled = true; txtTenNganh.Enabled = false;
            pfc = new PrivateFontCollection();
            pfc.AddFontFile("UVF_SlimTony.ttf");
            label7777.Font = new Font(pfc.Families[0], 23);

        }
        private void checktrungmalop(String p_malop, ref int p_kq)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                string query = "Check_trunglop";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@malop", SqlDbType.NVarChar, 50).Value = p_malop;
                    SqlParameter kq = new SqlParameter("@ketqua", SqlDbType.Int);
                    command.Parameters.Add(kq).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    p_kq = (int)kq.Value;
                }
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                string p_malop = txtMalop.Text.Trim();
                string p_tenlop = txtTenLop.Text.Trim();
                string p_tennganh = txtTenNganh.Text.Trim();
                string p_khoa = txtKhoa.Text.Trim();
                string P_maNganh = cbMaNganh.Text.Trim();
                int number;
                bool isnumber = int.TryParse(p_khoa, out number);
                string p_gvcn = txtGVCN.Text.Trim();
                // kiểm tra mã lớp khôgn được rỗng
                if (p_malop == "")
                {
                    txtMalop.Focus();
                    MessageBox.Show("Hãy Nhập Mã Lớp ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (p_tenlop == "")
                {
                    txtMalop.Focus();
                    MessageBox.Show("Hãy Nhập Tên Lớp ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (p_tennganh == "")
                {
                    txtMalop.Focus();
                    MessageBox.Show("Hãy Nhập Tên Ngành ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (isnumber)
                {
                }
                else
                {
                    txtMalop.Focus();
                    MessageBox.Show("Khoá Là Int Không Phải String ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (p_khoa == "")
                {
                    txtMalop.Focus();
                    MessageBox.Show("Hãy Nhập Khoá ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (p_khoa.GetType() == typeof(int))
                {
                    txtMalop.Focus();
                    MessageBox.Show("Khoá Là Int Không Phải String ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (p_gvcn == "")
                {
                    txtMalop.Focus();
                    MessageBox.Show("Hãy Nhập Tên GVCN ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                //kiểm tra trùng mã lớp
                int kq = 0;
                checktrungmalop(p_malop, ref kq);
                if (kq == 1)
                {
                    txtMalop.Focus();
                    MessageBox.Show("trùng mã lớp");
                    return;
                }
                string query = "Insert into Lop Values('" + p_malop + "', N'" + p_tenlop + "', N'" + P_maNganh + "',N'" + p_tennganh + "',N'" + p_khoa + "',N'" + p_gvcn + "')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    load_gvrlophoc();
                }
            }
        }

        private void grvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;// lấy chỉ số dòng đc click chuột vào
            txtMalop.Text = grvLop.Rows[i].Cells[0].Value.ToString();
            txtTenLop.Text = grvLop.Rows[i].Cells[1].Value.ToString();
            cbMaNganh.Text = grvLop.Rows[i].Cells[2].Value.ToString();
            txtTenNganh.Text = grvLop.Rows[i].Cells[3].Value.ToString();
            txtKhoa.Text = grvLop.Rows[i].Cells[4].Value.ToString();
            txtGVCN.Text = grvLop.Rows[i].Cells[5].Value.ToString(); 
            btSua.Enabled = true;
            btXoa.Enabled = true;
            txtKhoa.Enabled = true; txtMalop.Enabled = false; txtTenLop.Enabled = true;
            txtGVCN.Enabled = true; cbMaNganh.Enabled = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            String tb = "Bạn muốn thoát ??";
            DialogResult check = MessageBox.Show(tb, "Thông báo :D", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                ManagerClass_Load(sender, e);
            }
            else
            {
                //Khong lam j cả :D
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                string p_malop = txtMalop.Text.Trim();
                string p_tenlop = txtTenLop.Text.Trim();
                string p_tennganh = txtTenNganh.Text.Trim();
                string p_khoa = txtKhoa.Text.Trim();
                string P_maNganh = cbMaNganh.Text.Trim();
                int number;
                bool isnumber = int.TryParse(p_khoa, out number);
                string p_gvcn = txtGVCN.Text.Trim();
                // kiểm tra mã lớp khôgn được rỗng
                if (p_tenlop == "")
                {
                    txtMalop.Focus();
                    MessageBox.Show("Hãy Nhập Tên Lớp ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (p_tennganh == "")
                {
                    txtMalop.Focus();
                    MessageBox.Show("Hãy Nhập Tên Ngành ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (isnumber)
                {
                }
                else
                {
                    txtMalop.Focus();
                    MessageBox.Show("Khoá Là Int Không Phải String ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (p_khoa == "")
                {
                    txtMalop.Focus();
                    MessageBox.Show("Hãy Nhập Khoá ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (p_khoa.GetType() == typeof(int))
                {
                    txtMalop.Focus();
                    MessageBox.Show("Khoá Là Int Không Phải String ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                if (p_gvcn == "")
                {
                    txtMalop.Focus();
                    MessageBox.Show("Hãy Nhập Tên GVCN ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                string query = "update Lop Set tenLop=N'" + p_tenlop + "', maNganh='" + P_maNganh+
                    "',tenNganh=N'" + p_tennganh + "',khoa='" + p_khoa + "',gvChuNhiem=N'"
                    + p_gvcn + "'where maLop='" + p_malop + "'";
                String thongbao = "Bạn chắc chắn chứ ??";
                DialogResult check = MessageBox.Show(thongbao, "Thông báo :D", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        load_gvrlophoc();
                    }
                }
                else
                {
                    //Khong lam j cả :D
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                string p_malop = txtMalop.Text.Trim();
                string query = "delete from lop where maLop='" + p_malop + "'";
                String thongbao = "Bạn chắc chắn chứ muốn xoá " + p_malop + "chứ ?";
                DialogResult check = MessageBox.Show(thongbao, "Thông báo :D", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    txtMalop.Text = "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        txtMalop.Text = "";
                        txtTenLop.Text = "";
                        txtTenNganh.Text = "";
                        txtKhoa.Text = "";
                        txtGVCN.Text = "";
                        command.ExecuteNonQuery();
                        load_gvrlophoc();
                    }
                }
                else
                {
                    //Khong lam j cả :D
                }
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                string p_timkiem = txtTimKiem.Text.Trim();
                if (p_timkiem == "Nhâp Mã lớp cần tìm")
                {
                    txtTimKiem.Focus();
                    load_gvrlophoc();
                    MessageBox.Show("Bạn bị đần à không nhập gì sao tìm kiếm ╰（‵□′）╯", "          ⇨ Thông Báo ⇦");
                    return;
                }
                string query = "select * from Lop where maLop lIKE '%" + p_timkiem + "%'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.SelectCommand = command;
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    grvLop.DataSource = tb;
                    grvLop.Refresh();
                }
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            string p_timkiem = txtTimKiem.Text.Trim();
            if (p_timkiem == "Nhâp Mã lớp cần tìm")
            {
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            string p_timkiem = txtTimKiem.Text.Trim();
            if (p_timkiem == "")
            {
                txtTimKiem.ForeColor = Color.Silver;
                txtTimKiem.Text = "Nhâp Mã lớp cần tìm";
            }
        }

        private void cbMaNganh_TextChanged(object sender, EventArgs e)
        {
            string manganh = cbMaNganh.Text.Trim();

            DataTable data = svs.find("Nganh", "tenNganh", "maNganh", manganh);

            if (data != null && data.Rows.Count > 0)
            {
                txtTenNganh.Text = data.Rows[0][0].ToString();
            }
        }
    }
}
