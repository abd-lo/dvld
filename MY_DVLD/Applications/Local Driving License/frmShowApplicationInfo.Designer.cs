namespace MY_DVLD.Applications.Local_Driving_License
{
	partial class frmShowApplicationInfo
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1 = new MY_DVLD.Applications.Controls.UCApplicationInfoWithLocalDrivingLicenseAppInfo();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(12, 39);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(869, 39);
			this.lblTitle.TabIndex = 124;
			this.lblTitle.Text = "Application Info";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ucApplicationInfoWithLocalDrivingLicenseAppInfo1
			// 
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.Location = new System.Drawing.Point(2, 103);
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.Name = "ucApplicationInfoWithLocalDrivingLicenseAppInfo1";
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.Size = new System.Drawing.Size(902, 456);
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.TabIndex = 125;
			// 
			// frmShowApplicationInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(907, 585);
			this.Controls.Add(this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmShowApplicationInfo";
			this.Text = "frmShowApplicationInfo";
			this.Load += new System.EventHandler(this.frmShowApplicationInfo_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblTitle;
		private Controls.UCApplicationInfoWithLocalDrivingLicenseAppInfo ucApplicationInfoWithLocalDrivingLicenseAppInfo1;
	}
}