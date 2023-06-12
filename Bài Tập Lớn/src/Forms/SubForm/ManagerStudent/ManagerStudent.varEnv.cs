using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Forms.SubForm.ManagerStudent
{
    public static class ManagerStudent_EnviromentVariable
    {
        public static string tableName = Globals.tableStudent;
        public static string selectedMaSV = "";
        public static string primaryKeyName = "maSinhVien";
        public static bool isAddStudentAction = true;        
    }
}
