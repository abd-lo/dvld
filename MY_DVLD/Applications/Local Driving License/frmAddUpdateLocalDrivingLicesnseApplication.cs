using MY_DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;
using MY_DVLD_GlobalClasses;
using MY_DVLD.GlobalClasses;
using MY_DVLD_Business.Enum;

namespace MY_DVLD.Applications.Local_Driving_License
{
	public partial class frmAddUpdateLocalDrivingLicesnseApplication : Form
	{
		#region Vars

		int _PersonID = -1;
		int _LDLAppID = -1;
		clsLocalDrivingLicenseApplication _LDLApp;

		enum enMode { AddNew, Update };
		enMode _Mode;
		#endregion

		public frmAddUpdateLocalDrivingLicesnseApplication()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;
		}

		public frmAddUpdateLocalDrivingLicesnseApplication(int LDLAppID)
		{

			//MessageBox.Show("AddUpdateConstLoad", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

			InitializeComponent();

			_Mode = enMode.Update;
			_LDLAppID = LDLAppID;

		}
		
		private void frmAddUpdateLocalDrivingLicesnseApplication_Load(object sender, EventArgs e)
		{

			//	MessageBox.Show("frmAddUpdateLoadEvent", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

			_ResetDefaultValues();

			if (_Mode == enMode.Update)
			{

				ucPersonCardWithFind1.FilterEnabled = false;
				_LoadData();
			}

			btnSave.Enabled = false;
		}

		private void _IntializeLicenseClassesComboBox()
		{
			DataTable dt = clsLicenseClass.GetAllLicenseClasses();


			cbLicenseClass.DataSource = dt;
			cbLicenseClass.DisplayMember = "ClassName";
			cbLicenseClass.ValueMember = "LicenseClassID";
		}

		private void _ResetDefaultValues()
		{
			_IntializeLicenseClassesComboBox();

			if (_Mode == enMode.AddNew)
			{
				lblTitle.Text = "Add New Local Driving License Application";
				this.Text = "Add New Local Driving License Application";

				tpApplicationInfo.Enabled = false;
				_LDLApp = new clsLocalDrivingLicenseApplication();


				lblApplicationDate.Text = DateTime.Now.ToString();
				clsApplicationType App = clsApplicationType.FindApplicationTypeByID(enApplicationType.NewDrivingLicense);
				lblFees.Text = App.ApplicationFees.ToString();
				lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;

			}
			else
			{


				lblTitle.Text = "Update Local Driving License Application";
				this.Text = "Update Local Driving License Application";
				tpApplicationInfo.Enabled = true;


			}

		}

		private void _LoadData()
		{
			_LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(_LDLAppID);
			if (_LDLApp == null)
			{
				MessageBox.Show($"There Is no Application with this ID{_LDLAppID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			ucPersonCardWithFind1.LoadPerson(_LDLApp.ApplicantPersonID);

			lblLocalDrivingLicebseApplicationID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
			lblApplicationDate.Text = _LDLApp.ApplicationDate.ToString();
			cbLicenseClass.SelectedValue = _LDLApp.LicenseClassID;
			lblFees.Text = _LDLApp.PaidFees.ToString();
			lblCreatedByUser.Text = _LDLApp.UserInfo.Username.ToString();


		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			//_PersonID = ucPersonCardWithFind1.PersonID;
			if (_PersonID == -1)
			{
				MessageBox.Show($"Please Select a Person First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnSave.Enabled = false;
				return;
			}

			tpApplicationInfo.Enabled = true;


			tcApplicationInfo.SelectedTab = tpApplicationInfo;

			btnSave.Enabled = true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int LicenseClassID = Convert.ToInt32(cbLicenseClass.SelectedValue);
			int ApplicationID = -1;

			//Check there is no Active application with Same Class
			bool IsActiveApplicationExisted = (clsApplication.GetActiveApplicationIDForPersonIDAndLicenseClass(ref ApplicationID, _PersonID, LicenseClassID))!=-1;

			if (IsActiveApplicationExisted)
			{
				MessageBox.Show($"There Is Already Existed Application With ID:{ApplicationID} For the Same LicenseClass\n You Have to Choose another LicenseClass or Cancel the old application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			//Check if this person Has this license
			if (clsLicense.IsLicenseExistedForPersonID(_PersonID, LicenseClassID))
			{
				MessageBox.Show($"There Is Already Existed LicenseClass For this Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			_LDLApp.ApplicantPersonID = _PersonID;
			_LDLApp.LicenseClassID = LicenseClassID;
			_LDLApp.ApplicationStatus = clsApplication.enApplicationStatus.New;
			_LDLApp.ApplicationTypeID = enApplicationType.NewDrivingLicense;
			_LDLApp.ApplicationDate = DateTime.Now; 
			_LDLApp.LastStatusDate = DateTime.Now;
			_LDLApp.CreatedByUserID = clsUser.FindUserByUsername(lblCreatedByUser.Text).UserID;
			_LDLApp.PaidFees = Convert.ToSingle(lblFees.Text);

			if (_LDLApp.Save())
			{
				lblTitle.Text = "Update Local Driving License Application";
				this.Text = "Update Local Driving License Application";
				lblLocalDrivingLicebseApplicationID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();

				MessageBox.Show("Saved Sucessfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

				_Mode = enMode.Update;
			}
			else

				MessageBox.Show($"ErrorSaving Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void ucPersonCardWithFind1_OnPersonSelectedEvent(int obj)
		{
			_PersonID = obj;
		}
	}
}
