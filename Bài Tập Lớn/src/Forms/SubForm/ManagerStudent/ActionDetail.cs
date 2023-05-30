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

namespace BaiTapLon_CSharp.src.Forms.SubForm.ManagerStudent
{
    public partial class ActionDetail : Form
    {
        private static ConnectDB database = new ConnectDB();
        private static Actions databaseQuery = new Actions();
        private static FormController formController = new FormController();

        private string stringConnection = database.getConnectionString();
        private bool isAddStudentAction = ManagerStudent_EnviromentVariable.isAddStudentAction;
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
             nganhTextBox.Text = data.Rows[0][0].ToString();

             string nganh = nganhTextBox.Text;

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string query = "insert into SinhVien Values(N'" + msv + "',N'" + hoTen + "',N'" + lop + "',N'" + khoa + "',N'" + nganh 
                    + "',N'" + ngaySinh + "',N'" + gioiTinh + "',N'" + diaChi + "',N'" + sdt + "',N'" + soCCCD + "',N'" + email + "')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                }
            }
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

                string query = "update SinhVien set maSinhVien = N'" + msv + "', hoTen = N'" + hoTen + "', tenLop = N'" + lop + "', khoa = N'" + khoa + "', tenNganh = N'" + nganh
                    + "', ngaySinh = N'" + ngaySinh + "', gioiTinh = N'" + gioiTinh + "', diaChi = N'" + diaChi + "', sdt = N'" + sdt + "', cccd = N'" + soCCCD + "', email = N'" + email + "'"; 

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
            DataTable data = databaseQuery.find("SinhVien", "*", "maSinhVien", keyword);

            maSinhVienTextBox.Text = data.Rows[0][0].ToString();
            hoTenTextBox.Text = data.Rows[0][1].ToString();
            lopComboBox.Text = data.Rows[0][2].ToString();
            khoaTextBox.Text = data.Rows[0][3].ToString();
            nganhTextBox.Text = data.Rows[0][4].ToString();

            gioiTinhComboBox.Text = data.Rows[0][6].ToString();
            diaChiTextBox.Text = data.Rows[0][7].ToString();
            sdtTextBox.Text = data.Rows[0][8].ToString();
            cccdTextBox.Text = data.Rows[0][9].ToString();
            emailTextBox.Text = data.Rows[0][10].ToString();
        }
    }
}
