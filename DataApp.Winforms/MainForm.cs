using DataApp.Core;
using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApp.Winforms
{
    public partial class MainForm : Form
    {
        private User currentUser = null;
        private DataAppCore dataAppCore = null;

        public DataAppCore DataAppCore
        {
            get
            {
                return this.dataAppCore;
            }
        }

        //child forms
        ProjectsForm projectForm = null;
        ExpensesForm expensesForm = null;
        ChecksForm checksForm = null;
        CompaniesForm companiesForm = null;


        public MainForm()
        {
            InitializeComponent();
            this.dataAppCore = DataAppFactory.Create();
        }

        #region CUSTOM CODE
        
        private void SignOutUser()
        {
            if (currentUser == null)
                return;

            this.dataAppCore.UserController.Logout(currentUser.Id);
            this.currentUser = null;

            //clear all mdi children
        }

        private void DisplayLoginForm()
        {
            if (currentUser == null)
            {
                using (var loginForm = FormFactory.CreateLoginForm(this))
                {
                    this.Hide();
                    loginForm.ShowDialog();
                }
            }
        }

        void DisplayProjectsForm()
        {
            if (projectForm == null || projectForm.IsDisposed)
            {
                this.projectForm = FormFactory.CreateProjectsForm(this);
                projectForm.MdiParent = this;
            }
            projectForm.Show();
        }

        void DisplayExpensesForm()
        {
            if (expensesForm == null || expensesForm.IsDisposed)
            {
                this.expensesForm = FormFactory.CreateExpensesForm(this);
                expensesForm.MdiParent = this;
            }
            expensesForm.Show();
        }

        void DisplayChecksForm()
        {
            if (checksForm == null || checksForm.IsDisposed)
            {
                this.checksForm = FormFactory.CreateChecksForm(this);
                checksForm.MdiParent = this;
            }
            checksForm.Show();
        }

        void DisplayCompaniesForm()
        {
            if (companiesForm == null || companiesForm.IsDisposed)
            {
                this.companiesForm = FormFactory.CreateCompaniesForm(this);
                companiesForm.MdiParent = this;
            }
            companiesForm.Show();
        }

        void HideAllForm()
        {
            foreach (var item in this.MdiChildren)
            {
                item.Hide();
            }
        }

        //PUBLIC METHODS
        public void WriteStatusBar(string message = null)
        {
            if (message == null)
            {
                toolStripStatusLabel1.Text = "----";
                return;
            }

            toolStripStatusLabel1.Text = message;
        }

        //ExpensesForm
        #endregion

        #region EVENTS
        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayLoginForm();
        }

        private void lognoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignOutUser();
            DisplayLoginForm();
        } 
        #endregion


        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForm();
            DisplayProjectsForm();
            WriteStatusBar();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForm();
            DisplayExpensesForm();
            WriteStatusBar();
            MessageBox.Show("To be implemented.");

        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForm();
            DisplayCompaniesForm();
            WriteStatusBar();
            //MessageBox.Show("To be implemented.");

        }

        private void checksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForm();
            DisplayChecksForm();
            WriteStatusBar();
            //MessageBox.Show("To be implemented.");
        }

        public enum StatusBarCode
        {
            success,failed,invalid
        }

        private void updateUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented.");
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented.");
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented.");
        }
    }
}
