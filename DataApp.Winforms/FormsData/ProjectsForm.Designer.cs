namespace DataApp.Winforms
{
    public partial class ProjectsForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.dataGridViewMainSearchResult = new System.Windows.Forms.DataGridView();
            this.contextMenuStripGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditRow = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FilterCheckBoxIncludeHidden = new System.Windows.Forms.CheckBox();
            this.numericUpDownFilterId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFilterClearFilters = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFilterMaxRow = new System.Windows.Forms.NumericUpDown();
            this.buttonSearchFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonDetailsUnhide = new System.Windows.Forms.Button();
            this.buttonDetailsUpdate = new System.Windows.Forms.Button();
            this.buttonDetailsDelete = new System.Windows.Forms.Button();
            this.buttonDetailsAdd = new System.Windows.Forms.Button();
            this.buttonDetailsReset = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.numericUpDownDetailsID = new System.Windows.Forms.NumericUpDown();
            this.textBoxDetailsDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDetailsName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripMenuItemAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainSearchResult)).BeginInit();
            this.contextMenuStripGridView.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterMaxRow)).BeginInit();
            this.tabPageDetails.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsID)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSearch);
            this.tabControlMain.Controls.Add(this.tabPageDetails);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(624, 381);
            this.tabControlMain.TabIndex = 3;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.dataGridViewMainSearchResult);
            this.tabPageSearch.Controls.Add(this.groupBox2);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(616, 355);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMainSearchResult
            // 
            this.dataGridViewMainSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMainSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMainSearchResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridViewMainSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainSearchResult.ContextMenuStrip = this.contextMenuStripGridView;
            this.dataGridViewMainSearchResult.Location = new System.Drawing.Point(8, 135);
            this.dataGridViewMainSearchResult.MultiSelect = false;
            this.dataGridViewMainSearchResult.Name = "dataGridViewMainSearchResult";
            this.dataGridViewMainSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMainSearchResult.ShowEditingIcon = false;
            this.dataGridViewMainSearchResult.Size = new System.Drawing.Size(602, 212);
            this.dataGridViewMainSearchResult.StandardTab = true;
            this.dataGridViewMainSearchResult.TabIndex = 6;
            // 
            // contextMenuStripGridView
            // 
            this.contextMenuStripGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditRow,
            this.toolStripMenuItemAddNew});
            this.contextMenuStripGridView.Name = "contextMenuStrip1";
            this.contextMenuStripGridView.Size = new System.Drawing.Size(153, 70);
            this.contextMenuStripGridView.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuItemEditRow
            // 
            this.toolStripMenuItemEditRow.Name = "toolStripMenuItemEditRow";
            this.toolStripMenuItemEditRow.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemEditRow.Text = "VIEW/EDIT";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.FilterCheckBoxIncludeHidden);
            this.groupBox2.Controls.Add(this.numericUpDownFilterId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonFilterClearFilters);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDownFilterMaxRow);
            this.groupBox2.Controls.Add(this.buttonSearchFilter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxFilterName);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 126);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // FilterCheckBoxIncludeHidden
            // 
            this.FilterCheckBoxIncludeHidden.AutoSize = true;
            this.FilterCheckBoxIncludeHidden.Location = new System.Drawing.Point(9, 97);
            this.FilterCheckBoxIncludeHidden.Name = "FilterCheckBoxIncludeHidden";
            this.FilterCheckBoxIncludeHidden.Size = new System.Drawing.Size(98, 17);
            this.FilterCheckBoxIncludeHidden.TabIndex = 13;
            this.FilterCheckBoxIncludeHidden.Text = "Include Hidden";
            this.FilterCheckBoxIncludeHidden.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFilterId
            // 
            this.numericUpDownFilterId.Location = new System.Drawing.Point(76, 15);
            this.numericUpDownFilterId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFilterId.Name = "numericUpDownFilterId";
            this.numericUpDownFilterId.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownFilterId.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id :";
            // 
            // buttonFilterClearFilters
            // 
            this.buttonFilterClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilterClearFilters.Location = new System.Drawing.Point(522, 97);
            this.buttonFilterClearFilters.Name = "buttonFilterClearFilters";
            this.buttonFilterClearFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterClearFilters.TabIndex = 9;
            this.buttonFilterClearFilters.Text = "Reset";
            this.buttonFilterClearFilters.UseVisualStyleBackColor = true;
            this.buttonFilterClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max Rows :";
            // 
            // numericUpDownFilterMaxRow
            // 
            this.numericUpDownFilterMaxRow.Location = new System.Drawing.Point(75, 41);
            this.numericUpDownFilterMaxRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFilterMaxRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFilterMaxRow.Name = "numericUpDownFilterMaxRow";
            this.numericUpDownFilterMaxRow.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownFilterMaxRow.TabIndex = 7;
            this.numericUpDownFilterMaxRow.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonSearchFilter
            // 
            this.buttonSearchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchFilter.Location = new System.Drawing.Point(441, 97);
            this.buttonSearchFilter.Name = "buttonSearchFilter";
            this.buttonSearchFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchFilter.TabIndex = 6;
            this.buttonSearchFilter.Text = "Search";
            this.buttonSearchFilter.UseVisualStyleBackColor = true;
            this.buttonSearchFilter.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name :";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterName.Location = new System.Drawing.Point(209, 15);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(387, 20);
            this.textBoxFilterName.TabIndex = 4;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.groupBoxActions);
            this.tabPageDetails.Controls.Add(this.groupBoxDetails);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(616, 355);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "New/Edit";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActions.Controls.Add(this.buttonDetailsUnhide);
            this.groupBoxActions.Controls.Add(this.buttonDetailsUpdate);
            this.groupBoxActions.Controls.Add(this.buttonDetailsDelete);
            this.groupBoxActions.Controls.Add(this.buttonDetailsAdd);
            this.groupBoxActions.Controls.Add(this.buttonDetailsReset);
            this.groupBoxActions.Location = new System.Drawing.Point(8, 267);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(600, 80);
            this.groupBoxActions.TabIndex = 13;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonDetailsUnhide
            // 
            this.buttonDetailsUnhide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDetailsUnhide.Location = new System.Drawing.Point(90, 51);
            this.buttonDetailsUnhide.Name = "buttonDetailsUnhide";
            this.buttonDetailsUnhide.Size = new System.Drawing.Size(75, 23);
            this.buttonDetailsUnhide.TabIndex = 14;
            this.buttonDetailsUnhide.Text = "Unhide";
            this.buttonDetailsUnhide.UseVisualStyleBackColor = true;
            this.buttonDetailsUnhide.Click += new System.EventHandler(this.buttonDetailsUnhide_Click);
            // 
            // buttonDetailsUpdate
            // 
            this.buttonDetailsUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetailsUpdate.Location = new System.Drawing.Point(289, 51);
            this.buttonDetailsUpdate.Name = "buttonDetailsUpdate";
            this.buttonDetailsUpdate.Size = new System.Drawing.Size(109, 23);
            this.buttonDetailsUpdate.TabIndex = 13;
            this.buttonDetailsUpdate.Text = "Update";
            this.buttonDetailsUpdate.UseVisualStyleBackColor = true;
            this.buttonDetailsUpdate.Click += new System.EventHandler(this.buttonDetailsUpdate_Click);
            // 
            // buttonDetailsDelete
            // 
            this.buttonDetailsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDetailsDelete.Location = new System.Drawing.Point(9, 51);
            this.buttonDetailsDelete.Name = "buttonDetailsDelete";
            this.buttonDetailsDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDetailsDelete.TabIndex = 12;
            this.buttonDetailsDelete.Text = "Delete";
            this.buttonDetailsDelete.UseVisualStyleBackColor = true;
            this.buttonDetailsDelete.Click += new System.EventHandler(this.buttonDetailsDelete_Click);
            // 
            // buttonDetailsAdd
            // 
            this.buttonDetailsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetailsAdd.Location = new System.Drawing.Point(404, 51);
            this.buttonDetailsAdd.Name = "buttonDetailsAdd";
            this.buttonDetailsAdd.Size = new System.Drawing.Size(109, 23);
            this.buttonDetailsAdd.TabIndex = 11;
            this.buttonDetailsAdd.Text = "Add";
            this.buttonDetailsAdd.UseVisualStyleBackColor = true;
            this.buttonDetailsAdd.Click += new System.EventHandler(this.buttonDetailsSaveChanges_Click);
            // 
            // buttonDetailsReset
            // 
            this.buttonDetailsReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetailsReset.Location = new System.Drawing.Point(519, 51);
            this.buttonDetailsReset.Name = "buttonDetailsReset";
            this.buttonDetailsReset.Size = new System.Drawing.Size(75, 23);
            this.buttonDetailsReset.TabIndex = 10;
            this.buttonDetailsReset.Text = "Reset";
            this.buttonDetailsReset.UseVisualStyleBackColor = true;
            this.buttonDetailsReset.Click += new System.EventHandler(this.buttonDetailsReset_Click);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDetails.Controls.Add(this.numericUpDownDetailsID);
            this.groupBoxDetails.Controls.Add(this.textBoxDetailsDescription);
            this.groupBoxDetails.Controls.Add(this.label6);
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.Controls.Add(this.textBoxDetailsName);
            this.groupBoxDetails.Controls.Add(this.label5);
            this.groupBoxDetails.Location = new System.Drawing.Point(8, 6);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(600, 255);
            this.groupBoxDetails.TabIndex = 12;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Main Details";
            // 
            // numericUpDownDetailsID
            // 
            this.numericUpDownDetailsID.Enabled = false;
            this.numericUpDownDetailsID.Location = new System.Drawing.Point(29, 19);
            this.numericUpDownDetailsID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDetailsID.Name = "numericUpDownDetailsID";
            this.numericUpDownDetailsID.ReadOnly = true;
            this.numericUpDownDetailsID.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownDetailsID.TabIndex = 13;
            // 
            // textBoxDetailsDescription
            // 
            this.textBoxDetailsDescription.Location = new System.Drawing.Point(237, 45);
            this.textBoxDetailsDescription.Multiline = true;
            this.textBoxDetailsDescription.Name = "textBoxDetailsDescription";
            this.textBoxDetailsDescription.Size = new System.Drawing.Size(345, 60);
            this.textBoxDetailsDescription.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID :";
            // 
            // textBoxDetailsName
            // 
            this.textBoxDetailsName.Location = new System.Drawing.Point(237, 19);
            this.textBoxDetailsName.Name = "textBoxDetailsName";
            this.textBoxDetailsName.Size = new System.Drawing.Size(345, 20);
            this.textBoxDetailsName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name :";
            // 
            // toolStripMenuItemAddNew
            // 
            this.toolStripMenuItemAddNew.Name = "toolStripMenuItemAddNew";
            this.toolStripMenuItemAddNew.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemAddNew.Text = "ADD NEW";
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.tabControlMain);
            this.Name = "ProjectsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.ProjectsForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainSearchResult)).EndInit();
            this.contextMenuStripGridView.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterMaxRow)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterMaxRow;
        private System.Windows.Forms.Button buttonSearchFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.Button buttonFilterClearFilters;
        private System.Windows.Forms.DataGridView dataGridViewMainSearchResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterId;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDetailsDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDetailsName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonDetailsAdd;
        private System.Windows.Forms.Button buttonDetailsReset;
        private System.Windows.Forms.Button buttonDetailsDelete;
        private System.Windows.Forms.Button buttonDetailsUpdate;
        private System.Windows.Forms.CheckBox FilterCheckBoxIncludeHidden;
        private System.Windows.Forms.NumericUpDown numericUpDownDetailsID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditRow;
        private System.Windows.Forms.Button buttonDetailsUnhide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddNew;

    }
}