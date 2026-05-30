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

namespace MY_DVLD.Applications.Controls
{
	public partial class UCApplicationInfoWithLocalDrivingLicenseAppInfo : UserControl
	{
		public UCApplicationInfoWithLocalDrivingLicenseAppInfo()
		{
			InitializeComponent();
		}

		public clsLocalDrivingLicenseApplication LDLApp { get; private set; }

		private void _ResetDefaultValues()
		{
			lblLocalDrivingLicenseApplicationID.Text = "[???]";
			lblAppliedFor.Text = "[???]";
			lblPassedTests.Text = "0";


		}

		private void _FillData()
		{
			lblLocalDrivingLicenseApplicationID.Text = LDLApp.LocalDrivingLicenseApplicationID.ToString();
			lblAppliedFor.Text = LDLApp.LicenseClassText;
			lblPassedTests.Text = LDLApp.GetPassedTestsCount().ToString();
			bool IsLicenseExisted = LDLApp.IsActiveLicenseForPersonIDAndLicenseClassExisted();
			llShowLicenceInfo.Enabled = IsLicenseExisted;
		}

		public void LoadData(int LDLAppID)
		{
			LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);
			if (LDLApp == null)
			{
				MessageBox.Show($"Can't Find This LocalDrivingLicneseApp With ID{LDLAppID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			ucApplicationInfo1.LoadData(LDLApp.ApplicationID);
			_FillData();


		}

		private void UCApplicationInfoWithLocalDrivingLicenseAppInfo_Load(object sender, EventArgs e)
		{
			_ResetDefaultValues();
		}

		private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			int LicenseID = LDLApp.GetActiveLicenseForPersonIDAndLicenseClass();
			frmShowLocalDrivingLicense frm = new frmShowLocalDrivingLicense(LicenseID);
			frm.ShowDialog();
		}
	}
}
