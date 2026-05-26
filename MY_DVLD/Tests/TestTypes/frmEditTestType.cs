using MY_DVLD_Business;
using MY_DVLD_GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Tests.TestTypes
{
	public partial class frmEditTestType : Form
	{
		clsTestType.enTestType _TestTypeID;
		clsTestType _TestType;
		public frmEditTestType(clsTestType.enTestType TestTypeID)
		{
			InitializeComponent();
			this._TestTypeID = TestTypeID;
			btnClose.CausesValidation = false;

		}

		private void _FillTestTypeData()
		{
			lblTestTypeID.Text = ((int)_TestType.ID).ToString();
			txtTitle.Text = _TestType.Title.ToString();
			txtDescription.Text = _TestType.Description.ToString();
			txtFees.Text = _TestType.Fees.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show($"Check Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_TestType.Title = txtTitle.Text.Trim();
			_TestType.Description = txtDescription.Text.Trim();
			_TestType.Fees = float.Parse(txtFees.Text.Trim());

			if (_TestType.Save())
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
				//e.Cancel = false;
				errorProvider1.SetError(txtFees, null);

			}

		}



		private void frmEditTestType_Load(object sender, EventArgs e)
		{
			_TestType = clsTestType.FindTestType(_TestTypeID);

			if (_TestType == null)
			{
				MessageBox.Show($"TestType With ID:{_TestTypeID}Can't be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			_FillTestTypeData();
		}


		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
