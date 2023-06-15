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
            btSua.Enabled = false;
            btXoa.Enabled = false;
            cbbMasv.Enabled = false;

            load_dgv2();
            fctl.load_ComboBox(cbbLop, Globals.tableClass, "tenLop", "maLop");
        }
        public void load_dgv2()
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = "Select * from Diem";
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
            string masv = cbbMasv.Text.Trim();
            string hoten = txthoten.Text.Trim();
            string mamon = txtmamon.Text.Trim();
            string tenmon = cbbTenmon.Text.Trim();
            float diemCC = Convert.ToSingle(txtdiemCC.Text.Trim());
            float diemGK = Convert.ToSingle(txtdiemGK.Text.Trim());
            float diemTH = Convert.ToSingle(txtdiemTH.Text.Trim());
            float diemCK = Convert.ToSingle(txtdiemCK.Text.Trim());
            int hocKy = Convert.ToInt32(txtHocKy.Text.Trim());

            List<float> scores = new List<float>
            {
                diemCC,
                diemGK,
                diemTH,
                diemCK
            };

            List<string> columnName = new List<string>();
            for(int i=1; i<13; i++)
            {
                columnName.Add(ModelScore.getFieldName(i));
            }

            ManagerScore_EnviromentVariable.listComponentScore = addScoreToList(scores);
            float diemTK = professionHandling.getDiemTK_1Mon(ManagerScore_EnviromentVariable.listComponentScore);
            string diemChu = professionHandling.getDiemChu(diemTK);
            string danhGia = professionHandling.getDanhGia(diemChu);

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = $"insert into Diem ({string.Join(", ", columnName)}) Values('{masv}', N'{hoten}', '{mamon}', N'{tenmon}', {diemCC}, {diemGK}, {diemTH}, {diemCK}, {diemTK.ToString().Replace(",", ".")}, '{diemChu}', '{danhGia}', {hocKy})";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                            MessageBox.Show(query);
                            load_dgv2();
                        }
                        else
                            MessageBox.Show("Thêm thất bại");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(diemTK.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text.Trim());
            string masv = cbbMasv.Text.Trim();
            string hoten = txthoten.Text.Trim();
            string mamon = txtmamon.Text.Trim();
            string tenmon = cbbTenmon.Text.Trim();
            float diemCC = Convert.ToSingle(txtdiemCC.Text);
            float diemGK = Convert.ToSingle(txtdiemGK.Text);
            float diemTH = Convert.ToSingle(txtdiemTH.Text);
            float diemCK = Convert.ToSingle(txtdiemCK.Text);
            int hocKy = Convert.ToInt32(txtHocKy.Text.Trim());

            List<float> scores = new List<float>
            {
                diemCC,
                diemGK,
                diemTH,
                diemCK
            };

            List<string> columnName = new List<string>();
            for (int i = 1; i < 13; i++)
            {
                columnName.Add(ModelScore.getFieldName(i));
            }

            ManagerScore_EnviromentVariable.listComponentScore = addScoreToList(scores);
            float diemTK = professionHandling.getDiemTK_1Mon(ManagerScore_EnviromentVariable.listComponentScore);
            string diemChu = professionHandling.getDiemChu(diemTK);
            string danhGia = professionHandling.getDanhGia(diemChu);

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = $"Update Diem set maSinhVien = '{masv}', hoTen=N'{hoten}', maMon='{mamon}', tenMon=N'{tenmon}', " +
                    $"diemCC={diemCC}, diemGK={diemGK}, diemTH={diemTH}, diemCK={diemCK}, diemTK={diemTK}, diemChu='{diemChu}', danhGia='{danhGia}', hocKy={hocKy}" +
                    $" Where ID = '" + id + "'";
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
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cbbMasv.Text = dgv2.Rows[i].Cells[1].Value.ToString();
                txthoten.Text = dgv2.Rows[i].Cells[2].Value.ToString();
                txtmamon.Text = dgv2.Rows[i].Cells[3].Value.ToString();
                cbbTenmon.Text = dgv2.Rows[i].Cells[4].Value.ToString();
                txtdiemCC.Text = dgv2.Rows[i].Cells[5].Value.ToString();
                txtdiemGK.Text = dgv2.Rows[i].Cells[6].Value.ToString();
                txtdiemTH.Text = dgv2.Rows[i].Cells[7].Value.ToString();
                txtdiemCK.Text = dgv2.Rows[i].Cells[8].Value.ToString();

                btSua.Enabled = true;
                btXoa.Enabled = true;
            }
            catch (Exception ex) {}
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text.Trim();
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = "Delete From Diem where ID = '"+ID+"' ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    load_dgv2();
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ManagerScore_Load(sender, e);
        }

        private void cbbLop_TextChanged(object sender, EventArgs e)
        {
            cbbMasv.Enabled = true;
            noteMsvLabel.Visible = false;

            string tenLop = cbbLop.Text.Trim();
            string condition = $"tenLop = '{tenLop}'";

            List<string> conditions= new List<string> { condition };

            fctl.load_ComboBox(cbbMasv, Globals.tableStudent, "maSinhVien", "hoTen", conditions);
            fctl.load_ComboBox(cbbTenmon, Globals.tableCourse, "tenMon", "maMon");
        }

        private void cbbTenmon_TextChanged(object sender, EventArgs e)
        {
            txtmamon.Text = cbbTenmon.SelectedValue.ToString();

            DataTable data = fctl.find(Globals.tableCourse, "hocKy", "maMon", txtmamon.Text);

            if (data != null && data.Rows.Count > 0)
                txtHocKy.Text = data.Rows[0][0].ToString();
        }

        private void cbbMasv_TextChanged(object sender, EventArgs e)
        {
            txthoten.Text = cbbMasv.SelectedValue.ToString();
        }

        private Dictionary<string, float> addScoreToList(List<float> scores)
        {
            Dictionary<string, float> listScore = new Dictionary<string, float>();

            for (int i = 0; i < scores.Count; i++)
            {
                listScore.Add(ModelScore.getFieldName(i + 5), scores[i]);
            }

            return listScore;
        }
    }
}
