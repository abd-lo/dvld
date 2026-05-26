using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_DataAccess;

namespace MY_DVLD_Business
{
	public class clsTest
	{
		#region Vars

		public int TestID { get; set; }
		public int TestAppointmentID { get; set; }
		public bool TestResult { get; set; }
		public string Notes { get; set; }
		public int CreatedByUserID { get; set; }

		public clsTestAppointment TestAppointmentInfo;
		enum enMode { AddNew, Update };
		enMode Mode;

		#endregion

		public clsTest()
		{
			this.TestID = 0;
			this.TestAppointmentID = 0;
			this.TestResult = false;
			this.Notes = "";
			this.CreatedByUserID = 0;

			this.Mode = enMode.AddNew;

		}

		clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
		{
			this.TestID = TestID;
			this.TestAppointmentID = TestAppointmentID;
			this.TestResult = TestResult;
			this.Notes = Notes;
			this.CreatedByUserID = CreatedByUserID;

			this.TestAppointmentInfo = clsTestAppointment.FindTestAppointmentByID(TestAppointmentID);
			this.Mode = enMode.Update;


		}

		public static DataTable GetAllTests()
		{
			return clsTestData.GetAllTests();
		}

		bool _AddNewTest()
		{
			this.TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
			return (this.TestID != -1);
		}

		bool _UpdateTest()
		{
			bool IsUpdated = clsTestData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
			return IsUpdated;
		}

		public bool Save()
		{
			switch (this.Mode)
			{
				case enMode.AddNew:
					if (_AddNewTest())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;

				case enMode.Update:
					if (_UpdateTest())
						return true;
					break;
			}
			return false;
		}

		public static bool DeleteTest(int TestID)
		{
			return clsTestData.DeleteTest(TestID);
		}

		public static clsTest FindTestByID(int TestID)
		{
			int TestAppointmentID = 0;
			string Notes = "";
			int CreatedByUserID = 0;
			bool TestResult = false;

			bool IsFound = clsTestData.FindTestByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);

			if (IsFound)
			{
				clsTest Test = new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
				return Test;
			}

			return null;
		}


		public static int GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
		{
			return clsTestData.GetPassedTestsCount(LocalDrivingLicenseApplicationID);
		}

		public static int GetTestIDForTestAppointment(int TestAppointment)
		{
			return clsTestData.GetTestIDForTestAppointment(TestAppointment);
		}
		public static bool IsTestTakenForTestAppointmet(int TestAppointment)
		{
			return (clsTestData.GetTestIDForTestAppointment(TestAppointment)) != -1;
		}

		public static bool GetLastTestForTestTypeAndPersonID(int TestAppointment)
		{
			return (clsTestData.GetTestIDForTestAppointment(TestAppointment)) != -1;
		}

		public static clsTest GetLastTestByPersonIDAndTestType(int PersonID, clsTestType.enTestType TestTypeID, int LicenseClassID)
		{
			int TestID = -1; int TestAppointmentID = -1; bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

			bool IsFound = clsTestData.GetLastTestByPersonIDAndTestType(PersonID, (int) TestTypeID, LicenseClassID, ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);

			if (IsFound)
			{
				return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
			}

			return null;
		}

	}
}
