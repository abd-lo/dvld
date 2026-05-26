namespace MY_DVLD.People.Controls
{
	partial class ucPersonCardWithFind
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
			this.components = new System.ComponentModel.Container();
			this.gbFilter = new System.Windows.Forms.GroupBox();
			this.btnFindPerson = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnAddNewPerson = new System.Windows.Forms.Button();
			this.txtFindByValue = new System.Windows.Forms.TextBox();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.ucPersonCard1 = new MY_DVLD.People.Controls.ucPersonCard();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbFilter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbFilter
			// 
			this.gbFilter.Controls.Add(this.btnFindPerson);
			this.gbFilter.Controls.Add(this.label7);
			this.gbFilter.Controls.Add(this.btnAddNewPerson);
			this.gbFilter.Controls.Add(this.txtFindByValue);
			this.gbFilter.Controls.Add(this.cbFilterBy);
			this.gbFilter.Font = new System.Drawing.Font("Tahoma", 12F);
			this.gbFilter.Location = new System.Drawing.Point(3, 3);
			this.gbFilter.Name = "gbFilter";
			this.gbFilter.Size = new System.Drawing.Size(815, 81);
			this.gbFilter.TabIndex = 6;
			this.gbFilter.TabStop = false;
			this.gbFilter.Text = "Filter";
			// 
			// btnFindPerson
			// 
			this.btnFindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnFindPerson.Image = global::MY_DVLD.Properties.Resources.SearchPerson;
			this.btnFindPerson.Location = new System.Drawing.Point(400, 20);
			this.btnFindPerson.Name = "btnFindPerson";
			this.btnFindPerson.Size = new System.Drawing.Size(41, 49);
			this.btnFindPerson.TabIndex = 4;
			this.btnFindPerson.UseVisualStyleBackColor = true;
			this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 13F);
			this.label7.Location = new System.Drawing.Point(7, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 22);
			this.label7.TabIndex = 3;
			this.label7.Text = "FilterBy:";
			// 
			// btnAddNewPerson
			// 
			this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAddNewPerson.Image = global::MY_DVLD.Properties.Resources.Add_Person_40;
			this.btnAddNewPerson.Location = new System.Drawing.Point(447, 20);
			this.btnAddNewPerson.Name = "btnAddNewPerson";
			this.btnAddNewPerson.Size = new System.Drawing.Size(42, 49);
			this.btnAddNewPerson.TabIndex = 2;
			this.btnAddNewPerson.UseVisualStyleBackColor = true;
			this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
			// 
			// txtFindByValue
			// 
			this.txtFindByValue.Location = new System.Drawing.Point(229, 34);
			this.txtFindByValue.Name = "txtFindByValue";
			this.txtFindByValue.Size = new System.Drawing.Size(124, 27);
			this.txtFindByValue.TabIndex = 1;
			this.txtFindByValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindByValue_KeyPress);
			this.txtFindByValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFindByValue_Validating);
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Location = new System.Drawing.Point(87, 35);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(121, 27);
			this.cbFilterBy.TabIndex = 0;
			// 
			// ucPersonCard1
			// 
			this.ucPersonCard1.Location = new System.Drawing.Point(5, 108);
			this.ucPersonCard1.Name = "ucPersonCard1";
			this.ucPersonCard1.Size = new System.Drawing.Size(821, 293);
			this.ucPersonCard1.TabIndex = 7;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ucPersonCardWithFind
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ucPersonCard1);
			this.Controls.Add(this.gbFilter);
			this.Name = "ucPersonCardWithFind";
			this.Size = new System.Drawing.Size(829, 404);
			this.Load += new System.EventHandler(this.ucPersonCardWithFind_Load);
			this.gbFilter.ResumeLayout(false);
			this.gbFilter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox gbFilter;
		private System.Windows.Forms.Button btnFindPerson;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnAddNewPerson;
		private System.Windows.Forms.TextBox txtFindByValue;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private ucPersonCard ucPersonCard1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
