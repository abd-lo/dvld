namespace MY_DVLD.Drivers
{
	partial class frmShowPersonInfo
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
			this.ucPersonCard1 = new MY_DVLD.People.Controls.ucPersonCard();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ucPersonCard1
			// 
			this.ucPersonCard1.Location = new System.Drawing.Point(23, 98);
			this.ucPersonCard1.Name = "ucPersonCard1";
			this.ucPersonCard1.Size = new System.Drawing.Size(821, 293);
			this.ucPersonCard1.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(149, 34);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(568, 39);
			this.lblTitle.TabIndex = 148;
			this.lblTitle.Text = "Person Details";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnClose
			// 
			this.btnClose.AutoEllipsis = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::MY_DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(664, 419);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(135, 36);
			this.btnClose.TabIndex = 149;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmShowPersonInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 490);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.ucPersonCard1);
			this.Name = "frmShowPersonInfo";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmShowPersonInfo_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private People.Controls.ucPersonCard ucPersonCard1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnClose;
	}
}