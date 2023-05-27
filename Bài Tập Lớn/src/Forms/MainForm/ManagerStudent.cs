using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Forms.SubForm.ManagerStudent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    public partial class ManagerStudent : Form
    {
        FormController controller = new FormController();
        string tableName = ManagerStudent_EnviromentVariable.tableName;

        public ManagerStudent()
        {
            InitializeComponent();
        }

        private void ManagerStudent_Load(object sender, EventArgs e)
        {
            controller.load_DataGridView(dgvDisplayStudents, tableName);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            controller.load_DataGridView(dgvDisplayStudents, tableName);
        }
    }
}
