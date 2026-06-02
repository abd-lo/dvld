using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Licenses
{
	public partial class frmShowDrivingLicenseHistory : Form
	{
		int _PersonID = -1;

		public frmShowDrivingLicenseHistory()
		{
			InitializeComponent();
		}

		public frmShowDrivingLicenseHistory(int PersonID)
		{
			InitializeComponent();
			_PersonID = PersonID;
		}

		private void frmShowDrivingLicenseHistory_Load(object sender, EventArgs e)
		{
			if (_PersonID != -1)
			{
				ucDriverLicenses1.LoadData(_PersonID);
				ucPersonCardWithFind1.LoadPerson(_PersonID);
				ucPersonCardWithFind1.FilterEnabled = false;
			}
		}

		private void ucPersonCardWithFind1_OnPersonSelectedEvent(int obj)
		{
			_PersonID = obj;

			if (_PersonID != -1)
				ucDriverLicenses1.LoadData(_PersonID);

			else
				ucDriverLicenses1.Clear();
		}
	}
}
