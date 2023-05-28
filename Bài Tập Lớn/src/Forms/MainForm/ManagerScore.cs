using BaiTapLon_CSharp.src.Controller.Login;
using BaiTapLon_CSharp.src.Database;
using BaiTapLon_CSharp.src.Forms.SubForm.subManagerScoure;
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

namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    public partial class ManagerScore : Form
    {
        public void load_dgv1()
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
                    dgv1.DataSource = dt;
                    dgv1.Refresh();
                }
            }
        }
        static ConnectDB Ctrl = new ConnectDB();
        string con = Ctrl.getConnectionString();
        public ManagerScore()
        {
            InitializeComponent();
        }

        private void ManagerScore_Load(object sender, EventArgs e)
        {
            load_dgv1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = txt1.Text.Trim();
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();


                string query = "Diemtrungbinh_find";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@maSinhvien", SqlDbType.NVarChar, 20).Value = tk;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv1.DataSource = dt;
                    dgv1.Refresh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add them = new Add();
            them.ShowDialog();
            load_dgv1();

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt1.Text = dgv1.Rows[i].Cells[1].Value.ToString();
        }
    }
}

