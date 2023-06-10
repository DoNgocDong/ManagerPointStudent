using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Forms.SubForm.ManagerStudent;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.MainForm.Manager
{
    public partial class ManagerStudent : Form
    {
        private FormController controller = new FormController();
        private string tableName = ManagerStudent_EnviromentVariable.tableName;

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
            controller.showDialog(new ManagerStudentActions());
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
            controller.showDialog(new ManagerStudentActions());
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
                    if (controller.delete(tableName, fieldCondition, keyword))
                        controller.delete(Globals.tableStudentAccount, fieldCondition, keyword);
                    break;
                case DialogResult.No:
                    break;
            }
            controller.load_DataGridViewforAll(dgvDisplayStudents, tableName);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            controller.load_DataGridViewforAll(dgvDisplayStudents, tableName);
            updateBtn.Enabled = false;
            updateBtn.BackColor = Color.AliceBlue;
            deleteBtn.Enabled = false;
            deleteBtn.BackColor = Color.AliceBlue;
            selectedStudentLabel.Text = "None";
        }

        private void dgvDisplayStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                selectedStudentLabel.Text = dgvDisplayStudents.Rows[i].Cells[0].Value.ToString();

                ManagerStudent_EnviromentVariable.selectedMaSV = selectedStudentLabel.Text;

                updateBtn.Enabled = true;
                updateBtn.BackColor = Color.Aqua;
                deleteBtn.Enabled = true;
                deleteBtn.BackColor = Color.Aqua;
            }
            catch (Exception ex) {
                
            }
        }
    }
}
