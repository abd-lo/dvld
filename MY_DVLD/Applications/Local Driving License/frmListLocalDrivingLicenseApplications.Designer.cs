namespace MY_DVLD.Applications.Local_Driving_License
{
	partial class frmListLocalDrivingLicenseApplications
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.txtFilterValue = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelApplicaitonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ScheduleTestsMenue = new System.Windows.Forms.ToolStripMenuItem();
			this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbRecordsNO = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
			this.lblTitle = new System.Windows.Forms.Label();
			this.cbStatus = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnAddNewApplication = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pbPersonImage = new System.Windows.Forms.PictureBox();
			this.cmsApplications.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
			this.SuspendLayout();
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterBy.Font = new System.Drawing.Font("Tahoma", 13F);
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Location = new System.Drawing.Point(96, 282);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(210, 29);
			this.cbFilterBy.TabIndex = 138;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.ApplyFilterEventHandler);
			// 
			// txtFilterValue
			// 
			this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 13F);
			this.txtFilterValue.Location = new System.Drawing.Point(313, 282);
			this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtFilterValue.Name = "txtFilterValue";
			this.txtFilterValue.Size = new System.Drawing.Size(256, 28);
			this.txtFilterValue.TabIndex = 137;
			this.txtFilterValue.TextChanged += new System.EventHandler(this.ApplyFilterEventHandler);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 285);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 136;
			this.label1.Text = "Filter By:";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(258, 6);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(258, 6);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(258, 6);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
			// 
			// cmsApplications
			// 
			this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator5,
            this.cancelApplicaitonToolStripMenuItem,
            this.toolStripSeparator1,
            this.ScheduleTestsMenue,
            this.toolStripSeparator3,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripSeparator4,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.showPersonLicenseHistoryToolStripMenuItem});
			this.cmsApplications.Name = "contextMenuStrip1";
			this.cmsApplications.Size = new System.Drawing.Size(262, 366);
			this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
			// 
			// showApplicationDetailsToolStripMenuItem
			// 
			this.showApplicationDetailsToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.PersonDetails_32;
			this.showApplicationDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
			this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
			this.showApplicationDetailsToolStripMenuItem.Text = "&Show Application Details";
			this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationInfoToolStripMenuItem_Click);
			// 
			// editApplicationToolStripMenuItem
			// 
			this.editApplicationToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.edit_32;
			this.editApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
			this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
			this.editApplicationToolStripMenuItem.Text = "&Edit Application";
			this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.EditApplicationToolStripMenuItem_Click);
			// 
			// deleteApplicationToolStripMenuItem
			// 
			this.deleteApplicationToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Delete_32_2;
			this.deleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
			this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
			this.deleteApplicationToolStripMenuItem.Text = "&Delete Application";
			this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.DeleteApplicationToolStripMenuItem_Click);
			// 
			// cancelApplicaitonToolStripMenuItem
			// 
			this.cancelApplicaitonToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Delete_32;
			this.cancelApplicaitonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.cancelApplicaitonToolStripMenuItem.Name = "cancelApplicaitonToolStripMenuItem";
			this.cancelApplicaitonToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
			this.cancelApplicaitonToolStripMenuItem.Text = "&Cancel Application";
			this.cancelApplicaitonToolStripMenuItem.Click += new System.EventHandler(this.CancelApplicaitonToolStripMenuItem_Click);
			// 
			// ScheduleTestsMenue
			// 
			this.ScheduleTestsMenue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
			this.ScheduleTestsMenue.Image = global::MY_DVLD.Properties.Resources.Test_32;
			this.ScheduleTestsMenue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ScheduleTestsMenue.Name = "ScheduleTestsMenue";
			this.ScheduleTestsMenue.Size = new System.Drawing.Size(261, 38);
			this.ScheduleTestsMenue.Text = "Sechdule &Tests";
			// 
			// scheduleVisionTestToolStripMenuItem
			// 
			this.scheduleVisionTestToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Vision_Test_32;
			this.scheduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
			this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
			this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
			this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
			// 
			// scheduleWrittenTestToolStripMenuItem
			// 
			this.scheduleWrittenTestToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Written_Test_32;
			this.scheduleWrittenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
			this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
			this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
			this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
			// 
			// scheduleStreetTestToolStripMenuItem
			// 
			this.scheduleStreetTestToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Street_Test_32;
			this.scheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
			this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
			this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
			this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
			// 
			// issueDrivingLicenseFirstTimeToolStripMenuItem
			// 
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.IssueDrivingLicense_32;
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "&Issue Driving License (First Time)";
			// 
			// showLicenseToolStripMenuItem
			// 
			this.showLicenseToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.License_Type_32;
			this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
			this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
			this.showLicenseToolStripMenuItem.Text = "Show &License";
			this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
			// 
			// showPersonLicenseHistoryToolStripMenuItem
			// 
			this.showPersonLicenseHistoryToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.PersonLicenseHistory_32;
			this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
			this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
			this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
			// 
			// lbRecordsNO
			// 
			this.lbRecordsNO.AutoSize = true;
			this.lbRecordsNO.Font = new System.Drawing.Font("Tahoma", 15F);
			this.lbRecordsNO.Location = new System.Drawing.Point(117, 700);
			this.lbRecordsNO.Name = "lbRecordsNO";
			this.lbRecordsNO.Size = new System.Drawing.Size(28, 24);
			this.lbRecordsNO.TabIndex = 134;
			this.lbRecordsNO.Text = "??";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 700);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 133;
			this.label2.Text = "# Records:";
			// 
			// dgvLocalDrivingLicenseApplications
			// 
			this.dgvLocalDrivingLicenseApplications.AllowUserToAddRows = false;
			this.dgvLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
			this.dgvLocalDrivingLicenseApplications.AllowUserToResizeRows = false;
			this.dgvLocalDrivingLicenseApplications.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLocalDrivingLicenseApplications.ContextMenuStrip = this.cmsApplications;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvLocalDrivingLicenseApplications.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvLocalDrivingLicenseApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvLocalDrivingLicenseApplications.Location = new System.Drawing.Point(13, 331);
			this.dgvLocalDrivingLicenseApplications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvLocalDrivingLicenseApplications.MultiSelect = false;
			this.dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
			this.dgvLocalDrivingLicenseApplications.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLocalDrivingLicenseApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvLocalDrivingLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLocalDrivingLicenseApplications.Size = new System.Drawing.Size(1405, 353);
			this.dgvLocalDrivingLicenseApplications.TabIndex = 132;
			this.dgvLocalDrivingLicenseApplications.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(399, 202);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(568, 39);
			this.lblTitle.TabIndex = 135;
			this.lblTitle.Text = "Local Driving License Applications";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbStatus
			// 
			this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStatus.Font = new System.Drawing.Font("Tahoma", 13F);
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Location = new System.Drawing.Point(313, 282);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(256, 29);
			this.cbStatus.TabIndex = 142;
			this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.ApplyFilterEventHandler);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = global::MY_DVLD.Properties.Resources.Local_32;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(757, 75);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(78, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 141;
			this.pictureBox1.TabStop = false;
			// 
			// btnAddNewApplication
			// 
			this.btnAddNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNewApplication.Image = global::MY_DVLD.Properties.Resources.New_Application_64;
			this.btnAddNewApplication.Location = new System.Drawing.Point(1330, 248);
			this.btnAddNewApplication.Name = "btnAddNewApplication";
			this.btnAddNewApplication.Size = new System.Drawing.Size(88, 75);
			this.btnAddNewApplication.TabIndex = 140;
			this.btnAddNewApplication.UseVisualStyleBackColor = true;
			this.btnAddNewApplication.Click += new System.EventHandler(this.btnAddNewApplication_Click);
			// 
			// btnClose
			// 
			this.btnClose.AutoEllipsis = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1283, 692);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(135, 36);
			this.btnClose.TabIndex = 131;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pbPersonImage
			// 
			this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbPersonImage.Image = global::MY_DVLD.Properties.Resources.Applications;
			this.pbPersonImage.InitialImage = null;
			this.pbPersonImage.Location = new System.Drawing.Point(581, 8);
			this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbPersonImage.Name = "pbPersonImage";
			this.pbPersonImage.Size = new System.Drawing.Size(220, 189);
			this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPersonImage.TabIndex = 139;
			this.pbPersonImage.TabStop = false;
			// 
			// frmListLocalDrivingLicenseApplications
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1448, 747);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnAddNewApplication);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.txtFilterValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pbPersonImage);
			this.Controls.Add(this.lbRecordsNO);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvLocalDrivingLicenseApplications);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.cbStatus);
			this.Name = "frmListLocalDrivingLicenseApplications";
			this.Text = "frmListLocalDrivingLicesnseApplications";
			this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplications_Load);
			this.cmsApplications.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnAddNewApplication;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.TextBox txtFilterValue;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
		private System.Windows.Forms.PictureBox pbPersonImage;
		private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ScheduleTestsMenue;
		private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cancelApplicaitonToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip cmsApplications;
		private System.Windows.Forms.Label lbRecordsNO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvLocalDrivingLicenseApplications;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ComboBox cbStatus;
	}
}