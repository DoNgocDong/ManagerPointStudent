using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.SubForm.ManagerStudent
{
    public partial class ActionDetail : Form
    {
        bool isAddStudentAction = ManagerStudent_EnviromentVariable.isAddStudentAction;
        public ActionDetail()
        {
            InitializeComponent();
        }

        private void ActionDetail_Load(object sender, EventArgs e)
        {
            setUpDisplay(isAddStudentAction);
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {

        }

        private void setUpDisplay(bool check)
        {
            if(check){
                actionBtn.Text = "Thêm Sinh Viên";
            }
            else{
                actionBtn.Text = "Lưu thay đổi";
            }
        }
    }
}
