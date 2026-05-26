namespace MY_DVLD.Tests
{
	partial class frmListTestAppointment
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
			this.dgvTestAppointments = new System.Windows.Forms.DataGridView();
			this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddTestAppointment = new System.Windows.Forms.Button();
			this.lblRecordsCount = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1 = new MY_DVLD.Applications.Controls.UCApplicationInfoWithLocalDrivingLicenseAppInfo();
			((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
			this.cmsApplications.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(283, 124);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(441, 39);
			this.lblTitle.TabIndex = 135;
			this.lblTitle.Text = "Vision Test Appointments";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbTestTypeImage
			// 
			this.pbTestTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbTestTypeImage.Image = global::MY_DVLD.Properties.Resources.Vision_512;
			this.pbTestTypeImage.InitialImage = null;
			this.pbTestTypeImage.Location = new System.Drawing.Point(442, 14);
			this.pbTestTypeImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbTestTypeImage.Name = "pbTestTypeImage";
			this.pbTestTypeImage.Size = new System.Drawing.Size(113, 104);
			this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTestTypeImage.TabIndex = 134;
			this.pbTestTypeImage.TabStop = false;
			// 
			// dgvTestAppointments
			// 
			this.dgvTestAppointments.AllowUserToAddRows = false;
			this.dgvTestAppointments.AllowUserToDeleteRows = false;
			this.dgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTestAppointments.ContextMenuStrip = this.cmsApplications;
			this.dgvTestAppointments.Location = new System.Drawing.Point(12, 628);
			this.dgvTestAppointments.Name = "dgvTestAppointments";
			this.dgvTestAppointments.ReadOnly = true;
			this.dgvTestAppointments.Size = new System.Drawing.Size(902, 198);
			this.dgvTestAppointments.TabIndex = 137;
			// 
			// cmsApplications
			// 
			this.cmsApplications.AllowDrop = true;
			this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
			this.cmsApplications.Name = "contextMenuStrip1";
			this.cmsApplications.Size = new System.Drawing.Size(197, 102);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.edit_32;
			this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// takeTestToolStripMenuItem
			// 
			this.takeTestToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Test_32;
			this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
			this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
			this.takeTestToolStripMenuItem.Text = "Take Test";
			this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(7, 578);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(306, 39);
			this.label1.TabIndex = 138;
			this.label1.Text = "Test Appointments:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAddTestAppointment
			// 
			this.btnAddTestAppointment.Image = global::MY_DVLD.Properties.Resources.AddAppointment_32;
			this.btnAddTestAppointment.Location = new System.Drawing.Point(863, 571);
			this.btnAddTestAppointment.Name = "btnAddTestAppointment";
			this.btnAddTestAppointment.Size = new System.Drawing.Size(51, 46);
			this.btnAddTestAppointment.TabIndex = 140;
			this.btnAddTestAppointment.UseVisualStyleBackColor = true;
			this.btnAddTestAppointment.Click += new System.EventHandler(this.btnAddTestAppointment_Click);
			// 
			// lblRecordsCount
			// 
			this.lblRecordsCount.AutoSize = true;
			this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 16F);
			this.lblRecordsCount.Location = new System.Drawing.Point(119, 831);
			this.lblRecordsCount.Name = "lblRecordsCount";
			this.lblRecordsCount.Size = new System.Drawing.Size(32, 27);
			this.lblRecordsCount.TabIndex = 143;
			this.lblRecordsCount.Text = "??";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 831);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 142;
			this.label2.Text = "# Records:";
			// 
			// ucApplicationInfoWithLocalDrivingLicenseAppInfo1
			// 
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.Location = new System.Drawing.Point(21, 166);
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.Name = "ucApplicationInfoWithLocalDrivingLicenseAppInfo1";
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.Size = new System.Drawing.Size(902, 409);
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.TabIndex = 139;
			// 
			// frmListTestAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 860);
			this.Controls.Add(this.lblRecordsCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAddTestAppointment);
			this.Controls.Add(this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvTestAppointments);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pbTestTypeImage);
			this.Name = "frmListTestAppointment";
			this.Text = "frmListTestAppointment";
			this.Load += new System.EventHandler(this.frmListTestAppointment_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
			this.cmsApplications.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pbTestTypeImage;
		private System.Windows.Forms.DataGridView dgvTestAppointments;
		private System.Windows.Forms.Label label1;
		private Applications.Controls.UCApplicationInfoWithLocalDrivingLicenseAppInfo ucApplicationInfoWithLocalDrivingLicenseAppInfo1;
		private System.Windows.Forms.Button btnAddTestAppointment;
		private System.Windows.Forms.ContextMenuStrip cmsApplications;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
		private System.Windows.Forms.Label lblRecordsCount;
		private System.Windows.Forms.Label label2;
	}
}