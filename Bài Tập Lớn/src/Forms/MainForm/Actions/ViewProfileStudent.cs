using BaiTapLon_CSharp.src.Controller.Forms;
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

namespace BaiTapLon_CSharp.src.Forms.MainForm.Actions
{
    public partial class ViewProfileStudent : Form
    {
        private Services databaseQuery = new Services();
        private string masv = Globals.currentAccount;
        private string tableName = Globals.tableStudent;
        private static FormController formController = new FormController();
        private static ConnectDB database = new ConnectDB();
        private string connectString = database.getConnectionString();
        public ViewProfileStudent()
        {
            InitializeComponent();
        }
        private void ViewProfileStudent_Load_1(object sender, EventArgs e)
        {
            string p_timkiem = Globals.currentAccount;
            DataTable data = formController.find("SinhVien", "*", "maSinhVien", p_timkiem);
            if (data != null && data.Rows.Count > 0)
            {
                DateTime ns = Convert.ToDateTime(data.Rows[0][5].ToString());
                txtMaSV.Text = data.Rows[0][0].ToString();
                txtHoTen.Text = data.Rows[0][1].ToString();
                txtTenLop.Text = data.Rows[0][2].ToString();
                txtKhoa.Text = data.Rows[0][3].ToString();
                txtTenNganh.Text = data.Rows[0][4].ToString();
                txtNgaySInh.Text = ns.ToString("dd/MM/yyyy");
                txtGioiTinh.Text = data.Rows[0][6].ToString();
                txtDiaChi.Text = data.Rows[0][7].ToString();
                txtSDT.Text = data.Rows[0][8].ToString();
                txtCCCD.Text = data.Rows[0][9].ToString();
                txtEmail.Text = data.Rows[0][10].ToString();
            }
        }
    }
}