namespace MY_DVLD.People
{
	partial class frmListPeople
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPeople));
			this.dgvListPersons = new System.Windows.Forms.DataGridView();
			this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ShowDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.AddNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblTitle = new System.Windows.Forms.Label();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbRecordsNo = new System.Windows.Forms.Label();
			this.txtFilterValue = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAddPerson = new System.Windows.Forms.Button();
			this.pbPersonImage = new System.Windows.Forms.PictureBox();
			this.pbRefresh = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvListPersons)).BeginInit();
			this.cmsPeople.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvListPersons
			// 
			this.dgvListPersons.AllowUserToAddRows = false;
			this.dgvListPersons.AllowUserToDeleteRows = false;
			this.dgvListPersons.AllowUserToOrderColumns = true;
			this.dgvListPersons.AllowUserToResizeRows = false;
			this.dgvListPersons.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvListPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListPersons.ContextMenuStrip = this.cmsPeople;
			this.dgvListPersons.GridColor = System.Drawing.SystemColors.Control;
			this.dgvListPersons.Location = new System.Drawing.Point(12, 336);
			this.dgvListPersons.Name = "dgvListPersons";
			this.dgvListPersons.ReadOnly = true;
			this.dgvListPersons.Size = new System.Drawing.Size(1258, 294);
			this.dgvListPersons.TabIndex = 0;
			this.dgvListPersons.DoubleClick += new System.EventHandler(this.dgvListPersons_DoubleClick);
			// 
			// cmsPeople
			// 
			this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.AddNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
			this.cmsPeople.Name = "contextMenuStrip1";
			this.cmsPeople.Size = new System.Drawing.Size(179, 244);
			// 
			// ShowDetailsToolStripMenuItem
			// 
			this.ShowDetailsToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.PersonDetails_32;
			this.ShowDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ShowDetailsToolStripMenuItem.Name = "ShowDetailsToolStripMenuItem";
			this.ShowDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
			this.ShowDetailsToolStripMenuItem.Text = "&Show Details";
			this.ShowDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowDetailsToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
			// 
			// AddNewPersonToolStripMenuItem
			// 
			this.AddNewPersonToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.AddPerson_32;
			this.AddNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.AddNewPersonToolStripMenuItem.Name = "AddNewPersonToolStripMenuItem";
			this.AddNewPersonToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
			this.AddNewPersonToolStripMenuItem.Text = "Add &New Person";
			this.AddNewPersonToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.edit_32;
			this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Delete_32;
			this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
			// 
			// sendEmailToolStripMenuItem
			// 
			this.sendEmailToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.send_email_32;
			this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
			this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
			this.sendEmailToolStripMenuItem.Text = "Send E&mail";
			// 
			// phoneCallToolStripMenuItem
			// 
			this.phoneCallToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.Phone_32;
			this.phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
			this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
			this.phoneCallToolStripMenuItem.Text = "Phone &Call";
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(561, 208);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(258, 39);
			this.lblTitle.TabIndex = 97;
			this.lblTitle.Text = "Manage People";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
			this.cbFilterBy.Location = new System.Drawing.Point(83, 291);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(210, 21);
			this.cbFilterBy.TabIndex = 95;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 294);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 93;
			this.label1.Text = "Filter By:";
			// 
			// lbRecordsNo
			// 
			this.lbRecordsNo.AutoSize = true;
			this.lbRecordsNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbRecordsNo.Location = new System.Drawing.Point(21, 655);
			this.lbRecordsNo.Name = "lbRecordsNo";
			this.lbRecordsNo.Size = new System.Drawing.Size(81, 16);
			this.lbRecordsNo.TabIndex = 100;
			this.lbRecordsNo.Text = "RecordsNo:";
			// 
			// txtFilterValue
			// 
			this.txtFilterValue.Location = new System.Drawing.Point(315, 291);
			this.txtFilterValue.Name = "txtFilterValue";
			this.txtFilterValue.Size = new System.Drawing.Size(186, 20);
			this.txtFilterValue.TabIndex = 102;
			this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
			this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1135, 680);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(135, 36);
			this.btnClose.TabIndex = 99;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAddPerson
			// 
			this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddPerson.Image = global::MY_DVLD.Properties.Resources.Add_Person_72;
			this.btnAddPerson.Location = new System.Drawing.Point(1048, 223);
			this.btnAddPerson.Name = "btnAddPerson";
			this.btnAddPerson.Size = new System.Drawing.Size(104, 91);
			this.btnAddPerson.TabIndex = 98;
			this.btnAddPerson.UseVisualStyleBackColor = true;
			this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
			// 
			// pbPersonImage
			// 
			this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbPersonImage.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonImage.Image")));
			this.pbPersonImage.InitialImage = null;
			this.pbPersonImage.Location = new System.Drawing.Point(568, 14);
			this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbPersonImage.Name = "pbPersonImage";
			this.pbPersonImage.Size = new System.Drawing.Size(220, 189);
			this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPersonImage.TabIndex = 96;
			this.pbPersonImage.TabStop = false;
			// 
			// pbRefresh
			// 
			this.pbRefresh.Image = global::MY_DVLD.Properties.Resources.refresh__2_;
			this.pbRefresh.Location = new System.Drawing.Point(585, 282);
			this.pbRefresh.Name = "pbRefresh";
			this.pbRefresh.Size = new System.Drawing.Size(48, 48);
			this.pbRefresh.TabIndex = 104;
			this.pbRefresh.TabStop = false;
			this.pbRefresh.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// frmListPeople
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 735);
			this.Controls.Add(this.pbRefresh);
			this.Controls.Add(this.txtFilterValue);
			this.Controls.Add(this.lbRecordsNo);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAddPerson);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pbPersonImage);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvListPersons);
			this.Name = "frmListPeople";
			this.Text = "frmListPeople";
			this.Load += new System.EventHandler(this.frmListPeople_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListPersons)).EndInit();
			this.cmsPeople.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvListPersons;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnAddPerson;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pbPersonImage;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbRecordsNo;
		private System.Windows.Forms.TextBox txtFilterValue;
		private System.Windows.Forms.ContextMenuStrip cmsPeople;
		private System.Windows.Forms.ToolStripMenuItem ShowDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem AddNewPersonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
		private System.Windows.Forms.PictureBox pbRefresh;
	}
}