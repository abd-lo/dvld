using MY_DVLD.Properties;
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
using System.IO;
namespace MY_DVLD.Licenses.International_Licenses.Controls
{
	public partial class UCInternationalDriverLicense : UserControl
	{
		public UCInternationalDriverLicense()
		{
			InitializeComponent();
		}

		public clsInternationalLicense InLicense { get; private set; } = null;
		public int InLicenseID { get; private set; } = -1;

		private void _LoadPersonImage()
		{
			if (InLicense.DriverInfo.PersonInfo.Gender == 0)
				pbPersonImage.Image = Resources.Male_512;
			else
				pbPersonImage.Image = Resources.Female_512;

			string ImagePath = InLicense.DriverInfo.PersonInfo.ImagePath;

			if (ImagePath != "")
				if (File.Exists(ImagePath))
					pbPersonImage.Load(ImagePath);
				else
					MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}


		public void LoadData(int IntLicense)
		{
			clsInternationalLicense IL = clsInternationalLicense.FindInternationalLicenseByID(IntLicense);
			if (IL == null)
			{
				MessageBox.Show($"Int License with ID {IL.InternationalLicenseID} is not existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			InLicense = IL;

			lblInternationalLicenseID.Text = InLicense.InternationalLicenseID.ToString();
			lblApplicationID.Text = InLicense.ApplicationID.ToString();
			lblIsActive.Text = InLicense.IsActive ? "Yes" : "No";
			lblLocalLicenseID.Text = InLicense.IssuedUsingLocalLicenseID.ToString();
			lblFullName.Text = InLicense.DriverInfo.PersonInfo.FullName;
			lblNationalNo.Text = InLicense.DriverInfo.PersonInfo.NationalNo;
			lblGendor.Text = InLicense.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
			lblDateOfBirth.Text = InLicense.DriverInfo.PersonInfo.DateOfBirth.ToString("d");

			lblDriverID.Text = InLicense.DriverID.ToString();
			lblIssueDate.Text = InLicense.IssueDate.ToString("d");
			lblExpirationDate.Text = InLicense.ExpirationDate.ToString("d");

			_LoadPersonImage();
		}

	}
}
