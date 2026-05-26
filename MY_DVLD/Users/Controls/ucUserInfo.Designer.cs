namespace MY_DVLD.Users.Controls
{
	partial class ucUserInfo
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
			this.ucPersonCard1 = new MY_DVLD.People.Controls.ucPersonCard();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbUserID = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.Label();
			this.lbIsActive = new System.Windows.Forms.Label();
			this.lbUserName = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ucPersonCard1
			// 
			this.ucPersonCard1.Location = new System.Drawing.Point(0, 3);
			this.ucPersonCard1.Name = "ucPersonCard1";
			this.ucPersonCard1.Size = new System.Drawing.Size(821, 293);
			this.ucPersonCard1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lbUserName);
			this.groupBox1.Controls.Add(this.lbIsActive);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.lbUserID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.groupBox1.Location = new System.Drawing.Point(0, 329);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(818, 128);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login Info";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
			this.label1.Location = new System.Drawing.Point(6, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "UserID:";
			// 
			// lbUserID
			// 
			this.lbUserID.AutoSize = true;
			this.lbUserID.Font = new System.Drawing.Font("Tahoma", 14F);
			this.lbUserID.Location = new System.Drawing.Point(80, 50);
			this.lbUserID.Name = "lbUserID";
			this.lbUserID.Size = new System.Drawing.Size(46, 23);
			this.lbUserID.TabIndex = 1;
			this.lbUserID.Text = "????";
			// 
			// txtUsername
			// 
			this.txtUsername.AutoSize = true;
			this.txtUsername.Font = new System.Drawing.Font("Tahoma", 14F);
			this.txtUsername.Location = new System.Drawing.Point(161, 50);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(94, 23);
			this.txtUsername.TabIndex = 2;
			this.txtUsername.Text = "Username";
			// 
			// lbIsActive
			// 
			this.lbIsActive.AutoSize = true;
			this.lbIsActive.Font = new System.Drawing.Font("Tahoma", 14F);
			this.lbIsActive.Location = new System.Drawing.Point(428, 50);
			this.lbIsActive.Name = "lbIsActive";
			this.lbIsActive.Size = new System.Drawing.Size(46, 23);
			this.lbIsActive.TabIndex = 3;
			this.lbIsActive.Text = "????";
			// 
			// lbUserName
			// 
			this.lbUserName.AutoSize = true;
			this.lbUserName.Font = new System.Drawing.Font("Tahoma", 14F);
			this.lbUserName.Location = new System.Drawing.Point(254, 50);
			this.lbUserName.Name = "lbUserName";
			this.lbUserName.Size = new System.Drawing.Size(46, 23);
			this.lbUserName.TabIndex = 4;
			this.lbUserName.Text = "????";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
			this.label6.Location = new System.Drawing.Point(346, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "IsActive:";
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ucPersonCard1);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(826, 528);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private People.Controls.ucPersonCard ucPersonCard1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbUserName;
		private System.Windows.Forms.Label lbIsActive;
		private System.Windows.Forms.Label txtUsername;
		private System.Windows.Forms.Label lbUserID;
		private System.Windows.Forms.Label label1;
	}
}
