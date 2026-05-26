namespace MY_DVLD.Licenses.Local_Driving_Licenses
{
	partial class frmShowLocalDrivingLicense
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
			this.ucLocalDrivingLicense1 = new MY_DVLD.Licenses.Local_Driving_Licenses.Controls.UCLocalDrivingLicense();
			this.SuspendLayout();
			// 
			// ucLocalDrivingLicense1
			// 
			this.ucLocalDrivingLicense1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ucLocalDrivingLicense1.Location = new System.Drawing.Point(13, 14);
			this.ucLocalDrivingLicense1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucLocalDrivingLicense1.Name = "ucLocalDrivingLicense1";
			this.ucLocalDrivingLicense1.Size = new System.Drawing.Size(948, 541);
			this.ucLocalDrivingLicense1.TabIndex = 0;
			// 
			// frmShowLocalDrivingLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 579);
			this.Controls.Add(this.ucLocalDrivingLicense1);
			this.Name = "frmShowLocalDrivingLicense";
			this.Text = "frmShowLocalDrivingLicense";
			this.Load += new System.EventHandler(this.frmShowLocalDrivingLicense_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.UCLocalDrivingLicense ucLocalDrivingLicense1;
	}
}