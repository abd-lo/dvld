namespace MY_DVLD.Tests
{
	partial class frmScheduleTest
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
			this.ucScheduleTest1 = new MY_DVLD.Tests.Controls.UCScheduleTest();
			this.SuspendLayout();
			// 
			// ucScheduleTest1
			// 
			this.ucScheduleTest1.EnableRetakeTestInfo = true;
			this.ucScheduleTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ucScheduleTest1.Location = new System.Drawing.Point(46, 14);
			this.ucScheduleTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucScheduleTest1.Name = "ucScheduleTest1";
			this.ucScheduleTest1.Size = new System.Drawing.Size(533, 722);
			this.ucScheduleTest1.TabIndex = 0;
			// 
			// frmScheduleTest
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(637, 765);
			this.Controls.Add(this.ucScheduleTest1);
			this.Name = "frmScheduleTest";
			this.Text = "frmScheduleTest";
			this.Load += new System.EventHandler(this.frmScheduleTest_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.UCScheduleTest ucScheduleTest1;
	}
}