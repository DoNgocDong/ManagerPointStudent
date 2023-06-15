using BaiTapLon_CSharp.src.Database;
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
        private static ConnectDB database = new ConnectDB();
        private string stringConnetion = database.getConnectionString();
        public Sua()
        {
            InitializeComponent();
        }
        private void load_DGV()
        {
            using (SqlConnection connection = new SqlConnection(stringConnetion))
            {
                connection.Open();

                string query = "select * from MonHoc";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    DGV.DataSource = tb;
                    DGV.Refresh();
                }
            }
        }
        private void Sua_Load(object sender, EventArgs e)
        {
            load_DGV();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mm = txtmamon.Text.Trim();
            if (mm == "")
            {
                MessageBox.Show("Chọn Môn cần sửa!");
                return;
            }

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
            string hocki = cbhocki.Text.ToString();

            using (SqlConnection connection = new SqlConnection(stringConnetion))
            {
                connection.Open();

                string query = "update MonHoc set maMon='" + mmmoi + "', tenMon=N'" + tmmoi + "', soTinChi=" + stcmoi + ", hocKi=" + hocki + " where maMon='" + mm + "'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!");
                    this.Close();
                }
            }
        }

        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex; //lấy chỉ số dòng dc click
                txtmamon.Text = DGV.Rows[i].Cells[0].Value.ToString();
                txttenmon.Text = DGV.Rows[i].Cells[1].Value.ToString();
                txtsotinchi.Text = DGV.Rows[i].Cells[2].Value.ToString();
                txthocki.Text = DGV.Rows[i].Cells[3].Value.ToString();

                txtmmmoi.Text = txtmamon.Text;
                txttmmoi.Text = txttenmon.Text;
                txtstcmoi.Text = txtsotinchi.Text;
                cbhocki.Text = txthocki.Text;
            }
            catch(Exception ex) {}
        }
    }
}
