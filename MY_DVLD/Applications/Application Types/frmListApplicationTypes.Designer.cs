namespace MY_DVLD.Applications.Application_Types
{
	partial class frmListApplicationTypes
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lbRecordsNo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
			this.cmsApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.pbApplicationTypesmage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
			this.cmsApplicationTypes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.AutoEllipsis = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(612, 641);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(135, 36);
			this.btnClose.TabIndex = 112;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(188, 219);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(446, 39);
			this.lblTitle.TabIndex = 117;
			this.lblTitle.Text = "Manage Application Types";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbRecordsNo
			// 
			this.lbRecordsNo.AutoSize = true;
			this.lbRecordsNo.Location = new System.Drawing.Point(172, 648);
			this.lbRecordsNo.Name = "lbRecordsNo";
			this.lbRecordsNo.Size = new System.Drawing.Size(17, 13);
			this.lbRecordsNo.TabIndex = 115;
			this.lbRecordsNo.Text = "??";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(70, 648);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 114;
			this.label2.Text = "# Records:";
			// 
			// dgvApplicationTypes
			// 
			this.dgvApplicationTypes.AllowUserToAddRows = false;
			this.dgvApplicationTypes.AllowUserToDeleteRows = false;
			this.dgvApplicationTypes.AllowUserToResizeRows = false;
			this.dgvApplicationTypes.BackgroundColor = System.Drawing.Color.White;
			this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvApplicationTypes.ContextMenuStrip = this.cmsApplicationTypes;
			this.dgvApplicationTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvApplicationTypes.Location = new System.Drawing.Point(68, 279);
			this.dgvApplicationTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvApplicationTypes.MultiSelect = false;
			this.dgvApplicationTypes.Name = "dgvApplicationTypes";
			this.dgvApplicationTypes.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvApplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvApplicationTypes.Size = new System.Drawing.Size(679, 354);
			this.dgvApplicationTypes.TabIndex = 113;
			this.dgvApplicationTypes.TabStop = false;
			// 
			// cmsApplicationTypes
			// 
			this.cmsApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.editToolStripMenuItem,
            this.toolStripSeparator1});
			this.cmsApplicationTypes.Name = "contextMenuStrip1";
			this.cmsApplicationTypes.Size = new System.Drawing.Size(202, 54);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
			// 
			// editToolStripMenuItem
			// 
						//this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;

			this.editToolStripMenuItem.Image = global::MY_DVLD.Properties.Resources.edit_32;
			this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(201, 38);
			this.editToolStripMenuItem.Text = "&Edit Application Type";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripApplicationEditClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
			// 
			// pbApplicationTypesmage
			// 
			this.pbApplicationTypesmage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbApplicationTypesmage.Image = global::MY_DVLD.Properties.Resources.Application_Types_512;
			this.pbApplicationTypesmage.InitialImage = null;
			this.pbApplicationTypesmage.Location = new System.Drawing.Point(312, 14);
			this.pbApplicationTypesmage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbApplicationTypesmage.Name = "pbApplicationTypesmage";
			this.pbApplicationTypesmage.Size = new System.Drawing.Size(220, 189);
			this.pbApplicationTypesmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbApplicationTypesmage.TabIndex = 116;
			this.pbApplicationTypesmage.TabStop = false;
			// 
			// frmManageApplicationTypes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(810, 738);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pbApplicationTypesmage);
			this.Controls.Add(this.lbRecordsNo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvApplicationTypes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmManageApplicationTypes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmManageApplicationTypes";
			this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
			this.cmsApplicationTypes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pbApplicationTypesmage;
		private System.Windows.Forms.Label lbRecordsNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvApplicationTypes;
		private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}