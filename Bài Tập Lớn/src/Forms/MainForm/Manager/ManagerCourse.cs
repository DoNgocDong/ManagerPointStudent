using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BaiTapLon_CSharp.src.Forms.SubFormMonHoc;
using BaiTapLon_CSharp.src.Forms.SubForm.ManagerCourse;
using BaiTapLon_CSharp.src.Database;

namespace BaiTapLon_CSharp.src.Forms.MainForm.Manager
{
    public partial class ManagerCourse : Form
    {
        private static ConnectDB database = new ConnectDB();
        private string stringConnetion = database.getConnectionString();
        public ManagerCourse()
        {
            InitializeComponent();
        }

        private void load_DGV()
        {
            using(SqlConnection connection = new SqlConnection(stringConnetion))
            {
                connection.Open();

                string query = "select * from MonHoc";
                using(SqlCommand cmd = new SqlCommand(query, connection))
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
        private void ManagerCourse_Load(object sender, EventArgs e)
        {
            load_DGV();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them them = new Them();
            them.ShowDialog();
            load_DGV();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Sua sua = new Sua();
            sua.ShowDialog();
            load_DGV();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Xoa xoa = new Xoa();
            xoa.ShowDialog();
            load_DGV();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tk = txttimkiem.Text.Trim();
            if (tk == "")
            {
                txttimkiem.Focus();
                MessageBox.Show("Nhận tên Môn cần tìm kiếm!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(stringConnetion))
            {
                connection.Open();

                string query = "select * from MonHoc where tenMon like '%" + tk + "%'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            load_DGV();
        }
    }
}
