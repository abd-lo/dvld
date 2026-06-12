namespace MY_DVLD.Licenses.International_Licenses
{
	partial class frmManageInternationalLicenseApplications
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
			this.lblTotalRecords = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
			this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.PesonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblTitle = new System.Windows.Forms.Label();
			this.cbIsActive = new System.Windows.Forms.ComboBox();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.txtFilterValue = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pbPersonImage = new System.Windows.Forms.PictureBox();
			this.btnAddNewApp = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
			this.cmsApplications.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTotalRecords
			// 
			this.lblTotalRecords.AutoSize = true;
			this.lblTotalRecords.Location = new System.Drawing.Point(103, 685);
			this.lblTotalRecords.Name = "lblTotalRecords";
			this.lblTotalRecords.Size = new System.Drawing.Size(17, 13);
			this.lblTotalRecords.TabIndex = 170;
			this.lblTotalRecords.Text = "??";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 685);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 20);
			this.label5.TabIndex = 169;
			this.label5.Text = "# Records:";
			// 
			// dgvInternationalLicenses
			// 
			this.dgvInternationalLicenses.AllowUserToAddRows = false;
			this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
			this.dgvInternationalLicenses.AllowUserToResizeRows = false;
			this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
			this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInternationalLicenses.ContextMenuStrip = this.cmsApplications;
			this.dgvInternationalLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvInternationalLicenses.Location = new System.Drawing.Point(9, 336);
			this.dgvInternationalLicenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvInternationalLicenses.MultiSelect = false;
			this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
			this.dgvInternationalLicenses.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvInternationalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvInternationalLicenses.Size = new System.Drawing.Size(1261, 340);
			this.dgvInternationalLicenses.TabIndex = 168;
			this.dgvInternationalLicenses.TabStop = false;
			// 
			// cmsApplications
			// 
			this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PesonDetailsToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
			this.cmsApplications.Name = "contextMenuStrip1";
			this.cmsApplications.Size = new System.Drawing.Size(242, 118);
			// 
			// PesonDetailsToolStripMenuItem
			// 
			this.PesonDetailsToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.PersonDetails_32;
			this.PesonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.PesonDetailsToolStripMenuItem.Name = "PesonDetailsToolStripMenuItem";
			this.PesonDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
			this.PesonDetailsToolStripMenuItem.Text = "Show Person Details";
			this.PesonDetailsToolStripMenuItem.Click += new System.EventHandler(this.PesonDetailsToolStripMenuItem_Click_1);
			// 
			// showDetailsToolStripMenuItem
			// 
			this.showDetailsToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.License_View_32;
			this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
			this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
			this.showDetailsToolStripMenuItem.Text = "&Show License Details";
			this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click_1);
			// 
			// showPersonLicenseHistoryToolStripMenuItem
			// 
			this.showPersonLicenseHistoryToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.PersonLicenseHistory_32;
			this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
			this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
			this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
			this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click_1);
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(389, 208);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(699, 39);
			this.lblTitle.TabIndex = 162;
			this.lblTitle.Text = "International License Applications";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbIsActive
			// 
			this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIsActive.FormattingEnabled = true;
			this.cbIsActive.Location = new System.Drawing.Point(297, 300);
			this.cbIsActive.Name = "cbIsActive";
			this.cbIsActive.Size = new System.Drawing.Size(121, 21);
			this.cbIsActive.TabIndex = 171;
			this.cbIsActive.Visible = false;
			this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.ChangeFilter);
			this.cbIsActive.TextChanged += new System.EventHandler(this.ChangeFilter);
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Location = new System.Drawing.Point(81, 300);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(210, 21);
			this.cbFilterBy.TabIndex = 165;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.ChangeFilter);
			// 
			// txtFilterValue
			// 
			this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFilterValue.Location = new System.Drawing.Point(298, 300);
			this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtFilterValue.Name = "txtFilterValue";
			this.txtFilterValue.Size = new System.Drawing.Size(256, 20);
			this.txtFilterValue.TabIndex = 164;
			this.txtFilterValue.TextChanged += new System.EventHandler(this.ChangeFilter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 303);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 163;
			this.label1.Text = "Filter By:";
			// 
			// pbPersonImage
			// 
			this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbPersonImage.Image = global::MY_DVLD.Properties.Resources.Applications;
			this.pbPersonImage.InitialImage = null;
			this.pbPersonImage.Location = new System.Drawing.Point(631, 14);
			this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbPersonImage.Name = "pbPersonImage";
			this.pbPersonImage.Size = new System.Drawing.Size(220, 189);
			this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPersonImage.TabIndex = 166;
			this.pbPersonImage.TabStop = false;
			// 
			// btnAddNewApp
			// 
			this.btnAddNewApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNewApp.Image = global::MY_DVLD.Properties.Resources.New_Application_64;
			this.btnAddNewApp.Location = new System.Drawing.Point(1182, 248);
			this.btnAddNewApp.Name = "btnAddNewApp";
			this.btnAddNewApp.Size = new System.Drawing.Size(88, 75);
			this.btnAddNewApp.TabIndex = 167;
			this.btnAddNewApp.UseVisualStyleBackColor = true;
			this.btnAddNewApp.Click += new System.EventHandler(this.btnAddNewApp_Click);
			// 
			// btnClose
			// 
			this.btnClose.AutoEllipsis = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1135, 685);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(135, 36);
			this.btnClose.TabIndex = 161;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = global::MY_DVLD.Properties.Resources.International_32;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(817, 98);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(78, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 173;
			this.pictureBox1.TabStop = false;
			// 
			// frmManageInternationalLicenseApplications
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1281, 759);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblTotalRecords);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dgvInternationalLicenses);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pbPersonImage);
			this.Controls.Add(this.cbIsActive);
			this.Controls.Add(this.btnAddNewApp);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.txtFilterValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Name = "frmManageInternationalLicenseApplications";
			this.Text = "Manage_International_Licenses";
			this.Load += new System.EventHandler(this.frmManageInternationalLicenseApplications_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
			this.cmsApplications.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblTotalRecords;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvInternationalLicenses;
		private System.Windows.Forms.ContextMenuStrip cmsApplications;
		private System.Windows.Forms.ToolStripMenuItem PesonDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pbPersonImage;
		private System.Windows.Forms.ComboBox cbIsActive;
		private System.Windows.Forms.Button btnAddNewApp;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.TextBox txtFilterValue;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}