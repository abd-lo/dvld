namespace MY_DVLD.Licenses
{
	partial class frmShowDrivingLicenseHistory
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
			this.pbPersonImage = new System.Windows.Forms.PictureBox();
			this.ucDriverLicenses1 = new MY_DVLD.Licenses.Controls.UCDriverLicenses();
			this.ucPersonCardWithFind1 = new MY_DVLD.People.Controls.ucPersonCardWithFind();
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(12, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(1062, 39);
			this.lblTitle.TabIndex = 132;
			this.lblTitle.Text = "License History";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbPersonImage
			// 
			this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbPersonImage.Image = global::MY_DVLD.Properties.Resources.PersonLicenseHistory_512;
			this.pbPersonImage.InitialImage = null;
			this.pbPersonImage.Location = new System.Drawing.Point(19, 53);
			this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbPersonImage.Name = "pbPersonImage";
			this.pbPersonImage.Size = new System.Drawing.Size(149, 124);
			this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPersonImage.TabIndex = 131;
			this.pbPersonImage.TabStop = false;
			// 
			// ucDriverLicenses1
			// 
			this.ucDriverLicenses1.Location = new System.Drawing.Point(12, 481);
			this.ucDriverLicenses1.Name = "ucDriverLicenses1";
			this.ucDriverLicenses1.Size = new System.Drawing.Size(1059, 344);
			this.ucDriverLicenses1.TabIndex = 134;
			// 
			// ucPersonCardWithFind1
			// 
			this.ucPersonCardWithFind1.FilterEnabled = true;
			this.ucPersonCardWithFind1.Location = new System.Drawing.Point(190, 53);
			this.ucPersonCardWithFind1.Name = "ucPersonCardWithFind1";
			this.ucPersonCardWithFind1.ShowAddPersonButton = true;
			this.ucPersonCardWithFind1.ShowFindButton = true;
			this.ucPersonCardWithFind1.Size = new System.Drawing.Size(829, 404);
			this.ucPersonCardWithFind1.TabIndex = 133;
			this.ucPersonCardWithFind1.OnPersonSelectedEvent += new System.Action<int>(this.ucPersonCardWithFind1_OnPersonSelectedEvent);
			// 
			// frmShowDrivingLicenseHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 865);
			this.Controls.Add(this.ucDriverLicenses1);
			this.Controls.Add(this.ucPersonCardWithFind1);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pbPersonImage);
			this.Name = "frmShowDrivingLicenseHistory";
			this.Text = "frmShowDrivingLicenseHistory";
			this.Load += new System.EventHandler(this.frmShowDrivingLicenseHistory_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbPersonImage;
		private System.Windows.Forms.Label lblTitle;
		private People.Controls.ucPersonCardWithFind ucPersonCardWithFind1;
		private Controls.UCDriverLicenses ucDriverLicenses1;
	}
}