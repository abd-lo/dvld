namespace MY_DVLD.Users
{
	partial class frmShowUserDetails
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
			this.ucUserInfo1 = new MY_DVLD.Users.Controls.ucUserInfo();
			this.SuspendLayout();
			// 
			// ucUserInfo1
			// 
			this.ucUserInfo1.Location = new System.Drawing.Point(8, 3);
			this.ucUserInfo1.Name = "ucUserInfo1";
			this.ucUserInfo1.Size = new System.Drawing.Size(826, 528);
			this.ucUserInfo1.TabIndex = 1;
			// 
			// frmShowUserDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 534);
			this.Controls.Add(this.ucUserInfo1);
			this.Name = "frmShowUserDetails";
			this.Text = "frmShowUserDetails";
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.ucUserInfo ucUserInfo1;
	}
}