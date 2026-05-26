namespace MY_DVLD.Users
{
	partial class frmChangeUserPassword
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
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.txtCurrentPassword = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.ucUserInfo1 = new MY_DVLD.Users.Controls.ucUserInfo();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 13F);
			this.txtNewPassword.Location = new System.Drawing.Point(287, 556);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.Size = new System.Drawing.Size(140, 28);
			this.txtNewPassword.TabIndex = 172;
			this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
			// 
			// txtCurrentPassword
			// 
			this.txtCurrentPassword.Font = new System.Drawing.Font("Tahoma", 13F);
			this.txtCurrentPassword.Location = new System.Drawing.Point(287, 519);
			this.txtCurrentPassword.Name = "txtCurrentPassword";
			this.txtCurrentPassword.Size = new System.Drawing.Size(140, 28);
			this.txtCurrentPassword.TabIndex = 171;
			this.txtCurrentPassword.Text = " ";
			this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MY_DVLD.Properties.Resources.Number_32;
			this.pictureBox2.Location = new System.Drawing.Point(241, 556);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(31, 26);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 170;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(76, 556);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 20);
			this.label4.TabIndex = 169;
			this.label4.Text = "New Password:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MY_DVLD.Properties.Resources.Number_32;
			this.pictureBox1.Location = new System.Drawing.Point(241, 521);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 168;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(76, 521);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 20);
			this.label2.TabIndex = 167;
			this.label2.Text = "Current Password:";
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 13F);
			this.txtConfirmPassword.Location = new System.Drawing.Point(287, 590);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(140, 28);
			this.txtConfirmPassword.TabIndex = 175;
			this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MY_DVLD.Properties.Resources.Number_32;
			this.pictureBox3.Location = new System.Drawing.Point(241, 590);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(31, 26);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 174;
			this.pictureBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(76, 590);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 20);
			this.label1.TabIndex = 173;
			this.label1.Text = "Confirm Password:";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 15F);
			this.btnSave.Image = global::MY_DVLD.Properties.Resources.Save_32;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.Location = new System.Drawing.Point(639, 675);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(163, 50);
			this.btnSave.TabIndex = 178;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 15F);
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.Location = new System.Drawing.Point(470, 675);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(163, 50);
			this.btnClose.TabIndex = 176;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbTitle.Location = new System.Drawing.Point(136, 9);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(534, 39);
			this.lbTitle.TabIndex = 177;
			this.lbTitle.Text = "Change User Password";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ucUserInfo1
			// 
			this.ucUserInfo1.Location = new System.Drawing.Point(11, 39);
			this.ucUserInfo1.Name = "ucUserInfo1";
			this.ucUserInfo1.Size = new System.Drawing.Size(826, 460);
			this.ucUserInfo1.TabIndex = 0;
			// 
			// frmChangeUserPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 756);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.txtCurrentPassword);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ucUserInfo1);
			this.Name = "frmChangeUserPassword";
			this.Text = "frmChangeUserPassword";
			this.Load += new System.EventHandler(this.frmChangeUserPassword_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.ucUserInfo ucUserInfo1;
		private System.Windows.Forms.TextBox txtNewPassword;
		private System.Windows.Forms.TextBox txtCurrentPassword;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}