using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Models
{
    public static class ModelsUserAccount
    {
        public const int maSinhVien = 0;
        public const int userName = 1;
        public const int userPassword = 2;

        public static string getFieldName(int index)
        {
            switch (index)
            {
                case maSinhVien:
                    return "maSinhVien";
                case userName:
                    return "userName";
                case userPassword:
                    return "userPassword";
                default:
                    throw new ArgumentException("Invalid field index value!");
            }
        }
    }
}
