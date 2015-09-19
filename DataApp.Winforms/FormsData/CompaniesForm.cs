using DataApp.Core;
using DataApp.Core.Models;
using DataApp.Winforms.ViewModels.DataGridViewModels;
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
    public partial class CompaniesForm : Form
    {
        private MainForm mainform = null;
        private DataAppCore db = null;
        private Company currentModel = null; 

        public CompaniesForm(MainForm form)
        {
            InitializeComponent();
            mainform = form;
            db = mainform.DataAppCore;
            currentModel = new Company();
            //set data grid settings
            ControlFactory.SetDataGridSettings(this.dataGridViewMainSearchResult);
        }

        #region CUSTOM CODE

        #region SEARCH

        void LoadSearchResultToGrid()
        {
            //TODO: check filters
            int projectID = Convert.ToInt32(numericUpDownFilterId.Value);
            bool includeHiddenProjects = FilterCheckBoxIncludeHidden.Checked;
            string projectName = textBoxFilterName.Text;


            var rawDataList = db.CompanyController.Get().ToList();

            if (projectID > 0)
            {
                rawDataList = rawDataList.Where(x => x.Id == projectID).ToList();
            }

            if (String.IsNullOrEmpty(projectName) == false)
            {
                projectName = projectName.ToLower();
                rawDataList = rawDataList.Where(x => x.Name.ToLower() == projectName).ToList();
            }

            if (includeHiddenProjects == false)
            {
                rawDataList = rawDataList.Where(x => x.IsHidden == false).ToList();
            }

            List<CompanyViewModel> result = new List<CompanyViewModel>();

            foreach (var item in rawDataList)
            {
                result.Add(new CompanyViewModel(item));
            }

            dataGridViewMainSearchResult.DataSource = result;
            mainform.WriteStatusBar(String.Format("Total Rows : {0}", result.Count));
        }

        void ResetSearchFilters()
        {
            this.textBoxFilterName.Text = "";
            this.numericUpDownFilterId.Value = 0;
            this.numericUpDownFilterMaxRow.Value = 100;
            this.FilterCheckBoxIncludeHidden.Checked = false;


        }

        #endregion

        #region UPDATE

        void ResetDetailsPane()
        {
            textBoxDetailsDescription.Text = "";
            numericUpDownDetailsID.Value = 0;
            textBoxDetailsDescription.Text = "";
            textBoxDetailsName.Text = "";
            textBoxDetailsContact.Text = "";
            textBoxDetailsEmail.Text = "";

            currentModel = new Company();

            buttonDetailsUpdate.Visible = false;
            buttonDetailsDelete.Visible = false;

            buttonDetailsUpdate.Enabled = false;
            buttonDetailsDelete.Enabled = false;
            buttonDetailsAdd.Enabled = true;
        }

        void MapObjectToControls()
        {
            if (currentModel != null)
            {
                numericUpDownDetailsID.Value = currentModel.Id;
                textBoxDetailsName.Text = currentModel.Name;
                textBoxDetailsDescription.Text = currentModel.Description;
                textBoxDetailsContact.Text = currentModel.Contact;
                textBoxDetailsEmail.Text = currentModel.Email;
            }
        }

        void MapControlsToObject()
        {
            currentModel.Id = Convert.ToInt32(numericUpDownDetailsID.Value);
            currentModel.Name = textBoxDetailsName.Text;
            currentModel.Description = textBoxDetailsDescription.Text;
            currentModel.Contact = textBoxDetailsContact.Text;
            currentModel.Email = textBoxDetailsEmail.Text;
        }


        private void TogleUpdateButtons()
        {
            if (tabControlMain.SelectedTab.Name == "tabPageDetails")
            {
                if (currentModel.Id == 0)
                {
                    buttonDetailsUpdate.Enabled = false;
                    buttonDetailsDelete.Enabled = false;
                    buttonDetailsAdd.Enabled = true;

                    buttonDetailsUnhide.Enabled = false;
                    buttonDetailsUnhide.Visible = false;
                }
                else
                {
                    buttonDetailsUpdate.Enabled = true;
                    buttonDetailsDelete.Enabled = true;
                    buttonDetailsAdd.Enabled = false;

                    if (currentModel.IsHidden == true)
                    {
                        buttonDetailsUnhide.Visible = true;
                        buttonDetailsUnhide.Enabled = true;
                        buttonDetailsDelete.Enabled = false;
                        buttonDetailsDelete.Visible = false;
                    }
                    else
                    {
                        buttonDetailsUnhide.Visible = false;
                        buttonDetailsUnhide.Enabled = false;
                        buttonDetailsDelete.Enabled = true;
                        buttonDetailsDelete.Visible = true;
                    }
                }
            }
        }

        private void SaveDataToDB(bool isUpdate = false)
        {
            try
            {
                if (isUpdate == false)
                    currentModel = new Company();

                //map controls to object
                MapControlsToObject();

                //validate
                if (string.IsNullOrEmpty(currentModel.Name) || string.IsNullOrEmpty(currentModel.Description))
                {
                    MessageBox.Show("Please check empty input fields.");
                    return;
                }

                bool result = false;

                if (isUpdate == false)
                    result = db.CompanyController.Add(currentModel);
                else
                    result = db.CompanyController.Update(currentModel);

                if (result)
                {
                    if (isUpdate == false)
                        currentModel = db.CompanyController.Get(currentModel.Id);

                    //map 
                    MapObjectToControls();
                    TogleUpdateButtons();
                    mainform.WriteStatusBar("Record saved...");
                }
                else
                {
                    mainform.WriteStatusBar("Saving failed...");
                    MessageBox.Show("Saving failed...");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void HideObject()
        {
            if (currentModel != null)
                currentModel.IsHidden = true;

            if (db.CompanyController.Update(currentModel))
                mainform.WriteStatusBar("Record saved...");
            else
                mainform.WriteStatusBar("Saving failed...");
        }

        private void UnhideObject()
        {
            if (currentModel != null)
                currentModel.IsHidden = false;

            if (db.CompanyController.Update(currentModel))
                mainform.WriteStatusBar("Record saved...");
            else
                mainform.WriteStatusBar("Saving failed...");
        }

        private void EditSelectedObject()
        {
            //update
            if (this.contextMenuStripGridView.Items[0].Selected)
            {
                int selectedRowId = 0;

                foreach (DataGridViewRow row in dataGridViewMainSearchResult.SelectedRows)
                {
                    int.TryParse(row.Cells[0].Value.ToString(), out selectedRowId);
                }

                //fetch data
                this.currentModel = db.CompanyController.Get(selectedRowId);

                MapObjectToControls();
                tabControlMain.SelectedIndex = 1;
            }

            //add 
            if(this.contextMenuStripGridView.Items[1].Selected)
            {
                ResetDetailsPane();
                tabControlMain.SelectedIndex = 1;
            }
        }
        #endregion

        #endregion

        #region EVENTS

        #region SEARCH
        private void buttonSearchFilter_Click(object sender, EventArgs e)
        {
            LoadSearchResultToGrid();

        }

        private void buttonFilterClearFilters_Click(object sender, EventArgs e)
        {
            ResetSearchFilters();
        }

        private void CompaniesForm_Load(object sender, EventArgs e)
        {
            LoadSearchResultToGrid();

        }

        #endregion

        #region UPDATE
        private void buttonDetailsDelete_Click(object sender, EventArgs e)
        {
            HideObject();
        }

        private void buttonDetailsUnhide_Click(object sender, EventArgs e)
        {
            UnhideObject();
        }

        private void buttonDetailsUpdate_Click(object sender, EventArgs e)
        {
            SaveDataToDB(true);
        }

        private void buttonDetailsAdd_Click(object sender, EventArgs e)
        {
            SaveDataToDB();
            ResetDetailsPane();
        }

        private void buttonDetailsReset_Click(object sender, EventArgs e)
        {
            ResetDetailsPane();
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            TogleUpdateButtons();
        }
        #endregion

        private void contextMenuStripGridView_Click(object sender, EventArgs e)
        {
            EditSelectedObject();
        }

        #endregion

    }
}