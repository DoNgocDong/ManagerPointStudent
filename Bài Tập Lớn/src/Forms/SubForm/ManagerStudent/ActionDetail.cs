using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Database;
using BaiTapLon_CSharp.src.Models;
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

namespace BaiTapLon_CSharp.src.Forms.SubForm.ManagerStudent
{
    public partial class ActionDetail : Form
    {
        private static ConnectDB database = new ConnectDB();
        private static Services databaseQuery = new Services();
        private static FormController formController = new FormController();

        private string stringConnection = database.getConnectionString();
        private bool isAddStudentAction = ManagerStudent_EnviromentVariable.isAddStudentAction;
        private string tableName = ManagerStudent_EnviromentVariable.tableName;

        public ActionDetail()
        {
            InitializeComponent();
        }

        private void ActionDetail_Load(object sender, EventArgs e)
        {
            setUpDisplay(isAddStudentAction);
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (isAddStudentAction)
                addStudent();
            else
                update();
        }

        private void setUpDisplay(bool check)
        {
            if(check){
                actionBtn.Text = "Thêm Sinh Viên";
                formController.load_ComboBox(lopComboBox, "Lop", "tenLop", "maLop");
            }
            else{
                maSinhVienTextBox.Enabled = false;
                displayToUpdate(ManagerStudent_EnviromentVariable.selectedMaSV);
                actionBtn.Text = "Lưu thay đổi";
            }
        }

        private void addStudent()
        {             
/*            string msv = maSinhVienTextBox.Text.Trim();
            string lop = lopComboBox.Text.Trim();
            string hoTen = hoTenTextBox.Text.Trim();
            string gioiTinh = gioiTinhComboBox.SelectedItem.ToString();
            string diaChi = diaChiTextBox.Text.Trim();
            int khoa = Convert.ToInt32(khoaTextBox.Text.Trim());
            string sdt = sdtTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string soCCCD = cccdTextBox.Text.Trim();
            DateTime ngaySinh = ngaySinhDateTimePicker.Value;
            string nganh = nganhTextBox.Text.Trim();*/

            ModelStudent student = new ModelStudent();

            student.maSinhVien = maSinhVienTextBox.Text.Trim();
            student.hoTen = hoTenTextBox.Text.Trim();
            student.tenLop = lopComboBox.Text.Trim();
            student.khoa = Convert.ToInt32(khoaTextBox.Text.Trim());
            student.tenNganh = nganhTextBox.Text.Trim();
            student.ngaySinh = ngaySinhDateTimePicker.Value;
            student.gioiTinh = gioiTinhComboBox.SelectedItem.ToString();
            student.diaChi = diaChiTextBox.Text.Trim();
            student.sdt = sdtTextBox.Text.Trim();
            student.cccd = cccdTextBox.Text.Trim();
            student.email = emailTextBox.Text.Trim();

            Dictionary<string, object> values = new Dictionary<string, object>();

            values.Add(student.getColumnName_maSinhVien(), student.maSinhVien);
            values.Add(student.getColumnName_hoTen(), student.hoTen);
            values.Add(student.getColumnName_tenLop(), student.tenLop);
            values.Add(student.getColumnName_khoa(), student.khoa);
            values.Add(student.getColumnName_tenNganh(), student.tenNganh);
            values.Add(student.getColumnName_ngaySinh(), student.ngaySinh);
            values.Add(student.getColumnName_gioiTinh(), student.gioiTinh);
            values.Add(student.getColumnName_diaChi(), student.diaChi);
            values.Add(student.getColumnName_sdt(), student.sdt);
            values.Add(student.getColumnName_cccd(), student.cccd);
            values.Add(student.getColumnName_email(), student.email);

            databaseQuery.create(tableName, values);

/*            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string query = "insert into SinhVien Values('" + msv + "',N'" + hoTen + "',N'" + lop + "',N'" + khoa + "',N'" + nganh 
                    + "','" + ngaySinh + "',N'" + gioiTinh + "',N'" + diaChi + "','" + sdt + "','" + soCCCD + "','" + email + "')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                }
            }*/
        }

        private void update()
        {
            string msv = maSinhVienTextBox.Text.Trim();
            string lop = lopComboBox.Text.Trim();
            string hoTen = hoTenTextBox.Text.Trim();
            string gioiTinh = gioiTinhComboBox.SelectedItem.ToString();
            string diaChi = diaChiTextBox.Text.Trim();
            int khoa = Convert.ToInt32(khoaTextBox.Text.Trim());
            string sdt = maSinhVienTextBox.Text.Trim();
            string email = maSinhVienTextBox.Text.Trim();
            string soCCCD = maSinhVienTextBox.Text.Trim();
            DateTime ngaySinh = ngaySinhDateTimePicker.Value;

            DataTable data = databaseQuery.find("Lop", "tenNganh", "tenLop", lop);
            string nganh = data.Rows[0][0].ToString();

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string query = "update SinhVien set maSinhVien = '" + msv + "', hoTen = N'" + hoTen + "', tenLop = N'" + lop + "', khoa = '" + khoa + "', tenNganh = N'" + nganh
                    + "', ngaySinh = '" + ngaySinh + "', gioiTinh = N'" + gioiTinh + "', diaChi = N'" + diaChi + "', sdt = '" + sdt + "', cccd = '" + soCCCD + "', email = '" + email + "'"; 

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!");
                    this.Close();
                }
            }
        }

        private void displayToUpdate(string keyword)
        {
            DataTable data = databaseQuery.find(tableName, "*", "maSinhVien", keyword);

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

            DataTable data = databaseQuery.find("Lop", "tenNganh", "tenLop", lop);

            if (data != null && data.Rows.Count > 0)
            {
                nganhTextBox.Text = data.Rows[0][0].ToString();
            }
        }
    }
}
