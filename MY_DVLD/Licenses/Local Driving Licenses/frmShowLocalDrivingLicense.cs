using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Licenses.Local_Driving_Licenses
{
	public partial class frmShowLocalDrivingLicense : Form
	{
		int _LicenseID;
		public frmShowLocalDrivingLicense(int LicneseID)
		{
			InitializeComponent();
			_LicenseID = LicneseID;	
		}

		private void frmShowLocalDrivingLicense_Load(object sender, EventArgs e)
		{
			ucLocalDrivingLicense1.LoadData(_LicenseID);
		}
	}
}
