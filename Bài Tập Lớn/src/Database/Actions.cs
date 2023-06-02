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

        public DataTable find(string tableToFind, string getValue, string fieldCondition, string keyword)
        {
            string query = $"select {getValue} from {tableToFind} where {fieldCondition} like '%{keyword}%'";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

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
            string query = $"select * from {tableToFind}";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    return data;
                }
            }
        }

        public bool create(string tableToCreate, Dictionary<string, string> columnValues)
        {
            string query = $"INSERT INTO {tableToCreate} VALUES ({string.Join(", ", columnValues.Keys)})";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                // Tạo command và truyền tham số
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var kvp in columnValues)
                    {
                        command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
                    }

                    // Thực hiện truy vấn
                    int i = command.ExecuteNonQuery();

                    return i > 0;
                }
            }
        }

        public void update(string tableNameToUpdate, Dictionary<string, string> columnValues, string condition)
        {
            // Tạo câu truy vấn cập nhật dữ liệu
            string query = $"UPDATE {tableNameToUpdate} SET ";

            List<string> updateStatements = new List<string>();

            foreach (var kvp in columnValues)
            {
                updateStatements.Add($"{kvp.Key} = @{kvp.Key}");
            }

            query += string.Join(", ", updateStatements);
            query += $" WHERE {condition}";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                // Tạo command và truyền tham số
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var kvp in columnValues)
                    {
                        command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
                    }

                    // Thực hiện truy vấn
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool delete(string tableToDelete, string fieldCondition, string keyword)
        {
            string query = $"delete from {tableToDelete} where {fieldCondition} = '{keyword}'";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    int i = cmd.ExecuteNonQuery();

                    return i > 0;
                }
            }
        }
    }
}
