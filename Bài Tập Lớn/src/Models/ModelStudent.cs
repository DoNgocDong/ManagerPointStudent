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

        public string getColumnName_maSinhVien() 
        {
            return "maSinhVien";
        }
        public string getColumnName_hoTen()
        {
            return "hoTen";
        }
        public string getColumnName_tenLop()
        {
            return "tenLop";
        }
        public string getColumnName_khoa()
        {
            return "khoa";
        }
        public string getColumnName_tenNganh()
        {
            return "tenNganh";
        }
        public string getColumnName_ngaySinh()
        {
            return "ngaySinh";
        }
        public string getColumnName_gioiTinh()
        {
            return "gioiTinh";
        }
        public string getColumnName_diaChi()
        {
            return "diaChi";
        }
        public string getColumnName_sdt()
        {
            return "sdt";
        }
        public string getColumnName_cccd()
        {
            return "cccd";
        }
        public string getColumnName_email()
        {
            return "email";
        }
    }
}
