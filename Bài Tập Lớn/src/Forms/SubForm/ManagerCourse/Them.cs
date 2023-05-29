using BaiTapLon_CSharp.src.Forms.MainForm;
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
    public partial class Them : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NJVE0UN\\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True");
        public Them()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string mamonhoc = txtmamon.Text.Trim();
            if (mamonhoc == "")
            {
                txtmamon.Focus();
                MessageBox.Show("Phải nhập mã môn!");
                return;
            }
            string tenmonhoc = txttenmon.Text.Trim();
            if (tenmonhoc == "")
            {
                txttenmon.Focus();
                MessageBox.Show("Phải nhập tên môn!");
                return;
            }
            string sotinchi = txtsotinchi.Text.Trim();
            if (sotinchi == "")
            {
                txtsotinchi.Focus();
                MessageBox.Show("Phải nhập mã môn!");
                return;
            }
            string query = "insert MonHoc values('" + mamonhoc + "','" + tenmonhoc + "'," + sotinchi + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm thành công!");
            this.Close();
        }

        private void Them_Load(object sender, EventArgs e)
        {

        }
    }
}
