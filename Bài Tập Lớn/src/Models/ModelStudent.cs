using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Models
{
    public static class ModelStudent
    {
        public const int maSinhVien = 0;
        public const int hoTen = 1;
        public const int tenLop = 2;
        public const int khoa = 3;
        public const int tenNganh = 4;
        public const int ngaySinh = 5;
        public const int gioiTinh = 6;
        public const int diaChi = 7;
        public const int sdt = 8;
        public const int cccd = 9;
        public const int email = 10;

        public static string getFieldName(int index)
        {
            switch (index)
            {
                case maSinhVien:
                    return "maSinhVien";
                case hoTen:
                    return "hoTen";
                case tenLop:
                    return "tenLop";
                case khoa:
                    return "khoa";
                case tenNganh:
                    return "tenNganh";
                case ngaySinh:
                    return "ngaySinh";
                case gioiTinh:
                    return "gioiTinh";
                case diaChi:
                    return "diaChi";
                case sdt:
                    return "sdt";
                case cccd:
                    return "cccd";
                case email:
                    return "email";
                default:
                    throw new ArgumentException("Invalid field index value!");
            }
        }
}
}
