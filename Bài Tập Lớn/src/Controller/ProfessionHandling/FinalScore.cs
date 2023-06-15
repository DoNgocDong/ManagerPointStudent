using BaiTapLon_CSharp.src.Models;
using BaiTapLon_CSharp.src.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Controller.ProfessionHandling
{
    public class FinalScore
    {        
        public FinalScore() {}

        public float getDiemTK_1Mon(Dictionary<string, float> listScore)
        {
            float diemGK = 0f;
            float diemCK = 0f;
            float diemTP = 0f;

            foreach (var score in listScore) {
                if (score.Key == "diemCK")
                    diemCK += Convert.ToSingle(score.Value) * 0.7f;
                else if (score.Key == "diemGK")
                    diemGK += Convert.ToSingle(score.Value) * 0.2f;
                else
                    diemTP += Convert.ToSingle(score.Value);
            }
            diemTP = (diemTP / 2.0f) * 0.1f;

            float data = diemCK + diemGK + diemTP;

            return data;
        }

        public float getDiemTK_list(List<float> listScore)
        {
            float data = 0f;

            foreach(var score in listScore)
            {
                data += score;
            }

            data /= listScore.Count;

            return data;
        }

        public string getDiemChu(float diemTK)
        {
            if (diemTK >= 8.5f)
                return DiemChu.getFieldName(DiemChu.A);
            else if(diemTK >= 8.0f)
                return DiemChu.getFieldName(DiemChu.B_plus);
            else if (diemTK >= 7.0f)
                return DiemChu.getFieldName(DiemChu.B);
            else if (diemTK >= 6.5f)
                return DiemChu.getFieldName(DiemChu.C_plus);
            else if (diemTK >= 5.5f)
                return DiemChu.getFieldName(DiemChu.C);
            else if (diemTK >= 5.0f)
                return DiemChu.getFieldName(DiemChu.D_plus);
            else if (diemTK >= 4.0f)
                return DiemChu.getFieldName(DiemChu.D);
            else
                return DiemChu.getFieldName(DiemChu.F);
        }

        public string getDanhGia(string diemChu)
        {
            if (diemChu == "F")
                return DanhGia.getFieldName(DanhGia.KHONG_DAT);
            else
                return DanhGia.getFieldName(DanhGia.DAT);
        }
    }
}
