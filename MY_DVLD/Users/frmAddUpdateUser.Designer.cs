namespace MY_DVLD.Users
{
	partial class frmAddUpdateUser
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
			this.btnNext = new System.Windows.Forms.Button();
			this.tcUser = new System.Windows.Forms.TabControl();
			this.tpPersonInfo = new System.Windows.Forms.TabPage();
			this.ucPersonCardWithFind1 = new MY_DVLD.People.Controls.ucPersonCardWithFind();
			this.tpLoginInfo = new System.Windows.Forms.TabPage();
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbUserID = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tcUser.SuspendLayout();
			this.tpPersonInfo.SuspendLayout();
			this.tpLoginInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Tahoma", 15F);
			this.btnNext.Image = global::MY_DVLD.Properties.Resources.Next_32;
			this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNext.Location = new System.Drawing.Point(670, 425);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(163, 50);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// tcUser
			// 
			this.tcUser.Controls.Add(this.tpPersonInfo);
			this.tcUser.Controls.Add(this.tpLoginInfo);
			this.tcUser.Location = new System.Drawing.Point(12, 75);
			this.tcUser.Name = "tcUser";
			this.tcUser.SelectedIndex = 0;
			this.tcUser.Size = new System.Drawing.Size(879, 535);
			this.tcUser.TabIndex = 2;
			// 
			// tpPersonInfo
			// 
			this.tpPersonInfo.Controls.Add(this.ucPersonCardWithFind1);
			this.tpPersonInfo.Controls.Add(this.btnNext);
			this.tpPersonInfo.Font = new System.Drawing.Font("Tahoma", 8F);
			this.tpPersonInfo.Location = new System.Drawing.Point(4, 22);
			this.tpPersonInfo.Name = "tpPersonInfo";
			this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpPersonInfo.Size = new System.Drawing.Size(871, 509);
			this.tpPersonInfo.TabIndex = 0;
			this.tpPersonInfo.Text = "PersonInfo";
			this.tpPersonInfo.UseVisualStyleBackColor = true;
			// 
			// ucPersonCardWithFind1
			// 
			this.ucPersonCardWithFind1.FilterEnabled = true;
			this.ucPersonCardWithFind1.Location = new System.Drawing.Point(0, 0);
			this.ucPersonCardWithFind1.Margin = new System.Windows.Forms.Padding(6);
			this.ucPersonCardWithFind1.Name = "ucPersonCardWithFind1";
			this.ucPersonCardWithFind1.ShowAddPersonButton = true;
			this.ucPersonCardWithFind1.ShowFindButton = true;
			this.ucPersonCardWithFind1.Size = new System.Drawing.Size(833, 416);
			this.ucPersonCardWithFind1.TabIndex = 2;
			// 
			// tpLoginInfo
			// 
			this.tpLoginInfo.Controls.Add(this.chkIsActive);
			this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
			this.tpLoginInfo.Controls.Add(this.txtPassword);
			this.tpLoginInfo.Controls.Add(this.txtUserName);
			this.tpLoginInfo.Controls.Add(this.pictureBox2);
			this.tpLoginInfo.Controls.Add(this.label4);
			this.tpLoginInfo.Controls.Add(this.pictureBox1);
			this.tpLoginInfo.Controls.Add(this.label2);
			this.tpLoginInfo.Controls.Add(this.pictureBox8);
			this.tpLoginInfo.Controls.Add(this.pictureBox10);
			this.tpLoginInfo.Controls.Add(this.label22);
			this.tpLoginInfo.Controls.Add(this.label1);
			this.tpLoginInfo.Controls.Add(this.lbUserID);
			this.tpLoginInfo.Location = new System.Drawing.Point(4, 22);
			this.tpLoginInfo.Name = "tpLoginInfo";
			this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpLoginInfo.Size = new System.Drawing.Size(871, 509);
			this.tpLoginInfo.TabIndex = 1;
			this.tpLoginInfo.Text = "LoginInfo";
			this.tpLoginInfo.UseVisualStyleBackColor = true;
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.Font = new System.Drawing.Font("Tahoma", 12F);
			this.chkIsActive.Location = new System.Drawing.Point(275, 238);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(89, 23);
			this.chkIsActive.TabIndex = 167;
			this.chkIsActive.Text = "Is Active";
			this.chkIsActive.UseVisualStyleBackColor = true;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 13F);
			this.txtConfirmPassword.Location = new System.Drawing.Point(280, 189);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(140, 28);
			this.txtConfirmPassword.TabIndex = 166;
			this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Tahoma", 13F);
			this.txtPassword.Location = new System.Drawing.Point(280, 152);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(140, 28);
			this.txtPassword.TabIndex = 165;
			this.txtPassword.Text = " ";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Tahoma", 13F);
			this.txtUserName.Location = new System.Drawing.Point(280, 115);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(140, 28);
			this.txtUserName.TabIndex = 164;
			this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MY_DVLD.Properties.Resources.Number_32;
			this.pictureBox2.Location = new System.Drawing.Point(234, 189);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(31, 26);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 160;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(69, 189);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 20);
			this.label4.TabIndex = 158;
			this.label4.Text = "Confirm Password:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MY_DVLD.Properties.Resources.Number_32;
			this.pictureBox1.Location = new System.Drawing.Point(234, 154);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 157;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(69, 154);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 155;
			this.label2.Text = "Password:";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::MY_DVLD.Properties.Resources.Person_32;
			this.pictureBox8.Location = new System.Drawing.Point(234, 119);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(31, 26);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 148;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = global::MY_DVLD.Properties.Resources.Number_32;
			this.pictureBox10.Location = new System.Drawing.Point(234, 84);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(31, 26);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox10.TabIndex = 154;
			this.pictureBox10.TabStop = false;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(69, 84);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(71, 20);
			this.label22.TabIndex = 150;
			this.label22.Text = "User ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(69, 119);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 151;
			this.label1.Text = "User Name:";
			// 
			// lbUserID
			// 
			this.lbUserID.AutoSize = true;
			this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUserID.Location = new System.Drawing.Point(276, 84);
			this.lbUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbUserID.Name = "lbUserID";
			this.lbUserID.Size = new System.Drawing.Size(53, 20);
			this.lbUserID.TabIndex = 152;
			this.lbUserID.Text = "[????]";
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbTitle.Location = new System.Drawing.Point(350, 33);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(258, 39);
			this.lbTitle.TabIndex = 98;
			this.lbTitle.Text = "Add New User";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 15F);
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.Location = new System.Drawing.Point(589, 646);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(163, 50);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 15F);
			this.btnSave.Image = global::MY_DVLD.Properties.Resources.Save_32;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.Location = new System.Drawing.Point(758, 646);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(163, 50);
			this.btnSave.TabIndex = 99;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmAddUpdateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 725);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.tcUser);
			this.Name = "frmAddUpdateUser";
			this.Text = "frmAddNewUser";
			this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
			this.tcUser.ResumeLayout(false);
			this.tpPersonInfo.ResumeLayout(false);
			this.tpLoginInfo.ResumeLayout(false);
			this.tpLoginInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.TabControl tcUser;
		private System.Windows.Forms.TabPage tpPersonInfo;
		private People.Controls.ucPersonCardWithFind ucPersonCardWithFind1;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.TabPage tpLoginInfo;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbUserID;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox chkIsActive;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}