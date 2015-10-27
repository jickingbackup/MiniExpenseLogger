namespace DataApp.Winforms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lognoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pROJECTSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPENSESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANIESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.pROJECTSToolStripMenuItem1,
            this.cHECKSToolStripMenuItem1,
            this.eXPENSESToolStripMenuItem1,
            this.cOMPANIESToolStripMenuItem1,
            this.rEPORTSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUserDetailsToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.lognoutToolStripMenuItem});
            this.userToolStripMenuItem.Image = global::DataApp.Winforms.Properties.Resources.settings_32;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.userToolStripMenuItem.Text = "SETTINGS";
            // 
            // updateUserDetailsToolStripMenuItem
            // 
            this.updateUserDetailsToolStripMenuItem.Image = global::DataApp.Winforms.Properties.Resources.user;
            this.updateUserDetailsToolStripMenuItem.Name = "updateUserDetailsToolStripMenuItem";
            this.updateUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.updateUserDetailsToolStripMenuItem.Text = "Update User Details";
            this.updateUserDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateUserDetailsToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Image = global::DataApp.Winforms.Properties.Resources.user;
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // lognoutToolStripMenuItem
            // 
            this.lognoutToolStripMenuItem.Image = global::DataApp.Winforms.Properties.Resources.disconnected_32;
            this.lognoutToolStripMenuItem.Name = "lognoutToolStripMenuItem";
            this.lognoutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.lognoutToolStripMenuItem.Text = "Logout";
            this.lognoutToolStripMenuItem.Click += new System.EventHandler(this.lognoutToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.Image = global::DataApp.Winforms.Properties.Resources.reports;
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel1.Text = "----";
            // 
            // pROJECTSToolStripMenuItem1
            // 
            this.pROJECTSToolStripMenuItem1.Image = global::DataApp.Winforms.Properties.Resources.projects;
            this.pROJECTSToolStripMenuItem1.Name = "pROJECTSToolStripMenuItem1";
            this.pROJECTSToolStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.pROJECTSToolStripMenuItem1.Text = "PROJECTS";
            this.pROJECTSToolStripMenuItem1.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // cHECKSToolStripMenuItem1
            // 
            this.cHECKSToolStripMenuItem1.Image = global::DataApp.Winforms.Properties.Resources.checks;
            this.cHECKSToolStripMenuItem1.Name = "cHECKSToolStripMenuItem1";
            this.cHECKSToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.cHECKSToolStripMenuItem1.Text = "CHECKS";
            this.cHECKSToolStripMenuItem1.Click += new System.EventHandler(this.checksToolStripMenuItem_Click);
            // 
            // eXPENSESToolStripMenuItem1
            // 
            this.eXPENSESToolStripMenuItem1.Image = global::DataApp.Winforms.Properties.Resources.expense;
            this.eXPENSESToolStripMenuItem1.Name = "eXPENSESToolStripMenuItem1";
            this.eXPENSESToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.eXPENSESToolStripMenuItem1.Text = "EXPENSES";
            this.eXPENSESToolStripMenuItem1.Click += new System.EventHandler(this.expensesToolStripMenuItem_Click);
            // 
            // cOMPANIESToolStripMenuItem1
            // 
            this.cOMPANIESToolStripMenuItem1.Image = global::DataApp.Winforms.Properties.Resources.Companies;
            this.cOMPANIESToolStripMenuItem1.Name = "cOMPANIESToolStripMenuItem1";
            this.cOMPANIESToolStripMenuItem1.Size = new System.Drawing.Size(102, 20);
            this.cOMPANIESToolStripMenuItem1.Text = "COMPANIES";
            this.cOMPANIESToolStripMenuItem1.Click += new System.EventHandler(this.companiesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 501);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Expense Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lognoutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem pROJECTSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cHECKSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eXPENSESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cOMPANIESToolStripMenuItem1;
    }
}