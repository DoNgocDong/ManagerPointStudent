using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Controller.ProfessionHandling;
using BaiTapLon_CSharp.src.Database;
using BaiTapLon_CSharp.src.Forms.SubForm.ManagerScore;
using BaiTapLon_CSharp.src.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.MainForm.Manager 
{
    public partial class ManagerScore : Form

    {
        static ConnectDB Ctrl = new ConnectDB();
        string con = Ctrl.getConnectionString();
        private FormController fctl = new FormController();
        private FinalScore professionHandling = new FinalScore();

        public ManagerScore()
        {
            InitializeComponent();
        }
        private void ManagerScore_Load(object sender, EventArgs e)
        {
            load_dgv2();
            fctl.load_ComboBox(txttenmon, "MonHoc", "tenMon", "maMon");
        }
        public void load_dgv2()
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = "Select*from Diem";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = command;
                    //b4 do du lieu tu adp va data table
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dgv2.DataSource = dt;
                    dgv2.Refresh();
                }
            }
        }

        private void bluu_Click(object sender, EventArgs e)
        {
            string masv = txtmasv.Text.Trim();
            string hoten = txthoten.Text.Trim();
            string mamon = txtmamon.Text.Trim();
            string tenmom = txttenmon.Text.Trim();
            double diemCC = Convert.ToDouble(txtdiemCC.Text.Trim());
            double diemGK = Convert.ToDouble(txtdiemGK.Text.Trim());
            double diemTH = Convert.ToDouble(txtdiemTH.Text.Trim());
            double diemCK = Convert.ToDouble(txtdiemCK.Text.Trim());

            List<object> scores = new List<object>
            {
                diemCC,
                diemGK,
                diemTH,
                diemCK
            };

            ManagerScore_EnviromentVariable.listComponentScore = addScoreToList(scores);
            double diemTK = professionHandling.getDiemTK_1Mon(ManagerScore_EnviromentVariable.listComponentScore);
            string diemChu = professionHandling.getDiemChu(diemTK);
            string danhGia = professionHandling.getDanhGia(diemChu);

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = $"insert into Diem Values('{masv}', N'{hoten}', '{mamon}', N'{tenmom}', {diemCC}, {diemGK}, {diemTH}, {diemCK}, {diemTK}, '{diemChu}', '{danhGia}')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        load_dgv2();
                    }
                }
            }
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text.Trim());
            string masv = txtmasv.Text.Trim();
            string hoten = txthoten.Text.Trim();
            string mamon = txtmamon.Text.Trim();
            string tenmom = txttenmon.Text.Trim();
            double diemCC = Convert.ToDouble(txtdiemCC.Text);
            double diemGK = Convert.ToDouble(txtdiemGK.Text);
            double diemTH = Convert.ToDouble(txtdiemTH.Text);
            double diemCK = Convert.ToDouble(txtdiemCK.Text);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = "Update Diem set maSinhVien = '" + masv + "', hoTen= N'" + hoten + "',maMon='" + mamon + "',tenMon=N'" + tenmom + "',diemCC='" + diemCC + "',diemGK = '" + diemGK + "',diemTH ='" + diemTH + "',diemCK ='" + diemCK + "' Where ID = '" + id + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Sửa thành công");
                        else
                            MessageBox.Show("Sửa thất bại");

                        load_dgv2();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtID.Text = dgv2.Rows[i].Cells[0].Value.ToString();
                txtmasv.Text = dgv2.Rows[i].Cells[1].Value.ToString();
                txthoten.Text = dgv2.Rows[i].Cells[2].Value.ToString();
                txtmamon.Text = dgv2.Rows[i].Cells[3].Value.ToString();
                txttenmon.Text = dgv2.Rows[i].Cells[4].Value.ToString();
                txtdiemCC.Text = dgv2.Rows[i].Cells[5].Value.ToString();
                txtdiemGK.Text = dgv2.Rows[i].Cells[6].Value.ToString();
                txtdiemTH.Text = dgv2.Rows[i].Cells[7].Value.ToString();
                txtdiemCK.Text = dgv2.Rows[i].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string masv = txtmasv.Text.Trim();
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = "Delete From Diem where maSinhVien='" + masv + "' ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    load_dgv2();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            load_dgv2();
        }

        private Dictionary<string, object> addScoreToList(List<object> scores)
        {
            Dictionary<string, object> listScore = new Dictionary<string, object>();

            for (int i=0; i<scores.Count; i++)
            {
                listScore.Add(ModelScore.getFieldName(i+5), scores[i]);
            }

            return listScore;
        }
    }
}
