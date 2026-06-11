using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Licenses.International_Licenses
{
	public partial class frmShowInternationalLicenseInfo : Form
	{
		int _InLicenseID;
		public frmShowInternationalLicenseInfo(int InLicenseID)
		{
			InitializeComponent();
			_InLicenseID = InLicenseID;
		}

		private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
		{
			ucInternationalDriverLicense1.LoadData(_InLicenseID);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
