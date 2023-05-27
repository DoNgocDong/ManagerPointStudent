using BaiTapLon_CSharp.src.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Controller.Forms
{
    public class FormController
    {
        private static ConnectDB database = new ConnectDB();
        private string connectString = database.getConnectionString();

        public void hideAndShow(Form hiddenForm, Form displayForm)
        {
            hiddenForm.Hide();
            displayForm.Show();
        }

        public void closeAndShow(Form closeForm, Form displayForm)
        {
            closeForm.Close();
            displayForm.Show();
        }

        public void showDialog(Form f)
        {
            f.ShowDialog();
        }

        public void show(Form f)
        {
            f.Show();
        }

        public void addForm(Form childForm, Panel placeShow)
        {
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            placeShow.Controls.Clear();
            placeShow.Controls.Add(childForm);
            childForm.Show();
        }
        
        public void load_DataGridView(DataGridView dgv, string tableNameinDatabase)
        {
            using(SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                string query = $"select * from {tableNameinDatabase}";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                    dgv.Refresh();
                }
            }
        }

        public void load_ComboBox(ComboBox cbBox)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                string query = "";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                }
            }
        }
    }
}
