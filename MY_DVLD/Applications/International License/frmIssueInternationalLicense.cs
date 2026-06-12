using MY_DVLD.GlobalClasses;
using MY_DVLD.Licenses;
using MY_DVLD.Licenses.International_Licenses;
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

namespace MY_DVLD.Applications.International_License
{
	public partial class frmIssueInternationalLicense : Form
	{
		/*
			Having a third class Local license
			Is active 
			Is not detained 
			Is not expired
		*/

		clsLicense _License;
		clsInternationalLicense _InternationalLicense;


		public frmIssueInternationalLicense()
		{
			InitializeComponent();
		}


		private bool _CheckConstrains()
		{

			if (_License.LicenseClassID != 3)
			{
				MessageBox.Show($"License Class must be third class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (!_License.IsActive)
			{
				MessageBox.Show($"License Is not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (_License.IsDetained)
			{
				MessageBox.Show($"License Is Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			//License should has 1 month validity at least
			if (_License.ExpirationDate < DateTime.Now.AddMonths(1))
			{
				MessageBox.Show($"License Is Expired Or have less than 1 month validity ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(_License.DriverID) != -1)
			{
				MessageBox.Show($"International Licnese Already Existed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void ucDriverLicenseWithFilter1_OnLicenseFound(MY_DVLD_Business.clsLicense license)
		{
			if (license == null)
			{
				MessageBox.Show($"Can't Find License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_License = license;

			if (!_CheckConstrains())
				return;

			lblLocalLicenseID.Text = _License.LicenseID.ToString();


			ucDriverLicenseWithFilter1.IsFilterEnabled = false;
			llShowLicenseHistory.Enabled = true;

			btnIssueLicense.Enabled = true;


		}

		private void btnIssueLicense_Click_1(object sender, EventArgs e)
		{

			/*
			 int ApplicationID, int ApplicantPersonID, enApplicationType ApplicationTypeID, DateTime ApplicationDate,
			DateTime LastStatusDate, enApplicationStatus ApplicationStatus, float PaidFees, int CreatedByUserID, int InternationalLicenseID,
			int DriverID, int IssuedUsingLocalLicenseID,
			DateTime IssueDate, DateTime ExpirationDate, bool IsActive
			 */

			clsInternationalLicense IntLicense = new clsInternationalLicense();
			IntLicense.ApplicantPersonID = _License.ApplicationInfo.ApplicantPersonID;
			IntLicense.ApplicationTypeID = enApplicationType.NewInternationalLicense;
			IntLicense.ApplicationDate = DateTime.Now;
			IntLicense.LastStatusDate = DateTime.Now;
			IntLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
			IntLicense.PaidFees = clsApplicationType.FindApplicationTypeByID(enApplicationType.NewInternationalLicense).ApplicationFees;
			IntLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
			IntLicense.DriverID = _License.DriverID;
			IntLicense.IssuedUsingLocalLicenseID = _License.LicenseID;
			IntLicense.IssueDate = DateTime.Now;
			IntLicense.ExpirationDate = DateTime.Now.AddYears(1);
			IntLicense.IsActive = true;

			if (!IntLicense.Save())
			{
				MessageBox.Show($"Failed to issue a license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show($"License Issued Successfully with International LicneseID {IntLicense.InternationalLicenseID}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

			_InternationalLicense = IntLicense;

			lblExpirationDate.Text = IntLicense.ExpirationDate.ToString("d");
			lblInternationalLicenseID.Text = IntLicense.InternationalLicenseID.ToString();
			lblApplicationID.Text = IntLicense.ApplicationID.ToString();

			btnIssueLicense.Enabled = false;
			llShowLicenseInfo.Enabled = true;

		}

		private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowPersonDrivingLicenseHistory frm = new frmShowPersonDrivingLicenseHistory(_License.ApplicationInfo.ApplicantPersonID);
			frm.ShowDialog();

		}

		private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(_InternationalLicense.InternationalLicenseID);
			frm.ShowDialog();

		}

		private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
		{
			lblApplicationDate.Text = DateTime.Now.ToString("d");
			lblIssueDate.Text = DateTime.Now.ToString("d");
			lblFees.Text = clsApplicationType.FindApplicationTypeByID(enApplicationType.NewInternationalLicense).ApplicationFees.ToString();
			lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
		}
	}
}
