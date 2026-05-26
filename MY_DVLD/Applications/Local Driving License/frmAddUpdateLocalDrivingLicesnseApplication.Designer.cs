namespace MY_DVLD.Applications.Local_Driving_License
{
	partial class frmAddUpdateLocalDrivingLicesnseApplication
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.tcApplicationInfo = new System.Windows.Forms.TabControl();
			this.tpPersonInfo = new System.Windows.Forms.TabPage();
			this.ucPersonCardWithFind1 = new MY_DVLD.People.Controls.ucPersonCardWithFind();
			this.tpApplicationInfo = new System.Windows.Forms.TabPage();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCreatedByUser = new System.Windows.Forms.Label();
			this.lblFees = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.cbLicenseClass = new System.Windows.Forms.ComboBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label15 = new System.Windows.Forms.Label();
			this.lblApplicationDate = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblLocalDrivingLicebseApplicationID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.tcApplicationInfo.SuspendLayout();
			this.tpPersonInfo.SuspendLayout();
			this.tpApplicationInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 15F);
			this.btnSave.Image = global::MY_DVLD.Properties.Resources.Save_32;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.Location = new System.Drawing.Point(688, 621);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(163, 50);
			this.btnSave.TabIndex = 102;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 15F);
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.Location = new System.Drawing.Point(519, 621);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(163, 50);
			this.btnClose.TabIndex = 101;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Tahoma", 15F);
			this.btnNext.Image = global::MY_DVLD.Properties.Resources.Next_32;
			this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNext.Location = new System.Drawing.Point(672, 467);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(163, 50);
			this.btnNext.TabIndex = 100;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// tcApplicationInfo
			// 
			this.tcApplicationInfo.Controls.Add(this.tpPersonInfo);
			this.tcApplicationInfo.Controls.Add(this.tpApplicationInfo);
			this.tcApplicationInfo.Font = new System.Drawing.Font("Tahoma", 12F);
			this.tcApplicationInfo.ItemSize = new System.Drawing.Size(20, 30);
			this.tcApplicationInfo.Location = new System.Drawing.Point(12, 51);
			this.tcApplicationInfo.Name = "tcApplicationInfo";
			this.tcApplicationInfo.SelectedIndex = 0;
			this.tcApplicationInfo.Size = new System.Drawing.Size(869, 566);
			this.tcApplicationInfo.TabIndex = 101;
			// 
			// tpPersonInfo
			// 
			this.tpPersonInfo.Controls.Add(this.btnNext);
			this.tpPersonInfo.Controls.Add(this.ucPersonCardWithFind1);
			this.tpPersonInfo.Font = new System.Drawing.Font("Tahoma", 8F);
			this.tpPersonInfo.Location = new System.Drawing.Point(4, 34);
			this.tpPersonInfo.Name = "tpPersonInfo";
			this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpPersonInfo.Size = new System.Drawing.Size(861, 528);
			this.tpPersonInfo.TabIndex = 0;
			this.tpPersonInfo.Text = "Person Info";
			this.tpPersonInfo.UseVisualStyleBackColor = true;
			// 
			// ucPersonCardWithFind1
			// 
			this.ucPersonCardWithFind1.FilterEnabled = true;
			this.ucPersonCardWithFind1.Location = new System.Drawing.Point(6, 23);
			this.ucPersonCardWithFind1.Name = "ucPersonCardWithFind1";
			this.ucPersonCardWithFind1.ShowAddPersonButton = true;
			this.ucPersonCardWithFind1.ShowFindButton = true;
			this.ucPersonCardWithFind1.Size = new System.Drawing.Size(829, 404);
			this.ucPersonCardWithFind1.TabIndex = 0;
			this.ucPersonCardWithFind1.OnPersonSelectedEvent += new System.Action<int>(this.ucPersonCardWithFind1_OnPersonSelectedEvent);
			// 
			// tpApplicationInfo
			// 
			this.tpApplicationInfo.Controls.Add(this.pictureBox2);
			this.tpApplicationInfo.Controls.Add(this.pictureBox1);
			this.tpApplicationInfo.Controls.Add(this.label1);
			this.tpApplicationInfo.Controls.Add(this.lblCreatedByUser);
			this.tpApplicationInfo.Controls.Add(this.lblFees);
			this.tpApplicationInfo.Controls.Add(this.label2);
			this.tpApplicationInfo.Controls.Add(this.pictureBox3);
			this.tpApplicationInfo.Controls.Add(this.cbLicenseClass);
			this.tpApplicationInfo.Controls.Add(this.pictureBox6);
			this.tpApplicationInfo.Controls.Add(this.label15);
			this.tpApplicationInfo.Controls.Add(this.lblApplicationDate);
			this.tpApplicationInfo.Controls.Add(this.pictureBox4);
			this.tpApplicationInfo.Controls.Add(this.label5);
			this.tpApplicationInfo.Controls.Add(this.lblLocalDrivingLicebseApplicationID);
			this.tpApplicationInfo.Controls.Add(this.label4);
			this.tpApplicationInfo.Location = new System.Drawing.Point(4, 34);
			this.tpApplicationInfo.Name = "tpApplicationInfo";
			this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpApplicationInfo.Size = new System.Drawing.Size(861, 528);
			this.tpApplicationInfo.TabIndex = 1;
			this.tpApplicationInfo.Text = "Application Info";
			this.tpApplicationInfo.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MY_DVLD.Properties.Resources.Number_32;
			this.pictureBox2.Location = new System.Drawing.Point(190, 69);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(31, 26);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 159;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MY_DVLD.Properties.Resources.User_32__2;
			this.pictureBox1.Location = new System.Drawing.Point(189, 221);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 158;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 221);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 157;
			this.label1.Text = "Created By:";
			// 
			// lblCreatedByUser
			// 
			this.lblCreatedByUser.AutoSize = true;
			this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreatedByUser.Location = new System.Drawing.Point(228, 221);
			this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCreatedByUser.Name = "lblCreatedByUser";
			this.lblCreatedByUser.Size = new System.Drawing.Size(59, 20);
			this.lblCreatedByUser.TabIndex = 156;
			this.lblCreatedByUser.Text = "[????]";
			// 
			// lblFees
			// 
			this.lblFees.AutoSize = true;
			this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFees.Location = new System.Drawing.Point(228, 185);
			this.lblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFees.Name = "lblFees";
			this.lblFees.Size = new System.Drawing.Size(49, 20);
			this.lblFees.TabIndex = 155;
			this.lblFees.Text = "[$$$]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 183);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 20);
			this.label2.TabIndex = 153;
			this.label2.Text = "Application Fees:";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MY_DVLD.Properties.Resources.money_32;
			this.pictureBox3.Location = new System.Drawing.Point(189, 184);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(31, 26);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 154;
			this.pictureBox3.TabStop = false;
			// 
			// cbLicenseClass
			// 
			this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLicenseClass.FormattingEnabled = true;
			this.cbLicenseClass.Location = new System.Drawing.Point(228, 146);
			this.cbLicenseClass.Name = "cbLicenseClass";
			this.cbLicenseClass.Size = new System.Drawing.Size(270, 27);
			this.cbLicenseClass.TabIndex = 150;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::MY_DVLD.Properties.Resources.Application_Types_64;
			this.pictureBox6.Location = new System.Drawing.Point(189, 146);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(31, 26);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 152;
			this.pictureBox6.TabStop = false;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(19, 145);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(125, 20);
			this.label15.TabIndex = 151;
			this.label15.Text = "License Class:";
			// 
			// lblApplicationDate
			// 
			this.lblApplicationDate.AutoSize = true;
			this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApplicationDate.Location = new System.Drawing.Point(228, 111);
			this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblApplicationDate.Name = "lblApplicationDate";
			this.lblApplicationDate.Size = new System.Drawing.Size(109, 20);
			this.lblApplicationDate.TabIndex = 149;
			this.lblApplicationDate.Text = "[??/??/????]";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::MY_DVLD.Properties.Resources.Calendar_32;
			this.pictureBox4.Location = new System.Drawing.Point(190, 105);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(31, 26);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 148;
			this.pictureBox4.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(19, 107);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 20);
			this.label5.TabIndex = 147;
			this.label5.Text = "Application Date:";
			// 
			// lblLocalDrivingLicebseApplicationID
			// 
			this.lblLocalDrivingLicebseApplicationID.AutoSize = true;
			this.lblLocalDrivingLicebseApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocalDrivingLicebseApplicationID.Location = new System.Drawing.Point(228, 69);
			this.lblLocalDrivingLicebseApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLocalDrivingLicebseApplicationID.Name = "lblLocalDrivingLicebseApplicationID";
			this.lblLocalDrivingLicebseApplicationID.Size = new System.Drawing.Size(49, 20);
			this.lblLocalDrivingLicebseApplicationID.TabIndex = 146;
			this.lblLocalDrivingLicebseApplicationID.Text = "[???]";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 69);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 20);
			this.label4.TabIndex = 145;
			this.label4.Text = "D.L.Application ID:";
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(15, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(869, 39);
			this.lblTitle.TabIndex = 123;
			this.lblTitle.Text = "Local Driving License Application";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmAddUpdateLocalDrivingLicesnseApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 692);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.tcApplicationInfo);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Name = "frmAddUpdateLocalDrivingLicesnseApplication";
			this.Text = "frmAddUpdate";
			this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicesnseApplication_Load);
			this.tcApplicationInfo.ResumeLayout(false);
			this.tpPersonInfo.ResumeLayout(false);
			this.tpApplicationInfo.ResumeLayout(false);
			this.tpApplicationInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private People.Controls.ucPersonCardWithFind ucPersonCardWithFind1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.TabControl tcApplicationInfo;
		private System.Windows.Forms.TabPage tpApplicationInfo;
		private System.Windows.Forms.TabPage tpPersonInfo;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCreatedByUser;
		private System.Windows.Forms.Label lblFees;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.ComboBox cbLicenseClass;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lblApplicationDate;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblLocalDrivingLicebseApplicationID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblTitle;
	}
}