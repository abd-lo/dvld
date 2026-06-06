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

namespace MY_DVLD.Applications.ReplacementForLostOrDamaged
{
	public partial class frmReplacementForLostOrDamaged : Form
	{
		clsLicense _OldLicense;
		clsLicense _NewLicense;
		public enApplicationType _ApplicationType { get; private set; }


		public frmReplacementForLostOrDamaged()
		{
			InitializeComponent();
		}

		private void ucDriverLicenseWithFilter1_OnLicenseFound(MY_DVLD_Business.clsLicense License)
		{
			if (License == null)
			{
				MessageBox.Show($"License Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_OldLicense = License;
			lblOldLicenseID.Text = _OldLicense.LicenseID.ToString();
			llShowLicenseHistory.Enabled = true;



			if (!License.IsActive || License.IsDetained)
			{
				MessageBox.Show($"License Is Not Active or it's Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnIssueReplacement.Enabled = false;
				return;
			}

			btnIssueReplacement.Enabled = true;
			ucDriverLicenseWithFilter1.IsFilterEnabled = false;
		}

		private void frmReplacementForLostOrDamaged_Load(object sender, EventArgs e)
		{
			lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
			lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

			_SetReplacementForModeAndFeesAndTitle();

			llShowNewLicenseInfo.Enabled = false;
			llShowLicenseHistory.Enabled = false;

		}

		private void _SetReplacementForModeAndFeesAndTitle()
		{
			if (rbDamagedLicense.Checked)
			{
				lblTitle.Text = "Replacement For Damaged License";
				lblApplicationFees.Text = clsApplicationType.FindApplicationTypeByID(enApplicationType.ReplaceDamagedDrivingLicense).ApplicationFees.ToString();
				_ApplicationType = enApplicationType.ReplaceDamagedDrivingLicense;
			}

			else
			{
				lblTitle.Text = "Replacement For Lost License";
				lblApplicationFees.Text = clsApplicationType.FindApplicationTypeByID(enApplicationType.ReplaceLostDrivingLicense).ApplicationFees.ToString();
				_ApplicationType = enApplicationType.ReplaceLostDrivingLicense;
			}
		}

		private void ReplacementFor(object sender, EventArgs e)
		{
			_SetReplacementForModeAndFeesAndTitle();

		}

		private void btnIssueReplacement_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show($"Are U Sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}

			_NewLicense = _OldLicense.ReplaceLicense(clsGlobal.CurrentUser.UserID, _ApplicationType);

			if (_NewLicense == null)
			{
				MessageBox.Show($"Error Replacing The License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show($"License Replaced Susseffully New LinceseID:{_NewLicense.LicenseID}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
			btnIssueReplacement.Enabled = false;

			lblRenewedLicenseID.Text = _NewLicense.LicenseID.ToString();
			lblApplicationID.Text = _NewLicense.ApplicationID.ToString();

			llShowNewLicenseInfo.Enabled = true;


		}

		private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowLocalDrivingLicense frm = new frmShowLocalDrivingLicense(_NewLicense.LicenseID);
			frm.ShowDialog();
		}

		private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowDrivingLicenseHistory frm = new frmShowDrivingLicenseHistory(_OldLicense.DriverInfo.PersonID);
			frm.ShowDialog();
		}
	}
}
