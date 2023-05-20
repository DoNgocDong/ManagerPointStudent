using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Controller.Forms
{
    public class FormController
    {
        public void hideAndShow(Form hiddenForm, Form displayForm)
        {
            hiddenForm.Hide();
            displayForm.Show();
        }

        public void closeAndShow(Form closeForm, Form displayForm)
        {
            closeForm.Close();
            displayForm.Show();
        }
        public void addForm(Form childForm, Panel placeShow)
        {
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            placeShow.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
