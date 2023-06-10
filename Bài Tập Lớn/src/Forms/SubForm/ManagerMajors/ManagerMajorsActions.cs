using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Forms.SubForm.ManagerStudent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.SubForm.ManagerMajors
{
    public partial class ManagerMajorsActions : Form
    {
        private FormController controller = new FormController();
        private bool isAddMajorsAction = ManagerMajors_EnviromentVariable.isAddMajorsAction;
        public ManagerMajorsActions()
        {
            InitializeComponent();
        }
    }
}
