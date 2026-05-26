using MY_DVLD.Properties;
using MY_DVLD_Business;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Licenses.Local_Driving_Licenses.Controls
{
	public partial class UCLocalDrivingLicense : UserControl
	{
		public UCLocalDrivingLicense()
		{
			InitializeComponent();
		}

		private int _LicenseID;
		private clsLicense _License;


		public clsLicense License { get { return _License; } }
		public int LicenseID { get { return _LicenseID; } }


		private void _ResetDefaultValues()
		{
			lblIsDetained.Text = "[???]";
			lblIssueReason.Text = "[???]";
			lblIsActive.Text = "[???]";
			lblFullName.Text = "[???]";
			lblClass.Text = "[???]";
			lblExpirationDate.Text = "[???]";
			lblDriverID.Text = "[???]";
			lblDateOfBirth.Text = "[???]";
			lblGender.Text = "[???]";
			lblNotes.Text = "[???]";
			lblIssueDate.Text = "[???]";
			lblNationalNo.Text = "[???]";
			lblLicenseID.Text = "[???]";
		}

		private void _FillData()
		{
			_LicenseID = LicenseID;
			_LoadImage();

			lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";
			lblIssueReason.Text = _License.IssueReasonText;
			lblIsActive.Text = _License.IsActive ? "Yes" : "No";
			lblFullName.Text = _License.DriverInfo.PersonInfo.FullName;
			lblClass.Text = _License.LicenseClassInfo.ClassName;
			lblExpirationDate.Text = _License.ExpirationDate.ToString();
			lblDriverID.Text = _License.DriverID.ToString();
			lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString();
			lblGender.Text = _License.DriverInfo.PersonInfo.GenderText;
			lblNotes.Text = _License.Notes;
			lblIssueDate.Text = _License.IssueDate.ToString();
			lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
			lblLicenseID.Text = _License.LicenseID.ToString();

		}

		private void _LoadImage()
		{
			string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;
			bool IsMale = (_License.DriverInfo.PersonInfo.GenderText == "Male");
			pbPersonImage.Image = IsMale ? Resources.Male_512 : Resources.Female_512;

			if (ImagePath != null && File.Exists(ImagePath))
			{
				pbPersonImage.ImageLocation = ImagePath;
			}

		}

		public void LoadData(int LicenseID)
		{
			_License = clsLicense.FindLicenseByID(LicenseID);

			if (_License == null)
			{

				MessageBox.Show($"Can't Find License With LicenseID with{LicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_ResetDefaultValues();
				return;
			}

			_FillData();

		}




	}
}
