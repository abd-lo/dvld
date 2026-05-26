using MY_DVLD.Applications.Application_Types;
using MY_DVLD.Applications.Local_Driving_License;
using MY_DVLD.GlobalClasses;
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
	}
}
