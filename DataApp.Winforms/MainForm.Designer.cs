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
            this.rECORDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.rECORDSToolStripMenuItem,
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
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.userToolStripMenuItem.Text = "SETTINGS";
            // 
            // updateUserDetailsToolStripMenuItem
            // 
            this.updateUserDetailsToolStripMenuItem.Name = "updateUserDetailsToolStripMenuItem";
            this.updateUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.updateUserDetailsToolStripMenuItem.Text = "Update User Details";
            this.updateUserDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateUserDetailsToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // lognoutToolStripMenuItem
            // 
            this.lognoutToolStripMenuItem.Name = "lognoutToolStripMenuItem";
            this.lognoutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.lognoutToolStripMenuItem.Text = "Logout";
            this.lognoutToolStripMenuItem.Click += new System.EventHandler(this.lognoutToolStripMenuItem_Click);
            // 
            // rECORDSToolStripMenuItem
            // 
            this.rECORDSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.checksToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.companiesToolStripMenuItem});
            this.rECORDSToolStripMenuItem.Name = "rECORDSToolStripMenuItem";
            this.rECORDSToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.rECORDSToolStripMenuItem.Text = "RECORDS";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.companiesToolStripMenuItem.Text = "Companies";
            this.companiesToolStripMenuItem.Click += new System.EventHandler(this.companiesToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expensesToolStripMenuItem.Text = "Expenses";
            this.expensesToolStripMenuItem.Click += new System.EventHandler(this.expensesToolStripMenuItem_Click);
            // 
            // checksToolStripMenuItem
            // 
            this.checksToolStripMenuItem.Name = "checksToolStripMenuItem";
            this.checksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checksToolStripMenuItem.Text = "Checks";
            this.checksToolStripMenuItem.Click += new System.EventHandler(this.checksToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
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
        private System.Windows.Forms.ToolStripMenuItem rECORDSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}