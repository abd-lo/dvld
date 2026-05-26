using MY_DVLD_Business;
using MY_DVLD_Business.Enum;
using MY_DVLD_GlobalClasses;
using System;
using System.Windows.Forms;

namespace MY_DVLD.Applications.Application_Types
{
	public partial class frmEditApplicationType : Form
	{
		int _ApplicationTypeID;
		clsApplicationType _ApplicationType;

		public frmEditApplicationType(int ApplicationTypeID)
		{
			InitializeComponent();
			this._ApplicationTypeID = ApplicationTypeID;
			btnClose.CausesValidation = false;
		}

		private void _FillApplicationData()
		{
			lblApplicationTypeID.Text = _ApplicationType.ApplicationTypeID.ToString();
			txtTitle.Text = _ApplicationType.ApplicationTypeTitle.ToString();
			txtFees.Text = _ApplicationType.ApplicationFees.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show($"Check Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_ApplicationType.ApplicationTypeTitle = txtTitle.Text.Trim();
			_ApplicationType.ApplicationFees = float.Parse(txtFees.Text.Trim());

			if (_ApplicationType.Save())
				MessageBox.Show("Saved Succefully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else

				MessageBox.Show($"Error Happens During Saving Proccess", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void txtTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			clsValidation.ValidateControlRequired(sender, e, errorProvider1);
		}

		private void txtFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			clsValidation.ValidateControlRequired(sender, e, errorProvider1);

			if (!clsValidation.IsValidFloat(txtFees.Text))
			{
				errorProvider1.SetError(txtFees, "Not Valid Number");
				e.Cancel = true;
			}
			else
			{
				errorProvider1.SetError(txtFees, null);
				e.Cancel = false;
			}
		}

		private void frmUpdateApplicationType_Load(object sender, EventArgs e)
		{
			_ApplicationType = clsApplicationType.FindApplicationTypeByID((enApplicationType)_ApplicationTypeID);
			if (_ApplicationType == null)
			{
				MessageBox.Show($"Can't Find this Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			_FillApplicationData();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
