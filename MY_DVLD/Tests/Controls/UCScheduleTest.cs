using MY_DVLD.GlobalClasses;
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

namespace MY_DVLD.Tests.Controls
{
	public partial class UCScheduleTest : UserControl
	{
		#region Vars

		int _LDLAppID;
		clsLocalDrivingLicenseApplication _LDLAppInfo;

		int _TestAppointmentID;
		clsTestAppointment _TestAppointmentInfo;

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
		clsTestType.enTestType _TestType;

		public enum enMode { AddNew, Update }
		enMode _Mode;

		public enum enCreationMode { FirstTimeSchedule, RetakeTestSchedule }
		enCreationMode _CreationMode;

		public bool EnableRetakeTestInfo
		{
			get => gbRetakeTestInfo.Enabled;
			set => gbRetakeTestInfo.Enabled = value;
		}

		public bool EnableEditing
		{
			set
			{
				dtpTestDate.Enabled = value;
				gbRetakeTestInfo.Enabled = value;
				lblUserMessage.Visible = !value;
			}
		}


		#endregion

		public UCScheduleTest()
		{
			InitializeComponent();
		}


		private void _SetDefaultData()
		{
			lblTitle.Text = "ScheduleTest";
			lblTotalFees.Text = "0";
			lblRetakeAppFees.Text = "0";
			lblRetakeTestAppID.Text = "N/A";
			lblDrivingClass.Text = "";
			lblFullName.Text = "";
			lblTrial.Text = "0";
			lblFees.Text = "0";
			lblLocalDrivingLicenseAppID.Text = "";
			lblUserMessage.Text = "";
			dtpTestDate.Value = DateTime.Now;

			gbRetakeTestInfo.Enabled = false;
		}

