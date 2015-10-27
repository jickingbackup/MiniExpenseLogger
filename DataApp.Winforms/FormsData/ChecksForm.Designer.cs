namespace DataApp.Winforms
{
    partial class ChecksForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonSearchFilter = new System.Windows.Forms.Button();
            this.FilterCheckBoxIncludeHidden = new System.Windows.Forms.CheckBox();
            this.numericUpDownFilterId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFilterMaxRow = new System.Windows.Forms.NumericUpDown();
            this.textBoxFilterSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewMainSearchResult = new System.Windows.Forms.DataGridView();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonDetailsUnhide = new System.Windows.Forms.Button();
            this.buttonDetailsUpdate = new System.Windows.Forms.Button();
            this.buttonDetailsDelete = new System.Windows.Forms.Button();
            this.buttonDetailsAdd = new System.Windows.Forms.Button();
            this.buttonDetailsReset = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDetailsID = new System.Windows.Forms.NumericUpDown();
            this.textBoxDetailsDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDetailsVoucherNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterMaxRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainSearchResult)).BeginInit();
            this.tabPageDetails.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.groupBox2);
            this.tabPageSearch.Controls.Add(this.dataGridViewMainSearchResult);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(616, 355);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonClearFilters);
            this.groupBox2.Controls.Add(this.buttonSearchFilter);
            this.groupBox2.Controls.Add(this.FilterCheckBoxIncludeHidden);
            this.groupBox2.Controls.Add(this.numericUpDownFilterId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDownFilterMaxRow);
            this.groupBox2.Controls.Add(this.textBoxFilterSearch);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 73);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearFilters.Location = new System.Drawing.Point(521, 39);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFilters.TabIndex = 11;
            this.buttonClearFilters.Text = "Reset";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            // 
            // buttonSearchFilter
            // 
            this.buttonSearchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchFilter.Location = new System.Drawing.Point(440, 39);
            this.buttonSearchFilter.Name = "buttonSearchFilter";
            this.buttonSearchFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchFilter.TabIndex = 10;
            this.buttonSearchFilter.Text = "Search";
            this.buttonSearchFilter.UseVisualStyleBackColor = true;
            this.buttonSearchFilter.Click += new System.EventHandler(this.buttonSearchFilter_Click);
            // 
            // FilterCheckBoxIncludeHidden
            // 
            this.FilterCheckBoxIncludeHidden.AutoSize = true;
            this.FilterCheckBoxIncludeHidden.Location = new System.Drawing.Point(176, 44);
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
            9999999,
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
            9999999,
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
            // textBoxFilterSearch
            // 
            this.textBoxFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterSearch.Location = new System.Drawing.Point(176, 15);
            this.textBoxFilterSearch.Name = "textBoxFilterSearch";
            this.textBoxFilterSearch.Size = new System.Drawing.Size(420, 20);
            this.textBoxFilterSearch.TabIndex = 4;
            // 
            // dataGridViewMainSearchResult
            // 
            this.dataGridViewMainSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMainSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMainSearchResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridViewMainSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainSearchResult.Location = new System.Drawing.Point(8, 85);
            this.dataGridViewMainSearchResult.MultiSelect = false;
            this.dataGridViewMainSearchResult.Name = "dataGridViewMainSearchResult";
            this.dataGridViewMainSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMainSearchResult.ShowEditingIcon = false;
            this.dataGridViewMainSearchResult.Size = new System.Drawing.Size(602, 262);
            this.dataGridViewMainSearchResult.StandardTab = true;
            this.dataGridViewMainSearchResult.TabIndex = 6;
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
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDetails.Controls.Add(this.dateTimePicker2);
            this.groupBoxDetails.Controls.Add(this.label10);
            this.groupBoxDetails.Controls.Add(this.dateTimePicker1);
            this.groupBoxDetails.Controls.Add(this.label9);
            this.groupBoxDetails.Controls.Add(this.comboBox1);
            this.groupBoxDetails.Controls.Add(this.label8);
            this.groupBoxDetails.Controls.Add(this.numericUpDown1);
            this.groupBoxDetails.Controls.Add(this.label7);
            this.groupBoxDetails.Controls.Add(this.numericUpDownDetailsID);
            this.groupBoxDetails.Controls.Add(this.textBoxDetailsDescription);
            this.groupBoxDetails.Controls.Add(this.label6);
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.Controls.Add(this.textBoxDetailsVoucherNumber);
            this.groupBoxDetails.Controls.Add(this.label5);
            this.groupBoxDetails.Location = new System.Drawing.Point(8, 6);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(600, 255);
            this.groupBoxDetails.TabIndex = 12;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Main Details";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(237, 98);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(345, 20);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Due  Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(345, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Issued  Date:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Payee :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(237, 124);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(345, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount :";
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
            this.textBoxDetailsDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDetailsDescription.Location = new System.Drawing.Point(237, 150);
            this.textBoxDetailsDescription.Name = "textBoxDetailsDescription";
            this.textBoxDetailsDescription.Size = new System.Drawing.Size(345, 20);
            this.textBoxDetailsDescription.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Notes:";
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
            // textBoxDetailsVoucherNumber
            // 
            this.textBoxDetailsVoucherNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDetailsVoucherNumber.Location = new System.Drawing.Point(237, 19);
            this.textBoxDetailsVoucherNumber.Name = "textBoxDetailsVoucherNumber";
            this.textBoxDetailsVoucherNumber.Size = new System.Drawing.Size(345, 20);
            this.textBoxDetailsVoucherNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Voucher # :";
            // 
            // ChecksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.tabControlMain);
            this.Name = "ChecksForm";
            this.Text = "ChecksForm";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterMaxRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainSearchResult)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.DataGridView dataGridViewMainSearchResult;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonDetailsUnhide;
        private System.Windows.Forms.Button buttonDetailsUpdate;
        private System.Windows.Forms.Button buttonDetailsDelete;
        private System.Windows.Forms.Button buttonDetailsAdd;
        private System.Windows.Forms.Button buttonDetailsReset;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.NumericUpDown numericUpDownDetailsID;
        private System.Windows.Forms.TextBox textBoxDetailsDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDetailsVoucherNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Button buttonSearchFilter;
        private System.Windows.Forms.CheckBox FilterCheckBoxIncludeHidden;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterMaxRow;
        private System.Windows.Forms.TextBox textBoxFilterSearch;
    }
}