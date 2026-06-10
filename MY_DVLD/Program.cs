using MY_DVLD.People;
using MY_DVLD.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MY_DVLD.Users;
using MY_DVLD_Business;
using MY_DVLD.Applications.Application_Types;
using MY_DVLD.Tests.TestTypes;
using MY_DVLD.Applications.Local_Driving_License;
using MY_DVLD.Applications.Detain_and_Release_License;

namespace MY_DVLD
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmLogin());
			//Application.Run(new frmMainForm());
			//Application.Run(new frmListPeople());
			//Application.Run(new frmManageDetainedLicenses());
			//Application.Run(new frmAddEditPerson(1));
			//Application.Run(new frmListUsers());
			//Application.Run(new frmAddUpdateUser());
			//Application.Run(new frmListApplicationTypes());
			//Application.Run(new frmListTestTypes());
			//Application.Run(new frmListLocalDrivingLicenseApplications());
			//Application.Run(new frmAddUpdateLocalDrivingLicesnseApplication());
			

		}
	}
}
