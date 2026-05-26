namespace MY_DVLD.People
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonInfo));
			this.lblTitle = new System.Windows.Forms.Label();
			this.ucPersonCard1 = new MY_DVLD.People.Controls.ucPersonCard();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(-9, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(928, 39);
			this.lblTitle.TabIndex = 115;
			this.lblTitle.Text = "Show Person Info";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ucPersonCard1
			// 
			this.ucPersonCard1.Location = new System.Drawing.Point(24, 70);
			this.ucPersonCard1.Name = "ucPersonCard1";
			this.ucPersonCard1.Size = new System.Drawing.Size(844, 305);
			this.ucPersonCard1.TabIndex = 116;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(681, 430);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 36);
			this.button1.TabIndex = 117;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// frmShowPersonInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 497);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ucPersonCard1);
			this.Controls.Add(this.lblTitle);
			this.Name = "frmShowPersonInfo";
			this.Text = "Show PersonInfo";
			this.Load += new System.EventHandler(this.frmShowPersonInfo_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblTitle;
		private Controls.ucPersonCard ucPersonCard1;
		private System.Windows.Forms.Button button1;
	}
}