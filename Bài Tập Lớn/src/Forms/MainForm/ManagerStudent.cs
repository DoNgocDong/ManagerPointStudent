using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Database;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    public partial class ManagerStudent : Form
    {
        private FormController controller = new FormController();
        private Actions databaseQuery = new Actions();
        string tableName = ManagerStudent_EnviromentVariable.tableName;
        string selectedMSV = ManagerStudent_EnviromentVariable.selectedMaSV;

        public ManagerStudent()
        {
            InitializeComponent();
        }

        private void ManagerStudent_Load(object sender, EventArgs e)
        {
            controller.load_DataGridViewforAll(dgvDisplayStudents, tableName);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ManagerStudent_EnviromentVariable.isAddStudentAction = true;
            controller.showDialog(new ActionDetail());
            controller.load_DataGridViewforAll(dgvDisplayStudents, tableName);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string fieldCondition = "maSinhVien";
            string keyword = keywordTxt.Text.Trim();
            controller.load_DataGridViewWithCondition(dgvDisplayStudents, tableName, fieldCondition, keyword);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ManagerStudent_EnviromentVariable.isAddStudentAction = false;
            controller.showDialog(new ActionDetail());
            controller.load_DataGridViewforAll(dgvDisplayStudents, tableName);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string fieldCondition = "maSinhVien";
            string keyword = selectedStudentLabel.Text.Trim();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            switch (result)
            {
                case DialogResult.Yes:
                    databaseQuery.delete(tableName, fieldCondition, keyword);
                    break;
                case DialogResult.No:
                    break;
            }
            controller.load_DataGridViewforAll(dgvDisplayStudents, tableName);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            controller.load_DataGridViewforAll(dgvDisplayStudents, tableName);
        }

        private void dgvDisplayStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            selectedStudentLabel.Text = dgvDisplayStudents.Rows[i].Cells[0].Value.ToString();
            selectedMSV = selectedStudentLabel.Text;
        }
    }
}
