using BaiTapLon_CSharp.src.Controller.Forms;
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

namespace BaiTapLon_CSharp.src.Forms.SubForm.ManagerMajors
{
    public partial class ManagerMajorsActions : Form
    {
        private FormController controller = new FormController();

        private bool isAddMajorsAction = ManagerMajors_EnviromentVariable.isAddMajorsAction;
        private string tableName = ManagerMajors_EnviromentVariable.tableName;
        private string primaryKey = ManagerMajors_EnviromentVariable.primaryKeyName;
        public ManagerMajorsActions()
        {
            InitializeComponent();
        }

        private void ManagerMajorsActions_Load(object sender, EventArgs e)
        {
            setUpDisplay(isAddMajorsAction);
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (isAddMajorsAction)
                createMajors();
            else
                updateMajors();

            this.Close();
        }

        private void setUpDisplay(bool check)
        {
            if (check)
            {
                actionBtn.Text = "Thêm Ngành";
            }
            else
            {
                maNganhTextBox.Enabled = false;
                displayToUpdate(ManagerMajors_EnviromentVariable.selectedMaNganh);
                actionBtn.Text = "Lưu thay đổi";
            }
        }

        private void displayToUpdate(string selectedMaNganh)
        {
            DataTable data = controller.find(tableName, "*", primaryKey, selectedMaNganh);

            if (data != null && data.Rows.Count > 0)
            {
                maNganhTextBox.Text = data.Rows[0][0].ToString();
                tenNganhTextBox.Text = data.Rows[0][1].ToString();
            }
        }

        private void createMajors()
        {
            List<object> values = new List<object>();
            try
            {
                values.Add(maNganhTextBox.Text.Trim());
                values.Add(tenNganhTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ và chính xác thông tin!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Dictionary<string, object> columnValues = new Dictionary<string, object>();

            for (int i = 0; i < values.Count; i++)
            {
                columnValues.Add(ModelStudent.getFieldName(i), values[i]);
            }

            controller.create(tableName, columnValues);
        }

        private void updateMajors()
        {
            List<object> values = new List<object>();

            try
            {
                values.Add(maNganhTextBox.Text.Trim());
                values.Add(tenNganhTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ và chính xác thông tin!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Dictionary<string, object> columnValues = new Dictionary<string, object>();

            for (int i = 0; i < values.Count; i++)
            {
                columnValues.Add(ModelStudent.getFieldName(i), values[i]);
            }

            string condition = $"{primaryKey} = '{ManagerMajors_EnviromentVariable.selectedMaNganh}'";
            controller.update(tableName, columnValues, condition);
        }
    }
}
