using MY_DVLD.Applications.Application_Types;
using MY_DVLD.Applications.Detain_and_Release_License;
using MY_DVLD.Applications.Local_Driving_License;
using MY_DVLD.Applications.Renew_Local_License;
using MY_DVLD.Applications.ReplacementForLostOrDamaged;
using MY_DVLD.Drivers;
using MY_DVLD.GlobalClasses;
using MY_DVLD.Licenses;
using MY_DVLD.Licenses.International_Licenses;
using MY_DVLD.Login;
using MY_DVLD.People;
using MY_DVLD.Users;
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

namespace MY_DVLD
{
	public partial class frmMainForm : Form
	{
		private frmLogin _frmLogin = new frmLogin();
		public bool IsSignOut = false;

		public frmMainForm(frmLogin frm)
		{
			InitializeComponent();
			_frmLogin = frm;
		}

		public frmMainForm()
		{
			InitializeComponent();
		}



		private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListPeople frm = new frmListPeople();
			frm.ShowDialog();
		}

		private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			IsSignOut = true;
			this.Close();
			_frmLogin.Show();
		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmChangeUserPassword frm = new frmChangeUserPassword(clsGlobal.CurrentUser.UserID);
			frm.ShowDialog();
		}

		private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListApplicationTypes frm = new frmListApplicationTypes();
			frm.ShowDialog();
		}

		private void manageLocalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListLocalDrivingLicenseApplications frm = new frmListLocalDrivingLicenseApplications();
			frm.ShowDialog();
		}

		private void driversToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListDrivers frm = new frmListDrivers();
			frm.ShowDialog();
		}

		private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmRenewLocalLicenseApplication frm = new frmRenewLocalLicenseApplication();
			frm.ShowDialog();
		}

		private void ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmReplacementForLostOrDamaged frm = new frmReplacementForLostOrDamaged();
			frm.ShowDialog();
		}

		private void ManageDetainedLicensestoolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmManageDetainedLicenses frm = new frmManageDetainedLicenses();
			frm.ShowDialog();
		}

		private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDetainLicense frm = new frmDetainLicense();
			frm.ShowDialog();
		}

		private void retakeTestToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmListLocalDrivingLicenseApplications frm = new frmListLocalDrivingLicenseApplications();
			frm.ShowDialog();
		}

		private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmRealeseDetainLicenseApplication frm = new frmRealeseDetainLicenseApplication();
			frm.ShowDialog();
		}

		private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmRealeseDetainLicenseApplication frm = new frmRealeseDetainLicenseApplication();
			frm.ShowDialog();
		}

		private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListLocalDrivingLicenseApplications frm = new frmListLocalDrivingLicenseApplications();
			frm.ShowDialog();
		}

		private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmManageInternationalLicenseApplications frm = new frmManageInternationalLicenseApplications();
			frm.ShowDialog();
		}

		private void ManageInternationaDrivingLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmManageInternationalLicenseApplications frm = new frmManageInternationalLicenseApplications();
			frm.ShowDialog();
		}

		private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmShowUserDetails frm = new frmShowUserDetails(clsGlobal.CurrentUser.UserID);
			frm.ShowDialog();
		}

		private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListUsers frm = new frmListUsers();
			frm.ShowDialog();
		}
	}
}