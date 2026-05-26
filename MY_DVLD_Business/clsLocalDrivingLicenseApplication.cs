using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_DataAccess;
using System.Windows.Forms;
using static MY_DVLD_Business.clsApplication;
using MY_DVLD_Business.Enum;

namespace MY_DVLD_Business
{
	public class clsLocalDrivingLicenseApplication : clsApplication
	{
		#region Vars

		public int LocalDrivingLicenseApplicationID { set; get; }
		public int LicenseClassID { set; get; }
		public string LicenseClassText
		{
			get
			{
				return clsLicenseClass.FindLicenseClassByID(LicenseClassID).ClassName;
			}
		}
		public enum enMode { AddNew, Update };
		enMode Mode;

		#endregion

		public clsLocalDrivingLicenseApplication()
		{
			this.LocalDrivingLicenseApplicationID = 0;
			this.LicenseClassID = 0;

			//this.ApplicationID = 0;
			//this.ApplicantPersonID = 0;
			//this.ApplicationTypeID = 0;
			//this.CreatedByUserID = 0;
			//this.ApplicationDate = DateTime.Now;
			//this.LastStatusDate = DateTime.Now;
			//this.PaidFees = 0f;
			//this.ApplicationStatus = enApplicationStatus.New;
			//this.Mode = enMode.AddNew;
		}

		clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int LicenseClassID, int ApplicationID, int ApplicantPersonID, enApplicationType ApplicationTypeID, int CreatedByUserID, DateTime ApplicationDate, DateTime LastStatusDate, float PaidFees, enApplicationStatus ApplicationStatus)
		: base(ApplicationID, ApplicantPersonID, ApplicationTypeID, ApplicationDate, LastStatusDate, ApplicationStatus, PaidFees, CreatedByUserID)
		{
			this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
			this.LicenseClassID = LicenseClassID;
			this.Mode = enMode.Update;


		}

		public static DataTable GetAllLocalDrivingLicenseApplications()
		{
			return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
		}

		bool _AddNewLocalDrivingLicenseApplication()
		{
			this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(this.LicenseClassID, this.ApplicationID);
			return (this.LocalDrivingLicenseApplicationID != -1);
		}

		bool _UpdateLocalDrivingLicenseApplication()
		{
			bool IsUpdated = clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.LicenseClassID, this.ApplicationID);
			return IsUpdated;
		}

		public new bool Save()
		{
			base.Mode = (clsApplication.enMode)this.Mode;
			if (!base.Save())
			{
				return false;
			}


			switch (this.Mode)
			{
				case enMode.AddNew:
					if (_AddNewLocalDrivingLicenseApplication())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;

				case enMode.Update:
					if (_UpdateLocalDrivingLicenseApplication())
						return true;
					break;
			}
			return false;
		}

		public bool DeleteLocalDrivingLicenseApplication()
		{
			//Delete Local

			bool IsLocalDrivingLicenseDeleted = clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);
			if (!IsLocalDrivingLicenseDeleted)
				return false;

			//delete Application
			bool IsApplicationDeleted = base.DeleteApplication();
			return (IsApplicationDeleted);
		}

		public static clsLocalDrivingLicenseApplication FindLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID)
		{
			int LicenseClassID = 0;
			int ApplicationID = 0;

			bool IsFound = clsLocalDrivingLicenseApplicationData.FindLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID, ref LicenseClassID, ref ApplicationID);

			if (IsFound)
			{

				clsApplication a = clsApplication.FindApplicationByID(ApplicationID);


				clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, LicenseClassID, ApplicationID, a.ApplicantPersonID, a.ApplicationTypeID, a.CreatedByUserID, a.ApplicationDate, a.LastStatusDate, a.PaidFees, a.ApplicationStatus);


				return LocalDrivingLicenseApplication;
			}

			return null;
		}

		public int GetActiveLicenseForPersonIDAndLicenseClass()
		{
			return clsLicenseData.GetActiveLicenseIDByPersonIDAndLicenseClass(this.ApplicantPersonID, this.LicenseClassID);
		}

		public bool IsActiveLicenseForPersonIDAndLicenseClassExisted()
		{
			return (GetActiveLicenseForPersonIDAndLicenseClass() != -1);
		}

		public bool IsTestPassedByTestTypeAndLocalDrivingLicneseAppID(clsTestType.enTestType TestTypeID)
		{
			return clsLocalDrivingLicenseApplicationData.IsTestPassedByTestTypeAndLocalDrivingLicneseAppID(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
		}

		public int GetPassedTestsCount()
		{
			return clsTest.GetPassedTestsCount(this.LocalDrivingLicenseApplicationID);
		}

		public DataTable GetAllTestAppointmentsForLDLAppIDAndTestType(clsTestType.enTestType TestType)
		{
			return clsTestAppointment.GetAllTestAppointmentsForLDLAppIDAndTestType(this.LocalDrivingLicenseApplicationID, TestType);
		}


		public bool IsActiveTestAppointmentForTestTypeExisted(clsTestType.enTestType TestType)
		{

			return clsTestAppointment.IsActiveTestAppointmentForTestTypeExisted(this.LocalDrivingLicenseApplicationID, TestType);
		}


		public bool IsLockedTestAppointmentForTestTypeExisted(clsTestType.enTestType TestType)
		{
			return clsTestAppointment.IsLockedTestAppointmentForTestTypeExisted(this.LocalDrivingLicenseApplicationID, TestType);
		}

		public int GetNumberOfTriesPerTest(clsTestType.enTestType TestType)
		{

			return clsTestAppointment.GetNumberOfTriesPerTest(this.LocalDrivingLicenseApplicationID, TestType);
		}


		public bool DoesAttendedTestByTestType(clsTestType.enTestType TestType)
		{
			return clsLocalDrivingLicenseApplicationData.DoesAttendedTestByTestType(this.LocalDrivingLicenseApplicationID, (int)TestType);
		}

		public  clsTest GetLastTestByTestType( clsTestType.enTestType TestTypeID)
		{
			return  clsTest.GetLastTestByPersonIDAndTestType(this.ApplicantPersonID, TestTypeID,this.LicenseClassID);

		}

		//GetNumberOfTriesPerTest
	}
}


//public int LocalDrivingLicenseApplicationID { set; get; }
//public int LicenseClassID { set; get; }
//public int ApplicationID { set; get; }
//public int ApplicantPersonID { set; get; }
//public int ApplicationTypeID { set; get; }
//public int CreatedByUserID { set; get; }
//public DateTime ApplicationDate { set; get; }
//public DateTime LastStatusDate { set; get; }
//public float PaidFees { set; get; }
//public enApplicationStatus ApplicationStatus { set; get; }