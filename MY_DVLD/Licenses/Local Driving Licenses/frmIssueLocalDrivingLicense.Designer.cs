namespace MY_DVLD.Licenses.Local_Driving_Licenses
{
	partial class frmIssueLocalDrivingLicense
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
			this.rtxtNotes = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnIssue = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1 = new MY_DVLD.Applications.Controls.UCApplicationInfoWithLocalDrivingLicenseAppInfo();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// rtxtNotes
			// 
			this.rtxtNotes.Location = new System.Drawing.Point(115, 459);
			this.rtxtNotes.Name = "rtxtNotes";
			this.rtxtNotes.Size = new System.Drawing.Size(746, 224);
			this.rtxtNotes.TabIndex = 2;
			this.rtxtNotes.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
			this.label1.Location = new System.Drawing.Point(8, 459);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Notes:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MY_DVLD.Properties.Resources.Notes_32;
			this.pictureBox1.Location = new System.Drawing.Point(82, 459);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(27, 30);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// btnIssue
			// 
			this.btnIssue.Font = new System.Drawing.Font("Tahoma", 8F);
			this.btnIssue.Image = global::MY_DVLD.Properties.Resources.IssueDrivingLicense_32;
			this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIssue.Location = new System.Drawing.Point(735, 730);
			this.btnIssue.Name = "btnIssue";
			this.btnIssue.Size = new System.Drawing.Size(126, 39);
			this.btnIssue.TabIndex = 7;
			this.btnIssue.Text = "Issue";
			this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnIssue.UseVisualStyleBackColor = true;
			this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(603, 732);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(126, 37);
			this.btnClose.TabIndex = 209;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// ucApplicationInfoWithLocalDrivingLicenseAppInfo1
			// 
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.Location = new System.Drawing.Point(12, 27);
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.Name = "ucApplicationInfoWithLocalDrivingLicenseAppInfo1";
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.Size = new System.Drawing.Size(902, 456);
			this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1.TabIndex = 1;
			// 
			// frmIssueLocalDrivingLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 816);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnIssue);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rtxtNotes);
			this.Controls.Add(this.ucApplicationInfoWithLocalDrivingLicenseAppInfo1);
			this.MaximizeBox = false;
			this.Name = "frmIssueLocalDrivingLicense";
			this.Text = "frmIssueLocalDrivingLicense";
			this.Load += new System.EventHandler(this.frmIssueLocalDrivingLicense_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Applications.Controls.UCApplicationInfoWithLocalDrivingLicenseAppInfo ucApplicationInfoWithLocalDrivingLicenseAppInfo1;
		private System.Windows.Forms.RichTextBox rtxtNotes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnIssue;
		private System.Windows.Forms.Button btnClose;
	}
}