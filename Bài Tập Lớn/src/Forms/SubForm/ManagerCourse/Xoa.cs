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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NJVE0UN\\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True");
        public Xoa()
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
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string mm = txtmamon.Text.Trim();
            if (mm == "")
            {
                MessageBox.Show("Chọn Môn cần xóa!");
                return;
            }    
            SqlCommand cmd = new SqlCommand("delete from MonHoc where maMon='"+mm+"'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xóa thành công!");
            this.Close();
        }
    }
}
