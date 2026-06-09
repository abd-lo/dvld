using MY_DVLD.GlobalClasses;
using MY_DVLD.Licenses;
using MY_DVLD.Licenses.Local_Driving_Licenses;
using MY_DVLD_Business;
using MY_DVLD_Business.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Applications.Renew_Local_License
{
	public partial class frmRenewLocalLicenseApplication : Form
	{
		public frmRenewLocalLicenseApplication()
		{
			InitializeComponent();
		}
		clsLicense _OldLicense;
		clsLicense _NewLicense;

		private void ucDriverLicenseWithFilter1_OnLicenseFound(MY_DVLD_Business.clsLicense License)
		{

			if (License != null)
			{
				_OldLicense = License;
				llShowLicenseHistory.Enabled = true;
			}

			if (!_CheckConstrains())
			{
				btnRenewLicense.Enabled = false;

			}
			else
			{

				btnRenewLicense.Enabled = true;
				_FillData();
			}
		}

		private bool _CheckConstrains()
		{
			if (!_OldLicense.IsActive)
			{

				MessageBox.Show($"LicenseIsNotActive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;

			}
			if (_OldLicense.IsDetained)
			{
				MessageBox.Show($"License Is Detained ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			}

			//License can be renwed if it has less than 1 month
			if (_OldLicense.ExpirationDate > DateTime.Today.AddMonths(1))
			{

				MessageBox.Show($"Can't be renewed it had validity more than 1 month ,ExpireDate: {_OldLicense.ExpirationDate}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;

			}

			return true;
		}


		private void _FillData()
		{
			lblLicenseFees.Text = clsLicenseClass.FindLicenseClassByID(_OldLicense.LicenseClassID).ClassFees.ToString();
			lblOldLicenseID.Text = _OldLicense.LicenseID.ToString();
			lblTotalFees.Text = (decimal.Parse(lblLicenseFees.Text) + decimal.Parse(lblApplicationFees.Text)).ToString();
			lblExpirationDate.Text = _OldLicense.ExpirationDate.AddYears(clsLicenseClass.GetDefaultValidityLength(_OldLicense.LicenseClassID)).ToString("dd/MM/yyyy");

		}





		private void frmRenewLocalLicenseApplication_Load(object sender, EventArgs e)
		{
			lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
			lblApplicationFees.Text = clsApplicationType.FindApplicationTypeByID(enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();
			lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
			lblIssueDate.Text = DateTime.Now.ToString();

		}

		private void btnRenewLicense_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show($"Are u sure u want to Renew the license?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}

			string Notes = txtNotes.Text.Trim();
			int CurrentUserID = clsGlobal.CurrentUser.UserID;

			_NewLicense = _OldLicense.RenewLicense(Notes, CurrentUserID);

			if (_NewLicense.LicenseID == -1)
			{
				MessageBox.Show($"Failed To Renew The License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			MessageBox.Show($"Renewing License Done , NewLicense ID :{_NewLicense.LicenseID}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

			llShowNewLicenseInfo.Enabled = true;
			btnRenewLicense.Enabled = false;
			lblRenewedLicenseID.Text = _NewLicense.LicenseID.ToString();
			lblApplicationID.Text= _NewLicense.ApplicationID.ToString();
		}

		private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowPersonDrivingLicenseHistory frm = new frmShowPersonDrivingLicenseHistory(_OldLicense.ApplicationInfo.ApplicantPersonID);
			frm.ShowDialog();
		}

		private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowLocalDrivingLicense frm = new frmShowLocalDrivingLicense(_NewLicense.LicenseID);
			frm.ShowDialog();

		}
	}
}
