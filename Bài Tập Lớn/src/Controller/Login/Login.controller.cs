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
    }
}
