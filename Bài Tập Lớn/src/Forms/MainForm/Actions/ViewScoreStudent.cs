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

namespace BaiTapLon_CSharp.src.Forms.MainForm.Actions
{
    public partial class ViewScoreStudent : Form
    {
        static ConnectDB Ctrl = new ConnectDB();
        string con = Ctrl.getConnectionString();
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
            }
        }
    }
}
