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

namespace BaiTapLon_CSharp.src.Forms.SubForm.ManagerCourse
{
    public partial class Xoa : Form
    {
        private static ConnectDB database = new ConnectDB();
        private string stringConnetion = database.getConnectionString();
        public Xoa()
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
        private void Xoa_Load(object sender, EventArgs e)
        {
            load_DGV();

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; //lấy chỉ số dòng dc click
            txtmamon.Text = DGV.Rows[i].Cells[0].Value.ToString();
            txttenmon.Text = DGV.Rows[i].Cells[1].Value.ToString();
            txtsotinchi.Text = DGV.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mm = txtmamon.Text.Trim();
            if (mm == "")
            {
                MessageBox.Show("Chọn Môn cần xóa!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(stringConnetion))
            {
                connection.Open();

                string query = "delete from MonHoc where maMon='" + mm + "'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    this.Close();
                }
            }
        }
    }
}
