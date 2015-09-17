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
    public partial class ProjectsForm : Form
    {
        private MainForm mainform = null;
        private DataAppCore db = null;
        private Project currentProject = null; 


        public ProjectsForm(MainForm form)
        {
            InitializeComponent();
            mainform = form;
            db = mainform.DataAppCore;
            currentProject = new Project();
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


            var rawDataList = db.ProjectController.Get().ToList();

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

            List<ProjectViewModel> result = new List<ProjectViewModel>();

            foreach (var item in rawDataList)
            {
                result.Add(new ProjectViewModel(item));
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

            currentProject = new Project();

            buttonDetailsUpdate.Enabled = false;
            buttonDetailsDelete.Enabled = false;
            buttonDetailsAdd.Enabled = true;
        }

        void MapObjectToControls()
        {
            if(currentProject != null)
            {
                numericUpDownDetailsID.Value = currentProject.Id;
                textBoxDetailsName.Text = currentProject.Name;
                textBoxDetailsDescription.Text = currentProject.Description  ;
            }
        }

        void MapControlsToObject()
        {
            currentProject.Id = Convert.ToInt32(numericUpDownDetailsID.Value);
            currentProject.Name = textBoxDetailsName.Text;
            currentProject.Description = textBoxDetailsDescription.Text;
        }


        private void TogleUpdateButtons()
        {
            if (tabControlMain.SelectedTab.Name == "tabPageDetails")
            {
                if (currentProject.Id == 0)
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

                    if(currentProject.IsHidden == true )
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

        private void SaveDataToDB(bool isUpdate=false)
        {
            try
            {
                if(isUpdate == false)
                    currentProject = new Project();

                //map controls to object
                MapControlsToObject();

                //validate
                if (string.IsNullOrEmpty(currentProject.Name) || string.IsNullOrEmpty(currentProject.Description))
                {
                    MessageBox.Show("Please check empty input fields.");
                    return;
                }

                bool result = false;

                if (isUpdate == false)
                    result = db.ProjectController.Add(currentProject);
                else
                    result = db.ProjectController.Update(currentProject);

                if (result)
                {
                    if (isUpdate == false)
                        currentProject = db.ProjectController.Get(currentProject.Id);

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
            if (currentProject != null)
                currentProject.IsHidden = true;

            if (db.ProjectController.Update(currentProject))
                mainform.WriteStatusBar("Record saved...");
            else
                mainform.WriteStatusBar("Saving failed...");
        }

        private void UnhideObject()
        {
            if (currentProject != null)
                currentProject.IsHidden = false;

            if (db.ProjectController.Update(currentProject))
                mainform.WriteStatusBar("Record saved...");
            else
                mainform.WriteStatusBar("Saving failed...");
        }

        private void EditSelectedObject()
        {
            if (this.contextMenuStripGridView.Items[0].Selected)
            {
                int selectedRowId = 0;

                foreach (DataGridViewRow row in dataGridViewMainSearchResult.SelectedRows)
                {
                    int.TryParse(row.Cells[0].Value.ToString(), out selectedRowId);
                }

                //fetch data
                this.currentProject = db.ProjectController.Get(selectedRowId);

                MapObjectToControls();
                tabControlMain.SelectedIndex = 1;
            }
        }
        #endregion

        #endregion


        #region EVENTS

        #region SEARCH
        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            LoadSearchResultToGrid();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadSearchResultToGrid();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            ResetSearchFilters();
        }

        #endregion

        #region UPDATE
        private void buttonDetailsSaveChanges_Click(object sender, EventArgs e)
        {
            SaveDataToDB();
            //LoadDataToGrid();
        }

        private void buttonDetailsReset_Click(object sender, EventArgs e)
        {
            ResetDetailsPane();
        }

        private void buttonDetailsDelete_Click(object sender, EventArgs e)
        {
            HideObject();
            //LoadDataToGrid();

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            TogleUpdateButtons();
        }

        private void buttonDetailsUpdate_Click(object sender, EventArgs e)
        {
            SaveDataToDB(true);
            //LoadDataToGrid();
        }

        private void buttonDetailsUnhide_Click(object sender, EventArgs e)
        {
            UnhideObject();
        }
        #endregion


        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            EditSelectedObject();
        }
        #endregion



    }
}
