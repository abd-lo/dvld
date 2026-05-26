using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_DataAccess;
namespace MY_DVLD_Business
{
	public class clsTestAppointment
	{
		#region Vars

		public int TestAppointmentID { get; set; }
		public clsTestType.enTestType TestTypeID { get; set; }
		public int LocalDrivingLicenseApplicationID { get; set; }
		public DateTime AppointmentDate { get; set; }
		public float PaidFees { get; set; }
		public int CreatedByUserID { get; set; }
		public bool IsLocked { get; set; }
		public int RetakeTestApplicationID { get; set; }

		public clsTestType TestTypeInfo { get; }
		public clsApplication RetakeTestApplicationInfo { get; set; }
		enum enMode { AddNew, Update };
		enMode Mode;
		#endregion


		public clsTestAppointment()
		{
			this.TestAppointmentID = -1;
			this.TestTypeID = clsTestType.enTestType.VisionTest;
			this.LocalDrivingLicenseApplicationID = -1;
			this.AppointmentDate = DateTime.Now;
			this.PaidFees = 0f;
			this.CreatedByUserID = -1;
			this.IsLocked = false;
			this.RetakeTestApplicationID = -1;

			this.Mode = enMode.AddNew;
		}

		clsTestAppointment(int TestAppointmentID, clsTestType.enTestType TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
		{
			this.TestAppointmentID = TestAppointmentID;
			this.TestTypeID = TestTypeID;
			this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
			this.AppointmentDate = AppointmentDate;
			this.PaidFees = PaidFees;
			this.CreatedByUserID = CreatedByUserID;
			this.IsLocked = IsLocked;
			this.RetakeTestApplicationID = RetakeTestApplicationID;

			if (RetakeTestApplicationID != -1 || RetakeTestApplicationID != null)
				this.RetakeTestApplicationInfo = clsApplication.FindApplicationByID(this.RetakeTestApplicationID);

			TestTypeInfo = clsTestType.FindTestType(TestTypeID);
			this.Mode = enMode.Update;
		}

		public static DataTable GetAllTestAppointments()
		{
			return clsTestAppointmentData.GetAllTestAppointments();
		}

		bool _AddNewTestAppointment()
		{
			this.TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment((int)this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
			return (this.TestAppointmentID != -1);
		}

		bool _UpdateTestAppointment()
		{
			bool IsUpdated = clsTestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
			return IsUpdated;
		}

		public bool Save()
		{
			switch (this.Mode)
			{
				case enMode.AddNew:
					if (_AddNewTestAppointment())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;

				case enMode.Update:
					if (_UpdateTestAppointment())
						return true;
					break;
			}
			return false;
		}

		public static bool DeleteTestAppointment(int TestAppointmentID)
		{
			return clsTestAppointmentData.DeleteTestAppointment(TestAppointmentID);
		}

		public static clsTestAppointment FindTestAppointmentByID(int TestAppointmentID)
		{
			int TestTypeID = 0;
			int LocalDrivingLicenseApplicationID = 0;
			DateTime AppointmentDate = DateTime.MinValue;
			float PaidFees = 0f;
			int CreatedByUserID = 0;
			int RetakeTestApplicationID = 0;
			bool IsLocked = false;

			bool IsFound = clsTestAppointmentData.FindTestAppointmentByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID);

			if (IsFound)
			{
				clsTestAppointment TestAppointment = new clsTestAppointment(TestAppointmentID, (clsTestType.enTestType)TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
				return TestAppointment;
			}

			return null;
		}


		public static DataTable GetAllTestAppointmentsForLDLAppIDAndTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
		{
			return clsTestAppointmentData.GetAllTestAppointmentsForLDLAppIDAndTestType(LocalDrivingLicenseApplicationID, (int)TestType);
		}

		public static bool IsActiveTestAppointmentForTestTypeExisted(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
		{

			return clsTestAppointmentData.IsActiveTestAppointmentForTestTypeExisted(LocalDrivingLicenseApplicationID, (int)TestType);
		}

		public static bool IsLockedTestAppointmentForTestTypeExisted(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
		{

			return clsTestAppointmentData.IsLockedTestAppointmentForTestTypeExisted(LocalDrivingLicenseApplicationID, (int)TestType);
		}

		//GetNumberOfTriesPerTest
		public static int GetNumberOfTriesPerTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
		{
			return clsTestAppointmentData.GetNumberOfTriesPerTest(LocalDrivingLicenseApplicationID, (int)TestType);
		}
	}
}

