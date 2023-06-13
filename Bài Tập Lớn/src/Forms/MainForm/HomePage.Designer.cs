namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manaMajorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manaClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manaStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manaCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manaScoreStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scholarshipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayMenuFormPanel = new System.Windows.Forms.Panel();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.toolsMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1163, 28);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.actionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.viewScoreToolStripMenuItem});
            this.actionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.actionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.actionToolStripMenuItem.Text = "Hành động";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewProfileToolStripMenuItem.Text = "Xem hồ sơ";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // viewScoreToolStripMenuItem
            // 
            this.viewScoreToolStripMenuItem.Name = "viewScoreToolStripMenuItem";
            this.viewScoreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewScoreToolStripMenuItem.Text = "Xem điểm";
            this.viewScoreToolStripMenuItem.Click += new System.EventHandler(this.viewScoreToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.managerToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manaMajorsToolStripMenuItem,
            this.manaClassToolStripMenuItem,
            this.manaStudentToolStripMenuItem,
            this.manaCourseToolStripMenuItem,
            this.manaScoreStripMenuItem});
            this.managerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.managerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.managerToolStripMenuItem.Text = "Quản lý";
            // 
            // manaMajorsToolStripMenuItem
            // 
            this.manaMajorsToolStripMenuItem.Name = "manaMajorsToolStripMenuItem";
            this.manaMajorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manaMajorsToolStripMenuItem.Text = "Chuyên ngành";
            this.manaMajorsToolStripMenuItem.Click += new System.EventHandler(this.manaMajorsToolStripMenuItem_Click);
            // 
            // manaClassToolStripMenuItem
            // 
            this.manaClassToolStripMenuItem.Name = "manaClassToolStripMenuItem";
            this.manaClassToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manaClassToolStripMenuItem.Text = "Lớp học";
            this.manaClassToolStripMenuItem.Click += new System.EventHandler(this.manaClassToolStripMenuItem_Click);
            // 
            // manaStudentToolStripMenuItem
            // 
            this.manaStudentToolStripMenuItem.Name = "manaStudentToolStripMenuItem";
            this.manaStudentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manaStudentToolStripMenuItem.Text = "Sinh viên";
            this.manaStudentToolStripMenuItem.Click += new System.EventHandler(this.manaStudentToolStripMenuItem_Click);
            // 
            // manaCourseToolStripMenuItem
            // 
            this.manaCourseToolStripMenuItem.Name = "manaCourseToolStripMenuItem";
            this.manaCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manaCourseToolStripMenuItem.Text = "Môn học";
            this.manaCourseToolStripMenuItem.Click += new System.EventHandler(this.manaCourseToolStripMenuItem_Click);
            // 
            // manaScoreStripMenuItem
            // 
            this.manaScoreStripMenuItem.Name = "manaScoreStripMenuItem";
            this.manaScoreStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manaScoreStripMenuItem.Text = "Điểm";
            this.manaScoreStripMenuItem.Click += new System.EventHandler(this.manaScoreStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.systemToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.systemToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.systemToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.systemToolStripMenuItem.Text = "Hệ thống";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changePasswordToolStripMenuItem.Text = "Đổi mật khẩu";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "Đăng xuất";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scholarshipMenuItem});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(77, 24);
            this.toolsMenuItem.Text = "Công cụ";
            // 
            // scholarshipMenuItem
            // 
            this.scholarshipMenuItem.Name = "scholarshipMenuItem";
            this.scholarshipMenuItem.Size = new System.Drawing.Size(224, 26);
            this.scholarshipMenuItem.Text = "Xét học bổng";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.helpToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.helpToolStripMenuItem.Text = "Trợ giúp";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // displayMenuFormPanel
            // 
            this.displayMenuFormPanel.BackColor = System.Drawing.Color.White;
            this.displayMenuFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayMenuFormPanel.Location = new System.Drawing.Point(0, 28);
            this.displayMenuFormPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayMenuFormPanel.Name = "displayMenuFormPanel";
            this.displayMenuFormPanel.Size = new System.Drawing.Size(1163, 542);
            this.displayMenuFormPanel.TabIndex = 4;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1163, 570);
            this.Controls.Add(this.displayMenuFormPanel);
            this.Controls.Add(this.mainMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manaStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manaClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manaCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manaScoreStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel displayMenuFormPanel;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scholarshipMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manaMajorsToolStripMenuItem;
    }
}