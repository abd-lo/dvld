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
using static MY_DVLD_Business.clsTestType;

namespace MY_DVLD.Tests
{
	public partial class frmListTestAppointment : Form
	{
		int _LDLAppID;
		clsTestType.enTestType _TestType;
		clsLocalDrivingLicenseApplication _LDLAppInfo;

		public frmListTestAppointment(int LDLAppID, clsTestType.enTestType TestType)
		{
			InitializeComponent();
			_LDLAppID = LDLAppID;
			_TestType = TestType;
		}


		private void _Set_RefreshData()
		{
			ucApplicationInfoWithLocalDrivingLicenseAppInfo1.LoadData(_LDLAppID);
			_LDLAppInfo = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(_LDLAppID);
			_LoadTestAppointments();
			_SetTitleAndImage();
		}

		private void frmListTestAppointment_Load(object sender, EventArgs e)
		{
			_Set_RefreshData();
		}


		private void _SetTitleAndImage()
		{
			switch (_TestType)
			{
				case clsTestType.enTestType.VisionTest:
					lblTitle.Text = "Vision Test Appointments";
					pbTestTypeImage.Image = Properties.Resources.Vision_512;
					break;

				case clsTestType.enTestType.WrittenTest:
					pbTestTypeImage.Image = Properties.Resources.Written_Test_512;
					lblTitle.Text = "Written Test Appointments";
					break;

				case clsTestType.enTestType.StreetTest:
					pbTestTypeImage.Image = Properties.Resources.Street_Test_32;
					lblTitle.Text = "Street Test Appointments";
					break;

				default:
					break;
			}
		}

		private void _LoadTestAppointments()
		{
			DataTable dt = clsTestAppointment.GetAllTestAppointmentsForLDLAppIDAndTestType(_LDLAppInfo.LocalDrivingLicenseApplicationID, _TestType);

			if (dt.Rows.Count != 0)
			{

				DataView view = new DataView(dt);

				DataTable SelectedColumns = view.ToTable(
					false,
					"TestAppointmentID",
					"AppointmentDate",
					"PaidFees",
					"IsLocked"
				);
				dgvTestAppointments.DataSource = SelectedColumns;
				lblRecordsCount.Text = dgvTestAppointments.RowCount.ToString();

			}
		}

		private void btnAddTestAppointment_Click(object sender, EventArgs e)
		{
			//Check if it has an Appointment and not locked(test is not taken yet)
			bool IsActiveTestAppointmentExisted = _LDLAppInfo.IsActiveTestAppointmentForTestTypeExisted(_TestType);

			if (IsActiveTestAppointmentExisted)
			{
				MessageBox.Show($"TestAppointment is Already Existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			//Check if the test has been passed previously
			clsTest PrevTest = _LDLAppInfo.GetLastTestByTestType(_TestType);

			if (PrevTest != null && PrevTest.TestResult == true)
			{
				MessageBox.Show($"This Test Has Been Passed earlier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			frmScheduleTest frm = new frmScheduleTest(_LDLAppID, _TestType);
			frm.ShowDialog();
			//Refresh DataGridView
			_LoadTestAppointments();

		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int TestAppointment = Convert.ToInt32(dgvTestAppointments.CurrentRow.Cells[0].Value);


			frmScheduleTest frm = new frmScheduleTest(_LDLAppID, _TestType, TestAppointment);
			frm.ShowDialog();
			_LoadTestAppointments();
		}

		private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int TestAppointment = Convert.ToInt32(dgvTestAppointments.CurrentRow.Cells[0].Value);
			frmTakeTest frm = new frmTakeTest(_LDLAppID, _TestType, TestAppointment);
			frm.ShowDialog();
			//refresh data after Taking a Test or Editing a TestAppointment
			_LoadTestAppointments();
		}
	}
}
