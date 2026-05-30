using MY_DVLD.GlobalClasses;
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

namespace MY_DVLD.Licenses.Local_Driving_Licenses
{
	public partial class frmIssueLocalDrivingLicense : Form
	{
		int _LDLID = -1;
		clsLocalDrivingLicenseApplication LDLApp;
		public frmIssueLocalDrivingLicense(int lDLID)
		{
			InitializeComponent();
			_LDLID = lDLID;
		}

		private void frmIssueLocalDrivingLicense_Load(object sender, EventArgs e)
		{
			ucApplicationInfoWithLocalDrivingLicenseAppInfo1.LoadData(_LDLID);
			LDLApp = ucApplicationInfoWithLocalDrivingLicenseAppInfo1.LDLApp;

		}


		private void btnIssue_Click(object sender, EventArgs e)
		{
			if (clsTest.GetPassedTestsCount(LDLApp.LocalDrivingLicenseApplicationID) < 3)
			{

				MessageBox.Show($"Did't Pass All Tests", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string Notes = rtxtNotes.Text.Trim();
			int CreatedByUserID = clsGlobal.CurrentUser.UserID;
			int LicenseID = LDLApp.IssueNewDrivingLicense(Notes, CreatedByUserID);

			if (LicenseID != -1)
			{
				MessageBox.Show($"License Has Issued Successfully with LicenseID: {LicenseID}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{

				MessageBox.Show($"Failed to issue a License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnIssue.Enabled = false;
				this.Close();

			}
		}
	}
}
