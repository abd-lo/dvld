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

namespace MY_DVLD.Applications.Detain_and_Release_License
{
	public partial class frmRealeseDetainLicenseApplication : Form
	{
		public frmRealeseDetainLicenseApplication()
		{
			InitializeComponent();
		}
		clsLicense _License;
		clsDetainedLicense _DetainedLicense;

		private void ucDriverLicenseWithFilter1_OnLicenseFound(clsLicense license)
		{
			if (license == null) { return; }



			if (!license.IsDetained)
			{
				MessageBox.Show($"License Is Not Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_License = null;
				return;
			}
			_License = license;
			_DetainedLicense = clsDetainedLicense.FindDetainedLicenseByLicenseID(_License.LicenseID);

			lblDetainID.Text = _DetainedLicense.DetainID.ToString();
			lblDetainDate.Text = _DetainedLicense.DetainDate.ToString();
			lblApplicationFees.Text = clsApplicationType.FindApplicationTypeByID(enApplicationType.ReleaseDetainedDrivingLicsense).ApplicationFees.ToString();
			lblLicenseID.Text = _License.LicenseID.ToString();
			lblCreatedByUser.Text = _DetainedLicense.CreatedByUserInfo.Username;
			lblFineFees.Text = _DetainedLicense.FineFees.ToString();
			lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();

			llShowLicenseHistory.Enabled = true;
			llShowLicenseInfo.Enabled = true;
			btnReleaseLicense.Enabled = true;
			ucDriverLicenseWithFilter1.IsFilterEnabled = false;
		}


		private void frmRealeseDetainLicenseApplication_Load(object sender, EventArgs e)
		{

		}

		private void btnReleaseLicense_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show($"Are you Sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{ return; }

			bool IsReleased = _License.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID);

			if (!IsReleased)
				MessageBox.Show($"Failed to release License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			else
			{

				MessageBox.Show("Released Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnReleaseLicense.Enabled = false;
				//Update object data after releasing

				_DetainedLicense = clsDetainedLicense.FindDetainedLicenseByLicenseID(_License.LicenseID);
				lblApplicationID.Text = _DetainedLicense.ReleaseApplicationID.ToString();
			}

		}

		private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowLocalDrivingLicense frm = new frmShowLocalDrivingLicense(_License.LicenseID);
			frm.ShowDialog();
		}

		private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowPersonDrivingLicenseHistory frm = new frmShowPersonDrivingLicenseHistory(_License.ApplicationInfo.ApplicantPersonID);

			frm.ShowDialog();
		}
	}
}
