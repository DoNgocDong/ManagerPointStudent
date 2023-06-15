using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Database
{
    public class Services
    {
        private static ConnectDB database = new ConnectDB();
        private static string stringConnection = database.getConnectionString();
        public Services() { }

        //Select 1 hoặc nhiều bản ghi với điều kiện fieldCondition like %keyword%
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

        //Select 1 hoặc nhiều bản ghi với nhiều điều kiện
        public DataTable find(string tableToFind, string getValue, List<string> condition)
        {
            string query = $"select {getValue} from {tableToFind} where {string.Join(" and ", condition)}";

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

        //Select 1 hoặc nhiều bản ghi với điều kiện fieldCondition like %keyword%
        public DataTable find(string tableToFind, List<string> getValue, string fieldCondition, string keyword)
        {
            string query = $"select {string.Join(", ", getValue)} from {tableToFind} where {fieldCondition} like '%{keyword}%'";

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

        //select tất cả bản ghi trong bảng 'tableToFind'
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

        //tạo 1 bản ghi mới trong bảng 'tableToCreate'.
        //  - Dictionary<string, string> columnValues:  `columnValues` là 1 đối tượng của `Dictionary`
        //  - mỗi 1 giá trị của `columnValues` là 1 cặp `key-value`
        //  - <string, string>: là kiểu dữ liệu tương ứng của key & value
        public bool create(string tableToCreate, Dictionary<string, object> columnValues)
        {
            string query = $"INSERT INTO {tableToCreate} VALUES ({string.Join(", ", columnValues.Keys.Select(key => "@" + key))})";

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
                    int i = 0;
                    try
                    {
                        i = command.ExecuteNonQuery();
                        return i > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"---Thêm thất bại!!---\n{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }


        //Cập nhật lại giá trị của 1 bản ghi trong bảng `tableNameToUpdate` với điều kiện là `condition`
        public bool update(string tableNameToUpdate, Dictionary<string, object> columnValues, string condition)
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
                    try
                    {
                        int i = command.ExecuteNonQuery();
                        return i > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"---Cập nhật thất bại!!---\n{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }


        //Xóa 1 bản ghi trong bảng `tableToDelete` với điều kiện fieldCondition = 'keyword'
        public bool delete(string tableToDelete, string fieldCondition, string keyword)
        {
            string query = $"delete from {tableToDelete} where {fieldCondition} = '{keyword}'";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    int i = 0;
                    try
                    {
                        i = cmd.ExecuteNonQuery();
                        return i > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"---Xóa thất bại!!---\n{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
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
