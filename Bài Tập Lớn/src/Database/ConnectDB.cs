using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaiTapLon_CSharp.src.Database
{
    public class ConnectDB
    {
        private string stringConnection = $"Data Source= {Globals.databaseServerName};Initial Catalog=QLDiemSinhVien;Integrated Security=True";

        public ConnectDB() {}

        public string getConnectionString()
        {
            return this.stringConnection;
        }

        public bool checkExistValueInDatabase(string keyword, string compareFieldName, string compareTableName)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {compareTableName} WHERE {compareFieldName} = @keyword";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@keyword", keyword);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
