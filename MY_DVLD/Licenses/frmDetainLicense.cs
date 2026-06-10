using MY_DVLD.GlobalClasses;
using MY_DVLD.Licenses.Local_Driving_Licenses;
using MY_DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Licenses
{
	public partial class frmDetainLicense : Form
	{


		clsLicense _License;
		clsDetainedLicense _DetainedLicense;


		public frmDetainLicense()
		{
			InitializeComponent();
		}

		private void ucDriverLicenseWithFilter1_OnLicenseFound(MY_DVLD_Business.clsLicense license)
		{
			if (license == null) { return; }



			if (!license.IsDetained)
			{

				MessageBox.Show($"License Is Not Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_License = null;
				return;

			}
			_License = license;
			llShowLicenseHistory.Enabled = true;
			llShowLicenseInfo.Enabled = true;
			btnDetainLicense.Enabled = true;
		}

		private void frmDetainLicense_Load(object sender, EventArgs e)
		{
			lblDetainDate.Text = DateTime.Now.ToString("d");
			lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;

		}

		private void btnDetainLicense_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
				return;
			int CreatedByUserID = clsGlobal.CurrentUser.UserID;
			float FineFees = Convert.ToSingle(txtFineFees.Text);

			clsDetainedLicense dt = _License.DetainLicense(FineFees, CreatedByUserID);

			if (dt == null)
			{
				MessageBox.Show($"Failed To Detain", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			lblDetainID.Text = dt.DetainID.ToString();
			lblLicenseID.Text = dt.LicenseID.ToString();

			llShowLicenseInfo.Enabled = true;
			llShowLicenseHistory.Enabled = true;


		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
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


		private void txtFineFees_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtFineFees.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtFineFees, "Set Fines");
				MessageBox.Show($"Fill The FineFees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
				errorProvider1.SetError(txtFineFees, null);

		}
	}
}
