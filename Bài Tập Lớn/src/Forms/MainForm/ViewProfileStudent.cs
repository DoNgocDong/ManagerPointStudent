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

namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    public partial class ViewProfileStudent : Form
    {
        private Actions databaseQuery = new Actions();
        private string masv = Globals.currentAccount;
        private string tableName = Globals.tableStudent;

        public ViewProfileStudent()
        {
            InitializeComponent();
        }

        private void ViewProfileStudent_Load(object sender, EventArgs e)
        {
            DataTable data = databaseQuery.find(tableName, "*", "maSinhVien", masv);
            dgv1.DataSource = data;
            dgv1.Refresh();
        }
    }
}