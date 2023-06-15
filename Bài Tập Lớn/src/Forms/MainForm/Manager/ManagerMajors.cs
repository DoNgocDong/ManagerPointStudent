using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Forms.SubForm.ManagerMajors;
using BaiTapLon_CSharp.src.Forms.SubForm.ManagerStudent;
using BaiTapLon_CSharp.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.MainForm.Manager
{
    public partial class ManagerMajors : Form
    {
        FormController controller = new FormController();

        string tableName = Globals.tableMajors;
        string fieldCondition = ModelMajors.getFieldName(ModelMajors.maNganh);
        public ManagerMajors()
        {
            InitializeComponent();
        }

        private void ManagerMajors_Load(object sender, EventArgs e)
        {
            controller.load_DataGridViewforAll(displayMajorsDgv, tableName);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            controller.load_DataGridViewforAll(displayMajorsDgv, tableName);
            updateBtn.Enabled = false;
            updateBtn.BackColor = Color.AliceBlue;
            deleteBtn.Enabled = false;
            deleteBtn.BackColor = Color.AliceBlue;
            selectedMajorsLabel.Text = "None";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = keywordTxt.Text.Trim();
            controller.load_DataGridViewWithCondition(displayMajorsDgv, tableName, fieldCondition, keyword);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ManagerMajors_EnviromentVariable.isAddMajorsAction = true;
            controller.showDialog(new ManagerMajorsActions());
            controller.load_DataGridViewforAll(displayMajorsDgv, tableName);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ManagerMajors_EnviromentVariable.isAddMajorsAction = false;
            controller.showDialog(new ManagerMajorsActions());
            controller.load_DataGridViewforAll(displayMajorsDgv, tableName);

            this.reloadBtn_Click(sender, e);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string keyword = selectedMajorsLabel.Text.Trim();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    controller.delete(tableName, fieldCondition, keyword);
                    break;
                case DialogResult.No:
                    break;
            }

            this.reloadBtn_Click(sender, e);
        }

        private void displayMajorsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                selectedMajorsLabel.Text = displayMajorsDgv.Rows[i].Cells[0].Value.ToString();

                ManagerMajors_EnviromentVariable.selectedMaNganh = selectedMajorsLabel.Text;

                updateBtn.Enabled = true;
                updateBtn.BackColor = Color.Aqua;
                deleteBtn.Enabled = true;
                deleteBtn.BackColor = Color.Aqua;
            }
            catch (Exception ex) {}
        }
    }
}
