namespace MY_DVLD.Licenses.Local_Driving_Licenses.Controls
{
	partial class UCDriverLicenseWithFilter
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbFilters = new System.Windows.Forms.GroupBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtLicenseID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ucLocalDrivingLicense1 = new MY_DVLD.Licenses.Local_Driving_Licenses.Controls.UCLocalDrivingLicense();
			this.gbFilters.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbFilters
			// 
			this.gbFilters.Controls.Add(this.btnFind);
			this.gbFilters.Controls.Add(this.txtLicenseID);
			this.gbFilters.Controls.Add(this.label1);
			this.gbFilters.Location = new System.Drawing.Point(129, 13);
			this.gbFilters.Name = "gbFilters";
			this.gbFilters.Size = new System.Drawing.Size(406, 63);
			this.gbFilters.TabIndex = 18;
			this.gbFilters.TabStop = false;
			this.gbFilters.Text = "Filter";
			// 
			// btnFind
			// 
			this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFind.Image = global::MY_DVLD.Properties.Resources.License_View_32;
			this.btnFind.Location = new System.Drawing.Point(342, 16);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(48, 41);
			this.btnFind.TabIndex = 18;
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// txtLicenseID
			// 
			this.txtLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLicenseID.Location = new System.Drawing.Point(113, 26);
			this.txtLicenseID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtLicenseID.Name = "txtLicenseID";
			this.txtLicenseID.Size = new System.Drawing.Size(210, 20);
			this.txtLicenseID.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 20);
			this.label1.TabIndex = 19;
			this.label1.Text = "LicenseID:";
			// 
			// ucLocalDrivingLicense1
			// 
			this.ucLocalDrivingLicense1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ucLocalDrivingLicense1.Location = new System.Drawing.Point(3, 71);
			this.ucLocalDrivingLicense1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucLocalDrivingLicense1.Name = "ucLocalDrivingLicense1";
			this.ucLocalDrivingLicense1.Size = new System.Drawing.Size(679, 544);
			this.ucLocalDrivingLicense1.TabIndex = 0;
			// 
			// UCDriverLicenseWithFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gbFilters);
			this.Controls.Add(this.ucLocalDrivingLicense1);
			this.Name = "UCDriverLicenseWithFilter";
			this.Size = new System.Drawing.Size(765, 614);
			this.gbFilters.ResumeLayout(false);
			this.gbFilters.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private UCLocalDrivingLicense ucLocalDrivingLicense1;
		private System.Windows.Forms.GroupBox gbFilters;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtLicenseID;
		private System.Windows.Forms.Label label1;
	}
}
