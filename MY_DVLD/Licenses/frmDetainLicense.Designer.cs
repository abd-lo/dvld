namespace MY_DVLD.Licenses
{
	partial class frmDetainLicense
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
			this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
			this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
			this.btnDetainLicense = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.ucDriverLicenseWithFilter1 = new MY_DVLD.Licenses.Local_Driving_Licenses.Controls.UCDriverLicenseWithFilter();
			this.lblTitle = new System.Windows.Forms.Label();
			this.gpDetain = new System.Windows.Forms.GroupBox();
			this.lblLicenseID = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lblCreatedByUser = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lblDetainDate = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lblDetainID = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.txtFineFees = new System.Windows.Forms.MaskedTextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gpDetain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// llShowLicenseInfo
			// 
			this.llShowLicenseInfo.AutoSize = true;
			this.llShowLicenseInfo.Enabled = false;
			this.llShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F);
			this.llShowLicenseInfo.Location = new System.Drawing.Point(191, 906);
			this.llShowLicenseInfo.Name = "llShowLicenseInfo";
			this.llShowLicenseInfo.Size = new System.Drawing.Size(145, 19);
			this.llShowLicenseInfo.TabIndex = 194;
			this.llShowLicenseInfo.TabStop = true;
			this.llShowLicenseInfo.Text = "Show Licenses Info";
			this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
			// 
			// llShowLicenseHistory
			// 
			this.llShowLicenseHistory.AutoSize = true;
			this.llShowLicenseHistory.Enabled = false;
			this.llShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12F);
			this.llShowLicenseHistory.Location = new System.Drawing.Point(19, 906);
			this.llShowLicenseHistory.Name = "llShowLicenseHistory";
			this.llShowLicenseHistory.Size = new System.Drawing.Size(166, 19);
			this.llShowLicenseHistory.TabIndex = 193;
			this.llShowLicenseHistory.TabStop = true;
			this.llShowLicenseHistory.Text = "Show Licenses History";
			this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
			// 
			// btnDetainLicense
			// 
			this.btnDetainLicense.Enabled = false;
			this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDetainLicense.Image = global::MY_DVLD.Properties.Resources.Detain_32;
			this.btnDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDetainLicense.Location = new System.Drawing.Point(552, 899);
			this.btnDetainLicense.Name = "btnDetainLicense";
			this.btnDetainLicense.Size = new System.Drawing.Size(186, 37);
			this.btnDetainLicense.TabIndex = 192;
			this.btnDetainLicense.Text = "DetainLicense";
			this.btnDetainLicense.UseVisualStyleBackColor = true;
			this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(419, 899);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(126, 37);
			this.btnClose.TabIndex = 191;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ucDriverLicenseWithFilter1
			// 
			this.ucDriverLicenseWithFilter1.IsFilterEnabled = true;
			this.ucDriverLicenseWithFilter1.Location = new System.Drawing.Point(8, 75);
			this.ucDriverLicenseWithFilter1.Name = "ucDriverLicenseWithFilter1";
			this.ucDriverLicenseWithFilter1.Size = new System.Drawing.Size(699, 616);
			this.ucDriverLicenseWithFilter1.TabIndex = 195;
			this.ucDriverLicenseWithFilter1.OnLicenseFound += new MY_DVLD.Licenses.Local_Driving_Licenses.Controls.UCDriverLicenseWithFilter.OnLicenseSelected(this.ucDriverLicenseWithFilter1_OnLicenseFound);
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(85, 22);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(568, 39);
			this.lblTitle.TabIndex = 196;
			this.lblTitle.Text = "Detain License";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gpDetain
			// 
			this.gpDetain.Controls.Add(this.txtFineFees);
			this.gpDetain.Controls.Add(this.pictureBox11);
			this.gpDetain.Controls.Add(this.pictureBox14);
			this.gpDetain.Controls.Add(this.pictureBox9);
			this.gpDetain.Controls.Add(this.pictureBox12);
			this.gpDetain.Controls.Add(this.pictureBox13);
			this.gpDetain.Controls.Add(this.lblLicenseID);
			this.gpDetain.Controls.Add(this.label11);
			this.gpDetain.Controls.Add(this.label13);
			this.gpDetain.Controls.Add(this.lblCreatedByUser);
			this.gpDetain.Controls.Add(this.label15);
			this.gpDetain.Controls.Add(this.lblDetainDate);
			this.gpDetain.Controls.Add(this.label16);
			this.gpDetain.Controls.Add(this.lblDetainID);
			this.gpDetain.Controls.Add(this.label17);
			this.gpDetain.Location = new System.Drawing.Point(12, 697);
			this.gpDetain.Name = "gpDetain";
			this.gpDetain.Size = new System.Drawing.Size(699, 147);
			this.gpDetain.TabIndex = 197;
			this.gpDetain.TabStop = false;
			this.gpDetain.Text = "Detain Info";
			// 
			// lblLicenseID
			// 
			this.lblLicenseID.AutoSize = true;
			this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLicenseID.Location = new System.Drawing.Point(619, 24);
			this.lblLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLicenseID.Name = "lblLicenseID";
			this.lblLicenseID.Size = new System.Drawing.Size(49, 20);
			this.lblLicenseID.TabIndex = 191;
			this.lblLicenseID.Text = "[???]";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(410, 24);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 20);
			this.label11.TabIndex = 190;
			this.label11.Text = "License ID:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(410, 56);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(103, 20);
			this.label13.TabIndex = 181;
			this.label13.Text = "Created By:";
			// 
			// lblCreatedByUser
			// 
			this.lblCreatedByUser.AutoSize = true;
			this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreatedByUser.Location = new System.Drawing.Point(619, 56);
			this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCreatedByUser.Name = "lblCreatedByUser";
			this.lblCreatedByUser.Size = new System.Drawing.Size(59, 20);
			this.lblCreatedByUser.TabIndex = 180;
			this.lblCreatedByUser.Text = "[????]";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(16, 102);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(94, 20);
			this.label15.TabIndex = 177;
			this.label15.Text = "Fine Fees:";
			// 
			// lblDetainDate
			// 
			this.lblDetainDate.AutoSize = true;
			this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetainDate.Location = new System.Drawing.Point(225, 65);
			this.lblDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDetainDate.Name = "lblDetainDate";
			this.lblDetainDate.Size = new System.Drawing.Size(109, 20);
			this.lblDetainDate.TabIndex = 176;
			this.lblDetainDate.Text = "[??/??/????]";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(16, 65);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(111, 20);
			this.label16.TabIndex = 174;
			this.label16.Text = "Detain Date:";
			// 
			// lblDetainID
			// 
			this.lblDetainID.AutoSize = true;
			this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetainID.Location = new System.Drawing.Point(225, 24);
			this.lblDetainID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDetainID.Name = "lblDetainID";
			this.lblDetainID.Size = new System.Drawing.Size(49, 20);
			this.lblDetainID.TabIndex = 173;
			this.lblDetainID.Text = "[???]";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(16, 24);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(91, 20);
			this.label17.TabIndex = 172;
			this.label17.Text = "Detain ID:";
			// 
			// pictureBox13
			// 
			this.pictureBox13.Image = global::MY_DVLD.Properties.Resources.money_32;
			this.pictureBox13.Location = new System.Drawing.Point(187, 102);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(31, 26);
			this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox13.TabIndex = 204;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = global::MY_DVLD.Properties.Resources.User_32__2;
			this.pictureBox12.Location = new System.Drawing.Point(581, 56);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(31, 26);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox12.TabIndex = 206;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = global::MY_DVLD.Properties.Resources.Number_32;
			this.pictureBox9.Location = new System.Drawing.Point(581, 18);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(31, 26);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 207;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Image = global::MY_DVLD.Properties.Resources.Calendar_32;
			this.pictureBox14.Location = new System.Drawing.Point(187, 65);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(31, 26);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox14.TabIndex = 202;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = global::MY_DVLD.Properties.Resources.Number_32;
			this.pictureBox11.Location = new System.Drawing.Point(187, 24);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(31, 26);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox11.TabIndex = 210;
			this.pictureBox11.TabStop = false;
			// 
			// txtFineFees
			// 
			this.txtFineFees.Location = new System.Drawing.Point(224, 108);
			this.txtFineFees.Mask = "000";
			this.txtFineFees.Name = "txtFineFees";
			this.txtFineFees.Size = new System.Drawing.Size(70, 20);
			this.txtFineFees.TabIndex = 212;
			this.txtFineFees.ValidatingType = typeof(int);
			this.txtFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFineFees_Validating);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmDetainLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 962);
			this.Controls.Add(this.gpDetain);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.ucDriverLicenseWithFilter1);
			this.Controls.Add(this.llShowLicenseInfo);
			this.Controls.Add(this.llShowLicenseHistory);
			this.Controls.Add(this.btnDetainLicense);
			this.Controls.Add(this.btnClose);
			this.Name = "frmDetainLicense";
			this.Text = "frmDetainLicense";
			this.Load += new System.EventHandler(this.frmDetainLicense_Load);
			this.gpDetain.ResumeLayout(false);
			this.gpDetain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel llShowLicenseInfo;
		private System.Windows.Forms.LinkLabel llShowLicenseHistory;
		private System.Windows.Forms.Button btnDetainLicense;
		private System.Windows.Forms.Button btnClose;
		private Local_Driving_Licenses.Controls.UCDriverLicenseWithFilter ucDriverLicenseWithFilter1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox gpDetain;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.Label lblLicenseID;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblCreatedByUser;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lblDetainDate;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblDetainID;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.MaskedTextBox txtFineFees;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}