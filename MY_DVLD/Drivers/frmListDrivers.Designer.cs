namespace MY_DVLD.Drivers
{
	partial class frmListDrivers
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
			this.lbRecordsNO = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvDrivers = new System.Windows.Forms.DataGridView();
			this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.IssueInternationalLicnese = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblTitle = new System.Windows.Forms.Label();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilterValue = new System.Windows.Forms.TextBox();
			this.pbPersonImage = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
			this.cmsApplications.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
			this.SuspendLayout();
			// 
			// lbRecordsNO
			// 
			this.lbRecordsNO.AutoSize = true;
			this.lbRecordsNO.Font = new System.Drawing.Font("Tahoma", 15F);
			this.lbRecordsNO.Location = new System.Drawing.Point(111, 670);
			this.lbRecordsNO.Name = "lbRecordsNO";
			this.lbRecordsNO.Size = new System.Drawing.Size(28, 24);
			this.lbRecordsNO.TabIndex = 146;
			this.lbRecordsNO.Text = "??";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 670);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 145;
			this.label2.Text = "# Records:";
			// 
			// dgvDrivers
			// 
			this.dgvDrivers.AllowUserToAddRows = false;
			this.dgvDrivers.AllowUserToDeleteRows = false;
			this.dgvDrivers.AllowUserToResizeRows = false;
			this.dgvDrivers.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDrivers.ContextMenuStrip = this.cmsApplications;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDrivers.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDrivers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvDrivers.Location = new System.Drawing.Point(13, 300);
			this.dgvDrivers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvDrivers.MultiSelect = false;
			this.dgvDrivers.Name = "dgvDrivers";
			this.dgvDrivers.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDrivers.Size = new System.Drawing.Size(1085, 348);
			this.dgvDrivers.TabIndex = 144;
			this.dgvDrivers.TabStop = false;
			// 
			// cmsApplications
			// 
			this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonInfo,
            this.toolStripSeparator2,
            this.IssueInternationalLicnese,
            this.toolStripSeparator5,
            this.showPersonLicenseHistoryToolStripMenuItem});
			this.cmsApplications.Name = "contextMenuStrip1";
			this.cmsApplications.Size = new System.Drawing.Size(242, 130);
			// 
			// ShowPersonInfo
			// 
			this.ShowPersonInfo.Image = global::MY_DVLD.Properties.Resources.PersonDetails_32;
			this.ShowPersonInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ShowPersonInfo.Name = "ShowPersonInfo";
			this.ShowPersonInfo.Size = new System.Drawing.Size(241, 38);
			this.ShowPersonInfo.Text = "&ShowPersonInfo";
			this.ShowPersonInfo.Click += new System.EventHandler(this.ShowPersonInfo_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
			// 
			// IssueInternationalLicnese
			// 
			this.IssueInternationalLicnese.Image = global::MY_DVLD.Properties.Resources.edit_32;
			this.IssueInternationalLicnese.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.IssueInternationalLicnese.Name = "IssueInternationalLicnese";
			this.IssueInternationalLicnese.Size = new System.Drawing.Size(241, 38);
			this.IssueInternationalLicnese.Text = "&Issue International Licnese";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(238, 6);
			// 
			// showPersonLicenseHistoryToolStripMenuItem
			// 
			this.showPersonLicenseHistoryToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.PersonLicenseHistory_32;
			this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
			this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
			this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
			this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(228, 214);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(568, 39);
			this.lblTitle.TabIndex = 147;
			this.lblTitle.Text = "Manage Drivers";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterBy.Font = new System.Drawing.Font("Tahoma", 13F);
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Location = new System.Drawing.Point(153, 258);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(210, 29);
			this.cbFilterBy.TabIndex = 150;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this._ApplyUserFilter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(77, 261);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 148;
			this.label1.Text = "Filter By:";
			// 
			// txtFilterValue
			// 
			this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 13F);
			this.txtFilterValue.Location = new System.Drawing.Point(378, 259);
			this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtFilterValue.Name = "txtFilterValue";
			this.txtFilterValue.Size = new System.Drawing.Size(256, 28);
			this.txtFilterValue.TabIndex = 149;
			this.txtFilterValue.TextChanged += new System.EventHandler(this._ApplyUserFilter);
			// 
			// pbPersonImage
			// 
			this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbPersonImage.Image = global::MY_DVLD.Properties.Resources.Driver_Main;
			this.pbPersonImage.InitialImage = null;
			this.pbPersonImage.Location = new System.Drawing.Point(414, 20);
			this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbPersonImage.Name = "pbPersonImage";
			this.pbPersonImage.Size = new System.Drawing.Size(220, 189);
			this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPersonImage.TabIndex = 151;
			this.pbPersonImage.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.AutoEllipsis = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(944, 656);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(135, 36);
			this.btnClose.TabIndex = 143;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmListDrivers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1118, 743);
			this.Controls.Add(this.pbPersonImage);
			this.Controls.Add(this.lbRecordsNO);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvDrivers);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.txtFilterValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Name = "frmListDrivers";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmListDrivers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
			this.cmsApplications.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbPersonImage;
		private System.Windows.Forms.Label lbRecordsNO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvDrivers;
		private System.Windows.Forms.ContextMenuStrip cmsApplications;
		private System.Windows.Forms.ToolStripMenuItem ShowPersonInfo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem IssueInternationalLicnese;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtFilterValue;
	}
}