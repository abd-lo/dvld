using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Applications.Local_Driving_License
{
	public partial class frmShowApplicationInfo : Form
	{
		int _LDLAppID;
		public frmShowApplicationInfo(int LDLAppID)
		{
			InitializeComponent();
			_LDLAppID = LDLAppID;
		}

		private void frmShowApplicationInfo_Load(object sender, EventArgs e)
		{
			ucApplicationInfoWithLocalDrivingLicenseAppInfo1.LoadData(_LDLAppID);
		}
	}
}
