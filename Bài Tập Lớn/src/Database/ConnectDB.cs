using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Database
{
    public class ConnectDB
    {
        private string stringConnection = "Data Source=DESKTOP-UE2RN9I\\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True";

        public ConnectDB() {}

        public string getConnectionString()
        {
            return this.stringConnection;
        }
    }
}
