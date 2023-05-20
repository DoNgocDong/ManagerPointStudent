using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Forms.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    public partial class HomePage : Form
    {
        FormController formController = new FormController();
        public HomePage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();

            formController.addForm(helpForm, displayMenuFormPanel);
        }
    }
}
