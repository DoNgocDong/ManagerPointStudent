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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using excel = Microsoft.Office.Interop.Excel.Application;

namespace BaiTapLon_CSharp.src.Forms.MainForm.Actions
{
    public partial class ViewScoreStudent : Form
    {
        static ConnectDB Ctrl = new ConnectDB();
        string con = Ctrl.getConnectionString();
        private FormController ctl = new FormController();
        public ViewScoreStudent()
        {
            InitializeComponent();
        }

        private void ViewScoreStudent_Load(object sender, EventArgs e)
        {
            string masv = Globals.currentAccount;
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string query = "SELECT * FROM Diem where maSinhvien=@maSinhvien";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@maSinhvien", SqlDbType.NVarChar, 20).Value = masv;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv1.DataSource = dt;
                    dgv1.Refresh();
                }
                string query1 = "SELECT * FROM DanhGia where maSinhvien=@maSinhvien";
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.Add("@maSinhvien", SqlDbType.NVarChar, 20).Value = masv;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    DataTable data = new DataTable();
                    da.Fill(data);
                    dgv2.DataSource = data;
                    dgv2.Refresh();
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string condition1 = $"maSinhVien = '{Globals.currentAccount}'";
            string condition2 = $"hocKy = '{cbxhocky.Text}'";
            List<string> listCondition = new List<string>
            {
                condition1,
                condition2,
            };
            ctl.load_DataGridViewWithCondition(dgv1, "Diem", listCondition);
            ctl.load_DataGridViewWithCondition(dgv2, "DanhGia", listCondition);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctl.load_DataGridViewforAll(dgv1, "Diem");
            ctl.load_DataGridViewforAll(dgv2, "DanhGia");
        }
        private bool xuatdgv1(DataGridView dgv1, DataGridView dgv2, string duongdan, string tentap)
        {
            excel obj = new excel();
            try
            {
                int countdgv1 = dgv1.Rows.Count;

                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;
                for (int i = 1; i < dgv1.Columns.Count + 1; i++)
                { obj.Cells[1, i] = dgv1.Columns[i - 1].HeaderText; }
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv1.Columns.Count; j++)
                    {
                        if (dgv1.Rows[i].Cells[j].Value != null)
                        { obj.Cells[i + 2, j + 1] = dgv1.Rows[i].Cells[j].Value.ToString(); }
                    }
                }

                for (int i = 1; i < dgv2.Columns.Count + 1; i++)
                { obj.Cells[countdgv1 + 3, i] = dgv2.Columns[i - 1].HeaderText; }
                for (int i = 0; i < dgv2.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv2.Columns.Count; j++)
                    {
                        if (dgv2.Rows[i].Cells[j].Value != null)
                        { obj.Cells[i + countdgv1 + 4, j + 1] = dgv2.Rows[i].Cells[j].Value.ToString(); }
                    }
                }
                obj.ActiveWorkbook.SaveCopyAs(duongdan + tentap + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (xuatdgv1(dgv1, dgv2, @"D:\", "xuatfileExcel"))
                MessageBox.Show("Xuất thành công");
            else MessageBox.Show("Xuất thất bại");
        }
    }
}