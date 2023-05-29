using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.SubFormMonHoc
{
    public partial class Sua : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NJVE0UN\\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True");

        public Sua()
        {
            InitializeComponent();
        }
        private void load_DGV()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from MonHoc", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            DGV.DataSource = tb;
            DGV.Refresh();
        }
        private void Sua_Load(object sender, EventArgs e)
        {
            load_DGV();
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
            private void btnsua_Click(object sender, EventArgs e)
        {
            string mm = txtmamon.Text.Trim();

            string mmmoi = txtmmmoi.Text.Trim();
            if (mmmoi == "")
            {
                txtmmmoi.Focus();
                MessageBox.Show("Phải nhập mã môn!");
                return;
            }
            string tmmoi = txttmmoi.Text.Trim();
            if (tmmoi == "")
            {
                txttmmoi.Focus();
                MessageBox.Show("Phải nhập tên môn!");
                return;
            }
            string stcmoi = txtstcmoi.Text.Trim();
            if (stcmoi == "")
            {
                txtstcmoi.Focus();
                MessageBox.Show("Phải nhập số tín chỉ!");
                return;
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string query = "update MonHoc set maMon='" + mmmoi + "',tenMon='" + tmmoi + "',soTinChi=" + stcmoi + " where maMon='" + mm+"'";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa thành công!");

        }

        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; //lấy chỉ số dòng dc click
            txtmamon.Text = DGV.Rows[i].Cells[0].Value.ToString();
            txttenmon.Text = DGV.Rows[i].Cells[1].Value.ToString();
            txtsotinchi.Text = DGV.Rows[i].Cells[2].Value.ToString();
        }
    }
}
