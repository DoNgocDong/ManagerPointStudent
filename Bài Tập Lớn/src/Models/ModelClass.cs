using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Models
{
    public static class ModelClass
    {
        public const int maLop = 0;
        public const int tenLop = 1;
        public const int tenNganh = 2;
        public const int khoa = 3;
        public const int gvChuNhiem = 4;

        public static string getFieldName(int index)
        {
            switch (index)
            {
                case maLop:
                    return "maLop";
                case tenLop:
                    return "tenLop";
                case tenNganh:
                    return "tenNganh";
                case khoa:
                    return "khoa";
                case gvChuNhiem:
                    return "gvChuNhiem";
                default:
                    throw new ArgumentException("Invalid field index value!");
            }
        }
    }
}
