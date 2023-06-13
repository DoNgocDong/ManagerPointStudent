using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Models
{
    public static class ModelReviews
    {
        public const int ID = 0;
        public const int maSinhVien = 1;
        public const int diemTK = 2;
        public const int diemChu = 3;
        public const int danhGia = 4;
        public const int hocKy = 5;

        public static string getFieldName(int index)
        {
            switch (index)
            {
                case ID:
                    return "ID";
                case maSinhVien:
                    return "maSinhVien";
                case diemTK:
                    return "diemTK";
                case diemChu:
                    return "diemChu";
                case danhGia:
                    return "danhGia";
                case hocKy:
                    return "hocKy";
                default:
                    throw new ArgumentException("Invalid field index value!");
            }
        }
    }
}
