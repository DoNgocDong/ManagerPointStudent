using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BaiTapLon_CSharp.src.Forms.MainForm.Tools
{
    public partial class Exambanlist : Form
    {
        public Exambanlist()
        {
            InitializeComponent();
        }
        private Services sr = new Services();
        private FormController clt = new FormController(); 

        private void button2_Click(object sender, EventArgs e)
        {
            string keyword = txttiemkiem.Text.Trim();
            DataTable dt =sr.find("DanhGia","*","maSinhVien",keyword);
            dgv1.DataSource= dt;
            dgv1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clt.load_DataGridViewforAll(dgv1,"DanhGia");
        }
        private void bxuat_Click(object sender, EventArgs e)
        {

        }
    }
}