		private bool _LoadTestAppointment()
		{

			_TestAppointmentInfo = clsTestAppointment.FindTestAppointmentByID(_TestAppointmentID);
			if (_TestAppointmentInfo == null)
			{
				MessageBox.Show($"Error Loading TestAppointment With ID{_TestAppointmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			dtpTestDate.Value = _TestAppointmentInfo.AppointmentDate;

			//Set the min Date by Comparing Appointment Date with Today Date 

			dtpTestDate.MinDate =
			(_TestAppointmentInfo.AppointmentDate < DateTime.Today) ?
			_TestAppointmentInfo.AppointmentDate
			: DateTime.Today;



			//Fill RetakeTestApplicationID 
			if (_TestAppointmentInfo.RetakeTestApplicationID != null || _TestAppointmentInfo.RetakeTestApplicationID != -1)
			{
				lblRetakeTestAppID.Text = _TestAppointmentInfo.RetakeTestApplicationID.ToString();
			}

			else
				lblRetakeTestAppID.Text = "N/A";

			return true;
		}

		private void _HandelFees()
		{
			if (_Mode == enMode.AddNew)
			{
				lblFees.Text = clsTestType.FindTestType(_TestType).Fees.ToString();


				if (_CreationMode == enCreationMode.RetakeTestSchedule)
				{
					lblRetakeAppFees.Text = clsApplicationType.FindApplicationTypeByID(enApplicationType.RetakeTest).ApplicationFees.ToString();

				}
				lblTotalFees.Text = (Convert.ToInt32(lblFees.Text) + Convert.ToInt32(lblRetakeAppFees.Text)).ToString();

			}

			if (_Mode == enMode.Update)
			{

				lblFees.Text = _TestAppointmentInfo.PaidFees.ToString();
				lblTotalFees.Text = (Convert.ToInt32(lblFees.Text) + Convert.ToInt32(lblRetakeAppFees.Text)).ToString();


				if (_CreationMode == enCreationMode.RetakeTestSchedule)
				{
					lblTotalFees.Text = _TestAppointmentInfo.PaidFees.ToString();
					lblRetakeAppFees.Text = _TestAppointmentInfo.RetakeTestApplicationInfo.PaidFees.ToString();
					lblFees.Text = (Convert.ToInt32(lblTotalFees.Text) - Convert.ToInt32(lblRetakeAppFees.Text)).ToString();
				}
			}




		}

		private bool _HandelActiveTestAppointmentConstrain()
		{
			bool IsActiveTestAppointmentForTestTypeExisted = _LDLAppInfo.IsActiveTestAppointmentForTestTypeExisted(_TestType);

			if (IsActiveTestAppointmentForTestTypeExisted && _Mode == enMode.AddNew)
			{
				MessageBox.Show($"There Is An Active Test Appointment Can't Add New One!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnSave.Enabled = false;
				dtpTestDate.Enabled = false;
				return false;
			}

			else
				return true;
		}

		private bool _HandelLockedTestAppointmentConstrain()
		{
			if (_TestAppointmentInfo.IsLocked)
			{
				lblUserMessage.Visible = true;
				lblUserMessage.Text = "Person Has already Sat for this test can't be edited";
				btnSave.Enabled = false;
				dtpTestDate.Enabled = false;
				return false;
			}
			lblUserMessage.Visible = false;
			return true;
		}

		private bool _HandelIsAllowedToTakeTest()
		{
			switch (_TestType)
			{
				case clsTestType.enTestType.VisionTest:
					lblUserMessage.Visible = false;
					return true;

				case clsTestType.enTestType.WrittenTest:
					//check if passed test
					if (!_LDLAppInfo.IsTestPassedByTestTypeAndLocalDrivingLicneseAppID(clsTestType.enTestType.VisionTest))
					{
						lblUserMessage.Text = "Cannot Sechule, Vision Test should be passed first";
						lblUserMessage.Visible = true;
						btnSave.Enabled = false;
						dtpTestDate.Enabled = false;
						return false;
					}

					else
					{
						lblUserMessage.Visible = false;
						btnSave.Enabled = true;
						dtpTestDate.Enabled = true;
						return true;
					}


				case clsTestType.enTestType.StreetTest:
					if (!_LDLAppInfo.IsTestPassedByTestTypeAndLocalDrivingLicneseAppID(clsTestType.enTestType.WrittenTest))
					{
						lblUserMessage.Text = "Cannot Sechule, Written Test should be passed first";
						lblUserMessage.Visible = true;
						btnSave.Enabled = false;
						dtpTestDate.Enabled = false;
						return false;
					}
					else
					{
						lblUserMessage.Visible = false;
						btnSave.Enabled = true;
						dtpTestDate.Enabled = true;
						return true;
					}



				default:
					return false;
			}
		}

		public void LoadData(int LDLAppID, int TestAppointmentID = -1)
		{
			_SetDefaultData();

			clsLocalDrivingLicenseApplication LDLAppInfo = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);


			if (LDLAppInfo == null)
			{
				MessageBox.Show($"This Local Application with ID :{LDLAppID} Has Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnSave.Enabled = false;
				return;
			}

			_LDLAppInfo = LDLAppInfo;
			_LDLAppID = LDLAppID;

			#region IdentifyMode

			if (TestAppointmentID == -1)
			{
				_Mode = enMode.AddNew;
				_TestAppointmentInfo = new clsTestAppointment();
			}

			else
			{
				_Mode = enMode.Update;
				_TestAppointmentID = TestAppointmentID;
				if (!_LoadTestAppointment())
					return;
			}

			//TestType has been set by the form
			if (_LDLAppInfo.DoesAttendedTestByTestType(TestType))
			{
				_CreationMode = enCreationMode.RetakeTestSchedule;
				lblTitle.Text = "Retake Test Schedule";
				gbRetakeTestInfo.Enabled = true;
			}
			else
			{
				_CreationMode = enCreationMode.FirstTimeSchedule;

			}


			#endregion

			#region Fill_LDLAppInfo

			lblLocalDrivingLicenseAppID.Text = _LDLAppInfo.LocalDrivingLicenseApplicationID.ToString();
			lblDrivingClass.Text = _LDLAppInfo.LicenseClassText;
			lblFullName.Text = _LDLAppInfo.ApplicantFullName;
			lblTrial.Text = _LDLAppInfo.GetNumberOfTriesPerTest(_TestType).ToString();

			#endregion



			if (!_HandelActiveTestAppointmentConstrain())
				return;

			if (!_HandelIsAllowedToTakeTest())
				return;

			if (!_HandelLockedTestAppointmentConstrain())
				return;

			_HandelFees();
		}

		//for creating a new application linked to this LDLAPP
		private bool _HandleRetakeApplication()
		{
			if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
			{
				//incase the mode is add new and creation mode is retake test we should create a seperate application for it.
				//then we linke it with the appointment.

				//First Create Application 
				clsApplication Application = new clsApplication();

				Application.ApplicantPersonID = _LDLAppInfo.ApplicantPersonID;
				Application.ApplicationDate = DateTime.Now;
				Application.ApplicationTypeID = enApplicationType.RetakeTest;
				Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
				Application.LastStatusDate = DateTime.Now;
				Application.PaidFees = clsApplicationType.FindApplicationTypeByID(enApplicationType.RetakeTest).ApplicationFees;
				Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

				if (!Application.Save())
				{
					_TestAppointmentInfo.RetakeTestApplicationID = -1;
					MessageBox.Show("Faild to Create application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				_TestAppointmentInfo.RetakeTestApplicationID = Application.ApplicationID;

			}
			return true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!_HandleRetakeApplication())
				return;

			_TestAppointmentInfo.LocalDrivingLicenseApplicationID = Convert.ToInt32(lblLocalDrivingLicenseAppID.Text);

			_TestAppointmentInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
			_TestAppointmentInfo.AppointmentDate = dtpTestDate.Value;
			_TestAppointmentInfo.PaidFees = float.Parse(lblTotalFees.Text);
			_TestAppointmentInfo.TestTypeID = _TestType;


			if (_TestAppointmentInfo.Save())
			{
				MessageBox.Show("Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;

			}
			else
			{
				MessageBox.Show($"Error During Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
	}
}