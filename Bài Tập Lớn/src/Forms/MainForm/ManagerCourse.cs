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

namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    public partial class ManagerCourse : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NJVE0UN\\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True");
        public ManagerCourse()
        {
            InitializeComponent();
        }

        private void load_DGV()
        {
            if (con.State == ConnectionState.Closed) { 
                con.Open(); }
            SqlCommand cmd = new SqlCommand("select * from MonHoc",con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            DGV.DataSource = tb;
            DGV.Refresh();
        }
        private void ManagerCourse_Load(object sender, EventArgs e)
        {
            load_DGV();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them them = new Them();
            them.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Sua sua = new Sua();
            sua.Show();
        }
    }
}
