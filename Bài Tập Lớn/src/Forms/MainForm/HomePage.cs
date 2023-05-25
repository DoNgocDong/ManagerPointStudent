﻿using BaiTapLon_CSharp.src.Controller.Forms;
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
        private void HomePage_Load(object sender, EventArgs e)
        {
            if(Globals.isAdmin == false)
                managerToolStripMenuItem.Visible = false;
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    LoginMethod loginMethod = new LoginMethod();
                    formController.hideAndShow(this, loginMethod);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();

            formController.addForm(changePassword, displayMenuFormPanel);
        }

        private void manaStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerStudent managerStudent = new ManagerStudent();

            formController.addForm(managerStudent, displayMenuFormPanel);
        }

        private void manaClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerClass managerClass = new ManagerClass();

            formController.addForm(managerClass, displayMenuFormPanel);
        }

        private void manaCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerCourse managerCourse = new ManagerCourse();

            formController.addForm(managerCourse, displayMenuFormPanel);
        }

        private void manaScoreStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerScore managerScore = new ManagerScore();

            formController.addForm(managerScore, displayMenuFormPanel);
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globals.isAdmin)
            {
                ViewForAdmin viewForAdmin = new ViewForAdmin();
                formController.addForm(viewForAdmin, displayMenuFormPanel);
            }
            else
            {
                ViewProfileStudent viewProfileStudent = new ViewProfileStudent();
                formController.addForm(viewProfileStudent, displayMenuFormPanel);
            }

        }

        private void viewScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.isAdmin)
            {
                ViewForAdmin viewForAdmin = new ViewForAdmin();
                formController.addForm(viewForAdmin, displayMenuFormPanel);
            }
            else
            {
                ViewScoreStudent viewScoreStudent = new ViewScoreStudent();
                formController.addForm(viewScoreStudent, displayMenuFormPanel);
            }
        }

      
    }
}
