using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        PrivateFontCollection pfc;
        private void Welcome_Load(object sender, EventArgs e)
        {
            pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"UVF_SlimTony.ttf");
            label1.Font = new Font(pfc.Families[0], 23);
            label2.Font = new Font(pfc.Families[0], 23);
            label3.Font = new Font(pfc.Families[0], 23);
        }
    }
}
