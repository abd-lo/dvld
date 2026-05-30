using MY_DVLD.GlobalClasses;
using MY_DVLD.Licenses.Local_Driving_Licenses;
using MY_DVLD.Tests;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MY_DVLD.Applications.Local_Driving_License
{
	public partial class frmListLocalDrivingLicenseApplications : Form
	{
		public frmListLocalDrivingLicenseApplications()
		{
			InitializeComponent();
		}
		DataTable _dtLocalDrivingLicenseApplications;

		//	LocalDrivingLicenseApplicationID ClassName   NationalNo FullName    ApplicationDate PassedTestCount Status
		private void _IntializeStatusComboBox()
		{
			cbStatus.Items.Add("All");
			cbStatus.Items.Add("Completed");
			cbStatus.Items.Add("Cancelled");
			cbStatus.Items.Add("New");
			cbStatus.SelectedIndex = 0;

			cbStatus.Visible = false;
		}

		private void _IntializeFilterByComboBox()
		{
			//	DataTable dt = clsLicenseClass.GetAllLicenseClasses();
			////	LicenseClassID ClassName;

			//	cbFilterBy.DataSource = dt;

			cbFilterBy.Items.Add("None");
			cbFilterBy.Items.Add("L.D.L ApplicationID");
			cbFilterBy.Items.Add("Class Name");
			cbFilterBy.Items.Add("National No");
			cbFilterBy.Items.Add("FullName");
			cbFilterBy.Items.Add("ApplicationDate");
			cbFilterBy.Items.Add("Passed Test Count");
			cbFilterBy.Items.Add("Status");

			cbFilterBy.SelectedIndex = 0;
		}

		private void _IntializeDataGridView()
		{
			if (dgvLocalDrivingLicenseApplications.RowCount <= 0)
				return;


			var columnSettings = new[]
			{
			new { Name = "LocalDrivingLicenseApplicationID",  Header = "L.D.L.ApplicationID", Weight = 30  },
			new { Name = "ClassName",       Header = "ClassName",       Weight = 70  },
			new { Name = "NationalNo",      Header = "National No", Weight = 40 },
			new { Name = "FullName",        Header = "FullName",        Weight = 110  },
			new { Name = "ApplicationDate", Header = "ApplicationDate", Weight = 50 },
			new { Name = "PassedTestCount", Header = "PassedTestCount", Weight = 30 },
			new { Name = "Status",          Header = "Status", Weight = 30 }
			};

			foreach (var col in columnSettings)
			{
				var column = dgvLocalDrivingLicenseApplications.Columns[col.Name];
				column.HeaderText = col.Header;
				column.FillWeight = col.Weight;
			}

			dgvLocalDrivingLicenseApplications.DataSource = _dtLocalDrivingLicenseApplications;

			dgvLocalDrivingLicenseApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvLocalDrivingLicenseApplications.AllowUserToResizeColumns = true;

			//dgvLocalDrivingLicenseApplications.Columns.Clear();



		}

		private void _UpdateRecordsNo()
		{
			lbRecordsNO.Text = dgvLocalDrivingLicenseApplications.RowCount.ToString();
		}

		private void _RefreshData()
		{
			_dtLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
			//ReAssign DataGridView Instance to The New DataTable
			dgvLocalDrivingLicenseApplications.DataSource = _dtLocalDrivingLicenseApplications;
			_UpdateRecordsNo();
		}

		private void frmListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
		{
			_RefreshData();
			_IntializeDataGridView();
			_IntializeFilterByComboBox();
			_IntializeStatusComboBox();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		string _GetFilterByTrimmedString()
		{
			string SelectedText = cbFilterBy.SelectedItem?.ToString();

			//LocalDrivingLicenseApplicationID

			if (SelectedText == "L.D.L ApplicationID")
				SelectedText = "LocalDrivingLicenseApplicationID";

			string SelectedTextTrimmed = clsUtil.TrimSpaces(SelectedText);

			return SelectedTextTrimmed;
		}

		void _SetFilterControlsVisibility(string SelectedFilterTrimmed)
		{
			txtFilterValue.Visible = !(SelectedFilterTrimmed == "None") && !(SelectedFilterTrimmed == "Status");
			cbStatus.Visible = (SelectedFilterTrimmed == "Status");
		}

		private void _ApplyUserFilter()
		{
			string SelectedFilter = cbFilterBy.SelectedItem?.ToString();

			if (SelectedFilter == null)
				return;

			SelectedFilter = _GetFilterByTrimmedString();
			string UserInputString = txtFilterValue.Text.Trim();
			string SelectedStatus = cbStatus.Text.Trim();

			_SetFilterControlsVisibility(SelectedFilter);


			bool IsValueEmptyORNone = (UserInputString == "" || SelectedFilter == "None");
			bool IsStatusSelected = (SelectedFilter == "Status");

			if (IsValueEmptyORNone && !IsStatusSelected)
			{
				_dtLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
				_UpdateRecordsNo();
				return;
			}

			if (SelectedFilter == "Status")
			{
				if (SelectedStatus == "All")
					_dtLocalDrivingLicenseApplications.DefaultView.RowFilter = "";


				else
					_dtLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", SelectedFilter, SelectedStatus);


				_UpdateRecordsNo();
				return;
			}


			switch (SelectedFilter)
			{
				case "LocalDrivingLicenseApplicationID":
				case "PassedTestCount":
					_dtLocalDrivingLicenseApplications.DefaultView.RowFilter = $"[{SelectedFilter}]={UserInputString}";
					break;

				default:
					_dtLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", SelectedFilter, UserInputString);
					break;
			}

			_UpdateRecordsNo();
		}

		private void ApplyFilterEventHandler(object sender, EventArgs e)
		{
			_ApplyUserFilter();
		}

		private void btnAddNewApplication_Click(object sender, EventArgs e)
		{
			frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication();
			frm.ShowDialog();
			_RefreshData();
		}

		private void EditApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication(LDLID);
			frm.ShowDialog();
			_RefreshData();
		}

		private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLID);
			if (LDLApp.DeleteLocalDrivingLicenseApplication())
			{

				MessageBox.Show("Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_RefreshData();
			}
			else

				MessageBox.Show($"Failed To Delete ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


		}

		private void CancelApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLID);

			if (LDLApp == null)
			{
				MessageBox.Show($"ApplicationHasNotFound", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (LDLApp.UpdateStatus(clsApplication.enApplicationStatus.Cancelled))
			{
				MessageBox.Show($"Can't Be Canclled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_RefreshData();
		}

		private void showApplicationInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLID);

			if (LDLApp == null)
			{
				MessageBox.Show($"Failed To Find This Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			frmShowApplicationInfo frm = new frmShowApplicationInfo(LDLApp.LocalDrivingLicenseApplicationID);

			frm.ShowDialog();
			_RefreshData();
		}

		private void cmsApplications_Opening(object sender, CancelEventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLID);

			clsApplication.enApplicationStatus AppStatus = LDLApp.ApplicationStatus;
			byte PassedTestsCount = Convert.ToByte(dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value);
			bool LicenseExisted = clsLicense.IsLicenseExistedForPersonID(LDLApp.ApplicantPersonID, LDLApp.LicenseClassID);

			editApplicationToolStripMenuItem.Enabled = (AppStatus == clsApplication.enApplicationStatus.New && !LicenseExisted);
			deleteApplicationToolStripMenuItem.Enabled = AppStatus == clsApplication.enApplicationStatus.New;
			ScheduleTestsMenue.Enabled = (AppStatus == clsApplication.enApplicationStatus.New);
			cancelApplicaitonToolStripMenuItem.Enabled = (AppStatus == clsApplication.enApplicationStatus.New);
			issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (PassedTestsCount == 3) && !LicenseExisted;
			showLicenseToolStripMenuItem.Enabled = LicenseExisted;


			bool IsVissionTestPassed = LDLApp.IsTestPassedByTestTypeAndLocalDrivingLicneseAppID(clsTestType.enTestType.VisionTest);
			bool IsWrittenTestPassed = LDLApp.IsTestPassedByTestTypeAndLocalDrivingLicneseAppID(clsTestType.enTestType.WrittenTest);
			bool IsStreetTestPassed = LDLApp.IsTestPassedByTestTypeAndLocalDrivingLicneseAppID(clsTestType.enTestType.StreetTest);

			scheduleVisionTestToolStripMenuItem.Enabled = !IsVissionTestPassed;
			scheduleWrittenTestToolStripMenuItem.Enabled = !IsWrittenTestPassed && IsVissionTestPassed;
			scheduleStreetTestToolStripMenuItem.Enabled = !IsStreetTestPassed && IsWrittenTestPassed && IsVissionTestPassed;





		}

		private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLID);

			int LicenseID = LDLApp.GetActiveLicenseForPersonIDAndLicenseClass();

			if (LicenseID == -1)
			{
				MessageBox.Show($"Error Finding This License With LicenseID{LicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			frmShowLocalDrivingLicense frm = new frmShowLocalDrivingLicense(LicenseID);
			frm.ShowDialog();

		}

		private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			frmListTestAppointment frm = new frmListTestAppointment(LDLID, clsTestType.enTestType.VisionTest);
			frm.ShowDialog();
			_RefreshData();
		}

		private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			frmListTestAppointment frm = new frmListTestAppointment(LDLID, clsTestType.enTestType.WrittenTest);
			frm.ShowDialog();
			_RefreshData();
		}

		private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			frmListTestAppointment frm = new frmListTestAppointment(LDLID, clsTestType.enTestType.StreetTest);
			frm.ShowDialog();
			_RefreshData();
		}

		private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
			frmIssueLocalDrivingLicense frm = new frmIssueLocalDrivingLicense(LDLID);
			frm.ShowDialog();
			_RefreshData();
		}
	}
}
