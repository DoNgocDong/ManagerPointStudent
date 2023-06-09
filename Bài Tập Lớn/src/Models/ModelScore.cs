﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BaiTapLon_CSharp.src.Models
{
    public static class ModelScore
    {
        public const int ID = 0;           
        public const int maSinhVien = 1;    
        public const int hoTen = 2;       
        public const int maMon = 3;
        public const int tenMon = 4;
        public const int diemCC = 5;
        public const int diemGK = 6;
        public const int diemTH = 7;
        public const int diemCK = 8;
        public const int diemTK = 9;
        public const int diemChu = 10;
        public const int danhGia = 11;
        public const int hocKy = 12;

        public static string getFieldName(int index)
        {
            switch (index)
            {
                case ID:
                    return "ID";
                case maSinhVien:
                    return "maSinhVien";
                case hoTen:
                    return "hoTen";
                case maMon:
                    return "maMon";
                case tenMon:
                    return "tenMon";
                case diemCC:
                    return "diemCC";
                case diemGK:
                    return "diemGK";
                case diemTH:
                    return "diemTH";
                case diemCK:
                    return "diemCK";
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
