namespace MY_DVLD
{
	partial class frmMainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
			this.msMainMenue = new System.Windows.Forms.MenuStrip();
			this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.drivingLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oNewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.retakeTestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.tsMManageApplications = new System.Windows.Forms.ToolStripMenuItem();
			this.manageLocalDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ManageInternationaDrivingLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.DetainLicensesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ManageDetainedLicensestoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msMainMenue.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMainMenue
			// 
			this.msMainMenue.BackColor = System.Drawing.Color.DimGray;
			this.msMainMenue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.msMainMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.msMainMenue.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.msMainMenue.Location = new System.Drawing.Point(0, 0);
			this.msMainMenue.Name = "msMainMenue";
			this.msMainMenue.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.msMainMenue.Size = new System.Drawing.Size(1142, 72);
			this.msMainMenue.TabIndex = 2;
			this.msMainMenue.Text = "menuStrip1";
			// 
			// servicesToolStripMenuItem
			// 
			this.servicesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesToolStripMenuItem,
            this.toolStripSeparator6,
            this.tsMManageApplications,
            this.toolStripSeparator5,
            this.DetainLicensesToolStripMenuItem1,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
			this.servicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.servicesToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Applications_64;
			this.servicesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.servicesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
			this.servicesToolStripMenuItem.Size = new System.Drawing.Size(206, 68);
			this.servicesToolStripMenuItem.Text = "&Applications";
			// 
			// drivingLicensesToolStripMenuItem
			// 
			this.drivingLicensesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.drivingLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNewDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.toolStripSeparator1,
            this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem,
            this.toolStripSeparator2,
            this.releaseDetainedDrivingLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem1});
			this.drivingLicensesToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Driver_License_32;
			this.drivingLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.drivingLicensesToolStripMenuItem.Name = "drivingLicensesToolStripMenuItem";
			this.drivingLicensesToolStripMenuItem.Size = new System.Drawing.Size(384, 70);
			this.drivingLicensesToolStripMenuItem.Text = "&Driving Licenses Services";
			// 
			// oNewDrivingLicenseToolStripMenuItem
			// 
			this.oNewDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
			this.oNewDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.oNewDrivingLicenseToolStripMenuItem.Name = "oNewDrivingLicenseToolStripMenuItem";
			this.oNewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(483, 32);
			this.oNewDrivingLicenseToolStripMenuItem.Text = "&New Driving License";
			// 
			// localLicenseToolStripMenuItem
			// 
			this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
			this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
			this.localLicenseToolStripMenuItem.Text = "&Local License";
			// 
			// internationalLicenseToolStripMenuItem
			// 
			this.internationalLicenseToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
			this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
			this.internationalLicenseToolStripMenuItem.Text = "&International License";
			// 
			// renewDrivingLicenseToolStripMenuItem
			// 
			this.renewDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
			this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(483, 32);
			this.renewDrivingLicenseToolStripMenuItem.Text = "&Renew Driving License";
			this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(480, 6);
			// 
			// ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem
			// 
			this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.Name = "ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem";
			this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(483, 32);
			this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.Text = "Replacement for Lost or &Damaged License";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(480, 6);
			// 
			// releaseDetainedDrivingLicenseToolStripMenuItem
			// 
			this.releaseDetainedDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
			this.releaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(483, 32);
			this.releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
			// 
			// retakeTestToolStripMenuItem1
			// 
			this.retakeTestToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.retakeTestToolStripMenuItem1.Name = "retakeTestToolStripMenuItem1";
			this.retakeTestToolStripMenuItem1.Size = new System.Drawing.Size(483, 32);
			this.retakeTestToolStripMenuItem1.Text = "Retake Test";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(381, 6);
			// 
			// tsMManageApplications
			// 
			this.tsMManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLocalDrivingLicenseApplicationsToolStripMenuItem,
            this.ManageInternationaDrivingLicenseToolStripMenuItem1});
			this.tsMManageApplications.Image = global::MY_DVLD.Properties.Resources.Applications_64;
			this.tsMManageApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsMManageApplications.Name = "tsMManageApplications";
			this.tsMManageApplications.Size = new System.Drawing.Size(384, 70);
			this.tsMManageApplications.Text = "Manage Applications";
			// 
			// manageLocalDrivingLicenseApplicationsToolStripMenuItem
			// 
			this.manageLocalDrivingLicenseApplicationsToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.License_Type_32;
			this.manageLocalDrivingLicenseApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.manageLocalDrivingLicenseApplicationsToolStripMenuItem.Name = "manageLocalDrivingLicenseApplicationsToolStripMenuItem";
			this.manageLocalDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(424, 38);
			this.manageLocalDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
			this.manageLocalDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageLocalDrivingLicenseApplicationsToolStripMenuItem_Click);
			// 
			// ManageInternationaDrivingLicenseToolStripMenuItem1
			// 
			this.ManageInternationaDrivingLicenseToolStripMenuItem1.Image = global::MY_DVLD.Properties.Resources.International_32;
			this.ManageInternationaDrivingLicenseToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ManageInternationaDrivingLicenseToolStripMenuItem1.Name = "ManageInternationaDrivingLicenseToolStripMenuItem1";
			this.ManageInternationaDrivingLicenseToolStripMenuItem1.Size = new System.Drawing.Size(424, 38);
			this.ManageInternationaDrivingLicenseToolStripMenuItem1.Text = "International License Applications";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(381, 6);
			// 
			// DetainLicensesToolStripMenuItem1
			// 
			this.DetainLicensesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageDetainedLicensestoolStripMenuItem1,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
			this.DetainLicensesToolStripMenuItem1.Image = global::MY_DVLD.Properties.Resources.Detain_64;
			this.DetainLicensesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.DetainLicensesToolStripMenuItem1.Name = "DetainLicensesToolStripMenuItem1";
			this.DetainLicensesToolStripMenuItem1.Size = new System.Drawing.Size(384, 70);
			this.DetainLicensesToolStripMenuItem1.Text = "Detain Licenses";
			// 
			// ManageDetainedLicensestoolStripMenuItem1
			// 
			this.ManageDetainedLicensestoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ManageDetainedLicensestoolStripMenuItem1.Name = "ManageDetainedLicensestoolStripMenuItem1";
			this.ManageDetainedLicensestoolStripMenuItem1.Size = new System.Drawing.Size(336, 32);
			this.ManageDetainedLicensestoolStripMenuItem1.Text = "Manage Detained Licenses";
			// 
			// detainLicenseToolStripMenuItem
			// 
			this.detainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
			this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
			this.detainLicenseToolStripMenuItem.Text = "Detain License";
			// 
			// releaseDetainedLicenseToolStripMenuItem
			// 
			this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
			this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(336, 32);
			this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
			// 
			// manageApplicationTypesToolStripMenuItem
			// 
			this.manageApplicationTypesToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Application_Types_64;
			this.manageApplicationTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
			this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(384, 70);
			this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
			this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
			// 
			// manageTestTypesToolStripMenuItem
			// 
			this.manageTestTypesToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Test_Type_64;
			this.manageTestTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
			this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(384, 70);
			this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
			// 
			// peopleToolStripMenuItem
			// 
			this.peopleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleToolStripMenuItem.Image")));
			this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
			this.peopleToolStripMenuItem.Size = new System.Drawing.Size(151, 68);
			this.peopleToolStripMenuItem.Text = "People";
			this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
			// 
			// driversToolStripMenuItem
			// 
			this.driversToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Drivers_64;
			this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
			this.driversToolStripMenuItem.Size = new System.Drawing.Size(156, 68);
			this.driversToolStripMenuItem.Text = "Drivers";
			this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
			// 
			// employeesToolStripMenuItem
			// 
			this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listUsersToolStripMenuItem});
			this.employeesToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.users_64;
			this.employeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
			this.employeesToolStripMenuItem.Size = new System.Drawing.Size(139, 68);
			this.employeesToolStripMenuItem.Text = "Users";
			// 
			// listUsersToolStripMenuItem
			// 
			this.listUsersToolStripMenuItem.Name = "listUsersToolStripMenuItem";
			this.listUsersToolStripMenuItem.Size = new System.Drawing.Size(168, 32);
			this.listUsersToolStripMenuItem.Text = "ListUsers";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator4,
            this.signOutToolStripMenuItem});
			this.closeToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.account_settings_64;
			this.closeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(249, 68);
			this.closeToolStripMenuItem.Text = "Account Settings";
			// 
			// currentUserInfoToolStripMenuItem
			// 
			this.currentUserInfoToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.PersonDetails_32;
			this.currentUserInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
			this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
			this.currentUserInfoToolStripMenuItem.Text = "&Current User Info";
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Password_32;
			this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
			this.changePasswordToolStripMenuItem.Text = "Change Password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(262, 6);
			// 
			// signOutToolStripMenuItem
			// 
			this.signOutToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Sign_Out_32;
			this.signOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
			this.signOutToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
			this.signOutToolStripMenuItem.Text = "Sign &Out";
			this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
			// 
			// frmMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1142, 750);
			this.Controls.Add(this.msMainMenue);
			this.Name = "frmMainForm";
			this.Text = "MY_DVLD";
			this.msMainMenue.ResumeLayout(false);
			this.msMainMenue.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msMainMenue;
		private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem drivingLicensesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oNewDrivingLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem tsMManageApplications;
		private System.Windows.Forms.ToolStripMenuItem manageLocalDrivingLicenseApplicationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ManageInternationaDrivingLicenseToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem DetainLicensesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ManageDetainedLicensestoolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listUsersToolStripMenuItem;
	}
}

