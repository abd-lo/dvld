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

namespace MY_DVLD.Licenses.Local_Driving_Licenses.Controls
{
	public partial class UCDriverLicenseWithFilter : UserControl
	{
		public UCDriverLicenseWithFilter()
		{
			InitializeComponent();
		}

		public delegate void OnLicenseSelected(clsLicense license);
		public event OnLicenseSelected OnLicenseFound;


		public int LicenseID { get; private set; } = -1;
		public clsLicense LicenseInfo { get; private set; } = null;
		public bool IsFilterEnabled
		{
			get { return txtLicenseID.Enabled; }
			set
			{
				txtLicenseID.Enabled = value;
				btnFind.Enabled = value;
			}
		}
		private void btnFind_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtLicenseID.Text, out int LicenseID))
			{
				MessageBox.Show("Please enter a valid numeric License ID.");
				return;
			}


			LicenseInfo = clsLicense.FindLicenseByID(LicenseID);
			if (LicenseInfo == null)
			{

				MessageBox.Show($"Can't be Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}

			this.LicenseID = LicenseID;

			ucLocalDrivingLicense1.LoadData(LicenseID);
			OnLicenseChecked(LicenseInfo);

		}

		protected virtual void OnLicenseChecked(clsLicense license)
		{

			OnLicenseFound?.Invoke(license);

		}
	}
}
