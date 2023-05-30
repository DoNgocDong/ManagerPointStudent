using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Database
{
    internal class Actions
    {
        private static ConnectDB database = new ConnectDB();
        private static string stringConnection = database.getConnectionString();
        public Actions() { }

        public bool delete(string tableToDelete, string fieldCondition, string keyword)
        {
            using(SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string query = $"delete from {tableToDelete} where {fieldCondition} = '{keyword}'";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    int i = cmd.ExecuteNonQuery();

                    return i > 0;
                }
            }
        }

        public DataTable find(string tableToFind, string getValue, string fieldCondition, string keyword)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string query = $"select {getValue} from {tableToFind} where {fieldCondition} like '%{keyword}%'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    return data;
                }
            }
        }

        public DataTable findAll(string tableToFind)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string query = $"select * from {tableToFind}";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    return data;
                }
            }
        }
    }
}
