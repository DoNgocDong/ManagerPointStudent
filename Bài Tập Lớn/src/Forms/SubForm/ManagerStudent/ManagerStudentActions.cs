using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.SubForm.ManagerStudent
{
    public partial class ManagerStudentActions : Form
    {
        private static FormController formController = new FormController();

        private bool isAddStudentAction = ManagerStudent_EnviromentVariable.isAddStudentAction;
        private string tableName = ManagerStudent_EnviromentVariable.tableName;
        private string primaryKey = ManagerStudent_EnviromentVariable.primaryKeyName;

        public ManagerStudentActions()
        {
            InitializeComponent();
        }

        private void ActionDetail_Load(object sender, EventArgs e)
        {
            formController.load_ComboBox(lopComboBox, Globals.tableClass, "tenLop", "maLop");
            setUpDisplay(isAddStudentAction);
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (isAddStudentAction)
                createStudent();
            else
                updateStudent();

            this.Close();
        }

        private void setUpDisplay(bool check)
        {
            if(check){
                actionBtn.Text = "Thêm Sinh Viên";
            }
            else{
                maSinhVienTextBox.Enabled = false;
                displayToUpdate(ManagerStudent_EnviromentVariable.selectedMaSV);
                actionBtn.Text = "Lưu thay đổi";
            }
        }

        private void createStudent()
        {
            List<object> values = new List<object>();
            try
            {
                values.Add(maSinhVienTextBox.Text.Trim());
                values.Add(hoTenTextBox.Text.Trim());
                values.Add(lopComboBox.Text.Trim());
                values.Add(Convert.ToInt32(khoaTextBox.Text.Trim()));
                values.Add(nganhTextBox.Text.Trim());
                values.Add(ngaySinhDateTimePicker.Value);
                values.Add(gioiTinhComboBox.SelectedItem.ToString());
                values.Add(diaChiTextBox.Text.Trim());
                values.Add(sdtTextBox.Text.Trim());
                values.Add(cccdTextBox.Text.Trim());
                values.Add(emailTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ và chính xác thông tin!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Dictionary<string, object> columnValues = new Dictionary<string, object>();

            for(int i=0; i< values.Count; i++)
            {
                columnValues.Add(ModelStudent.getFieldName(i), values[i]);
            }

            if (formController.create(tableName, columnValues))
                this.createAccountStudent(maSinhVienTextBox.Text.Trim());
        }

        private void updateStudent()
        {
            List<object> values = new List<object>();

            try
            {
                values.Add(maSinhVienTextBox.Text.Trim());
                values.Add(hoTenTextBox.Text.Trim());
                values.Add(lopComboBox.Text.Trim());
                values.Add(Convert.ToInt32(khoaTextBox.Text.Trim()));
                values.Add(nganhTextBox.Text.Trim());
                values.Add(ngaySinhDateTimePicker.Value);
                values.Add(gioiTinhComboBox.SelectedItem.ToString());
                values.Add(diaChiTextBox.Text.Trim());
                values.Add(sdtTextBox.Text.Trim());
                values.Add(cccdTextBox.Text.Trim());
                values.Add(emailTextBox.Text.Trim());
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

            string condition = $"maSinhVien = '{ManagerStudent_EnviromentVariable.selectedMaSV}'";
            formController.update(tableName, columnValues, condition);
        }

        private void displayToUpdate(string keyword)
        {
            DataTable data = formController.find(tableName, "*", primaryKey, keyword);

            if(data != null && data.Rows.Count > 0)
            {
                maSinhVienTextBox.Text = data.Rows[0][0].ToString();
                hoTenTextBox.Text = data.Rows[0][1].ToString();
                lopComboBox.Text = data.Rows[0][2].ToString();
                khoaTextBox.Text = data.Rows[0][3].ToString();
                nganhTextBox.Text = data.Rows[0][4].ToString();
                ngaySinhDateTimePicker.Value = Convert.ToDateTime(data.Rows[0][5]);
                gioiTinhComboBox.Text = data.Rows[0][6].ToString();
                diaChiTextBox.Text = data.Rows[0][7].ToString();
                sdtTextBox.Text = data.Rows[0][8].ToString();
                cccdTextBox.Text = data.Rows[0][9].ToString();
                emailTextBox.Text = data.Rows[0][10].ToString();
            }
        }

        private void lopComboBox_TextChanged(object sender, EventArgs e)
        {
            string lop = lopComboBox.Text.Trim();

            DataTable data = formController.find(Globals.tableClass, "tenNganh", "tenLop", lop);

            if (data != null && data.Rows.Count > 0)
            {
                nganhTextBox.Text = data.Rows[0][0].ToString();
            }
        }

        private bool createAccountStudent(string maSinhVien)
        {
            try
            {
                Dictionary<string, object> value = new Dictionary<string, object>();
                for (int i = 0; i < 3; i++)
                {
                    value.Add(ModelsUserAccount.getFieldName(i), maSinhVien);
                }

                formController.create(Globals.tableStudentAccount, value);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    } 
}
