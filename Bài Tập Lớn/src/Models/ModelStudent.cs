using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Models
{
    public class ModelStudent
    {
        public string maSinhVien { get; set; }
        public string hoTen { get; set; }
        public string tenLop { get; set; }
        public int khoa { get; set; }
        public string tenNganh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
        public string cccd { get; set; }
        public string email { get; set; }

        public ModelStudent() { }
    }
}
