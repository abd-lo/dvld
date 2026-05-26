namespace MY_DVLD.Tests.TestTypes
{
	partial class frmListTestTypes
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lbRecordsNo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvTestTypes = new System.Windows.Forms.DataGridView();
			this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.pbApplicationTypes = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
			this.cmsTestTypes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(299, 219);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(446, 39);
			this.lblTitle.TabIndex = 123;
			this.lblTitle.Text = "Manage Test Types";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbRecordsNo
			// 
			this.lbRecordsNo.AutoSize = true;
			this.lbRecordsNo.Font = new System.Drawing.Font("Tahoma", 15F);
			this.lbRecordsNo.Location = new System.Drawing.Point(142, 643);
			this.lbRecordsNo.Name = "lbRecordsNo";
			this.lbRecordsNo.Size = new System.Drawing.Size(28, 24);
			this.lbRecordsNo.TabIndex = 121;
			this.lbRecordsNo.Text = "??";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 643);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 120;
			this.label2.Text = "# Records:";
			// 
			// dgvTestTypes
			// 
			this.dgvTestTypes.AllowUserToAddRows = false;
			this.dgvTestTypes.AllowUserToDeleteRows = false;
			this.dgvTestTypes.AllowUserToResizeRows = false;
			this.dgvTestTypes.BackgroundColor = System.Drawing.Color.White;
			this.dgvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTestTypes.ContextMenuStrip = this.cmsTestTypes;
			this.dgvTestTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvTestTypes.Location = new System.Drawing.Point(38, 274);
			this.dgvTestTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvTestTypes.MultiSelect = false;
			this.dgvTestTypes.Name = "dgvTestTypes";
			this.dgvTestTypes.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTestTypes.Size = new System.Drawing.Size(931, 354);
			this.dgvTestTypes.TabIndex = 119;
			this.dgvTestTypes.TabStop = false;
			// 
			// cmsTestTypes
			// 
			this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.editToolStripMenuItem,
            this.toolStripSeparator1});
			this.cmsTestTypes.Name = "contextMenuStrip1";
			this.cmsTestTypes.Size = new System.Drawing.Size(197, 76);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.edit_32;
			this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
			this.editToolStripMenuItem.Text = "&Edit Test Type";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripTestTypeEditClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
			// 
			// pbApplicationTypes
			// 
			this.pbApplicationTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbApplicationTypes.Image = global::MY_DVLD.Properties.Resources.TestType_512;
			this.pbApplicationTypes.InitialImage = null;
			this.pbApplicationTypes.Location = new System.Drawing.Point(423, 14);
			this.pbApplicationTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbApplicationTypes.Name = "pbApplicationTypes";
			this.pbApplicationTypes.Size = new System.Drawing.Size(220, 189);
			this.pbApplicationTypes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbApplicationTypes.TabIndex = 122;
			this.pbApplicationTypes.TabStop = false;
			// 
			// button1
			// 
			this.button1.AutoEllipsis = true;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(834, 643);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 36);
			this.button1.TabIndex = 124;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmListTestTypes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 736);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lbRecordsNo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvTestTypes);
			this.Controls.Add(this.pbApplicationTypes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmListTestTypes";
			this.Text = "frmEditTestType";
			this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
			this.cmsTestTypes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lbRecordsNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvTestTypes;
		private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.PictureBox pbApplicationTypes;
		private System.Windows.Forms.Button button1;
	}
}