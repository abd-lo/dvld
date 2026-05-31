using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Drivers
{
	public partial class frmShowPersonInfo : Form
	{
		int _PersonID;
		public frmShowPersonInfo(int PersonID)
		{
			InitializeComponent();
			_PersonID = PersonID;
		}

		private void frmShowPersonInfo_Load(object sender, EventArgs e)
		{
			ucPersonCard1.LoadPersonData(_PersonID);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
