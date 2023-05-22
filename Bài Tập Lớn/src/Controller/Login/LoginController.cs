using BaiTapLon_CSharp.src.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Controller.Login
{
    public class Login
    {
        private static ConnectDB database = new ConnectDB();
        private string connectString = database.getConnectionString();

        public bool CheckLogin(string username, string password, string tableUser)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {tableUser} WHERE userName = @Username AND userPassword = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public void changePassword(string userName, string newPassword, string tableUser)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                string query = $"UPDATE {tableUser} SET userPassword = @newPass WHERE userName = @userName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@newPass", newPassword);
                    
                    command.ExecuteNonQuery();
                }
            }
        }

        public void handleChangeStatusPassword(TextBox txtPassword, PictureBox pictureBox)
        {
            if(txtPassword.PasswordChar == '*')
            {
                pictureBox.Image = global::BaiTapLon_CSharp.Properties.Resources.showEye;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                pictureBox.Image = global::BaiTapLon_CSharp.Properties.Resources.hideEye;
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
