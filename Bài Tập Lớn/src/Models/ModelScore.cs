using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Models
{
    public class ModelScore
    {
        public int ID { get; set; }
        public string maSinhVien { get; set; }
        public string hoTen { get; set; }
        public string maMon { get; set; }
        public string tenMon { get; set; }
        public double diemCC { get; set; }
        public double diemGK { get; set; }
        public double diemTH { get; set; }
        public double diemCK { get; set; }
        public double diemTK { get; set; }
        public string diemChu { get; set; }
        public string danhGia { get; set; }

        public ModelScore() { }
    }
}
