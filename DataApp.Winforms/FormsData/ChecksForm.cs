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
    public partial class ChecksForm : Form
    {
        MainForm mainform = null;
        private DataAppCore db = null;
        private Check currentModel = null; 

        public ChecksForm(MainForm form)
        {
            InitializeComponent();
            mainform = form;
            db = mainform.DataAppCore;
            currentModel = new Check();
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
            string keyword = textBoxFilterSearch.Text;
            int maxRows = (Int32)numericUpDownFilterMaxRow.Value;
            int counter = 0;

            var rawDataList = db.CheckController.Get().ToList();

            if (includeHiddenProjects == false)
                rawDataList = rawDataList.Where(x => x.IsHidden == false).ToList();

            if (projectID > 0)
                rawDataList = rawDataList.Where(x => x.Id == projectID).ToList();


            if (String.IsNullOrEmpty(keyword) == false)
            {
                keyword = keyword.ToLower();
                rawDataList = rawDataList.Where(x =>
                    x.Amount.ToString().ToLower().Contains(keyword)
                    || x.DueOn.ToShortDateString().ToLower().Contains(keyword)
                    || x.EntryOn.ToShortDateString().ToLower().Contains(keyword)
                    || x.IssuedOn.ToShortDateString().ToLower().Contains(keyword)
                    || x.Notes.ToLower().Contains(keyword)
                    || x.Payee.Name.ToLower().Contains(keyword)
                    || x.VoucherNumber.ToLower().Contains(keyword)
                    ).ToList();
            }

            List<ChecksViewModel> result = new List<ChecksViewModel>();

            foreach (var item in rawDataList)
            {
                result.Add(new ChecksViewModel(item));
                counter++;
                if (counter >= maxRows)
                    break;
            }

            dataGridViewMainSearchResult.DataSource = result;
            mainform.WriteStatusBar(String.Format("Total Rows : {0}", result.Count));
        }

        void ResetSearchFilters()
        {
            this.textBoxFilterSearch.Text = "";
            this.numericUpDownFilterId.Value = 0;
            this.numericUpDownFilterMaxRow.Value = 100;
            this.FilterCheckBoxIncludeHidden.Checked = false;
        }

        void LoadDataToComboBoxes()
        {
            comboBoxDetailsPayee.ValueMember = "Id";
            comboBoxDetailsPayee.DisplayMember = "Name";
            comboBoxDetailsPayee.DataSource = db.CompanyController.Get().ToList();
        }

        #endregion

        #region UPDATE

        void ResetDetailsPane()
        {
            textBoxDetailsDescription.Text = "";
            numericUpDownDetailsID.Value = 0;
            textBoxDetailsVoucherNumber.Text = "";
            comboBoxDetailsPayee.SelectedIndex = 0;
            dateTimePickerDetailsIssuedDate.Value = DateTime.Now.Date;
            dateTimePickerDetailsDueDate.Value = DateTime.Now.Date;
            numericUpDownDetailsAmount.Value = 0;

            currentModel = new Check();


            buttonDetailsUpdate.Enabled = false;
            buttonDetailsDelete.Enabled = false;
            buttonDetailsAdd.Enabled = true;
        }

        //OBJECT -> CONTROLS
        void MapObjectToControls()
        {
            if (currentModel != null)
            {
                textBoxDetailsDescription.Text = currentModel.Notes;
                numericUpDownDetailsID.Value = currentModel.Id;
                textBoxDetailsVoucherNumber.Text = currentModel.VoucherNumber;
                dateTimePickerDetailsIssuedDate.Value = currentModel.IssuedOn.Date;
                dateTimePickerDetailsDueDate.Value = currentModel.DueOn.Date;
                numericUpDownDetailsAmount.Value = currentModel.Amount;

                comboBoxDetailsPayee.SelectedValue = currentModel.PayeeId;
            }
        }

        void MapControlsToObject()
        {
            //currentModel.Id = Convert.ToInt32(numericUpDownDetailsID.Value);
            //currentModel.Name = textBoxDetailsName.Text;
            //currentModel.Description = textBoxDetailsDescription.Text;
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
                    currentModel = new Check();

                //map controls to object
                MapControlsToObject();

                //validate
                if (string.IsNullOrEmpty(currentModel.VoucherNumber) || string.IsNullOrEmpty(currentModel.Notes))
                {
                    MessageBox.Show("Please check empty input fields.");
                    return;
                }

                bool result = false;

                if (isUpdate == false)
                    result = db.CheckController.Add(currentModel);
                else
                    result = db.CheckController.Update(currentModel);

                if (result)
                {
                    if (isUpdate == false)
                        currentModel = db.CheckController.Get(currentModel.Id);

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

            if (db.CheckController.Update(currentModel))
                mainform.WriteStatusBar("Record saved...");
            else
                mainform.WriteStatusBar("Saving failed...");
        }

        private void UnhideObject()
        {
            if (currentModel != null)
                currentModel.IsHidden = false;

            if (db.CheckController.Update(currentModel))
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
                this.currentModel = db.CheckController.Get(selectedRowId);

                MapObjectToControls();
                tabControlMain.SelectedIndex = 1;
            }

            //add 
            if (this.contextMenuStripGridView.Items[1].Selected)
            {
                ResetDetailsPane();
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
            LoadDataToComboBoxes();
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
            ResetDetailsPane();
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

        private void ChecksForm_Activated(object sender, EventArgs e)
        {
            LoadDataToComboBoxes();
        }
    }
}
