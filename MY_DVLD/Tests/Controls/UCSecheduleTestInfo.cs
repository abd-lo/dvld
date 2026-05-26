using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MY_DVLD_Business;
using static MY_DVLD_Business.clsTestType;
namespace MY_DVLD.Tests.Controls
{
	public partial class UCSecheduleTestInfo : UserControl
	{
		#region Vars


		int _LDLAppID;
		clsLocalDrivingLicenseApplication _LDLAppInfo;

		int _TestAppointmentID;
		clsTestAppointment _TestAppointmentInfo;

		clsTestType.enTestType _TestType;
		clsTest _Test;
		public clsTestType.enTestType TestType
		{
			get { return _TestType; }
			set
			{
				_TestType = value;

				switch (_TestType)

				{
					case clsTestType.enTestType.VisionTest:
						pbTestTypeImage.Image = Properties.Resources.Vision_512;
						lblTitle.Text = "Vision Test";
						break;


					case clsTestType.enTestType.WrittenTest:
						pbTestTypeImage.Image = Properties.Resources.Written_Test_512;
						lblTitle.Text = "Written Test";

						break;


					case clsTestType.enTestType.StreetTest:
						pbTestTypeImage.Image = Properties.Resources.Street_Test_32;
						lblTitle.Text = "Street Test";

						break;
					default:
						break;
				}
			}
		}

		#endregion

		public UCSecheduleTestInfo()
		{
			InitializeComponent();
		}

		public void LoadData(int LDLAppID, clsTestType.enTestType TestType, int TestAppointmentID = -1)
		{

			clsLocalDrivingLicenseApplication LDLAppInfo = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);


			if (LDLAppInfo == null)
			{
				MessageBox.Show($"This Local Application with ID :{LDLAppID} Has Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}



			clsTestAppointment TestAppointmentInfo = clsTestAppointment.FindTestAppointmentByID(TestAppointmentID);

			if (TestAppointmentInfo == null)
			{
				MessageBox.Show($"This Test Appointment with ID :{_TestAppointmentID} Has Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_LDLAppInfo = LDLAppInfo;
			_LDLAppID = LDLAppID;
			_TestAppointmentInfo = TestAppointmentInfo;
			_TestAppointmentID = TestAppointmentID;

			#region Fill_LDLAppInfo

			lblLocalDrivingLicenseAppID.Text = _LDLAppInfo.LocalDrivingLicenseApplicationID.ToString();
			lblDrivingClass.Text = _LDLAppInfo.LicenseClassText;
			lblFullName.Text = _LDLAppInfo.ApplicantFullName;
			lblTrial.Text = _LDLAppInfo.GetNumberOfTriesPerTest(TestType).ToString();
			//lblFees.Text = _LDLAppInfo.PaidFees.ToString();
			lblDate.Text = _TestAppointmentInfo.AppointmentDate.ToString();
			lblFees.Text = clsTestType.GetTestFees(TestType).ToString();

			#endregion


			int TestID = clsTest.GetTestIDForTestAppointment(_TestAppointmentID);
			
			//if test is taken prevent changing results
			if (TestID != -1)
			{
				_Test = clsTest.FindTestByID(TestID);
				lblTestID.Text = _Test.TestID.ToString();
			}

		}
	}

}